using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationProgramm
{
    class Ship
    {
        string _nameShip;
        string _speedShip;

        public Ship(string nameShip, string speedShip)
        {
            _nameShip = nameShip;
            _speedShip = speedShip;
        }

        public string GetInfo()
        {
            return $"{_nameShip} {_speedShip}";
        }
    }
}
