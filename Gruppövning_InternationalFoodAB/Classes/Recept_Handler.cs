using System.Text.Json;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept_Handler
    {
        public List<Recept> AllRecepts { get; set; }

        private readonly string logFilePath = "Errorlog/errorLog.txt";

        //Skapar
        public void Create(Recept recept)
        {
            try
            {
                if (recept.Id == Guid.Empty)
                {
                    recept.Id = Guid.NewGuid();
                }

                string jsonRecept = JsonSerializer.Serialize(recept);
                string filePath = FileDirectory.GetJsonReceptPath();

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
            List<Recept> receptList = new List<Recept>();

            try
            {
                string filepath = FileDirectory.GetJsonReceptPath();

                using (StreamReader sr = new StreamReader(filepath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Recept recept = JsonSerializer.Deserialize<Recept>(line);
                        if (recept != null)
                        {
                            receptList.Add(recept);
                            AllRecepts.Add(recept);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                LogError(ex);
                MessageBox.Show("Receptfilen kunde inte hittas.");
            }
            catch (JsonException ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel inträffade vid tolkning av receptdata.");
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett oväntat fel inträffade när recepten skulle hämtas.");
            }

            return receptList;
        }

        //Uppdaterar
        public void Update(Guid receptId, Recept updatedRecept)
        {
            try
            {
                var receptToUpdate = AllRecepts.FirstOrDefault(recept => recept.Id == receptId);
                receptToUpdate.Name = updatedRecept.Name;
                receptToUpdate.Description = updatedRecept.Description;
                receptToUpdate.TypeOfRecept = updatedRecept.TypeOfRecept;

                WriteToFile();
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

            AllRecepts = Read(); //Läsa in recept från filen

            var searchResults = new List<Recept>();

            if (name)
            {
                searchResults = AllRecepts.Where(recept => recept.Name.Contains(keyWord))
                                .ToList();
                return searchResults;
            }
            else if (type)
            {
                searchResults = AllRecepts.Where(recept => recept.TypeOfRecept.Contains(keyWord))
                                .ToList();
                return searchResults;
            }
            else
            {
                searchResults = AllRecepts.Where(recept => recept.Name.Contains(keyWord) ||
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
                int removedCount = AllRecepts.RemoveAll(recept => recept.Id == receptId);
                WriteToFile();
                MessageBox.Show("Receptet har tagits bort.");
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel inträffade när receptet skulle tas bort.");
            }
        }

        public void WriteToFile()
        {
            string filePath = FileDirectory.GetJsonReceptPath();
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (var recept in AllRecepts)
                {
                    string jsonRecept = JsonSerializer.Serialize(recept);
                    sw.WriteLine(jsonRecept);
                }
            }
        }
        private void LogError(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine($"{DateTime.Now}: Ett fel inträffade - {ex.Message}");
                sw.WriteLine(ex.StackTrace);
            }
        }
    }
}
