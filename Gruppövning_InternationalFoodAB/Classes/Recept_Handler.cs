using System.IO;
using System;
using System.Text.Json;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept_Handler
    {
        //Skapar en nytt recept
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

        //Listar igenom alla filerna
        public List<Recept> Read()
        { 
            try
            {
                string jsonReceptFilePath = FileDirectory.GetJsonReceptPath();

                List<Recept> personList = new List<Recept>();
                using (StreamReader sr = new StreamReader(jsonReceptFilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Recept recept = JsonSerializer.Deserialize<Recept>(line);
                        personList.Add(recept);
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


        //Uppdaterar recepten i listan
        public void Update(Guid receptId, Recept updatedRecept)
        {
            try
            {
                List<Recept> receptList = Read();
                var receptToUpdate = receptList.FirstOrDefault(recept => recept.Id == receptId);

                if (receptToUpdate != null)
                {
                    //Uppdaterar fältet
                    receptToUpdate.Name = updatedRecept.Name;
                    receptToUpdate.Description = updatedRecept.Description;
                    receptToUpdate.TypeOfRecept = updatedRecept.TypeOfRecept;

                    WriteToFile(receptList);  //Sparar den uppdaterade listan till filen
                    MessageBox.Show("Receptet har uppdaterats.");
                }
                else
                {
                    MessageBox.Show("Receptet kunde inte hittas.");
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel inträffade när receptet skulle uppdateras.");
            }
        }
        //Sökresultaten
        public List<Recept> ShowSearchResults(string keyWord, bool name, bool type)
        {
            //Vi läser in sökordet som användaren skriver in och ser om något av recepten innehåller det
            //Sen returnenar vi listan för att visa innehållet
            //Läser sen in recept från filen för att läsa in våra de till listan AllRecepts
            var recepts = Read();
            var searchResults = new List<Recept>();

            if (name)
            {
                searchResults = recepts.Where(recept => recept.Name.ToLower().Contains(keyWord.ToLower()))
                                .ToList();
                return searchResults;
            }
            else if (type)
            {
                searchResults = recepts.Where(recept => recept.TypeOfRecept.ToLower().Contains(keyWord.ToLower()))
                                .ToList();
                return searchResults;
            }
            else
            {
                searchResults = recepts.Where(recept => recept.Name.ToLower().Contains(keyWord.ToLower()) ||
                                                recept.Description.ToLower().Contains(keyWord.ToLower()) ||
                                                recept.TypeOfRecept.ToLower().Contains(keyWord.ToLower()))
                                                .ToList();
                return searchResults;
            }
        }

        //Ta bort ett recept
        public void Delete(Guid receptId)
        {
            try
            {
                List<Recept> receptList = Read();
                var receptToRemove = receptList.FirstOrDefault(recept => recept.Id == receptId);

                if (receptToRemove != null)
                {
                    receptList.Remove(receptToRemove);  //Tar bort receptet
                    WriteToFile(receptList);  //Spara den uppdaterade listan till filen
                    MessageBox.Show("Receptet har tagits bort.");
                }
                else
                {
                    MessageBox.Show("Receptet kunde inte hittas.");
                }
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
