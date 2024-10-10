using Gruppövning_InternationalFoodAB.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppövning_InternationalFoodAB.WinForms
{
    public partial class FrmAdminScreen : Form
    {
        Recept_Handler recept_Handler;
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

        private void btnGetAllRecipes_Click(object sender, EventArgs e)
        {
            List<Recept> ReceptList = recept_Handler.Read();
            lbxAdminView.Items.Clear();

            foreach (var recept in ReceptList)
            {
                lbxAdminView.Items.Add(recept.Name);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Recept recept = new Recept
            {
                Name = txtTitle.Text,
                Description = txtDescription.Text,
                TypeOfRecept = cbxCategory.Text
            };
            recept_Handler.Create(recept);
            txtTitle.Text = "";
            txtDescription.Text = "";
        }
    }
}
