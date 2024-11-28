using System.Data;
using System.Data.SqlClient;
namespace Demo_RCP
{
    public partial class Form1 : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER LAPTOP\OneDrive\Tài liệu\movie.mdf"";Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }





        private void btn_reglink_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private void btn_close_log_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon thoat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (log_username.Text == "" || log_passwd.Text == "")
            {
                MessageBox.Show("Hay dien vao nhung o trong", "loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectData = "select * from users where username = @usern and password = @pass";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", log_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", log_passwd.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(" dang nhap thanh cong ", " thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AdminForm adform = new AdminForm();
                            adform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(" tai khoan hoac mac khau khong dung ", " loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void log_showpass_CheckedChanged(object sender, EventArgs e)
        {
            log_passwd.PasswordChar = log_showpass.Checked ? '\0' : '*';

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void log_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_username_Enter(object sender, EventArgs e)
        {
            if (log_username.Text == "Nhập tên đăng nhập")
            {
                log_username.Text = ""; // Xóa placeholder
                log_username.ForeColor = Color.Black; // Đổi màu chữ khi nhập
            }
        }

        private void log_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(log_username.Text))
            {
                log_username.Text = "Nhập tên đăng nhập"; // Hiển thị lại placeholder
                log_username.ForeColor = Color.Gray; // Màu chữ cho placeholder
            }
        }

        private void log_passwd_Enter(object sender, EventArgs e)
        {
            if (log_passwd.Text == "Nhập tên đăng nhập")
            {
                log_passwd.Text = ""; // Xóa placeholder
                log_passwd.ForeColor = Color.Black; // Đổi màu chữ khi nhập
            }
        }

        private void log_passwd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(log_passwd.Text))
            {
                log_passwd.Text = "Nhập tên đăng nhập"; // Hiển thị lại placeholder
                log_passwd.ForeColor = Color.Gray; // Màu chữ cho placeholder
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
