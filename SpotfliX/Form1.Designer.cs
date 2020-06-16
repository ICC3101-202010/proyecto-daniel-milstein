namespace SpotfliX
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
            this.panelInicio = new System.Windows.Forms.Panel();
            this.GoToRegButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UsernameLAbel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.RegErrorLabel = new System.Windows.Forms.Label();
            this.EmailSame2Label = new System.Windows.Forms.Label();
            this.EmailSameLabel = new System.Windows.Forms.Label();
            this.SamePass2Label = new System.Windows.Forms.Label();
            this.SamePassLabel = new System.Windows.Forms.Label();
            this.UserAvailableLabel = new System.Windows.Forms.Label();
            this.PremiumCheck = new System.Windows.Forms.CheckBox();
            this.PremiumLabel = new System.Windows.Forms.Label();
            this.BackRegButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PvtRegCheck = new System.Windows.Forms.CheckBox();
            this.PassRegBox = new System.Windows.Forms.TextBox();
            this.Pass2RegBox = new System.Windows.Forms.TextBox();
            this.Email2RegBox = new System.Windows.Forms.TextBox();
            this.EmailRegBox = new System.Windows.Forms.TextBox();
            this.UserRegBox = new System.Windows.Forms.TextBox();
            this.PasswordRegLabel = new System.Windows.Forms.Label();
            this.Password2RegLabel = new System.Windows.Forms.Label();
            this.EmailRegLabel = new System.Windows.Forms.Label();
            this.Email2RegLabel = new System.Windows.Forms.Label();
            this.PvtRegLabel = new System.Windows.Forms.Label();
            this.UserRegLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.Black;
            this.panelInicio.Controls.Add(this.GoToRegButton);
            this.panelInicio.Controls.Add(this.SignInButton);
            this.panelInicio.Controls.Add(this.PassBox);
            this.panelInicio.Controls.Add(this.UserBox);
            this.panelInicio.Controls.Add(this.PassLabel);
            this.panelInicio.Controls.Add(this.UsernameLAbel);
            this.panelInicio.Location = new System.Drawing.Point(251, 138);
            this.panelInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(531, 525);
            this.panelInicio.TabIndex = 0;
            // 
            // GoToRegButton
            // 
            this.GoToRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GoToRegButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToRegButton.Location = new System.Drawing.Point(112, 300);
            this.GoToRegButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoToRegButton.Name = "GoToRegButton";
            this.GoToRegButton.Size = new System.Drawing.Size(147, 62);
            this.GoToRegButton.TabIndex = 5;
            this.GoToRegButton.Text = "Register";
            this.GoToRegButton.UseVisualStyleBackColor = true;
            this.GoToRegButton.Click += new System.EventHandler(this.GoToRegButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SignInButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(321, 300);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(112, 62);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(321, 240);
            this.PassBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '•';
            this.PassBox.Size = new System.Drawing.Size(112, 26);
            this.PassBox.TabIndex = 3;
            this.PassBox.Text = "admin";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(321, 191);
            this.UserBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserBox.Multiline = true;
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(112, 26);
            this.UserBox.TabIndex = 2;
            this.UserBox.Text = "admin";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassLabel.Location = new System.Drawing.Point(107, 231);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(111, 29);
            this.PassLabel.TabIndex = 1;
            this.PassLabel.Text = "Password";
            // 
            // UsernameLAbel
            // 
            this.UsernameLAbel.AutoSize = true;
            this.UsernameLAbel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLAbel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLAbel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLAbel.Location = new System.Drawing.Point(107, 182);
            this.UsernameLAbel.Name = "UsernameLAbel";
            this.UsernameLAbel.Size = new System.Drawing.Size(117, 29);
            this.UsernameLAbel.TabIndex = 0;
            this.UsernameLAbel.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1127, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.Black;
            this.panelRegister.Controls.Add(this.RegErrorLabel);
            this.panelRegister.Controls.Add(this.EmailSame2Label);
            this.panelRegister.Controls.Add(this.EmailSameLabel);
            this.panelRegister.Controls.Add(this.SamePass2Label);
            this.panelRegister.Controls.Add(this.SamePassLabel);
            this.panelRegister.Controls.Add(this.UserAvailableLabel);
            this.panelRegister.Controls.Add(this.PremiumCheck);
            this.panelRegister.Controls.Add(this.PremiumLabel);
            this.panelRegister.Controls.Add(this.BackRegButton);
            this.panelRegister.Controls.Add(this.RegisterButton);
            this.panelRegister.Controls.Add(this.PvtRegCheck);
            this.panelRegister.Controls.Add(this.PassRegBox);
            this.panelRegister.Controls.Add(this.Pass2RegBox);
            this.panelRegister.Controls.Add(this.Email2RegBox);
            this.panelRegister.Controls.Add(this.EmailRegBox);
            this.panelRegister.Controls.Add(this.UserRegBox);
            this.panelRegister.Controls.Add(this.PasswordRegLabel);
            this.panelRegister.Controls.Add(this.Password2RegLabel);
            this.panelRegister.Controls.Add(this.EmailRegLabel);
            this.panelRegister.Controls.Add(this.Email2RegLabel);
            this.panelRegister.Controls.Add(this.PvtRegLabel);
            this.panelRegister.Controls.Add(this.UserRegLabel);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Location = new System.Drawing.Point(114, 138);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(844, 665);
            this.panelRegister.TabIndex = 1;
            this.panelRegister.Visible = false;
            // 
            // RegErrorLabel
            // 
            this.RegErrorLabel.AutoSize = true;
            this.RegErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RegErrorLabel.Location = new System.Drawing.Point(194, 544);
            this.RegErrorLabel.Name = "RegErrorLabel";
            this.RegErrorLabel.Size = new System.Drawing.Size(0, 29);
            this.RegErrorLabel.TabIndex = 23;
            this.RegErrorLabel.Visible = false;
            // 
            // EmailSame2Label
            // 
            this.EmailSame2Label.AutoSize = true;
            this.EmailSame2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSame2Label.ForeColor = System.Drawing.Color.White;
            this.EmailSame2Label.Location = new System.Drawing.Point(513, 342);
            this.EmailSame2Label.Name = "EmailSame2Label";
            this.EmailSame2Label.Size = new System.Drawing.Size(0, 29);
            this.EmailSame2Label.TabIndex = 22;
            // 
            // EmailSameLabel
            // 
            this.EmailSameLabel.AutoSize = true;
            this.EmailSameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSameLabel.ForeColor = System.Drawing.Color.White;
            this.EmailSameLabel.Location = new System.Drawing.Point(513, 281);
            this.EmailSameLabel.Name = "EmailSameLabel";
            this.EmailSameLabel.Size = new System.Drawing.Size(0, 29);
            this.EmailSameLabel.TabIndex = 21;
            // 
            // SamePass2Label
            // 
            this.SamePass2Label.AutoSize = true;
            this.SamePass2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamePass2Label.ForeColor = System.Drawing.Color.White;
            this.SamePass2Label.Location = new System.Drawing.Point(513, 221);
            this.SamePass2Label.Name = "SamePass2Label";
            this.SamePass2Label.Size = new System.Drawing.Size(0, 29);
            this.SamePass2Label.TabIndex = 20;
            // 
            // SamePassLabel
            // 
            this.SamePassLabel.AutoSize = true;
            this.SamePassLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamePassLabel.ForeColor = System.Drawing.Color.White;
            this.SamePassLabel.Location = new System.Drawing.Point(513, 164);
            this.SamePassLabel.Name = "SamePassLabel";
            this.SamePassLabel.Size = new System.Drawing.Size(0, 29);
            this.SamePassLabel.TabIndex = 19;
            // 
            // UserAvailableLabel
            // 
            this.UserAvailableLabel.AutoSize = true;
            this.UserAvailableLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAvailableLabel.ForeColor = System.Drawing.Color.White;
            this.UserAvailableLabel.Location = new System.Drawing.Point(513, 100);
            this.UserAvailableLabel.Name = "UserAvailableLabel";
            this.UserAvailableLabel.Size = new System.Drawing.Size(0, 29);
            this.UserAvailableLabel.TabIndex = 18;
            // 
            // PremiumCheck
            // 
            this.PremiumCheck.AutoSize = true;
            this.PremiumCheck.Location = new System.Drawing.Point(286, 458);
            this.PremiumCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PremiumCheck.Name = "PremiumCheck";
            this.PremiumCheck.Size = new System.Drawing.Size(113, 24);
            this.PremiumCheck.TabIndex = 17;
            this.PremiumCheck.Text = "checkBox1";
            this.PremiumCheck.UseVisualStyleBackColor = true;
            // 
            // PremiumLabel
            // 
            this.PremiumLabel.AutoSize = true;
            this.PremiumLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PremiumLabel.ForeColor = System.Drawing.Color.White;
            this.PremiumLabel.Location = new System.Drawing.Point(32, 458);
            this.PremiumLabel.Name = "PremiumLabel";
            this.PremiumLabel.Size = new System.Drawing.Size(117, 29);
            this.PremiumLabel.TabIndex = 16;
            this.PremiumLabel.Text = "Premium?";
            // 
            // BackRegButton
            // 
            this.BackRegButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackRegButton.Location = new System.Drawing.Point(37, 544);
            this.BackRegButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackRegButton.Name = "BackRegButton";
            this.BackRegButton.Size = new System.Drawing.Size(147, 62);
            this.BackRegButton.TabIndex = 15;
            this.BackRegButton.Text = "Back";
            this.BackRegButton.UseVisualStyleBackColor = true;
            this.BackRegButton.Click += new System.EventHandler(this.BackRegButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(433, 544);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(147, 62);
            this.RegisterButton.TabIndex = 14;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PvtRegCheck
            // 
            this.PvtRegCheck.AutoSize = true;
            this.PvtRegCheck.Location = new System.Drawing.Point(286, 404);
            this.PvtRegCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PvtRegCheck.Name = "PvtRegCheck";
            this.PvtRegCheck.Size = new System.Drawing.Size(113, 24);
            this.PvtRegCheck.TabIndex = 13;
            this.PvtRegCheck.Text = "checkBox1";
            this.PvtRegCheck.UseVisualStyleBackColor = true;
            // 
            // PassRegBox
            // 
            this.PassRegBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassRegBox.Location = new System.Drawing.Point(286, 164);
            this.PassRegBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassRegBox.Name = "PassRegBox";
            this.PassRegBox.PasswordChar = '•';
            this.PassRegBox.Size = new System.Drawing.Size(209, 26);
            this.PassRegBox.TabIndex = 12;
            this.PassRegBox.TextChanged += new System.EventHandler(this.PassRegBox_TextChanged);
            // 
            // Pass2RegBox
            // 
            this.Pass2RegBox.Location = new System.Drawing.Point(286, 221);
            this.Pass2RegBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pass2RegBox.Name = "Pass2RegBox";
            this.Pass2RegBox.PasswordChar = '•';
            this.Pass2RegBox.Size = new System.Drawing.Size(209, 26);
            this.Pass2RegBox.TabIndex = 11;
            this.Pass2RegBox.TextChanged += new System.EventHandler(this.Pass2RegBox_TextChanged);
            // 
            // Email2RegBox
            // 
            this.Email2RegBox.Location = new System.Drawing.Point(286, 342);
            this.Email2RegBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email2RegBox.Name = "Email2RegBox";
            this.Email2RegBox.Size = new System.Drawing.Size(209, 26);
            this.Email2RegBox.TabIndex = 9;
            this.Email2RegBox.TextChanged += new System.EventHandler(this.Email2RegBox_TextChanged);
            // 
            // EmailRegBox
            // 
            this.EmailRegBox.Location = new System.Drawing.Point(286, 281);
            this.EmailRegBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailRegBox.Name = "EmailRegBox";
            this.EmailRegBox.Size = new System.Drawing.Size(209, 26);
            this.EmailRegBox.TabIndex = 8;
            this.EmailRegBox.TextChanged += new System.EventHandler(this.EmailRegBox_TextChanged);
            // 
            // UserRegBox
            // 
            this.UserRegBox.Location = new System.Drawing.Point(286, 100);
            this.UserRegBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserRegBox.Name = "UserRegBox";
            this.UserRegBox.Size = new System.Drawing.Size(209, 26);
            this.UserRegBox.TabIndex = 7;
            this.UserRegBox.TextChanged += new System.EventHandler(this.UserRegBox_TextChanged);
            // 
            // PasswordRegLabel
            // 
            this.PasswordRegLabel.AutoSize = true;
            this.PasswordRegLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRegLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordRegLabel.Location = new System.Drawing.Point(32, 155);
            this.PasswordRegLabel.Name = "PasswordRegLabel";
            this.PasswordRegLabel.Size = new System.Drawing.Size(111, 29);
            this.PasswordRegLabel.TabIndex = 6;
            this.PasswordRegLabel.Text = "Password";
            // 
            // Password2RegLabel
            // 
            this.Password2RegLabel.AutoSize = true;
            this.Password2RegLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password2RegLabel.ForeColor = System.Drawing.Color.White;
            this.Password2RegLabel.Location = new System.Drawing.Point(32, 212);
            this.Password2RegLabel.Name = "Password2RegLabel";
            this.Password2RegLabel.Size = new System.Drawing.Size(197, 29);
            this.Password2RegLabel.TabIndex = 5;
            this.Password2RegLabel.Text = "Confirm password";
            // 
            // EmailRegLabel
            // 
            this.EmailRegLabel.AutoSize = true;
            this.EmailRegLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailRegLabel.ForeColor = System.Drawing.Color.White;
            this.EmailRegLabel.Location = new System.Drawing.Point(32, 272);
            this.EmailRegLabel.Name = "EmailRegLabel";
            this.EmailRegLabel.Size = new System.Drawing.Size(69, 29);
            this.EmailRegLabel.TabIndex = 4;
            this.EmailRegLabel.Text = "Email";
            // 
            // Email2RegLabel
            // 
            this.Email2RegLabel.AutoSize = true;
            this.Email2RegLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email2RegLabel.ForeColor = System.Drawing.Color.White;
            this.Email2RegLabel.Location = new System.Drawing.Point(32, 334);
            this.Email2RegLabel.Name = "Email2RegLabel";
            this.Email2RegLabel.Size = new System.Drawing.Size(155, 29);
            this.Email2RegLabel.TabIndex = 3;
            this.Email2RegLabel.Text = "Confirm email";
            // 
            // PvtRegLabel
            // 
            this.PvtRegLabel.AutoSize = true;
            this.PvtRegLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PvtRegLabel.ForeColor = System.Drawing.Color.White;
            this.PvtRegLabel.Location = new System.Drawing.Point(32, 394);
            this.PvtRegLabel.Name = "PvtRegLabel";
            this.PvtRegLabel.Size = new System.Drawing.Size(179, 29);
            this.PvtRegLabel.TabIndex = 2;
            this.PvtRegLabel.Text = "Private account?";
            this.PvtRegLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // UserRegLabel
            // 
            this.UserRegLabel.AutoSize = true;
            this.UserRegLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRegLabel.ForeColor = System.Drawing.Color.White;
            this.UserRegLabel.Location = new System.Drawing.Point(32, 100);
            this.UserRegLabel.Name = "UserRegLabel";
            this.UserRegLabel.Size = new System.Drawing.Size(117, 29);
            this.UserRegLabel.TabIndex = 1;
            this.UserRegLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1127, 890);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panelRegister);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Spotflix";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Button GoToRegButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label UsernameLAbel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label PasswordRegLabel;
        private System.Windows.Forms.Label Password2RegLabel;
        private System.Windows.Forms.Label EmailRegLabel;
        private System.Windows.Forms.Label Email2RegLabel;
        private System.Windows.Forms.Label PvtRegLabel;
        private System.Windows.Forms.Label UserRegLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackRegButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.CheckBox PvtRegCheck;
        private System.Windows.Forms.TextBox PassRegBox;
        private System.Windows.Forms.TextBox Pass2RegBox;
        private System.Windows.Forms.TextBox Email2RegBox;
        private System.Windows.Forms.TextBox EmailRegBox;
        private System.Windows.Forms.TextBox UserRegBox;
        private System.Windows.Forms.Label UserAvailableLabel;
        private System.Windows.Forms.CheckBox PremiumCheck;
        private System.Windows.Forms.Label PremiumLabel;
        private System.Windows.Forms.Label SamePassLabel;
        private System.Windows.Forms.Label EmailSame2Label;
        private System.Windows.Forms.Label EmailSameLabel;
        private System.Windows.Forms.Label SamePass2Label;
        private System.Windows.Forms.Label RegErrorLabel;
    }
}

