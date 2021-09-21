/*File Name: Project1Week4
 * Programmer: Nasi Bode
 * Problem Statement: Write a GUI program that reads in the amount of a monthly mortgage payment
 * and the outstanding balance (i.e., the amount still owed) and then outputs the amount of
 * the payment that goes to interest and the amount that goes to principal (i.e., the amount
 * that goes to reducing the debt). Assume that the annual interest payment is 6.39 percent. 
 * Use a defined constant for the interest rate. Note that payments are made monthly,
 * so the interest is only one-twelfth of the annual interest rate of 6.39 percent.
 * Overall Plan: 
 * 1. Create GUI Application
 * 2. Create textboxes for user input (monthly payment and outstanding balance)
 * 3. Create labels for user 
 * 4. Create button to calculate the results
 * 5. get input from users and convert the string values to doubles
 * 6. figure out how many years it will take to pay off mortgage
 * 7. Solve for principle using a mortgage formula (monthly payment, interest rate, and time are found)
 * 8. Calculate monthly interest rate
 * 9. Subtract monthly interest rate from monthly pay to determine the amount of the mortgage payment that goes to reducing principle
 * 10. Display results to the user
 */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1Week4
{
    public partial class Form1 : Form
    {
        public const double interestRate = 6.39 / 100;
        
            public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get double values from user input
            double monthlyPay = double.Parse(mortgagePayInput.Text);
            double outStandBalance = double.Parse(outStandPayInput.Text);

            //create amount of years it will take to pay off debt
            double n = (outStandBalance / monthlyPay);
            //original formula: monthly payment = principle * (interestRate * (1 + interestRate)^time /
            //divided by:
            // (1 + interestRate)^ time - 1
  

            //create variable to perform the exponent method
            double var1 = (1 + interestRate);
            //get value for exponent
            double variable1 = Math.Pow(var1, n);
            ;
            //solve for principle

            double principle = (monthlyPay * ((variable1) - 1)) / (interestRate * variable1);
            //calculate monthly interest rate
            double monthlyIntAmt= (principle * interestRate) / 12;
            //calculate what part of the payment reduces the principle amount
            double reducePrincipal = monthlyPay - monthlyIntAmt;

            //display results to screen
            MessageBox.Show($"Your Principle is ${Math.Round(principle, 2)}\nThe Monthly Interest Rate is: ${Math.Round(monthlyIntAmt, 2)}\nThe Amount that goes to Principle: ${Math.Round(reducePrincipal, 2)}");


        }
    }
}
