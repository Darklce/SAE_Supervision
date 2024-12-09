namespace SAE
{
    partial class MENU
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_BoutonAuto = new System.Windows.Forms.Button();
            this.m_BoutonManu = new System.Windows.Forms.Button();
            this.m_BoutonConnecter = new System.Windows.Forms.Button();
            this.m_BoutonDeconnecter = new System.Windows.Forms.Button();
            this.m_Label_Connection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_BoutonAuto
            // 
            this.m_BoutonAuto.BackColor = System.Drawing.Color.SeaGreen;
            this.m_BoutonAuto.Location = new System.Drawing.Point(169, 121);
            this.m_BoutonAuto.Name = "m_BoutonAuto";
            this.m_BoutonAuto.Size = new System.Drawing.Size(177, 83);
            this.m_BoutonAuto.TabIndex = 0;
            this.m_BoutonAuto.Text = "Mode Automatique ";
            this.m_BoutonAuto.UseVisualStyleBackColor = false;
            this.m_BoutonAuto.Click += new System.EventHandler(this.Bouton_Auto_Click);
            // 
            // m_BoutonManu
            // 
            this.m_BoutonManu.BackColor = System.Drawing.Color.DarkCyan;
            this.m_BoutonManu.Location = new System.Drawing.Point(392, 121);
            this.m_BoutonManu.Name = "m_BoutonManu";
            this.m_BoutonManu.Size = new System.Drawing.Size(172, 83);
            this.m_BoutonManu.TabIndex = 1;
            this.m_BoutonManu.Text = "Mode Manuel";
            this.m_BoutonManu.UseVisualStyleBackColor = false;
            this.m_BoutonManu.Click += new System.EventHandler(this.Bouton_Manu_Click);
            // 
            // m_BoutonConnecter
            // 
            this.m_BoutonConnecter.Location = new System.Drawing.Point(90, 317);
            this.m_BoutonConnecter.Name = "m_BoutonConnecter";
            this.m_BoutonConnecter.Size = new System.Drawing.Size(87, 76);
            this.m_BoutonConnecter.TabIndex = 2;
            this.m_BoutonConnecter.Text = "Connecter";
            this.m_BoutonConnecter.UseVisualStyleBackColor = true;
            this.m_BoutonConnecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_BoutonDeconnecter
            // 
            this.m_BoutonDeconnecter.Location = new System.Drawing.Point(228, 317);
            this.m_BoutonDeconnecter.Name = "m_BoutonDeconnecter";
            this.m_BoutonDeconnecter.Size = new System.Drawing.Size(87, 76);
            this.m_BoutonDeconnecter.TabIndex = 3;
            this.m_BoutonDeconnecter.Text = "Deconnecter";
            this.m_BoutonDeconnecter.UseVisualStyleBackColor = true;
            this.m_BoutonDeconnecter.Click += new System.EventHandler(this.m_Bouton_Deconnecter_Click);
            // 
            // m_Label_Connection
            // 
            this.m_Label_Connection.AutoSize = true;
            this.m_Label_Connection.Location = new System.Drawing.Point(373, 339);
            this.m_Label_Connection.Name = "m_Label_Connection";
            this.m_Label_Connection.Size = new System.Drawing.Size(0, 13);
            this.m_Label_Connection.TabIndex = 4;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_Label_Connection);
            this.Controls.Add(this.m_BoutonDeconnecter);
            this.Controls.Add(this.m_BoutonConnecter);
            this.Controls.Add(this.m_BoutonManu);
            this.Controls.Add(this.m_BoutonAuto);
            this.Name = "MENU";
            this.Text = "Menu Principal ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_BoutonAuto;
        private System.Windows.Forms.Button m_BoutonManu;
        private System.Windows.Forms.Button m_BoutonConnecter;
        private System.Windows.Forms.Button m_BoutonDeconnecter;
        private System.Windows.Forms.Label m_Label_Connection;
    }
}

