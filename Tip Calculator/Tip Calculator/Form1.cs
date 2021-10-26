using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Tip_Calculator : Form
    {
        double tip = 0, amount = 0;         //initilizing the variables
        int people = 0;
        public Tip_Calculator()
        {
            InitializeComponent();
        }
        
        // function to perform decrement operation on tip_amount
        
        private void tip_decrease_Click(object sender, EventArgs e)
        {
            if (tip_amount.Text != "")      
                tip = Double.Parse(tip_amount.Text);
            else
                tip = 1;
            if (tip > 0)
            {
                tip--; 
                tip_amount.Text = tip.ToString();
            }
            else
                MessageBox.Show("Tip cannot be less than 0 %");
        }

        // function to perform increment operation on tip_amount
        private void tip_increase_Click(object sender, EventArgs e)
        {
            if (tip_amount.Text != "")
                tip = Double.Parse(tip_amount.Text);
            else
                tip = 0;
            if (tip < 100)
            {
                tip++;
                tip_amount.Text = tip.ToString();
            }
            else
                MessageBox.Show("Tip cannot exceed 100 %");
            
        }

        // function to perform decrement operation on no_of_people
        private void people_decrease_Click(object sender, EventArgs e)
        {
            if (no_of_people.Text != "")
                people = int.Parse(no_of_people.Text);
            else
                people = 2;
            if(people>1)
            {
                people--;
                no_of_people.Text = people.ToString();
            }
            else
                MessageBox.Show("Number of people cannot be 0");
        }

        // function to perform increment operation on no_of_people
        private void people_increase_Click(object sender, EventArgs e)
        {
            if (no_of_people.Text != "")
                people = int.Parse(no_of_people.Text);
            else
                people = 0;
            people++;
            no_of_people.Text = people.ToString();
        }

        //Function to check only numeric values are entered
        private void Keys(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch!=8 && ch!=46)    // check if input character is not numeric
            {                                              // 8 is key enumeration for backspace key
                                                           // 46 is key enumeration for delete key
                e.Handled = true;                           
                MessageBox.Show("Invalid Input!! Please enter numbers only");
                tip_amount.Text = "0";
                no_of_people.Text = "1";
                bill_amount.Text = "0.00";
            }
        }

        
        private void Clear_tip(object sender, EventArgs e)
        {
            if (tip_amount.Text == "0")
                tip_amount.Clear();
        }

        private void bill_clear(object sender, EventArgs e)
        {
            if (bill_amount.Text == "0.00" )
                bill_amount.Clear();
        }

        //function to caclculate the result
        private void tip_calculate(object sender, EventArgs e)
        {
            if (bill_amount.Text !="" && tip_amount.Text != "" && no_of_people.Text != "")
            {
                tip = Double.Parse(tip_amount.Text);
                people = int.Parse(no_of_people.Text);
                amount = Double.Parse(bill_amount.Text);
                Double tip_result, total;
                if (amount >= 0 && tip >= 0 && tip <= 100 && people >= 1) //Check if values are in desired range
                {
                    //calculating tip_result and total_amount per person

                    tip_result = (amount * tip) / (100 * people);
                    tip_amount_per_person.Text = "$" + Math.Round(tip_result,2).ToString();
                    total = (amount / people) + tip_result;
                    Total_amount_per_person.Text = "$" + Math.Round(total,2).ToString();
                }
                else if (people <= 0)
                {
                    MessageBox.Show("Number of people cannot be 0");
                    tip_amount_per_person.Text = " ";
                    Total_amount_per_person.Text = " ";
                }
                else if (tip < 0)
                {
                    MessageBox.Show("Tip cannot be less than 0 %");
                    tip_amount_per_person.Text = " ";
                    Total_amount_per_person.Text = " ";
                }
                else if (tip > 100)
                {
                    MessageBox.Show("Tip cannot exceed 100 %");
                    tip_amount_per_person.Text = " ";
                    Total_amount_per_person.Text = " ";
                }
                else
                {
                    MessageBox.Show("Bill Amount cannot be negative");
                    tip_amount_per_person.Text = " ";
                    Total_amount_per_person.Text = " ";
                }
            }
        }
    }
}
