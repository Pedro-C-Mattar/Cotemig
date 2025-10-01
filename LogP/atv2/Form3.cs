namespace Area_Quadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int lado = int.Parse(textBox1.Text);
            int resultado = 0;

            resultado = lado * lado;

            MessageBox.Show("A área do quadrado é: " + resultado);

        }
    }
}