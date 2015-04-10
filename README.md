# Lemniscate

*download: http://104.236.233.37/lemniscate/*


Lemniscate is a simple chat server and client written in Python and C#. The server is written in Python and the client is written in C#. Soon to also be written in node.js (web version!) and C# OSX compatible.

![alt tag](http://i.imgur.com/aDOV5Dg.png)

**How to set up the server::**

The server is preconfigured to start with "10.0.1.25" with the port "1337". Be sure to change the host to your ipv4 address and the port to anything you want- as long as it's port forwarded.

To get the ipv4 address of your computer, type in "ipconfig" into cmd. Search for your ipv4 address there.

**Client:**
```
	host = '10.0.1.25' #Your ipv4 address goes here.
	port = 1337 #Your port goes here. (has to be port forwarded)
```

**Server commands:**

```ban [name]``` IP bans the player. Stores IP in banlist.txt (auto-generated). Can easily unban by removing the user assigned IP.

```broadcast [message]``` Broadcasts a message to everyone in the server

```users``` Lists the users in the chatroom


**Client commands:**

**/quit**: Instantly disconnects from the server and exits out the client.

**/pm [name]**: *[case sensitive!]* Invokes a private chatting session with the specified name.



**TODO LIST**

~~- Make a fully functional graphical user interface~~


~~- Spam filter~~


~~- Private chatting~~


~~-IP banning~~


~~- Switch client over to C#~~


- File transfer
- Settings for client
- Make a C# OSX safe version of the client
- MAC Address logging. (Safer ban system)
- **Make a global chat through VPS. [WORKING ON!]**
- Encryption
- Flood bot protection
- Users can make own server from the GUI easily.

*by Nigel Chen 2015*
