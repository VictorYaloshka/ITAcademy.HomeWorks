
namespace HW12.RP_Console
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
        public int Price { get; set; }


        public Motorcycle(int Id, string Name, string Model, int Year, int Odometer, int Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Model = Model;
            this.Year = Year;
            this.Odometer = Odometer;
            this.Price = Price;
        }

        public Motorcycle()
        {
        }
    }
}
