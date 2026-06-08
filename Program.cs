using KeyAuth;
using System;
using System.Windows.Forms;

namespace SECURE_BYTE_GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Check_for_updates.updateChecker.checkforUpdates();
            Application.Run(new Login());
        }
        public static api Auth = new api(
        name: "Blazzer Obfuscator",
        ownerid: "YX86icHBic",
        secret: "d94adaf57842f39c2f5644dc33e034acf43cd8c5f3242181593ea225d305dcd8",
        version: "1.0"
        );
    }
}
