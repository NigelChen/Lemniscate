import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;


public class Listen implements Runnable{
	private static boolean stop = false;
	public void run() {
		while (true) {
			
        try {
        	BufferedReader inFromServer=new BufferedReader(new InputStreamReader(Main.s.getInputStream()));
        	char cbuf[] = new char[300];
			inFromServer.read(cbuf);
			System.out.println(cbuf);
		} catch (IOException e) {
			System.out.println("**CONNECTION WITH SERVER DISCONNECTED**");
			stop = true;
			break;
		}
		}
	}
	public static void threadRun() {
		Listen x  = new Listen();
		Thread t1 = new Thread(x);
		while (true) {
			if (!t1.isAlive()) {
				if (stop) {
					break;
				}
			t1.start();
			}
			else {
				continue;
			}
		}
		
	}
}
