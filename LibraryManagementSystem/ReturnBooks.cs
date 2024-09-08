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

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30");
        public ReturnBooks()
        {
            InitializeComponent();
            displayIssuedBooksData();
        }

        public void clearFields()
        {
            ReturnBooks_id.Text = "";
            ReturnBooks_name.Text = "";
            ReturnBooks_contact.Text = "";
            ReturnBooks_email.Text = "";
            ReturnBooks_booktitle.Text = "";
            ReturnBooks_author.Text = "";
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIssuedBooksData();
        }
        public void displayIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.ReturnIssueBooksData();

            dataGridView1.DataSource = listData;
        }

        private void ReturnBooks_retunbtn_Click(object sender, EventArgs e)
        {
            if (ReturnBooks_id.Text == ""
                || ReturnBooks_name.Text == ""
                || ReturnBooks_contact.Text == ""
                || ReturnBooks_email.Text == ""
                || ReturnBooks_booktitle.Text == ""
                || ReturnBooks_author.Text == ""
                || ReturnBooks_issuedate.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    DialogResult check = MessageBox.Show("Are you sure that Issue ID: "
                        + ReturnBooks_id.Text.Trim()
                        + "is return already?", "Confirmation Message", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            connect.Open();

                            string updateData = "UPDATE issues SET status = @status, date_update = @dateUpdate " +
                                "WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@status", "Return");
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", ReturnBooks_id.Text);

                                cmd.ExecuteNonQuery();

                                displayIssuedBooksData();

                                MessageBox.Show("Returned successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //clearFields();
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

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ReturnBooks_id.Text = row.Cells[1].Value.ToString();
                ReturnBooks_name.Text = row.Cells[2].Value.ToString();
                ReturnBooks_contact.Text = row.Cells[3].Value.ToString();
                ReturnBooks_email.Text = row.Cells[4].Value.ToString();
                ReturnBooks_booktitle.Text = row.Cells[5].Value.ToString();
                ReturnBooks_author.Text = row.Cells[6].Value.ToString();
                ReturnBooks_issuedate.Text = row.Cells[7].Value.ToString();
            }
        }

        private void ReturnBooks_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
