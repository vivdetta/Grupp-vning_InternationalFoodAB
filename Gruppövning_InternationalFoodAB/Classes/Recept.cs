namespace Gruppövning_InternationalFoodAB.Classes
{
    public class Recept
    {
        public Guid Id { get; set; } //Lägger till en GUID (Global Unique Identifier) för unika recept
        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeOfRecept {  get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
