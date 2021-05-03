using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    


    public partial class pizzaParlour : Form
    {
        //declare global varibles 
        double pizzaPrice = 7.00;
        double numOfToppings;
        double toppingPrice = 1.25;
        double totalPrice;

        public pizzaParlour()
        {
            InitializeComponent();
        }

      

        private void inputButton_Click(object sender, EventArgs e)
        {
            //check if only numbers have been inputed 
            try
            {
                //display total price
                numOfToppings = Convert.ToDouble(inputBox.Text);
                totalPrice = pizzaPrice + toppingPrice * numOfToppings;
                outputLabel.Text = $"The price of a pizza with {numOfToppings} toppings is:\n{totalPrice.ToString("C")}";
            }
            //display message if something other than numbers have been entered 
            catch { outputLabel.Text = "please enter a number"; }

        }
    }
}
