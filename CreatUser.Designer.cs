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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatUser));
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
            textBox1.Location = new Point(543, 190);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your ID";
            textBox1.Size = new Size(375, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.Location = new Point(543, 267);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your new Username";
            textBox2.Size = new Size(375, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.Location = new Point(543, 347);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter your new Password";
            textBox3.Size = new Size(375, 31);
            textBox3.TabIndex = 2;
            textBox3.UseSystemPasswordChar = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.Location = new Point(543, 418);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Confirm your Password";
            textBox4.Size = new Size(375, 31);
            textBox4.TabIndex = 3;
            textBox4.UseSystemPasswordChar = true;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblid.ForeColor = Color.DimGray;
            lblid.Location = new Point(221, 190);
            lblid.Name = "lblid";
            lblid.Size = new Size(122, 32);
            lblid.TabIndex = 4;
            lblid.Text = "Login ID";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblname.ForeColor = Color.DimGray;
            lblname.Location = new Point(221, 267);
            lblname.Name = "lblname";
            lblname.Size = new Size(133, 32);
            lblname.TabIndex = 5;
            lblname.Text = "Username";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblpass.ForeColor = Color.DimGray;
            lblpass.Location = new Point(221, 343);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(129, 32);
            lblpass.TabIndex = 6;
            lblpass.Text = "Password";
            // 
            // lblpassagain
            // 
            lblpassagain.AutoSize = true;
            lblpassagain.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            lblpassagain.ForeColor = Color.DimGray;
            lblpassagain.Location = new Point(221, 417);
            lblpassagain.Name = "lblpassagain";
            lblpassagain.Size = new Size(237, 32);
            lblpassagain.TabIndex = 7;
            lblpassagain.Text = "Confirm Password";
            lblpassagain.Click += lblpassagain_Click;
            // 
            // lblnamecreate
            // 
            lblnamecreate.AutoSize = true;
            lblnamecreate.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnamecreate.ForeColor = Color.DimGray;
            lblnamecreate.Location = new Point(331, 43);
            lblnamecreate.Name = "lblnamecreate";
            lblnamecreate.Size = new Size(446, 51);
            lblnamecreate.TabIndex = 8;
            lblnamecreate.Text = "New User Registration";
            lblnamecreate.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.PaleGoldenrod;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.Location = new Point(591, 517);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 52);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.PaleGoldenrod;
            btnEnter.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnEnter.ForeColor = Color.DimGray;
            btnEnter.Location = new Point(331, 517);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(151, 52);
            btnEnter.TabIndex = 10;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // CreatUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1159, 682);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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