using System.IO;
namespace TimerAppRM
{
    public partial class Form1 : Form
    {

        decimal RunningTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }
            WelcomeLabel.Visible = true;

            timer1.Interval = 8000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            foreach (Control c in this.Controls)
            {
                c.Visible = true;
            }
            WelcomeLabel.Visible = false;
        }

        private void Order1_Click(object sender, EventArgs e)
        {
            decimal OrderTotal1 = 0.00m;

            //Apps
            if (Salad.Checked || Soup.Checked || Fries.Checked || Bread.Checked)
            {
                OrderTotal1 += 21.00m;
            }
            //Entree
            if (Steak.Checked || Ribs.Checked || Pork.Checked || Burger.Checked)
            {
                OrderTotal1 += 56.00m;
            }
            //Dessert
            if (IceCream.Checked || Pie.Checked || Brownie.Checked || Cookie.Checked)
            {
                OrderTotal1 += 16.00m;
            }

            RunningTotal = RunningTotal + OrderTotal1;

            MessageBox.Show("$" + OrderTotal1 + "Added");

        }

        private void Order2_Click(object sender, EventArgs e)
        {
            decimal OrderTotal2 = 0.00m;

            //Apps
            if (Salad.Checked || Soup.Checked || Fries.Checked || Bread.Checked)
            {
                OrderTotal2 += 21.00m;
            }
            //Entree
            if (Steak.Checked || Ribs.Checked || Pork.Checked || Burger.Checked)
            {
                OrderTotal2 += 56.00m;
            }
            //Dessert
            if (IceCream.Checked || Pie.Checked || Brownie.Checked || Cookie.Checked)
            {
                OrderTotal2 += 16.00m;
            }

            RunningTotal = RunningTotal + OrderTotal2;

            MessageBox.Show("$" + OrderTotal2 + "Added");

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal Gratuity = decimal.Multiply(RunningTotal, 0.25m);
            decimal GrandTotal = RunningTotal + Gratuity;
            
            TotalOrderTB.Text = RunningTotal.ToString();
            GratuityTB.Text = Gratuity.ToString();
            GrandTotalTB.Text = GrandTotal.ToString();

            timer2.Interval = 30000;
            timer2.Start();
        }

        private void TotalOrder_Click(object sender, EventArgs e)
        {

        }

        private void Gratuity_Click(object sender, EventArgs e)
        {

        }

        private void GrandTotal_Click(object sender, EventArgs e)
        {

        }

        private void TotalOrderTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void GratuityTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrandTotalTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppetizerGB_Enter(object sender, EventArgs e)
        {

        }

        private void EntreeGB_Enter(object sender, EventArgs e)
        {

        }

        private void DessertGB_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            Application.Exit();
        }
    }
}
