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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Bouton_Retour_Click(object sender, EventArgs e)
        {
            Hide();
            m_MENU.plc.Write("M4.0", 0);

            if (m_MENU.Visible)
            {
                m_MENU.BringToFront();
            }
            this.Close();

        }


        // Activation des boutons pour le Tapis

        private void m_BoutonTapis_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M1.2", 1);
        }
        
        private void m_BoutonTapis_off_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M1.2", 0);
        }

        //Activation des boutons pour rentrer le Bras 

        private void m_BoutonRentrer_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.0", 1);

        }

        private void m_BoutonRentrer_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.0", 0);
        }

        //Activation des boutons pour le Tapis


        private void M_button_tapis(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.2", 1);

        }

        private void M_button_tapis_up(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.2", 0);

        }


        //Activation des boutons pour Sortir le bras

        private void m_button_Sortir_Down(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.1", 1); // Turn on the output
        }

        private void m_button_Sortir_Up(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.1", 0); // Turn off the output
        }


        //Activation des boutons pour mettre le bras sur le TRI

        private void m_BoutonTri_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.2", 1); // Turn on the output
        }

        private void m_BoutonTri_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.2", 0); // Turn off the output
        }


        //Activation des boutons pour mettre le bras sur l'USINAGE

        private void m_BoutonUsin_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.3", 1); // Turn on the output
        }
        private void m_BoutonUsin_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.3", 0); // Turn off the output
        }

        //Activation des boutons pour descendre le Palpeur

        private void m_BoutonPalp_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.4", 1); // Turn on the output
        }
        private void m_BoutonPalp_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.4", 0); // Turn off the output
        }

        //Activation des boutons pour saisir la pièce

        private void m_BoutonSaisir_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.6", 1); // Turn on the output
        }
        private void m_BoutonSaisir_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.6", 0); // Turn off the output
        }

        //Activation des boutons pour lâcher la pièce

        private void m_BoutonLacher_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.5", 1); // Turn on the output  
        }
        private void m_BoutonLacher_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.5", 0); // Turn off the output
        }

        //Activation des boutons pour sortir la pièce sur coté noir

        private void m_BoutonSortirNoir_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.7", 1); // Turn on the output
        }
        private void m_BoutonSortirNoir_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.7", 0); // Turn off the output
        }

        //Activation des boutons pour sortir la pièce sur coté rouge

        private void m_BoutonSortirRouge_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.0", 1); // Turn on the output
        }
        private void m_BoutonSortirRouge_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.0", 0); // Turn off the output
        }

        private void m_BoutonRentrer_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonSortir_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonTri_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonUsin_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonPalp_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonSortirNoir_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonSortirRouge_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonSaisir_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonAU_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonLacher_Click(object sender, EventArgs e)
        {

        }

        private void m_BoutonTapis_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
