namespace LibraryManagementSystem
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.Register_Showpassword = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Register_Signupbtn = new System.Windows.Forms.Button();
            this.Register_Signinbtn = new System.Windows.Forms.Button();
            this.Register_passwordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Register_Usernametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Register_Emailtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Register_Showpassword
            // 
            this.Register_Showpassword.AutoSize = true;
            this.Register_Showpassword.Checked = true;
            this.Register_Showpassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Register_Showpassword.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Showpassword.ForeColor = System.Drawing.Color.White;
            this.Register_Showpassword.Location = new System.Drawing.Point(300, 358);
            this.Register_Showpassword.Name = "Register_Showpassword";
            this.Register_Showpassword.Size = new System.Drawing.Size(119, 21);
            this.Register_Showpassword.TabIndex = 17;
            this.Register_Showpassword.Text = "Show password";
            this.Register_Showpassword.UseVisualStyleBackColor = true;
            this.Register_Showpassword.CheckedChanged += new System.EventHandler(this.Register_Showpassword_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "\"Already have an account ? Sign in here\"";
            // 
            // Register_Signupbtn
            // 
            this.Register_Signupbtn.BackColor = System.Drawing.Color.White;
            this.Register_Signupbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Register_Signupbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Register_Signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Signupbtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Signupbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Register_Signupbtn.Location = new System.Drawing.Point(192, 397);
            this.Register_Signupbtn.Name = "Register_Signupbtn";
            this.Register_Signupbtn.Size = new System.Drawing.Size(150, 50);
            this.Register_Signupbtn.TabIndex = 15;
            this.Register_Signupbtn.Text = "SIGN UP";
            this.Register_Signupbtn.UseVisualStyleBackColor = false;
            this.Register_Signupbtn.Click += new System.EventHandler(this.Register_Signupbtn_Click);
            // 
            // Register_Signinbtn
            // 
            this.Register_Signinbtn.BackColor = System.Drawing.Color.White;
            this.Register_Signinbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Register_Signinbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Register_Signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Signinbtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Signinbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Register_Signinbtn.Location = new System.Drawing.Point(192, 566);
            this.Register_Signinbtn.Name = "Register_Signinbtn";
            this.Register_Signinbtn.Size = new System.Drawing.Size(150, 50);
            this.Register_Signinbtn.TabIndex = 14;
            this.Register_Signinbtn.Text = "SIGN IN";
            this.Register_Signinbtn.UseVisualStyleBackColor = false;
            this.Register_Signinbtn.Click += new System.EventHandler(this.Login_Signinbtn_Click);
            // 
            // Register_passwordtxt
            // 
            this.Register_passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Register_passwordtxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_passwordtxt.ForeColor = System.Drawing.Color.White;
            this.Register_passwordtxt.Location = new System.Drawing.Point(192, 309);
            this.Register_passwordtxt.Name = "Register_passwordtxt";
            this.Register_passwordtxt.Size = new System.Drawing.Size(227, 29);
            this.Register_passwordtxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password :";
            // 
            // Register_Usernametxt
            // 
            this.Register_Usernametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Register_Usernametxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Usernametxt.ForeColor = System.Drawing.Color.White;
            this.Register_Usernametxt.Location = new System.Drawing.Point(192, 265);
            this.Register_Usernametxt.Name = "Register_Usernametxt";
            this.Register_Usernametxt.Size = new System.Drawing.Size(227, 29);
            this.Register_Usernametxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username :";
            // 
            // Register_Emailtxt
            // 
            this.Register_Emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Register_Emailtxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Emailtxt.ForeColor = System.Drawing.Color.White;
            this.Register_Emailtxt.Location = new System.Drawing.Point(192, 219);
            this.Register_Emailtxt.Name = "Register_Emailtxt";
            this.Register_Emailtxt.Size = new System.Drawing.Size(227, 29);
            this.Register_Emailtxt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(119, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 47);
            this.label5.TabIndex = 20;
            this.label5.Text = "REGISTER HERE!";
            // 
            // Exitbutton
            // 
            this.Exitbutton.AutoSize = true;
            this.Exitbutton.BackColor = System.Drawing.Color.White;
            this.Exitbutton.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(464, 2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(34, 37);
            this.Exitbutton.TabIndex = 21;
            this.Exitbutton.Text = "X";
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Register_Emailtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register_Showpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Register_Signupbtn);
            this.Controls.Add(this.Register_Signinbtn);
            this.Controls.Add(this.Register_passwordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Register_Usernametxt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Register_Showpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Register_Signupbtn;
        private System.Windows.Forms.Button Register_Signinbtn;
        private System.Windows.Forms.TextBox Register_passwordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Register_Usernametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Register_Emailtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Exitbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}