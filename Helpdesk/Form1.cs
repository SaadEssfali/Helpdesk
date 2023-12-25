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
        public string departement, service, numtel, numbureau;
        public int etage;


        SqlCommand cmd;
        MainForm MainForm;
        TechnicienForm TechnicienForm;

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
            if (txtUser.Text == "")
            {
                MessageBox.Show("Entrer Usename  !");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Entrer Password  !");
            }

            //a l aide de fonction
         

            if (IsValidEmploye(txtUser, txtPass))
            {

                ticket.ticketfun();
                MainForm = new MainForm();
                MainForm.Show();
                this.Hide();
            }
            else if (isValidTechnicien(txtUser, txtPass))
            {
                TechnicienForm = new TechnicienForm();
                TechnicienForm.Show();
                this.Hide();

            }
            else if (txtUser.Text=="admin" && txtPass.Text=="admin")
            {
                AdminForm adminForm =new AdminForm();
                adminForm.Show();
                this.Hide();


            }

            else
            {

                MessageBox.Show("Invalid username ou password");
            }


        }



        public static bool IsValidEmploye(TextBox txtUser, TextBox txtPass)
        {

            cnx = Program.GetConnection();
            cnx.Open();
            int Count = 0;
           

            ds = new DataSet();
            adapter = new SqlDataAdapter("select * from Employe where UserName = @username and MotDePasse = @password", cnx);
            adapter.SelectCommand.Parameters.AddWithValue("@username", txtUser.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@password", txtPass.Text);
            adapter.Fill(ds, "valid");

            if (ds.Tables["valid"].Rows.Count > 0)
            {
                Count = 1;
                Employe.id= (int)ds.Tables["valid"].Rows[0]["ID"];
                Employe.nom = (string)ds.Tables["valid"].Rows[0]["Nom"];
                Employe.prenom = (string)ds.Tables["valid"].Rows[0]["Prenom"];
                Employe.departement= (string)ds.Tables["valid"].Rows[0]["Departement"];
                Employe.service= (string)ds.Tables["valid"].Rows[0]["N_Service"];
                Employe.numbureau = (string)ds.Tables["valid"].Rows[0]["NumBureau"];
                Employe.numtel= (string)ds.Tables["valid"].Rows[0]["NumTel"];
                Employe.etage= (int)ds.Tables["valid"].Rows[0]["Etage"];
               



            }


            return Count == 1;




        }
        
        public static bool isValidTechnicien(TextBox txtUser, TextBox txtPass)

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
                Classtech.ID = (int)ds.Tables["Technicien"].Rows[0]["ID"];
                Classtech.Nom = (string)ds.Tables["Technicien"].Rows[0]["Nom"];
                Classtech.Prenom = (string)ds.Tables["Technicien"].Rows[0]["Prenom"];
                Classtech.Departement = (string)ds.Tables["Technicien"].Rows[0]["Departement"];
                Classtech.Service = (string)ds.Tables["Technicien"].Rows[0]["N_Service"];
                Classtech.Nbureau = (string)ds.Tables["Technicien"].Rows[0]["NumBureau"];
                Classtech.Ntel = (string)ds.Tables["Technicien"].Rows[0]["NumTel"];
                Classtech.Specialité= (string)ds.Tables["Technicien"].Rows[0]["Specialite"];

                Count = 1;
            }
            return Count == 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}