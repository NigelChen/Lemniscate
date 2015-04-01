import java.io.IOException;

public class userThread implements Runnable {

	@SuppressWarnings("static-access")
	public void run() {
		Main main = new Main();
		try {
			main.listener();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public static void runThread() {
		userThread x = new userThread();
		Thread t1 = new Thread(x);
		t1.start();
	}

}
