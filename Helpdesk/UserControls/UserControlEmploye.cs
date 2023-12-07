using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.UserControls
{
    public partial class UserControlEmploye : UserControl
    {
        private string nom;
        private string prenom;

        public UserControlEmploye(string nom, string prenom)
        {
            InitializeComponent();
            this.nom = nom;
            this.prenom = prenom;

            Nom.Text = nom;
            Prnm.Text = prenom;






        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void UserControlEmploye_Load(object sender, EventArgs e)
        {
            Nom.Parent = Id_card; 
            Prnm.Parent = Id_card;
            Nom.BackColor = Color.Transparent;
            Prnm.BackColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
