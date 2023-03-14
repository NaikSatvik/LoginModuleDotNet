
namespace LoginRegister
{
    partial class app
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.lgnPassword = new System.Windows.Forms.TextBox();
            this.lgnAckBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lgnBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lgnUsername = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationTab = new System.Windows.Forms.TabPage();
            this.confPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.ackRegisterMsg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.registrationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.loginTab);
            this.Tab.Controls.Add(this.registrationTab);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(395, 495);
            this.Tab.TabIndex = 8;
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.Color.Silver;
            this.loginTab.Controls.Add(this.lgnPassword);
            this.loginTab.Controls.Add(this.lgnAckBox);
            this.loginTab.Controls.Add(this.label3);
            this.loginTab.Controls.Add(this.linkLabel1);
            this.loginTab.Controls.Add(this.lgnBtn);
            this.loginTab.Controls.Add(this.label2);
            this.loginTab.Controls.Add(this.lgnUsername);
            this.loginTab.Controls.Add(this.label1);
            this.loginTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(387, 469);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "L O G I N";
            // 
            // lgnPassword
            // 
            this.lgnPassword.BackColor = System.Drawing.SystemColors.Info;
            this.lgnPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lgnPassword.Location = new System.Drawing.Point(153, 242);
            this.lgnPassword.Name = "lgnPassword";
            this.lgnPassword.Size = new System.Drawing.Size(167, 20);
            this.lgnPassword.TabIndex = 16;
            // 
            // lgnAckBox
            // 
            this.lgnAckBox.AutoSize = true;
            this.lgnAckBox.ForeColor = System.Drawing.Color.Red;
            this.lgnAckBox.Location = new System.Drawing.Point(109, 279);
            this.lgnAckBox.Name = "lgnAckBox";
            this.lgnAckBox.Size = new System.Drawing.Size(0, 13);
            this.lgnAckBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "A N O N";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(91, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(206, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have accout? Click here to register .";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lgnBtn
            // 
            this.lgnBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lgnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lgnBtn.FlatAppearance.BorderSize = 2;
            this.lgnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnBtn.Location = new System.Drawing.Point(85, 299);
            this.lgnBtn.Name = "lgnBtn";
            this.lgnBtn.Size = new System.Drawing.Size(212, 46);
            this.lgnBtn.TabIndex = 12;
            this.lgnBtn.Text = "L O G I N";
            this.lgnBtn.UseVisualStyleBackColor = false;
            this.lgnBtn.Click += new System.EventHandler(this.lgnBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // lgnUsername
            // 
            this.lgnUsername.BackColor = System.Drawing.SystemColors.Info;
            this.lgnUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lgnUsername.Location = new System.Drawing.Point(152, 184);
            this.lgnUsername.Name = "lgnUsername";
            this.lgnUsername.Size = new System.Drawing.Size(167, 28);
            this.lgnUsername.TabIndex = 9;
            this.lgnUsername.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // registrationTab
            // 
            this.registrationTab.BackColor = System.Drawing.Color.LightGray;
            this.registrationTab.Controls.Add(this.registerBtn);
            this.registrationTab.Controls.Add(this.confPassword);
            this.registrationTab.Controls.Add(this.password);
            this.registrationTab.Controls.Add(this.ackRegisterMsg);
            this.registrationTab.Controls.Add(this.label12);
            this.registrationTab.Controls.Add(this.label11);
            this.registrationTab.Controls.Add(this.address);
            this.registrationTab.Controls.Add(this.label10);
            this.registrationTab.Controls.Add(this.other);
            this.registrationTab.Controls.Add(this.female);
            this.registrationTab.Controls.Add(this.male);
            this.registrationTab.Controls.Add(this.label9);
            this.registrationTab.Controls.Add(this.lname);
            this.registrationTab.Controls.Add(this.label8);
            this.registrationTab.Controls.Add(this.fname);
            this.registrationTab.Controls.Add(this.label7);
            this.registrationTab.Controls.Add(this.email);
            this.registrationTab.Controls.Add(this.label6);
            this.registrationTab.Controls.Add(this.label5);
            this.registrationTab.Controls.Add(this.username);
            this.registrationTab.Controls.Add(this.label4);
            this.registrationTab.Location = new System.Drawing.Point(4, 22);
            this.registrationTab.Name = "registrationTab";
            this.registrationTab.Padding = new System.Windows.Forms.Padding(3);
            this.registrationTab.Size = new System.Drawing.Size(387, 469);
            this.registrationTab.TabIndex = 1;
            this.registrationTab.Text = "R E G I S T E R";
            // 
            // confPassword
            // 
            this.confPassword.BackColor = System.Drawing.SystemColors.Info;
            this.confPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confPassword.Location = new System.Drawing.Point(121, 362);
            this.confPassword.Name = "confPassword";
            this.confPassword.Size = new System.Drawing.Size(198, 20);
            this.confPassword.TabIndex = 22;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Info;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(121, 334);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(198, 20);
            this.password.TabIndex = 21;
            // 
            // ackRegisterMsg
            // 
            this.ackRegisterMsg.AutoSize = true;
            this.ackRegisterMsg.ForeColor = System.Drawing.Color.Red;
            this.ackRegisterMsg.Location = new System.Drawing.Point(118, 31);
            this.ackRegisterMsg.Name = "ackRegisterMsg";
            this.ackRegisterMsg.Size = new System.Drawing.Size(0, 13);
            this.ackRegisterMsg.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Confirm Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Password";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.Info;
            this.address.Location = new System.Drawing.Point(120, 195);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(198, 96);
            this.address.TabIndex = 14;
            this.address.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Address";
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(242, 172);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(51, 17);
            this.other.TabIndex = 12;
            this.other.TabStop = true;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(177, 172);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 11;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(120, 172);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 10;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Gender";
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.SystemColors.Info;
            this.lname.Location = new System.Drawing.Point(120, 142);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(198, 22);
            this.lname.TabIndex = 8;
            this.lname.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Last Name";
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.SystemColors.Info;
            this.fname.Location = new System.Drawing.Point(120, 114);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(198, 22);
            this.fname.TabIndex = 6;
            this.fname.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "First Name";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Info;
            this.email.Location = new System.Drawing.Point(120, 86);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(198, 22);
            this.email.TabIndex = 4;
            this.email.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Register a user here.";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Info;
            this.username.Location = new System.Drawing.Point(120, 58);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(198, 22);
            this.username.TabIndex = 1;
            this.username.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(96, 401);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(159, 50);
            this.registerBtn.TabIndex = 23;
            this.registerBtn.Text = "R E G I S T E R";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(419, 519);
            this.Controls.Add(this.Tab);
            this.Name = "app";
            this.Text = "Application";
            this.Tab.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.registrationTab.ResumeLayout(false);
            this.registrationTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Label lgnAckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button lgnBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox lgnUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage registrationTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox lname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox fname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ackRegisterMsg;
        private System.Windows.Forms.TextBox confPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox lgnPassword;
        private System.Windows.Forms.Button registerBtn;
    }
}

