using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace cashRegister
{
    public partial class cashRegister : Form
    {
        double item1Price = 5;
        double item2Price = 2.5;
        double item3Price = 3;
        int item1Amount;
        int item2Amount;
        int item3Amount;
        double hst = 0.13;
        double itemsTotal;
        double tendered;
        double change;
        SoundPlayer Print = new SoundPlayer(Properties.Resources.typewriter_2);


        public cashRegister()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {

            try
            {
                subtotalLabelLeft.Visible = true;
                subtotalLabelRight.Visible = true;

                item1Amount = Convert.ToInt16(item1Box.Text);
                item2Amount = Convert.ToInt16(item2Box.Text);
                item3Amount = Convert.ToInt16(item3Box.Text);

                itemsTotal = (item1Price * item1Amount) + (item2Price * item2Amount) + (item3Price * item3Amount);


                subtotalLabelLeft.Text = $"Sub Total:";
                subtotalLabelLeft.Text += $"\n\nTax:";
                subtotalLabelLeft.Text += $"\n\nTotal:";

                subtotalLabelRight.Text = $"{itemsTotal.ToString("C")}";
                subtotalLabelRight.Text += $"\n\n{(itemsTotal * hst).ToString("C")}";
                subtotalLabelRight.Text += $"\n\n{(itemsTotal * hst + itemsTotal).ToString("C")}";
                barLabel.Visible = true;
            }
            catch
            {
                subtotalLabelLeft.Text = "whoops";
            }

        }



        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                changeBoxLeft.Visible = true;
                changeBoxRight.Visible = true;

                tendered = Convert.ToDouble(tenderedBox.Text);
                change = tendered - (itemsTotal * hst + itemsTotal);

                changeBoxLeft.Text = $"Change:";
                changeBoxRight.Text = $"{change.ToString("C")}";
            }
            catch
            {
                changeBoxLeft.Text = "Whoops";
            }
        }

        private void recieptButton_Click(object sender, EventArgs e)
        {
            receiptSideLabel.Visible = true;
            receiptLabel.Visible = true;
            receiptLabelRight.Visible = true;

            Print.Play();
            receiptLabel.Text = $"\n\nBurritos  x{item1Amount} @";
            receiptLabelRight.Text = $"\n\n{item1Price.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            Print.Play();
            receiptLabel.Text += $"\n\nTacos  x{item2Amount} @";
            receiptLabelRight.Text += $"\n\n{item2Price.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            Print.Play();
            receiptLabel.Text += $"\n\nNachos  x{item3Amount} @";
            receiptLabelRight.Text += $"\n\n{item3Price.ToString("C")}";

            Refresh();
            Thread.Sleep(1000);




            Print.Play();
            receiptLabel.Text += $"\n\n\nSubtotal:";
            receiptLabelRight.Text += $"\n\n\n{itemsTotal.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            Print.Play();
            receiptLabel.Text += $"\n\nTax:";
            receiptLabelRight.Text += $"\n\n{(itemsTotal * hst).ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            Print.Play();
            receiptLabel.Text += $"\n\nTotal:";
            receiptLabelRight.Text += $"\n\n{(itemsTotal * hst + itemsTotal).ToString("C")}";

            Refresh();
            Thread.Sleep(1000);




            Print.Play();
            receiptLabel.Text += $"\n\n\nTendered:";
            receiptLabelRight.Text += $"\n\n\n{Convert.ToDouble(tenderedBox.Text).ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            Print.Play();
            receiptLabel.Text += $"\n\nChange:";
            receiptLabelRight.Text += $"\n\n{change.ToString("C")}";

            Refresh();
            Thread.Sleep(500);




            receiptLabel.Text += $"\n";
            receiptLabelRight.Text += $"\n";

            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\n";
            receiptLabelRight.Text += $"\n";

            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\n";
            receiptLabelRight.Text += $"\n";

            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\n";
            receiptLabelRight.Text += $"\n";

            Refresh();
            Thread.Sleep(500);

            receiptLabel.Text += $"\n";
            receiptLabelRight.Text += $"\n";
            Refresh();


        }

        private void receiptLabelRight_Click(object sender, EventArgs e)
        {

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            item1Amount = 0;
            item2Amount = 0;
            item3Amount = 0;
            itemsTotal = 0;
            tendered = 0;
            change = 0;

            receiptLabel.Visible = false;
            receiptLabelRight.Visible = false;
            receiptSideLabel.Visible = false;
            subtotalLabelLeft.Visible = false;
            subtotalLabelRight.Visible = false;
            changeBoxLeft.Visible = false;
            changeBoxRight.Visible = false;
            barLabel.Visible = false;

            item1Box.Text = "0";
            item2Box.Text = "0";
            item3Box.Text = "0";
            tenderedBox.Text = "0";
        }

        private void item1Plus_Click(object sender, EventArgs e)
        {
            int itemBox1Amount = Convert.ToInt16(item1Box.Text);
            itemBox1Amount++;
            item1Box.Text = Convert.ToString(itemBox1Amount);
        }

        private void item1Minus_Click(object sender, EventArgs e)
        {
            int itemBox1Amount = Convert.ToInt16(item1Box.Text);
            itemBox1Amount--;
            item1Box.Text = Convert.ToString(itemBox1Amount);
        }

        private void item2Minus_Click(object sender, EventArgs e)
        {
            int itemBox2Amount = Convert.ToInt16(item2Box.Text);
            itemBox2Amount--;
            item2Box.Text = Convert.ToString(itemBox2Amount);
        }

        private void Item2Plus_Click(object sender, EventArgs e)
        {
            int itemBox2Amount = Convert.ToInt16(item2Box.Text);
            itemBox2Amount++;
            item2Box.Text = Convert.ToString(itemBox2Amount);
        }

        private void item3Plus_Click(object sender, EventArgs e)
        {
            int itemBox3Amount = Convert.ToInt16(item3Box.Text);
            itemBox3Amount++;
            item3Box.Text = Convert.ToString(itemBox3Amount);
        }

        private void item3Minus_Click(object sender, EventArgs e)
        {
            int itemBox3Amount = Convert.ToInt16(item3Box.Text);
            itemBox3Amount--;
            item3Box.Text = Convert.ToString(itemBox3Amount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tenderedBoxAmount = Convert.ToInt16(tenderedBox.Text);
            tenderedBoxAmount++;
            tenderedBox.Text = Convert.ToString(tenderedBoxAmount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tenderedBoxAmount = Convert.ToInt16(tenderedBox.Text);
            tenderedBoxAmount--;
            tenderedBox.Text = Convert.ToString(tenderedBoxAmount);
        }

        private void receiptSideLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
