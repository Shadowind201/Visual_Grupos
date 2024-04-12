using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Grupos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            animefoto1.Visible = true;
            anime1.Visible = true;
            animefoto2.Visible = true;
            anime2.Visible = true;
            animefoto3.Visible = true;
            anime3.Visible = true;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            jogofoto1.Visible = true;
            jogo1.Visible = true;
            jogofoto2.Visible = true;
            jogo2.Visible = true;
            jogofoto3.Visible = true;
            jogo3.Visible = true;

        }
    }
}
