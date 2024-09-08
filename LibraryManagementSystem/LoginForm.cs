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
    public partial class LoginForm : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HAI\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Signupbtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(); 
            registerForm.Show();
            this.Hide();
        }

        private void Login_Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            login_passwordtxt.PasswordChar = Login_Showpassword.Checked ? '\0' : '*';
        }

        private void Login_Signinbtn_Click(object sender, EventArgs e)
        {

            if (login_Usernametxt.Text == "" || login_passwordtxt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (connect.State != ConnectionState.Open)
                {
                    try
                    {

                        connect.Open();

                        String selectData
                            = "SELECT * FROM users WHERE username = @username AND password = @password";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {

                            cmd.Parameters.AddWithValue("@username", login_Usernametxt.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_passwordtxt.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfully!", "Information Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                              MainForm mForm = new MainForm();
                               mForm.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }


                    }
                    catch (Exception ex)
                    {

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
