namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double divisor = Convert.ToInt32(txtDivisor.Text);
            double dividendo = Convert.ToInt32(txtDividendo.Text);

            double resultado = divisor + dividendo;

            txtResultado.Text = resultado.ToString();
        }
    }
}