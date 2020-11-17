using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("100 Road Way");
            building1.Width = 1;
            building1.Depth = 1;
            building1.Stories = 1;
            building1.Construct();
            building1.Purchase("Mike Stoklasa");
            Console.WriteLine($@"
            {building1.GetBuildingInfo()}
            {building1.Volume} cubic meters of space
            ");
        }
    }
}
