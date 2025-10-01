namespace Gasolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valor = double.Parse(textBox1.Text);
            double gasolina = 5.80;
            double resultado = 0.0;

            resultado = valor / gasolina;

            MessageBox.Show("O valor a Ser Pago é: " + resultado);
         
        }
    }
}