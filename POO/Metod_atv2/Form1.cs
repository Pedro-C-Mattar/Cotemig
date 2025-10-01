namespace ConversorTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Metodos acesso = new Metodos();

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(textBox1.Text);
            double m = double.Parse(textBox2.Text);
            double s = double.Parse(textBox3.Text);
            double resul = 0;

            resul = acesso.ConvertH(h) + acesso.ConvertM(m) + s;

            MessageBox.Show("O Horario em Segundos é: " +  resul);

        }
    }
}
