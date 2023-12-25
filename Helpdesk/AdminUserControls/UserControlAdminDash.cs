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

namespace Helpdesk.AdminUserControls
{
    public partial class UserControlAdminDash : UserControl
    {
        public static SqlConnection cnx = Program.GetConnection();
        public UserControlAdminDash()
        {
            InitializeComponent();
            ticketresolut.Text = TicketResolueadmin().ToString();
            nombretech.Text = nombretech1().ToString();
            nombreticket.Text = nombreticket1().ToString(); 
            nombreemploye.Text = nombreemploye1().ToString();



        }

        private void ticketresolut_Click(object sender, EventArgs e)
        {

        }
        public static int TicketResolueadmin()
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(TicketID) from Ticket where Statut ='résolue';", cnx);
            int nombreTicketsResolus = (int)cmd.ExecuteScalar();
            return nombreTicketsResolus;

        }
        public static int nombretech1()
        {

            SqlCommand cmd = new SqlCommand("select count(Id) from Technicien", cnx);
            int nombreteech = (int)cmd.ExecuteScalar();
            return nombreteech;
        }
        public static int nombreticket1()
        {
            SqlCommand cmd = new SqlCommand("select count(TicketID) from Ticket", cnx);
            int nombreticket1 = (int)cmd.ExecuteScalar();
            return nombreticket1;

        }
        public static int nombreemploye1() 
        {
            SqlCommand cmd = new SqlCommand("select count(ID) from Employe", cnx);
            int nombreemploye1 = (int)cmd.ExecuteScalar();
            return nombreemploye1;
        }

        private void nombretech_Click(object sender, EventArgs e)
        {

        }

        private void nombreticket_Click(object sender, EventArgs e)
        {

        }
    }
}
