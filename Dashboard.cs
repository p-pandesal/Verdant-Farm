using CropsPage;
using EquipmentsPage;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using System.Data;

namespace VerdantFarm
{
    public partial class Dashboard : Form
    {

        // <( Instantiations )>
        private List<Crops> cropList = new List<Crops>();
        private List<Equipments> equipmentList = new List<Equipments>();
        private PieChart inventoryChart;
        private PieChart equipmentChart;
        private string connStr = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw;Database=defaultdb";


        /*
         *   --------------------------------------------------
         *        <( Constructor for the Dashboard form )>
         *   --------------------------------------------------
         */
        public Dashboard()
        {
            InitializeComponent();
            inventoryChart = new PieChart();
            equipmentChart = new PieChart();

            inventoryChart.Width = 180;
            inventoryChart.Height = 180;
            inventoryChart.Top = 1;
            inventoryChart.Left = 20;

            htcDashboard.TabPages[0].Controls.Add(inventoryChart); inventoryChart.BringToFront();
            inventoryChart.BackColor = System.Drawing.Color.FromArgb(213, 214, 199);

            equipmentChart.Width = 180;
            equipmentChart.Height = 180;
            equipmentChart.Top = 1;
            equipmentChart.Left = 250;

            htcDashboard.TabPages[0].Controls.Add(equipmentChart); equipmentChart.BringToFront();
            equipmentChart.BackColor = System.Drawing.Color.FromArgb(213, 214, 199);


            RefreshChartData();
            RefreshEquipmentChartData();
        }


        /*
         *   --------------------------------------------------------------------------------------------------
         *        This method calculates totals for each crop category and updates the inventory pie chart
         *   --------------------------------------------------------------------------------------------------
         */
        public void RefreshChartData()
        {
            // We initialize variables to hold the total quantities for each of the 4 categories we want to display in the pie chart
            double fruitsTotal = 0;
            double vegetablesTotal = 0;
            double wheatsTotal = 0;
            double oilseedsTotal = 0;

            // Loop through your cropList and sum up the quantities for each of the 4 categories
            string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw\r\n ;Database=defaultdb";
            using (var connection = new Npgsql.NpgsqlConnection(conn))
            {
                connection.Open();
                string categoriesQuery = "SELECT cropclassification, SUM(cropquantity) as total FROM crops WHERE accountid = @accountId GROUP BY cropclassification";
                using (var command = new Npgsql.NpgsqlCommand(categoriesQuery, connection))
                {
                    command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string classification = reader.GetString(0);
                            double total = reader.GetDouble(1);

                            switch (classification)
                            {
                                case "Fruits":
                                    fruitsTotal = total;
                                    break;
                                case "Vegetables":
                                    vegetablesTotal = total;
                                    break;
                                case "Grains":
                                    wheatsTotal = total;
                                    break;
                                case "Oilseeds":
                                    oilseedsTotal = total;
                                    break;
                            }
                        }
                    }
                }
            }

