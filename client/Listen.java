import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Listen implements Runnable {
	private static boolean stop = false;

	public void run() {
		boolean clear = false;
		while (true) {
			try {
				BufferedReader inFromServer = new BufferedReader(
						new InputStreamReader(Main.s.getInputStream()));
				char cbuf[] = new char[1024];
				inFromServer.read(cbuf);
				String b = new String(cbuf);
				clear = true;
				if (b.contains("userUpdate")) {
					while (true) {
						if (clear) {
							GUI.textArea_1.setText("                 USERS");
						}
						clear = false;
						char dbuf[] = new char[1024];
						inFromServer.read(dbuf);
						String x = new String(dbuf);
						if (x.contains("stop")) {
							clear = true;
							break;
						} else {
							GUI.textArea_1.append("\n " + x);
						}
					}
				} else {
					GUI.textArea.append("\n" + b + "\n");
				}
			} catch (IOException e) {
				stop = true;
				break;
			}
			try {
				Thread.sleep(100);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
	}

	public static void threadRun() {
		Listen x = new Listen();
		Thread t1 = new Thread(x);
		while (true) {
			if (!t1.isAlive()) {
				if (stop) {
					break;
				}
				t1.start();
			} else {
				continue;
			}
		}

	}
}