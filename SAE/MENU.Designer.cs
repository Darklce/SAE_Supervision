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
            this.m_label_titre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.m_button_select_ip = new System.Windows.Forms.Button();
            this.m_label_ip_choose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_BoutonAuto
            // 
            this.m_BoutonAuto.BackColor = System.Drawing.Color.SeaGreen;
            this.m_BoutonAuto.FlatAppearance.BorderSize = 0;
            this.m_BoutonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_BoutonAuto.Location = new System.Drawing.Point(191, 118);
            this.m_BoutonAuto.Margin = new System.Windows.Forms.Padding(4);
            this.m_BoutonAuto.Name = "m_BoutonAuto";
            this.m_BoutonAuto.Size = new System.Drawing.Size(236, 102);
            this.m_BoutonAuto.TabIndex = 0;
            this.m_BoutonAuto.Text = "Mode Automatique ";
            this.m_BoutonAuto.UseVisualStyleBackColor = false;
            this.m_BoutonAuto.Click += new System.EventHandler(this.Bouton_Auto_Click);
            // 
            // m_BoutonManu
            // 
            this.m_BoutonManu.BackColor = System.Drawing.Color.DarkCyan;
            this.m_BoutonManu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_BoutonManu.Location = new System.Drawing.Point(639, 118);
            this.m_BoutonManu.Margin = new System.Windows.Forms.Padding(4);
            this.m_BoutonManu.Name = "m_BoutonManu";
            this.m_BoutonManu.Size = new System.Drawing.Size(229, 102);
            this.m_BoutonManu.TabIndex = 1;
            this.m_BoutonManu.Text = "Mode Manuel";
            this.m_BoutonManu.UseVisualStyleBackColor = false;
            this.m_BoutonManu.Click += new System.EventHandler(this.Bouton_Manu_Click);
            // 
            // m_BoutonConnecter
            // 
            this.m_BoutonConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.m_BoutonConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_BoutonConnecter.Location = new System.Drawing.Point(120, 390);
            this.m_BoutonConnecter.Margin = new System.Windows.Forms.Padding(4);
            this.m_BoutonConnecter.Name = "m_BoutonConnecter";
            this.m_BoutonConnecter.Size = new System.Drawing.Size(116, 94);
            this.m_BoutonConnecter.TabIndex = 2;
            this.m_BoutonConnecter.Text = "Connexion";
            this.m_BoutonConnecter.UseVisualStyleBackColor = false;
            this.m_BoutonConnecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_BoutonDeconnecter
            // 
            this.m_BoutonDeconnecter.BackColor = System.Drawing.Color.Red;
            this.m_BoutonDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_BoutonDeconnecter.Location = new System.Drawing.Point(264, 390);
            this.m_BoutonDeconnecter.Margin = new System.Windows.Forms.Padding(4);
            this.m_BoutonDeconnecter.Name = "m_BoutonDeconnecter";
            this.m_BoutonDeconnecter.Size = new System.Drawing.Size(116, 94);
            this.m_BoutonDeconnecter.TabIndex = 3;
            this.m_BoutonDeconnecter.Text = "Déconnexion";
            this.m_BoutonDeconnecter.UseVisualStyleBackColor = false;
            this.m_BoutonDeconnecter.Click += new System.EventHandler(this.m_Bouton_Deconnecter_Click);
            // 
            // m_Label_Connection
            // 
            this.m_Label_Connection.AutoSize = true;
            this.m_Label_Connection.Location = new System.Drawing.Point(159, 487);
            this.m_Label_Connection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_Label_Connection.Name = "m_Label_Connection";
            this.m_Label_Connection.Size = new System.Drawing.Size(0, 16);
            this.m_Label_Connection.TabIndex = 4;
            // 
            // m_label_titre
            // 
            this.m_label_titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_label_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_label_titre.Location = new System.Drawing.Point(287, 11);
            this.m_label_titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_label_titre.Name = "m_label_titre";
            this.m_label_titre.Size = new System.Drawing.Size(490, 49);
            this.m_label_titre.TabIndex = 5;
            this.m_label_titre.Text = "Supervision SAÉ P3";
            this.m_label_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10.102.172.239",
            "10.102.172.240",
            "10.102.172.241"});
            this.comboBox1.Location = new System.Drawing.Point(402, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Tag = "m_val_ip";
            // 
            // m_button_select_ip
            // 
            this.m_button_select_ip.Location = new System.Drawing.Point(406, 441);
            this.m_button_select_ip.Name = "m_button_select_ip";
            this.m_button_select_ip.Size = new System.Drawing.Size(110, 23);
            this.m_button_select_ip.TabIndex = 7;
            this.m_button_select_ip.Text = "Sélectionner";
            this.m_button_select_ip.UseVisualStyleBackColor = true;
            this.m_button_select_ip.Click += new System.EventHandler(this.m_button_select);
            // 
            // m_label_ip_choose
            // 
            this.m_label_ip_choose.AutoSize = true;
            this.m_label_ip_choose.Location = new System.Drawing.Point(212, 361);
            this.m_label_ip_choose.Name = "m_label_ip_choose";
            this.m_label_ip_choose.Size = new System.Drawing.Size(73, 16);
            this.m_label_ip_choose.TabIndex = 8;
            this.m_label_ip_choose.Text = "Adresse IP";
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.m_label_ip_choose);
            this.Controls.Add(this.m_button_select_ip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.m_label_titre);
            this.Controls.Add(this.m_Label_Connection);
            this.Controls.Add(this.m_BoutonDeconnecter);
            this.Controls.Add(this.m_BoutonConnecter);
            this.Controls.Add(this.m_BoutonManu);
            this.Controls.Add(this.m_BoutonAuto);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label m_label_titre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button m_button_select_ip;
        private System.Windows.Forms.Label m_label_ip_choose;
    }
}

