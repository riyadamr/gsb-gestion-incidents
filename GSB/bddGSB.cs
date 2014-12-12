using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB
{
    class bddGSB
    {
        static private string paramConnexion = "Database=gsb;Data Source=localhost;User Id=root;Password=";
        static private MySqlConnection connexion = new MySqlConnection(paramConnexion);

        public MySqlConnection getConnexion() {
            return connexion;
        }

        public void connexionBase(string connexionChoix) {
            if (connexionChoix == "ouvrir") { connexion.Open(); }
            if (connexionChoix == "fermer") { connexion.Close(); }
        }

        public MySqlDataReader getPersonnel (String identifiant) {
                String requete =
                @"SELECT *, count(*) as NBR
                FROM personnel WHERE matricule ='" + identifiant + "';";
                MySqlDataReader myReader = null;
                MySqlCommand myCommand = new MySqlCommand(requete, this.getConnexion());
                myReader = myCommand.ExecuteReader();
                return myReader;
        }

        public String getTypePersonnel(String identifiant) {
            int nbr = 0;
            String resultat;
            String requete =
            @"SELECT count(*) AS nbr
            FROM technicien WHERE idTechnicien ='" + identifiant + "';";
            MySqlDataReader myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, this.getConnexion());
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
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
    }
}
