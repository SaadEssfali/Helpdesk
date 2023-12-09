using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.UserControls
{
    public partial class UserControlCreateticket : UserControl
    {
        public UserControlCreateticket()
        {
            InitializeComponent();
        }

        private void UserControlCreateticket_Load(object sender, EventArgs e)
        {
            DataTable categoryTable = Categorie.Category();
            comboBoxCat.DataSource=categoryTable;
            comboBoxCat.DisplayMember = "Nom";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
