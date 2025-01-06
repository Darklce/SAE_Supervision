using S7.Net;
using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace SAE
{
    public partial class Mode_Auto : Form
    {
        public MENU m_MENU;
        private Color Circle_Color = Color.Red; // Variable de couleur pour le cercle
        bool l_bool_test = false;

        public Mode_Auto()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Mode_Auto_Paint);
            this.Load += new EventHandler(Mode_Auto_Load);

        }

        private void Bouton_Retour_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("40.1", 0);
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
        private void Mode_Auto_Paint(object sender, PaintEventArgs e)
        {
            // Dessiner un cercle
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Circle_Color);
            int x = 200; // Position X du cercle
            int y = 100; // Position Y du cercle
            int width = 50; // Largeur du cercle
            int height = 50; // Hauteur du cercle

            g.FillEllipse(brush, x, y, width, height);
        }
        private void UpdateCircleColorFromPLC()
        {
            // Lire une valeur du PLC
            bool plcValue = l_bool_test;//Convert.ToBoolean(m_MENU.plc.Read("I0.0")); // Exemple de lecture d'une entrée du PLC

            // Mettre à jour la couleur du cercle en fonction de la valeur lue
            if (plcValue)
            {
                Circle_Color = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                Circle_Color = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }

            Invalidate(); // Redessiner le formulaire
        }

        private void m_button_test_UP(object sender, MouseEventArgs e)
        {
            l_bool_test = true;
            m_label_2.Text = l_bool_test.ToString();
            UpdateCircleColorFromPLC();

        }

        private void m_button_test_down(object sender, MouseEventArgs e)
        {
            l_bool_test = false;
            m_label_2.Text = l_bool_test.ToString();
            UpdateCircleColorFromPLC();

        }
    }
}