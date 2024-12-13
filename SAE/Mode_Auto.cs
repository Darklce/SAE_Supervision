using S7.Net;
using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace SAE
{
    public partial class Mode_Auto : Form
    {
        public MENU m_MENU;
        public Mode_Auto()
        {
            InitializeComponent();
        }

        private void Bouton_Retour_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();

            if (m_MENU.Visible)
            {
                m_MENU.BringToFront();
            }
 
        }

        private void m_BoutonAU_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.3", 1);
        }

        private void m_BoutonAU_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.3", 0);
        }

        private void m_BoutonDCY_MouseDown(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.4", 1); 

        }

        private void m_BoutonDCY_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.4", 0);
        }

        private void Mode_Auto_Load(object sender, EventArgs e)
        {

        }
    }
}