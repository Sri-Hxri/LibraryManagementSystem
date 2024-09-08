namespace LibraryManagementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.ReturnBooks_btn = new System.Windows.Forms.Button();
            this.IssueBooks_btn = new System.Windows.Forms.Button();
            this.AddBooks_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.issueBooks1 = new LibraryManagementSystem.IssueBooks();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ReturnBooks_btn);
            this.panel1.Controls.Add(this.IssueBooks_btn);
            this.panel1.Controls.Add(this.AddBooks_btn);
            this.panel1.Controls.Add(this.Dashboard_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exitbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(855, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "LOGOUT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ReturnBooks_btn
            // 
            this.ReturnBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReturnBooks_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ReturnBooks_btn.FlatAppearance.BorderSize = 2;
            this.ReturnBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBooks_btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBooks_btn.ForeColor = System.Drawing.Color.White;
            this.ReturnBooks_btn.Location = new System.Drawing.Point(716, 16);
            this.ReturnBooks_btn.Name = "ReturnBooks_btn";
            this.ReturnBooks_btn.Size = new System.Drawing.Size(120, 71);
            this.ReturnBooks_btn.TabIndex = 4;
            this.ReturnBooks_btn.Text = "RETURN BOOKS";
            this.ReturnBooks_btn.UseVisualStyleBackColor = false;
            this.ReturnBooks_btn.Click += new System.EventHandler(this.ReturnBooks_btn_Click);
            // 
            // IssueBooks_btn
            // 
            this.IssueBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.IssueBooks_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IssueBooks_btn.FlatAppearance.BorderSize = 2;
            this.IssueBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueBooks_btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBooks_btn.ForeColor = System.Drawing.Color.White;
            this.IssueBooks_btn.Location = new System.Drawing.Point(565, 16);
            this.IssueBooks_btn.Name = "IssueBooks_btn";
            this.IssueBooks_btn.Size = new System.Drawing.Size(120, 71);
            this.IssueBooks_btn.TabIndex = 5;
            this.IssueBooks_btn.Text = "ISSUE BOOKS";
            this.IssueBooks_btn.UseVisualStyleBackColor = false;
            this.IssueBooks_btn.Click += new System.EventHandler(this.IssueBooks_btn_Click);
            // 
            // AddBooks_btn
            // 
            this.AddBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddBooks_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddBooks_btn.FlatAppearance.BorderSize = 2;
            this.AddBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooks_btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooks_btn.ForeColor = System.Drawing.Color.White;
            this.AddBooks_btn.Location = new System.Drawing.Point(426, 16);
            this.AddBooks_btn.Name = "AddBooks_btn";
            this.AddBooks_btn.Size = new System.Drawing.Size(111, 71);
            this.AddBooks_btn.TabIndex = 4;
            this.AddBooks_btn.Text = "ADD BOOKS";
            this.AddBooks_btn.UseVisualStyleBackColor = false;
            this.AddBooks_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Dashboard_btn.FlatAppearance.BorderSize = 2;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.Location = new System.Drawing.Point(271, 26);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(120, 50);
            this.Dashboard_btn.TabIndex = 3;
            this.Dashboard_btn.Text = "DASHBOARD";
            this.Dashboard_btn.UseVisualStyleBackColor = false;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome User!";
            // 
            // Exitbutton
            // 
            this.Exitbutton.AutoSize = true;
            this.Exitbutton.BackColor = System.Drawing.Color.White;
            this.Exitbutton.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exitbutton.Location = new System.Drawing.Point(966, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(34, 37);
            this.Exitbutton.TabIndex = 1;
            this.Exitbutton.Text = "X";
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Controls.Add(this.addBooks1);
            this.panel2.Controls.Add(this.issueBooks1);
            this.panel2.Controls.Add(this.returnBooks1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 500);
            this.panel2.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1000, 500);
            this.dashboard1.TabIndex = 3;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, 0);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(1000, 500);
            this.addBooks1.TabIndex = 2;
            // 
            // issueBooks1
            // 
            this.issueBooks1.BackColor = System.Drawing.Color.White;
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(1000, 500);
            this.issueBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(1000, 500);
            this.returnBooks1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ReturnBooks_btn;
        private System.Windows.Forms.Button IssueBooks_btn;
        private System.Windows.Forms.Button AddBooks_btn;
        private System.Windows.Forms.Panel panel2;
        private ReturnBooks returnBooks1;
        private IssueBooks issueBooks1;
        private AddBooks addBooks1;
        private Dashboard dashboard1;
    }
}