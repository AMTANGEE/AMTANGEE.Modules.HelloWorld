using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMTANGEE.Administration;
using AMTANGEE.Interfaces;
using AMTANGEE.Interfaces.Contacts;
using AMTANGEE.Interfaces.Messages;
using AMTANGEE.SDK;
using AMTANGEE.SDK.Campaigns;
using AMTANGEE.SDK.Contacts;
using AMTANGEE.SDK.Messages;
using DevExpress.XtraBars;

namespace AMTANGEE.Modules.HelloWorld
{
    public class HelloWorldModule : AMTANGEE.Interfaces.IModule
    {


        string IModule.Caption
        {
            get
            {
                return "Hello World";
            }
        }

        System.Drawing.Image IModule.Image
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        System.Drawing.Image IModule.Image24
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images24[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        System.Windows.Forms.UserControl IModule.ModuleControl
        {
            get
            {
                ModuleControl mc = new ModuleControl();
                mc.LoadData();
                return mc;
            }
        }

        string IModule.Name
        {
            get
            {
                return "Hello World";
            }
        }

        bool IModule.NeedsLicense
        {
            get
            {
                return false;
            }
        }

        string IModule.StatusBarText
        {
            get
            {
                return "Hello World";
            }
        }

        bool IModule.Visible
        {
            get
            {
                return true;
            }
        }

        void IModule.Activated()
        {
        }

        bool IModule.CheckRequirements()
        {
            return true;
        }

        void IModule.Deactivated()
        {
        }

        void IModule.Initialize()
        {
        }

        void IModule.ProcessEvent(string theEvent)
        {
        }
    }

    public class HelloWorldSettingsAdministration : AMTANGEE.Administration.IAdministrationPlugin
    {
        SettingsControl sc = null;
        Control IAdministrationPlugin.Control
        {
            get
            {
                if (sc == null)
                    sc = new SettingsControl();
                sc.LoadData();
                return sc;
            }
        }

        string IAdministrationPlugin.Description
        {
            get
            {
                return "Hello World";
            }
        }

        Image IAdministrationPlugin.GroupImage
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        string IAdministrationPlugin.GroupName
        {
            get
            {
                return "Hello World";
            }
        }

        Image IAdministrationPlugin.Image
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        Image IAdministrationPlugin.Image32
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images32[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        bool IAdministrationPlugin.Modified
        {
            get
            {
                if (sc != null)
                    return sc.Modified;

                return false;
            }
        }

        string IAdministrationPlugin.Name
        {
            get
            {
                return "Hello World Administration";
            }
        }

        bool IAdministrationPlugin.Visible
        {
            get
            {
                return AMTANGEE.SDK.Global.CurrentUser.IsAdministrator;
            }
        }

        bool IAdministrationPlugin.CancelEditor()
        {
            return true;
        }

        void IAdministrationPlugin.Save()
        {
            if (sc != null)
                sc.SaveData();
        }
    }

    public class HelloWorldSettingsPerUser : AMTANGEE.Administration.IAdministrationPlugin
    {
        SettingsControl2 sc = null;
        Control IAdministrationPlugin.Control
        {
            get
            {
                if(sc ==null)
                    sc = new SettingsControl2();
                sc.LoadData();
                return sc;
            }
        }

        string IAdministrationPlugin.Description
        {
            get
            {
                return "Hello World";
            }
        }

        Image IAdministrationPlugin.GroupImage
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        string IAdministrationPlugin.GroupName
        {
            get
            {
                return "Hello World";
            }
        }

        Image IAdministrationPlugin.Image
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        Image IAdministrationPlugin.Image32
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images32[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        bool IAdministrationPlugin.Modified
        {
            get
            {
                if (sc != null)
                    return sc.Modified;

                return false;
            }
        }

        string IAdministrationPlugin.Name
        {
            get
            {
                return "Hello World Per User";
            }
        }

        bool IAdministrationPlugin.Visible
        {
            get
            {
                return true;
            }
        }

        bool IAdministrationPlugin.CancelEditor()
        {
            return true;
        }

        void IAdministrationPlugin.Save()
        {
            if (sc != null)
                sc.SaveData();
        }
    }

