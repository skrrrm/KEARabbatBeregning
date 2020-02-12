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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try // Error text if wrong input - i.e. digits#
            {
                price = Convert.ToDouble(textBoxPriceWithoutDiscount.Text); // Converts input in textbox to number
                discount = Convert.ToDouble(textBoxDiscountPercent.Text); // Converts input in textbox to number

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
