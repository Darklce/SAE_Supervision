using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;






namespace SAE_Control_Distrib
{
    
    public partial class ModeManu : Form
    {
        public Lobby m_Lobby;                       // Association avec Lobby.cs

        bool[] m_bool_tab_entree = new bool[13];    // Tableau des entrée de 1 à 13 

        public ModeManu()
        {
            InitializeComponent();
        }

        private void m_button_retour_Click(object sender, EventArgs e)
        {

            m_Lobby.Show();                     // Affiche le menu
            m_Lobby.m_Manu.Hide();              // Cache la supervision du mode manu
            m_Lobby.plc.Write("M7.0", 0);       // Desactive le mode manu dans le GEMMA


        }

        

        

        private void m_timer_modeManu_Tick(object sender, EventArgs e)              // Temps de rafraichissement des entrées et mise a jour des voyants 
        {
            if (m_Lobby != null)                // Gère l'éventualité ou m_Lobby est nul afin d'éviter tout problème 
            {
                // Récupération des entrées dans notre tableau des entrées
                
                    m_Lobby.m_bool_tab_entree[0] = Convert.ToBoolean(m_Lobby.plc.Read("I3.1"));         //I_cont_asc_bas  
                    m_Lobby.m_bool_tab_entree[1] = Convert.ToBoolean(m_Lobby.plc.Read("I3.2"));         //I_cont_asc_haut
                    m_Lobby.m_bool_tab_entree[2] = Convert.ToBoolean(m_Lobby.plc.Read("I2.3"));         //I_cont_det_piece
                    m_Lobby.m_bool_tab_entree[3] = Convert.ToBoolean(m_Lobby.plc.Read("I3.3"));         //I_cont_eject_arr
                    m_Lobby.m_bool_tab_entree[4] = Convert.ToBoolean(m_Lobby.plc.Read("I4.0"));         //I_cont_palpeur_bas
                    m_Lobby.m_bool_tab_entree[5] = Convert.ToBoolean(m_Lobby.plc.Read("I2.2"));         //I_cont_piece_metal
                    m_Lobby.m_bool_tab_entree[6] = Convert.ToBoolean(m_Lobby.plc.Read("I3.0"));         //I_cont_piece_rouge
                    m_Lobby.m_bool_tab_entree[7] = Convert.ToBoolean(m_Lobby.plc.Read("I2.1"));         //I_dist_abs_piece
                    m_Lobby.m_bool_tab_entree[8] = Convert.ToBoolean(m_Lobby.plc.Read("I1.2"));         //I_dist_bras_asc
                    m_Lobby.m_bool_tab_entree[9] = Convert.ToBoolean(m_Lobby.plc.Read("I1.3"));         //I_dist_bras_mag
                    m_Lobby.m_bool_tab_entree[10] = Convert.ToBoolean(m_Lobby.plc.Read("I1.0"));        //I_dist_eject_arr
                    m_Lobby.m_bool_tab_entree[11] = Convert.ToBoolean(m_Lobby.plc.Read("I1.1"));        //I_dist_eject_av
                    m_Lobby.m_bool_tab_entree[12] = Convert.ToBoolean(m_Lobby.plc.Read("I2.0"));        //I_dist_piece_saisie


                // MISE A JOUR DES VOYANTS


                if (m_Lobby.m_bool_tab_entree[0] == true)  // Mise a jour du voyant ascenceur bas
                {
                    this.m_panel_asc_bas.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_asc_bas.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }


                if (m_Lobby.m_bool_tab_entree[1] == true)  // Mise a jour du voyant ascenceur haut
                {
                    this.m_panel_asc_haut.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_asc_haut.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }


                if (m_Lobby.m_bool_tab_entree[3] == false)  // Mise a jour du voyant ejecteur ascenceur
                {
                    this.m_panel_cont_ejec.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_cont_ejec.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }


                if (m_Lobby.m_bool_tab_entree[4] == true)  // Mise a jour du voyant du palpeur
                {
                    this.m_panel_cont_palp.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_cont_palp.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }

                if (m_Lobby.m_bool_tab_entree[7] == true)  // Mise a jour du voyant absence pièce
                {
                    this.m_panel_abs_piece.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }
                else
                {
                    this.m_panel_abs_piece.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }

                if (m_Lobby.m_bool_tab_entree[8] == true)  // Mise a jour du voyant bras sur asc
                {
                    this.m_panel_bras_asc.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_bras_asc.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }

                if (m_Lobby.m_bool_tab_entree[9] == true)  // Mise a jour du voyant bras sur mag
                {
                    this.m_panel_bras_mag.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_bras_mag.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }

                if (m_Lobby.m_bool_tab_entree[10] == true)  // Mise a jour du voyant ejecteur magasin arrière
                {
                    this.m_panel_dist_ejec_rentree.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_dist_ejec_rentree.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }

                if (m_Lobby.m_bool_tab_entree[11] == true)  // Mise a jour du voyant ejecteur magasin avant
                {
                    this.m_panel_dist_ejec_sortie.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_dist_ejec_sortie.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }

                if (m_Lobby.m_bool_tab_entree[12] == true)  // Mise a jour du voyant pièce siasie
                {
                    this.m_panel_saisie.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOn;
                }
                else
                {
                    this.m_panel_saisie.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.VoyantOff;
                }


                

            }



        }