    public class HelloWorldNewMenuPlugin : AMTANGEE.Interfaces.INewMenuPlugin
    {
        IList<NewMenuEntry> INewMenuPlugin.Entries(ContactBase contact)
        {
            var result = new SDK.List<NewMenuEntry>();
            NewMenuEntry nme = new NewMenuEntry(AMTANGEE.SDK.Resources.Images[Resources.ImageIndexes.AMTANGEE], "Hello World");
            result.Add(nme);
            return result;
        }

        void INewMenuPlugin.EntryClicked(NewMenuEntry entry, ContactBase contact)
        {
            SDK.MessageBox.Show("Entry '" + entry.Caption + "' clicked!");
        }
    }

    public class HelloWorldContactTabPlugin : AMTANGEE.Interfaces.Contacts.IContactTabControlPlugin
    {
        string IContactTabControlPlugin.Caption
        {
            get
            {
                return "Hello World";
            }
        }

        ContactTabPluginControl ctpc = null;
        Control IContactTabControlPlugin.Control
        {
            get
            {
                if (ctpc == null)
                    ctpc = new ContactTabPluginControl();

                return ctpc;
            }
        }

        bool IContactTabControlPlugin.HasData
        {
            get
            {
                return true;
            }
        }

        Image IContactTabControlPlugin.Image
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        bool IContactTabControlPlugin.Modified
        {
            get
            {
                return false;
            }
        }

        bool IContactTabControlPlugin.Visible
        {
            get
            {
                return true;
            }
        }

        void IContactTabControlPlugin.ActivateField(string fieldName)
        {
            
        }

        bool IContactTabControlPlugin.CanClose(bool escapePressed)
        {
            return true;
        }

        void IContactTabControlPlugin.Create(ContactBase contact, IContactTabControl contactTabControl)
        {
            if(ctpc == null)
                ctpc = new ContactTabPluginControl();
            ctpc.LoadData(contact);
        }

        void IContactTabControlPlugin.Save()
        {
            if (ctpc != null)
                ctpc.SaveData();
        }
    }

    public class HelloWorldContactViewerPlugin : AMTANGEE.Interfaces.Contacts.IContactViewerPlugin
    {
        string IContactViewerPlugin.Caption
        {
            get
            {
                return "Hello World";
            }
        }

        ContactViewerControl cvc = null;
        Control IContactViewerPlugin.Control
        {
            get
            {
                if (cvc == null)
                    cvc = new ContactViewerControl();
                return cvc;
            }
        }

        Image IContactViewerPlugin.Image
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[Resources.ImageIndexes.AMTANGEE];
            }
        }

        bool IContactViewerPlugin.Visible
        {
            get
            {
                return true;
            }
        }

        void IContactViewerPlugin.Create(ContactBase contact)
        {
            if (cvc == null)
                cvc = new ContactViewerControl();
            cvc.LoadData(contact);
        }
    }

    public class HelloWorldContactMenuPlugin : AMTANGEE.Interfaces.Contacts.IContactMenuPlugin, AMTANGEE.Interfaces.Contacts.IContactsMenuPlugin
    {
        public string Caption
        {
            get
            {
                return "Hello World";
            }
        }

        public Image Image
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        public IDictionary<global::DevExpress.XtraBars.BarItem, bool> SubMenuEntries(Contacts contacts, Campaign campaign, Members campaignMembers)
        {
            var result = new SDK.Dictionary<DevExpress.XtraBars.BarItem, bool>();

            DevExpress.XtraBars.BarItem bi = new DevExpress.XtraBars.BarButtonItem();
            bi.Caption = "Hello World 1";
            bi.ItemClick += Bi_ItemClick;
            result.Add(bi, true);

            DevExpress.XtraBars.BarItem bi2 = new DevExpress.XtraBars.BarButtonItem();
            bi2.Caption = "Hello World 2";
            bi2.ItemClick += Bi_ItemClick;
            result.Add(bi2, false);

            return result;
        }

