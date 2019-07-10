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
    public partial class ContactTabPluginControl : UserControl
    {
        public ContactTabPluginControl()
        {
            InitializeComponent();
        }

        public void LoadData(AMTANGEE.SDK.Contacts.ContactBase cb)
        {
            label2.Text = cb.ToString();
        }

        public void SaveData()
        { }
    }
}
