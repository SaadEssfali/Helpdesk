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
    public partial class UserControlNotification : UserControl
    {
        public UserControlNotification()
        {
            InitializeComponent();
            notiflow();
        }

        private void UserControlNotification_Load(object sender, EventArgs e)
        {

        }
        public void notiflow()
        {
           SqlConnection cnx=Program.GetConnection();
            SqlCommand cmd = new SqlCommand("select n.TicketID,MessageNotif,n.Datenotif,IsRead   from NotificationLog n Inner join Ticket t on n.TicketID=t.TicketID where  EmployeID=@EmployeID",cnx);
            cmd.Parameters.AddWithValue("@EmployeID",Employe.id);
           SqlDataAdapter adapter=new SqlDataAdapter(cmd);
            DataTable notif=new DataTable();
            adapter.Fill(notif);


            foreach (DataRow row in notif.Rows)
            {
                flowyoutmessagenotif flownotif = new flowyoutmessagenotif();    

                {
                    flownotif.txtmessagenotif.Text = row["MessageNotif"].ToString();
                    flownotif.date.Text = row["Datenotif"].ToString();
                    bool isread = (bool)row["IsRead"];
                    if (isread == false) {
                    flownotif.BackColor = Color.Gray;
                     flownotif.attention.Visible = true;
                    }
                    
                }


                flowLayoutPanel1.Controls.Add(flownotif);




            }

        }
    }
}
