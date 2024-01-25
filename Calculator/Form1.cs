using System;
using System.Data.SqlClient;

namespace Calculator;
public partial class Form1 : Form
{
    private double resultValue = 0;
    private string operationPerformed = "";
    private bool isOperationOnPerformed = false;
    private string FirstNum, SecondNum;

    public Form1()
    {
        InitializeComponent();
    }

    //user cannot add anything in the out put of the calculator
    private void tbResult_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!Char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    //for clicking on the digit
    private void Digit_Click(object sender, EventArgs e)
    {
        if (tbResult.Text.Equals("0") || isOperationOnPerformed)
        {
            tbResult.Clear();
        }

        isOperationOnPerformed = false;
        System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
        if (btn.Text.Equals("."))
        {
            if (!tbResult.Text.Contains('.'))
                tbResult.Text += btn.Text;
        }
        else
        {
            tbResult.Text += btn.Text;
        }
    }

    //for clicking on the operations
    private void operator_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.Button btn1 = (System.Windows.Forms.Button)sender;
        if (resultValue != 0)
        {
            btnEquel.PerformClick();
            operationPerformed = btn1.Text;
            labelShow.Text = resultValue + " " + operationPerformed;
            isOperationOnPerformed = true;
        }
        else
        {
            operationPerformed = btn1.Text;
            resultValue = Double.Parse(tbResult.Text);
            labelShow.Text = resultValue + " " + operationPerformed;
            isOperationOnPerformed = true;
        }

        FirstNum = labelShow.Text;
    }

    //clear buttons
    private void btnCE_Click(object sender, EventArgs e)
    {
        //tbResult.Text = "0";
        resultValue = 0;

        // Update the display to show the cleared value
        tbResult.Text = resultValue.ToString();
    }
    private void btnC_Click(object sender, EventArgs e)
    {
        tbResult.Text = "0";
        resultValue = 0;
    }

    //for equel button
    private void btnEquel_Click(object sender, EventArgs e)
    {
        SecondNum = tbResult.Text;

        switch (operationPerformed)
        {
            case "+":
                tbResult.Text = (resultValue + Double.Parse(tbResult.Text)).ToString();
                break;

            case "-":
                tbResult.Text = (resultValue - Double.Parse(tbResult.Text)).ToString();
                break;

            case "*":
                tbResult.Text = (resultValue * Double.Parse(tbResult.Text)).ToString();
                break;

            case "/":
                tbResult.Text = (resultValue / Double.Parse(tbResult.Text)).ToString();
                break;

            default:
                break;
        }
        resultValue = Double.Parse(tbResult.Text);
        labelShow.Text = string.Empty;

        //for append everything in the text box to the history part
        rtbHistory.AppendText(FirstNum + " " + SecondNum + " = " + "\n");
        rtbHistory.AppendText("\t" + tbResult.Text + "\n\n");
        lblHistoryText.Text = string.Empty;
    }

    //history section
    private void btnHistory_Click(object sender, EventArgs e)
    {
        btnDelete.Visible = !btnDelete.Visible;
        btnDelete.BringToFront();
        lblHistoryText.Visible = !lblHistoryText.Visible;
        rtbHistory.Visible = !rtbHistory.Visible;
        btnSave.Visible = !btnSave.Visible;
        btnSave.BringToFront();
    }

    //delete history
    private void btnDelete_Click(object sender, EventArgs e)
    {
        rtbHistory.Clear();
        if (string.IsNullOrWhiteSpace(lblHistoryText.Text))
        {
            lblHistoryText.Text = "there's no history yet";
        }
    }

    //saving history data in txt file
    private void btnSave_Click(object sender, EventArgs e)
    {
        string connectionString;
        SqlConnection cnn;
        connectionString = @"Data Source=.;Initial Catalog=Calculator_DB;Integrated Security=SSPI;Persist Security Info=False";
        cnn = new SqlConnection(connectionString);
        cnn.Open();
        SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[calculator_Table] (First_number, Operator, Second_number) Values ('" + float.Parse(FirstNum)+"', '" + char.Parse(operationPerformed) + "', '" + float.Parse(SecondNum) + "')", cnn);
        cmd.ExecuteNonQuery();
        
    }

    //selection feature in history section
    private void rtbHistory_SelectionChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(rtbHistory.SelectedText.Trim()))
        {
            var multilineString = rtbHistory.SelectedText.Trim();

            double result = 0;
            int lineCounter = 0;

            using (StringReader reader = new(multilineString))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains('='))
                    {
                        var operations = line.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);

                        if(operations.Length == 0)
                        {
                            continue;
                        }
                        var operation = operations[0].Trim();
                        if (operation.Contains('+'))
                        {
                            var digits = operation.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);
                            if (digits.Length != 2)
                            {
                                continue;
                            }

                            double digit1 = Double.Parse(digits[0]);
                            double digit2 = Double.Parse(digits[1]);

                            if (lineCounter == 0)
                            {
                                result = digit1 + digit2;
                            }
                            else if (result == digit1)
                            {
                                result += digit2;
                            }
                            else if (result == digit2)
                            {
                                result += digit1;
                            }
                            else
                            {
                                result = digit1 + digit2;
                            }
                        }
                        else if (operation.Contains('-'))
                        {
                            var digits = operation.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                            if (digits.Length != 2)
                            {
                                continue;
                            }

                            double digit1 = Double.Parse(digits[0]);
                            double digit2 = Double.Parse(digits[1]);

                            if (lineCounter == 0)
                            {
                                result = digit1 - digit2;
                            }
                            else if (result == digit1)
                            {
                                result -= digit2;
                            }
                            else if (result == digit2)
                            {
                                result -= digit1;
                            }
                            else
                            {
                                result = digit1 - digit2;
                            }
                        }
                        else if (operation.Contains('*'))
                        {
                            var digits = operation.Split(new string[] { "*" }, StringSplitOptions.RemoveEmptyEntries);
                            if (digits.Length != 2)
                            {
                                continue;
                            }

                            double digit1 = Double.Parse(digits[0]);
                            double digit2 = Double.Parse(digits[1]);

                            if (lineCounter == 0)
                            {
                                result = digit1 * digit2;
                            }
                            else if (result == digit1)
                            {
                                result *= digit2;
                            }
                            else if (result == digit2)
                            {
                                result *= digit1;
                            }
                            else
                            {
                                result = digit1 * digit2;
                            }
                        }
                        else if (operation.Contains('/'))
                        {
                            var digits = operation.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                            if (digits.Length != 2)
                            {
                                continue;
                            }

                            double digit1 = Double.Parse(digits[0]);
                            double digit2 = Double.Parse(digits[1]);

                            if (lineCounter == 0)
                            {
                               result = digit1 / digit2;
                            }
                            else if (result == digit1)
                            {
                                result /= digit2;
                            }
                            else if (result == digit2)
                            {
                                result /= digit1;
                            }
                            else
                            {
                                result = digit1 / digit2;
                            }
                        }
                    }
                    lineCounter++;
                }
            }

            if (result > 0)
            {
                historyHoverTooltip.Show("result is: " + result.ToString(), rtbHistory);
            }
        }
    }
}