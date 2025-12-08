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
            dateTimePicker1 = new DateTimePicker();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
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
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dateTimePicker1);
            splitContainer1.Panel1.Controls.Add(button11);
            splitContainer1.Panel1.Controls.Add(button10);
            splitContainer1.Panel1.Controls.Add(button9);
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
            splitContainer1.Size = new Size(859, 461);
            splitContainer1.SplitterDistance = 119;
            splitContainer1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 32);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button11
            // 
            button11.Location = new Point(479, 64);
            button11.Name = "button11";
            button11.Size = new Size(53, 46);
            button11.TabIndex = 4;
            button11.Text = "Go";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(12, 64);
            button10.Name = "button10";
            button10.Size = new Size(123, 46);
            button10.TabIndex = 3;
            button10.Text = "Refesh";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(292, 12);
            button9.Name = "button9";
            button9.Size = new Size(123, 46);
            button9.TabIndex = 2;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(155, 12);
            button8.Name = "button8";
            button8.Size = new Size(123, 46);
            button8.TabIndex = 1;
            button8.Text = "Log out";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(123, 46);
            button1.TabIndex = 0;
            button1.Text = "New ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(581, 170);
            button7.Name = "button7";
            button7.Size = new Size(275, 156);
            button7.TabIndex = 5;
            button7.Text = "Room 203";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(292, 170);
            button6.Name = "button6";
            button6.Size = new Size(275, 156);
            button6.TabIndex = 4;
            button6.Text = "Room 202";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 170);
            button5.Name = "button5";
            button5.Size = new Size(275, 156);
            button5.TabIndex = 3;
            button5.Text = "Room 201";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(581, 3);
            button4.Name = "button4";
            button4.Size = new Size(275, 156);
            button4.TabIndex = 2;
            button4.Text = "Room 103";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(292, 3);
            button3.Name = "button3";
            button3.Size = new Size(275, 156);
            button3.TabIndex = 1;
            button3.Text = "Room 102\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(275, 156);
            button2.TabIndex = 0;
            button2.Text = "Room 101";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 461);
            Controls.Add(splitContainer1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
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
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}