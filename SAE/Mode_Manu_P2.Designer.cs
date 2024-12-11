namespace SAE
{
    partial class Mode_Manu_P2
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
            this.SuspendLayout();
            // 
            // m_BoutonRetour
            // 
            this.m_BoutonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_BoutonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BoutonRetour.Location = new System.Drawing.Point(43, 397);
            this.m_BoutonRetour.Name = "m_BoutonRetour";
            this.m_BoutonRetour.Size = new System.Drawing.Size(258, 104);
            this.m_BoutonRetour.TabIndex = 0;
            this.m_BoutonRetour.Text = "RETOUR";
            this.m_BoutonRetour.UseVisualStyleBackColor = true;
            this.m_BoutonRetour.Click += new System.EventHandler(this.m_BoutonRetour_Click);
            // 
            // Mode_Manu_P2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 547);
            this.Controls.Add(this.m_BoutonRetour);
            this.Name = "Mode_Manu_P2";
            this.Text = "Mode Manuel P2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_BoutonRetour;
    }
}