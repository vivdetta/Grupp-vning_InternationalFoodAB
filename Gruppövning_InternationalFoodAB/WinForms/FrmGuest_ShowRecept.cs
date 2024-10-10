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
    public partial class FrmGuest_ShowRecept : Form
    {
        public FrmGuest_ShowRecept(Recept recept)
        {
            InitializeComponent();

            //Skriver ut valt recept till formuläret
            txtName.Text = recept.Name;
            txtTypeOfRecept.Text = recept.TypeOfRecept;
            txtDescription.Text = recept.Description;
        }
    }
}
