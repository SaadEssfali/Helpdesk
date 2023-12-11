using System.Data.SqlClient;
using System.Data;

namespace Helpdesk
{
    internal class Categorie
    {
        public int Categoryid;
        public string Name;
        public string Description;

        public static DataTable Category()
        {
            DataTable categoryTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CategorieProbleme", Form1.cnx);
            adapter.Fill(categoryTable);
            return categoryTable;
        }

        public static int catID(ComboBox comboBox)
        {
            string nom = comboBox.GetItemText(comboBox.SelectedItem);
            SqlConnection cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT CategorieID FROM CategorieProbleme WHERE Nom = @nom", cnx);
            cmd.Parameters.AddWithValue("@nom", nom);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();

            if (result != null)
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
    }
}
