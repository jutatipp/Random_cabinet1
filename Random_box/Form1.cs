using System;
using System.Net.Mime;

namespace Random_box
{
    public partial class Form1 : Form
    {
        Control controller;
        Box box = new Box();
        CSV csv = new CSV();
        public Form1()
        {
            InitializeComponent();
            controller = new Control();
        }

        int button3Numberofproducts3 = 0;


        int button1Numberofproducts1 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = box.box1;
            Box1.Image = box.box1;
            if (controller.product1 == 1)
            {
                button2.Hide();
            }
            controller.product1--;


            produck1.Text = "box 1";
            button1Numberofproducts1++;
            Numberofproducts1.Text = button1Numberofproducts1.ToString();
            box.sum += 20;
            box.products += 1;
            textsumbox.Text = box.sum.ToString();
            products6.Text = box.products.ToString();

        }
        int button2Numberofproducts2 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = box.box2;
            Box2.Image = box.box2;
            if (controller.product2 == 1)
            {
                button3.Hide();
            }
            controller.product2--;
            products6.Text = box.products.ToString();

            produck2.Text = "box 2";
            button2Numberofproducts2++;
            Numberofproducts2.Text = button2Numberofproducts2.ToString();
            box.sum += 20;
            box.products += 1;
            textsumbox.Text = box.sum.ToString();
            products6.Text = box.products.ToString();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            bool canBuy = controller.mybox3();
            if (canBuy)
            {
                Box3.Image = box.box3;
                pictureBox5.Image = box.box3;
                Box3.Image = box.box3;
            }
            if (controller.product3 == 1)
            {
                button4.Hide();
            }
            controller.product3--;

            produck3.Text = "box 3";
            button3Numberofproducts3++;
            Numberofproducts3.Text = button3Numberofproducts3.ToString();
            box.sum += 20;
            box.products += 1;
            textsumbox.Text = box.sum.ToString();
            products6.Text = box.products.ToString();
        }
        int button4Numberofproducts4 = 0;
        private void button5_Click(object sender, EventArgs e)
        {

            pictureBox5.Image = box.box4;
            Box4.Image = box.box4;
            if (controller.product4 == 1)
            {
                button5.Hide();
            }
            controller.product4--;

            produck4.Text = "box 4";
            button4Numberofproducts4++;
            Numberofproducts4.Text = button4Numberofproducts4.ToString();
            box.sum += 20;
            box.products += 1;
            textsumbox.Text = box.sum.ToString();
            products6.Text = box.products.ToString();
        }
        int button5Numberofproducts5 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = box.box5;
            Box5.Image = box.box5;
            if (controller.product5 == 1)
            {
                button6.Hide();
            }
            controller.product5--;

            produck5.Text = "box 5";
            button5Numberofproducts5++;
            Numberofproducts5.Text = button5Numberofproducts5.ToString();
            box.sum += 20;
            box.products += 1;
            textsumbox.Text = box.sum.ToString();
            products6.Text = box.products.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hider.Show();
            box.products = 0;
            box.sum = 0;

            textsumbox.Text = "";
            products6.Text = box.products.ToString();

            produck1.Text = "";
            button1Numberofproducts1 = 0;
            Numberofproducts1.Text = string.Empty;

            produck2.Text = "";
            button2Numberofproducts2 = 0;
            Numberofproducts2.Text = string.Empty;

            produck3.Text = "";
            button3Numberofproducts3 = 0;
            Numberofproducts3.Text = string.Empty;

            produck4.Text = "";
            button4Numberofproducts4 = 0;
            Numberofproducts4.Text = string.Empty;

            produck5.Text = "";
            button5Numberofproducts5 = 0;
            Numberofproducts5.Text = string.Empty;
            products6.Text = "";

            Box1.Image = null;
            Box2.Image = null;
            Box3.Image = null;
            Box4.Image = null;
            Box5.Image = null;
            pictureBox5.Image = null;

            button2.Show();
            controller.product1 = 2;
            button3.Show();
            controller.product2 = 1;
            button4.Show();
            controller.product3 = 4;
            button5.Show();
            controller.product4 = 2;
            button6.Show();
            controller.product5 = 3;
            

        }
        private void summit_Click(object sender, EventArgs e)
        {
            Hider.Hide();
            string lists = produck1.Text + " " + produck2.Text + " " + produck3.Text + " " + produck4.Text + " " + produck5.Text;
            bool canwrite = csv.FileCsv(lists, box.products, box.sum);
            if (canwrite)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }

        }

        private void Hider_Click(object sender, EventArgs e)
        {

        }
    }
}
