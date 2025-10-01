namespace Cubo_de_Numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num = int.Parse(textBox1.Text);
            int resultado = 0;

            resultado = num * num * num;

            MessageBox.Show("O cubo do número é: " + resultado);

        }
    }
}