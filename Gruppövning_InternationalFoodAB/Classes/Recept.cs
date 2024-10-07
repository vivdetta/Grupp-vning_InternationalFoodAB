namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeOfRecept {  get; set; }
        public Guid Id { get; set; }

        public Recept(string name, string description, string typeOfRecept, Guid id)
        {
            Name = name;
            Description = description;
            TypeOfRecept = typeOfRecept;
            Id = id;
        }
    }
}
