using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    public class Personnel
    {
        private String matricule;
        private int id;
        private String nom;
        private String prenom;
        private String ville;
        private String type;

        public Personnel(String matricule, int id, String nom, String prenom, String ville, String type)
        {
            this.matricule = matricule;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
            this.type = type;
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
        public String getType()
        {
            return type;
        }
    }
}
