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

namespace Helpdesk.usercontroltech
{
    public partial class ticteccontrole : UserControl
    {
        public static SqlConnection cnx;
        private TickControlflow tickcontrolflow; // Assurez-vous que tickcontrolflow est déclaré ici

        public ticteccontrole()
        {
            InitializeComponent();
            tickcontrolflow = new TickControlflow(); // Initialisez l'objet ici
            Ticketbox();

        }

        public void RefreshTickets()
        {
            tickcontrolflow.Controls.Clear();
            Ticketbox();
        }

        public  void Ticketbox()
        {
            DataTable ticontrol = new DataTable();
            ticontrol = datat();



            foreach (DataRow row in ticontrol.Rows)
            {
                TickControlflow flowt = new TickControlflow();
               
                {
                    flowt.label1.Text = row["TicketID"].ToString();
                    flowt.label2.Text = row["ID"].ToString();
                    flowt.label3.Text = row["Departement"].ToString();
                    flowt.label4.Text = row["N_Service"].ToString();
                    flowt.label5.Text = row["Etage"].ToString();
                    flowt.label6.Text = row["NumBureau"].ToString();
         
                }
                flowLayoutPanel1.Controls.Add(flowt);

            }
        }

        public static DataTable datat()
        {
            cnx = Program.GetConnection();
            DataTable local = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Ticket.TicketID, Employe.ID, Employe.Departement, Employe.N_Service, Employe.Etage, Employe.NUMBureau FROM Ticket INNER JOIN  Employe ON Ticket.EmployeID = Employe.ID;\r\n", cnx);
            adapter.Fill(local);
            return local;
        }



        private void ticteccontrole_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ticteccontrole_Load_1(object sender, EventArgs e)
        {

        }
    }
}



































