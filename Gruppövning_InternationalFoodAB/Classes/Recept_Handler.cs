using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept_Handler
    {
        public List<Recept> AllRecepts { get; set; }

        public Recept_Handler(List<Recept> allRecepts)
        {
            AllRecepts = allRecepts;
        }
    }
}
