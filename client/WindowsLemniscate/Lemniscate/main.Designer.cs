namespace Lemniscate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nsTheme1 = new NSTheme();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.nsButton2 = new NSButton();
            this.nsButton1 = new NSButton();
            this.nsLabel2 = new NSLabel();
            this.nsLabel1 = new NSLabel();
            this.textBox3 = new System.Windows.Forms.RichTextBox();
            this.nsTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(790, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Connect to a server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 456);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(660, 26);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.textBox3);
            this.nsTheme1.Controls.Add(this.textBox1);
            this.nsTheme1.Controls.Add(this.nsButton2);
            this.nsTheme1.Controls.Add(this.nsButton1);
            this.nsTheme1.Controls.Add(this.nsLabel2);
            this.nsTheme1.Controls.Add(this.nsLabel1);
            this.nsTheme1.Controls.Add(this.button1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(1009, 494);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 6;
            this.nsTheme1.Text = "Lemniscate";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(766, 399);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "";
            // 
            // nsButton2
            // 
            this.nsButton2.Location = new System.Drawing.Point(947, 3);
            this.nsButton2.Name = "nsButton2";
            this.nsButton2.Size = new System.Drawing.Size(22, 21);
            this.nsButton2.TabIndex = 5;
            this.nsButton2.Text = "-";
            this.nsButton2.Click += new System.EventHandler(this.nsButton2_Click);
            // 
            // nsButton1
            // 
            this.nsButton1.Location = new System.Drawing.Point(975, 3);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.Size = new System.Drawing.Size(22, 21);
            this.nsButton1.TabIndex = 4;
            this.nsButton1.Text = "X";
            this.nsButton1.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // nsLabel2
            // 
            this.nsLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsLabel2.Location = new System.Drawing.Point(348, 31);
            this.nsLabel2.Name = "nsLabel2";
            this.nsLabel2.Size = new System.Drawing.Size(227, 19);
            this.nsLabel2.TabIndex = 3;
            this.nsLabel2.Text = "nsLabel2";
            this.nsLabel2.Value1 = "Lemni";
            this.nsLabel2.Value2 = "scate";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(869, 31);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(137, 23);
            this.nsLabel1.TabIndex = 2;
            this.nsLabel1.Text = "Users";
            this.nsLabel1.Value1 = "USERS";
            this.nsLabel1.Value2 = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(789, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(208, 399);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 494);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lemniscate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nsTheme1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private NSTheme nsTheme1;
        private NSLabel nsLabel1;
        private System.Windows.Forms.Button button1;
        private NSLabel nsLabel2;
        private NSButton nsButton1;
        private NSButton nsButton2;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.RichTextBox textBox3;
    }
}

