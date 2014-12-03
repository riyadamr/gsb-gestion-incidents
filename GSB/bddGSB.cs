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
        static MySqlConnection connexion = new MySqlConnection(paramConnexion);
        public void connexionBase(string connexionChoix)
        {


            if (connexionChoix == "ouvrir") { connexion.Open(); }
            if (connexionChoix == "fermer") { connexion.Close(); }
        }

        // Requête de sélection des praticiens

        //requete =
        //    @"SELECT nomPraticien,prenomPraticien,
        //   diplomePraticien,specialitePraticien 
        //    FROM praticien ORDER BY nomPraticien,prenomPraticien;";
        // MySqlCommand selectPraticien =
        //     new MySqlCommand(requete, connexionBase);
        // MySqlDataReader resultatsPraticien = 
        //     selectPraticien.ExecuteReader();
    }
}
