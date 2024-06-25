namespace userRegister
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPass1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 0;
            label1.Text = "Registration form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 51);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 1;
            label2.Text = "Enter User Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(164, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 26);
            txtName.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(164, 99);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '#';
            txtPass.Size = new Size(175, 26);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 102);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "Enter Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 150);
            label4.Name = "label4";
            label4.Size = new Size(120, 19);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // txtPass1
            // 
            txtPass1.Location = new Point(164, 150);
            txtPass1.Name = "txtPass1";
            txtPass1.Size = new Size(175, 26);
            txtPass1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(68, 251);
            button1.Name = "button1";
            button1.Size = new Size(188, 35);
            button1.TabIndex = 7;
            button1.Text = "Register Now";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 198);
            button2.Name = "button2";
            button2.Size = new Size(188, 32);
            button2.TabIndex = 8;
            button2.Text = "Already have an account?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPass1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPass;
        private Label label3;
        private Label label4;
        private TextBox txtPass1;
        private Button button1;
        private Button button2;
    }
}
