using System;
using System.Windows.Forms;
using S7.Net;


namespace SAE
{
    public partial class Mode_Manu : Form
    {
        public MENU m_MENU;
        public Mode_Manu()
        {

            InitializeComponent();
        }

        private void Bouton_Retour_Click(object sender, EventArgs e)
        {
            Hide();

            m_MENU.ShowDialog();
            this.Close();

        }




        private void m_BoutonTapis_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M1.2", 1);
        }
        

        private void m_BoutonTapis_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M1.2", 0);
        }



        private void m_BoutonSortir_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.1", 1);
        }
        private void m_BoutonSortir_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.1", 0);

        }



        private void m_BoutonTri_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.2", 1);
        }
        private void m_BoutonTri_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.2", 0);
        }





        private void m_BoutonUsin_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.3", 1);
        }
        private void m_BoutonUsin_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.3", 0);
        }




        private void m_BoutonPalp_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.4", 1);
        }
        private void m_BoutonPalp_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.4", 0);
        }



        private void m_BoutonSaisir_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.6", 1);
        }
        private void m_BoutonSaisir_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.6", 0);
        }




        private void m_BoutonLacher_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.5", 1);
        }
        private void m_BoutonLacher_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.5", 0);
        }




        private void m_BoutonSortirNoir_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.7", 1);
        }
        private void m_BoutonSortirNoir_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M0.7", 0);
        }




        private void m_BoutonSortirRouge_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M1.0", 1);
        }
        private void m_BoutonSortirRouge_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M1.0", 0);
        }

        private void m_BoutonRentrer_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.0", 1);

        }

        private void m_BoutonRentrer_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.0", 0);
        }

        private void M_button_tapis(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.2", 1);

        }

        private void M_button_tapis_up(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.2", 0);

        }
    }
}
