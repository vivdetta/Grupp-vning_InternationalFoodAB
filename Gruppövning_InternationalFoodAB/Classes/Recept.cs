using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeOfRecept {  get; set; }

        public Recept(string name, string description, string typeOfRecept)
        {
            Name = name;
            Description = description;
            TypeOfRecept = typeOfRecept;
        }
    }

}
