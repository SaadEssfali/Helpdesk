using Helpdesk.UserControls;
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
    public partial class Vtickets : UserControl
    {
        public static SqlConnection cnx;
        ticketflow tf = new ticketflow();
 
        public Vtickets()
        {
            InitializeComponent();
           
            



        }


        public static void Ticketpicbox(FlowLayoutPanel flowLayoutTicket)
        {

            DataTable TicketTable = new DataTable();
            TicketTable = tic();










            foreach (DataRow row in TicketTable.Rows)
            {
                ticketflow flowt = new ticketflow();

                {
                    flowt.labelid.Text = row["TicketID"].ToString();
                    flowt.label2.Text = row["ID"].ToString();
                    flowt.label3.Text = row["Departement"].ToString();
                    flowt.label4.Text = row["N_Service"].ToString();
                    flowt.label5.Text = row["Etage"].ToString();
                    flowt.label6.Text = row["NumBureau"].ToString();
                    flowt.textBox1.Text = row["Description"].ToString();





                }


                flowLayoutTicket.Controls.Add(flowt);





            }



        }

        public static DataTable tic()
        {
            cnx = Program.GetConnection();
            DataTable local = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select t.TicketID,ID,Nom,Departement,N_Service,NumBureau,Etage,Description from Ticket t  full outer join Intervention I on t.TicketID = I.TicketID inner join Employe e on t.EmployeID=e.ID where i.TicketID IS NULL", cnx);
            adapter.Fill(local);
            return local;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Vtickets_Load(object sender, EventArgs e)
        {
            Ticketpicbox(flowLayoutTicket);

        }
    }
}
