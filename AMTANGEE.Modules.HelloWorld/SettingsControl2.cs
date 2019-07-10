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
    public partial class SettingsControl2 : UserControl
    {
        public SettingsControl2()
        {
            InitializeComponent();
        }

        bool _modified = false;
        public bool Modified
        {
            get
            {
                return _modified;
            }
        }

        public void LoadData()
        {
            edtValue4.Text = AMTANGEE.SDK.Settings.PerUser["AMTANGEE.Modules.HelloWorld"]["Value4"];
            edtValue5.Text = AMTANGEE.SDK.Settings.PerUser["AMTANGEE.Modules.HelloWorld"]["Value5"];
            edtValue6.Text = AMTANGEE.SDK.Settings.PerUser["AMTANGEE.Modules.HelloWorld"]["Value6"];
            _modified = false;
        }

        public void SaveData()
        {
            AMTANGEE.SDK.Settings.PerUser["AMTANGEE.Modules.HelloWorld"]["Value4"] = edtValue4.Text;
            AMTANGEE.SDK.Settings.PerUser["AMTANGEE.Modules.HelloWorld"]["Value5"] = edtValue5.Text;
            AMTANGEE.SDK.Settings.PerUser["AMTANGEE.Modules.HelloWorld"]["Value6"] = edtValue6.Text;
        }

        private void edtValue1_TextChanged(object sender, EventArgs e)
        {
            _modified = true;
        }
    }
}
