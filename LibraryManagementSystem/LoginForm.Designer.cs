namespace LibraryManagementSystem
{
    partial class LoginForm
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
            this.Exitbutton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Usernametxt = new System.Windows.Forms.TextBox();
            this.login_passwordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_Signinbtn = new System.Windows.Forms.Button();
            this.Login_Signupbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Login_Showpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.AutoSize = true;
            this.Exitbutton.BackColor = System.Drawing.Color.White;
            this.Exitbutton.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(464, 2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(34, 37);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.Text = "X";
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME USER!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username :";
            // 
            // login_Usernametxt
            // 
            this.login_Usernametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.login_Usernametxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Usernametxt.ForeColor = System.Drawing.Color.White;
            this.login_Usernametxt.Location = new System.Drawing.Point(198, 274);
            this.login_Usernametxt.Name = "login_Usernametxt";
            this.login_Usernametxt.Size = new System.Drawing.Size(227, 29);
            this.login_Usernametxt.TabIndex = 3;
            // 
            // login_passwordtxt
            // 
            this.login_passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.login_passwordtxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_passwordtxt.ForeColor = System.Drawing.Color.White;
            this.login_passwordtxt.Location = new System.Drawing.Point(198, 318);
            this.login_passwordtxt.Name = "login_passwordtxt";
            this.login_passwordtxt.Size = new System.Drawing.Size(227, 29);
            this.login_passwordtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            // 
            // Login_Signinbtn
            // 
            this.Login_Signinbtn.BackColor = System.Drawing.Color.White;
            this.Login_Signinbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Login_Signinbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Login_Signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Signinbtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Signinbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login_Signinbtn.Location = new System.Drawing.Point(198, 396);
            this.Login_Signinbtn.Name = "Login_Signinbtn";
            this.Login_Signinbtn.Size = new System.Drawing.Size(150, 50);
            this.Login_Signinbtn.TabIndex = 6;
            this.Login_Signinbtn.Text = "SIGN IN";
            this.Login_Signinbtn.UseVisualStyleBackColor = false;
            this.Login_Signinbtn.Click += new System.EventHandler(this.Login_Signinbtn_Click);
            // 
            // Login_Signupbtn
            // 
            this.Login_Signupbtn.BackColor = System.Drawing.Color.White;
            this.Login_Signupbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Login_Signupbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Login_Signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Signupbtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Signupbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login_Signupbtn.Location = new System.Drawing.Point(198, 582);
            this.Login_Signupbtn.Name = "Login_Signupbtn";
            this.Login_Signupbtn.Size = new System.Drawing.Size(150, 50);
            this.Login_Signupbtn.TabIndex = 7;
            this.Login_Signupbtn.Text = "SIGN UP";
            this.Login_Signupbtn.UseVisualStyleBackColor = false;
            this.Login_Signupbtn.Click += new System.EventHandler(this.Login_Signupbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(161, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "\"Dont have an account ? Register here\"";
            // 
            // Login_Showpassword
            // 
            this.Login_Showpassword.AutoSize = true;
            this.Login_Showpassword.Checked = true;
            this.Login_Showpassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Login_Showpassword.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Showpassword.ForeColor = System.Drawing.Color.White;
            this.Login_Showpassword.Location = new System.Drawing.Point(306, 353);
            this.Login_Showpassword.Name = "Login_Showpassword";
            this.Login_Showpassword.Size = new System.Drawing.Size(119, 21);
            this.Login_Showpassword.TabIndex = 9;
            this.Login_Showpassword.Text = "Show password";
            this.Login_Showpassword.UseVisualStyleBackColor = true;
            this.Login_Showpassword.CheckedChanged += new System.EventHandler(this.Login_Showpassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.Login_Showpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Login_Signupbtn);
            this.Controls.Add(this.Login_Signinbtn);
            this.Controls.Add(this.login_passwordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_Usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_Usernametxt;
        private System.Windows.Forms.TextBox login_passwordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login_Signinbtn;
        private System.Windows.Forms.Button Login_Signupbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Login_Showpassword;
    }
}