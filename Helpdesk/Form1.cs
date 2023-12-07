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
        public string Nom;
        public string Prenom;
        SqlCommand cmd;
        MainForm MainForm;
        TechnicienForm TechnicienForm = new TechnicienForm();

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
            (bool isValid, Nom,Prenom) = IsValidEmploye(txtUser, txtPass);

            if (isValid)
            {


               MainForm = new MainForm(Nom,Prenom);
                MainForm.Show();
                this.Hide(); 
            }
            else if (isValidTechnicien(txtUser, txtPass))
            {
                TechnicienForm.Show();
                this.Hide();
                
            }

            else
            {
                
                MessageBox.Show("Invalid username ou password");
            }
        }



        public static (bool,String,String) IsValidEmploye(TextBox txtUser,TextBox txtPass) {

            cnx = Program.GetConnection();
            cnx.Open();
            int Count = 0;
            string Nom, Prenom;

            ds =new DataSet();
             adapter = new SqlDataAdapter("select * from Employe where UserName = @username and MotDePasse = @password",cnx);
            adapter.SelectCommand.Parameters.AddWithValue("@username", txtUser.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@password", txtPass.Text);
            adapter.Fill(ds, "valid");
           
            if(ds.Tables["valid"].Rows.Count > 0)
            {
                Count =1;
                Nom = (string)ds.Tables["valid"].Rows[0]["Nom"];
                Prenom= (string)ds.Tables["valid"].Rows[0]["Prenom"];

            }
            else { Count = 0;
                Nom = null;
                Prenom = null;
            }

            bool isValid = Count == 1;
            return (isValid,Nom,Prenom);


            

        }

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

    }
}