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
        private bool showStick1 = true; // Variable pour contrôler la visibilité du premier bâton


        public Mode_Auto()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
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
            int x = 250; // Position X du cercle
            int y = 400; // Position Y du cercle
            int width = 40; // Largeur du cercle
            int height = 40; // Hauteur du cercle

            // Dessiner un bâton qui réprésente le bras en mouvement vers le haut
            Pen pen = new Pen(Color.Black, 15); // Créer un stylo noir avec une épaisseur de 15
            int startX = 500; // Position X de départ du bâton
            int startY = 450; // Position Y de départ du bâton
            int endX = 500; // Position X de fin du bâton
            int endY = 250; // Position Y de fin du bâton

            // Dessiner un bâton qui réprésente le bras en mouvement vers le magasin
            /*
                        Pen pen1 = new Pen(Color.Black, 15); // Créer un stylo noir avec une épaisseur de 15
                        int startX1 = 250; // Position X de départ du bâton
                        int startY1 = 450; // Position Y de départ du bâton
                        int endX1 = 500; // Position X de fin du bâton
                        int endY1 = 450; // Position Y de fin du bâton
            */
            // Dessiner un bâton qui réprésente le bras en mouvement vers l'ascenceur
            /*
                        Pen pen2 = new Pen(Color.Black, 15); // Créer un stylo noir avec une épaisseur de 15
                        int startX2 = 500; // Position X de départ du bâton
                        int startY2 = 450; // Position Y de départ du bâton
                        int endX2 = 750; // Position X de fin du bâton
                        int endY2 = 450; // Position Y de fin du bâton
            */
            //l_bool_test = Convert.ToBoolean(m_MENU.plc.Read("M1.4"));
            /*
                        if (l_bool_test == true)
                        {
                        g.DrawLine(pen1, startX1, startY1, endX1, endY1); // Dessiner le bâton

                            Invalidate(); // Redessiner le formulaire

                        }
                        else if (l_bool_test == false)
                        {
                            g.DrawLine(pen2, startX2, startY2, endX2, endY2); // Dessiner le bâton 
                            Invalidate(); // Redessiner le formulaire

                        }
            */
            //g.DrawLine(pen1, startX1, startY1, endX1, endY1); // Dessiner le bâton
            //g.DrawLine(pen2, startX2, startY2, endX2, endY2); // Dessiner le bâton 

            // Dessiner le capteur 1 :

         if (showStick1) {
            g.DrawLine(pen, startX, startY, endX, endY); // Dessiner le bâton

        }
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
            UpdateCircleColorFromPLC();
            m_label_test.Visible = false;
            m_label_droite_test.Visible = false;
            SetStick1Visibility(false);


        }

        private void m_button_test_down(object sender, MouseEventArgs e)
        {
            l_bool_test = false;
            UpdateCircleColorFromPLC();
            m_label_test.Visible = true;
            m_label_droite_test.Visible = true;
            SetStick1Visibility(true);



        }
        private void m_button_test(object sender, EventArgs e)
        {

        }

        private void m_label_test_Click(object sender, EventArgs e)
        {

        }
        private void SetStick1Visibility(bool visible)
        {
            showStick1 = visible;
            Invalidate(); // Redessiner le formulaire
        }
    }
}