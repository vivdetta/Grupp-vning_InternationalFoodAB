using Gruppövning_InternationalFoodAB.Classes;

namespace Gruppövning_InternationalFoodAB.WinForms
{
    public partial class FrmAdminScreen : Form
    {
        Recept_Handler recept_Handler = new Recept_Handler();
        private Recept selectedRecepie;
        public FrmAdminScreen()
        {
            InitializeComponent();

            List<Recept> typeOfRecipe = new List<Recept>();

            foreach (var recept in typeOfRecipe)
            {
                cbxCategory.Items.Add(recept.TypeOfRecept);
            }

            //cbxCategory.Items.AddRange(typeOfRecipe.Select(recept => recept.TypeOfRecept).ToArray());
            //Måste kopplas till txtNewCategory
            //Måste kopplas ihop med btnNewCategory
        }

        //Valt recept
        private void lbxAdminView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recept selectedRecept = lbxAdminView.SelectedItem as Recept;

            if (selectedRecept != null)
                selectedRecepie = selectedRecept;
        }

        //Öppna recept
        private void btnOpenRecipe_Click(object sender, EventArgs e)
        {
            FormAdmin_SelectedRecept formSelectedRecept = new FormAdmin_SelectedRecept(selectedRecepie);
        }

        //Skriva ut alla recept
        private void btnGetAllRecipes_Click(object sender, EventArgs e)
        {
            List<Recept> ReceptList = recept_Handler.Read();
            lbxAdminView.Items.Clear();

            foreach (var recept in ReceptList)
            {
                lbxAdminView.Items.Add(recept);
            }
        }

        //Skapa nytt recept
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


        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            string newCategory = txtNewCategory.Text;
            cbxCategory.Items.Add(newCategory);
            txtNewCategory.Clear();
        }
//Söka recept 
        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            var searchResults = recept_Handler.ShowSearchResults(txtSearch.Text, chkName.Checked, chkType.Checked);

            lbxAdminView.Items.Clear();

            foreach (var recept in searchResults)
            {
                lbxAdminView.Items.Add(recept);
            }
        }
    }
}
