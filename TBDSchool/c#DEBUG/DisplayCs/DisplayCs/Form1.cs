using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayCs
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }



        public void Attach(TextBox textBox)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (buttonText == "Enter")
            {
                inputTxtBox.AppendText(Environment.NewLine);
            }
            else if (buttonText == "Space")
            {
                inputTxtBox.AppendText(" ");
            }
            else if (buttonText == "Backspace")
            {
                if (inputTxtBox.Text.Length > 0)
                {
                    inputTxtBox.Text = inputTxtBox.Text.Substring(0, inputTxtBox.Text.Length - 1);
                }
            }
            else
            {
                inputTxtBox.AppendText(buttonText);
            }
        }
    }

}
