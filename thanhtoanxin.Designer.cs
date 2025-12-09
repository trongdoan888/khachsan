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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label20 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 16.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Blue;
            label20.Location = new Point(64, 71);
            label20.Name = "label20";
            label20.Size = new Size(139, 38);
            label20.TabIndex = 87;
            label20.Text = "Res. No: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.875F);
            label4.Location = new Point(64, 263);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 91;
            label4.Text = "Total Due";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Font = new Font("Times New Roman", 10.875F);
            textBox1.Location = new Point(64, 292);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Rate";
            textBox1.Size = new Size(383, 67);
            textBox1.TabIndex = 90;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.875F);
            label1.Location = new Point(659, 263);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 93;
            label1.Text = "Payment Received";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Font = new Font("Times New Roman", 10.875F);
            textBox2.Location = new Point(659, 292);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Rate";
            textBox2.Size = new Size(383, 67);
            textBox2.TabIndex = 92;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F);
            label2.Location = new Point(1180, 263);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 95;
            label2.Text = "Total remain";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Font = new Font("Times New Roman", 10.875F);
            textBox3.Location = new Point(1180, 292);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter Rate";
            textBox3.Size = new Size(383, 67);
            textBox3.TabIndex = 94;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F);
            label3.Location = new Point(64, 363);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 97;
            label3.Text = "Customer Payment";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.Font = new Font("Times New Roman", 10.875F);
            textBox4.Location = new Point(64, 393);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter Rate";
            textBox4.Size = new Size(383, 67);
            textBox4.TabIndex = 96;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGoldenrod;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button3.ForeColor = Color.DimGray;
            button3.Location = new Point(64, 817);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(154, 70);
            button3.TabIndex = 99;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGoldenrod;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = Color.DimGray;
            button2.Location = new Point(1409, 817);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(154, 70);
            button2.TabIndex = 100;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightGray;
            textBox5.Location = new Point(64, 120);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter Number";
            textBox5.Size = new Size(230, 31);
            textBox5.TabIndex = 101;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightGray;
            textBox6.Font = new Font("Times New Roman", 10.875F);
            textBox6.Location = new Point(659, 393);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Enter Name";
            textBox6.Size = new Size(383, 67);
            textBox6.TabIndex = 102;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.875F);
            label5.Location = new Point(659, 363);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 103;
            label5.Text = "Name";
            label5.Click += label5_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1703, 965);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label20);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "PAYMENT  PORTAL";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label20;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Button button3;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
    }
}