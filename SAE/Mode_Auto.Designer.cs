namespace SAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mode_Auto));
            this.m_BoutonRetour = new System.Windows.Forms.Button();
            this.m_BoutonDCY = new System.Windows.Forms.Button();
            this.m_BoutonAU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_BoutonRetour
            // 
            this.m_BoutonRetour.BackColor = System.Drawing.Color.DarkSlateGray;
            this.m_BoutonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_BoutonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BoutonRetour.Location = new System.Drawing.Point(33, 448);
            this.m_BoutonRetour.Margin = new System.Windows.Forms.Padding(4);
            this.m_BoutonRetour.Name = "m_BoutonRetour";
            this.m_BoutonRetour.Size = new System.Drawing.Size(215, 80);
            this.m_BoutonRetour.TabIndex = 0;
            this.m_BoutonRetour.Text = "RETOUR";
            this.m_BoutonRetour.UseVisualStyleBackColor = false;
            this.m_BoutonRetour.Click += new System.EventHandler(this.Bouton_Retour_Click);
            // 
            // m_BoutonDCY
            // 
            this.m_BoutonDCY.BackColor = System.Drawing.Color.DarkSlateGray;
            this.m_BoutonDCY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_BoutonDCY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BoutonDCY.Location = new System.Drawing.Point(388, 218);
            this.m_BoutonDCY.Margin = new System.Windows.Forms.Padding(4);
            this.m_BoutonDCY.Name = "m_BoutonDCY";
            this.m_BoutonDCY.Size = new System.Drawing.Size(216, 80);
            this.m_BoutonDCY.TabIndex = 1;
            this.m_BoutonDCY.Text = "Depart Cycle ";
            this.m_BoutonDCY.UseVisualStyleBackColor = false;
            this.m_BoutonDCY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_BoutonDCY_MouseDown);
            this.m_BoutonDCY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_BoutonDCY_MouseUp);
            // 
            // m_BoutonAU
            // 
            this.m_BoutonAU.BackColor = System.Drawing.Color.Red;
            this.m_BoutonAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_BoutonAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BoutonAU.Location = new System.Drawing.Point(662, 381);
            this.m_BoutonAU.Margin = new System.Windows.Forms.Padding(4);
            this.m_BoutonAU.Name = "m_BoutonAU";
            this.m_BoutonAU.Size = new System.Drawing.Size(284, 112);
            this.m_BoutonAU.TabIndex = 2;
            this.m_BoutonAU.Text = "ARRET URGENCE";
            this.m_BoutonAU.UseVisualStyleBackColor = false;
            this.m_BoutonAU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_BoutonAU_MouseDown);
            this.m_BoutonAU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_BoutonAU_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "MODE AUTOMATIQUE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 68);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Mode_Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1033, 576);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_BoutonAU);
            this.Controls.Add(this.m_BoutonDCY);
            this.Controls.Add(this.m_BoutonRetour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mode_Auto";
            this.Text = "Mode Automatique ";
            this.Load += new System.EventHandler(this.Mode_Auto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_BoutonRetour;
        private System.Windows.Forms.Button m_BoutonDCY;
        private System.Windows.Forms.Button m_BoutonAU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}