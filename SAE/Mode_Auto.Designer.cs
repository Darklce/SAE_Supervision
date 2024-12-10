﻿namespace SAE
{
    partial class Mode_Auto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_BoutonRetour = new System.Windows.Forms.Button();
            this.m_BoutonDCY = new System.Windows.Forms.Button();
            this.m_BoutonAU = new System.Windows.Forms.Button();
            this.m_label_debug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_BoutonRetour
            // 
            this.m_BoutonRetour.BackColor = System.Drawing.Color.SkyBlue;
            this.m_BoutonRetour.Location = new System.Drawing.Point(25, 364);
            this.m_BoutonRetour.Name = "m_BoutonRetour";
            this.m_BoutonRetour.Size = new System.Drawing.Size(161, 65);
            this.m_BoutonRetour.TabIndex = 0;
            this.m_BoutonRetour.Text = "RETOUR";
            this.m_BoutonRetour.UseVisualStyleBackColor = false;
            this.m_BoutonRetour.Click += new System.EventHandler(this.Bouton_Retour_Click);
            // 
            // m_BoutonDCY
            // 
            this.m_BoutonDCY.BackColor = System.Drawing.Color.SkyBlue;
            this.m_BoutonDCY.Location = new System.Drawing.Point(291, 177);
            this.m_BoutonDCY.Name = "m_BoutonDCY";
            this.m_BoutonDCY.Size = new System.Drawing.Size(162, 65);
            this.m_BoutonDCY.TabIndex = 1;
            this.m_BoutonDCY.Text = "Depart Cycle ";
            this.m_BoutonDCY.UseVisualStyleBackColor = false;
            this.m_BoutonDCY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_BoutonDCY_MouseDown);
            this.m_BoutonDCY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_BoutonDCY_MouseUp);
            // 
            // m_BoutonAU
            // 
            this.m_BoutonAU.BackColor = System.Drawing.Color.Red;
            this.m_BoutonAU.Location = new System.Drawing.Point(547, 330);
            this.m_BoutonAU.Name = "m_BoutonAU";
            this.m_BoutonAU.Size = new System.Drawing.Size(163, 71);
            this.m_BoutonAU.TabIndex = 2;
            this.m_BoutonAU.Text = "ARRET URGENCE";
            this.m_BoutonAU.UseVisualStyleBackColor = false;
            // 
            // m_label_debug
            // 
            this.m_label_debug.AutoSize = true;
            this.m_label_debug.Location = new System.Drawing.Point(318, 66);
            this.m_label_debug.Name = "m_label_debug";
            this.m_label_debug.Size = new System.Drawing.Size(45, 13);
            this.m_label_debug.TabIndex = 3;
            this.m_label_debug.Text = "DEBUG";
            // 
            // Mode_Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(775, 468);
            this.Controls.Add(this.m_label_debug);
            this.Controls.Add(this.m_BoutonAU);
            this.Controls.Add(this.m_BoutonDCY);
            this.Controls.Add(this.m_BoutonRetour);
            this.Name = "Mode_Auto";
            this.Text = "Mode Automatique ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_BoutonRetour;
        private System.Windows.Forms.Button m_BoutonDCY;
        private System.Windows.Forms.Button m_BoutonAU;
        private System.Windows.Forms.Label m_label_debug;
    }
}