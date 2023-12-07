using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace Helpdesk
{
    public partial class Form1 : Form
       
    {
        public static SqlConnection cnx;
        public static DataSet ds;
        public static SqlDataAdapter adapter;
        SqlCommand cmd;
<<<<<<< HEAD
        MainForm MainForm = new MainForm();
        TechnicienForm TechnicienForm = new TechnicienForm();
=======
>>>>>>> 1371d8257de0f827aa30fa65dec7eae6476d5b81
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {    //si l'user laisse les champs vide
            if(txtUser.Text=="")
            {
                MessageBox.Show("Entrer Usename  !");
            }
            else if ( txtPass.Text == "")
            {
                MessageBox.Show("Entrer Password  !");
            }

            //a l aide de fonction
<<<<<<< HEAD
            if (IsValidEmploye(txtUser, txtPass))
            {
              
              
                MainForm.Show();
                this.Hide(); 
            }
            else if (isValidTechnicien(txtUser, txtPass))
            {
                TechnicienForm.Show();
                this.Hide();
                
            }
=======
            if (IsValidUser(txtUser, txtPass))
            {
              
                MainForm MainForm = new MainForm(); 
                MainForm.Show();
                this.Hide(); 
            }
>>>>>>> 1371d8257de0f827aa30fa65dec7eae6476d5b81
            else
            {
                
                MessageBox.Show("Invalid username ou password");
            }
        }


<<<<<<< HEAD
        public static bool IsValidEmploye(TextBox txtUser,TextBox txtPass) {
=======
        public static bool IsValidUser(TextBox txtUser,TextBox txtPass) {
>>>>>>> 1371d8257de0f827aa30fa65dec7eae6476d5b81
            cnx = Program.GetConnection();
            cnx.Open();
            int Count = 0;

            ds =new DataSet();
             adapter = new SqlDataAdapter("select * from Employe where UserName = @username and MotDePasse = @password",cnx);
            adapter.SelectCommand.Parameters.AddWithValue("@username", txtUser.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@password", txtPass.Text);
            adapter.Fill(ds, "valid");
           
            if(ds.Tables["valid"].Rows.Count > 0)
            {
                Count =1;
            }
            else { Count = 0; }
          
            
            return Count==1;


            

        }
<<<<<<< HEAD
        public static bool isValidTechnicien(TextBox txtUser,TextBox txtPass)

        {
            cnx = Program.GetConnection();
            cnx.Open();
            int Count = 0;
            ds = new DataSet();
            adapter = new SqlDataAdapter("select * from Technicien where UserName = @username and MotDePasse = @password", cnx);
            adapter.SelectCommand.Parameters.AddWithValue("@username", txtUser.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@password", txtPass.Text);
            adapter.Fill(ds, "Technicien");

            if (ds.Tables["Technicien"].Rows.Count > 0)
            {
                Count = 1;
            }
            return Count==1;
        }
=======
>>>>>>> 1371d8257de0f827aa30fa65dec7eae6476d5b81
    }
}