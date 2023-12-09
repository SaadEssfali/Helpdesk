using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk
{
    internal class Categorie
    {
        public int Categoryid;
        public string Name;
        public string Description;

        public static DataTable Category()
        {
            Form1.adapter = new SqlDataAdapter("select * from CategorieProbleme", Form1.cnx);
            Form1.adapter.Fill(Form1.ds, "Category");

            return Form1.ds.Tables["Category"];


        }

        public static int catID(ComboBox comboBox)
        {
            string nom = comboBox.SelectedItem.ToString();
            Form1.adapter = new SqlDataAdapter(" select CategorieID from CategorieProbleme WHERE Nom=@nom", Form1.cnx);
            Form1.adapter.SelectCommand.Parameters.AddWithValue("@nom", nom);
            Form1.adapter.Fill(Form1.ds, "Category");
            int catID = (int)Form1.ds.Tables["Category"].Rows[0]["CategorieID"] ;


            return catID;
        }

    }
}
