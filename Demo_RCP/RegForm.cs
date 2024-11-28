using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Demo_RCP
{
    public partial class RegForm : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER LAPTOP\OneDrive\Tài liệu\movie.mdf"";Integrated Security=True;Connect Timeout=30";
        public RegForm()
        {
            InitializeComponent();
        }

        private void reg_showpass_CheckedChanged(object sender, EventArgs e)
        {
            reg_passwd.PasswordChar = reg_showpass.Checked ? '\0' : '*';
            reg_cpasswd.PasswordChar = reg_showpass.Checked ? '\0' : '*';
        }

        private void close_reg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (reg_username.Text == "" || reg_passwd.Text == "" || reg_cpasswd.Text == "")
            {
                MessageBox.Show("Hay dien vao nhung o trong", "loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reg_passwd.Text != reg_cpasswd.Text)
            {
                MessageBox.Show("mat khau khong trung khop", "loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (reg_passwd.Text.Length < 5)
            {
                MessageBox.Show("mat khau khong hop le", "loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string checkUsername = "select * from users where username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(reg_username.Text.Substring(0, 1).ToUpper() + reg_username.Text.Substring(1) + " da duoc thuc hien roi", " loi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "insert into users (username, password, role, status, date_reg)" + "values(@usern, @pass, @role, @status, @date)";
                            DateTime today = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", reg_passwd.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "member");
                                cmd.Parameters.AddWithValue("@status", "active");
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("dang ky thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginform = new Form1();
                                loginform.Show();
                                this.Hide();
                            }
                        }
                    }
                }

            }
        }

        private void btn_reglink_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void btn_close_reg_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon thoat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
