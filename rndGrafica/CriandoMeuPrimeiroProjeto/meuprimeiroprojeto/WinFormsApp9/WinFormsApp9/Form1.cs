namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            double preco = Convert.ToDouble(txtPreco.Text);

            string produtoPreco = produto + "-" + preco + "R$";

            listProdutos.Items.Add(produtoPreco);
        }
    }
}