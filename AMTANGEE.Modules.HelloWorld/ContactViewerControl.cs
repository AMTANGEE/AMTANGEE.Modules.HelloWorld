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
    public partial class ContactViewerControl : UserControl
    {
        public ContactViewerControl()
        {
            InitializeComponent();
        }

        public void LoadData(AMTANGEE.SDK.Contacts.ContactBase contact)
        {
            label2.Text = contact.ToString();
        }
    }
}
