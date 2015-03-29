import java.io.IOException;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.Scanner;

import javax.swing.JOptionPane;


public class Main implements Runnable{
	static String name = null;
	
	public void run() {
		PrintWriter out = null;
		try {
			System.out.println("!");
			out = new PrintWriter(Main.s.getOutputStream());
		} catch (IOException e) {
			e.printStackTrace();
		}
		while (true) {
			System.out.println("?");
			if (GUI.enter) {
				System.out.println("!");
				if (GUI.text.equals("/quit")) {
					System.exit(0);
				}
				else {
				out.print(GUI.text);
				out.flush();
				GUI.enter = false;
				}
			}
			/*if (x.equals("/quit")) {
				System.out.println("Disconnected from server");
				System.exit(0);
			}
			out.print(x);
			out.flush();*/
		}
	}
	public static void runThread() {
		Main main = new Main();
		Thread thr = new Thread(main);
		thr.start();
	}
	public static Socket s;
	public static String host = "localhost";
	public static int port = 25565;
	public static void listener() throws IOException {
		try {
			s = new Socket(host,port);
			
		} catch (Exception e) {
			GUI.textArea.append("**CANNOT CONNECT TO " + host+":"+port+"!\n");
		}
		while (true) {
			GUI.textArea.append("Welcome to " + host + ".\n");
			name = JOptionPane.showInputDialog("Enter your name!");
			if (name==null||name.equals(" ")) {
				JOptionPane.showMessageDialog(null, "Invalid name!");
			}
			else {
				break;
			}
		}
		PrintWriter out = new PrintWriter(s.getOutputStream());
		out.print(name);
		out.flush();
		Main x = new Main();
		Thread t1 = new Thread(x);
		t1.start();
		Listen.threadRun();
		
		if (!t1.isAlive()) {
			s.close();
		}
		System.exit(0);
	}
}
