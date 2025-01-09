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
        private object plc;
        private int labelSpeed = 15; // Vitesse de déplacement du label
        private int maxPosition = 530; // Position maximale vers le bas
        private int minPosition = 300;  // Position initiale ou minimale
        private int maxPosition2 = 370; // Position maximale vers la droite
        private int minPosition2 = 300;  // Position initiale ou gauche
        

        bool l_bool_valid = true;



        bool sensorState = true;
        private bool isMirrored = false; // Indique si l'image doit être inversée
        private Timer rotationTimer; // Timer pour gérer l'inversion

        public Mode_Auto()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Mode_Auto_Paint);
            this.Load += new EventHandler(Mode_Auto_Load);
            InitializeSensorControl();
            InitializeMirroring();
        }
        private void InitializeMirroring()
        {
            // Initialiser le Timer pour vérifier l'état du capteur
            rotationTimer = new Timer();
            rotationTimer.Interval = 100; // Vérifie toutes les 100 ms
            rotationTimer.Start();
        }
        private void InitializeSensorControl()
        {
            // Initialiser le Timer
            timer1 = new Timer();
            timer1.Interval = 50; // Vérifie toutes les 100 ms
            timer1.Start();


            // Initialiser la position du label
            label2.Location = new Point(label2.Location.X, minPosition);
            m_label_eject.Location = new Point(m_label_eject.Location.X, minPosition2);
            
        }

        private void Bouton_Retour_Click(object sender, EventArgs e)
        {
            m_MENU.plc.Write("M40.1", 0);
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
            //m_MENU.plc.Write("M1.4", 1);
            timer1.Tick += timer1_Tick;
            //rotationTimer.Tick += timer2_Tick;
/*
            bool lirePres = Convert.ToBoolean(m_MENU.plc.Read("M1.4"));
            if (lirePres == true)
            {
                UpdateCircleColorFromPLC();
            }
            else
            {
                UpdateCircleColorFromPLC();
            }
*/
        }

        private void m_BoutonDCY_MouseUp(object sender, MouseEventArgs e)
        {
           // m_MENU.plc.Write("M1.4", 0);
            
        }

        private void Mode_Auto_Load(object sender, EventArgs e)
        {

        }

        private void Mode_Auto_Paint(object sender, PaintEventArgs e)
        {

            // Dessiner un cercle
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Circle_Color);
            int x = 400; // Position X du cercle
            int y = 500; // Position Y du cercle
            int width = 40; // Largeur du cercle
            int height = 40; // Hauteur du cercle

            g.FillEllipse(brush, x, y, width, height);
            // Dessiner un cercle
            Graphics g1 = e.Graphics;
            Brush brush1 = new SolidBrush(Circle_Color);
            int x1 = 400; // Position X du cercle
            int y1 = 260; // Position Y du cercle
            int width1 = 40; // Largeur du cercle
            int height1 = 40; // Hauteur du cercle

            g1.FillEllipse(brush1, x1, y1, width1, height1);
            // Dessiner un cercle
            Graphics g2 = e.Graphics;
            Brush brush2 = new SolidBrush(Circle_Color);
            int x2 = 600; // Position X du cercle
            int y2 = 260; // Position Y du cercle
            int width2 = 40; // Largeur du cercle
            int height2 = 40; // Hauteur du cercle

            g2.FillEllipse(brush2, x2, y2, width2, height2);

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
          
        }

        private void m_button_test_down(object sender, MouseEventArgs e)
        {
            l_bool_test = false;
            UpdateCircleColorFromPLC();
            //m_label_test.Visible = true;
            //m_label_droite_test.Visible = true;



        }
        private void m_button_test(object sender, EventArgs e)
        {
            if (sensorState == true)
            {
                sensorState = false;
            }
            else if (sensorState == false)
            {
                sensorState = true;
            }
        }
        private void m_label_test_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Lire l'état du capteur
                //Convert.ToBoolean(m_MENU.plc.Read("I3.1")); // Exemple d'adresse du capteur

                // Si le capteur est activé (true), déplacer le label vers le bas
                if (sensorState && label2.Location.Y < maxPosition)
                {
                    label2.Location = new Point(label2.Location.X, label2.Location.Y + labelSpeed);
                    if (label2.Location.Y == maxPosition)
                    {
                        l_bool_valid = true;

                    }

                }
                // Si le capteur est désactivé (false), déplacer le label vers le haut
                else if (!sensorState && label2.Location.Y > minPosition)
                {
                    label2.Location = new Point(label2.Location.X, label2.Location.Y - labelSpeed);

                    if (label2.Location.Y != maxPosition)
                    {
                        l_bool_valid = false;

                    }
                }
                 
                if ((l_bool_valid == true) && (m_label_eject.Location.X < maxPosition2))
                {
                    m_label_eject.Location = new Point(m_label_eject.Location.X + labelSpeed, m_label_eject.Location.Y); 
                    m_label_3_debug.Text = Convert.ToString(m_label_eject.Location.X);
                }
                else if ((l_bool_valid == false) && (m_label_eject.Location.X > minPosition2))
                {
                    m_label_eject.Location = new Point(m_label_eject.Location.X - labelSpeed, m_label_eject.Location.Y);
                    m_label_debug.Text = Convert.ToString(label2.Location.Y);

                }

            }
            catch (Exception ex)
            {
                // Gérer les erreurs de lecture depuis le PLC
                MessageBox.Show($"Erreur de lecture depuis le PLC : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop(); // Arrête le Timer en cas d'erreur
            }
        }
    }
}