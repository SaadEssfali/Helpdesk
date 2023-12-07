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
            if (txtUser.Text == "")
            {
                MessageBox.Show("Entrer Usename  !");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Entrer Password  !");
            }

            //a l aide de fonction
            (bool isValid,Employe.id, Employe.nom, Employe.prenom, Employe.departement, Employe.service, Employe.numbureau, Employe.numtel, Employe.etage) = IsValidEmploye(txtUser, txtPass);

            if (isValid)
            {
                adapter = new SqlDataAdapter("select * from Ticket t Inner join Employe e on t.EmployeID=e.ID where UserName = @username and MotDePasse = @password order by DateOuverture DESC ", cnx);
                adapter.SelectCommand.Parameters.AddWithValue("@username", txtUser.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@password", txtPass.Text);
                adapter.Fill(ds, "ticket");
                ticket.TicketID = (int)ds.Tables["ticket"].Rows[0]["TicketID"];
                ticket.Statut=(string)ds.Tables["ticket"].Rows[0]["statut"];


                MainForm = new MainForm();
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



        public static (bool,int, String, String, String, String, String, String, int) IsValidEmploye(TextBox txtUser, TextBox txtPass)
        {

            cnx = Program.GetConnection();
            cnx.Open();
            int Count = 0;
            string Nom, Prenom, departement, service, numbureau, numtel;
            int id,etage;

            ds = new DataSet();
            adapter = new SqlDataAdapter("select * from Employe where UserName = @username and MotDePasse = @password", cnx);
            adapter.SelectCommand.Parameters.AddWithValue("@username", txtUser.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@password", txtPass.Text);
            adapter.Fill(ds, "valid");

            if (ds.Tables["valid"].Rows.Count > 0)
            {
                Count = 1;
                id= (int)ds.Tables["valid"].Rows[0]["ID"];
                Nom = (string)ds.Tables["valid"].Rows[0]["Nom"];
                Prenom = (string)ds.Tables["valid"].Rows[0]["Prenom"];
                departement = (string)ds.Tables["valid"].Rows[0]["Departement"];
                service = (string)ds.Tables["valid"].Rows[0]["N_Service"];
                numbureau = (string)ds.Tables["valid"].Rows[0]["NumBureau"];
                numtel = (string)ds.Tables["valid"].Rows[0]["NumTel"];
                etage = (int)ds.Tables["valid"].Rows[0]["Etage"];
               



            }
            else
            {
                Count = 0;
                Nom = null;
                Prenom = null;
                departement = null;
                service = null;
                numtel = null;
                numbureau = null;
                etage = 0;
                id = 0;
            }

            bool isValid = Count == 1;
            return (isValid,id, Nom, Prenom, departement, service, numbureau, numtel, etage);




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