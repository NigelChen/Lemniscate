import socket, threading

host = 'localhost'
port = 25565
s = socket.socket()
repeat = 0.4
s.bind((host,port))
print '** SERVER IS UP ONLINE ** IP: ' + host
s.listen(5)
users = []
rawNames = []
repeatNums = []
userNames = {}
stopped = False
def commandThread(connection,):
    global stopped
    global users
    while 1:
        x = raw_input('')
        if x.upper() == 'STOP':
            quit()
        elif x.upper() == 'USERS':
            print str(len(users)) + ' user(s) in the chatroom.'
            for i in range (len(users)):
                print rawNames[i]
        elif x.upper() == 'BROADCAST':
            y = raw_input('->')
            for i in range (0,len(users)):
                try:
                    users[i].send('SERVER: ' + y)
                except:
                    pass
x = threading.Thread(target=commandThread,args=(s,))
x.start()
def listenThread(connection,n):
    global users
    global stopped
    global userNames
    while 1:
        if stopped:
            print 'aa'
            break
        else:
            try:
                data = connection.recv(1024)
                print userNames[connection] + ': ' + data
                for i in range(0,len(users)):
                    users[i].send(userNames[connection] + ': ' + data)
            except:
                users.remove(connection)
                print userNames[connection] + ' disconnected from the server.'
                for i in range (0,len(users)):
                    users[i].send(userNames[connection] + ' disconnected from the server.\n')
                rawNames.remove(n.upper())
                break

while 1:
    c,addr = s.accept()
    name = c.recv(1024)
    print rawNames
    if name.upper() in rawNames:
        name = name + str(repeat)
        c.send('Someone else already has the same name as you. Your new name is now ' + name)
        repeat *= 2
    else:
        c.send('Welcome to the server, ' + name)
    print str(name) + ' has joined the server :: ' + str(addr)+'\n'
    rawNames.append(name.upper())
    for i in range (0,len(users)):
        users[i].send(str(name) + ' has joined the server :: ' + str(addr)+'\n')
    users.append(c)
    userNames[c] = name
    y = threading.Thread(target=listenThread,args=(c,name))
    y.start()
s.close()
