using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    /// <summary>                                                            
    /// Classe de personnel avec les propriétés d'un personnel ou technicien du laboratoire                 
    /// </summary>  
    public class Personnel
    {
        private String matricule;
        private int id;
        private String nom;
        private String prenom;
        private String ville;
        private String type;
        private int niveauIntervention;

        /// <summary>                                                            
        /// Constructeur de la classe Personnel               
        /// </summary> 
        public Personnel(String matricule, int id, String nom, String prenom, String ville, String type, int niveauIntervention = 0)
        {
            this.matricule = matricule;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
            this.type = type;
            this.niveauIntervention = niveauIntervention;
        }

        public String getMatricule() {
            return matricule;
        }
        public int getId() {
            return id;
        }
        public String getNom() {
            return nom;
        }
        public String getPrenom() {
            return prenom;
        }
        public String getVille() {
            return ville;
        }
        public String getType() {
            return type;
        }
        public int getNiveauIntervention()
        {
            return niveauIntervention;
        }
    }
}
