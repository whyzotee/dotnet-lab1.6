# .Net-Lab6_DollarToBath
การเขียน DotNet สร้างโปรแกรมคำนวนค่าเงินระหว่าง บาทไทย กับ ดอลลาร์สหรัฐ และสมารถกำหนดอัตราการแลกเปลี่ยนได้

# Preview / รีวิวครับ

![6_5](https://user-images.githubusercontent.com/53619535/201413664-cd2683a8-9bc7-4b0b-b03f-2eb9a1df3943.png)
![6_2](https://user-images.githubusercontent.com/53619535/201413514-2c25e70f-8bf5-4825-9d5c-ee463517c83a.png)
![6_4](https://user-images.githubusercontent.com/53619535/201413552-8ab1611d-543f-4e59-b088-ec09a358b19a.png)

# Source Code / ซอสโค้ด
```c#
using System;
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
```
