namespace Self_Service
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(textBox1.Text);
            double kilo = 34.00;
            double resultado = 0.0;

            resultado = peso * kilo;

            MessageBox.Show("O valor a Ser Pago é: " + resultado);
        }
    }
}