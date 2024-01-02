namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        const string caracteresProibidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+-=[]{}|;':\"<>,.?/\\";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string primeiro = txtPrimeiroValor.Text;
            string segundo = txtSegundoValor.Text;
            string terceiro = txtTerceiro.Text;

            if (!validaCampo(primeiro) && !validaCampo(segundo) && !validaCampo(terceiro))
            {
                int somaTotal = Convert.ToInt32(primeiro) + Convert.ToInt32(segundo) + Convert.ToInt32(terceiro);
                MessageBox.Show("tudo ok " + somaTotal);
            }
            else
            {
                MessageBox.Show("existe um erro de caractere");
            }
        }

        public bool validaCampo(string campo)
        {
            bool erro = false;

            for (int i = 0; i < campo.Length; i++)
            {
                for (int j = 0; j < caracteresProibidos.Length; j++)
                {
                    if (campo[i] == caracteresProibidos[j])
                    {
                        erro = true;
                        break;
                    }
                }
            }

            return erro;
        }
    }
}