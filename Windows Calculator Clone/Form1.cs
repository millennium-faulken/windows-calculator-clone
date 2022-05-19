using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Calculator_Clone
{
    public partial class Form1 : Form
    {

        Double value = 0;
        String operation = "";
        bool operator_clicked = false;
        bool equals_clicked = false;
        String num_1, num_2;

        public Form1()
        {
            InitializeComponent();
        }

        private void num_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operator_clicked) || (equals_clicked))
            {
                result.Text = "";
                operator_clicked = false;
                equals_clicked = false;
            }
            

            Button num = (Button)sender;

            if (num.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + num.Text;
            }
            else
            {
                result.Text = result.Text + num.Text;
            }
        }


        private void operator_click(object sender, EventArgs e)
        {
            Button sign = (Button)sender;
            if(value != 0)
            {
                equals.PerformClick();
                operator_clicked = true;
                operation = sign.Text;
                equation_show.Text = value + " " + operation;
            } 
            else
            {
                operation = sign.Text;
                value = Double.Parse(result.Text);
                operator_clicked = true;
                equation_show.Text = value + " " + operation;
            }
            num_1 = equation_show.Text;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            num_2 = result.Text;
            equation_show.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString("N0");
                    break;
                case "−":
                    result.Text = (value - Double.Parse(result.Text)).ToString("N0");
                    break;
                case "×":
                    result.Text = (value * Double.Parse(result.Text)).ToString("N0");
                    break;
                case "÷":
                    result.Text = (value / Double.Parse(result.Text)).ToString("N0");
                    break;
                default:
                    break;
            }
            value = Double.Parse(result.Text);
            operation = "";

            clear_History.Visible = true;
            history_Box.AppendText(num_1 + " " + num_2 + " = " + "\n");
            history_Box.AppendText(result.Text + "\n\n");
            history_Box.SelectAll();
            history_Box.SelectionAlignment = HorizontalAlignment.Right;
            history_Box.DeselectAll();
            no_History.Text = "";
            equals_clicked = true;
            equation_show.Text = num_1 + " " + num_2 + " = " + "\n";
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            result.Text="0";
            value = 0;
            equation_show.Text="0"; 
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            }

            if (result.Text == "")
            {
                result.Text = "0";  
            }
        }

        private void clearhistory_Click(object sender, EventArgs e)
        {
            history_Box.Clear();
            if (no_History.Text == "")
            {
                no_History.Text = "There's no history yet";
            }
            clear_History.Visible = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
             switch (e.KeyChar.ToString())
             {
                 case "1":
                     one.PerformClick();
                     break;
                 case "2":
                     two.PerformClick();
                     break;
                 case "3":
                     three.PerformClick();
                     break;
                 case "4":
                     four.PerformClick();
                     break;
                 case "5":
                     five.PerformClick();
                     break;
                 case "6":
                     six.PerformClick();
                     break;
                 case "7":
                     seven.PerformClick();
                     break;
                 case "8":
                     eight.PerformClick();
                     break;
                 case "9":
                     nine.PerformClick();
                     break;
                 case "0":
                     zero.PerformClick();
                     break;
                 case ".":
                     point.PerformClick();
                     break;
                 case "+":
                     plus.PerformClick();
                     break;
                 case "-":
                     minus.PerformClick();
                     break;
                 case "*":
                     times.PerformClick();
                     break;
                 case "/":
                     divide.PerformClick();
                     break;
                 case "=":
                     equals.PerformClick();
                     break;
                 case "ENTER":
                     equals.PerformClick();
                     break;
                 default:
                     break;
             }
        }
    }
}
