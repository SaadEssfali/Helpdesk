using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.usercontroltech
{
    public partial class techniciendash : UserControl
    {
        public techniciendash()
        {




            InitializeComponent();
            idlabel.Parent = idpicture;
            TickResLabel.Parent = TickResPicture;
            tickOuvLabel.Parent = TIckOuvPicture;
            idlabel.Text = Classtech.ID.ToString();
            idlabel.ForeColor = System.Drawing.Color.White;


            refreshinfo();
            tickOuvLabel.ForeColor = System.Drawing.Color.White;
            tickOuvLabel.Text = Classtechtick.TicketInformation().ToString();



            TickResLabel.ForeColor = System.Drawing.Color.White;





        }





        public void refreshinfo ()
        {
            tickOuvLabel.Text = Classtechtick.TicketID.ToString();
            TickResLabel.Text = Classtechtick.TicketResolue2().ToString();




        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void techniciendash_Load(object sender, EventArgs e)
        {

        }
    }
}
