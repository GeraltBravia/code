namespace Demo_RCP
{
    partial class AdminForm
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
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            btn_logout = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_addmovie = new Button();
            btn_addstaff = new Button();
            btn_dashbroad = new Button();
            pictureBox1 = new PictureBox();
            btn_close_log = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            dashbroadForm11 = new dashbroadForm1();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(133, 19, 33);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_addmovie);
            panel1.Controls.Add(btn_addstaff);
            panel1.Controls.Add(btn_dashbroad);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 450);
            panel1.TabIndex = 31;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.log_out1;
            pictureBox5.Location = new Point(12, 407);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // btn_logout
            // 
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(12, 407);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(174, 40);
            btn_logout.TabIndex = 7;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.video_player1;
            pictureBox4.Location = new Point(12, 268);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.group1;
            pictureBox3.Location = new Point(12, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cogwheel1;
            pictureBox2.Location = new Point(12, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btn_addmovie
            // 
            btn_addmovie.FlatAppearance.BorderSize = 0;
            btn_addmovie.FlatStyle = FlatStyle.Flat;
            btn_addmovie.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_addmovie.ForeColor = Color.White;
            btn_addmovie.Location = new Point(12, 268);
            btn_addmovie.Name = "btn_addmovie";
            btn_addmovie.Size = new Size(183, 40);
            btn_addmovie.TabIndex = 3;
            btn_addmovie.Text = "Them Phim";
            btn_addmovie.UseVisualStyleBackColor = true;
            btn_addmovie.Click += btn_addmovie_Click;
            // 
            // btn_addstaff
            // 
            btn_addstaff.FlatAppearance.BorderSize = 0;
            btn_addstaff.FlatStyle = FlatStyle.Flat;
            btn_addstaff.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_addstaff.ForeColor = Color.White;
            btn_addstaff.Location = new Point(12, 206);
            btn_addstaff.Name = "btn_addstaff";
            btn_addstaff.Size = new Size(183, 40);
            btn_addstaff.TabIndex = 2;
            btn_addstaff.Text = "Them Nhan Vien";
            btn_addstaff.TextAlign = ContentAlignment.MiddleRight;
            btn_addstaff.UseVisualStyleBackColor = true;
            // 
            // btn_dashbroad
            // 
            btn_dashbroad.FlatAppearance.BorderSize = 0;
            btn_dashbroad.FlatStyle = FlatStyle.Flat;
            btn_dashbroad.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_dashbroad.ForeColor = Color.White;
            btn_dashbroad.Location = new Point(12, 150);
            btn_dashbroad.Name = "btn_dashbroad";
            btn_dashbroad.Size = new Size(183, 40);
            btn_dashbroad.TabIndex = 1;
            btn_dashbroad.Text = "Bang Dieu Khien";
            btn_dashbroad.TextAlign = ContentAlignment.MiddleRight;
            btn_dashbroad.UseVisualStyleBackColor = true;
            btn_dashbroad.Click += btn_dashbroad_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.watching_a_movie1;
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_close_log
            // 
            btn_close_log.BackColor = Color.FromArgb(133, 19, 33);
            btn_close_log.FlatStyle = FlatStyle.Flat;
            btn_close_log.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_log.ForeColor = Color.White;
            btn_close_log.Location = new Point(764, 3);
            btn_close_log.Name = "btn_close_log";
            btn_close_log.Size = new Size(29, 29);
            btn_close_log.TabIndex = 30;
            btn_close_log.Text = "X";
            btn_close_log.UseVisualStyleBackColor = false;
            btn_close_log.Click += btn_close_log_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(133, 19, 33);
            label1.Location = new Point(185, 7);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 31;
            label1.Text = "he thong quan ly ve xem phim";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_close_log);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(195, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 34);
            panel2.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashbroadForm11);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(195, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(805, 416);
            panel3.TabIndex = 33;
            // 
            // dashbroadForm11
            // 
            dashbroadForm11.Location = new Point(0, 0);
            dashbroadForm11.Name = "dashbroadForm11";
            dashbroadForm11.Size = new Size(789, 450);
            dashbroadForm11.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_dashbroad;
        private Button button3;
        private Button btn_addmovie;
        private Button btn_addstaff;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btn_close_log;
        private Label label1;
        private Panel panel2;
        private Button btn_logout;
        private PictureBox pictureBox5;
        private Panel panel3;
        private addMovieForm1 addMovieForm1;
        private addMovieForm1 addMovieForm11;
        private dashbroadForm1 dashbroadForm11;
    }
}