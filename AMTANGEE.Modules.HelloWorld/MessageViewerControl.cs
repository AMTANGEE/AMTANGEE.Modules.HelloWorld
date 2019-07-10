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
    public partial class MessageViewerControl : UserControl
    {
        public MessageViewerControl()
        {
            InitializeComponent();
        }

        public void LoadData(AMTANGEE.SDK.Messages.MessageBase messageBase)
        {
            label1.Text = messageBase.Subject;
        }
    }
}
