namespace WinFormsApp1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeDigitado = txtNome.Text;

            MessageBox.Show("O nome digitado foi "+nomeDigitado);
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}