namespace SendMail
{
    partial class login
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_server = new System.Windows.Forms.TextBox();
            this.text_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(76, 37);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(169, 21);
            this.text_user.TabIndex = 2;
            // 
            // text_pw
            // 
            this.text_pw.Location = new System.Drawing.Point(76, 64);
            this.text_pw.Name = "text_pw";
            this.text_pw.PasswordChar = '*';
            this.text_pw.Size = new System.Drawing.Size(169, 21);
            this.text_pw.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mail User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server:";
            // 
            // text_server
            // 
            this.text_server.Location = new System.Drawing.Point(76, 10);
            this.text_server.Name = "text_server";
            this.text_server.ReadOnly = true;
            this.text_server.Size = new System.Drawing.Size(140, 21);
            this.text_server.TabIndex = 7;
            this.text_server.Text = "mail.chinadaily.com.cn";
            this.text_server.DoubleClick += new System.EventHandler(this.text_server_DoubleClick);
            // 
            // text_port
            // 
            this.text_port.Location = new System.Drawing.Point(222, 10);
            this.text_port.Name = "text_port";
            this.text_port.ReadOnly = true;
            this.text_port.Size = new System.Drawing.Size(23, 21);
            this.text_port.TabIndex = 8;
            this.text_port.Text = "25";
            this.text_port.DoubleClick += new System.EventHandler(this.text_port_DoubleClick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 129);
            this.Controls.Add(this.text_port);
            this.Controls.Add(this.text_server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_pw);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.TextBox text_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.TextBox text_port;
    }
}