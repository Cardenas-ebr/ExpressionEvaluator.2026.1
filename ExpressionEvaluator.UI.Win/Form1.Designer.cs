namespace ExpressionEvaluator.UI.Win
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnMultiplay = new Button();
            btnDivide = new Button();
            btnOpenParenthesis = new Button();
            btnPow = new Button();
            btnCloseParenthesis = new Button();
            btnResults = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.LightBlue;
            txtDisplay.Location = new Point(2, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(557, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.BackColor = Color.MediumPurple;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(17, 46);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 63);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.MediumPurple;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(103, 46);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 63);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.MediumPurple;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(189, 46);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 63);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.MediumPurple;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(189, 115);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 63);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.MediumPurple;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(103, 115);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 63);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.MediumPurple;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(17, 115);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 63);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.MediumPurple;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(189, 184);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 63);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.MediumPurple;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(103, 184);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 63);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.MediumPurple;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(17, 184);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 63);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.MediumPurple;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(189, 253);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(80, 63);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.MediumPurple;
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(17, 253);
            btn0.Name = "btn0";
            btn0.Size = new Size(166, 63);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(128, 255, 128);
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(361, 115);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(80, 63);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(128, 255, 128);
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(361, 46);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 63);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMultiplay
            // 
            btnMultiplay.BackColor = Color.FromArgb(128, 255, 128);
            btnMultiplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplay.Location = new Point(275, 115);
            btnMultiplay.Name = "btnMultiplay";
            btnMultiplay.Size = new Size(80, 63);
            btnMultiplay.TabIndex = 14;
            btnMultiplay.Text = "*";
            btnMultiplay.UseVisualStyleBackColor = false;
            btnMultiplay.Click += btnMultiplay_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(128, 255, 128);
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(275, 46);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(80, 63);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(128, 255, 128);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(275, 184);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(80, 63);
            btnOpenParenthesis.TabIndex = 18;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(128, 255, 128);
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPow.Location = new Point(447, 184);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(112, 63);
            btnPow.TabIndex = 17;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(128, 255, 128);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(361, 184);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(80, 63);
            btnCloseParenthesis.TabIndex = 19;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnResults
            // 
            btnResults.BackColor = Color.FromArgb(128, 255, 128);
            btnResults.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResults.Location = new Point(275, 253);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(284, 63);
            btnResults.TabIndex = 24;
            btnResults.Text = "=";
            btnResults.UseVisualStyleBackColor = false;
            btnResults.Click += btnResults_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 255, 128);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(447, 115);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 63);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 128);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(447, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 63);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(565, 321);
            Controls.Add(btnResults);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnPow);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiplay);
            Controls.Add(btnDivide);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "  ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDot;
        private Button btn0;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnMultiplay;
        private Button btnDivide;
        private Button btnOpenParenthesis;
        private Button btnPow;
        private Button btnCloseParenthesis;
        private Button btnResults;
        private Button btnClear;
        private Button btnDelete;
    }
}
