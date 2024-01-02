using System.Collections;
using System.Collections.Generic;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();

        string[] vetor = new string[3];


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vetor[0] = "bruno";
            vetor[2] = "maria";

            MessageBox.Show(vetor[1] + "teste");
        }
    }
}