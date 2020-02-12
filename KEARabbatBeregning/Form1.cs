using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEARabbatBeregning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variables
        double price, discount, result;

        private void Form1_Load(object sender, EventArgs e)
        {
            try // Error text if wrong input - i.e. digits#
            {
                price = Convert.ToDouble(textBoxPriceWithoutDiscount.Text); // Converts input in textbox to number

                // discount has to be between 0 and 100. Not that a discount couldnt give more than what you pay..
                if (discount > 0.0 && discount < 100.0 )
                {
                    discount = Convert.ToDouble(textBoxDiscountPercent.Text); // Converts input in textbox to number
                }
                else
                {
                    labelError.Text = "Percentage needs to be between 0 and 100."; // error
                }
                
            }
            catch
            {
                labelError.Text = "Only use numbers."; // error
            }

            result = price - discount / 100 * price; // formula for the price minus the discount
            textBoxResult.Text = Convert.ToString(result); // Converts result to at string and inputs into textbox

        }
    }
}
