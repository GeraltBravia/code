namespace Demo_RCP
{
    partial class RegForm
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
            reg_showpass = new CheckBox();
            label3 = new Label();
            label1 = new Label();
            btn_reg = new Button();
            reg_passwd = new TextBox();
            reg_username = new TextBox();
            label2 = new Label();
            label5 = new Label();
            reg_cpasswd = new TextBox();
            btn_reglink = new Button();
            label4 = new Label();
            btn_close_reg = new Button();
            SuspendLayout();
            // 
            // reg_showpass
            // 
            reg_showpass.AutoSize = true;
            reg_showpass.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reg_showpass.ForeColor = Color.FromArgb(133, 19, 33);
            reg_showpass.Location = new Point(74, 404);
            reg_showpass.Margin = new Padding(3, 4, 3, 4);
            reg_showpass.Name = "reg_showpass";
            reg_showpass.Size = new Size(165, 29);
            reg_showpass.TabIndex = 20;
            reg_showpass.Text = "Show password";
            reg_showpass.UseVisualStyleBackColor = true;
            reg_showpass.CheckedChanged += reg_showpass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(133, 19, 33);
            label3.Location = new Point(74, 229);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(133, 19, 33);
            label1.Location = new Point(74, 141);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 18;
            label1.Text = "UserName";
            // 
            // btn_reg
            // 
            btn_reg.BackColor = Color.FromArgb(133, 19, 33);
            btn_reg.FlatAppearance.BorderSize = 0;
            btn_reg.FlatAppearance.MouseDownBackColor = Color.FromArgb(213, 10, 56);
            btn_reg.FlatAppearance.MouseOverBackColor = Color.FromArgb(213, 10, 56);
            btn_reg.FlatStyle = FlatStyle.Flat;
            btn_reg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reg.ForeColor = Color.White;
            btn_reg.Location = new Point(74, 460);
            btn_reg.Margin = new Padding(3, 4, 3, 4);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(333, 57);
            btn_reg.TabIndex = 17;
            btn_reg.Text = "Register";
            btn_reg.UseVisualStyleBackColor = false;
            btn_reg.Click += btn_reg_Click;
            // 
            // reg_passwd
            // 
            reg_passwd.Font = new Font("Arial", 12F, FontStyle.Bold);
            reg_passwd.Location = new Point(74, 260);
            reg_passwd.Margin = new Padding(3, 4, 3, 4);
            reg_passwd.Multiline = true;
            reg_passwd.Name = "reg_passwd";
            reg_passwd.PasswordChar = '*';
            reg_passwd.Size = new Size(332, 39);
            reg_passwd.TabIndex = 16;
            // 
            // reg_username
            // 
            reg_username.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reg_username.Location = new Point(74, 172);
            reg_username.Margin = new Padding(3, 4, 3, 4);
            reg_username.Multiline = true;
            reg_username.Name = "reg_username";
            reg_username.Size = new Size(332, 39);
            reg_username.TabIndex = 15;
            reg_username.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(133, 19, 33);
            label2.Location = new Point(200, 47);
            label2.Name = "label2";
            label2.Size = new Size(116, 37);
            label2.TabIndex = 14;
            label2.Text = "Register";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(133, 19, 33);
            label5.Location = new Point(74, 325);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 24;
            label5.Text = "Confirm password";
            // 
            // reg_cpasswd
            // 
            reg_cpasswd.Font = new Font("Arial", 12F, FontStyle.Bold);
            reg_cpasswd.Location = new Point(74, 356);
            reg_cpasswd.Margin = new Padding(3, 4, 3, 4);
            reg_cpasswd.Multiline = true;
            reg_cpasswd.Name = "reg_cpasswd";
            reg_cpasswd.PasswordChar = '*';
            reg_cpasswd.Size = new Size(332, 39);
            reg_cpasswd.TabIndex = 23;
            reg_cpasswd.Tag = "dang nhap";
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
            btn_reglink.Location = new Point(240, 548);
            btn_reglink.Margin = new Padding(3, 4, 3, 4);
            btn_reglink.Name = "btn_reglink";
            btn_reglink.Size = new Size(167, 57);
            btn_reglink.TabIndex = 27;
            btn_reglink.Text = "Login here!";
            btn_reglink.UseVisualStyleBackColor = false;
            btn_reglink.Click += btn_reglink_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(133, 19, 33);
            label4.Location = new Point(74, 548);
            label4.Name = "label4";
            label4.Size = new Size(132, 46);
            label4.TabIndex = 26;
            label4.Text = "Do you have an\r\n account?";
            // 
            // btn_close_reg
            // 
            btn_close_reg.BackColor = Color.FromArgb(133, 19, 33);
            btn_close_reg.FlatStyle = FlatStyle.Flat;
            btn_close_reg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_reg.ForeColor = Color.White;
            btn_close_reg.Location = new Point(434, 16);
            btn_close_reg.Margin = new Padding(3, 4, 3, 4);
            btn_close_reg.Name = "btn_close_reg";
            btn_close_reg.Size = new Size(33, 39);
            btn_close_reg.TabIndex = 28;
            btn_close_reg.Text = "X";
            btn_close_reg.UseVisualStyleBackColor = false;
            btn_close_reg.Click += btn_close_reg_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(481, 624);
            Controls.Add(btn_close_reg);
            Controls.Add(btn_reglink);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(reg_cpasswd);
            Controls.Add(reg_showpass);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btn_reg);
            Controls.Add(reg_passwd);
            Controls.Add(reg_username);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox reg_showpass;
        private Label label3;
        private Label label1;
        private Button btn_reg;
        private TextBox reg_passwd;
        private TextBox reg_username;
        private Label label2;
        private Label label5;
        private TextBox reg_cpasswd;
        private Button btn_reglink;
        private Label label4;
        private Button btn_close_reg;
    }
}