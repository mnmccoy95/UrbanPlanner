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

        public Building(string address) {
            _address = address;
        }

        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string person) {
            _owner = person;
        }

        public string GetDesigner()
        {
            return _designer;
        }

        public string GetAddress()
        {
            return _address;
        }

        public DateTime GetDate()
        {
            return _dateConstructed;
        }

        public string GetOwner()
        {
            return _owner;
        }
    }
}