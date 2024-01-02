namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[] { "bruno", "bla" };

            listBox1.Items.Add(nomes[0]);
        }
    }
}