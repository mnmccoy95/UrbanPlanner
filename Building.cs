using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "Morrigan McCoy";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}
        public double Volume
        {
            get
            {
                return Width*Depth*(3*Stories);
            }
        }

        public Building(string address, int stories, double width, double depth) {
            _address = address;
            Stories = stories;
            Width = width;
            Depth = depth;
        }

        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string person) {
            _owner = person;
        }

        public string GetBuildingInfo()
        {
            return $@"
            {_address}
            ---------------
            Designed by {_designer}
            Constructed on {_dateConstructed}
            Owned by {_owner}";
        }
    }
}