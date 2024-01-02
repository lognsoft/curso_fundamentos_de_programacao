using System.Drawing;
using System.Globalization;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {

        double somaProdutos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            double preco = Convert.ToDouble(txtPreco.Text);

            somaProdutos += preco;

            listProdutos.Items.Add(listProdutos.Items.Count+1 + "-" + produto + " - " + preco + "R$");

            lblTotalProdutos.Text = listProdutos.Items.Count.ToString();

            txtTotal.Text = somaProdutos.ToString();
        }
    }
}