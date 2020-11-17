using System;
using System.Collections.Generic;

namespace Planner
{
    public class City 
    {
        private string _cityName;
        private string _cityMayor;
        private int _cityEst;
        public List<Building> Buildings;
        public City(string name, string mayor, int est, List<Building> buildings) {
            _cityName = name;
            _cityMayor = mayor;
            _cityEst = est;
            Buildings = buildings;
        }
    }
}