namespace math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox5.Text);
            double result1 = Math.Pow(num,5) * Math.Pow(num,3);
            double result2 = Math.Sqrt(num);
            double result3 = Math.Pow(Math.Pow(num, 2), 3);
            double result4 = num*Math.PI;

            MessageBox.Show("Resultado 1: " + result1);
            MessageBox.Show("Resultado 2: " + result2);
            MessageBox.Show("Resultado 3: " + result3);
            MessageBox.Show("Resultado 4: " + result4);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}