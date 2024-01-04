using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Helpdesk.usercontroltech
{
    public partial class TickControlflow : UserControl
    {
        public TickControlflow()
        {
            InitializeComponent();
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;

            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;

            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        public static SqlConnection GetConnection()
        {
            string strCnx = @"server=.\SQLEXPRESS;database=helpdesk_db;Integrated Security=true";
            SqlConnection cnx = new SqlConnection(strCnx);
            return cnx;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            int idTicket = int.Parse(label1.Text);



            using (SqlConnection cnx = GetConnection())
            {
                cnx.Open();

                SqlCommand UpdateCommand = new SqlCommand($"UPDATE Intervention SET Commentaires = @Commentaires WHERE TicketID = @TicketID; " +
                                                           $"UPDATE Ticket SET Statut = @Statut WHERE TicketID = @TicketID;", cnx);

                UpdateCommand.Parameters.AddWithValue("@Commentaires", textBox1.Text);
                UpdateCommand.Parameters.AddWithValue("@Statut", comboBox1.Text);
                UpdateCommand.Parameters.AddWithValue("@TicketID", idTicket);

                // exécuter les requêtes
                UpdateCommand.ExecuteNonQuery();
            }







        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
