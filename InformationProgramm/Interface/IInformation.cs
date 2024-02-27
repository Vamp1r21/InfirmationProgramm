using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationProgramm
{
    interface IInformation
    {
        void PrintInformation(ListBox informationBox);
        void PrintMoreInformation(ListBox informationBox, string nameElement);
    }
}
