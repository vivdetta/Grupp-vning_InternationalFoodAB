using Gruppövning_InternationalFoodAB.WinForms;

namespace Gruppövning_InternationalFoodAB
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            //När användaren klickar på Gäst-knappen så öppnas Gäst-formuläret.
            //I Gäst-formuläret kan man öppna upp alla recept (men det är readonly) och man kan söka på ett specifik

            FrmGuest_Screen guest_Screen = new FrmGuest_Screen();
            guest_Screen.Show();
            this.Hide();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            //När användaren klickar på Admin-knappen så öppnas Admin_Login-formuläret
            //I Admin_Login-formuläret så kan man logga in med admin-namn och lösenord
            FormAdmin_Login admin_Login = new FormAdmin_Login();
            admin_Login.Show();
            this.Hide();
        }
    }
}
