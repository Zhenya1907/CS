using MyFarm.Plant;
using MyFarm.Animal;

namespace MyFarm.Farm
{
    public class Farm
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public List<Patch> Patches { get; set; } = new List<Patch>();
        public List<Building> Buildings { get; set; } = new List<Building>();

        public Farm(string Name, int Area)
        {
            this.Name = Name;
            this.Area = Area;
        }
    }
}
