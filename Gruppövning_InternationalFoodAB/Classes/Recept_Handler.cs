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

        public List<Recept> ShowSearchResults(string keyWord)
        {
            // We take in a key word from the user and see if any recepts contain it. 
            // We then return a list to be displayed. 
            var searchResults = AllRecepts.Where(recept => recept.Name.Contains(keyWord) || 
                                            recept.Description.Contains(keyWord) ||
                                            recept.TypeOfRecept.Contains(keyWord))
                                            .ToList();
            return searchResults;
        }
    }
}
