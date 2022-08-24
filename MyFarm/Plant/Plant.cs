namespace MyFarm.Plant
{
    public class Plant
    {
        public string PlantType { get; set; }
        public string PlantingSeason { get; set; }
        public string HarvestSeason { get; set; }
        public int PlantArea { get; set; }

        public Plant(string PlantType, string PlantingSeason, string HarvestSeason, int PlantArea)
        { 
            this.PlantType = PlantType;
            this.PlantingSeason = PlantingSeason;
            this.HarvestSeason = HarvestSeason;
            this.PlantArea = PlantArea;
        }

    }
}
