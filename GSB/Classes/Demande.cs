using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    /// <summary>                                                            
    /// Classe pour les demandes (tickets) reçus depuis la bdd.             
    /// </summary>  
    public class Demande
    {
        private int idDemande;
        private String etatDemande;
        private String traitementDemande;
        private String descriptionDemande;
        private int niveauDemande;
        private String persDemande;
        private String matDemande;
        private String techDemande;

        /// <summary>                                                            
        /// Constructeur de la classe demande.           
        /// </summary> 
        public Demande(int idDemande, String etatDemande, String traitementDemande, String descriptionDemande, int niveauDemande, String persDemande, String matDemande, String techDemande) {
            this.idDemande = idDemande;
            this.etatDemande = etatDemande;
            this.traitementDemande = traitementDemande;
            this.descriptionDemande = descriptionDemande;
            this.niveauDemande = niveauDemande;
            this.persDemande = persDemande;
            this.matDemande = matDemande;
            this.techDemande = techDemande;
        }

        public int getIdDemande() {
            return idDemande;
        }

        /// <summary>                                                            
        /// Retourne en fonction de la syntaxe choisi :
        /// - pour un personnel : retourne numéro du ticket, nom du matériel de la demande, l'état de la demande et la description entre parenthèses.
        /// - pour un technicien : retourne seulemement l'etat de la demande.
        /// </summary>
        /// <param name="version">Paramètre à 1 pour un personnel et à 2 pour un technicien.</param>  
        public String getEtatDemande(int version) {

                if (version == 1)
                {
                    return "Ticket n°" + idDemande + " sur " + matDemande + " est " + etatDemande + " (" + descriptionDemande + ")";
                }
                else
                {
                    return etatDemande;
                }
        }
        public String getTraitementDemande() {
            return traitementDemande;
        }
        public String getDescriptionDemande() {
            return descriptionDemande;
        }
        public String getMatDemande() {
            return matDemande;
        }
        public String getTechDemande() {
            return techDemande;
        }
        public String getpersDemande() {
            return persDemande;
        }
        public int getNiveauDemande() {
            return niveauDemande;
        }
        public void setTraitementDemande(String traitementDemande) {
            this.traitementDemande = traitementDemande;
        }
        public void setEtatDemande(String etatDemande)
        {
            this.etatDemande = etatDemande;
        }
    }

}