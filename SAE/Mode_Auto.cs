using System;
using System.Windows.Forms;

namespace SAE
{
    public partial class Mode_Auto : Form
    {
        public Mode_Auto()
        {
            InitializeComponent();
        }

        private void Bouton_Retour_Click(object sender, EventArgs e)
        {
            MENU m_MENU = new MENU();
            Hide();
            m_MENU.ShowDialog();
            this.Close();

        }
    }
}
