using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GSB
{
    /// <summary>                                                            
    /// Classe de gestions de la connexion et des interactions avec la base de données.                    
    /// </summary>  
    public class bddGSB
    {
        static private string paramConnexion = "Database=gsb;Data Source=localhost;User Id=root;Password=";
        static private MySqlConnection connexion = new MySqlConnection(paramConnexion);
        static private MySqlDataReader myReader = null;

        public MySqlConnection getConnexion() {
            return connexion;
        }

        /// <summary>                                                            
        /// Ouvre ou ferme la connexion en cours.                   
        /// </summary>                                                           
        /// <param name="connexionChoix">Contient le choix d'ouvrir ou de fermer la connexion.</param>   
        public void connexionBase(string connexionChoix) {
            if (connexionChoix == "ouvrir") { connexion.Open(); }
            if (connexionChoix == "fermer") { connexion.Close(); }
        }

        /// <summary>                                                            
        /// Retourne les informations sur un personnel en fonction de l'identifiant renseigné en paramètre.                       
        /// </summary>                                                           
        /// <param name="identifiant">Identifiant correspondant à la clé primaire de la table personnel.</param>   
        public MySqlDataReader getPersonnel (String identifiant) {
                String requete = @"SELECT *, count(*) as NBR
                FROM personnel WHERE matricule ='" + identifiant + "';";
                myReader = null;
                MySqlCommand myCommand = new MySqlCommand(requete, connexion);
                myReader = myCommand.ExecuteReader();
                return myReader;
        }

        /// <summary>                                                            
        /// Retourne le type (personnel ou technicien) d'un utilisateur.                     
        /// </summary>                                                           
        /// <param name="identifiant">Identifiant correspondant à la clé primaire de la table personnel.</param>   
        public ArrayList getTypePersonnel(String identifiant)
        {
            int nbr = 0;
            ArrayList resultat = new ArrayList();
            myReader.Close();
            String requete = @"SELECT count(*) AS nbr, niveauInterv
            FROM technicien WHERE idTechnicien ='" + identifiant + "';";
            myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read()) {
                nbr = Convert.ToInt32(myReader["nbr"]);
                resultat.Add(myReader["niveauInterv"].ToString());
            }
            myReader.Close();
            if (nbr == 0) {
                resultat.Add("personnel");
            }
            else {
                resultat.Add("technicien");
            }
            return resultat;
        }

        /// <summary>                                                            
        /// Retourne les informations sur les matériels d'un personnel.                   
        /// </summary>                                                           
        /// <param name="idPersonnel">idPersonnel correspondant à la clé étrangère liée à la table personnel.</param>   
        public MySqlDataReader getMateriel(String idPersonnel)
        {
            String requete = @"SELECT *
            FROM materiel WHERE matProprio ='" + idPersonnel + "';";
            myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myReader = myCommand.ExecuteReader();
            return myReader;
        }

        /// <summary>                                                            
        /// Enregiste une nouvelle demande dans la table demande pour un utilisateur donné.                 
        /// </summary>                                                           
        /// <param name="describ">description du problème de la demande</param>
        /// <param name="niveauDemande">niveau de d'urgence pour la demande</param>
        /// <param name="personnel">matricule du personnel qui emet la demande</param>
        /// <param name="materiel">materiel concerné par la demande.</param>
        public void enregisterDemande (String describ, int niveauDemande, String personnel, String materiel) {
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
            String requete2 = @"INSERT INTO demande (descriptionDemande, niveauDemande, persDemande, matDemande) 
            VALUES ('" + describ + "'," + niveauDemande + ",'" + personnel + "'," + idMat + ");";
            MySqlCommand myCommand2 = new MySqlCommand(requete2, connexion);
            myCommand2.ExecuteNonQuery();
        }

        /// <summary>                                                            
        /// Retourne les demandes émisent par un personnel donné.                 
        /// </summary>                                                           
        /// <param name="identifiant">identifiant du personnel concerné</param>  
        public MySqlDataReader getDemandesP(String identifiant) {
            String requete = @"SELECT demande.* , materiel.matNom as matNom
            FROM demande, materiel WHERE persDemande ='" + identifiant + "'AND idMateriel = matDemande;";
            myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myReader = myCommand.ExecuteReader();
            return myReader;
        }

        /// <summary>                                                            
        /// Retourne les demandes assignées à un techicien donné              
        /// </summary>                                                           
        /// <param name="identifiant">identifiant du personnel concerné</param>  
        public MySqlDataReader getDemandesT(String identifiant) {
            String requete = @"SELECT demande.* , materiel.matNom as matNom FROM demande, materiel 
            WHERE techDemande ='" + identifiant + "' AND etatDemande <> 'Cloturé' AND  idMateriel = matDemande ORDER BY idDemande;";
            myReader = null;
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myReader = myCommand.ExecuteReader();
            return myReader;
        }

        /// <summary>                                                            
        /// Enregistre un nouvelle phase pour une demande par un technicien donné           
        /// </summary>                                                           
        /// <param name="identifiant">identifiant du technicien qui créer la phase</param>
        /// <param name="debut">date et heure de debut de la phase</param>
        /// <param name="fin">date et heure de fin de la phase</param>
        /// <param name="fin">description de la tache effectuée</param>
        public void enregitrerPhase(int identifiant, String debut, String fin, String tache)
        {
            myReader = null;
            String requete = @"INSERT INTO phasedemande (dateHdebut, dateHfin, tache, laDemande) 
            VALUES ('" + debut + "','" + fin + "','" + tache + "'," + identifiant + ");";
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myCommand.ExecuteNonQuery();
        }

        /// <summary>                                                            
        /// Modifie l'état de la demande dans la base de données.             
        /// </summary>                                                           
        /// <param name="identifiant">identifiant de la demande concernée</param> 
        /// <param name="etat">nouvelle valeur de l'état</param> 
        public void updateEtatDemande(String etat, int identifiant) {
            myReader = null;
            String requete = @"UPDATE demande
            SET etatDemande = '" + etat + "' WHERE idDemande = " + identifiant + ";";
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myCommand.ExecuteNonQuery();
        }

        /// <summary>                                                            
        /// Modifie le type de traitement de la demande dans la base de données.             
        /// </summary>                                                           
        /// <param name="identifiant">identifiant de la demande concernée</param> 
        /// <param name="etat">nouvelle valeur du type de traitement</param> 
        public void updateTypeDemande(String type, int identifiant) {
            myReader = null;
            String requete = @"UPDATE demande
            SET traitementDemande = '" + type + "' WHERE idDemande = " + identifiant + ";";
            MySqlCommand myCommand = new MySqlCommand(requete, connexion);
            myCommand.ExecuteNonQuery();
        }
    }
}