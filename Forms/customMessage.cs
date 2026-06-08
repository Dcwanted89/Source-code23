using SECURE_BYTE_GUI.Global_for_Obfuscation;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SECURE_BYTE_GUI
{
    public partial class customMessage : Form
    {
        public customMessage()
        {
            InitializeComponent();
        }
        private void customMessage_Load(object sender, EventArgs e)
        {
            Opacity = 0.98;
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static string msg { get; set; }
        public static bool status { get; set; }
        private void customMessage_Shown(object sender, EventArgs e)
        {
            msgLabel.Text = msg;
            if (Global_for_links.globalLinks.type != "") okButton.Visible = true;
        }
        private void customMessage_MouseDown(object sender, MouseEventArgs e)
        {
            Inx.Ui.Movement.Move(this, e, false);
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            switch (Global_for_links.globalLinks.type)
            {
                case "Dir":
                    Process.Start(oGlobals.browseDir);
                    Close();
                    break;
                case "Paypal":
                    Process.Start("https://www.paypal.com/paypalme/PegasusHacker");
                    Close();
                    break;
                case "Litecoin":
                    Clipboard.SetText("MBgSeKB12BFZ6RdV3LAXGWqufEZUKYbPgb");
                    Close();
                    break;
                case "Bitcoin":
                    Clipboard.SetText("39g9nRoWSjakg8uYfFrEQLjUPwQQRVPXDc");
                    Close();
                    break;
                case "Ethereum":
                    Clipboard.SetText("0x617a9c950e9df72437bec5de86608b2bd1f68421");
                    Close();
                    break;
                case "USDT_TRC20":
                    Clipboard.SetText("TBARTH2CxVkYJnKh6GbSCRpgHm6N7rJAeH");
                    Close();
                    break;
                case "Tron":
                    Clipboard.SetText("TBARTH2CxVkYJnKh6GbSCRpgHm6N7rJAeH");
                    Close();
                    break;
            }
            Global_for_links.globalLinks.type = "";
        }
    }
}
