using System.IO;
using System;
using System.Text.Json;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept_Handler
    {
        //public List<Recept> AllRecepts { get; set; }    

        //public Recept_Handler(List<Recept> allRecepts)
        //{
        //    AllRecepts = allRecepts;
        //}

        //Skapar
        public void Create(Recept recept)
        {
            try
            {
                if (recept.Id == Guid.Empty)
                {
                    recept.Id = Guid.NewGuid();
                }
                string filePath = FileDirectory.GetJsonReceptPath();
                string jsonRecept = JsonSerializer.Serialize(recept);
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(jsonRecept);
                }
                MessageBox.Show("Recept har lagts till");
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel inträffade när receptet skulle sparas.");
            }
        }

        //listar igenom alla
        public List<Recept> Read()
        {

            try
            {
                string jsonReceptFilePath = FileDirectory.GetJsonReceptPath();

                List<Recept> personList = new List<Recept>();
                //AllRecepts = new List<Recept>();
                using (StreamReader sr = new StreamReader(jsonReceptFilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Recept recept = JsonSerializer.Deserialize<Recept>(line);
                        personList.Add(recept);
                        //AllRecepts.Add(recept);
                    }
                }

                return personList;
            }

            catch (FileNotFoundException ex)
            {
                LogError(ex);
                MessageBox.Show("Receptfilen kunde inte hittas.");
                return new List<Recept>(); 
            }
            catch (JsonException ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel inträffade vid tolkning av receptdata.");
                return new List<Recept>(); 
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett oväntat fel inträffade när recepten skulle hämtas.");
                return new List<Recept>(); 
            }
        }


        //Uppdaterar
        public void Update(Guid receptId, Recept updatedRecept)
        {
            try
            {
                List<Recept> receptList = Read();
                var receptToUpdate = receptList.FirstOrDefault(recept => recept.Id == receptId);
                receptToUpdate.Name = updatedRecept.Name;
                receptToUpdate.Description = updatedRecept.Description;
                receptToUpdate.TypeOfRecept = updatedRecept.TypeOfRecept;

                WriteToFile(receptList);
                MessageBox.Show("Receptet har uppdaterats.");
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel inträffade när receptet skulle uppdateras.");
            }
        }


        //söker
        public List<Recept> ShowSearchResults(string keyWord, bool name, bool type)
        {
            // We take in a key word from the user and see if any recepts contain it. 
            // We then return a list to be displayed. 

            //Läsa in recept från filen  för att läsa in våra recept till listan AllRecepts
            var recepts = Read();
            var searchResults = new List<Recept>();

            if (name)
            {
                searchResults = recepts.Where(recept => recept.Name.Contains(keyWord))
                                .ToList();
                return searchResults;
            }
            else if (type)
            {
                searchResults = recepts.Where(recept => recept.TypeOfRecept.Contains(keyWord))
                                .ToList();
                return searchResults;
            }
            else
            {
                searchResults = recepts.Where(recept => recept.Name.Contains(keyWord) ||
                                                recept.Description.Contains(keyWord) ||
                                                recept.TypeOfRecept.Contains(keyWord))
                                                .ToList();
                return searchResults;
            }
        }

        //Delete
        public void Delete(Guid receptId)
        {
            try
            {
                List<Recept> receptList = Read();
                int removedCount = receptList.RemoveAll(recept => recept.Id == receptId);
                WriteToFile(receptList);
                MessageBox.Show("Receptet har tagits bort.");
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel inträffade när receptet skulle tas bort.");
            }
        }

        public void WriteToFile(List <Recept>receptList)
        {
            string filePath = FileDirectory.GetJsonReceptPath();
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (var recept in receptList)
                {
                    string jsonRecept = JsonSerializer.Serialize(recept);
                    sw.WriteLine(jsonRecept);
                }
            }
        }
        private void LogError(Exception ex)
        {
            string logFilePath = FileDirectory.GetErrorPath();
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine($"{DateTime.Now}: Ett fel inträffade - {ex.Message}");
                sw.WriteLine(ex.StackTrace);
            }
        }
    }
}
