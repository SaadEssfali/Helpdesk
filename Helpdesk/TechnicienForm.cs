using Helpdesk.UserControls;
using Helpdesk.usercontroltech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk
{
    public partial class TechnicienForm : Form
    {
        // déclaration et d'initialisation de dashboard 
        techniciendash techdash = new techniciendash();
        
        

        public TechnicienForm()
        {
            InitializeComponent();

            mainpanel_tech.Controls.Clear();
            mainpanel_tech.Controls.Add(techdash);
            techdash.Dock = DockStyle.Fill;



        }

        private void techniciensButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void HistoryButton_Click_1(object sender, EventArgs e)
        {

        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistoryButton_Click_2(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

        }

        private void TechnicienForm_Load(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            mainpanel_tech.Controls.Clear();
            mainpanel_tech.Controls.Add(techdash);
            techdash.Dock = DockStyle.Fill;


        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
