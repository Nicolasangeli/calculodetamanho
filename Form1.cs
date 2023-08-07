using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaOrientacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Colega legal = new Colega();

            legal.nome = txtnome.Text;
            legal.altura = Convert.ToDouble(txtaltura.Text);
            legal.idade = Convert.ToInt32(txtidade.Text);

            legal.exibir();
        }
    }
}
