using Helpdesk.AdminUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk
{
    public partial class AdminForm : Form
    {
        UserControlAdminEmploye Ae = new UserControlAdminEmploye();
        UserControlAdminTech At = new UserControlAdminTech();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btndash_Click(object sender, EventArgs e)
        {
            btnemploye.BackColor = ColorTranslator.FromHtml("#004AAD");
            btndash.BackColor = Color.Black;
            btntechnicien.BackColor = ColorTranslator.FromHtml("#004AAD");
            btnticket.BackColor = ColorTranslator.FromHtml("#004AAD");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntechnicien_Click(object sender, EventArgs e)
        {   MAINpanel.Controls.Clear();
            MAINpanel.Controls.Add(At);
            btnemploye.BackColor = ColorTranslator.FromHtml("#004AAD");
            btndash.BackColor = ColorTranslator.FromHtml("#004AAD");
            btntechnicien.BackColor = Color.Black;
            btnticket.BackColor = ColorTranslator.FromHtml("#004AAD");

        }

        private void btnemploye_Click(object sender, EventArgs e)
        {
            MAINpanel.Controls.Clear();
            MAINpanel.Controls.Add(Ae);
            btnemploye.BackColor = Color.Black;
            btndash.BackColor = ColorTranslator.FromHtml("#004AAD");
            btntechnicien.BackColor = ColorTranslator.FromHtml("#004AAD");
            btnticket.BackColor = ColorTranslator.FromHtml("#004AAD");
        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            btnemploye.BackColor = ColorTranslator.FromHtml("#004AAD");
            btndash.BackColor = ColorTranslator.FromHtml("#004AAD");
            btntechnicien.BackColor = ColorTranslator.FromHtml("#004AAD");
            btnticket.BackColor = Color.Black;
        }
    }
}
