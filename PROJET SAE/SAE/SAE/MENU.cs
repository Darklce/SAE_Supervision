﻿using System;
using System.Windows.Forms;
using S7.Net;



namespace SAE
{

    public partial class MENU : Form

    {
        public Mode_Auto m_Mode_Auto;  // Instance de la classe associée    
        public Mode_Manu m_Mode_Manu;  // Instance de la classe associée
        public Mode_Manu_P2 m_Mode_Manu_P2;  // Instance de la classe associée
        public Mode_Manu_Distribution m_Mode_Manu_Distribution;
        public Plc plc = new Plc(CpuType.S7300, "10.102.172.238", 0, 0);    //déclaration de l'automate
        public Plc plc2 = new Plc(CpuType.S7300, "10.102.172.239", 0, 0);
        public Plc plc3= new Plc(CpuType.S7300, "10.102.172.240", 0, 0);
        bool g_bool_connecte = false;
       
        public MENU()
        {
            //this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (m_label_ip_choose.Text)
                {
                    case "10.102.172.238":
                        this.plc.Open();
                        g_bool_connecte = plc.IsConnected; // Vérifie l'état de la connexion

                        break;

                    case "10.102.172.239":
                        this.plc2.Open();
                        g_bool_connecte = plc2.IsConnected; // Vérifie l'état de la connexion

                        break;

                    case "10.102.172.240":
                        this.plc3.Open();
                        g_bool_connecte = plc3.IsConnected; // Vérifie l'état de la connexion

                        break;

                }
                m_Label_Connection.Text = g_bool_connecte ? "Le système est connecté" : "Le système est déconnecté";

            }
            catch (S7.Net.PlcException ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
                m_Label_Connection.Text = "Erreur de connexion";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur inconnue : {ex.Message}");
                m_Label_Connection.Text = "Erreur inconnue";
            }
        }



        private void m_Bouton_Deconnecter_Click(object sender, EventArgs e)
        {
            plc.Close();
            plc2.Close();                                                                             // Ferme la connexion
            plc3.Close();                                                                             // Ferme la connexion
                                                                                                     // Ferme la connexion
            g_bool_connecte = plc.IsConnected;
            if (g_bool_connecte == true)                                                             // Vérifie l'état de la connexion
            {
                m_Label_Connection.Text = "Le système est connecté";
            }
            else if (g_bool_connecte == false)
            {
                m_Label_Connection.Text = "Le système est déconnecté";
            }
        }


        private void Bouton_Auto_Click(object sender, EventArgs e)
        {
            m_Mode_Auto = new Mode_Auto();
            m_Mode_Auto.m_MENU = this;
            //plc.Write("M40.1", 1);
            this.Hide();
            m_Mode_Auto.ShowDialog();
            this.Show();


        }
        private void Bouton_Auto_off_Click(object sender, EventArgs e)
        {



        }

        private void Bouton_Manu_Click(object sender, EventArgs e)
        {
            plc3.Write("M4.0", 1);
            m_Mode_Manu = new Mode_Manu();
            m_Mode_Manu.m_MENU = this;

            this.Hide();
            m_Mode_Manu.ShowDialog();
            this.Show();



        }

        private void Choix_Appareil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void m_button_select(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();
            m_label_ip_choose.Text = comboBox1.SelectedItem.ToString();
        }

        private void m_BoutonManuP2_Click(object sender, EventArgs e)
        {
            m_Mode_Manu_P2 = new Mode_Manu_P2();
            m_Mode_Manu.m_MENU = this;

            this.Hide();
            m_Mode_Manu_P2.ShowDialog();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            m_Mode_Manu_Distribution = new Mode_Manu_Distribution();
            m_Mode_Manu_Distribution.m_MENU = this; // Assurez-vous de lier l'instance de MENU à Mode_Manu

            this.Hide();
            m_Mode_Manu_Distribution.ShowDialog();
            this.Show();
        }
    }
}
