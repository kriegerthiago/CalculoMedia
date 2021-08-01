using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = Convert.ToDouble(nota1.Text);
            n2 = Convert.ToDouble(nota2.Text);
            n3 = Convert.ToDouble(nota3.Text);
            media = (n1 + n2 + n3) / 3;
            txtmedia.Text = media.ToString();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            nota1.Text = "";
            nota2.Text = "";
            nota3.Text = "";
            txtmedia.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
