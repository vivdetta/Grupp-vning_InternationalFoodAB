using System.Text.Json;

namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept_Handler
    {
        public List<Recept> AllRecepts { get; set; }

        public Recept_Handler(List<Recept> allRecepts)
        {
            AllRecepts = allRecepts;
        }

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
                List<Recept> receptList = new List<Recept>();

                if (File.Exists(filePath))
                {
                    string existingJson = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(existingJson))
                    {
                        try
                        {
                            receptList = JsonSerializer.Deserialize<List<Recept>>(existingJson) ?? new List<Recept>();
                        }
                        catch (JsonException jsonEx)
                        {
                            MessageBox.Show($"JSON-fel: {jsonEx.Message}");
                            receptList = new List<Recept>(); 
                        }
                    }
                }

                receptList.Add(recept);
                AllRecepts.Add(recept);

                string jsonReceptList = JsonSerializer.Serialize(receptList, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, jsonReceptList);
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
                return AllRecepts;
            }
            catch (FileNotFoundException ex)
            {
                LogError(ex);
                MessageBox.Show("Receptfilen kunde inte hittas.");
                return new List<Recept>(); // Returnera tom lista om filen inte finns
            }
            catch (JsonException ex)
            {
                LogError(ex);
                MessageBox.Show("Ett fel inträffade vid tolkning av receptdata.");
                return new List<Recept>(); // Returnera tom lista vid deserialiseringsfel
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ett oväntat fel inträffade när recepten skulle hämtas.");
                return new List<Recept>(); // Returnera tom lista för alla andra typer av fel
            }
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

            //Läsa in recept från filen  för att läsa in våra recept till listan AllRecepts
            var temp = Read(); 
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
            string logFilePath = FileDirectory.GetErrorPath();
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine($"{DateTime.Now}: Ett fel inträffade - {ex.Message}");
                sw.WriteLine(ex.StackTrace);
            }
        }
    }
}
