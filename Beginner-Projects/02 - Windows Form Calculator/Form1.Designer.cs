namespace _02___Windows_Form_Calculator
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
            btnClear = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnSubtraction = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAddition = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            btnModulus = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(24, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(276, 62);
            txtDisplay.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(24, 79);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(64, 45);
            btnClear.TabIndex = 1;
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(236, 80);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(64, 44);
            btnMultiply.TabIndex = 3;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperation_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(166, 80);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(64, 44);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperation_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(24, 130);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 40);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(166, 130);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 40);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(96, 130);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 40);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Location = new Point(236, 130);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(64, 40);
            btnSubtraction.TabIndex = 9;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = true;
            btnSubtraction.Click += btnOperation_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(166, 176);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 40);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(96, 176);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 40);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(24, 176);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 40);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_Click;
            // 
            // btnAddition
            // 
            btnAddition.Location = new Point(236, 176);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(64, 66);
            btnAddition.TabIndex = 13;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.MouseCaptureChanged += btnOperation_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(166, 222);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 40);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(96, 222);
            btn2.Name = "btn2";
            btn2.Size = new Size(64, 40);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(24, 222);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 40);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(24, 268);
            btn0.Name = "btn0";
            btn0.Size = new Size(136, 40);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(166, 268);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(64, 40);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btn_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(236, 248);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(64, 60);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnModulus
            // 
            btnModulus.Location = new Point(94, 80);
            btnModulus.Name = "btnModulus";
            btnModulus.Size = new Size(66, 44);
            btnModulus.TabIndex = 20;
            btnModulus.Text = "%";
            btnModulus.UseVisualStyleBackColor = true;
            btnModulus.Click += btnOperation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModulus);
            Controls.Add(btnEquals);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnAddition);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnSubtraction);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnClear);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnClear;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btnSubtraction;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAddition;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEquals;
        private Button btnModulus;
    }
}
