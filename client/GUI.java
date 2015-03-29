import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.SpringLayout;
import javax.swing.JTextPane;
import javax.swing.JTextField;
import javax.swing.UIManager;

import java.awt.Font;

import javax.swing.JButton;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import javax.swing.JLabel;
import javax.swing.JTextArea;
import java.awt.ScrollPane;
import java.awt.TextArea;


public class GUI{

	private JFrame frmBtalk;
	public static JTextField textField;
	public static TextArea textArea;
	public static boolean enter = true;
	public static String text = "";

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					GUI window = new GUI();
					window.frmBtalk.setVisible(true);
					userThread x = new userThread();
					x.runThread();
					Main main = new Main();
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public GUI() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
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
		textArea.setEditable(false);
		textArea.setFont(new Font("Arial", Font.PLAIN, 17));
		springLayout.putConstraint(SpringLayout.NORTH, textArea, 10, SpringLayout.NORTH, frmBtalk.getContentPane());
		springLayout.putConstraint(SpringLayout.WEST, textArea, 10, SpringLayout.WEST, frmBtalk.getContentPane());
		springLayout.putConstraint(SpringLayout.SOUTH, textArea, -6, SpringLayout.NORTH, textField);
		springLayout.putConstraint(SpringLayout.EAST, textArea, 0, SpringLayout.EAST, btnSend);
		frmBtalk.getContentPane().add(textArea);
	}

}
