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
    public partial class AddBooks : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30");
        
        
        public AddBooks()
        {
            InitializeComponent();

            displayBooks();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBooks();
        }

        public void clearFields()
        {
            AddBooks_BookTitletxt.Text = "";
            AddBooks_Authortxt.Text = "";
            AddBooks_picture.Image = null;
            AddBooks_Status.SelectedIndex = -1;
        }
        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List<DataAddBooks> listData = dab.addBooksData();

            dataGridView1.DataSource = listData;

        }

        private String imagePath;
        private void AddBooks_Importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    AddBooks_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBooks_Addbtn_Click(object sender, EventArgs e)
        {
            if (AddBooks_picture.Image == null
                || AddBooks_BookTitletxt.Text == ""
                || AddBooks_Authortxt.Text == ""
                || AddBooks_Publisheddate.Value == null
                || AddBooks_Status.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        connect.Open();
                        string insertData = "INSERT INTO books " +
                            "(book_title, author, published_date, status, image, date_insert) " +
                            "VALUES(@bookTitle, @author, @published_date, @status, @image, @dateInsert)";

                        string path = Path.Combine(@"C:\Users\HAI\source\repos\LibraryManagementSystem\LibraryManagementSystem\Books_Directory\" +
                            AddBooks_BookTitletxt.Text + AddBooks_Authortxt.Text.Trim() + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        File.Copy(AddBooks_picture.ImageLocation, path, true);

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookTitle", AddBooks_BookTitletxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", AddBooks_Authortxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@published_date", AddBooks_Publisheddate.Value);
                            cmd.Parameters.AddWithValue("@status", AddBooks_Status.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBooks();

                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        private int bookID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookID = (int)row.Cells[0].Value;
                AddBooks_BookTitletxt.Text = row.Cells[1].Value.ToString();
                AddBooks_Authortxt.Text = row.Cells[2].Value.ToString();
                AddBooks_Publisheddate.Text = row.Cells[3].Value.ToString();

                string imagePath = row.Cells[4].Value.ToString();


                if (imagePath != null || imagePath.Length >= 1)
                {
                    AddBooks_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    AddBooks_picture.Image = null;
                }
                AddBooks_Status.Text = row.Cells[5].Value.ToString();
            }
        }

        private void AddBooks_Clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AddBooks_Updatebtn_Click(object sender, EventArgs e)
        {
            if (AddBooks_picture.Image == null
                || AddBooks_BookTitletxt.Text == ""
                || AddBooks_Authortxt.Text == ""
                || AddBooks_Publisheddate.Value == null
                || AddBooks_Status.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Book ID:"
                        + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET book_title = @bookTitle" +
                                ", author = @author, published_date = @published" +
                                ", status = @status, date_update = @dateUpdate WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@bookTitle", AddBooks_BookTitletxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", AddBooks_Authortxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", AddBooks_Publisheddate.Value);
                                cmd.Parameters.AddWithValue("@status", AddBooks_Status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

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

        private void AddBooks_Deletebtn_Click(object sender, EventArgs e)
        {
            if (AddBooks_picture.Image == null
                || AddBooks_BookTitletxt.Text == ""
                || AddBooks_Authortxt.Text == ""
                || AddBooks_Publisheddate.Value == null
                || AddBooks_Status.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Book ID:"
                        + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET date_delete = @dateDelete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

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
    }
}
