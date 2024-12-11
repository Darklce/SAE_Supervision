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
            m_MENU.plc.Write("M1.4", 1); //VALEUR à CHANGER car je suis pas sur de celle ci 
            Mode_Auto_F1();

        }

        private void m_BoutonDCY_MouseUp(object sender, MouseEventArgs e)
        {
            m_MENU.plc.Write("M1.4", 0);
        }

        private void Mode_Auto_F1()
        {
            bool lireCpt_SaisiePiece = false;
            m_MENU.plc.Write("M7.1.", 1); //Sortir le bras activée
            bool lireCpt_BrasSorti = Convert.ToBoolean(m_MENU.plc.Read("I3.1")); // Lit l'entrée Si le bras est sorti

            if (lireCpt_BrasSorti == true)
            {
                m_MENU.plc.Write("M7.1", 1); //Sortir le bras Activé 
                m_MENU.plc.Write("M8.2", 1); // Descendre le palpeur

            }

            bool lireCpt_PalpBas = Convert.ToBoolean(m_MENU.plc.Read("I4.0")); // Lit l'entrée Si le palpeur est sorti
            if (lireCpt_PalpBas == true)
            {
                m_MENU.plc.Write("8.0", 1); //Saisir pièce

                lireCpt_SaisiePiece = Convert.ToBoolean(m_MENU.plc.Read("I2.2")); // Lit l'entrée si la pièce est saisie

                if (lireCpt_SaisiePiece == true)
                {
                    m_MENU.plc.Write("8.2", 0); //Descendre le palpeur désactivée
                }
            }

            bool lireCpt_PalpHaut = Convert.ToBoolean(m_MENU.plc.Read("I3.3")); // Lit l'entrée si le palpeur est en haut

            if (lireCpt_PalpHaut == true)
            {
                m_MENU.plc.Write("M7.0", 1); //Rentrer le bras
            }

            bool lireCpt_BrasRentre = Convert.ToBoolean(m_MENU.plc.Read("I3.2")); // Lit l'entrée Si le bras est rentrée

            if (lireCpt_BrasRentre == true)
            {
                m_MENU.plc.Write("M7.0", 0); //Rentrer le bras désactivée
                m_MENU.plc.Write("M7.3", 1); // Bras sur Tri
            }

            bool lireCpt_BrasTri = Convert.ToBoolean(m_MENU.plc.Read("I2.3")); // Lit l'entrée Si le bras est sur Usinage

            if (lireCpt_BrasTri == true)
            {
                m_MENU.plc.Write("M7.3", 0); // Bras sur Tri désactivée
                m_MENU.plc.Write("M7.1", 1); // Sortir le bras
            }

            lireCpt_BrasSorti = Convert.ToBoolean(m_MENU.plc.Read("I3.1")); // Lit l'entrée Si le bras est sorti

            if (lireCpt_BrasSorti == true)
            {
                m_MENU.plc.Write("M7.1", 0); // Sortir le bras Désactivée
                m_MENU.plc.Write("M8.2", 1); // Descendre le palpeur
            }

            lireCpt_PalpBas = Convert.ToBoolean(m_MENU.plc.Read("I4.0")); // Lit l'entrée Si le palpeur est sorti

            if (lireCpt_PalpBas == true)
            {
                m_MENU.plc.Write("8.0", 0); // Saisir pièce
                m_MENU.plc.Write("8.1", 1); // Lâcher pièce
            }
            lireCpt_SaisiePiece = Convert.ToBoolean(m_MENU.plc.Read("I2.2")); // Lit l'entrée si la pièce est saisie
                                                                              // 
            if (lireCpt_SaisiePiece == false)
            {
                m_MENU.plc.Write("8.2", 0); // Descendre le palpeur désactivée

                if ((lireCpt_PalpHaut = Convert.ToBoolean(m_MENU.plc.Read("I3.3"))) == true) // Condition si le palpeur est en haut 
                {
                    m_MENU.plc.Write("M7.0", 1); // Rentrer le bras
                    m_MENU.plc.Write("M7.2", 1); // Bras sur Usinage


                }
            }
            bool lireCpt_PieceTapis = Convert.ToBoolean(m_MENU.plc.Read("I2.1")); // Lit l'entrée Si la pièce est sur le tapis

            if (lireCpt_PieceTapis == true)
            {
                m_MENU.plc.Write("M6.3", 1); // Tapis Activée
                m_MENU.plc.Write("M6.2", 1); // Barrière Rouge Activée
                m_MENU.plc.Write("M6.0", 0); // Barrière Désactivée

            }
        }

        private void Mode_Auto_Load(object sender, EventArgs e)
        {

        }
    }
}