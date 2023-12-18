using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.AdminUserControls
{
    public partial class UserControlAdminTech : UserControl
    {
        public static SqlConnection cnx;

        public UserControlAdminTech()
        {
            InitializeComponent();
            actualisertech(dataGridViewtech);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlAdminTech_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            inserttechinfo();
            actualisertech(dataGridViewtech);


        }
        public static void inserttechinfo()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("insert into Technicien(Nom,Prenom,UserName,MotDePasse,Departement,N_Service,NumBureau,NumTel,Specialite) values(@Nom,@Prenom,@UserName,@MotDePasse,@Departement,@N_Service,@NumBureau,@NumTel,@specialite)", cnx);
            cmd.Parameters.Add(new SqlParameter("@Nom", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("@Prenom", txtPrenom.Text));
            cmd.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text));
            cmd.Parameters.Add(new SqlParameter("@MotDePasse", txtPass.Text));
            cmd.Parameters.Add(new SqlParameter("@NumTel", txtTelephone.Text));
            cmd.Parameters.Add(new SqlParameter("@N_Service", txtService.Text));
            cmd.Parameters.Add(new SqlParameter("@Departement", txtDepartement.Text));
            cmd.Parameters.Add(new SqlParameter("@NumBureau", txtBureau.Text));
            cmd.Parameters.Add(new SqlParameter("@Specialite", txtspecialite.Text));
            cmd.ExecuteNonQuery();
        }
        public static DataTable datatech()
        {
            cnx = Program.GetConnection();
            DataTable dl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Technicien", cnx);
            adapter.Fill(dl);
            return dl;
        }
        public static DataGridView actualisertech(DataGridView datagridviewtech)
        {
            datagridviewtech.DataSource = datatech();
            return datagridviewtech;
        }
        public static void deletetech(DataGridView tech)
        {
            cnx = Program.GetConnection();

            if (tech.SelectedRows.Count >= 0)
            {
                cnx.Open();
                int id = (int)tech.SelectedRows[0].Cells["ID"].Value;
                SqlCommand cmd = new SqlCommand("delete from Intervention where TechnicienID = @id ; delete from Technicien where ID =@id", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
            }
           
           
        }
        
        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            deletetech(dataGridViewtech);
            actualisertech(dataGridViewtech);
        }

        private void btnmettreajour_Click(object sender, EventArgs e)
        {

        }
    }
}
