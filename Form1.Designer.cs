namespace khachsan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label20 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 16.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Blue;
            label20.Location = new Point(41, 101);
            label20.Name = "label20";
            label20.Size = new Size(182, 49);
            label20.TabIndex = 87;
            label20.Text = "Res. No: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(354, 40);
            comboBox1.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.875F);
            label4.Location = new Point(41, 779);
            label4.Name = "label4";
            label4.Size = new Size(128, 33);
            label4.TabIndex = 91;
            label4.Text = "Total Due";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.875F);
            textBox1.Location = new Point(41, 830);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 41);
            textBox1.TabIndex = 90;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 10.875F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(569, 946);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(437, 41);
            comboBox2.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.875F);
            label1.Location = new Point(569, 779);
            label1.Name = "label1";
            label1.Size = new Size(226, 33);
            label1.TabIndex = 93;
            label1.Text = "Payment Received";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 10.875F);
            textBox2.Location = new Point(569, 830);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(446, 41);
            textBox2.TabIndex = 92;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F);
            label2.Location = new Point(1107, 779);
            label2.Name = "label2";
            label2.Size = new Size(117, 33);
            label2.TabIndex = 95;
            label2.Text = "Discount";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 10.875F);
            textBox3.Location = new Point(1107, 830);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(446, 41);
            textBox3.TabIndex = 94;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F);
            label3.Location = new Point(41, 895);
            label3.Name = "label3";
            label3.Size = new Size(230, 33);
            label3.TabIndex = 97;
            label3.Text = "Customer Payment";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 10.875F);
            textBox4.Location = new Point(41, 946);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(446, 41);
            textBox4.TabIndex = 96;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.875F);
            label5.Location = new Point(569, 895);
            label5.Name = "label5";
            label5.Size = new Size(228, 33);
            label5.TabIndex = 98;
            label5.Text = "Receiving Account";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Times New Roman", 10.875F);
            button3.Location = new Point(61, 1132);
            button3.Name = "button3";
            button3.Size = new Size(162, 72);
            button3.TabIndex = 99;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Times New Roman", 10.875F);
            button2.Location = new Point(2057, 1132);
            button2.Name = "button2";
            button2.Size = new Size(162, 72);
            button2.TabIndex = 100;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2316, 1261);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label20);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label20;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label5;
        private Button button3;
        private Button button2;
    }
}