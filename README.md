# Lemniscate


**Before downloading**: Lemniscate shows up as a virus in antiviruses such as AVG, Bitdefender, and a couple more. Please note that Lemniscate is *not* a virus and these antiviruses are showing [false positives](http://www.howtogeek.com/180162/how-to-tell-if-a-virus-is-actually-a-false-positive/). If you feel that you don't want to download this file, you are free to look through the source code, copy it and run it as your own. 

*download: http://104.236.233.37/lemniscate/* [SAFE]

*virustotal link:* https://www.virustotal.com/en/file/777c224033f2372bc1c56c8804555f92831e71344281d7430cd282512525fe3e/analysis/1428794596/





Lemniscate is a simple chat server and client written in Python and C#. The server is written in Python and the client is written in C#. Soon to also be written in node.js (web version!) and C# OSX compatible.

![alt tag](http://i.imgur.com/fhLf6FS.png)

**How to set up the server::**

Run the server.py file. The program should automatically create `config.txt` and `banlist.txt`. Once created, your server will be running on the 127.0.0.1 : 1338. You can use this oppertunity to test out the server. If you'd like to configure it so other people can connect to your server, [portforward a port](http://www.wikihow.com/Set-Up-Port-Forwarding-on-a-Router), fill in your [ipv4 address](http://i.imgur.com/dqW4wHL.png) and opened port in `config.txt`. 

**Server commands:**

```ban [name]``` IP bans the player. Stores IP in banlist.txt (auto-generated). Can easily unban by removing the user assigned IP.

```broadcast [message]``` Broadcasts a message to everyone in the server

```users``` Lists the users in the chatroom


**Client commands:**

**/quit**: Instantly disconnects from the server and exits out the client.

**/pm [name]**: *[case sensitive!]* Invokes a private chatting session with the specified name.




*by Nigel Chen 2015*
