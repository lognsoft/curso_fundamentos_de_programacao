namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtPrimeiroValor.Text);

            int valor2 = Convert.ToInt32(txtSegundoValor.Text);

            int resultado = valor1 + valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtPrimeiroValor.Text);

            int valor2 = Convert.ToInt32(txtSegundoValor.Text);

            int resultado = valor1 - valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtPrimeiroValor.Text);

            int valor2 = Convert.ToInt32(txtSegundoValor.Text);

            int resultado = valor1 * valor2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtPrimeiroValor.Text);

            int valor2 = Convert.ToInt32(txtSegundoValor.Text);

            int resultado = valor1 / valor2;

            txtResultado.Text = resultado.ToString();
        }
    }
}