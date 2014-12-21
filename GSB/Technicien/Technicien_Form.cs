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
    public partial class Technicien_Form : Form
    {
        public Technicien_Form()
        {
            InitializeComponent();
        }
        bddGSB gsb;
        ArrayList lesDemandes = new ArrayList();
        Demande demandeEncours;
        private void Technicien_Form_Load(object sender, EventArgs e)
        {
            gsb = new bddGSB();
            gsb.connexionBase("ouvrir");
            LBbienvenue.Text = "Bienvenue dans votre espace technicien " + Login.unPersonnel.getNom() + " " + Login.unPersonnel.getPrenom();

            MySqlDataReader myReader = gsb.getDemandesT(Login.unPersonnel.getMatricule());
            while (myReader.Read())
            {
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
                    CBtickets.Items.Add("Ticket n° " + uneDemande.getIdDemande() + " pour : " + uneDemande.getMatDemande());
                }
            }
            gsb.connexionBase("fermer");
        }

        private void CBtickets_SelectedIndexChanged(object sender, EventArgs e)
        {

            LBmateriel.Text = "Matériel : ";
            LBetat.Text = "Etat : ";
            LBtype.Text = "Type : ";
            LBniveau.Text = "Niveau : ";
            LBpersonnel.Text = "Personnel : ";
            TBdescription.Text = "";
            foreach (Demande uneDemande in lesDemandes) {
                if (CBtickets.SelectedItem.ToString().Contains(uneDemande.getIdDemande().ToString())) {
                    demandeEncours = uneDemande;
                    LBmateriel.Text += uneDemande.getMatDemande() + " ticket n°" + uneDemande.getIdDemande().ToString();
                    LBetat.Text += uneDemande.getEtatDemande(2);
                    LBtype.Text += uneDemande.getTraitementDemande().ToString();
                    LBniveau.Text += uneDemande.getNiveauDemande().ToString();
                    LBpersonnel.Text += uneDemande.getpersDemande();
                    TBdescription.Text += uneDemande.getDescriptionDemande();
                }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gsb.connexionBase("ouvrir");
            String debut = DTdebut.Value.ToString();
            String fin = DTfin.Value.ToString();
            String tache = TBtache.Text;
            if (tache != "") {
                gsb.enregitrerPhase(demandeEncours.getIdDemande(), debut, fin, tache);
                MessageBox.Show("Tache enregistré !");
            }
            else {
                MessageBox.Show("Veuillez décrire la tache effectué");
            }
            gsb.connexionBase("fermer");

        }

        private void CBetat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBtickets.SelectedItem.ToString() != "") {
                if (CBetat.SelectedItem.ToString() != "") {
                    gsb.connexionBase("ouvrir");
                    gsb.updateEtatDemande(CBetat.SelectedItem.ToString(), demandeEncours.getIdDemande());
                    gsb.connexionBase("fermer");
                    MessageBox.Show("Etat du ticket mis à jours.");
                    demandeEncours.setEtatDemande(CBetat.SelectedItem.ToString());
                    LBetat.Text = "Etat : ";
                    LBetat.Text += demandeEncours.getEtatDemande(2);
                }
            }
            else {
                MessageBox.Show("Il vous faut choisir un ticket pour modifier son etat.");
            }
        }

        private void CBtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBtickets.SelectedItem.ToString() != "") {
                if (CBtype.SelectedItem.ToString() != "") {
                    gsb.connexionBase("ouvrir");
                    gsb.updateTypeDemande(CBtype.SelectedItem.ToString(), demandeEncours.getIdDemande());
                    gsb.connexionBase("fermer");
                    MessageBox.Show("Type de traitement mis à jours.");
                    demandeEncours.setTraitementDemande(CBtype.SelectedItem.ToString());
                    LBtype.Text = "Type : ";
                    LBtype.Text += demandeEncours.getTraitementDemande().ToString();
                }
            }
            else {
                MessageBox.Show("Il vous faut choisir un ticket pour modifier son type de traitement.");
            }
        }

    }
}
