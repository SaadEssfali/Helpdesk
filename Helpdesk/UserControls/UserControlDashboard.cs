using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.UserControls
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            nticket.Parent = picnticket;
            dashID.Parent = picVotreID;
            statuticket.Parent = picnticket;
            nresolu.Parent = picRticket;
            nresolu.Location = new(90,42);
            dashID.Location = new Point(123, 42);
            nticket.Location = new Point(123, 37);
            hourlabel.Text = DateTime.Now.ToString("HH:mm:ss");
            monthLabel.Text = DateTime.Now.ToString("MMMM");
            dayOfMonthLabel.Text = DateTime.Now.ToString("dd");
            dayOfWeekLabel.Text = DateTime.Now.ToString("dddd");
            YearLabel.Text = DateTime.Now.ToString("yyyy");
            dashID.Text = Employe.id.ToString();
            nresolu.Text = ticket.resolvedticket().ToString();
            refreshntciket();




        }
        public void refreshntciket()
        {
            nticket.Text = ticket.TicketID.ToString();
            statuticket.Text = ticket.Statut;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {


        }

        private void hourlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourlabel.Text = DateTime.Now.ToString("HH:mm:ss");
            monthLabel.Text = DateTime.Now.ToString("MMMM");
            dayOfMonthLabel.Text = DateTime.Now.ToString("dd");
            dayOfWeekLabel.Text = DateTime.Now.ToString("dddd");
            YearLabel.Text = DateTime.Now.ToString("yyyy");
        }

        private void dayOfMonthLabel_Click(object sender, EventArgs e)
        {

        }

        private void dashID_Click(object sender, EventArgs e)
        {

        }

        private void picVotreID_Click(object sender, EventArgs e)
        {

        }

        private void dashID_Click_1(object sender, EventArgs e)
        {

        }

        private void nticket_Click(object sender, EventArgs e)
        {

        }
    }
}
