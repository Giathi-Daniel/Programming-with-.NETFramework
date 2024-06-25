using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace userRegister
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // Corrected the connection string typo
        private readonly string connectionString = "datasource=127.0.0.1;port=3306;user=root;password=6W4Rwtk,5Ggydwj;database=registration";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming txtName, txtPass, and txtPass1 are TextBox controls on your form
            string name = txtName.Text;
            string password = txtPass.Text;
            string confirmPassword = txtPass1.Text;

            // Check if any input is empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match! Please try again.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO login_details (userName, password) VALUES (@name, @password)", connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("User registered successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code for login click event
            // Assuming there's another form for login
            // userLogin loginForm = new userLogin();
            // loginForm.Show();
            // this.Hide();
        }
    }
}
