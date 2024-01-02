using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCliente = textBox1.Text;

            string novonome = nomeCliente.Replace(" ", "");

            MessageBox.Show(novonome);

            //if(nomeCliente.Length > 0)
            //{
            //    MessageBox.Show(nomeCliente);
            //} else
            //{
            //    MessageBox.Show("campo precisa ser preenchido");
            //}
        }
    }
}
