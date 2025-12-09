namespace khachsan
{
    partial class thongtinkhach
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
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox11 = new TextBox();
            label18 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            comboBox3 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.875F);
            label1.Location = new Point(37, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 33);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.875F);
            textBox1.Location = new Point(156, 81);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(726, 41);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 10.875F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Việt Nam", "Lào", "Bỉ" });
            comboBox1.Location = new Point(184, 241);
            comboBox1.Margin = new Padding(4, 2, 4, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(699, 41);
            comboBox1.TabIndex = 2;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Times New Roman", 10.875F);
            textBox11.Location = new Point(201, 604);
            textBox11.Margin = new Padding(4, 2, 4, 2);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(1802, 399);
            textBox11.TabIndex = 87;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 10.875F);
            label18.Location = new Point(41, 604);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(138, 33);
            label18.TabIndex = 86;
            label18.Text = "Comments";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 10.875F);
            textBox3.Location = new Point(156, 156);
            textBox3.Margin = new Padding(4, 2, 4, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(726, 41);
            textBox3.TabIndex = 91;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F);
            label3.Location = new Point(43, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 33);
            label3.TabIndex = 90;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.875F);
            label4.Location = new Point(43, 256);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(141, 33);
            label4.TabIndex = 92;
            label4.Text = "Nationality";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 10.875F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nam ", "Nữ" });
            comboBox2.Location = new Point(1281, 85);
            comboBox2.Margin = new Padding(4, 2, 4, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(123, 41);
            comboBox2.TabIndex = 99;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.875F);
            label8.Location = new Point(1172, 81);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 33);
            label8.TabIndex = 100;
            label8.Text = "Title";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Times New Roman", 10.875F);
            textBox7.Location = new Point(1311, 141);
            textBox7.Margin = new Padding(4, 2, 4, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(509, 41);
            textBox7.TabIndex = 104;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.875F);
            label10.Location = new Point(1172, 151);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(136, 33);
            label10.TabIndex = 103;
            label10.Text = "Phone/Fax";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.875F);
            label11.Location = new Point(1172, 233);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(160, 33);
            label11.TabIndex = 106;
            label11.Text = "Comp/Agent";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Times New Roman", 10.875F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Agoda", "Traveloka", "Trip" });
            comboBox3.Location = new Point(1339, 218);
            comboBox3.Margin = new Padding(4, 2, 4, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(509, 41);
            comboBox3.TabIndex = 105;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Times New Roman", 10.875F);
            button3.Location = new Point(1530, 1050);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(162, 73);
            button3.TabIndex = 109;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Times New Roman", 10.875F);
            button2.Location = new Point(1844, 1050);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(162, 73);
            button2.TabIndex = 108;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 10.875F);
            textBox5.Location = new Point(184, 316);
            textBox5.Margin = new Padding(4, 2, 4, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(398, 41);
            textBox5.TabIndex = 96;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.875F);
            label6.Location = new Point(43, 322);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 33);
            label6.TabIndex = 95;
            label6.Text = "Passport";
            // 
            // thongtinkhach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2180, 1217);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(comboBox3);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox11);
            Controls.Add(label18);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "thongtinkhach";
            Text = "thongtinkhach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox11;
        private Label label18;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox textBox7;
        private Label label10;
        private Label label11;
        private ComboBox comboBox3;
        private Button button3;
        private Button button2;
        private TextBox textBox5;
        private Label label6;
    }
}