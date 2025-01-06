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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_label_test = new System.Windows.Forms.Label();
            this.m_label_droite_test = new System.Windows.Forms.Label();
            this.m_label_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_BoutonRetour
            // 
            this.m_BoutonRetour.BackColor = System.Drawing.Color.LightSkyBlue;
            this.m_BoutonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_BoutonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BoutonRetour.Location = new System.Drawing.Point(7, 630);
            this.m_BoutonRetour.Name = "m_BoutonRetour";
            this.m_BoutonRetour.Size = new System.Drawing.Size(140, 65);
            this.m_BoutonRetour.TabIndex = 0;
            this.m_BoutonRetour.Text = "RETOUR";
            this.m_BoutonRetour.UseVisualStyleBackColor = false;
            this.m_BoutonRetour.Click += new System.EventHandler(this.Bouton_Retour_Click);
            // 
            // m_BoutonDCY
            // 
            this.m_BoutonDCY.BackColor = System.Drawing.Color.Turquoise;
            this.m_BoutonDCY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_BoutonDCY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BoutonDCY.Location = new System.Drawing.Point(181, 120);
            this.m_BoutonDCY.Name = "m_BoutonDCY";
            this.m_BoutonDCY.Size = new System.Drawing.Size(186, 55);
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
            this.m_BoutonAU.Image = ((System.Drawing.Image)(resources.GetObject("m_BoutonAU.Image")));
            this.m_BoutonAU.Location = new System.Drawing.Point(1179, 576);
            this.m_BoutonAU.Name = "m_BoutonAU";
            this.m_BoutonAU.Size = new System.Drawing.Size(193, 173);
            this.m_BoutonAU.TabIndex = 2;
            this.m_BoutonAU.UseVisualStyleBackColor = false;
            this.m_BoutonAU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_BoutonAU_MouseDown);
            this.m_BoutonAU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_BoutonAU_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "MODE AUTOMATIQUE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1230, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "BUTTON DEBUG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_button_test_down);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_button_test_UP);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(693, 55);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.m_BoutonRetour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 707);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 54);
            this.panel2.TabIndex = 19;
            // 
            // m_label_test
            // 
            this.m_label_test.AutoSize = true;
            this.m_label_test.BackColor = System.Drawing.Color.Black;
            this.m_label_test.Location = new System.Drawing.Point(269, 441);
            this.m_label_test.Name = "m_label_test";
            this.m_label_test.Size = new System.Drawing.Size(229, 13);
            this.m_label_test.TabIndex = 20;
            this.m_label_test.Text = "                                                                          ";
            this.m_label_test.VisibleChanged += new System.EventHandler(this.m_button_test);
            this.m_label_test.Click += new System.EventHandler(this.m_label_test_Click);
            // 
            // m_label_droite_test
            // 
            this.m_label_droite_test.AutoSize = true;
            this.m_label_droite_test.BackColor = System.Drawing.Color.Black;
            this.m_label_droite_test.Location = new System.Drawing.Point(495, 441);
            this.m_label_droite_test.Name = "m_label_droite_test";
            this.m_label_droite_test.Size = new System.Drawing.Size(229, 13);
            this.m_label_droite_test.TabIndex = 21;
            this.m_label_droite_test.Text = "                                                                          ";
            // 
            // m_label_2
            // 
            this.m_label_2.AutoSize = true;
            this.m_label_2.Location = new System.Drawing.Point(1303, 120);
            this.m_label_2.Name = "m_label_2";
            this.m_label_2.Size = new System.Drawing.Size(35, 13);
            this.m_label_2.TabIndex = 16;
            this.m_label_2.Text = "label2";
            // 
            // Mode_Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.m_label_droite_test);
            this.Controls.Add(this.m_label_test);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_label_2);
            this.Controls.Add(this.m_BoutonAU);
            this.Controls.Add(this.m_BoutonDCY);
            this.Name = "Mode_Auto";
            this.Text = "Mode Automatique ";
            this.Load += new System.EventHandler(this.Mode_Auto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_BoutonRetour;
        private System.Windows.Forms.Button m_BoutonDCY;
        private System.Windows.Forms.Button m_BoutonAU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_label_test;
        private System.Windows.Forms.Label m_label_droite_test;
        private System.Windows.Forms.Label m_label_2;
    }
}