        public IDictionary<global::DevExpress.XtraBars.BarItem, bool> SubMenuEntries(ContactBase contact, Campaign campaign, Member member)
        {
            var result = new SDK.Dictionary<DevExpress.XtraBars.BarItem, bool>();

            DevExpress.XtraBars.BarItem bi = new DevExpress.XtraBars.BarButtonItem();
            bi.Caption = "Hello World 1";
            bi.ItemClick += Bi_ItemClick;
            result.Add(bi, true);

            DevExpress.XtraBars.BarItem bi2 = new DevExpress.XtraBars.BarButtonItem();
            bi2.Caption = "Hello World 2";
            bi2.ItemClick += Bi_ItemClick;
            result.Add(bi2, false);

            return result;
        }

        private void Bi_ItemClick(object sender, ItemClickEventArgs e)
        {
            AMTANGEE.SDK.MessageBox.Show("Entry '" + e.Item.Caption + "' clicked!");
        }

        public bool Visible(Contacts contacts)
        {
            return true;
        }

        public bool Visible(ContactBase contact)
        {
            return true;
        }
    }

    public class HelloWorldMessageViewerPlugin : AMTANGEE.Interfaces.Messages.IMessageViewerPlugin
    {
        string IMessageViewerPlugin.Caption
        {
            get
            {
                return "Hello World";
            }
        }

        MessageViewerControl mvc = null;
        Control IMessageViewerPlugin.Control
        {
            get
            {
                if (mvc == null)
                    mvc = new MessageViewerControl();

                return mvc;
            }
        }

        Image IMessageViewerPlugin.Image
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[SDK.Resources.ImageIndexes.AMTANGEE];
            }
        }

        bool IMessageViewerPlugin.UseAsDefaultView
        {
            get
            {
                return false;
            }
        }

        bool IMessageViewerPlugin.Visible
        {
            get
            {
                return true;
            }
        }

        void IMessageViewerPlugin.Create(MessageBase message, IMessageViewer messageViewer)
        {
            if (mvc == null)
                mvc = new MessageViewerControl();
            mvc.LoadData(message);
        }
    }

    public class HelloWorldMessageMenuPlugin : AMTANGEE.Interfaces.Messages.IMessageMenuPlugin
    {
        string IMessageMenuPlugin.Caption
        {
            get
            {
                return "Hello World";
            }
        }

        Image IMessageMenuPlugin.Image
        {
            get
            {
                return AMTANGEE.SDK.Resources.Images[Resources.ImageIndexes.AMTANGEE];
            }
        }

        void IMessageMenuPlugin.Clicked(MessageBase message)
        {
            AMTANGEE.SDK.MessageBox.Show("Entry clicked!");
        }

        SDK.Dictionary<BarItem, bool> IMessageMenuPlugin.SubMenuEntries(MessageBase message)
        {
            var result = new SDK.Dictionary<DevExpress.XtraBars.BarItem, bool>();

            DevExpress.XtraBars.BarItem bi = new DevExpress.XtraBars.BarButtonItem();
            bi.Caption = "Hello World 1";
            bi.ItemClick += Bi_ItemClick;
            result.Add(bi, true);

            DevExpress.XtraBars.BarItem bi2 = new DevExpress.XtraBars.BarButtonItem();
            bi2.Caption = "Hello World 2";
            bi2.ItemClick += Bi_ItemClick;
            result.Add(bi2, false);

            return result;
        }

        private void Bi_ItemClick(object sender, ItemClickEventArgs e)
        {
            AMTANGEE.SDK.MessageBox.Show("Entry '" + e.Item.Caption + "' clicked!");
        }

        bool IMessageMenuPlugin.Visible(MessageBase message)
        {
            return true;
        }
    }
 
}
