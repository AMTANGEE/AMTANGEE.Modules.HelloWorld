using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMTANGEE.Modules.HelloWorld
{
    public partial class ModuleControl : UserControl
    {
        public ModuleControl()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            label2.Text = AMTANGEE.SDK.License.LicensedTo + " "  +  AMTANGEE.SDK.License.Type.ToString() +  " ("  + AMTANGEE.SDK.License.Users.ToString() + ")";
        }
    }
}
