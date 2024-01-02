namespace Aula19
{
    public partial class Form1 : Form
    {
        double calcular;

        TextBox visor;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            visor = txtVisor;

            Button button = (Button)sender;

            visor.Text += button.Text;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calcular += Convert.ToInt32(visor.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            visor.Text = calcular.ToString();
        }
    }
}