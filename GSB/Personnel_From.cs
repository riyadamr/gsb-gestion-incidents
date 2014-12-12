using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB
{
    public partial class Personnel_From : Form
    {
        public Personnel_From()
        {
            InitializeComponent();
        }

        private void Personnel_Load(object sender, EventArgs e)
        {

            LBbienvenue.Text = "Bienvenue dans votre espace personnel " + Form1.unPersonnel.getNom() + " " + Form1.unPersonnel.getPrenom() + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
