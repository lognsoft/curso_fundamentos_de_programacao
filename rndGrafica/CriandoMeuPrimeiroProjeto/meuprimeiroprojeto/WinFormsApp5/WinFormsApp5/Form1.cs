namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool vazio = checkTextBox(textBox1.Text);

            if (vazio)
                MessageBox.Show("cadastro efetuado");
            else
                MessageBox.Show("campo vazio");
        }

        private bool checkTextBox(string textBox) {
        {
            return textBox.Trim().Length > 0;
        }
    }
}