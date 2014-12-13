using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class Demande
    {
        private int idDemande;
        private String etatDemande;
        private String traitementDemande;
        private String descriptionDemande;
        private String persDemande;
        private String matDemande;
        private String techDemande;

        public Demande(int idDemande, String etatDemande, String traitementDemande, String descriptionDemande, String persDemande, String matDemande, String techDemande) {
            this.idDemande = idDemande;
            this.etatDemande = etatDemande;
            this.traitementDemande = traitementDemande;
            this.descriptionDemande = descriptionDemande;
            this.persDemande = persDemande;
            this.matDemande = matDemande;
            this.techDemande = techDemande;
        }

        public int getIdDemande()
        {
            return idDemande;
        }
        public String getEtatDemande()
        {
            return "Ticket n°" + idDemande + " sur " + matDemande + " est " + etatDemande + " (" + descriptionDemande + ")";
        }
        public String getTraitementDemande()
        {
            return traitementDemande;
        }
        public String getDescriptionDemande()
        {
            return descriptionDemande;
        }
        public String getMatDemande()
        {
            return matDemande;
        }
        public String getTechDemande()
        {
            return techDemande;
        }
        public String getpersDemande()
        {
            return persDemande;
        }

    }

}