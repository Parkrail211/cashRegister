﻿using System;
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

/* Parker Railton
 * ICU3U
 * Mr.T
 * 
 * This program is a cash register for a shop that sells burritos tacos and nachos. it calculates subtotal, tax, total, and change, it then displays it on a "receipt."
 * */

namespace cashRegister
{
    public partial class cashRegister : Form
    {

        // Glabal Variables

        double burritoPrice = 5;
        double tacoPrice = 2.5;
        double nachoPrice = 3;
        int burritoAmount;
        int tacoAmount;
        int nachoAmount;
        double hst = 0.13;
        double itemsTotal;
        double tendered = 0;
        double change;
        bool printing = false;

        //sets up printing sound effect

        SoundPlayer Print = new SoundPlayer(Properties.Resources.typewriter_2);


        public cashRegister()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {

            try
            {
                //shows text feild and hides error message

                subtotalLabelLeft.Visible = true;
                subtotalLabelRight.Visible = true;
                errorLabel.Visible = false;

                //takes value from text boxes

                burritoAmount = Convert.ToInt16(burritoBox.Text);
                tacoAmount = Convert.ToInt16(tacoBox.Text);
                nachoAmount = Convert.ToInt16(nachoBox.Text);

                itemsTotal = (burritoPrice * burritoAmount) + (tacoPrice * tacoAmount) + (nachoPrice * nachoAmount);

                //prints info

                subtotalLabelLeft.Text = $"Sub Total:";
                subtotalLabelLeft.Text += $"\n\nTax:";
                subtotalLabelLeft.Text += $"\n\nTotal:";

                subtotalLabelRight.Text = $"{itemsTotal.ToString("C")}";
                subtotalLabelRight.Text += $"\n\n{(itemsTotal * hst).ToString("C")}";
                subtotalLabelRight.Text += $"\n\n{(itemsTotal * hst + itemsTotal).ToString("C")}";
            }
            catch
            {
                //shows error message

                errorLabel.Visible = true;
            }

        }



        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //shows text field and hides error message

                changeBoxLeft.Visible = true;
                changeBoxRight.Visible = true;
                errorLabel.Visible = false;

                //gets value from text box

                tendered = Convert.ToDouble(tenderedBox.Text);
                change = tendered - (itemsTotal * hst + itemsTotal);

                //prints info

                changeBoxLeft.Text = $"Change:";
                changeBoxRight.Text = $"{change.ToString("C")}";
            }
            catch
            {
                //shows error message

                errorLabel.Visible = true;
            }
        }



        private void recieptButton_Click(object sender, EventArgs e)
        {


            //shows receipt box
            receiptSideLabel.Visible = true;
            receiptLabel.Visible = true;
            receiptLabelRight.Visible = true;

            //prints with sound
            Print.Play();
            receiptLabel.Text = $"\n\nBurritos  x{burritoAmount} @";
            receiptLabelRight.Text = $"\n\n{burritoPrice.ToString("C")}";
            Refresh();

            Thread.Sleep(500);
            Print.Play();
            receiptLabel.Text += $"\n\nTacos  x{tacoAmount} @";
            receiptLabelRight.Text += $"\n\n{tacoPrice.ToString("C")}";
            Refresh();

            Thread.Sleep(500);
            Print.Play();
            receiptLabel.Text += $"\n\nNachos  x{nachoAmount} @";
            receiptLabelRight.Text += $"\n\n{nachoPrice.ToString("C")}";
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
            try
            {
                receiptLabelRight.Text += $"\n\n\n{Convert.ToDouble(tenderedBox.Text).ToString("C")}";
            }
            catch
            {
                receiptLabelRight.Text += $"\n\n\n{Convert.ToDouble(tendered).ToString("C")}";
            }
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
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //resets variables
            burritoAmount = 0;
            tacoAmount = 0;
            nachoAmount = 0;
            itemsTotal = 0;
            tendered = 0;
            change = 0;

            //hides text fields and receipt box
            receiptLabel.Visible = false;
            receiptLabelRight.Visible = false;
            receiptSideLabel.Visible = false;
            subtotalLabelLeft.Visible = false;
            subtotalLabelRight.Visible = false;
            changeBoxLeft.Visible = false;
            changeBoxRight.Visible = false;


            //resets text boxes
            burritoBox.Text = "0";
            tacoBox.Text = "0";
            nachoBox.Text = "0";
            tenderedBox.Text = "0";
        }

        //plus and minus buttons for text boxes
        private void burritoPlus_Click(object sender, EventArgs e)
        {
            try
            {
                int burritoBoxAmount = Convert.ToInt16(burritoBox.Text);
                burritoBoxAmount++;
                burritoBox.Text = Convert.ToString(burritoBoxAmount);
            }
            catch
            {

            }
        }

        private void burritoMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int burritoBoxAmount = Convert.ToInt16(burritoBox.Text);
                burritoBoxAmount--;
                burritoBox.Text = Convert.ToString(burritoBoxAmount);
            }
            catch
            {

            }
        }

        private void tacoMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int tacoBoxAmount = Convert.ToInt16(tacoBox.Text);
                tacoBoxAmount--;
                tacoBox.Text = Convert.ToString(tacoBoxAmount);
            }
            catch
            {

            }
        }

        private void tacoPlus_Click(object sender, EventArgs e)
        {
            try
            {
                int tacoBoxAmount = Convert.ToInt16(tacoBox.Text);
                tacoBoxAmount++;
                tacoBox.Text = Convert.ToString(tacoBoxAmount);
            }
            catch
            {

            }
        }

        private void nachoPlus_Click(object sender, EventArgs e)
        {
            try
            {
                int nachoBoxAmount = Convert.ToInt16(nachoBox.Text);
                nachoBoxAmount++;
                nachoBox.Text = Convert.ToString(nachoBoxAmount);
            }
            catch
            {

            }
        }

        private void nachoMinus_Click(object sender, EventArgs e)
        {
            int nachoBoxAmount = Convert.ToInt16(nachoBox.Text);
            nachoBoxAmount--;
            nachoBox.Text = Convert.ToString(nachoBoxAmount);
        }

        private void tenderedPlus_Click(object sender, EventArgs e)
        {
            try
            {
                int tenderedBoxAmount = Convert.ToInt16(tenderedBox.Text);
                tenderedBoxAmount++;
                tenderedBox.Text = Convert.ToString(tenderedBoxAmount);
            }
            catch
            {

            }
        }

        private void tenderedMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int tenderedBoxAmount = Convert.ToInt16(tenderedBox.Text);
                tenderedBoxAmount--;
                tenderedBox.Text = Convert.ToString(tenderedBoxAmount);
            }
            catch
            {

            }
        }


    }
}
