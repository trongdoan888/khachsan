namespace khachsan
{
    partial class Form2
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
            splitContainer1 = new SplitContainer();
            button12 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button8 = new Button();
            button1 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(6, 6, 6, 6);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button12);
            splitContainer1.Panel1.Controls.Add(dateTimePicker1);
            splitContainer1.Panel1.Controls.Add(button8);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button7);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            splitContainer1.Size = new Size(2180, 1217);
            splitContainer1.SplitterDistance = 314;
            splitContainer1.SplitterWidth = 9;
            splitContainer1.TabIndex = 0;
            // 
            // button12
            // 
            button12.Location = new Point(430, 15);
            button12.Margin = new Padding(6, 6, 6, 6);
            button12.Name = "button12";
            button12.Size = new Size(301, 98);
            button12.TabIndex = 6;
            button12.Text = "New Account";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(32, 169);
            dateTimePicker1.Margin = new Padding(6, 6, 6, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(411, 56);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button8
            // 
            button8.Location = new Point(771, 15);
            button8.Margin = new Padding(6, 6, 6, 6);
            button8.Name = "button8";
            button8.Size = new Size(228, 98);
            button8.TabIndex = 1;
            button8.Text = "Log out";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(32, 15);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(340, 98);
            button1.TabIndex = 0;
            button1.Text = "New Booking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1540, 363);
            button7.Margin = new Padding(6, 6, 6, 6);
            button7.Name = "button7";
            button7.Size = new Size(511, 333);
            button7.TabIndex = 5;
            button7.Text = "203";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(867, 363);
            button6.Margin = new Padding(6, 6, 6, 6);
            button6.Name = "button6";
            button6.Size = new Size(511, 333);
            button6.TabIndex = 4;
            button6.Text = "202";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(138, 363);
            button5.Margin = new Padding(6, 6, 6, 6);
            button5.Name = "button5";
            button5.Size = new Size(511, 333);
            button5.TabIndex = 3;
            button5.Text = "201";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1540, 6);
            button4.Margin = new Padding(6, 6, 6, 6);
            button4.Name = "button4";
            button4.Size = new Size(511, 333);
            button4.TabIndex = 2;
            button4.Text = "103";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(867, 6);
            button3.Margin = new Padding(6, 6, 6, 6);
            button3.Name = "button3";
            button3.Size = new Size(511, 333);
            button3.TabIndex = 1;
            button3.Text = "102\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(132, 6);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(511, 333);
            button2.TabIndex = 0;
            button2.Text = "101";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2180, 1217);
            Controls.Add(splitContainer1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button12;
    }
}