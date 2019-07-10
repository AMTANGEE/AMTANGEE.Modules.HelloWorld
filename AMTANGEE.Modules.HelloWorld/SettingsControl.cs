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
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
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
            edtValue1.Text = AMTANGEE.SDK.Settings.Global["AMTANGEE.Modules.HelloWorld"]["Value1"];
            edtValue2.Text = AMTANGEE.SDK.Settings.Global["AMTANGEE.Modules.HelloWorld"]["Value2"];
            edtValue3.Text = AMTANGEE.SDK.Settings.Global["AMTANGEE.Modules.HelloWorld"]["Value3"];
            _modified = false;
        }

        public void SaveData()
        {
            AMTANGEE.SDK.Settings.Global["AMTANGEE.Modules.HelloWorld"]["Value1"] = edtValue1.Text;
            AMTANGEE.SDK.Settings.Global["AMTANGEE.Modules.HelloWorld"]["Value2"] = edtValue2.Text;
            AMTANGEE.SDK.Settings.Global["AMTANGEE.Modules.HelloWorld"]["Value3"] = edtValue3.Text;
        }

        private void edtValue1_TextChanged(object sender, EventArgs e)
        {
            _modified = true;
        }
    }
}
