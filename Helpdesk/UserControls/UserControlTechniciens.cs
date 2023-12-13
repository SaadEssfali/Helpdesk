using Helpdesk.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.UserControls
{
    public partial class UserControlTechniciens : UserControl
    {
        public UserControlTechniciens()
        {
            InitializeComponent();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlTechniciens_Load(object sender, EventArgs e)
        {
            Technicienpicbox(flowLayoutPanel1);
        }
        public static void Technicienpicbox(FlowLayoutPanel flowLayoutPanel1)
        {


            DataTable technicienTable = Classtech.technicienInformation();

            foreach (DataRow row in technicienTable.Rows)
            {
                flowyoutTech techControl = new flowyoutTech();
                {
                    flowyoutTech.label1.Text = row["Nom"].ToString();
                    flowyoutTech.label2.Text = row["Prenom"].ToString();
                    flowyoutTech.label3.Text = row["Specialite"].ToString();
                }


                flowLayoutPanel1.Controls.Add(techControl);




            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
