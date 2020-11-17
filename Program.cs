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
            {building1.GetAddress()}
            ---------------
            Designed by {building1.GetDesigner()}
            Constructed on {building1.GetDate()}
            Owned by {building1.GetOwner()}
            {building1.Volume} cubic meters of space
            ");
        }
    }
}
