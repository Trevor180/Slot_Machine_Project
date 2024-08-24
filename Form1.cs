using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WootenT_SlotMach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method for randomizing and getting amount details
        private decimal RandomFruits(ref decimal money)
        {
            //Randomizing the fruits within the array image list
            int numberOfFruits = fruitImageList.Images.Count;

            //Randomizer
            Random rand = new Random();
            

            //numbers to compare for winnings
            int randomNumber1 = rand.Next(10);
            int randomNumber2 = rand.Next(10);
            int randomNumber3 = rand.Next(10);

            //Randomization
            for (int i = 0; i < numberOfFruits; i++)
            {
             
                //assigning fruit to boxes randomly by index of 1-9
                leftPictureBox.Image = fruitImageList.Images[randomNumber1];
                middlePictureBox.Image = fruitImageList.Images[randomNumber2];
                rightPictureBox.Image = fruitImageList.Images[randomNumber3];

            }

            // If only two match then multiply amount by 2 (on left side)
            if (randomNumber1 == randomNumber2 && randomNumber2 != randomNumber3 )
            {
                money *= 2;

                //Showing congrats
                MessageBox.Show("Congrats! You doubled your money and won $" + money + "!");

            }

            // If only two match then multiply amount by 2 (on right side)
            if (randomNumber1 != randomNumber2 && randomNumber2 == randomNumber3)
            {
                money *= 2;

                //Showing congrats
                MessageBox.Show("Congrats! You doubled your money and won $" + money + "!");

            }

            //if all three match then multiply amount by 3
            if (randomNumber1 == randomNumber2 && randomNumber2 == randomNumber3)
            {
                money *= 3;

                //Showing congrats
                MessageBox.Show("Congrats! You tripled your money and won $" + money + "!");

            }


            //if none match at all
            if (randomNumber1 != randomNumber2 && randomNumber2 != randomNumber3)
            {
                //Showing they won nothing
                money = 0m;
                MessageBox.Show("Sorry! You have $" + money);

            }

            return money;
        }

        //Making amount avaiable for the spin button AND exit button
        decimal amount;

        public void spinButton_Click(object sender, EventArgs e)
            {

            try
            {


                //Converting user amount to int
                amount = decimal.Parse(userAmountTextBox.Text);

                if (amount > 0)
                {
                    //Calling random fruits method and
                    //changing amounts
                    //Also referencing so final amount
                    //appears on exit
                    RandomFruits(ref amount);
                }
                else
                {
                    //If they enter a negative number
                    MessageBox.Show("Please enter a positive dollar amount.");

                    //Clearing out textbox
                    userAmountTextBox.Text = "";

                }



            }
            catch 
            {
                MessageBox.Show("Please enter an amount.");
            
            
            }


            }

        public void exitButton_Click(object sender, EventArgs e)
        {
            //Showing exit amount entered and new amount earned
            MessageBox.Show("Total amount entered: $" + userAmountTextBox.Text + ". Amount won: $" + amount);

            //Closing program "Can also use "ECS" or "ALT + X"
            this.Close();
            
        }

        private void middlePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
