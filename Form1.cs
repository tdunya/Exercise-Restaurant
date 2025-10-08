namespace Restoruant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double doner = 3.00;
        double kofte = 5.00;
        double pizza = 8.50;
        double hamburger = 7.50;
        double spagetti = 9.00;
        double lahmacun = 5.00;
        double pide = 6.00;
        double toyuq = 5.50;
        double xengel = 3.00;
        double total = 0.00;

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətiniz boşdur");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Zəhmət olmasa ödəniş məbləğini daxil edin!");
            }
            else if (Convert.ToDouble(textBox2.Text) < total)
            {
                MessageBox.Show("Zəhmət olmasa kifayət qədər məbləğ daxil edin!");
            }
            else
                textBox3.Text = (Convert.ToDouble(textBox2.Text) - total).ToString("0.00") + " AZN";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = total.ToString("0.00") + " AZN";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += toyuq;
            listBox1.Items.Add("Toyuq - " + toyuq + " AZN");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            total += doner;
            listBox1.Items.Add("Dönər - " + doner + " AZN");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            total += hamburger;
            listBox1.Items.Add("Hamburger - " + hamburger + " AZN");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            total += spagetti;
            listBox1.Items.Add("Spagetti - " + spagetti + " AZN");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            total += pizza;
            listBox1.Items.Add("Pizza - " + pizza + " AZN");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            total += xengel;
            listBox1.Items.Add("Xəngəl - " + xengel + " AZN");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            total += kofte;
            listBox1.Items.Add("Köftə - " + kofte + " AZN");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            total += lahmacun;
            listBox1.Items.Add("Lahmacun - " + lahmacun + " AZN");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            total += pide;
            listBox1.Items.Add("Pide - " + pide + " AZN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            total = 0.00;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string item = listBox1.SelectedItem.ToString();

            if (item.Contains("Dönər")) total -= doner;
            else if (item.Contains("Köftə")) total -= kofte;
            else if (item.Contains("Pizza")) total -= pizza;
            else if (item.Contains("Hamburger")) total -= hamburger;
            else if (item.Contains("Spagetti")) total -= spagetti;
            else if (item.Contains("Lahmacun")) total -= lahmacun;
            else if (item.Contains("Pide")) total -= pide;
            else if (item.Contains("Toyuq")) total -= toyuq;
            else if (item.Contains("Xəngəl")) total -= xengel;

            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            total = 0.00;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
