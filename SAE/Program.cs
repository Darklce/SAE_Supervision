using System;
using System.Windows.Forms;

namespace SAE
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MENU MonMENU;
            Mode_Manu MonMode_Manu;
            Mode_Auto MonMode_Auto;
            Mode_Manu_P2 MonMode_Manu_P2;


            MonMode_Auto = new Mode_Auto();
            MonMode_Manu = new Mode_Manu();
            MonMode_Manu_P2 = new Mode_Manu_P2();
            MonMENU = new MENU();



            MonMode_Manu.m_MENU = MonMENU;
            MonMENU.m_Mode_Manu = MonMode_Manu;
            MonMENU.m_Mode_Auto = MonMode_Auto;
            MonMode_Auto.m_MENU = MonMENU;
            MonMode_Manu_P2.m_MENU = MonMENU;
            MonMENU.m_Mode_Manu_P2 = MonMode_Manu_P2;

            Application.Run(MonMENU);

        }
    }
}
