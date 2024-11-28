namespace Demo_RCP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            btn_log = new Button();
            label1 = new Label();
            label3 = new Label();
            log_showpass = new CheckBox();
            label4 = new Label();
            btn_close_log = new Button();
            log_username = new TextBox();
            log_passwd = new TextBox();
            panel1 = new Panel();
            btn_reglink1 = new Button();
            panel2 = new Panel();
            label8 = new Label();
            reg_cpasswd = new TextBox();
            btn_reglink2 = new Button();
            reg_passwd = new TextBox();
            reg_username = new TextBox();
            label5 = new Label();
            reg_showpass = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            btn_register = new Button();
            txt_register = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(133, 19, 33);
            label2.Location = new Point(129, 23);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 1;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // btn_log
            // 
            btn_log.BackColor = Color.FromArgb(133, 19, 33);
            btn_log.FlatAppearance.BorderSize = 0;
            btn_log.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            btn_log.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            btn_log.FlatStyle = FlatStyle.Flat;
            btn_log.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_log.ForeColor = Color.White;
            btn_log.Location = new Point(13, 356);
            btn_log.Margin = new Padding(3, 4, 3, 4);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(333, 57);
            btn_log.TabIndex = 8;
            btn_log.Text = "LOGIN";
            btn_log.UseVisualStyleBackColor = false;
            btn_log.Click += btn_log_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(133, 19, 33);
            label1.Location = new Point(13, 122);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 9;
            label1.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(133, 19, 33);
            label3.Location = new Point(13, 218);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 10;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // log_showpass
            // 
            log_showpass.AutoSize = true;
            log_showpass.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            log_showpass.ForeColor = Color.FromArgb(133, 19, 33);
            log_showpass.Location = new Point(13, 296);
            log_showpass.Margin = new Padding(3, 4, 3, 4);
            log_showpass.Name = "log_showpass";
            log_showpass.Size = new Size(165, 29);
            log_showpass.TabIndex = 11;
            log_showpass.Text = "Show password";
            log_showpass.UseVisualStyleBackColor = true;
            log_showpass.CheckedChanged += log_showpass_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(133, 19, 33);
            label4.Location = new Point(13, 471);
            label4.Name = "label4";
            label4.Size = new Size(157, 23);
            label4.TabIndex = 12;
            label4.Text = "Create an account?";
            label4.Click += label4_Click;
            // 
            // btn_close_log
            // 
            btn_close_log.BackColor = Color.FromArgb(133, 19, 33);
            btn_close_log.FlatStyle = FlatStyle.Flat;
            btn_close_log.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_log.ForeColor = Color.White;
            btn_close_log.Location = new Point(840, -1);
            btn_close_log.Margin = new Padding(3, 4, 3, 4);
            btn_close_log.Name = "btn_close_log";
            btn_close_log.Size = new Size(33, 39);
            btn_close_log.TabIndex = 29;
            btn_close_log.Text = "X";
            btn_close_log.UseVisualStyleBackColor = false;
            btn_close_log.Click += btn_close_log_Click;
            // 
            // log_username
            // 
            log_username.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_username.Location = new Point(13, 160);
            log_username.Margin = new Padding(3, 4, 3, 4);
            log_username.Multiline = true;
            log_username.Name = "log_username";
            log_username.Size = new Size(332, 39);
            log_username.TabIndex = 30;
            log_username.Tag = "";
            log_username.TextChanged += log_username_TextChanged;
            log_username.Enter += log_username_Enter;
            log_username.Leave += log_username_Leave;
            // 
            // log_passwd
            // 
            log_passwd.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_passwd.Location = new Point(13, 248);
            log_passwd.Margin = new Padding(3, 4, 3, 4);
            log_passwd.Multiline = true;
            log_passwd.Name = "log_passwd";
            log_passwd.PasswordChar = '*';
            log_passwd.Size = new Size(332, 39);
            log_passwd.TabIndex = 31;
            log_passwd.Tag = "";
            log_passwd.Enter += log_passwd_Enter;
            log_passwd.Leave += log_passwd_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_reglink1);
            panel1.Controls.Add(log_passwd);
            panel1.Controls.Add(log_username);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(log_showpass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_log);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(471, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 526);
            panel1.TabIndex = 32;
            // 
            // btn_reglink1
            // 
            btn_reglink1.BackColor = Color.FromArgb(133, 19, 33);
            btn_reglink1.FlatAppearance.BorderSize = 0;
            btn_reglink1.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            btn_reglink1.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            btn_reglink1.FlatStyle = FlatStyle.Flat;
            btn_reglink1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reglink1.ForeColor = Color.White;
            btn_reglink1.Location = new Point(179, 437);
            btn_reglink1.Margin = new Padding(3, 4, 3, 4);
            btn_reglink1.Name = "btn_reglink1";
            btn_reglink1.Size = new Size(167, 57);
            btn_reglink1.TabIndex = 35;
            btn_reglink1.Text = "Register here!";
            btn_reglink1.UseVisualStyleBackColor = false;
            btn_reglink1.Click += btn_reglink1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(reg_cpasswd);
            panel2.Controls.Add(btn_reglink2);
            panel2.Controls.Add(reg_passwd);
            panel2.Controls.Add(reg_username);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(reg_showpass);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btn_register);
            panel2.Controls.Add(txt_register);
            panel2.Location = new Point(471, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 526);
            panel2.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(133, 19, 33);
            label8.Location = new Point(13, 259);
            label8.Name = "label8";
            label8.Size = new Size(167, 25);
            label8.TabIndex = 34;
            label8.Text = "Confirm password";
            // 
            // reg_cpasswd
            // 
            reg_cpasswd.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_cpasswd.Location = new Point(13, 292);
            reg_cpasswd.Margin = new Padding(3, 4, 3, 4);
            reg_cpasswd.Multiline = true;
            reg_cpasswd.Name = "reg_cpasswd";
            reg_cpasswd.PasswordChar = '*';
            reg_cpasswd.Size = new Size(332, 39);
            reg_cpasswd.TabIndex = 33;
            reg_cpasswd.Tag = "";
            // 
            // btn_reglink2
            // 
            btn_reglink2.BackColor = Color.FromArgb(133, 19, 33);
            btn_reglink2.FlatAppearance.BorderSize = 0;
            btn_reglink2.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            btn_reglink2.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            btn_reglink2.FlatStyle = FlatStyle.Flat;
            btn_reglink2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reglink2.ForeColor = Color.White;
            btn_reglink2.Location = new Point(178, 459);
            btn_reglink2.Margin = new Padding(3, 4, 3, 4);
            btn_reglink2.Name = "btn_reglink2";
            btn_reglink2.Size = new Size(167, 57);
            btn_reglink2.TabIndex = 32;
            btn_reglink2.Text = "Login here!";
            btn_reglink2.UseVisualStyleBackColor = false;
            btn_reglink2.Click += btn_reglink2_Click;
            // 
            // reg_passwd
            // 
            reg_passwd.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_passwd.Location = new Point(13, 204);
            reg_passwd.Margin = new Padding(3, 4, 3, 4);
            reg_passwd.Multiline = true;
            reg_passwd.Name = "reg_passwd";
            reg_passwd.PasswordChar = '*';
            reg_passwd.Size = new Size(332, 39);
            reg_passwd.TabIndex = 31;
            reg_passwd.Tag = "";
            // 
            // reg_username
            // 
            reg_username.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg_username.Location = new Point(13, 123);
            reg_username.Margin = new Padding(3, 4, 3, 4);
            reg_username.Multiline = true;
            reg_username.Name = "reg_username";
            reg_username.Size = new Size(332, 39);
            reg_username.TabIndex = 30;
            reg_username.Tag = "";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(133, 19, 33);
            label5.Location = new Point(13, 459);
            label5.Name = "label5";
            label5.Size = new Size(144, 57);
            label5.TabIndex = 26;
            label5.Text = "Do you have an account?";
            // 
            // reg_showpass
            // 
            reg_showpass.AutoSize = true;
            reg_showpass.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reg_showpass.ForeColor = Color.FromArgb(133, 19, 33);
            reg_showpass.Location = new Point(13, 353);
            reg_showpass.Margin = new Padding(3, 4, 3, 4);
            reg_showpass.Name = "reg_showpass";
            reg_showpass.Size = new Size(165, 29);
            reg_showpass.TabIndex = 11;
            reg_showpass.Text = "Show password";
            reg_showpass.UseVisualStyleBackColor = true;
            reg_showpass.CheckedChanged += reg_showpass_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(133, 19, 33);
            label6.Location = new Point(13, 171);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 10;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(133, 19, 33);
            label7.Location = new Point(13, 85);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 9;
            label7.Text = "UserName";
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(133, 19, 33);
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            btn_register.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(13, 393);
            btn_register.Margin = new Padding(3, 4, 3, 4);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(333, 57);
            btn_register.TabIndex = 8;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // txt_register
            // 
            txt_register.AutoSize = true;
            txt_register.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_register.ForeColor = Color.FromArgb(133, 19, 33);
            txt_register.Location = new Point(129, 23);
            txt_register.Name = "txt_register";
            txt_register.Size = new Size(116, 37);
            txt_register.TabIndex = 1;
            txt_register.Text = "Register";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(30, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 267);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(871, 572);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btn_close_log);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button btn_log;
        private Label label1;
        private Label label3;
        private CheckBox log_showpass;
        private Label label4;
        private Button btn_close_log;
        private TextBox log_username;
        private TextBox log_passwd;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox reg_passwd;
        private TextBox reg_username;
        private Label label5;
        private CheckBox reg_showpass;
        private Label label6;
        private Label label7;
        private Button btn_register;
        private Label txt_register;
        private Button btn_reglink2;
        private TextBox reg_cpasswd;
        private Label label8;
        private Button btn_reglink1;
    }
}
