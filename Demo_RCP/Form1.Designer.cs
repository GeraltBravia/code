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
            label2 = new Label();
            btn_log = new Button();
            label1 = new Label();
            label3 = new Label();
            log_showpass = new CheckBox();
            label4 = new Label();
            btn_reglink = new Button();
            btn_close_log = new Button();
            log_username = new TextBox();
            log_passwd = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(133, 19, 33);
            label2.Location = new Point(183, 60);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 1;
            label2.Text = "Login";
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
            btn_log.Location = new Point(71, 310);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(291, 43);
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
            label1.Location = new Point(71, 134);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 9;
            label1.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(133, 19, 33);
            label3.Location = new Point(71, 206);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 10;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // log_showpass
            // 
            log_showpass.AutoSize = true;
            log_showpass.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            log_showpass.ForeColor = Color.FromArgb(133, 19, 33);
            log_showpass.Location = new Point(71, 265);
            log_showpass.Name = "log_showpass";
            log_showpass.Size = new Size(133, 24);
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
            label4.Location = new Point(71, 396);
            label4.Name = "label4";
            label4.Size = new Size(128, 19);
            label4.TabIndex = 12;
            label4.Text = "Create an account?";
            // 
            // btn_reglink
            // 
            btn_reglink.BackColor = Color.FromArgb(133, 19, 33);
            btn_reglink.FlatAppearance.BorderSize = 0;
            btn_reglink.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            btn_reglink.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            btn_reglink.FlatStyle = FlatStyle.Flat;
            btn_reglink.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reglink.ForeColor = Color.White;
            btn_reglink.Location = new Point(216, 396);
            btn_reglink.Name = "btn_reglink";
            btn_reglink.Size = new Size(146, 43);
            btn_reglink.TabIndex = 13;
            btn_reglink.Text = "Register here!";
            btn_reglink.UseVisualStyleBackColor = false;
            btn_reglink.Click += btn_reglink_Click;
            // 
            // btn_close_log
            // 
            btn_close_log.BackColor = Color.FromArgb(133, 19, 33);
            btn_close_log.FlatStyle = FlatStyle.Flat;
            btn_close_log.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_log.ForeColor = Color.White;
            btn_close_log.Location = new Point(380, 9);
            btn_close_log.Name = "btn_close_log";
            btn_close_log.Size = new Size(29, 29);
            btn_close_log.TabIndex = 29;
            btn_close_log.Text = "X";
            btn_close_log.UseVisualStyleBackColor = false;
            btn_close_log.Click += btn_close_log_Click;
            // 
            // log_username
            // 
            log_username.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log_username.Location = new Point(71, 157);
            log_username.Multiline = true;
            log_username.Name = "log_username";
            log_username.Size = new Size(291, 30);
            log_username.TabIndex = 30;
            log_username.Tag = "";
            // 
            // log_passwd
            // 
            log_passwd.Font = new Font("Arial Rounded MT Bold", 11.25F);
            log_passwd.Location = new Point(71, 229);
            log_passwd.Multiline = true;
            log_passwd.Name = "log_passwd";
            log_passwd.PasswordChar = '*';
            log_passwd.Size = new Size(291, 30);
            log_passwd.TabIndex = 31;
            log_passwd.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(421, 468);
            Controls.Add(log_passwd);
            Controls.Add(log_username);
            Controls.Add(btn_close_log);
            Controls.Add(btn_reglink);
            Controls.Add(label4);
            Controls.Add(log_showpass);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btn_log);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btn_log;
        private Label label1;
        private Label label3;
        private CheckBox log_showpass;
        private Label label4;
        private Button btn_reglink;
        private Button btn_close_log;
        private TextBox log_username;
        private TextBox log_passwd;
    }
}
