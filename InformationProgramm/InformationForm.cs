using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationProgramm
{
    public partial class InformationForm : Form
    {
        IInformation information = new Ports();
        public InformationForm()
        {
            InitializeComponent();
            information.PrintInformation(InformationLb);
        }

        private void InformationLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            information.PrintMoreInformation(MoreInformationLb, InformationLb.SelectedItem.ToString());
        }
    }
}
