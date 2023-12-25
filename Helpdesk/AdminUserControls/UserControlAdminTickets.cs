using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.AdminUserControls
{
    public partial class UserControlAdminTickets : UserControl
    {
        public UserControlAdminTickets()
        {
            InitializeComponent();
        }

        private void UserControlAdminTickets_Load(object sender, EventArgs e)
        {

        }

        private void DateOuverture_ValueChanged(object sender, EventArgs e)
        {
            DateOuverture.CustomFormat = "dd/MM/yyyy hh:mm";
        }

        private void DateOuverture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                DateOuverture.CustomFormat = " ";
            }
        }

        private void DateCloture_ValueChanged(object sender, EventArgs e)
        {
            DateCloture.CustomFormat = "dd/MM/yyyy hh:mm";

        }

        private void DateCloture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                DateCloture.CustomFormat = " ";
            }
        }

        private void comboBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