        private void m_button_asc_bas_MouseDown(object sender, MouseEventArgs e)                                                // Active la variable ascenceur bas quand presser
        {
            
            this.m_button_asc_bas.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Bas;
            m_Lobby.plc.Write("M5.0", 1);
        }

        private void m_button_asc_bas_MouseUp(object sender, MouseEventArgs e)                                                 // Desactive la variable ascenceur bas quand relâcher
        {
            this.m_button_asc_bas.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Haut;
            m_Lobby.plc.Write("M5.0", 0);
        }

        private void m_button_asc_haut_MouseDown(object sender, MouseEventArgs e)                                              // Active la variable ascenceur haut quand presser      
        {
            this.m_button_asc_haut.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Bas;
            if (m_Lobby.m_bool_tab_entree[9] == true)
            {
                m_Lobby.plc.Write("M5.1", 1);
            }
            else
            {
                this.m_panel_warning.Visible = true;        // Affiche l'avertissement si on essaye de monter l'ascenceur et que le bras n'est pas sur la magasin
            }
        }

        private void m_button_asc_haut_MouseUp(object sender, MouseEventArgs e)                                                // Desactive la vatiable ascenceur haut quand relâcher 
        {
            this.m_button_asc_haut.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Haut;
            
                m_Lobby.plc.Write("M5.1", 0);
                this.m_panel_warning.Visible = false;      // Fait disparaitre l'avertissement quand le bouton est lâché
            

        }

        private void m_button_bras_mag_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_button_bras_mag.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Bas;
            if (m_Lobby.m_bool_tab_entree[10] == true)
            {
                m_Lobby.plc.Write("M6.1", 1);                                                                                   // Bras sur magasin (%Q6.1)
            }
            else
            {
                this.m_panel_warning.Visible = true;        // Fais apparaitre l'avertissement si l'éjecteur est sorti
            }
            
        }

        private void m_button_bras_mag_MouseUp(object sender, MouseEventArgs e)
        {
            this.m_button_bras_mag.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Haut;
            
                m_Lobby.plc.Write("M6.1", 0);                                                                                   // Bras sur magasin (%Q6.1)
                this.m_panel_warning.Visible = false;
        }

