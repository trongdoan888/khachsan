namespace khachsan
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbllogin = new Label();
            lblname = new Label();
            lblaim = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnEnter = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.BackColor = Color.Transparent;
            lbllogin.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllogin.ForeColor = Color.LemonChiffon;
            lbllogin.Location = new Point(328, 139);
            lbllogin.Margin = new Padding(2, 0, 2, 0);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(566, 55);
            lbllogin.TabIndex = 1;
            lbllogin.Text = "HOTEL MANAGEMENT";
            lbllogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.Transparent;
            lblname.Font = new Font("Times New Roman", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.Khaki;
            lblname.Location = new Point(169, 50);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(873, 72);
            lblname.TabIndex = 2;
            lblname.Text = "PARKSIDE SUNLINE HOTEL";
            // 
            // lblaim
            // 
            lblaim.AutoSize = true;
            lblaim.BackColor = Color.Transparent;
            lblaim.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblaim.ForeColor = Color.Wheat;
            lblaim.Location = new Point(394, 210);
            lblaim.Margin = new Padding(2, 0, 2, 0);
            lblaim.Name = "lblaim";
            lblaim.Size = new Size(445, 43);
            lblaim.TabIndex = 3;
            lblaim.Text = "Front Office Management";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Khaki;
            lblUsername.Location = new Point(364, 512);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(154, 26);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "USERNAME ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Khaki;
            lblPassword.Location = new Point(364, 558);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 26);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "PASSWORD ";
            lblPassword.Click += lblPassword_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Khaki;
            textBox1.Location = new Point(568, 508);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your username";
            textBox1.Size = new Size(326, 30);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Khaki;
            textBox2.Location = new Point(568, 552);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your password";
            textBox2.Size = new Size(326, 32);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Khaki;
            btnEnter.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.DimGray;
            btnEnter.Location = new Point(475, 622);
            btnEnter.Margin = new Padding(2, 2, 2, 2);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(106, 31);
            btnEnter.TabIndex = 8;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Khaki;
            btnCancel.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.Location = new Point(657, 622);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 31);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1247, 637);
            Controls.Add(btnCancel);
            Controls.Add(btnEnter);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblaim);
            Controls.Add(lblname);
            Controls.Add(lbllogin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Login";
            Text = "LOGIN";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblname;
        private Label lblaim;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnEnter;
        private Button btnCancel;
    }
}

