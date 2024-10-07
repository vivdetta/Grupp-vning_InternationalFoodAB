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
        private Recept selectedRecepie;
        public FrmAdminScreen()
        {
            InitializeComponent();
        }

        private void lbxAdminView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recept selectedRecept = lbxAdminView.SelectedItem as Recept;

            if (selectedRecept != null)
                selectedRecepie = selectedRecept;
        }

        private void btnOpenRecipe_Click(object sender, EventArgs e)
        {
            FormAdmin_SelectedRecept formSelectedRecept = new FormAdmin_SelectedRecept(selectedRecepie);
        }
    }
}
