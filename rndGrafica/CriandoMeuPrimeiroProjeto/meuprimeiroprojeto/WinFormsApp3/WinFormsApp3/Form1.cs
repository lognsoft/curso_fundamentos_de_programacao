namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        int valor1;
        int valor2;
        int resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Somar(object sender, EventArgs e)
        {
          

            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicado");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }
    }
}