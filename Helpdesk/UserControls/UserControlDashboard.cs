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
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            hourlabel.Text = DateTime.Now.ToString("HH:mm:ss");
            monthLabel.Text = DateTime.Now.ToString("MMMM");
            dayOfMonthLabel.Text = DateTime.Now.ToString("dd");
            dayOfWeekLabel.Text = DateTime.Now.ToString("dddd");
            YearLabel.Text = DateTime.Now.ToString("yyyy");
            dashID.Text=Employe.id.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {

        }

        private void hourlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourlabel.Text = DateTime.Now.ToString("HH:mm:ss");
            monthLabel.Text = DateTime.Now.ToString("MMMM");
            dayOfMonthLabel.Text = DateTime.Now.ToString("dd");
            dayOfWeekLabel.Text = DateTime.Now.ToString("dddd");
            YearLabel.Text = DateTime.Now.ToString("yyyy");
        }

        private void dayOfMonthLabel_Click(object sender, EventArgs e)
        {

        }

        private void dashID_Click(object sender, EventArgs e)
        {

        }
    }
}
