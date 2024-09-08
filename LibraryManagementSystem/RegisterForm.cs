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
    public partial class RegisterForm : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Login_Signinbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            Register_passwordtxt.PasswordChar = Register_Showpassword.Checked ? '\0' : '*';
        }

        private void Register_Signupbtn_Click(object sender, EventArgs e)
        {

            if(Register_Emailtxt.Text == "" || Register_Usernametxt.Text == "" || Register_passwordtxt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {

                    try
                    {
                        connect.Open();

                        String checkUsername = "SELECT COUNT(*) FROM users WHERE username = @username";

                        using (SqlCommand checkCMD = new SqlCommand(checkUsername, connect))
                        {
                            checkCMD.Parameters.AddWithValue("@username", Register_Usernametxt.Text.Trim());
                            int count = (int)checkCMD.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(Register_Usernametxt.Text.Trim()
                                    + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // TO GET THE DATE TODAY
                                DateTime day = DateTime.Today;

                                String insertData = "INSERT INTO users (email, username, password, date_register) " +
                                    "VALUES(@email, @username, @password, @date)";

                                using (SqlCommand insertCMD = new SqlCommand(insertData, connect))
                                {
                                    insertCMD.Parameters.AddWithValue("@email", Register_Emailtxt.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@username", Register_Usernametxt.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@password", Register_passwordtxt.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@date", day.ToString());

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Register successfully!", "Information Message"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm lForm = new LoginForm();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }


                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }

            }


        }
    }
}
