import java.io.IOException;
import java.io.PrintWriter;
import java.net.Socket;

import javax.swing.JOptionPane;

public class Main implements Runnable {
	static String name = null;

	public void run() {
		PrintWriter out = null;
		try {
			out = new PrintWriter(Main.s.getOutputStream());
		} catch (IOException e) {
			e.printStackTrace();
		}
		while (true) {
			if (GUI.enter) {
				if (GUI.text.equals("/quit")) {
					System.exit(0);
				} else {
					out.print(GUI.text);
					out.flush();
					GUI.enter = false;
				}
			} else {
				System.out.print("");
			}
		}
	}

	public static void runThread() {
		Main main = new Main();
		Thread thr = new Thread(main);
		thr.start();
	}

	public static Socket s;
	public static String host = GUI.ownHost;
	public static boolean cantConnect = false;
	public static int port = GUI.ownPort;

	public static void listener() throws IOException {
		try {
			s = new Socket(host, port);

		} catch (Exception e) {
			GUI.textArea.append("\n**CANNOT CONNECT TO " + host + ":" + port
					+ "!\n");
			GUI.textArea
					.append("\nRestart the program to connect to a different server or retry.");
			cantConnect = true;
		}
		while (true) {
			if (cantConnect) {
				break;
			}
			name = JOptionPane.showInputDialog("Enter your name!");
			if (name == null || name.equals(" ")) {
				JOptionPane.showMessageDialog(null, "Invalid name!");
			} else {
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