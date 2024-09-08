namespace LibraryManagementSystem
{
    partial class IssueBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BookIssue_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookIssue_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookIssue_contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BookIssue_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BookIssue_booktitle = new System.Windows.Forms.ComboBox();
            this.BookIssue_author = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BookIssue_issuedate = new System.Windows.Forms.DateTimePicker();
            this.BookIssue_returndate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.BookIssue_picture = new System.Windows.Forms.PictureBox();
            this.BookIssue_addbtn = new System.Windows.Forms.Button();
            this.BookIssue_updatebtn = new System.Windows.Forms.Button();
            this.BookIssue_deletebtn = new System.Windows.Forms.Button();
            this.BookIssue_clearbtn = new System.Windows.Forms.Button();
            this.AddBooks_Importbtn = new System.Windows.Forms.Button();
            this.BookIssue_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookIssue_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 200);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(980, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISSUED BOOKS :";
            // 
            // BookIssue_id
            // 
            this.BookIssue_id.BackColor = System.Drawing.Color.White;
            this.BookIssue_id.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_id.Location = new System.Drawing.Point(104, 223);
            this.BookIssue_id.Name = "BookIssue_id";
            this.BookIssue_id.Size = new System.Drawing.Size(127, 23);
            this.BookIssue_id.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(24, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Issue Id :";
            // 
            // BookIssue_name
            // 
            this.BookIssue_name.BackColor = System.Drawing.Color.White;
            this.BookIssue_name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_name.Location = new System.Drawing.Point(104, 268);
            this.BookIssue_name.Name = "BookIssue_name";
            this.BookIssue_name.Size = new System.Drawing.Size(194, 23);
            this.BookIssue_name.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(37, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name :";
            // 
            // BookIssue_contact
            // 
            this.BookIssue_contact.BackColor = System.Drawing.Color.White;
            this.BookIssue_contact.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_contact.Location = new System.Drawing.Point(104, 321);
            this.BookIssue_contact.Name = "BookIssue_contact";
            this.BookIssue_contact.Size = new System.Drawing.Size(127, 23);
            this.BookIssue_contact.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(24, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Contact :";
            // 
            // BookIssue_email
            // 
            this.BookIssue_email.BackColor = System.Drawing.Color.White;
            this.BookIssue_email.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_email.Location = new System.Drawing.Point(104, 376);
            this.BookIssue_email.Name = "BookIssue_email";
            this.BookIssue_email.Size = new System.Drawing.Size(127, 23);
            this.BookIssue_email.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(37, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(320, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Book Title :";
            // 
            // BookIssue_booktitle
            // 
            this.BookIssue_booktitle.BackColor = System.Drawing.Color.White;
            this.BookIssue_booktitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_booktitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_booktitle.FormattingEnabled = true;
            this.BookIssue_booktitle.Location = new System.Drawing.Point(419, 224);
            this.BookIssue_booktitle.Name = "BookIssue_booktitle";
            this.BookIssue_booktitle.Size = new System.Drawing.Size(180, 23);
            this.BookIssue_booktitle.TabIndex = 30;
            this.BookIssue_booktitle.SelectedIndexChanged += new System.EventHandler(this.BookIssue_booktitle_SelectedIndexChanged);
            // 
            // BookIssue_author
            // 
            this.BookIssue_author.BackColor = System.Drawing.Color.White;
            this.BookIssue_author.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_author.FormattingEnabled = true;
            this.BookIssue_author.Location = new System.Drawing.Point(419, 267);
            this.BookIssue_author.Name = "BookIssue_author";
            this.BookIssue_author.Size = new System.Drawing.Size(180, 23);
            this.BookIssue_author.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(343, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Author :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(357, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Issue :";
            // 
            // BookIssue_issuedate
            // 
            this.BookIssue_issuedate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_issuedate.CalendarMonthBackground = System.Drawing.Color.White;
            this.BookIssue_issuedate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookIssue_issuedate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.BookIssue_issuedate.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.BookIssue_issuedate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_issuedate.Location = new System.Drawing.Point(419, 317);
            this.BookIssue_issuedate.Name = "BookIssue_issuedate";
            this.BookIssue_issuedate.Size = new System.Drawing.Size(198, 23);
            this.BookIssue_issuedate.TabIndex = 34;
            // 
            // BookIssue_returndate
            // 
            this.BookIssue_returndate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_returndate.CalendarMonthBackground = System.Drawing.Color.White;
            this.BookIssue_returndate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookIssue_returndate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.BookIssue_returndate.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.BookIssue_returndate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_returndate.Location = new System.Drawing.Point(419, 364);
            this.BookIssue_returndate.Name = "BookIssue_returndate";
            this.BookIssue_returndate.Size = new System.Drawing.Size(198, 23);
            this.BookIssue_returndate.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(343, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Return  :";
            // 
            // BookIssue_picture
            // 
            this.BookIssue_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookIssue_picture.Location = new System.Drawing.Point(816, 223);
            this.BookIssue_picture.Name = "BookIssue_picture";
            this.BookIssue_picture.Size = new System.Drawing.Size(150, 150);
            this.BookIssue_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookIssue_picture.TabIndex = 37;
            this.BookIssue_picture.TabStop = false;
            // 
            // BookIssue_addbtn
            // 
            this.BookIssue_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookIssue_addbtn.FlatAppearance.BorderSize = 2;
            this.BookIssue_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIssue_addbtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_addbtn.ForeColor = System.Drawing.Color.White;
            this.BookIssue_addbtn.Location = new System.Drawing.Point(76, 423);
            this.BookIssue_addbtn.Name = "BookIssue_addbtn";
            this.BookIssue_addbtn.Size = new System.Drawing.Size(120, 50);
            this.BookIssue_addbtn.TabIndex = 38;
            this.BookIssue_addbtn.Text = "ADD";
            this.BookIssue_addbtn.UseVisualStyleBackColor = false;
            this.BookIssue_addbtn.Click += new System.EventHandler(this.BookIssue_addbtn_Click);
            // 
            // BookIssue_updatebtn
            // 
            this.BookIssue_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookIssue_updatebtn.FlatAppearance.BorderSize = 2;
            this.BookIssue_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIssue_updatebtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_updatebtn.ForeColor = System.Drawing.Color.White;
            this.BookIssue_updatebtn.Location = new System.Drawing.Point(245, 423);
            this.BookIssue_updatebtn.Name = "BookIssue_updatebtn";
            this.BookIssue_updatebtn.Size = new System.Drawing.Size(120, 50);
            this.BookIssue_updatebtn.TabIndex = 39;
            this.BookIssue_updatebtn.Text = "UPDATE";
            this.BookIssue_updatebtn.UseVisualStyleBackColor = false;
            this.BookIssue_updatebtn.Click += new System.EventHandler(this.BookIssue_updatebtn_Click);
            // 
            // BookIssue_deletebtn
            // 
            this.BookIssue_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookIssue_deletebtn.FlatAppearance.BorderSize = 2;
            this.BookIssue_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIssue_deletebtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_deletebtn.ForeColor = System.Drawing.Color.White;
            this.BookIssue_deletebtn.Location = new System.Drawing.Point(419, 423);
            this.BookIssue_deletebtn.Name = "BookIssue_deletebtn";
            this.BookIssue_deletebtn.Size = new System.Drawing.Size(120, 50);
            this.BookIssue_deletebtn.TabIndex = 40;
            this.BookIssue_deletebtn.Text = "DELETE";
            this.BookIssue_deletebtn.UseVisualStyleBackColor = false;
            this.BookIssue_deletebtn.Click += new System.EventHandler(this.BookIssue_deletebtn_Click);
            // 
            // BookIssue_clearbtn
            // 
            this.BookIssue_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_clearbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookIssue_clearbtn.FlatAppearance.BorderSize = 2;
            this.BookIssue_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIssue_clearbtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_clearbtn.ForeColor = System.Drawing.Color.White;
            this.BookIssue_clearbtn.Location = new System.Drawing.Point(588, 423);
            this.BookIssue_clearbtn.Name = "BookIssue_clearbtn";
            this.BookIssue_clearbtn.Size = new System.Drawing.Size(120, 50);
            this.BookIssue_clearbtn.TabIndex = 41;
            this.BookIssue_clearbtn.Text = "CLEAR";
            this.BookIssue_clearbtn.UseVisualStyleBackColor = false;
            this.BookIssue_clearbtn.Click += new System.EventHandler(this.BookIssue_clearbtn_Click);
            // 
            // AddBooks_Importbtn
            // 
            this.AddBooks_Importbtn.BackColor = System.Drawing.Color.White;
            this.AddBooks_Importbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddBooks_Importbtn.FlatAppearance.BorderSize = 2;
            this.AddBooks_Importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooks_Importbtn.Font = new System.Drawing.Font("Yu Gothic UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBooks_Importbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddBooks_Importbtn.Location = new System.Drawing.Point(816, 372);
            this.AddBooks_Importbtn.Name = "AddBooks_Importbtn";
            this.AddBooks_Importbtn.Size = new System.Drawing.Size(150, 30);
            this.AddBooks_Importbtn.TabIndex = 42;
            this.AddBooks_Importbtn.Text = "IMPORT";
            this.AddBooks_Importbtn.UseVisualStyleBackColor = false;
            // 
            // BookIssue_status
            // 
            this.BookIssue_status.BackColor = System.Drawing.Color.White;
            this.BookIssue_status.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIssue_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BookIssue_status.FormattingEnabled = true;
            this.BookIssue_status.Items.AddRange(new object[] {
            "Return",
            "Not Return"});
            this.BookIssue_status.Location = new System.Drawing.Point(677, 224);
            this.BookIssue_status.Name = "BookIssue_status";
            this.BookIssue_status.Size = new System.Drawing.Size(124, 23);
            this.BookIssue_status.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(617, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 43;
            this.label10.Text = "Status :";
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BookIssue_status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AddBooks_Importbtn);
            this.Controls.Add(this.BookIssue_clearbtn);
            this.Controls.Add(this.BookIssue_deletebtn);
            this.Controls.Add(this.BookIssue_updatebtn);
            this.Controls.Add(this.BookIssue_addbtn);
            this.Controls.Add(this.BookIssue_picture);
            this.Controls.Add(this.BookIssue_returndate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BookIssue_issuedate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BookIssue_author);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BookIssue_booktitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BookIssue_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BookIssue_contact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookIssue_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookIssue_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBooks";
            this.Size = new System.Drawing.Size(1000, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookIssue_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox BookIssue_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookIssue_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookIssue_contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookIssue_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BookIssue_booktitle;
        private System.Windows.Forms.ComboBox BookIssue_author;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker BookIssue_issuedate;
        private System.Windows.Forms.DateTimePicker BookIssue_returndate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox BookIssue_picture;
        private System.Windows.Forms.Button BookIssue_addbtn;
        private System.Windows.Forms.Button BookIssue_updatebtn;
        private System.Windows.Forms.Button BookIssue_deletebtn;
        private System.Windows.Forms.Button BookIssue_clearbtn;
        private System.Windows.Forms.Button AddBooks_Importbtn;
        private System.Windows.Forms.ComboBox BookIssue_status;
        private System.Windows.Forms.Label label10;
    }
}
