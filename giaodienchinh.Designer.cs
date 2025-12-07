namespace khachsan
{
    partial class giaodienchinh
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
            splitContainer1 = new SplitContainer();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            splitContainer2 = new SplitContainer();
            dateTimePicker1 = new DateTimePicker();
            button6 = new Button();
            button5 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint_1;
            splitContainer1.Size = new Size(810, 589);
            splitContainer1.SplitterDistance = 52;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(409, 3);
            button4.Name = "button4";
            button4.Size = new Size(122, 46);
            button4.TabIndex = 3;
            button4.Text = "Đăng xuất";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(284, 3);
            button3.Name = "button3";
            button3.Size = new Size(119, 46);
            button3.TabIndex = 2;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(139, 3);
            button2.Name = "button2";
            button2.Size = new Size(139, 46);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(130, 47);
            button1.TabIndex = 0;
            button1.Text = "New Booking";
            button1.UseVisualStyleBackColor = false;
            button1.Click += this.button1_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dateTimePicker1);
            splitContainer2.Panel1.Controls.Add(button6);
            splitContainer2.Panel1.Controls.Add(button5);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button12);
            splitContainer2.Panel2.Controls.Add(button11);
            splitContainer2.Panel2.Controls.Add(button10);
            splitContainer2.Panel2.Controls.Add(button9);
            splitContainer2.Panel2.Controls.Add(button8);
            splitContainer2.Panel2.Controls.Add(button7);
            splitContainer2.Size = new Size(810, 533);
            splitContainer2.SplitterDistance = 93;
            splitContainer2.TabIndex = 0;
            splitContainer2.SplitterMoved += splitContainer2_SplitterMoved;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(316, 28);
            button6.Name = "button6";
            button6.Size = new Size(36, 29);
            button6.TabIndex = 1;
            button6.Text = "Go";
            button6.UseVisualStyleBackColor = true;
            button6.Click += this.button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(12, 25);
            button5.Name = "button5";
            button5.Size = new Size(75, 34);
            button5.TabIndex = 0;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackColor = Color.Red;
            button12.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(539, 247);
            button12.Name = "button12";
            button12.Size = new Size(266, 152);
            button12.TabIndex = 5;
            button12.Text = "203";
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Red;
            button11.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(275, 247);
            button11.Name = "button11";
            button11.Size = new Size(266, 152);
            button11.TabIndex = 4;
            button11.Text = "202";
            button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Red;
            button10.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(12, 247);
            button10.Name = "button10";
            button10.Size = new Size(266, 152);
            button10.TabIndex = 3;
            button10.Text = "201";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(539, 44);
            button9.Name = "button9";
            button9.Size = new Size(266, 152);
            button9.TabIndex = 2;
            button9.Text = "103";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(275, 44);
            button8.Name = "button8";
            button8.Size = new Size(266, 152);
            button8.TabIndex = 1;
            button8.Text = "102";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(12, 44);
            button7.Name = "button7";
            button7.Size = new Size(266, 152);
            button7.TabIndex = 0;
            button7.Text = "101";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(32, 19);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // giaodienchinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(810, 589);
            Controls.Add(splitContainer1);
            Name = "giaodienchinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += this.giaodienchinh_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripComboBox toolStripComboBox1;
        private Button button7;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private DateTimePicker dateTimePicker1;
    }
}
