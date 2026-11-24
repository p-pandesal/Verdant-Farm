using Npgsql;

namespace VerdantFarm
{
    public partial class Login : Form
    {
        // <( Instantiations )>
        Dashboard db = new Dashboard();

        // <( Constructor for the Login form )>
        public Login()
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

        // <( Event handler for the "Login" button click )>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw\r\n ;Database=defaultdb";

            using (var sql = new NpgsqlConnection(conn))
            {
                sql.Open();
                string query = "SELECT accountid FROM Accounts WHERE username = @u AND password = @p";
                using (var cmd = new NpgsqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("p", txtPassword.Text);
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string accountIdStr = reader["accountid"].ToString();
                                GlobalData.CurrentAccountId = accountIdStr;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // <= Validate user credentials against the database =>
            using (var sql = new NpgsqlConnection(conn))
            {
                sql.Open();
                string query = "SELECT COUNT(*) FROM Accounts WHERE username = @u AND password = @p";
                using (var cmd = new NpgsqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("p", txtPassword.Text);
                    try
                    {
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                        if (userCount > 0)
                        {
                            // <= Open the dashboard and close the login form =>
                            db.FormClosed += (s, args) => this.Close();
                            db.Show();
                            this.Hide();
                            SignUp su = new SignUp();
                            su.FormClosed += (s, args) => this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // <( Event handler for the "Sign Up" link label )>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }
    }
}
