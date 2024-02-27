using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationProgramm
{
    class SystemInformation: IInformation
    {
        List<string> _propertyName = new List<string>();
        List<string> _propertyInfo = new List<string>();

        public SystemInformation()
        {
            GetInfo("Win32_OperatingSystem");
            GetInfo("Win32_VideoController");
        }

        public void PrintInformation(ListBox informationBox)
        {
            informationBox.Items.Clear();
            foreach (string property in _propertyName)
            {
                informationBox.Items.Add(property);
            }
        }

        void GetInfo(string chapter)
        {
            List<string> information = new List<string>();

            ManagementClass managment = new ManagementClass(chapter);

            ManagementObjectCollection objects = managment.GetInstances();
            PropertyDataCollection properties = managment.Properties;

            foreach (ManagementObject objectInfo in objects)
            {
                foreach (PropertyData property in properties)
                {
                    Object propertyValue = objectInfo[property.Name];
                    if (propertyValue != null)
                    {
                        _propertyName.Add(property.Name);
                        _propertyInfo.Add(propertyValue.ToString());
                    }
                }
            }
        }

        public void PrintMoreInformation(ListBox informationBox, string nameElement)
        {
           informationBox.Items.Clear();
           string propetryValues = GetProperty(nameElement); 
           informationBox.Items.Add(propetryValues);
        }

        string GetProperty(string propertyName)
        {
            string name = "";
            for (int i = 0; i < _propertyName.Count; i++)
            {
                if(propertyName==_propertyName[i])
                {
                    name = _propertyInfo[i];
                }
            }
            return name;
        }
    }
}
