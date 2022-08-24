namespace MyFarm.Animal
{
    public class Product
    {
        public string ProductType { get; set; }
        public string Name { get; set; }
        public int Mass { get; set; }

        public Product(string ProductType, string Name, int Mass)
        { 
            this.ProductType = ProductType;
            this.Name = Name;
            this.Mass = Mass;
        }
    }
}
