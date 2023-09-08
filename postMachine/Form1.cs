using System.Xml.Schema;

namespace postMachine
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
        productId id = new productId();
        productName name = new productName();
        productPrice price = new productPrice();

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1 == null || textBox2 == null || textBox3 == null)
            {
                MessageBox.Show("Pls fill up the textboxes");
            }
            else
            {


                id.setproduct(Convert.ToInt32(textBox1.Text));
                name.setName(textBox2.Text);
                price.setPrice(Convert.ToDouble(textBox3.Text));
                MessageBox.Show("the product is saved");
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            int savedId = id.getindex(Convert.ToInt32(textBox4.Text));

            int idpro = id.getId(savedId);
            string namepro = name.getName(savedId);
            double pricepro = price.getPrice(savedId);



            label1.Text += idpro.ToString() + Environment.NewLine;
            label2.Text += namepro.ToString() + Environment.NewLine;
            label3.Text += pricepro.ToString() + Environment.NewLine;

            

            double total = 0.0;
            string[] priceStrings = label3.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < priceStrings.Length; i++)
            {
                double priceValue;
                if (double.TryParse(priceStrings[i], out priceValue))
                {
                    total += priceValue;
                    label4.Text = total.ToString();
                }
            }
            


        }
    }
}