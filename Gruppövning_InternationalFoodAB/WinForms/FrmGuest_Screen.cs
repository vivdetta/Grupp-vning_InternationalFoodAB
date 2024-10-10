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
    public partial class FrmGuest_Screen : Form
    {
        Recept_Handler recept_Handler = new Recept_Handler();
        private Recept selectedRecepie;
        public FrmGuest_Screen()
        {
            InitializeComponent();
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            List<Recept> ReceptList = recept_Handler.Read();
            lbxGuestResults.Items.Clear();

            foreach (var recept in ReceptList)
            {
                lbxGuestResults.Items.Add(recept);
            }
        }

        private void lbxGuestResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recept selectedRecept = lbxGuestResults.SelectedItem as Recept;

            if (selectedRecept != null)
                selectedRecepie = selectedRecept;
        }

        private void btnGuestOpenRecipe_Click(object sender, EventArgs e)
        {
            //Öppnar nya formuläret där valt recept visas för användaren
            FrmGuest_ShowRecept formShowRecept = new FrmGuest_ShowRecept(selectedRecepie);

        }
    }
}
