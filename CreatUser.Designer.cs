namespace khachsan
{
    partial class CreatUser
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblid = new Label();
            lblname = new Label();
            lblpass = new Label();
            lblpassagain = new Label();
            lblnamecreate = new Label();
            btnCancel = new Button();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(380, 114);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your ID";
            textBox1.Size = new Size(264, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Location = new Point(380, 160);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your new Username";
            textBox2.Size = new Size(264, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Location = new Point(380, 208);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter your new Password";
            textBox3.Size = new Size(264, 23);
            textBox3.TabIndex = 2;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.Location = new Point(380, 251);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Confirm your Password";
            textBox4.Size = new Size(264, 23);
            textBox4.TabIndex = 3;
            textBox4.UseSystemPasswordChar = true;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblid.ForeColor = Color.DimGray;
            lblid.Location = new Point(155, 114);
            lblid.Margin = new Padding(2, 0, 2, 0);
            lblid.Name = "lblid";
            lblid.Size = new Size(83, 22);
            lblid.TabIndex = 4;
            lblid.Text = "Login ID";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblname.ForeColor = Color.DimGray;
            lblname.Location = new Point(155, 160);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(92, 22);
            lblname.TabIndex = 5;
            lblname.Text = "Username";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblpass.ForeColor = Color.DimGray;
            lblpass.Location = new Point(155, 206);
            lblpass.Margin = new Padding(2, 0, 2, 0);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(90, 22);
            lblpass.TabIndex = 6;
            lblpass.Text = "Password";
            // 
            // lblpassagain
            // 
            lblpassagain.AutoSize = true;
            lblpassagain.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblpassagain.ForeColor = Color.DimGray;
            lblpassagain.Location = new Point(155, 250);
            lblpassagain.Margin = new Padding(2, 0, 2, 0);
            lblpassagain.Name = "lblpassagain";
            lblpassagain.Size = new Size(163, 22);
            lblpassagain.TabIndex = 7;
            lblpassagain.Text = "Confirm Password";
            lblpassagain.Click += lblpassagain_Click;
            // 
            // lblnamecreate
            // 
            lblnamecreate.AutoSize = true;
            lblnamecreate.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnamecreate.ForeColor = Color.DimGray;
            lblnamecreate.Location = new Point(232, 26);
            lblnamecreate.Margin = new Padding(2, 0, 2, 0);
            lblnamecreate.Name = "lblnamecreate";
            lblnamecreate.Size = new Size(300, 35);
            lblnamecreate.TabIndex = 8;
            lblnamecreate.Text = "New User Registration";
            lblnamecreate.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.PaleGoldenrod;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.Location = new Point(414, 310);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 31);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.PaleGoldenrod;
            btnEnter.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnEnter.ForeColor = Color.DimGray;
            btnEnter.Location = new Point(232, 310);
            btnEnter.Margin = new Padding(2);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(106, 31);
            btnEnter.TabIndex = 10;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // CreatUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(811, 409);
            Controls.Add(btnCancel);
            Controls.Add(btnEnter);
            Controls.Add(lblnamecreate);
            Controls.Add(lblpassagain);
            Controls.Add(lblpass);
            Controls.Add(lblname);
            Controls.Add(lblid);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "CreatUser";
            Text = "CREATE USER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblid;
        private Label lblname;
        private Label lblpass;
        private Label lblpassagain;
        private Label lblnamecreate;
        private Button btnCancel;
        private Button btnEnter;
    }
}