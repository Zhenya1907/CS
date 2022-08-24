namespace MyFarm.Animal
{
    public class Animal
    {
        public string AnimalType { get; set; }   
        public string ProductType { get; set; }


        public Animal(string AnimalType, string ProductType)
        { 
            this.AnimalType = AnimalType;
            this.ProductType = ProductType;
        }
    }
}
