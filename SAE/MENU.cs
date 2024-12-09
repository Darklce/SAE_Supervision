using System;
using System.Windows.Forms;
using S7.Net;



namespace SAE
{

    public partial class MENU : Form

    {
        public Mode_Manu m_Mode_Manu;  // Instance de la classe associée

        public Plc plc = new Plc(CpuType.S7300, "10.102.172.240", 0, 0);                            //declaration de l'automate


        bool g_bool_connecte = false;
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.plc.Open();

            g_bool_connecte = plc.IsConnected;                                                      // Vérifie l'état de la connexion
            if (g_bool_connecte == true)
            {
                m_Label_Connection.Text = "Le système est connecté";
            }
            else if (g_bool_connecte == false)
            {
                m_Label_Connection.Text = "Le système est déconnecté";
            }
        }


        private void m_Bouton_Deconnecter_Click(object sender, EventArgs e)
        {
            plc.Close();                                                                             // Ferme la connection
            g_bool_connecte = plc.IsConnected;
            if (g_bool_connecte == true)                                                             // Vérifie l'état de la connection
            {
                m_Label_Connection.Text = "Le système est connecté";
            }
            else if (g_bool_connecte == false)
            {
                m_Label_Connection.Text = "Le système est déconnecté";
            }
        }


        private void Bouton_Auto_Click(object sender, EventArgs e)
        {
            Mode_Auto mode_Auto = new Mode_Auto();
            this.Hide();
            mode_Auto.ShowDialog();
            this.Show();


        }
        private void Bouton_Auto_off_Click(object sender, EventArgs e)
        {



        }

        private void Bouton_Manu_Click(object sender, EventArgs e)
        {
            m_Mode_Manu = new Mode_Manu();
            m_Mode_Manu.m_MENU = this; // Assurez-vous de lier l'instance de MENU à Mode_Manu

            this.Hide();
            m_Mode_Manu.ShowDialog();
            this.Show();



        }

        private void m_label_titre_Click(object sender, EventArgs e)
        {

        }
    }
}
