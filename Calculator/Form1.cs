using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationOnPerformed = false;
        string FirstNum, SecondNum;
        public Form1()
        {
            InitializeComponent();
           // this.KeyPress += new KeyPressEventHandler(CalculatorForm_KeyPress);
        }

        private void tbResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                tbResult.Text += e.KeyChar;
            }
        }*/
        private void Digit_Click(object sender, EventArgs e)
        {
            if ((tbResult.Text == "0") || (isOperationOnPerformed))
            {
                tbResult.Clear();
            }

            isOperationOnPerformed = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!tbResult.Text.Contains("."))
                    tbResult.Text += btn.Text;
            }
            else
            {
                tbResult.Text += btn.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
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
        private void btnCE_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            resultValue = 0;
        }
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
            labelShow.Text = "";

            //for history part
            rtbHistory.AppendText(FirstNum + " " + SecondNum + " = " + "\n");
            rtbHistory.AppendText("\t" + tbResult.Text + "\n\n");
            lblHistoryText.Text = "";

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

            btnDelete.Visible = !btnDelete.Visible;
            btnDelete.BringToFront();
            lblHistoryText.Visible = !lblHistoryText.Visible;
            rtbHistory.Visible = !rtbHistory.Visible;
            btnSave.Visible = !btnSave.Visible;
            btnSave.BringToFront();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            rtbHistory.Clear();
            if (lblHistoryText.Text == "")
            {
                lblHistoryText.Text = "there's no history yet";
            }
        }

        //saving history data in txt file
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the history data to the specified text file
                string filePath = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(rtbHistory.Text);
                }
            }
        }
    }
}