            // Inject these 4 specific categories into the pie chart
            inventoryChart.Series = new ISeries[]
            {
                new PieSeries<double> { Values = new double[] { fruitsTotal }, Name = "Fruits" },
                new PieSeries<double> { Values = new double[] { vegetablesTotal }, Name = "Vegetables" },
                new PieSeries<double> { Values = new double[] { wheatsTotal }, Name = "Grains" },
                new PieSeries<double> { Values = new double[] { oilseedsTotal }, Name = "Oilseeds" }
            };
        }


        /*
         *   -------------------------------------------------------------------------------------------------------
         *        This method calculates totals for each equipment category and updates the equipment pie chart
         *   -------------------------------------------------------------------------------------------------------
         */
        public void RefreshEquipmentChartData()
        {
            double heavyTotal = 0;
            double implementsTotal = 0;
            double toolsTotal = 0;
            double irrigationTotal = 0;

            // Loop through your equipmentList and sum up the total costs for each of the 4 categories
            string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw\r\n ;Database=defaultdb";
            using (var connection = new Npgsql.NpgsqlConnection(conn))
            {
                connection.Open();
                string categoriesQuery = "SELECT equipmentclassification, SUM(equipmentquantity), SUM(equipmentunitcost) as total FROM equipments WHERE accountid = @accountId GROUP BY equipmentclassification";
                using (var command = new Npgsql.NpgsqlCommand(categoriesQuery, connection))
                {
                    command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string classification = reader.GetString(0);
                            double total = (reader.GetInt64(1)) * (reader.GetDouble(2));

                            switch (classification)
                            {
                                case "Heavy Machinery":
                                    heavyTotal = total;
                                    break;
                                case "Implements & Attachments":
                                    implementsTotal = total;
                                    break;
                                case "Hand Tools":
                                    toolsTotal = total;
                                    break;
                                case "Irrigation & Sprayers":
                                    irrigationTotal = total;
                                    break;
                            }
                        }
                    }
                }
            }

            // Inject these 4 specific categories into the pie chart
            equipmentChart.Series = new ISeries[]
            {
                new PieSeries<double> { Values = new double[] { heavyTotal }, Name = "Heavy Machineries" },
                new PieSeries<double> { Values = new double[] { implementsTotal }, Name = "Implements & Attachments" },
                new PieSeries<double> { Values = new double[] { toolsTotal }, Name = "Hand Tools" },
                new PieSeries<double> { Values = new double[] { irrigationTotal }, Name = "Irrigation & Sprayers" }
            };
        }


        /*
         *   ---------------------------------------------------------------
         *        <( Event handler for when the Dashboard form loads )>
         *   ---------------------------------------------------------------
         */
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Initialize the shared structure
            GlobalData.InitializeSchema();

            // Bind your homepage DataGridView to the shared global table
            dgvHistory.DataSource = GlobalData.MasterHistoryTable;

            // Format date view beautifully
            dgvHistory.Columns["LogDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

            cmbSearchCategory.Items.Add("All Categories");
            cmbSearchCategory.Items.Add("Crops");
            cmbSearchCategory.Items.Add("Equipment");

            // Make "All Categories" the default selected option
            cmbSearchCategory.SelectedIndex = 0;

            // Refresh the charts to display the most up-to-date data when the dashboard loads
            RefreshChartData();
            RefreshEquipmentChartData();
        }


        /*
         *   ---------------------------------------------------------
         *        <( Event handler for the "Home" button click )>     
         *   ---------------------------------------------------------
         */
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw\r\n ;Database=defaultdb";

            using (var connection = new Npgsql.NpgsqlConnection(conn))
            {
                connection.Open();
                string selectQuery = "SELECT logdate, itemname, action, category, totalcost FROM historytable WHERE accountid = @accountId ORDER BY logdate DESC";
                using (var command = new Npgsql.NpgsqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                    using (var reader = command.ExecuteReader())
                    {
                        GlobalData.MasterHistoryTable.Clear();
                        while (reader.Read())
                        {
                            DataRow row = GlobalData.MasterHistoryTable.NewRow();
                            row["LogDate"] = reader["logdate"];
                            row["ItemName"] = reader["itemname"];
                            row["Action"] = reader["action"];
                            row["Category"] = reader["category"];
                            row["TotalCost"] = reader["totalcost"];
                            GlobalData.MasterHistoryTable.Rows.Add(row);
                        }
                    }
                }
            }

            htcDashboard.SelectedIndex = 0;
            RefreshChartData();
            RefreshEquipmentChartData();
        }


        /*
         *   ------------------------------------------------------------
         *        <( Event handler for the "Profile" button click )>
         *   ------------------------------------------------------------
         */
        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            htcDashboard.SelectedIndex = 1;
        }


        /*
         *   --------------------------------------------------------------------
         *        <( Event handler for the "Crop Management" button click )>
         *   --------------------------------------------------------------------
         */
        private void btnCropPage_Click(object sender, EventArgs e)
        {
            // When the user clicks on the Crop Management tab, we want to load their crops from the database and display them in the DataGridView.
            RefreshGrid1();

            // After loading the crops from the database, we refresh the DataGridView to display them
            htcDashboard.SelectedIndex = 2;
        }


        /*
         *   -------------------------------------------------------------------------
         *        <( Event handler for the "Equipment Management" button click )>
         *   -------------------------------------------------------------------------
         */
        private void btnEquipPage_Click(object sender, EventArgs e)
        {
            RefreshGrid2();

            // After loading the equipment from the database, we refresh the DataGridView to display them
            htcDashboard.SelectedIndex = 3;
        }

        /*
         *   ------------------------------------------------------------------------------------------------------
         *        This method applies the combined filter logic to the MasterHistoryTable based on user inputs
         *   ------------------------------------------------------------------------------------------------------
         */
        private void ApplyMasterFilter()
        {
            // 1. Removed the accidental \r\n after the password
            string connString = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw;Database=defaultdb";

            List<string> whereClauses = new List<string>();
            var parameters = new Dictionary<string, object>();

            // Category Filter
            string selectedCategory = cmbSearchCategory.SelectedItem?.ToString();
            if (selectedCategory != "All Categories" && !string.IsNullOrEmpty(selectedCategory))
            {
                whereClauses.Add("Category = @Category");
                parameters.Add("@Category", selectedCategory);
            }

            // Search Text Filter
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText) && searchText != "Search items or actions...")
            {
                whereClauses.Add("(ItemName ILIKE @SearchText OR Action ILIKE @SearchText)");
                parameters.Add("@SearchText", $"%{searchText}%");
            }

            // 2. Account ID Filter: Added ::INT to keep CockroachDB happy!
            whereClauses.Add("AccountId = @AccountId::INT");
            parameters.Add("@AccountId", Convert.ToInt64(GlobalData.CurrentAccountId));

            // Construct Query
            string query = "SELECT * FROM historytable";
            if (whereClauses.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", whereClauses);
            }

            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            GlobalData.MasterHistoryTable.Clear();
                            while (reader.Read())
                            {
                                System.Data.DataRow row = GlobalData.MasterHistoryTable.NewRow();
                                row["LogDate"] = reader["LogDate"];
                                row["ItemName"] = reader["ItemName"];
                                row["Action"] = reader["Action"];
                                row["Category"] = reader["Category"];
                                row["TotalCost"] = reader["TotalCost"];
                                GlobalData.MasterHistoryTable.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        /*
         *   -------------------------------------------------------------
         *        <( Event handler for the "Add Crop" button click )>
         *   -------------------------------------------------------------
         */
        private void btnCropAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw;Database=defaultdb";

                using (var connection = new Npgsql.NpgsqlConnection(conn))
                {
                    connection.Open();

                    // When the user adds a new crop, we insert it into the database with all the relevant details, including the current account ID and timestamp
                    string insertQuery = "INSERT INTO crops (cropname, cropclassification, cropquantity, cropunitcost, dateadded, accountid) VALUES (@name, @classification, @quantity, @unitCost, @dateAdded, @accountId)";
                    using (var command = new Npgsql.NpgsqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtCropName.Text);
                        command.Parameters.AddWithValue("@classification", cmbCropClassification.SelectedItem?.ToString() ?? "");
                        command.Parameters.AddWithValue("@quantity", int.Parse(txtCropQuantity.Text));
                        command.Parameters.AddWithValue("@unitCost", double.Parse(txtCropUnitCost.Text));
                        command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                        command.Parameters.AddWithValue("@dateAdded", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }

                double totalCost = int.Parse(txtCropQuantity.Text) * double.Parse(txtCropUnitCost.Text);

                using (var connection = new Npgsql.NpgsqlConnection(conn))
                {
                    connection.Open();

                    // After adding the new crop to the database, we also want to log this action in the history table so it appears on the homepage log with all relevant details
                    string selectQuery = "INSERT INTO historytable (accountid, logdate, itemname, action, category, totalcost) VALUES (@accountId, @logDate, @name, @action, @category, @totalCost)";
                    using (var command = new Npgsql.NpgsqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                        command.Parameters.AddWithValue("@logDate", DateTime.Now);
                        command.Parameters.AddWithValue("@name", txtCropName.Text);
                        command.Parameters.AddWithValue("@action", "Added Stock");
                        command.Parameters.AddWithValue("@category", "Crops");
                        command.Parameters.AddWithValue("@totalCost", totalCost);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding crop: " + ex.Message);
                return;
            }
            RefreshGrid1();
            ClearInputs1();
            RefreshChartData();
            RefreshEquipmentChartData();
        }

        /*
         *   --------------------------------------------------------------------------------
         *        This method refreshes the DataGridView that displays the list of crops
         *   --------------------------------------------------------------------------------
         */
        private void RefreshGrid1()
        {
            dgvCrop.DataSource = null;

            string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw;Database=defaultdb";

            // We re-query the database to get the most up-to-date list of crops for the current user
            using (var connection = new Npgsql.NpgsqlConnection(conn))
            {
                connection.Open();
                string selectQuery = "SELECT cropname, cropclassification, cropquantity, cropunitcost FROM crops WHERE accountid = @accountId";
                using (var command = new Npgsql.NpgsqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                    using (var reader = command.ExecuteReader())
                    {
                        cropList.Clear();
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string classification = reader.GetString(1);
                            int quantity = reader.GetInt32(2);
                            double unitCost = reader.GetDouble(3);
                            Crops crop = new Crops(name, classification, quantity, unitCost);
                            cropList.Add(crop);
                        }
                    }
                }
            }

            dgvCrop.DataSource = cropList;
        }

        /*
         *   -----------------------------------------------------------------------------------------
         *        This method clears the input fields on the Crop Management tab and resets focus
         *   -----------------------------------------------------------------------------------------
         */
        private void ClearInputs1()
        {
            txtCropName.Clear();
            cmbCropClassification.SelectedIndex = -1;
            txtCropQuantity.Clear();
            txtCropUnitCost.Clear();
            txtCropName.Focus();
        }


        /*
         *   ------------------------------------------------------------------
         *        <( Event handler for the "Add Equipment" button click )>
         *   ------------------------------------------------------------------
         */
        private void btnEquipAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw;Database=defaultdb";

                using (var connection = new Npgsql.NpgsqlConnection(conn))
                {
                    connection.Open();

                    // When the user adds a new equipment, we insert it into the database with all the relevant details, including the current account ID and timestamp
                    string insertQuery = "INSERT INTO equipments (equipmentname, equipmentclassification, equipmentquantity, equipmentunitcost, dateadded, accountid) VALUES (@name, @classification, @quantity, @unitCost, @dateAdded, @accountId)";
                    using (var command = new Npgsql.NpgsqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtEquipName.Text);
                        command.Parameters.AddWithValue("@classification", cmbEquipClassification.SelectedItem?.ToString() ?? "");
                        command.Parameters.AddWithValue("@quantity", int.Parse(txtEquipQuantity.Text));
                        command.Parameters.AddWithValue("@unitCost", double.Parse(txtEquipUnitCost.Text));
                        command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                        command.Parameters.AddWithValue("@dateAdded", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }

                double totalCost = int.Parse(txtEquipQuantity.Text) * double.Parse(txtEquipUnitCost.Text);

                using (var connection = new Npgsql.NpgsqlConnection(conn))
                {
                    connection.Open();

                    // After adding the new equipment to the database, we also want to log this action in the history table so it appears on the homepage log with all relevant details
                    string selectQuery = "INSERT INTO historytable (accountid, logdate, itemname, action, category, totalcost) VALUES (@accountId, @logDate, @name, @action, @category, @totalCost)";
                    using (var command = new Npgsql.NpgsqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                        command.Parameters.AddWithValue("@logDate", DateTime.Now);
                        command.Parameters.AddWithValue("@name", txtEquipName.Text);
                        command.Parameters.AddWithValue("@action", "Added Stock");
                        command.Parameters.AddWithValue("@category", "Equipment");
                        command.Parameters.AddWithValue("@totalCost", totalCost);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding equipment: " + ex.Message);
                return;
            }
            RefreshGrid2();
            ClearInputs2();
            RefreshChartData();
            RefreshEquipmentChartData();
        }

        /*
         *   ------------------------------------------------------------------------------------
         *        This method refreshes the DataGridView that displays the list of equipment
         *   ------------------------------------------------------------------------------------
         */
        private void RefreshGrid2()
        {
            dgvEquipments.DataSource = null;

            string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw;Database=defaultdb";

            // We re-query the database to get the most up-to-date list of equipment for the current user
            using (var connection = new Npgsql.NpgsqlConnection(conn))
            {
                connection.Open();
                string selectQuery = "SELECT equipmentname, equipmentclassification, equipmentquantity, equipmentunitcost FROM equipments WHERE accountid = @accountId";
                using (var command = new Npgsql.NpgsqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        equipmentList.Clear();
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string classification = reader.GetString(1);
                            int quantity = reader.GetInt32(2);
                            double unitCost = reader.GetDouble(3);
                            Equipments equip = new Equipments(name, classification, quantity, unitCost);
                            equipmentList.Add(equip);
                        }
                    }
                }
            }

            dgvEquipments.DataSource = equipmentList;
        }

        /*
         *   ----------------------------------------------------------------------------------------------
         *        This method clears the input fields on the Equipment Management tab and resets focus
         *   ----------------------------------------------------------------------------------------------
         */
        private void ClearInputs2()
        {
            txtEquipName.Clear();
            cmbEquipClassification.SelectedIndex = -1;
            txtEquipQuantity.Clear();
            txtEquipUnitCost.Clear();
            txtEquipName.Focus();
        }


        /*
         *   ------------------------------------------------------------------------------------------------------------
         *        This method filters the MasterHistoryTable based on the date selected in the MonthCalendar control
         *   ------------------------------------------------------------------------------------------------------------
         */
        private void MCHomePage_DateChanged(object sender, DateRangeEventArgs e)
        {
            // 1. Grab the date the user just clicked (ignoring hours/minutes/seconds)
            DateTime selectedDate = MCHomePage.SelectionStart.Date;


            // 3. Apply the filter to your Global Data table
            string conn = "Host=server-esta-16103.jxf.gcp-asia-southeast1.cockroachlabs.cloud;Port=26257;Username=emmsj;Password=RDvETQvD0pA65aZUiWzbtw;Database=defaultdb";

            using (var connection = new Npgsql.NpgsqlConnection(conn))
            {
                connection.Open();
                // We also want to log this filter action in the history table so it appears on the homepage log with all relevant details
                string selectQuery = "SELECT logdate, itemname, action, category, totalcost FROM historytable WHERE accountid = @accountId AND logdate = @date";
                using (var command = new Npgsql.NpgsqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                    command.Parameters.AddWithValue("@date", selectedDate);

                    GlobalData.MasterHistoryTable.Clear();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataRow row = GlobalData.MasterHistoryTable.NewRow();
                            row["LogDate"] = reader["logdate"];
                            row["ItemName"] = reader["itemname"];
                            row["Action"] = reader["action"];
                            row["Category"] = reader["category"];
                            row["TotalCost"] = reader["totalcost"];
                            GlobalData.MasterHistoryTable.Rows.Add(row);
                        }
                    }
                }
            }
        }


        /*
         *   -----------------------------------------------------------------
         *        <( Event handler for the "Clear Filter" button click )>
         *   -----------------------------------------------------------------
         */
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearchCategory.SelectedIndex = 0;

            if (GlobalData.MasterHistoryTable != null)
            {
                // This instantly removes any date filter and shows your entire log history again
                GlobalData.MasterHistoryTable.DefaultView.RowFilter = string.Empty;
            }
        }


        /*
         *   -----------------------------------------------------------------------------------
         *        <( Event handlers for the search TextBox and category ComboBox changes )>
         *   -----------------------------------------------------------------------------------
         */
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyMasterFilter();
        }

        // Whenever the user changes the category filter, we re-apply the combined filter logic to update the displayed history records
        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyMasterFilter();
        }

        // <( Empty event handler for the crop classification ComboBox selection change - you can implement additional logic here if needed )>
        private void cmbCropClassification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();

            this.Hide();
            this.FormClosed += (s, args) => this.Close();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        /*
         *   ---------------------------------------------------------------------
         *        <( Event handler for the "Remove Equipment" button click )>
         *   ---------------------------------------------------------------------
         */
        private void btnEquipRemove_Click(object sender, EventArgs e)
        {
            if (dgvEquipments.SelectedRows.Count > 0)
            {
                // 2. Get the index of the selected row
                int rowIndex = dgvEquipments.SelectedRows[0].Index;
                Equipments itemToRemove = equipmentList[rowIndex];
                string name = itemToRemove.Name;
                double totalCost = itemToRemove.Quantity * itemToRemove.UnitCost;

                // 3. Grab the data of the item we are about to delete so we can log it
                // (Assuming your Crops class has public properties called Name, Quantity, and UnitCost)
                using (var connection = new Npgsql.NpgsqlConnection(connStr))
                {
                    connection.Open();

                    // --- QUERY 1: Delete the actual crop ---
                    // Added ::INT and Convert.ToInt64 to fix the type mismatch!
                    string deleteQuery = "DELETE FROM equipments WHERE equipmentname = @name AND accountid = @accountid::INT";
                    using (var deleteCommand = new Npgsql.NpgsqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@name", name);
                        deleteCommand.Parameters.AddWithValue("@accountid", Convert.ToInt64(GlobalData.CurrentAccountId));

                        // ExecuteNonQuery returns the number of rows it successfully deleted.
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Could not find the item in the database. It may have already been removed.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Stop the code right here so it doesn't update the UI
                        }
                    }

                    // --- QUERY 2: Log the removal to the history table ---
                    // Also added ::INT here just to be perfectly safe
                    string insertQuery = "INSERT INTO historytable (logdate, itemname, action, category, totalcost, accountid) " +
                                         "VALUES (@logdate, @itemname, @action, @category, @totalcost, @accountid::INT)";
                    using (var historyCommand = new Npgsql.NpgsqlCommand(insertQuery, connection))
                    {
                        historyCommand.Parameters.AddWithValue("@logdate", DateTime.Now);
                        historyCommand.Parameters.AddWithValue("@itemname", name);
                        historyCommand.Parameters.AddWithValue("@action", "Removed Stock");
                        historyCommand.Parameters.AddWithValue("@category", "Equipments");
                        historyCommand.Parameters.AddWithValue("@totalcost", totalCost);
                        historyCommand.Parameters.AddWithValue("@accountid", Convert.ToInt64(GlobalData.CurrentAccountId));

                        historyCommand.ExecuteNonQuery();
                    }
                }

                // 2. NOW that the database is happy, update the UI!
                // Temporarily unbind to prevent the Index 0 crash, remove the item, then refresh.
                dgvEquipments.DataSource = null;
                equipmentList.RemoveAt(rowIndex);
                RefreshGrid2();

                // 3. Update the local Master History table for the Dashboard
                GlobalData.InitializeSchema();
                GlobalData.MasterHistoryTable.Rows.Add(
                    DateTime.Now,
                    name,
                    "Removed Stock",
                    "Equipments",
                    totalCost
                );
            }
            else
            {
                MessageBox.Show("Please select an entire row to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /*
         *   ----------------------------------------------------------------
         *        <( Event handler for the "Remove Crop" button click )>
         *   ----------------------------------------------------------------
         */
        private void btnCropRemove_Click(object sender, EventArgs e)
        {
            if (dgvCrop.SelectedRows.Count > 0)
            {
                // 2. Get the index of the selected row
                int rowIndex = dgvCrop.SelectedRows[0].Index;
                Crops itemToRemove = cropList[rowIndex];
                string name = itemToRemove.Name;
                double totalCost = itemToRemove.Quantity * itemToRemove.UnitCost;

                // 3. Grab the data of the item we are about to delete so we can log it
                // (Assuming your Crops class has public properties called Name, Quantity, and UnitCost)
                using (var connection = new Npgsql.NpgsqlConnection(connStr))
                {
                    connection.Open();

                    // --- QUERY 1: Delete the actual crop ---
                    // Added ::INT and Convert.ToInt64 to fix the type mismatch!
                    string deleteQuery = "DELETE FROM crops WHERE cropname = @name AND accountid = @accountid::INT";
                    using (var deleteCommand = new Npgsql.NpgsqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@name", name);
                        deleteCommand.Parameters.AddWithValue("@accountid", Convert.ToInt64(GlobalData.CurrentAccountId));

                        // ExecuteNonQuery returns the number of rows it successfully deleted.
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Could not find the item in the database. It may have already been removed.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Stop the code right here so it doesn't update the UI
                        }
                    }

                    // --- QUERY 2: Log the removal to the history table ---
                    // Also added ::INT here just to be perfectly safe
                    string insertQuery = "INSERT INTO historytable (logdate, itemname, action, category, totalcost, accountid) " +
                                         "VALUES (@logdate, @itemname, @action, @category, @totalcost, @accountid::INT)";
                    using (var historyCommand = new Npgsql.NpgsqlCommand(insertQuery, connection))
                    {
                        historyCommand.Parameters.AddWithValue("@logdate", DateTime.Now);
                        historyCommand.Parameters.AddWithValue("@itemname", name);
                        historyCommand.Parameters.AddWithValue("@action", "Removed Stock");
                        historyCommand.Parameters.AddWithValue("@category", "Crops");
                        historyCommand.Parameters.AddWithValue("@totalcost", totalCost);
                        historyCommand.Parameters.AddWithValue("@accountid", Convert.ToInt64(GlobalData.CurrentAccountId));

                        historyCommand.ExecuteNonQuery();
                    }
                }

                // 2. NOW that the database is happy, update the UI!
                // Temporarily unbind to prevent the Index 0 crash, remove the item, then refresh.
                dgvCrop.DataSource = null;
                cropList.RemoveAt(rowIndex);
                RefreshGrid1();

                // 3. Update the local Master History table for the Dashboard
                GlobalData.InitializeSchema();
                GlobalData.MasterHistoryTable.Rows.Add(
                    DateTime.Now,
                    name,
                    "Removed Stock",
                    "Crops",
                    totalCost
                );
            }
            else
            {
                MessageBox.Show("Please select an entire row to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /*   -------------------------------------------------------------------------------------------------
         *               Event handler for when the user clicks on different tabs in the dashboard
         *        we will use this to trigger loading of profile info when they click on the Profile tab.
         *   -------------------------------------------------------------------------------------------------
         */
        private void htcDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (htcDashboard.SelectedTab == tabProfilePage)
            {
                // Only run the database query if the label is still empty (or says "Unknown")
                // This prevents querying the database EVERY single time they click back and forth.
                if (lblUsernameShow.Text == "Label" || lblUsernameShow.Text == "" || lblUsernameShow.Text.EndsWith("Label"))
                {
                    using (var connection = new Npgsql.NpgsqlConnection(connStr))
                    {
                        connection.Open();
                        string query = "SELECT username FROM accounts WHERE accountid = @accountId::INT";

                        using (var command = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@accountId", Convert.ToInt64(GlobalData.CurrentAccountId));
                            object result = command.ExecuteScalar();

                            if (result != null)
                            {
                                lblUsernameShow.Text = result.ToString();
                                lblUserIDShow.Text = GlobalData.CurrentAccountId.ToString();
                            }
                            else
                            {
                                lblUsernameShow.Text = "Unknown User";
                                lblUserIDShow.Text = "Unknown User";
                            }
                        }
                    }
                }
            }
        }
    }
}