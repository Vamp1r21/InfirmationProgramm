using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationProgramm
{
    class Ports: IInformation
    {
        List<Port> _ports = new List<Port>();

        public Ports()
        {
            List<string> ships = new List<string>();
            List<string> shipsSpeed = new List<string>();
            string namePort = "";
            var file = File.ReadAllLines("../../Folder/ship.txt");
            string[] decemitional = { " ", "  ", "\t" };
            foreach(string fileElement in file)
            {
                string[] masElem = fileElement.Split(decemitional, StringSplitOptions.RemoveEmptyEntries);
                if(namePort!=masElem[0] && namePort!="")
                {
                    _ports.Add(new Port(namePort, ships, shipsSpeed));
                    ships.Clear();
                    shipsSpeed.Clear();
                    namePort = masElem[0];
                }
                namePort = masElem[0];
                ships.Add(masElem[1]);
                shipsSpeed.Add(masElem[2]);
                
            }
            _ports.Add(new Port(namePort, ships, shipsSpeed));
        }

        public void PrintInformation(ListBox informationBox)
        {
            informationBox.Items.Clear();
            List<string> portsName = GetPortsName();
            foreach(string port in portsName)
            {
                informationBox.Items.Add(port);
            }
        }

        List<string> GetPortsName()
        {
            List<string> portsName = new List<string>();
            foreach(Port port in _ports)
            {
                portsName.Add(port.GetNamePort());
            }
            return portsName;
        }
        public void PrintMoreInformation(ListBox informationBox, string nameElement)
        {
            informationBox.Items.Clear();
            List<string> ships = GetShips(nameElement);
            foreach (string ship in ships)
            {
                informationBox.Items.Add(ship);
            }
        }

        List<string> GetShips(string nameElement)
        {
            List<string> ship = new List<string>();
            foreach (Port port in _ports)
            {
                if(nameElement==port.GetNamePort())
                {
                    ship = port.GetShips();
                    break;
                }
            }
            return ship;
        }
    }
}
