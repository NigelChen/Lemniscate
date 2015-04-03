import socket, threading,time, os.path

host = '10.0.1.25'
port = 1337

s = socket.socket()
repeat = 0.4
s.bind((host,port))
print '** SERVER IS UP ONLINE ** IP: ' + str(socket.gethostbyname(socket.gethostname()))
s.listen(5)
users = []
rawNames = []
repeatNums = []
#userNames (USERNAME => SOCKET)
userNames = {}
#SocketNames (SOCKET => USERNAME)
socketNames= {}
beginTime = -1
bans = []
spamTime = 0
spamLimit = 17
firstTime = True

def stripJunk(inn):
    x = list(inn)
    x[1]=''
    y = str(x)
    print y
    return y

def sendMessage(input,person):
    global users
    if type(person) is str:
        for i in range (0,len(users)):
            users[i].send('** '+input+' **')
    else:
        for i in range (0,len(users)):
            users[i].send(userNames[person]+': ' + input)

def ban(name):
    global bans
    f = open('banlist.txt','w')
    f.write(socketNames[name])
    f.write('\n')
    f.write('#'+name)
    sendMessage(name + ' has been banned','s')
    bans.append(name)
    f.close()
def userUpdate():
    global userNames
    global rawNames
    global users
    for i in range (0,len(users)):
        users[i].send('userUpdate')
    time.sleep(0.2)
    for i in range (0,len(rawNames)):
        for j in range (0,len(rawNames)):
            users[i].send(rawNames[j])
            time.sleep(0.03)
    time.sleep(0.3)
    for i in range (0,len(users)):
        users[i].send('stop')
def commandThread(connection,):
    global stopped
    global users
    while 1:
        x = raw_input('')
        if x.upper() == 'USERS':
            print str(len(users)) + ' user(s) in the chatroom.'
            for i in range (len(users)):
                print rawNames[i]
        elif x.upper() == 'BROADCAST':
            y = raw_input('->')
            sendMessage(y,'fd')
        elif x.upper() =='BAN':
            y = raw_input('BAN->')
            ban(y)
x = threading.Thread(target=commandThread,args=(s,))
x.start()
def listenThread(connection,n):
    global users
    global spamTime
    global beginTime
    global stopped
    global userNames
    global spamLimit
    global firstTime
    spam = 0
    while 1:
        if not firstTime:
            spamTime = time.time()-beginTime
        try:
            #Spam filter
            if firstTime:
                beginTime = time.time()
                data = connection.recv(1024)
                spam +=1
                print userNames[connection] + ': ' + data
                for i in range(0,len(users)):
                    users[i].send(userNames[connection] + ': ' + data)
                firstTime=False
            elif spamTime > 5 and spam < spamLimit:
                spamTime = 0
                spam = 0
                firstTime = True
            elif (spamTime >= 5 and spam > spamLimit or spam > spamLimit):
                print 'Muted ' + userNames[connection]
                print '------------------------'
                print str(spam) + ' messages in ' + str(spamTime) + ' seconds.'
                connection.send('You have been muted for 10 seconds.')
                time.sleep(10)
                firstTime = True
                spamTime = 0
                spam  = 0
            else:

                data = connection.recv(1024)
                if n in bans:
                    c.send('You are BANNED from the server!')
                    rawNames.remove(n)
                    users.remove(connection)
                    userNames.pop(connection, None)
                    userUpdate()
                    break
                spam +=1
                print userNames[connection] + ': ' + data
                sendMessage(data,connection)
        except:
            #client disconnected. Removes all traces of user from server.
            users.remove(connection)
            print userNames[connection] + ' disconnected from the server.'
            for i in range (0,len(users)):
                users[i].send(userNames[connection] + ' disconnected from the server.\n')
            rawNames.remove(n)
            userNames.pop(connection, None)
            userUpdate()
            break

while 1:
    while 1:
        banned = False
        if not os.path.exists('banlist.txt'):
            open('banlist.txt','a')
            print 'Creating banlist...'
        c,addr = s.accept()
        #Check if user is in banlist
        f = open('banlist.txt','r')
        for line in f:
            if '#' in line:
                pass
            elif stripJunk(addr) in line:
                c.send('You are BANNED from the server.')
                banned = True
        #does this if NOT banned. Otherwise, continue.
        if not banned:
            break
        else:
            continue
    name = c.recv(1024)
    print addr
    f.close()
    if name in rawNames:
        name = name + str(repeat)
        c.send('Someone else already has the same name as you. Your new name is now ' + name)
        repeat *= 2
    else:
        c.send('Welcome to the server, ' + name)
    print str(name) + ' has joined the server :: ' + str(addr)
    for i in range (0,len(rawNames)):
        users[i].send(str(name) + ' has joined the server!')
    #user joined - adds user's info into a list
    rawNames.append(name)
    users.append(c)
    userNames[c]=name
    socketNames[name] = stripJunk(addr)
    #start user's personal thread
    userUpdate()
    y = threading.Thread(target=listenThread,args=(c,name))
    y.start()
s.close()
