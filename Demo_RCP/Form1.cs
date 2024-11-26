using System.Data;
using System.Data.SqlClient;
namespace Demo_RCP
{
    public partial class Form1 : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";

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
        
        
       
    }
}
