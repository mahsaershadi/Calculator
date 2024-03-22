namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbResult = new TextBox();
            labelShow = new Label();
            btnDivision = new Button();
            btnPoint = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnC = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnCE = new Button();
            btnSum = new Button();
            btnMinus = new Button();
            btnMultiple = new Button();
            btn0 = new Button();
            btnEquel = new Button();
            btnDelete = new Button();
            btnHistory = new Button();
            lblHistoryText = new Label();
            rtbHistory = new RichTextBox();
            btnSave = new Button();
            historyHoverTooltip = new ToolTip(components);
            historyDataGridView = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tbResult
            // 
            tbResult.Font = new Font("Segoe UI", 13.8F);
            tbResult.Location = new Point(11, 81);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(316, 41);
            tbResult.TabIndex = 16;
            tbResult.Text = "0";
            tbResult.KeyPress += tbResult_KeyPress;
            // 
            // labelShow
            // 
            labelShow.Font = new Font("Segoe UI", 10.8F);
            labelShow.ForeColor = SystemColors.ControlDarkDark;
            labelShow.Location = new Point(11, 48);
            labelShow.Name = "labelShow";
            labelShow.Size = new Size(315, 25);
            labelShow.TabIndex = 17;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDivision.Location = new Point(206, 143);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(58, 59);
            btnDivision.TabIndex = 21;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += operator_Click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPoint.Location = new Point(142, 335);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(58, 59);
            btnPoint.TabIndex = 2;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += Digit_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn1.Location = new Point(14, 271);
            btn1.Name = "btn1";
            btn1.Size = new Size(58, 59);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Digit_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn2.Location = new Point(78, 271);
            btn2.Name = "btn2";
            btn2.Size = new Size(58, 59);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Digit_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn3.Location = new Point(142, 271);
            btn3.Name = "btn3";
            btn3.Size = new Size(58, 59);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Digit_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn4.Location = new Point(14, 207);
            btn4.Name = "btn4";
            btn4.Size = new Size(58, 59);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Digit_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn5.Location = new Point(78, 207);
            btn5.Name = "btn5";
            btn5.Size = new Size(58, 59);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Digit_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn6.Location = new Point(142, 207);
            btn6.Name = "btn6";
            btn6.Size = new Size(58, 59);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Digit_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnC.Location = new Point(270, 207);
            btnC.Name = "btnC";
            btnC.Size = new Size(58, 59);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn7.Location = new Point(14, 143);
            btn7.Name = "btn7";
            btn7.Size = new Size(58, 59);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Digit_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn8.Location = new Point(78, 143);
            btn8.Name = "btn8";
            btn8.Size = new Size(58, 59);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Digit_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn9.Location = new Point(142, 143);
            btn9.Name = "btn9";
            btn9.Size = new Size(58, 59);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Digit_Click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnCE.Location = new Point(270, 143);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(58, 59);
            btnCE.TabIndex = 15;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnSum
            // 
            btnSum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSum.Location = new Point(206, 335);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(58, 59);
            btnSum.TabIndex = 18;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += operator_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMinus.Location = new Point(206, 271);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(58, 59);
            btnMinus.TabIndex = 19;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += operator_Click;
            // 
            // btnMultiple
            // 
            btnMultiple.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMultiple.Location = new Point(206, 207);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(58, 59);
            btnMultiple.TabIndex = 20;
            btnMultiple.Text = "*";
            btnMultiple.UseVisualStyleBackColor = true;
            btnMultiple.Click += operator_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn0.Location = new Point(14, 335);
            btn0.Name = "btn0";
            btn0.Size = new Size(122, 59);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Digit_Click;
            // 
            // btnEquel
            // 
            btnEquel.BackColor = SystemColors.ActiveCaption;
            btnEquel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEquel.Location = new Point(270, 271);
            btnEquel.Name = "btnEquel";
            btnEquel.Size = new Size(58, 123);
            btnEquel.TabIndex = 24;
            btnEquel.Text = "=";
            btnEquel.UseVisualStyleBackColor = false;
            btnEquel.Click += btnEquel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ScrollBar;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(694, 371);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(19, 20);
            btnDelete.TabIndex = 27;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundImage = (Image)resources.GetObject("btnHistory.BackgroundImage");
            btnHistory.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Location = new Point(296, 9);
            btnHistory.Margin = new Padding(0);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(32, 29);
            btnHistory.TabIndex = 26;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // lblHistoryText
            // 
            lblHistoryText.AutoSize = true;
            lblHistoryText.BackColor = SystemColors.ScrollBar;
            lblHistoryText.Font = new Font("Segoe UI", 10.2F);
            lblHistoryText.Location = new Point(398, 55);
            lblHistoryText.Name = "lblHistoryText";
            lblHistoryText.Size = new Size(170, 23);
            lblHistoryText.TabIndex = 28;
            lblHistoryText.Text = "there's no history yet";
            lblHistoryText.Visible = false;
            // 
            // rtbHistory
            // 
            rtbHistory.BackColor = SystemColors.ScrollBar;
            rtbHistory.BorderStyle = BorderStyle.None;
            rtbHistory.Location = new Point(398, 79);
            rtbHistory.Margin = new Padding(5);
            rtbHistory.Name = "rtbHistory";
            rtbHistory.ReadOnly = true;
            rtbHistory.Size = new Size(317, 315);
            rtbHistory.TabIndex = 29;
            rtbHistory.Text = "";
            rtbHistory.Visible = false;
            rtbHistory.SelectionChanged += rtbHistory_SelectionChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonShadow;
            btnSave.Location = new Point(402, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(51, 31);
            btnSave.TabIndex = 32;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // historyDataGridView
            // 
            historyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDataGridView.Location = new Point(397, 83);
            historyDataGridView.Name = "historyDataGridView";
            historyDataGridView.RowHeadersWidth = 51;
            historyDataGridView.Size = new Size(316, 313);
            historyDataGridView.TabIndex = 33;
            // 
            // button1
            // 
            button1.Location = new Point(563, 20);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 34;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 408);
            Controls.Add(button1);
            Controls.Add(historyDataGridView);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(lblHistoryText);
            Controls.Add(rtbHistory);
            Controls.Add(btnHistory);
            Controls.Add(btnEquel);
            Controls.Add(btn0);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiple);
            Controls.Add(btnMinus);
            Controls.Add(btnSum);
            Controls.Add(labelShow);
            Controls.Add(tbResult);
            Controls.Add(btnCE);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnC);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnPoint);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)historyDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button11;
        private Button button12;
        private TextBox tbResult;
        private Label labelShow;
        private Button btnDivision;
        private Button btnPoint;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnC;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnCE;
        private Button btnSum;
        private Button btnMinus;
        private Button btnMultiple;
        private Button btn0;
        private Button btnEquel;
        private Button btnHistory;
        private Button btnDelete;
        private Label lblHistoryText;
        private RichTextBox rtbHistory;
        private Button btnSave;
        private ToolTip historyHoverTooltip;
        private DataGridView historyDataGridView;
        private Button button1;
    }
}