using Npgsql;

namespace VerdantFarm
{
    public partial class SignUp : Form
    {
        // <( Instantiations )>
        Login frm = new Login();

        // <( Constructor for the SignUp form )>
        public SignUp()
        {
            InitializeComponent();
        }

        // <( Event handler for the "Show Password" button click )>
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowPassword.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowPassword.Text = "Show";
            }
        }

        // <( Event handler for the "Show Confirm Password" button click )>
        private void btnShowConfirmPass_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.UseSystemPasswordChar == true)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
                btnShowConfirmPass.Text = "Hide";
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
                btnShowConfirmPass.Text = "Show";
            }
        }

        // <( Event handler for the "Login" button click )>
        private void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            // <= Check if password and confirm password match =>
            if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw\r\n ;Database=defaultdb";
            int id = 0;

            // <= Check if the username already exists in the database =>
            using (var sql = new NpgsqlConnection(conn))
            {
                try
                {
                    sql.Open();

                    string checkUser = "SELECT Username FROM Accounts;";
                    using (var cmd = new NpgsqlCommand(checkUser, sql))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["Username"].ToString() == txtUsername.Text)
                                {
                                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // <= Insert the new account into the database =>
            using (var sql = new NpgsqlConnection(conn))
            {
                try
                {
                    sql.Open();
                    string query = "INSERT INTO Accounts (username, password) VALUES (@u, @p);";
                    using (var cmd = new NpgsqlCommand(query, sql))
                    {
                        cmd.Parameters.AddWithValue("u", txtUsername.Text);
                        cmd.Parameters.AddWithValue("p", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm = new Login();
                        frm.Show();
                        this.Hide();
                        frm.FormClosed += (s, args) => this.Close();
                        Dashboard db = new Dashboard();
                        db.FormClosed += (s, args) => this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm.Show();
            this.Hide();
        }
    }
}
