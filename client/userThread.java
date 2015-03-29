import java.io.IOException;


public class userThread implements Runnable{

	public void run() {
		Main main  = new Main();
		try {
			main.listener();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public static void runThread() {
		userThread x  = new userThread();
		Thread t1 = new Thread(x);
		t1.start();
	}
	
}
