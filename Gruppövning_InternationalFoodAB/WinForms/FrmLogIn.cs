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
            // When the guest button is clicked, we open the from which takes the 
            // guest to a form where they can search for a particular recipe
            FrmGuest_Screen guest_Screen = new FrmGuest_Screen();
            guest_Screen.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            // When the guest button is clicked, we open the from which takes the 
            // guest to a form where they can search for a particular recipe
            FormAdmin_Login admin_Login = new FormAdmin_Login();
            admin_Login.Show();
        }
    }
}
