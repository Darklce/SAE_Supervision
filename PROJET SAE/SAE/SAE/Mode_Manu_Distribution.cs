using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE
{

    public partial class Mode_Manu_Distribution : Form
    {
        bool m_bool_dcy = false;
        public MENU m_MENU;

        public Mode_Manu_Distribution()
        {
            InitializeComponent();
        }

        private void Bouton_Retour_Click(object sender, EventArgs e)
        {
            Hide();
            m_MENU.plc.Write("M4.0", 0); // A modifier
            m_MENU.plc.Write("M1.2", 0); // A modifier
            if (m_MENU.Visible)
            {
                m_MENU.BringToFront();
            }
            this.Close();

        }

        private void m_BoutonDCY_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M1.2", 1); // A modifier //Lancement du mode manuel
            m_bool_dcy = true;
        }

        private void m_BoutonEjecter_MouseDown(object sender, MouseEventArgs e)
        {
            if (m_bool_dcy == true)
            {
                m_MENU.plc.Write("M0.0", 1); // A modifier
            }
            else
            {
                MessageBox.Show("Veuillez activer le mode manuel");

            }
        }

        private void m_BoutonEjecter_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M0.0", 0); // A modifier
        }
    }

}



