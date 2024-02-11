namespace cinema_canteen_sales
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int popcorn,coke, ticket,total;
        int kasa = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, coke, ticket, total;
            popcorn = Convert.ToInt32(textBox1.Text);
            coke = Convert.ToInt32(textBox2.Text);
            ticket = Convert.ToInt32(textBox3.Text);

            total = popcorn * 20 + coke * 15 + ticket * 40;
            label10.Text = total.ToString() + " TL";

            kasa = kasa + total;
            label14.Text = kasa.ToString() + " TL";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}