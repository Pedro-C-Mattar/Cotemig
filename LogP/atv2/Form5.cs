namespace retangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int basee = int.Parse(textBox1.Text);
            int altura = int.Parse(textBox2.Text);
            int area = 0;
            int perime = 0;

            area = basee * altura;
            perime = 2 * (basee + altura);

            MessageBox.Show("O Per�metro do Ret�ngulo �: " + perime);
            MessageBox.Show("A �rea do Ret�ngulo �: " + area);

        }
    }
}