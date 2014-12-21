namespace GSB
{
    /// <summary>                                                            
    /// Fenêtre de gestion des tickets pour les techniciens                  
    /// </summary>  
    partial class Technicien_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBtickets = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBdescription = new System.Windows.Forms.Label();
            this.TBdescription = new System.Windows.Forms.TextBox();
            this.LBmateriel = new System.Windows.Forms.Label();
            this.LBniveau = new System.Windows.Forms.Label();
            this.LBpersonnel = new System.Windows.Forms.Label();
            this.LBtype = new System.Windows.Forms.Label();
            this.LBetat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBtache = new System.Windows.Forms.TextBox();
            this.DTfin = new System.Windows.Forms.DateTimePicker();
            this.DTdebut = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBtype = new System.Windows.Forms.ComboBox();
            this.CBetat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBbienvenue
            // 
            this.LBbienvenue.AutoSize = true;
            this.LBbienvenue.Location = new System.Drawing.Point(13, 13);
            this.LBbienvenue.Name = "LBbienvenue";
            this.LBbienvenue.Size = new System.Drawing.Size(58, 13);
            this.LBbienvenue.TabIndex = 0;
            this.LBbienvenue.Text = "Bienvenue";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(138, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enregistrer phase";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectionner un ticket :";
            // 
            // CBtickets
            // 
            this.CBtickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtickets.FormattingEnabled = true;
            this.CBtickets.Location = new System.Drawing.Point(16, 49);
            this.CBtickets.Name = "CBtickets";
            this.CBtickets.Size = new System.Drawing.Size(229, 24);
            this.CBtickets.TabIndex = 3;
            this.CBtickets.SelectedIndexChanged += new System.EventHandler(this.CBtickets_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBdescription);
            this.groupBox1.Controls.Add(this.TBdescription);
            this.groupBox1.Controls.Add(this.LBmateriel);
            this.groupBox1.Controls.Add(this.LBniveau);
            this.groupBox1.Controls.Add(this.LBpersonnel);
            this.groupBox1.Controls.Add(this.LBtype);
            this.groupBox1.Controls.Add(this.LBetat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 354);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // LBdescription
            // 
            this.LBdescription.AutoSize = true;
            this.LBdescription.Location = new System.Drawing.Point(15, 144);
            this.LBdescription.Name = "LBdescription";
            this.LBdescription.Size = new System.Drawing.Size(82, 16);
            this.LBdescription.TabIndex = 7;
            this.LBdescription.Text = "Description :";
            // 
            // TBdescription
            // 
            this.TBdescription.BackColor = System.Drawing.SystemColors.InfoText;
            this.TBdescription.Enabled = false;
            this.TBdescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TBdescription.Location = new System.Drawing.Point(18, 168);
            this.TBdescription.Multiline = true;
            this.TBdescription.Name = "TBdescription";
            this.TBdescription.Size = new System.Drawing.Size(393, 170);
            this.TBdescription.TabIndex = 6;
            // 
            // LBmateriel
            // 
            this.LBmateriel.AutoSize = true;
            this.LBmateriel.Location = new System.Drawing.Point(15, 21);
            this.LBmateriel.Name = "LBmateriel";
            this.LBmateriel.Size = new System.Drawing.Size(65, 16);
            this.LBmateriel.TabIndex = 5;
            this.LBmateriel.Text = "Matériel : ";
            // 
            // LBniveau
            // 
            this.LBniveau.AutoSize = true;
            this.LBniveau.Location = new System.Drawing.Point(15, 93);
            this.LBniveau.Name = "LBniveau";
            this.LBniveau.Size = new System.Drawing.Size(60, 16);
            this.LBniveau.TabIndex = 4;
            this.LBniveau.Text = "Niveau : ";
            // 
            // LBpersonnel
            // 
            this.LBpersonnel.AutoSize = true;
            this.LBpersonnel.Location = new System.Drawing.Point(15, 119);
            this.LBpersonnel.Name = "LBpersonnel";
            this.LBpersonnel.Size = new System.Drawing.Size(78, 16);
            this.LBpersonnel.TabIndex = 3;
            this.LBpersonnel.Text = "Personnel : ";
            // 
            // LBtype
            // 
            this.LBtype.AutoSize = true;
            this.LBtype.Location = new System.Drawing.Point(15, 67);
            this.LBtype.Name = "LBtype";
            this.LBtype.Size = new System.Drawing.Size(49, 16);
            this.LBtype.TabIndex = 2;
            this.LBtype.Text = "Type : ";
            // 
            // LBetat
            // 
            this.LBetat.AutoSize = true;
            this.LBetat.Location = new System.Drawing.Point(15, 44);
            this.LBetat.Name = "LBetat";
            this.LBetat.Size = new System.Drawing.Size(40, 16);
            this.LBetat.TabIndex = 1;
            this.LBetat.Text = "Etat : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TBtache);
            this.groupBox2.Controls.Add(this.DTfin);
            this.groupBox2.Controls.Add(this.DTdebut);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(508, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phases";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tache effectué :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Début :";
            // 
            // TBtache
            // 
            this.TBtache.Location = new System.Drawing.Point(28, 130);
            this.TBtache.Multiline = true;
            this.TBtache.Name = "TBtache";
            this.TBtache.Size = new System.Drawing.Size(347, 117);
            this.TBtache.TabIndex = 4;
            // 
            // DTfin
            // 
            this.DTfin.CustomFormat = "dd/MM/yyyy | hh:mm";
            this.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTfin.Location = new System.Drawing.Point(114, 61);
            this.DTfin.Name = "DTfin";
            this.DTfin.Size = new System.Drawing.Size(200, 22);
            this.DTfin.TabIndex = 3;
            // 
            // DTdebut
            // 
            this.DTdebut.CustomFormat = "dd/MM/yyyy | hh:mm";
            this.DTdebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTdebut.Location = new System.Drawing.Point(114, 33);
            this.DTdebut.Name = "DTdebut";
            this.DTdebut.Size = new System.Drawing.Size(200, 22);
            this.DTdebut.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CBtype);
            this.groupBox3.Controls.Add(this.CBetat);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(508, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 118);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outils";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(227, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 58);
            this.button2.TabIndex = 10;
            this.button2.Text = "Envoyer mail";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Etat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type :";
            // 
            // CBtype
            // 
            this.CBtype.FormattingEnabled = true;
            this.CBtype.Items.AddRange(new object[] {
            "Téléphone",
            "Télémaintenance",
            "Déplacement"});
            this.CBtype.Location = new System.Drawing.Point(60, 72);
            this.CBtype.Name = "CBtype";
            this.CBtype.Size = new System.Drawing.Size(121, 24);
            this.CBtype.TabIndex = 1;
            this.CBtype.SelectedIndexChanged += new System.EventHandler(this.CBtype_SelectedIndexChanged);
            // 
            // CBetat
            // 
            this.CBetat.FormattingEnabled = true;
            this.CBetat.Items.AddRange(new object[] {
            "En cours de traitement",
            "Résolue"});
            this.CBetat.Location = new System.Drawing.Point(60, 30);
            this.CBetat.Name = "CBetat";
            this.CBetat.Size = new System.Drawing.Size(121, 24);
            this.CBetat.TabIndex = 0;
            this.CBetat.SelectedIndexChanged += new System.EventHandler(this.CBetat_SelectedIndexChanged);
            // 
            // Technicien_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(960, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CBtickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBbienvenue);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Technicien_Form";
            this.Text = "Technicien";
            this.Load += new System.EventHandler(this.Technicien_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBbienvenue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBtickets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBetat;
        private System.Windows.Forms.Label LBtype;
        private System.Windows.Forms.Label LBpersonnel;
        private System.Windows.Forms.Label LBniveau;
        private System.Windows.Forms.Label LBmateriel;
        private System.Windows.Forms.TextBox TBdescription;
        private System.Windows.Forms.Label LBdescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBtache;
        private System.Windows.Forms.DateTimePicker DTfin;
        private System.Windows.Forms.DateTimePicker DTdebut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBtype;
        private System.Windows.Forms.ComboBox CBetat;
        private System.Windows.Forms.Button button2;

    }
}