using Gruppövning_InternationalFoodAB.Classes;

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

        //Söka recept 
        private void btnGuestSearch_Click(object sender, EventArgs e)
        {
            var searchResults = recept_Handler.ShowSearchResults(txtGuestSearch.Text, chkSearchName.Checked, chkSearchType.Checked);

            lbxGuestResults.Items.Clear();

            foreach (var recept in searchResults)
            {
                lbxGuestResults.Items.Add(recept);
            }
        }

        //Skriva ut alla recept
        private void btnGetList_Click(object sender, EventArgs e)
        {
            List<Recept> ReceptList = recept_Handler.Read();
            lbxGuestResults.Items.Clear();

            foreach (var recept in ReceptList)
            {
                lbxGuestResults.Items.Add(recept);
            }
        }

        //Valt recept
        private void lbxGuestResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recept selectedRecept = lbxGuestResults.SelectedItem as Recept;

            if (selectedRecept != null)
                selectedRecepie = selectedRecept;
        }

        //Öppna recept
        private void btnGuestOpenRecipe_Click(object sender, EventArgs e)
        {
            if (selectedRecepie != null)
            {
                FrmGuest_ShowRecept formShowRecept = new FrmGuest_ShowRecept(selectedRecepie);
                formShowRecept.Show();
            }
            else
            {
                MessageBox.Show("Välj ett recept först.");
            }

        }
    }
}
