namespace GSB
{
    /// <summary>                                                            
    /// Fenêtre de création de tickets pour le personnel du laboratoire.                 
    /// </summary>  
    partial class Personnel_Form
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
            this.LBbienvenue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBniveau = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBchoix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBmateriel = new System.Windows.Forms.ComboBox();
            this.TBdescrib = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBenCours = new System.Windows.Forms.ListBox();
            this.LBresolue = new System.Windows.Forms.ListBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBbienvenue
            // 
            this.LBbienvenue.AutoSize = true;
            this.LBbienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBbienvenue.Location = new System.Drawing.Point(21, 14);
            this.LBbienvenue.Name = "LBbienvenue";
            this.LBbienvenue.Size = new System.Drawing.Size(0, 16);
            this.LBbienvenue.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CBniveau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CBchoix);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBmateriel);
            this.groupBox1.Controls.Add(this.TBdescrib);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(24, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faire une demande";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Niveau d\'urgence";
            // 
            // CBniveau
            // 
            this.CBniveau.FormattingEnabled = true;
            this.CBniveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CBniveau.Location = new System.Drawing.Point(171, 93);
            this.CBniveau.Name = "CBniveau";
            this.CBniveau.Size = new System.Drawing.Size(36, 24);
            this.CBniveau.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Choisir un problème :";
            // 
            // CBchoix
            // 
            this.CBchoix.FormattingEnabled = true;
            this.CBchoix.Items.AddRange(new object[] {
            "Pas d\'accès réseau",
            "Le matériel ne s\'allume pas",
            "S\'allume mais pas d\'affichage",
            "Redémarrage inopiné",
            "Autre..."});
            this.CBchoix.Location = new System.Drawing.Point(24, 140);
            this.CBchoix.Name = "CBchoix";
            this.CBchoix.Size = new System.Drawing.Size(224, 24);
            this.CBchoix.TabIndex = 7;
            this.CBchoix.SelectedIndexChanged += new System.EventHandler(this.CBchoix_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veuillez décrire votre problème et choisir le matériel concercé.\r\nUn technicien t" +
    "raitera votre demande dans les plus brefs délais.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Choisir un materiel :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description du problème si autre :";
            // 
            // CBmateriel
            // 
            this.CBmateriel.FormattingEnabled = true;
            this.CBmateriel.Location = new System.Drawing.Point(21, 93);
            this.CBmateriel.Name = "CBmateriel";
            this.CBmateriel.Size = new System.Drawing.Size(121, 24);
            this.CBmateriel.TabIndex = 3;
            // 
            // TBdescrib
            // 
            this.TBdescrib.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBdescrib.Enabled = false;
            this.TBdescrib.Location = new System.Drawing.Point(21, 199);
            this.TBdescrib.Multiline = true;
            this.TBdescrib.Name = "TBdescrib";
            this.TBdescrib.Size = new System.Drawing.Size(405, 173);
            this.TBdescrib.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(171, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Envoyer ticket";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LBenCours);
            this.groupBox2.Controls.Add(this.LBresolue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(513, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 437);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etat de vos demandes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Résolues";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "En cours";
            // 
            // LBenCours
            // 
            this.LBenCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBenCours.FormattingEnabled = true;
            this.LBenCours.Location = new System.Drawing.Point(16, 53);
            this.LBenCours.Name = "LBenCours";
            this.LBenCours.Size = new System.Drawing.Size(416, 160);
            this.LBenCours.TabIndex = 1;
            this.LBenCours.SelectedIndexChanged += new System.EventHandler(this.LBenCours_SelectedIndexChanged);
            // 
            // LBresolue
            // 
            this.LBresolue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBresolue.FormattingEnabled = true;
            this.LBresolue.Location = new System.Drawing.Point(16, 246);
            this.LBresolue.Name = "LBresolue";
            this.LBresolue.Size = new System.Drawing.Size(416, 160);
            this.LBresolue.TabIndex = 0;
            // 
            // Personnel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1001, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBbienvenue);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Personnel_Form";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.Personnel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBbienvenue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBmateriel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBenCours;
        private System.Windows.Forms.ListBox LBresolue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBchoix;
        private System.Windows.Forms.TextBox TBdescrib;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBniveau;

    }
}