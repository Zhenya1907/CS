namespace MyFarm.Plant
{
    public class Patch
    {
        public int PatchArea { get; set; }
        public List<Plant> Plants { get; set; } = new List<Plant>();


        public Patch(int PatchArea)
        {
            this.PatchArea = PatchArea;
        }
    }
}
