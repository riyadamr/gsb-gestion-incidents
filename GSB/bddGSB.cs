using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GSB
{
    class bddGSB
    {
        static private string paramConnexion = "Database=gsb;Data Source=localhost;User Id=root;Password=";
        static private MySqlConnection connexion = new MySqlConnection(paramConnexion);
        static private MySqlDataReader myReader = null;

        public MySqlConnection getConnexion() {
            return connexion;
        }

        public void connexionBase(string connexionChoix) {
            if (connexionChoix == "ouvrir") { connexion.Open(); }
            if (connexionChoix == "fermer") { connexion.Close(); }
        }

        public MySqlDataReader getPersonnel (String identifiant) {
                String requete = @"SELECT *, count(*) as NBR
                FROM personnel WHERE matricule ='" + identifiant + "';";
                myReader = null;
                MySqlCommand myCommand = new MySqlCommand(requete, connexion);
                myReader = myCommand.ExecuteReader();
                return myReader;
        }

        public String getTypePersonnel(String identifiant) {
            int nbr = 0;
            String resultat;
            String requete = @"SELECT count(*) AS nbr
            FROM technicien WHERE idTechnicien ='" + identifiant + "';";
            myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read()) {
                nbr = Convert.ToInt32(myReader["nbr"]);
            }
            myReader.Close();
            if (nbr == 0) {
                resultat = "personnel";
            }
            else {
                resultat = "technicien";
            }
            return resultat;
        }

        public MySqlDataReader getMateriel(String idPersonnel)
        {
            String requete = @"SELECT *
            FROM materiel WHERE matProprio ='" + idPersonnel + "';";
            myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myReader = myCommand.ExecuteReader();
            return myReader;
        }

        public void enregisterDemande (String describ, String personnel, String materiel) {
            String requete = @"SELECT idMateriel
            FROM materiel WHERE matNom ='" + materiel + "' AND matProprio = '"+personnel+ "'";
            myReader.Close();
            myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            int idMat = Convert.ToInt32(myReader["idMateriel"]);

            myReader.Close();
            myReader = null;
            String requete2 = @"INSERT INTO demande (descriptionDemande, persDemande, matDemande) 
            VALUES ('" + describ + "','" + personnel + "'," + idMat + ");";
            MySqlCommand myCommand2 = new MySqlCommand(requete2, connexion);
            myCommand2.ExecuteNonQuery();
        }

        public MySqlDataReader getDemandes(String identifiant) {
            String requete = @"SELECT demande.* , materiel.matNom as matNom
            FROM demande, materiel WHERE persDemande ='" + identifiant + "'AND idMateriel = matDemande;";
            myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, this.getConnexion());
            myReader = myCommand.ExecuteReader();
            return myReader;
        }
    }
}