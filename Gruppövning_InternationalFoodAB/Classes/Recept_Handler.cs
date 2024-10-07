using System.Text.Json;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept_Handler
    {
        public List<Recept> AllRecepts { get; set; }
        private string filePath = "recepts.json"; 


        //public Recept_Handler(List<Recept> allRecepts)
        //{
        //    AllRecepts = allRecepts;

        //}

        //Skapar
        public void Create(Recept recept)
        {
            if (recept.Id == Guid.Empty)
            {
                recept.Id = Guid.NewGuid();
            }

            string jsonRecept = JsonSerializer.Serialize(recept); 
            using (StreamWriter sw = new StreamWriter(filePath, true)) 
            {
                sw.WriteLine(jsonRecept);
            }
            MessageBox.Show("Recept har lagts till");
        }
        //listar igenom alla
        public void Read()
        {
            //List<Recept> receptList = new List<Recept>();
            using (StreamReader sr = new StreamReader(filePath)) 
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Recept recept = JsonSerializer.Deserialize<Recept>(line);
                    AllRecepts.Add(recept);
                }
            }
            //return receptList;
        }
        //Uppdaterar
        public void Update(Guid receptId, Recept updatedRecept)
        {
            //List<Recept> receptList = Read();
            var receptToUpdate = AllRecepts.FirstOrDefault(recept => recept.Id == receptId);

            if (receptToUpdate != null)
            {
                receptToUpdate.Name = updatedRecept.Name;
                receptToUpdate.Description = updatedRecept.Description;
                receptToUpdate.TypeOfRecept = updatedRecept.TypeOfRecept;

                WriterToFile();
                MessageBox.Show("Receptet har uppdaterats.");
            }
            else
            {
                MessageBox.Show("Kunde inte hitta receptet för att uppdatera.");
            }
        }

        //söker
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
        //Delete
        public void Delete(Guid receptId)
        {
            //List<Recept> receptList = Read();
            AllRecepts.RemoveAll(recept => recept.Id == receptId);
            WriterToFile();

            MessageBox.Show("Receptet har tagits bort.");
        }

        public void WriterToFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (var recept in AllRecepts)
                {
                    string jsonRecept = JsonSerializer.Serialize(recept);
                    sw.WriteLine(jsonRecept);
                }
            }
        }
    }
}
