import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.SpringLayout;
import javax.swing.JTextField;
import javax.swing.UIManager;

import java.awt.Font;

import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import javax.swing.JLabel;

import java.awt.TextArea;


public class GUI{

	private JFrame frmBtalk;
	public static JTextField textField;
	public static TextArea textArea;
	public static boolean enter = true;
	public static String ownHost;
	public static int ownPort;
	public static String text = "";
	public static TextArea textArea_1;
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			@SuppressWarnings("static-access")
			public void run() {
				try {
					try {
						UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
					} catch (Exception e) {
						e.printStackTrace();
						
					}
					ownHost = JOptionPane.showInputDialog("Enter host IP address");
					String port = JOptionPane.showInputDialog("Enter the port");
					ownPort = Integer.parseInt(port);
					GUI window = new GUI();
					window.frmBtalk.setVisible(true);
					userThread x = new userThread();
					x.runThread();
					@SuppressWarnings("unused")
					Main main = new Main();
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public GUI() {
		initialize();
	}

	private void initialize() {
		try {
			UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		} catch (Exception e) {
			e.printStackTrace();
			
		}
		
		frmBtalk = new JFrame();
		frmBtalk.setResizable(false);
		frmBtalk.setTitle("Lemniscate v0.1");
		frmBtalk.setBounds(100, 100, 850, 510);
		frmBtalk.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		SpringLayout springLayout = new SpringLayout();
		frmBtalk.getContentPane().setLayout(springLayout);
		
		JLabel label = new JLabel("");
		springLayout.putConstraint(SpringLayout.NORTH, label, 10, SpringLayout.NORTH, frmBtalk.getContentPane());
		springLayout.putConstraint(SpringLayout.EAST, label, -44, SpringLayout.EAST, frmBtalk.getContentPane());
		frmBtalk.getContentPane().add(label);
		
		textField = new JTextField();
		springLayout.putConstraint(SpringLayout.NORTH, textField, 389, SpringLayout.NORTH, frmBtalk.getContentPane());
		springLayout.putConstraint(SpringLayout.WEST, textField, 10, SpringLayout.WEST, frmBtalk.getContentPane());
		springLayout.putConstraint(SpringLayout.SOUTH, textField, -33, SpringLayout.SOUTH, frmBtalk.getContentPane());
		springLayout.putConstraint(SpringLayout.EAST, textField, 760, SpringLayout.WEST, frmBtalk.getContentPane());
		frmBtalk.getContentPane().add(textField);
		textField.setColumns(10);
		textField.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {
				text = textField.getText();
				enter = true;
				textField.setText("");
			}}); 
		
		JButton btnSend = new JButton("Send");
		btnSend.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				text = textField.getText();
				enter = true;
				textField.setText("");
			}
		});
		springLayout.putConstraint(SpringLayout.NORTH, btnSend, 0, SpringLayout.NORTH, textField);
		springLayout.putConstraint(SpringLayout.WEST, btnSend, 6, SpringLayout.EAST, textField);
		springLayout.putConstraint(SpringLayout.SOUTH, btnSend, 0, SpringLayout.SOUTH, textField);
		springLayout.putConstraint(SpringLayout.EAST, btnSend, -10, SpringLayout.EAST, frmBtalk.getContentPane());
		frmBtalk.getContentPane().add(btnSend);
		
		textArea = new TextArea();
		textArea.setText("**ATTEMPTING TO CONNECT TO " + ownHost + "**\n");
		textArea.append("If this takes more than a minute, then the server isn't up or the hostname/port is wrong.\n");
		springLayout.putConstraint(SpringLayout.NORTH, textArea, 10, SpringLayout.NORTH, frmBtalk.getContentPane());
		springLayout.putConstraint(SpringLayout.WEST, textArea, 10, SpringLayout.WEST, frmBtalk.getContentPane());
		springLayout.putConstraint(SpringLayout.SOUTH, textArea, -6, SpringLayout.NORTH, textField);
		textArea.setEditable(false);
		textArea.setFont(new Font("Arial", Font.PLAIN, 17));
		frmBtalk.getContentPane().add(textArea);
		
		textArea_1 = new TextArea();
		textArea_1.setEditable(false);
		textArea_1.setText("                 USERS");
		springLayout.putConstraint(SpringLayout.EAST, textArea, -9, SpringLayout.WEST, textArea_1);
		springLayout.putConstraint(SpringLayout.WEST, textArea_1, -159, SpringLayout.EAST, btnSend);
		springLayout.putConstraint(SpringLayout.NORTH, textArea_1, 0, SpringLayout.NORTH, label);
		springLayout.putConstraint(SpringLayout.SOUTH, textArea_1, -6, SpringLayout.NORTH, textField);
		springLayout.putConstraint(SpringLayout.EAST, textArea_1, 0, SpringLayout.EAST, btnSend);
		frmBtalk.getContentPane().add(textArea_1);
	}
}
