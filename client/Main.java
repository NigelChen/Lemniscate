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
			out = new PrintWriter(Main.s.getOutputStream());
		} catch (IOException e) {
			e.printStackTrace();
		}
		while (true) {
			Scanner ins = new Scanner(System.in);
			String x = ins.nextLine();
			if (x.equals("/quit")) {
				System.out.println("Disconnected from server");
				System.exit(0);
			}
			out.print(x);
			out.flush();
		}
	}
	public static Socket s;
	public static String host = "localhost";
	public static int port = 25565;
	public static void main(String[] args) throws IOException {
		Scanner input = new Scanner(System.in);
		try {
			s = new Socket(host,port);
			
		} catch (Exception e) {
			System.out.println("**CANNOT CONNECT TO " + host+":"+port+"!");
		}
		while (true) {
			System.out.println("Welcome to " + host+ ".");
			name = JOptionPane.showInputDialog("Enter your name!");
			if (name==null||name.equals(" ")) {
				System.out.println("Invalid name");
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
