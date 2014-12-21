using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GSB
{
    public partial class Personnel_Form : Form
    {
        public Personnel_Form()
        {
            InitializeComponent();
        }
        bddGSB gsb;
        private void Personnel_Load(object sender, EventArgs e)
        {
            gsb = new bddGSB();
            gsb.connexionBase("ouvrir");

            LBbienvenue.Text = "Bienvenue dans votre espace personnel " + Login.unPersonnel.getNom() + " " + Login.unPersonnel.getPrenom();

            MySqlDataReader myReader = gsb.getMateriel(Login.unPersonnel.getMatricule());        
            while (myReader.Read())
            {
                CBmateriel.Items.Add(myReader["matNom"].ToString());
            }
            myReader.Close();
            myReader = gsb.getDemandesP(Login.unPersonnel.getMatricule());

            ArrayList lesDemandes = new ArrayList();
            while (myReader.Read()) {
                int idDemande = Convert.ToInt32(myReader["idDemande"]);
                String etatDemande = (myReader["etatDemande"]).ToString();
                String traitementDemande = myReader["traitementDemande"].ToString();
                String descriptionDemande = myReader["descriptionDemande"].ToString();
                int niveauDemande = Convert.ToInt32(myReader["niveauDemande"]);
                String persDemande = myReader["persDemande"].ToString();
                String matDemande = myReader["matNom"].ToString();
                String techDemande = myReader["techDemande"].ToString();
                Demande uneDemande = new Demande(idDemande, etatDemande, traitementDemande,
                descriptionDemande, niveauDemande, persDemande, matDemande, techDemande);
                lesDemandes.Add(uneDemande);
                if (Login.unPersonnel.getNiveauIntervention() >= uneDemande.getNiveauDemande())
                {
                    if (etatDemande == "Résolue" || etatDemande == "Cloturé")
                    {
                        LBresolue.Items.Add(uneDemande.getEtatDemande(1));
                    }
                    else
                    {
                        LBenCours.Items.Add(uneDemande.getEtatDemande(1));
                    }
                }
            }
            gsb.connexionBase("fermer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gsb.connexionBase("ouvrir");

            if (CBmateriel.SelectedItem != null) {
                if (CBniveau.SelectedItem != null) {
                    if (CBchoix.SelectedItem != null) { 
                        String materiel = CBmateriel.SelectedItem.ToString();
                        String choix = (CBchoix.SelectedItem.ToString());
                        int niveauDemande = Convert.ToInt32(CBniveau.SelectedItem);
                        if (choix == "Autre..." && TBdescrib.Text == "") {
                            MessageBox.Show("Veuillez faire une description du votre problème");
                        }
                        else {
                            String description;
                            if (TBdescrib.Text == "") {
                                description = choix.Replace("'", "''"); ;
                            }
                            else {
                                description = TBdescrib.Text.Replace("'", "''"); ; ;
                            }
                            gsb.enregisterDemande(description, niveauDemande, Login.unPersonnel.getMatricule(), materiel);
                            MessageBox.Show("Ticket enregistré !");
                            System.Threading.Thread fenPersonnel;
                            fenPersonnel = new System.Threading.Thread(new System.Threading.ThreadStart(Login.fenPerso));
                            fenPersonnel.Start();
                            this.Close();
                        }
                    }
                    else {
                        MessageBox.Show("Veuillez choisir un problème");
                    }
                }
                else {
                    MessageBox.Show("Veuillez un niveau d'urgence");
                }
            }
            else {
                MessageBox.Show("Merci de choisir l'équipement concerné par le problème");
            }
            gsb.connexionBase("fermer");
        }

        private void CBchoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            String choix = CBchoix.SelectedItem.ToString();
            if (choix == "Autre...") {
                TBdescrib.BackColor = System.Drawing.SystemColors.Window;
                TBdescrib.Enabled = true;
            }
            else {
                TBdescrib.BackColor = System.Drawing.SystemColors.WindowFrame;
                TBdescrib.Enabled = false;
            }
        }

        private void LBenCours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
