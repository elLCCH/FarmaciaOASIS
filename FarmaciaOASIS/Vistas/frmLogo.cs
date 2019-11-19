using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaOASIS.Vistas
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }
        int cont_transition;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont_transition = cont_transition + timer1.Interval;
            if (cont_transition == 2000)
            {
                bunifuTransition1.ShowSync(pictureBox1);
            }
            if (cont_transition == 6000)
            {
                bunifuTransition2.ShowSync(pictureBox2);
                bunifuTransition1.HideSync(pictureBox1);
            }
            if (cont_transition == 12000)
            {
                bunifuTransition3.ShowSync(pictureBox3);
                bunifuTransition2.HideSync(pictureBox2);
            }
            if (cont_transition == 18000)
            {
                bunifuTransition4.ShowSync(pictureBox4);
                bunifuTransition3.HideSync(pictureBox3);
            }
            if (cont_transition == 24000)
            {
                bunifuTransition5.ShowSync(pictureBox5);
                bunifuTransition4.HideSync(pictureBox4);
            }
            if (cont_transition == 30000)
            {
                cont_transition = 0;
            }
        }
    }
}
