using System;
using System.Windows.Forms;

namespace _20200305043.FORMS
{
    public partial class LogIn : Form
    {
        private MySQLDataAccess _dataAccess;

        public LogIn()
        {
            InitializeComponent();
            string connectionString = "server=127.0.0.1; user=root; database=TechTrove;";
            _dataAccess = new MySQLDataAccess(connectionString);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if (picShow.Visible)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (picHide.Visible)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcıyı doğrula
            var users = _dataAccess.GetUsers(username, password);

            if (users.Count > 0)
            {
                // Eğer kullanıcı doğrulandıysa, ana formu göster ve giriş formunu gizle
                Main main = new Main(_dataAccess); // MySQLDataAccess nesnesini parametre olarak geçirin
                main.Show();
                this.Hide();
            }
            else
            {
                // Kullanıcı doğrulanamazsa uyarı mesajı göster
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmptyBox();
            }
        }

        private void EmptyBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
