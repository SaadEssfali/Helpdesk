﻿using System;
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
    }
}
