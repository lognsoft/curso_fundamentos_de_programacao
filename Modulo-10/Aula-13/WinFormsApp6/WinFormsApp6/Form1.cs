namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox nome = Nome;
            TextBox sobrenome = SobreNome;

            bool nomeValidado = validaCampo(nome);
            bool sobrenomeValidado = validaCampo(sobrenome);

            if (nomeValidado && sobrenomeValidado)
                MessageBox.Show("cadastro efetuado com sucesso");
            else
                MessageBox.Show("Houve um erro no cadastro");
        }

        public bool validaCampo(TextBox campo)
        {
            string novoNome = "";

            for(int i = 0; i < campo.Text.Length; i++)
            {
                if (campo.Text[i] != ' ')
                {
                    novoNome += campo.Text[i];
                }
            }

            if (novoNome.Length > 0)
            {
                return verificaCaracteres(campo);
            }
            MessageBox.Show("O campo " + campo.Name + " esta vazio");
            return false;
        }

        public bool verificaCaracteres(TextBox novoNome)
        {
            string caracteresProibidos = "1!@#$%^&*(1234567890";

            for(int n = 0; n < novoNome.Text.Length; n++)
            {
                for(int c = 0; c < caracteresProibidos.Length; c++)
                {
                    if (caracteresProibidos[c] == novoNome.Text[n])
                    {
                        MessageBox.Show("O campo " + novoNome.Name + " esta com caractere invalido");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}