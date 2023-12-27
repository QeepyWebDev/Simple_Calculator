using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace New_calc
{
    public partial class Form1 : Form
    {
        private List<string> history;

        public Form1()
        {
            InitializeComponent();
            history = new List<string>();
        }

        private void btn_digit_click(object sender, EventArgs e) //tangenter 0-9 och "."
        {
            txtOutput.Text += (string)((Button)sender).Text;
        }

        private void btn_operator_click(object sender, EventArgs e) //tangenter + - / *
        {
            if (txtOutput.Text == "")
                txtOutput.Text += (string)((Button)sender).Text;

            else
                txtOutput.Text += " " + (string)((Button)sender).Text + " ";
        }

        private void btn_equals_click(object sender, EventArgs e) //tangent =
        {
            string[] text = txtOutput.Text.Split();

            if (text.Length != 3) //om användaren använder tangentbord istället för klicka i applikationen och slår fel
            {
                txtOutput.Text = "Error: Invalid input format.";
                return;
            }

            if (!double.TryParse(text[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double n1))
            {
                txtOutput.Text = $"Error: Invalid format for the first number ('{text[0]}').";
                return;
            }

            if (!double.TryParse(text[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double n2))
            {
                txtOutput.Text = $"Error: Invalid format for the second number ('{text[2]}').";
                return;
            }

            switch (text[1]) //switch sats för de olika räknesätten
            {
                case "+":
                    txtOutput.Text = (n1 + n2).ToString();
                    history.Add($"{n1} + {n2} = {txtOutput.Text}");
                    break;

                case "-":
                    txtOutput.Text = (n1 - n2).ToString();
                    history.Add($"{n1} - {n2} = {txtOutput.Text}");
                    break;

                case "*":
                    txtOutput.Text = (n1 * n2).ToString();
                    history.Add($"{n1} * {n2} = {txtOutput.Text}");
                    break;

                case "/":
                    if (n2 == 0.0)
                    {
                        txtOutput.Text = "Error: Cannot divide by zero.";
                    }
                    else
                    {
                        txtOutput.Text = (n1 / n2).ToString();
                        history.Add($"{n1} / {n2} = {txtOutput.Text}");
                    }
                    break;

                default:
                    txtOutput.Text = "Error: Invalid operator.";
                    break;
            }

            UpdateHistory(); 
        }

        private void clear_all_btn_click(object sender, EventArgs e) //raderar allting i fältet
        {
            txtOutput.Clear();
        }

        private void UpdateHistory() //funktion för att uppdatera label för historiken
        {
            lbHistory.Text = string.Join(Environment.NewLine, history);
        }

        private void clear_history_btn(object sender, EventArgs e) //raderar och uppdaterar historiken
        {
            history.Clear();
            UpdateHistory();
        }
    }
}