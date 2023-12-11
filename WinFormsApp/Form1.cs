namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Menu m = new Menu();
        Form2 form2 = new Form2();


        private void button1_Click(object sender, EventArgs e)
        {
            string[] Name = { "Şef Burger", "Twister Junior Menu" };
            decimal[] Price = { 3.90M, 5.50M };

            decimal total = 0;

            if (numericUpDown1.Value > 0)
            {
                m.Name = Name[0];
                m.Price = Price[0];
                total = total + m.Price * numericUpDown1.Value;

                form2.label37.Visible=true;
                form2.label37.Text = Name[0];

                form2.label6.Visible = true;
                form2.label6.Text = Price[0].ToString() + " " + "azn";

                form2.label7.Visible = true;
                form2.label7.Text = numericUpDown1.Value.ToString() + " " + "ədəd";

                form2.label5.Visible = true;
                form2.label5.Text = total.ToString() + " " + "azn";
            }
            if (numericUpDown2.Value > 0)
            {
                m.Name = Name[1];
                m.Price = Price[1];
                total = total + m.Price * numericUpDown2.Value;

                form2.label36.Visible = true;
                form2.label36.Text = Name[1];

                form2.label9.Visible = true;
                form2.label9.Text = Price[1].ToString() + " " + "azn";

                form2.label10.Visible = true;
                form2.label10.Text = numericUpDown2.Value.ToString() + " " + "ədəd";

                form2.label8.Visible = true;
                form2.label8.Text = total.ToString() + " " + "azn";
            }
            if (numericUpDown3.Value > 0)
            {
                m.Name = "Lunchbox";
                m.Price = 13.00M;
                total = total + m.Price * numericUpDown3.Value;
            }
            if (numericUpDown4.Value > 0)
            {
                m.Name = "Şef Burger Menu";
                m.Price = 6.00M;
                total = total + m.Price * numericUpDown4.Value;
            }
            if (numericUpDown5.Value > 0)
            {
                m.Name = "Cütlük qutusu";
                m.Price = 10.90M;
                total = total + m.Price * numericUpDown5.Value;
            }
            if (numericUpDown6.Value > 0)
            {
                m.Name = "Dondurma";
                m.Price = 0.50M;
                total = total + m.Price * numericUpDown6.Value;
            }
            if (numericUpDown7.Value > 0)
            {
                m.Name = "Xüsusi təklif";
                m.Price = 3.60M;
                total = total + m.Price * numericUpDown7.Value;
            }
            if (numericUpDown8.Value > 0)
            {
                m.Name = "Bud ətli Twisterlər";
                m.Price = 3.90M;
                total = total + m.Price * numericUpDown8.Value;
            }
           
            if (numericUpDown1.Value > 0 || numericUpDown2.Value > 0
                || numericUpDown3.Value > 0 || numericUpDown4.Value > 0
                || numericUpDown5.Value > 0 || numericUpDown6.Value > 0
                || numericUpDown7.Value > 0 || numericUpDown8.Value > 0)
            {
                form2.Show();
            }
            if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0
                && numericUpDown3.Value == 0 && numericUpDown4.Value == 0
                && numericUpDown5.Value == 0 && numericUpDown6.Value == 0
                && numericUpDown7.Value == 0 && numericUpDown8.Value == 0)
            {
                MessageBox.Show("Lütfən menu seçimi edin.");
            }

            form2.label29.Text = total.ToString();



        }
    }
}