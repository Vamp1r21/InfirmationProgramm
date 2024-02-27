using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationProgramm
{
    class Port
    {
        string _namePort;
        List<Ship> _ships = new List<Ship>();

        public Port(string namePort, List<string> ships, List<string> speedShips)
        {
            _namePort = namePort;
            for(int i=0; i<ships.Count; i++)
            {
                _ships.Add(new Ship(ships[i], speedShips[i]));
            }
        }

        public string GetNamePort()
        {
            return _namePort;
        }

        public List<string> GetShips()
        {
            List<string> ships = new List<string>();
            foreach(Ship ship in _ships)
            {
                ships.Add(ship.GetInfo());
            }
            return ships;
        }
    }
}
