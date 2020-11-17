using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("100 Road Way", 1, 1, 1);
            building1.Construct();
            building1.Purchase("Mike Stoklasa");
            Building building2 = new Building("100 Road Way", 1, 1, 1);
            building2.Construct();
            building2.Purchase("Mike Stoklasa");
            Building building3 = new Building("100 Road Way", 1, 1, 1);
            building3.Construct();
            building3.Purchase("Mike Stoklasa");

            List<Building> buildings = new List<Building>();
            buildings.Add(building1);
            buildings.Add(building2);
            buildings.Add(building3);

            City town = new City("Placeville", "MayorMan", 1201, buildings);

            foreach (Building building in town.Buildings)
            {
                Console.WriteLine($@"
                {building.GetBuildingInfo()}
            {building.Volume} cubic meters of space
                ");
            }
        }
    }
}
