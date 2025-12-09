namespace khachsan
{
    partial class xemBooking
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
            button3 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            tbAdults = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label10 = new Label();
            comboBox3 = new ComboBox();
            textBox6 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            comboBox4 = new ComboBox();
            label13 = new Label();
            comboBox5 = new ComboBox();
            textBox7 = new TextBox();
            label14 = new Label();
            textBox8 = new TextBox();
            label15 = new Label();
            textBox9 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            comboBox6 = new ComboBox();
            label19 = new Label();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label18 = new Label();
            textBox12 = new TextBox();
            label21 = new Label();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Times New Roman", 10.875F);
            button3.Location = new Point(3113, 2421);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(162, 73);
            button3.TabIndex = 2;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.875F);
            label1.Location = new Point(32, 111);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 33);
            label1.TabIndex = 4;
            label1.Text = "Room";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 10.875F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SUP", "DLX", "EXE", "APT" });
            comboBox1.Location = new Point(581, 107);
            comboBox1.Margin = new Padding(4, 2, 4, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(353, 41);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.875F);
            textBox1.Location = new Point(147, 107);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(201, 41);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.Font = new Font("Times New Roman", 10.875F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(79, 89);
            dateTimePicker1.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 24);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker2.Font = new Font("Times New Roman", 10.875F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(331, 92);
            dateTimePicker2.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(160, 24);
            dateTimePicker2.TabIndex = 8;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F);
            label2.Location = new Point(32, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 33);
            label2.TabIndex = 9;
            label2.Text = "Arrival";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.875F);
            label3.Location = new Point(258, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 33);
            label3.TabIndex = 10;
            label3.Text = "Departure";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.875F);
            label4.Location = new Point(416, 109);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 33);
            label4.TabIndex = 11;
            label4.Text = "Room Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.875F);
            label5.Location = new Point(35, 279);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 33);
            label5.TabIndex = 12;
            label5.Text = "Nights";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 10.875F);
            textBox2.Location = new Point(147, 277);
            textBox2.Margin = new Padding(4, 2, 4, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 41);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // tbAdults
            // 
            tbAdults.Font = new Font("Times New Roman", 10.875F);
            tbAdults.Location = new Point(537, 277);
            tbAdults.Margin = new Padding(4, 2, 4, 2);
            tbAdults.Name = "tbAdults";
            tbAdults.Size = new Size(65, 41);
            tbAdults.TabIndex = 14;
            tbAdults.TextChanged += D_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 10.875F);
            textBox4.Location = new Point(789, 273);
            textBox4.Margin = new Padding(4, 2, 4, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(65, 41);
            textBox4.TabIndex = 15;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.875F);
            label6.Location = new Point(35, 382);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 33);
            label6.TabIndex = 16;
            label6.Text = "Rate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.875F);
            label7.Location = new Point(440, 279);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 33);
            label7.TabIndex = 16;
            label7.Text = "Adults";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.875F);
            label8.Location = new Point(670, 277);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 33);
            label8.TabIndex = 17;
            label8.Text = "Children";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 10.875F);
            textBox5.Location = new Point(147, 378);
            textBox5.Margin = new Padding(4, 2, 4, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(359, 41);
            textBox5.TabIndex = 18;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.875F);
            label9.Location = new Point(581, 382);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(134, 33);
            label9.TabIndex = 20;
            label9.Text = "Rate Code";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 10.875F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "FO", "Sale", "Company" });
            comboBox2.Location = new Point(737, 378);
            comboBox2.Margin = new Padding(4, 2, 4, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 41);
            comboBox2.TabIndex = 19;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.875F);
            label10.Location = new Point(581, 454);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(113, 33);
            label10.TabIndex = 22;
            label10.Text = "Payment";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Times New Roman", 10.875F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Bank", "Card", "Cash", "Công nợ" });
            comboBox3.Location = new Point(737, 454);
            comboBox3.Margin = new Padding(4, 2, 4, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(242, 41);
            comboBox3.TabIndex = 21;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Times New Roman", 10.875F);
            textBox6.Location = new Point(147, 578);
            textBox6.Margin = new Padding(4, 2, 4, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(834, 41);
            textBox6.TabIndex = 24;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.875F);
            label11.ForeColor = Color.Blue;
            label11.Location = new Point(32, 578);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(75, 33);
            label11.TabIndex = 23;
            label11.Text = "Code";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.875F);
            label12.Location = new Point(32, 734);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(93, 33);
            label12.TabIndex = 28;
            label12.Text = "Source";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Times New Roman", 10.875F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "FO", "Sale", "comporate", "Facebook" });
            comboBox4.Location = new Point(147, 736);
            comboBox4.Margin = new Padding(4, 2, 4, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(242, 41);
            comboBox4.TabIndex = 27;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10.875F);
            label13.Location = new Point(32, 670);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(71, 33);
            label13.TabIndex = 26;
            label13.Text = "Type";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Times New Roman", 10.875F);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Walk-In", "Online", "Comporate", "Sale" });
            comboBox5.Location = new Point(147, 668);
            comboBox5.Margin = new Padding(4, 2, 4, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(242, 41);
            comboBox5.TabIndex = 25;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Times New Roman", 10.875F);
            textBox7.Location = new Point(704, 668);
            textBox7.Margin = new Padding(4, 2, 4, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(277, 41);
            textBox7.TabIndex = 30;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 10.875F);
            label14.Location = new Point(615, 668);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(47, 33);
            label14.TabIndex = 29;
            label14.Text = "By";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Times New Roman", 10.875F);
            textBox8.Location = new Point(704, 736);
            textBox8.Margin = new Padding(4, 2, 4, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(277, 41);
            textBox8.TabIndex = 32;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 10.875F);
            label15.Location = new Point(609, 730);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(52, 33);
            label15.TabIndex = 31;
            label15.Text = "Tel";
            label15.Click += label15_Click;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Times New Roman", 10.875F);
            textBox9.Location = new Point(704, 791);
            textBox9.Margin = new Padding(4, 2, 4, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(277, 41);
            textBox9.TabIndex = 34;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 10.875F);
            label16.Location = new Point(615, 796);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(83, 33);
            label16.TabIndex = 33;
            label16.Text = "Email";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 10.875F);
            label17.Location = new Point(677, 50);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(160, 33);
            label17.TabIndex = 36;
            label17.Text = "Comp/Agent";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Times New Roman", 10.875F);
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Agoda", "Travelloca", "Trip" });
            comboBox6.Location = new Point(780, 48);
            comboBox6.Margin = new Padding(2, 1, 2, 1);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(401, 41);
            comboBox6.TabIndex = 35;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 10.875F);
            label19.Location = new Point(677, 88);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(81, 33);
            label19.TabIndex = 37;
            label19.Text = "Guest";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Times New Roman", 10.875F);
            textBox10.Location = new Point(780, 87);
            textBox10.Margin = new Padding(2, 1, 2, 1);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(401, 41);
            textBox10.TabIndex = 38;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Times New Roman", 10.875F);
            textBox11.Location = new Point(1400, 378);
            textBox11.Margin = new Padding(4, 2, 4, 2);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(728, 384);
            textBox11.TabIndex = 40;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 10.875F);
            label18.Location = new Point(1257, 382);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(138, 33);
            label18.TabIndex = 39;
            label18.Text = "Comments";
            label18.Click += label18_Click;
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Times New Roman", 10.875F);
            textBox12.Location = new Point(1917, 1037);
            textBox12.Margin = new Padding(4, 2, 4, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(201, 41);
            textBox12.TabIndex = 43;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 10.875F);
            label21.Location = new Point(1790, 1041);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(84, 33);
            label21.TabIndex = 42;
            label21.Text = "Status";
            // 
            // button5
            // 
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(2047, 182);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 44;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // xemBooking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2475, 1198);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(textBox12);
            Controls.Add(label21);
            Controls.Add(textBox11);
            Controls.Add(label18);
            Controls.Add(textBox10);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(comboBox6);
            Controls.Add(textBox9);
            Controls.Add(label16);
            Controls.Add(textBox8);
            Controls.Add(label15);
            Controls.Add(textBox7);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(comboBox4);
            Controls.Add(label13);
            Controls.Add(comboBox5);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox3);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(tbAdults);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Margin = new Padding(4, 2, 4, 2);
            Name = "xemBooking";
            Text = "Form3";
            Load += xemBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button4;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox tbAdults;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private ComboBox comboBox2;
        private Label label10;
        private ComboBox comboBox3;
        private TextBox textBox6;
        private Label label11;
        private Label label12;
        private ComboBox comboBox4;
        private Label label13;
        private ComboBox comboBox5;
        private TextBox textBox7;
        private Label label14;
        private TextBox textBox8;
        private Label label15;
        private TextBox textBox9;
        private Label label16;
        private Label label17;
        private ComboBox comboBox6;
        private Label label19;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label18;
        private TextBox textBox12;
        private Label label21;
        private Button button5;
        private Button button2;
        private Button button1;
    }
}