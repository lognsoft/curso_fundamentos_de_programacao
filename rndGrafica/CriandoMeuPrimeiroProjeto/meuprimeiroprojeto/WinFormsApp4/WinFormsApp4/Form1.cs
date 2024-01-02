namespace WinFormsApp4
{
    public partial class Form1 : Form
    {

        RadioButton Selecionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if(rb.Checked)
                Selecionado = rb;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Primeiro botao"+Selecionado.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Segundo botao"+ Selecionado.Text);
        }
    }
}