namespace MyFarm.Animal
{
    public class Building
    {
        public string BuildingType { get; set; }
        public int BuildingArea { get; set; }
        public int Capacity { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();

        public Building(string BuildingType, int BuildingArea, int Capacity)
        { 
            this.BuildingType = BuildingType;
            this.BuildingArea = BuildingArea;
            this.Capacity = Capacity;
        }
    }
}
