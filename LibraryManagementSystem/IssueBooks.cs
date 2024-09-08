using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class IssueBooks : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30");
        public IssueBooks()
        {
            InitializeComponent();

            DataBookTitle();

            displayBookIssueData();
        }



        public void clearFields()
        {
            BookIssue_id.Text = "";
            BookIssue_name.Text = "";
            BookIssue_contact.Text = "";
            BookIssue_email.Text = "";
            BookIssue_booktitle.SelectedIndex = -1;
            BookIssue_author.SelectedIndex = -1;
            BookIssue_status.SelectedIndex = -1;
            BookIssue_picture.Image = null;
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBookIssueData();
            DataBookTitle();
        }

        public void displayBookIssueData()
        {

            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.IssueBooksData();

            dataGridView1.DataSource = listData;
        }

        public void DataBookTitle()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, book_title FROM books WHERE status = 'Available' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        BookIssue_booktitle.DataSource = table;
                        BookIssue_booktitle.DisplayMember = "book_title";
                        BookIssue_booktitle.ValueMember = "id";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }

        }

        private void BookIssue_addbtn_Click(object sender, EventArgs e)
        {

            if (BookIssue_id.Text == ""
                || BookIssue_name.Text == ""
                || BookIssue_contact.Text == ""
                || BookIssue_email.Text == ""
                || BookIssue_booktitle.Text == ""
                || BookIssue_author.Text == ""
                || BookIssue_issuedate.Value == null
                || BookIssue_returndate.Value == null
                || BookIssue_status.Text == ""
                || BookIssue_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        DateTime today = DateTime.Today;

                        connect.Open();

                        string insertData = "INSERT INTO issues " +
                            "(issue_id, full_name, contact, email, book_title, author, status, issue_date, return_date, date_insert) " +
                            "VALUES(@issueID, @fullname, @contact, @email, @bookTitle, @author, @status, @issueDate, @returnDate, @dateInsert)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@issueID", BookIssue_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullname", BookIssue_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", BookIssue_contact.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", BookIssue_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@bookTitle", BookIssue_booktitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", BookIssue_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", BookIssue_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@issueDate", BookIssue_issuedate.Value);
                            cmd.Parameters.AddWithValue("@returnDate", BookIssue_returndate.Value); ;
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBookIssueData();

                            MessageBox.Show("Issued successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void BookIssue_booktitle_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (connect.State != ConnectionState.Open)
            {
                if (BookIssue_booktitle.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)BookIssue_booktitle.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM books WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                BookIssue_author.Text = table.Rows[0]["author"].ToString();

                                string imagePath = table.Rows[0]["image"].ToString();

                                if (imagePath != null)
                                {
                                    BookIssue_picture.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    BookIssue_picture.Image = null;
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                BookIssue_id.Text = row.Cells[1].Value.ToString();
                BookIssue_name.Text = row.Cells[2].Value.ToString();
                BookIssue_contact.Text = row.Cells[3].Value.ToString();
                BookIssue_email.Text = row.Cells[4].Value.ToString();
                BookIssue_booktitle.Text = row.Cells[5].Value.ToString();
                BookIssue_author.Text = row.Cells[6].Value.ToString();
                BookIssue_issuedate.Text = row.Cells[7].Value.ToString();
                BookIssue_returndate.Text = row.Cells[8].Value.ToString();
                BookIssue_status.Text = row.Cells[9].Value.ToString();

            }
        }

        private void BookIssue_updatebtn_Click(object sender, EventArgs e)
        {
            if (BookIssue_id.Text == ""
                || BookIssue_name.Text == ""
                || BookIssue_contact.Text == ""
                || BookIssue_email.Text == ""
                || BookIssue_booktitle.Text == ""
                || BookIssue_author.Text == ""
                || BookIssue_issuedate.Value == null
                || BookIssue_returndate.Value == null
                || BookIssue_status.Text == ""
                || BookIssue_picture.Image == null)
            {

                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Issue ID:"
                        + BookIssue_id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE issues SET full_name = @fullName, contact = @contact, email = @email" +
                                ", book_title = @bookTitle, author = @author, status = @status, issue_date = @issueDate" +
                                ", return_date = @returnDate, date_update = @dateUpdate WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@fullName", BookIssue_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@contact", BookIssue_contact.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", BookIssue_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@bookTitle", BookIssue_booktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", BookIssue_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", BookIssue_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@issueDate", BookIssue_issuedate.Value);
                                cmd.Parameters.AddWithValue("@returnDate", BookIssue_returndate.Value);
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", BookIssue_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void BookIssue_deletebtn_Click(object sender, EventArgs e)
        {
            if (BookIssue_id.Text == ""
                || BookIssue_name.Text == ""
                || BookIssue_contact.Text == ""
                || BookIssue_email.Text == ""
                || BookIssue_booktitle.Text == ""
                || BookIssue_author.Text == ""
                || BookIssue_issuedate.Value == null
                || BookIssue_returndate.Value == null
                || BookIssue_status.Text == ""
                || BookIssue_picture.Image == null)
            {

                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Issue ID:"
                        + BookIssue_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE issues SET date_delete = @dateDelete WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@issueID", BookIssue_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BookIssue_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}