        private void m_button_bras_asc_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_button_bras_asc.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Bas;
            if (m_Lobby.m_bool_tab_entree[0] == true)
            {
                m_Lobby.plc.Write("M6.0", 1);                                                                                   // Bras sur ascenceur (%Q6.0)
            }
            else
            {
                this.m_panel_warning.Visible = true;
            }
        }

        private void m_button_bras_asc_MouseUp(object sender, MouseEventArgs e)
        {
            this.m_button_bras_asc.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Haut;
            
                m_Lobby.plc.Write("M6.0", 0);                                                                                   // Bras sur ascenceur (%Q6.0)
                this.m_panel_warning.Visible = false;
            
        }

        private void m_button_dist_ejec_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_button_dist_ejec.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Bas;
            if (m_Lobby.m_bool_tab_entree[8] == true)
            {
                m_Lobby.plc.Write("M6.2", 1);                                                                                   // Ejecteur Magasin (%Q6.2)                                                                                  // Bras sur ascenceur (%Q6.0)                                                                                // Bras sur magasin (%Q6.1)
                
            }
            else
            {
                this.m_panel_warning.Visible = true;
            }
            
        }

        private void m_button_dist_ejec_MouseUp(object sender, MouseEventArgs e)
        {
            this.m_button_dist_ejec.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Haut;
            
                m_Lobby.plc.Write("M6.2", 0);                                                                                   // Ejecteur Magasin (%Q6.2)                                                                                  // Bras sur ascenceur (%Q6.0)                                                                                // Bras sur magasin (%Q6.1)
                this.m_panel_warning.Visible = false;
        }

        private void m_button_cont_ejec_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_button_cont_ejec.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Bas;
            m_Lobby.plc.Write("M5.4", 1);                                                                                   // Ejecteur Ascenceur (%Q5.4)
        }

        private void m_button_cont_ejec_MouseUp(object sender, MouseEventArgs e)
        {
            this.m_button_cont_ejec.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Haut;
            m_Lobby.plc.Write("M5.4", 0);                                                                                   // Ejecteur Ascenceur (%Q5.4)
        }

        private void m_button_palpeur_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_button_palpeur.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Bas;
            if (m_Lobby.m_bool_tab_entree[1] == true)
            {
                m_Lobby.plc.Write("M5.3", 1);                                                                                   // Palpeur (%Q5.3)                                                                                // Ejecteur Magasin (%Q6.2)                                                                                  // Bras sur ascenceur (%Q6.0)                                                                                // Bras sur magasin (%Q6.1)
            }
            else
            {
                this.m_panel_warning.Visible = true;
            }
        }

        private void m_button_palpeur_MouseUp(object sender, MouseEventArgs e)
        {
            this.m_button_palpeur.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.Bouton_Haut;

                m_Lobby.plc.Write("M5.3", 0);                                                                                   // Palpeur (%Q5.3) 
            this.m_panel_warning.Visible = false;
        }



       

        private void m_button_saisir_CheckedChanged(object sender, EventArgs e)
        {
            if (m_button_saisir.Checked)
            {
                m_Lobby.plc.Write("M6.3", 0);                                                          // Pièce lacher  (%Q6.0)
                m_Lobby.plc.Write("M6.4", 1);
            }
            else
            {
                m_Lobby.plc.Write("M6.3", 1);                                                          // Pièce lacher  (%Q6.0)
                m_Lobby.plc.Write("M6.4", 0);
            }
                                                                     // Pièce saisir  (%Q6.0)
            if (Convert.ToBoolean(m_button_saisir.CheckState))
            {

                this.m_button_saisir.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
                this.m_button_saisir.Text = "Lâcher";
                this.m_button_saisir.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.SwitchON;
                this.m_button_saisir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            }
            else
            {
                this.m_button_saisir.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.SwitchOFF;
                this.m_button_saisir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.m_button_saisir.Text = "Saisir";
                this.m_button_saisir.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            }
        }

        private void m_button_bloqueur_CheckedChanged(object sender, EventArgs e)
        {
            m_Lobby.plc.Write("M5.2", m_button_bloqueur.CheckState);                                                       // Bloqueur (%Q7.1)
            if (Convert.ToBoolean(m_button_bloqueur.CheckState))
            {

                this.m_button_bloqueur.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
                this.m_button_bloqueur.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.SwitchON;
                this.m_button_bloqueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                

            }
            else
            {
                this.m_button_bloqueur.BackgroundImage = global::SAE_Control_Distrib.Properties.Resources.SwitchOFF;
                this.m_button_bloqueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.m_button_bloqueur.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            }
        }

        
    }
}
