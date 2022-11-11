using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarToBath_Project
{
    public partial class Form1 : Form
    {
        double swap = 35.97;
        bool isNum;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = Cur_textBox.Text;
            isNum = double.TryParse(input, out swap);
            this.currency.Text = (!isNum) ? "Error" : $"อัตราแลกเปลี่ยน : {swap} THB / 1 USD";
            if (isNum) 
            {
                this.dollar_textBox.Text = "1";
                this.baht_textBox.Text = $"{swap}";
            }
        }

        public void update_Data(object sender, KeyEventArgs e)
        {
            double x;
            string input = ((TextBox)sender).Text;
            isNum = double.TryParse(input, out x);

            if (!isNum) 
            {
                this.dollar_textBox.Text = "";
                this.baht_textBox.Text = "";
            }
            else if (((TextBox)sender).Name == "dollar_textBox")
            {
                this.baht_textBox.Text = (x * swap).ToString();
            }
            else if (((TextBox)sender).Name == "baht_textBox")
            {
                this.dollar_textBox.Text = (x / swap).ToString();
            }
        }
    }
}
