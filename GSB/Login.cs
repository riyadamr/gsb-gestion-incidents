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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        bddGSB gsb;
        public static Personnel unPersonnel;

        public static void fenPerso()
        {
            Application.Run(new Personnel_Form());
        }

        public static void fenTech()
        {
            Application.Run(new Technicien_Form());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gsb = new bddGSB();
            gsb.connexionBase("ouvrir");

            if ((TBidentifiant.Text == "Identifiant") || (TBpass.Text == "Mot de passe") ||
                (TBidentifiant.Text == "") || (TBpass.Text == "")) {
                MessageBox.Show("Veuillez renseigner tout les champs");
            }
            else  {
                String identifiant = TBidentifiant.Text;
                String pass = "";

                MySqlDataReader myReader = gsb.getPersonnel(identifiant);
                myReader.Read();

                int nb = Convert.ToInt32(myReader["nbr"]);
                pass = (myReader["passPersonnel"].ToString());
                
                if (nb==0) {
                    MessageBox.Show("Identifiant incorrect.");
                    TBidentifiant.Text = "Identifiant";
                }
                else  {
                    if (pass == TBpass.Text) {
                        int id = Convert.ToInt32(myReader["idPersonnel"]);
                        String nom = (myReader["nomPersonnel"].ToString());
                        String prenom = (myReader["prenomPersonnel"].ToString());
                        String ville = (myReader["villePersonnel"].ToString());
                        ArrayList typePersonnel = new ArrayList();
                        typePersonnel = gsb.getTypePersonnel(identifiant);
                        if (typePersonnel[1].ToString() == "personnel")
                        {
                            unPersonnel = new Personnel(identifiant, id, nom, prenom, ville, typePersonnel[1].ToString());
                            System.Threading.Thread fenPersonnel;
                            fenPersonnel = new System.Threading.Thread(new System.Threading.ThreadStart(fenPerso));
                            fenPersonnel.Start();
                            this.Close();
                        }
                        else {
                            int niveauInterv = Convert.ToInt32(typePersonnel[0]);
                            unPersonnel = new Personnel(identifiant, id, nom, prenom, ville, typePersonnel[1].ToString(), niveauInterv);
                            System.Threading.Thread fenTechnicien;
                            fenTechnicien = new System.Threading.Thread(new System.Threading.ThreadStart(fenTech));
                            fenTechnicien.Start();
                            this.Close();
                        }
                        myReader.Close();
                    }
                    else {
                        MessageBox.Show("Mot de passe incorrect");
                        TBpass.UseSystemPasswordChar = false;
                        TBpass.Text = "Mot de passe";
                    }
                }
            }
            gsb.connexionBase("fermer");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TBidentifiant.Text = "";
        }

        private void TBpass_Click(object sender, EventArgs e)
        {
            TBpass.Text = "";
            TBpass.UseSystemPasswordChar = true;
        }

    }
}
