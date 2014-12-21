namespace GSB
{
    /// <summary>                                                            
    /// Fenêtre de connexion utilisateur                     
    /// </summary>                                                             
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.TBidentifiant = new System.Windows.Forms.TextBox();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(153, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TBidentifiant
            // 
            this.TBidentifiant.Location = new System.Drawing.Point(125, 63);
            this.TBidentifiant.Name = "TBidentifiant";
            this.TBidentifiant.Size = new System.Drawing.Size(150, 20);
            this.TBidentifiant.TabIndex = 1;
            this.TBidentifiant.Text = "Identifiant";
            this.TBidentifiant.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // TBpass
            // 
            this.TBpass.Location = new System.Drawing.Point(125, 90);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(150, 20);
            this.TBpass.TabIndex = 2;
            this.TBpass.Text = "Mot de passe";
            this.TBpass.Click += new System.EventHandler(this.TBpass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestionnaire de tickets\r\nGSB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.TBidentifiant);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TBpass);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(38, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(473, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBidentifiant;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

