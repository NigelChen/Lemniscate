# Lemniscate

*download: http://104.236.233.37/lemniscate/*


Lemniscate is a simple chat server and client written in Python and Java. The server is written in Python and the client is written in Java. Soon to be written in node.js (web version!). The final result of the project will have a finished GUI and does not require you to go into the code and change everything.

![alt tag](http://i.imgur.com/OYsHWdh.png)

**How to set up server/client to connect to the internet:**

*The code is preconfigured to start with "localhost". This should work fine on your computer, but nobody can connect to it except for you. To change it, follow the tutorial below:*
- Step 1: Port forward your port (can be any! 25565 is the default port for the chat client).:
- Step 2: Change the server's host to your ipv4 address and the client's host to your public IP address.

*Get your ipv4 address by typing in "ipconfig" in cmd and get your public IP address by going to http://ipchicken.com.*

**Server:**
```
host = '10.0.1.25' #ipv4 address goes here!
port = 25565 #Your forwarded port goes here!
```

**Client:**
```
	public static String host = "198.23.103.81"; //Your public IP address goes here!
	public static int port = 25565; //Your forwarded port goes here!
```

- Step 3: Well, there's no step 3. You're done. Launch it and have fun!

**TODO LIST**

~~- Make a fully functional graphical user interface~~
- Spam filter
- Encryption
- Bot protection
- Users can make own server from the GUI easily.
- Make a global chat through VPS.

*by Nigel Chen 2015*
