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
        bool l_bool_test = false;
        private object plc;
        private int labelSpeed = 15; // Vitesse de déplacement du label
        

        bool l_bool_valid = true;



        bool sensorState = true;
        private bool isMirrored = false; // Indique si l'image doit être inversée
        private Timer rotationTimer; // Timer pour gérer l'inversion

        public Mode_Auto()
        {
            InitializeComponent();            
            this.Load += new EventHandler(Mode_Auto_Load);
            InitializeSensorControl();
        }
        

        private void InitializeSensorControl()
        {
            //Initialiser le Timer
            timer1 = new Timer();
            timer1.Interval = 50; // Vérifie toutes les 100 ms
            timer1.Start();


            // Initialiser la position du label
            //label2.Location = new Point(label2.Location.X, minPosition);
            //m_label_eject.Location = new Point(m_label_eject.Location.X, minPosition2);
            
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

            private void UpdateCircleColorFromPLC()
        {
            // Lire une valeur du PLC
            bool plcValue = l_bool_test;//Convert.ToBoolean(m_MENU.plc.Read("I0.0")); // Exemple de lecture d'une entrée du PLC

            // Mettre à jour la couleur du cercle en fonction de la valeur lue
            if (plcValue)
            {
                m_panel_stock.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                m_panel_stock.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }


            Invalidate(); // Redessiner le formulaire
        }


  


        // Variables d'état globales
        private bool movingRight = false;
        private bool waitingToReturn = false;
        private bool returningLeft = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_button_test_MouseDown(object sender, MouseEventArgs e)
        {
            l_bool_test = false;
            UpdateCircleColorFromPLC();
        }

        private void m_button_test_MouseUp(object sender, MouseEventArgs e)
        {
            l_bool_test = true;
            UpdateCircleColorFromPLC();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(m_MENU.plc.Read("I5.2")))
            {
                m_panel_stock.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                m_panel_stock.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
        }
    }
}