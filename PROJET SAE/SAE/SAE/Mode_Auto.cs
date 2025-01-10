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
        private object plc2;
        private object plc3;
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
            timer1.Interval = 100; // Vérifie toutes les 100 ms
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
            m_MENU.plc.Write("I10.4", 1);
            timer1.Tick += timer1_Tick;
        }

        private void m_BoutonDCY_MouseUp(object sender, MouseEventArgs e)
        {
           m_MENU.plc.Write("I10.4", 0);


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
            if (Convert.ToBoolean(m_MENU.plc.Read("I2.1"))) //Absence pièce dans le stock
            {
                m_panel_stock.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                m_panel_stock.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc.Read("I3.1"))) //Ascenceur en bas
            {
                panel3.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                panel3.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc.Read("I3.2"))) //Ascenceur en haut
            {
                panel4.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                panel4.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc2.Read("I1.0"))) //Pièce sur usinage
            {
                panel5.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                panel5.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc2.Read("I1.2"))) //Pièce qui se fait percer
            {
                panel6.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                panel6.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc2.Read("I2.3"))) //Palpeur Bas
            {
                panel8.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                panel8.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc2.Read("I5.2"))) //Présence pièce
            {
                panel10.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                panel10.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc3.Read("I1.0"))) //pièce dans goulotte
            {
                panel6.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                m_panel_stock.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc3.Read("I2.1"))) //Pièce sur le tapis
            {
                m_panel_stock.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                m_panel_stock.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc3.Read("I1.1"))) //Pièce plastique noire
            {
                m_panel_stock.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                m_panel_stock.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            if (Convert.ToBoolean(m_MENU.plc3.Read("I1.2"))){//Pièce plastique rouge
                m_panel_stock.BackColor = Color.Green; // Si la valeur est vraie, mettre la couleur en vert
            }
            else
            {
                m_panel_stock.BackColor = Color.Red; // Si la valeur est fausse, mettre la couleur en rouge
            }
            

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}