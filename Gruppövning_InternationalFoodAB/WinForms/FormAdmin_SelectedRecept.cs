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
using System.Xml.Linq;

namespace Gruppövning_InternationalFoodAB.WinForms
{
    public partial class FormAdmin_SelectedRecept : Form
    {
        Recept_Handler recept_Handler;
        Recept recept;

        public FormAdmin_SelectedRecept(Recept recept)
        {
            InitializeComponent();
            this.recept = recept;

            txtName.Text = recept.Name;
            txtTypeOfRecept.Text = recept.TypeOfRecept;
            txtDescription.Text = recept.Description;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Är du säker på att du vill ta bort detta recept?",
                                                 "Bekräfta borttagning",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
                recept_Handler.Delete(this.recept.Id);

            MessageBox.Show("Receptet har nu tagits bort");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Recept updatedRecept = new Recept()
            {
                Id = this.recept.Id,
                Name = this.recept.Name,
                TypeOfRecept = this.recept.TypeOfRecept,
                Description = this.recept.Description

            };

            recept_Handler.Update(updatedRecept.Id, updatedRecept);
        }
    }
}
