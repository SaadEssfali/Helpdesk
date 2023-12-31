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

        public event EventHandler NotificationUpdated;
        public UserControlDashboard()
        {
            InitializeComponent();
            notification();
            nticket.Parent = picnticket;
            dashID.Parent = picVotreID;
            statuticket.Parent = picnticket;
            nresolu.Parent = picRticket;
            nbrenotif.Parent = picNotif;
            nresolu.Location = new(90, 42);
            dashID.Location = new Point(123, 42);
            nticket.Location = new Point(123, 37);
            nbrenotif.Location = new Point(123, 42);
            hourlabel.Text = DateTime.Now.ToString("HH:mm:ss");
            monthLabel.Text = DateTime.Now.ToString("MMMM");
            dayOfMonthLabel.Text = DateTime.Now.ToString("dd");
            dayOfWeekLabel.Text = DateTime.Now.ToString("dddd");
            YearLabel.Text = DateTime.Now.ToString("yyyy");
            dashID.Text = Employe.id.ToString();
            refreshntciket();




        }
        //statistique pour dashboard de  employee
        public void refreshntciket()
        {
            nticket.Text = ticket.TicketID.ToString();
            statuticket.Text = ticket.Statut;
            nresolu.Text = ticket.resolvedticket().ToString();
        }

        //verification si se trouve des notifications non lus dans la table notificatiionLog
        public void notification()
        {
            
            SqlConnection cnx = Program.GetConnection();          
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(NotificationID)from NotificationLog  n Inner join Ticket t on n.TicketID=t.TicketID where EmployeID=@EmployeID and IsRead=0",cnx);
            cmd.Parameters.AddWithValue("@EmployeID", Employe.id);
            int nbre;
         
            cmd.CommandTimeout = 60; 

            if (cmd.ExecuteScalar() == null)
            {
                nbre = 0;
            }
            else { nbre= (int)cmd.ExecuteScalar(); }

            if (nbre > 0) {
                // si se trouve notification non lu un event est declenché pour afficher symbol rouge de notification
                NotificationUpdated?.Invoke(this, EventArgs.Empty);
            }
            cnx.Close();

            nbrenotif.Text = nbre.ToString();
          
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
            notification();
        

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
