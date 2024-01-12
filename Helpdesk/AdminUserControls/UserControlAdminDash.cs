using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.AdminUserControls
{
    public partial class UserControlAdminDash : UserControl
    {
        public static SqlConnection cnx;

        public UserControlAdminDash()
        {
            InitializeComponent();



            TicketResolueadmin();
            nombretech1();
            nombreticket1();
            nombreemploye1();
            ticketresolut.Parent = TickResPicture;
            ticketresolut.BackColor = Color.Transparent;
            nombreticket.Parent = pictureBox2;
            nombreticket.BackColor = Color.Transparent;
            nombreemploye.Parent = pictureBox3;
            nombreemploye.BackColor = Color.Transparent;
            nombretech.Parent = pictureBox1;
            nombretech.BackColor = Color.Transparent;
            nombretech.ForeColor = Color.White;
            nombreticket.ForeColor = Color.White;




        }

        private void ticketresolut_Click(object sender, EventArgs e)
        {

        }
        public  void TicketResolueadmin()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(TicketID) from Ticket where Statut ='résolu';", cnx);
            int nombreTicketsResolus = (int)cmd.ExecuteScalar();

            ticketresolut.Text = nombreTicketsResolus.ToString();


        }
        public  void nombretech1()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(Id) from Technicien", cnx);
            int nombreteech = (int)cmd.ExecuteScalar();
            nombretech.Text = nombreteech.ToString();

        }
        public  void nombreticket1()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(TicketID) from Ticket", cnx);
            int nombreticket1 = (int)cmd.ExecuteScalar();
            nombreticket.Text = nombreticket1.ToString();

        }
        public  void nombreemploye1()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(ID) from Employe", cnx);
            int nombreemploye1 = (int)cmd.ExecuteScalar();
            nombreemploye.Text = nombreemploye1.ToString();
        }

        private void nombretech_Click(object sender, EventArgs e)
        {

        }

        private void nombreticket_Click(object sender, EventArgs e)
        {

        }

        private void UserControlAdminDash_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nombreemploye_Click(object sender, EventArgs e)
        {

        }
    }
}
