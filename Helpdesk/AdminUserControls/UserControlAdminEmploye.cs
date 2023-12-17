using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.AdminUserControls
{
    public partial class UserControlAdminEmploye : UserControl
    {
        public static SqlConnection cnx;
        public UserControlAdminEmploye()
        {
            InitializeComponent();
            DataTable empable = dataemp();
            dataGridViewemp.DataSource = empable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlAdminEmploye_Load(object sender, EventArgs e)
        {

        }
        public static void insertempinfo()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("insert into Employe(Nom,Prenom,UserName,MotDePasse,Departement,N_Service,NumBureau,NumTel,Etage) values(@Nom,@Prenom,@UserName,@MotDePasse,@Departement,@N_Service,@NumBureau,@NumTel,@Etage)", cnx);
            cmd.Parameters.Add(new SqlParameter("@Nom", txtName.Text));
            cmd.Parameters.Add(new SqlParameter("@Prenom", txtPrenom.Text));
            cmd.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text));
            cmd.Parameters.Add(new SqlParameter("@MotDePasse", txtPass.Text));
            cmd.Parameters.Add(new SqlParameter("@NumTel", txtTelephone.Text));
            cmd.Parameters.Add(new SqlParameter("@N_Service", txtService.Text));
            cmd.Parameters.Add(new SqlParameter("@Departement", txtDepartement.Text));
            cmd.Parameters.Add(new SqlParameter("@Etage", txtEtage.Text));
            cmd.Parameters.Add(new SqlParameter("@NumBureau", txtBureau.Text));
            cmd.ExecuteNonQuery();
        }
        public static DataTable dataemp()
        {
            cnx = Program.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Employe", cnx);
            adapter.Fill(dt);
            return dt;

        }
        public static void deleterow(DataGridView dtv)
        {
            cnx = Program.GetConnection();
           
            if (dtv.SelectedRows.Count > 0)
            {
                cnx.Open();
                int id = (int)dtv.SelectedRows[0].Cells["ID"].Value;
                SqlCommand cmd = new SqlCommand("delete from Employe where ID =@id",cnx);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();

            }
        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            insertempinfo();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            deleterow(dataGridViewemp);
        }
    }
}
