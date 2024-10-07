namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept
    {
        public Guid Id { get; set; } // Lägg till Guid för unika recept
        public string Name { get; set; }
        public string Description { get; set; }

        public string TypeOfRecept {  get; set; }

        //public Recept(string name, string description, string typeOfRecept, Guid id)
        //{
        //    Id = Guid.NewGuid(); // Generera ett nytt unikt Id när receptet skapas
        //    Name = name;
        //    Description = description;
        //    TypeOfRecept = typeOfRecept;
        //}
    }
}
