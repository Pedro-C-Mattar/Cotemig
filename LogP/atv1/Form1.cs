namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int resultado = 12 + 5 - 3;
            lblresult1.Text = resultado.ToString();

            int resultado2 = 12 * 3 - 4;
            lblresult2.Text = resultado2.ToString();

            int resultado3 = 12 - 4 * 3;
            lblresult3.Text = resultado3.ToString();

            int resultado4 = 12 - 3 + 5;
            lblresult4.Text = resultado4.ToString();

            int resultado5 = 15 / 3 + 2 - 8;
            lblresult5.Text = resultado5.ToString();

            int resultado6 = 2 + 15 / 3 - 4;
            lblresult6.Text = resultado6.ToString();

            int resultado7 = 12 % 3;
            lblresult7.Text = resultado7.ToString();

            int resultado8 = 17 % 5;
            lblresult8.Text = resultado8.ToString();

            int resultado9 = (124 % 5) / 2;
            lblresult9.Text = resultado9.ToString();

            int resultado10 = ((120 / 2) % 5) / 3;
            lblresult10.Text = resultado10.ToString();

            int resultado11 = 140 % 75;
            lblresult11.Text = resultado11.ToString();

        }
    }
}


