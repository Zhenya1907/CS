using MyFarm.Animal;
using MyFarm.Plant;
using MyFarm.Reports;



namespace MyFarm
{
    public class Menu
    {
        public Building building;
        public Patch patch;
        public Animal.Animal animal;
        public Plant.Plant plant;

        public void UserMenu()
        {
            
        // ферма
            var farm = new Farm.Farm("My Happy Farm", 1000);
            var report = new Report();

            Console.WriteLine("Hello, this is your farm, it's empty now. You can create new objects, add them to the farm, receive reports");

            while (true)
            {
                Console.WriteLine("If you want to CREATE - 1, ADD - 2, GET REPORT - 3, EXIT - 0");
                var user_answer = Console.ReadLine();

                if (user_answer == "0")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

                // создание обьектов
                else if (user_answer == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("If you want to create: BUILDING - 1, PATCH - 2, ANIMAL - 3, PLANT - 4, MAIN MENU - 0");
                        var answer = Console.ReadLine();


                        if (answer == "0")
                        {
                            break;
                        }

                        else if (answer == "1")
                        {
                            // данные для создания здания
                            Console.WriteLine("Creation of a building. Write the name of the building, area and capacity.");
                            var building_type = Console.ReadLine();
                            int building_area = Convert.ToInt16(Console.ReadLine());
                            var capacity = Convert.ToInt16(Console.ReadLine());

                            building = new Building(building_type, building_area, capacity);

                            //report.CreateBuilding(building_type, building_area, capacity);
                        }

                        else if (answer == "2")
                        {
                            // данные для создания грядки
                            Console.WriteLine("Creation of a patch. Write the area of ​​the patch");
                            int patch_area = Convert.ToInt16(Console.ReadLine());

                            patch = new Patch(patch_area);

                            //report.CreatePatch(patch_area);
                        }

                        else if (answer == "3")
                        {
                            // данные для создания животного
                            Console.WriteLine("Creation of an animal. Write the name of the animal and the product that is made from it.");
                            var animal_type = Console.ReadLine();
                            var product_type = Console.ReadLine();

                            animal = new Animal.Animal(animal_type, product_type);

                            //report.CreateAnimal(animal_type, product_type);
                        }

                        else if (answer == "4")
                        {
                            // данные для создания растения
                            Console.WriteLine("Plant creation. Write the name, planting season, harvest season, area");
                            var plant_type = Console.ReadLine();
                            var planting_season = Console.ReadLine();
                            var harvest_season = Console.ReadLine();
                            int plant_area = Convert.ToInt16(Console.ReadLine());

                            plant = new Plant.Plant(plant_type, planting_season, harvest_season, plant_area);

                            //report.CreatePlant(plant_type, planting_season, harvest_season, plant_area);
                        }
                    }
                }

                // добавление обьектов
                else if (user_answer == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("If you want to add: BUILDING TO FARM - 1, PATCH TO FARM - 2, ANIMAL TO BUILDING - 3, PLANT TO PATCH - 4, MAIN MENU - 0");
                        var answer = Console.ReadLine();

                        if (answer == "0")
                        {
                            break;
                        }

                        else if (answer == "1")
                        {
                            report.AddNewBuildingToFarm(ref farm, ref building);
                        }

                        else if (answer == "2")
                        {
                            report.AddNewPatchToFarm(ref farm, ref patch);
                        }

                        else if (answer == "3")
                        {
                            report.AddNewAnimalToBuilding(ref building, ref animal);
                        }

                        else if (answer == "4")
                        {
                            report.AddNewPlantToPatch(farm, ref patch, ref plant);
                        }

                    }



                }

                else if (user_answer == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("If you want to get report: ABOUT FARM - 1, ABOUT PATCHES - 2, ABOUT ANIMALS - 3, MAIN MENU - 0");
                        var answer = Console.ReadLine();

                        if (answer == "0")
                        {
                            break;
                        }

                        if (answer == "1")
                        {
                            report.ShowFarmReport(farm);


                        }

                        if (answer == "2")
                        {
                            report.ShowPatchReport(farm);
                        }

                        if (answer == "3")
                        {
                            report.ShowAnimalReport(farm);
                        }

                    }
                }





            }



        }



    }
}
