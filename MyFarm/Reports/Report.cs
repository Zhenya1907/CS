using MyFarm.Farm;
using MyFarm.Plant;
using MyFarm.Animal;
using System;


namespace MyFarm.Reports
{
    public class Report
    {
        //  СОЗДАНИЕ 

        // создание растения
        public void CreatePlant(string PlantType, string PlantingSeason, string HarvestSeason, int PlantArea)
        {

            Plant.Plant plant = new Plant.Plant(PlantType, PlantingSeason, HarvestSeason, PlantArea);
            Console.WriteLine($"Created a new plant: {PlantType}");
           
        }
        // создание животного
        public void CreateAnimal(string AnimalType, string ProductType)
        {
            Animal.Animal animal = new Animal.Animal(AnimalType, ProductType);
            Console.WriteLine($"Created a new animal: {AnimalType}");
        }

        // создание грядки
        public void CreatePatch(int PatchArea)
        {

            Patch patch = new Patch(PatchArea);
            Console.WriteLine($"Created a new patch");

        }

        // создание здания
        public void CreateBuilding(string BuildingType, int BuildingArea, int Capacity)
        {
            Building building = new Building(BuildingType, BuildingArea, Capacity);
            Console.WriteLine($"Created a new building");
        }


        // ДОБАВЛЕНИЕ

        // добавление грядки на ферму
        public void AddNewPatchToFarm(ref Farm.Farm farm, ref Plant.Patch patch)
        {
            farm.Patches.Add(patch);
            Console.WriteLine($"+ New patch was added to the farm.\n");
        }

        // добавление здания на ферму
        public void AddNewBuildingToFarm(ref Farm.Farm farm, ref Animal.Building building)
        {
            farm.Buildings.Add(building);
            Console.WriteLine($"+ New building was added to the farm.\n");
        }


        // добавление растения на грядку
        public void AddNewPlantToPatch(Farm.Farm farm, ref Plant.Patch patch, ref Plant.Plant plant)
        {
            int area = AllPlantsArea(farm);

            if (area >= patch.PatchArea)
            {
                Console.WriteLine($"The patch is full. You can not to add new plant.");
            }
            else
            {
                patch.Plants.Add(plant);
                Console.WriteLine($"+ {plant.PlantType} was added to the patch.\n");
            }

        }

        // добавление животного в здание
        public void AddNewAnimalToBuilding(ref Animal.Building building, ref Animal.Animal animal)
        {
            building.Animals.Add(animal);
            Console.WriteLine($"+ {animal.AnimalType} was added to the building.\n");
        }

  



        // ЗАНИМАЕМАЯ ПЛОЩАДЬ
        // площадь, занимаемая растениями
        public int AllPlantsArea(Farm.Farm farm)
        {
            int result = 0;
            foreach (var patch in farm.Patches)
            {
                foreach (var plant in patch.Plants)
                {
                    result = result + plant.PlantArea;
                }
            }
            return result;
        }

        // площадь, занимаемая грядками
        public void AllPatchesArea(ref Farm.Farm farm, out int result)
        {
            result = 0;
            foreach (var patch in farm.Patches)
            {
                result = result + patch.PatchArea;
            }
        }

        // площадь, занимаемая зданиями
        public void AllBuildingsArea(ref Farm.Farm farm, out int result)
        {
            result = 0;
            foreach (var build in farm.Buildings)
            {
                result = result + build.BuildingArea;
            }
        }


        // ОТЧЕТЫ
        // отчет ферме
        public void ShowFarmReport(MyFarm.Farm.Farm farm)
        {
            Console.WriteLine($"Name of farm: {farm.Name}\nArea: {farm.Area}\nNamber of patches: {farm.Patches.Count}\nNumber of buildings: {farm.Buildings.Count}\n");
        }

        // отчет по грядкам
        public void ShowPatchReport(MyFarm.Farm.Farm farm)
        {
            var i = 1;
            var plants_count = 0;
            var PERCENT_100 = 100;

            foreach (var patch in farm.Patches)
            {
                List<string> plants_spam = new List<string>();

                // список уникальных растений на грядке
                foreach (var plant in patch.Plants.Distinct())
                {
                    plants_spam.Add(plant.PlantType.ToString());
                }

                // площадь на грядке, занимаемая всеми растениями

                foreach (var plant in patch.Plants)
                {
                    plants_count = plants_count + plant.PlantArea;
                }

                // процент заполненности грядки
                var percent_full = plants_count * PERCENT_100 / patch.PatchArea;

                Console.WriteLine($"Patch {i}:\nArea - {patch.PatchArea} | All unique plants - {String.Join(" ", plants_spam)} | Fullness of the patch - {percent_full}% |\n");

                i = i + 1;
            }

        }

        // отчет по животным
        public void ShowAnimalReport(MyFarm.Farm.Farm farm)
        {
            var i = 1;
            var PERCENT_100 = 100;

            foreach (var building in farm.Buildings)
            {
                List<string> animal_spam = new List<string>();

                // список уникальных животных в строении
                foreach (var animal in building.Animals.Distinct())
                {
                    animal_spam.Add(animal.AnimalType.ToString());
                }

                // процент заполненности здания
                var percent_full = building.Animals.Count() * PERCENT_100 / building.Capacity;

                Console.WriteLine($"Building {i}:\nAll unique animals - {String.Join(" ", animal_spam)} | Fullness of the building - {percent_full}% |\n");

                i = i + 1;

            }
        }







    }


}
