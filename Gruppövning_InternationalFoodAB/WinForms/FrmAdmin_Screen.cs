using Gruppövning_InternationalFoodAB.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppövning_InternationalFoodAB.WinForms
{
    public partial class FrmAdminScreen : Form
    {
        Recept_Handler recept_Handler = new Recept_Handler();
        private Guid selectedRecepieId;
        public FrmAdminScreen()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Är du säker på att du vill ta bort detta recept?",
                                                 "Bekräfta borttagning",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                recept_Handler.Delete(selectedRecepieId);

            MessageBox.Show("Receptet har nu tagits bort");
        }

        private void lbxAdminView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recept selectedRecept = lbxAdminView.SelectedItem as Recept;

            if (selectedRecept != null)
                selectedRecepieId = selectedRecept.Id;
        }
    }
}
