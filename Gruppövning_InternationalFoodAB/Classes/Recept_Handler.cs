using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept_Handler
    {
        public Guid Id { get; set; }
        public List<Recept> AllRecepts { get; set; }
        private string path;

        public Recept_Handler(List<Recept> allRecepts, string filePath)
        {
            AllRecepts = allRecepts;
            path = filePath;
        }

        public void Create(Recept recept)
        {
            if (recept.Id == Guid.Empty)
            {
            }

            string jsonRecepts = JsonSerializer.Serialize(recept);

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(jsonRecepts);
                }
                //Visa medelande nånstans
                //Console.WriteLine("Receptet har sparats.");
            }
            catch (Exception ex)
            {
                //Visa medelande nånstans
                //Console.WriteLine($"Ett fel inträffade vid sparning av recept: {ex.Message}");
            }
        }
    }

}
