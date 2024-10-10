using Gruppövning_InternationalFoodAB.Classes;

namespace Gruppövning_InternationalFoodAB.WinForms
{
    public partial class FormAdmin_Login : Form
    {
        Admin adminTry;
        public FormAdmin_Login()

        {
            InitializeComponent();
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("You have not entered a username.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("You have not entered a password.");
                return;
            }
            else
            {
                adminTry.UserName = txtUserName.Text;
                adminTry.Password = txtPassword.Text;
                bool isValidAdmin = LoginAuthenticator.CheckForAdmin(adminTry);
                if (isValidAdmin)
                {
                    FrmAdminScreen adminScreen = new FrmAdminScreen();
                    adminScreen.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("You username and password did not match existing Admins." +
                        "Please check your details and try again.");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
