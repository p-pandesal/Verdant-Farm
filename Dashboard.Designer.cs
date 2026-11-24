namespace VerdantFarm
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pnlTabs = new Panel();
            lblEquipments = new Label();
            btnEquipPage = new Button();
            lblProfilePage = new Label();
            lblCrops = new Label();
            lblHomePage = new Label();
            btnCropPage = new Button();
            btnProfilePage = new Button();
            btnHomePage = new Button();
            htcDashboard = new HiddenTabControl();
            tabHomePage = new TabPage();
            cmbSearchCategory = new ComboBox();
            txtSearch = new TextBox();
            btnClearFilter = new Button();
            MCHomePage = new MonthCalendar();
            dgvHistory = new DataGridView();
            tabProfilePage = new TabPage();
            panel3 = new Panel();
            lblUserIDShow = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblUsernameShow = new Label();
            lblUsernameProfilePage = new Label();
            btnLogOut = new Button();
            pictureBox1 = new PictureBox();
            tabCropPage = new TabPage();
            label2 = new Label();
            btnCropRemove = new Button();
            dgvCrop = new DataGridView();
            cmbCropClassification = new ComboBox();
            btnCropAdd = new Button();
            txtCropUnitCost = new TextBox();
            txtCropQuantity = new TextBox();
            lblCropUnitCost = new Label();
            lblCropQuantity = new Label();
            lblCropClassification = new Label();
            txtCropName = new TextBox();
            lblCropName = new Label();
            tabEquipPage = new TabPage();
            label3 = new Label();
            btnEquipRemove = new Button();
            dgvEquipments = new DataGridView();
            cmbEquipClassification = new ComboBox();
            btnEquipAdd = new Button();
            txtEquipUnitCost = new TextBox();
            txtEquipQuantity = new TextBox();
            lblEquipUnitCost = new Label();
            lblEquipQuantity = new Label();
            lblEquipClassification = new Label();
            txtEquipName = new TextBox();
            lblEquipName = new Label();
            panel1 = new Panel();
            pnlTabs.SuspendLayout();
            htcDashboard.SuspendLayout();
            tabHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            tabProfilePage.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabCropPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCrop).BeginInit();
            tabEquipPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipments).BeginInit();
            SuspendLayout();
            // 
            // pnlTabs
            // 
            pnlTabs.BackColor = Color.FromArgb(213, 214, 199);
            pnlTabs.Controls.Add(lblEquipments);
            pnlTabs.Controls.Add(btnEquipPage);
            pnlTabs.Controls.Add(lblProfilePage);
            pnlTabs.Controls.Add(lblCrops);
            pnlTabs.Controls.Add(lblHomePage);
            pnlTabs.Controls.Add(btnCropPage);
            pnlTabs.Controls.Add(btnProfilePage);
            pnlTabs.Controls.Add(btnHomePage);
            pnlTabs.Location = new Point(12, 88);
            pnlTabs.Name = "pnlTabs";
            pnlTabs.Size = new Size(71, 558);
            pnlTabs.TabIndex = 0;
            // 
            // lblEquipments
            // 
            lblEquipments.AutoSize = true;
            lblEquipments.ForeColor = Color.Black;
            lblEquipments.Location = new Point(1, 196);
            lblEquipments.Name = "lblEquipments";
            lblEquipments.Size = new Size(70, 15);
            lblEquipments.TabIndex = 7;
            lblEquipments.Text = "Equipments";
            // 
            // btnEquipPage
            // 
            btnEquipPage.BackColor = Color.FromArgb(22, 85, 59);
            btnEquipPage.BackgroundImage = Properties.Resources.equipment;
            btnEquipPage.BackgroundImageLayout = ImageLayout.Zoom;
            btnEquipPage.FlatAppearance.BorderSize = 0;
            btnEquipPage.FlatStyle = FlatStyle.Flat;
            btnEquipPage.Location = new Point(12, 154);
            btnEquipPage.Name = "btnEquipPage";
            btnEquipPage.Size = new Size(47, 39);
            btnEquipPage.TabIndex = 6;
            btnEquipPage.UseVisualStyleBackColor = false;
            btnEquipPage.Click += btnEquipPage_Click;
            // 
            // lblProfilePage
            // 
            lblProfilePage.AutoSize = true;
            lblProfilePage.ForeColor = Color.Black;
            lblProfilePage.Location = new Point(16, 532);
            lblProfilePage.Name = "lblProfilePage";
            lblProfilePage.Size = new Size(41, 15);
            lblProfilePage.TabIndex = 5;
            lblProfilePage.Text = "Profile";
            // 
            // lblCrops
            // 
            lblCrops.AutoSize = true;
            lblCrops.ForeColor = Color.Black;
            lblCrops.Location = new Point(17, 125);
            lblCrops.Name = "lblCrops";
            lblCrops.Size = new Size(38, 15);
            lblCrops.TabIndex = 4;
            lblCrops.Text = "Crops";
            // 
            // lblHomePage
            // 
            lblHomePage.AutoSize = true;
            lblHomePage.ForeColor = Color.Black;
            lblHomePage.Location = new Point(16, 54);
            lblHomePage.Name = "lblHomePage";
            lblHomePage.Size = new Size(40, 15);
            lblHomePage.TabIndex = 3;
            lblHomePage.Text = "Home";
            // 
            // btnCropPage
            // 
            btnCropPage.BackColor = Color.FromArgb(22, 85, 59);
            btnCropPage.BackgroundImage = Properties.Resources.crops;
            btnCropPage.BackgroundImageLayout = ImageLayout.Zoom;
            btnCropPage.FlatAppearance.BorderSize = 0;
            btnCropPage.FlatStyle = FlatStyle.Flat;
            btnCropPage.Location = new Point(12, 83);
            btnCropPage.Name = "btnCropPage";
            btnCropPage.Size = new Size(47, 39);
            btnCropPage.TabIndex = 2;
            btnCropPage.UseVisualStyleBackColor = false;
            btnCropPage.Click += btnCropPage_Click;
            // 
            // btnProfilePage
            // 
            btnProfilePage.BackColor = Color.FromArgb(22, 85, 59);
            btnProfilePage.BackgroundImage = Properties.Resources.account_profile_user_icon_190494;
            btnProfilePage.BackgroundImageLayout = ImageLayout.Zoom;
            btnProfilePage.FlatAppearance.BorderSize = 0;
            btnProfilePage.FlatStyle = FlatStyle.Flat;
            btnProfilePage.Location = new Point(12, 490);
            btnProfilePage.Name = "btnProfilePage";
            btnProfilePage.Size = new Size(47, 39);
            btnProfilePage.TabIndex = 1;
            btnProfilePage.UseVisualStyleBackColor = false;
            btnProfilePage.Click += btnProfilePage_Click;
            // 
            // btnHomePage
            // 
            btnHomePage.BackColor = Color.FromArgb(22, 85, 59);
            btnHomePage.BackgroundImage = Properties.Resources.house_icon_png_white_32;
            btnHomePage.BackgroundImageLayout = ImageLayout.Zoom;
            btnHomePage.FlatAppearance.BorderSize = 0;
            btnHomePage.FlatStyle = FlatStyle.Flat;
            btnHomePage.Location = new Point(12, 12);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(47, 39);
            btnHomePage.TabIndex = 0;
            btnHomePage.UseVisualStyleBackColor = false;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // htcDashboard
            // 
            htcDashboard.Controls.Add(tabHomePage);
            htcDashboard.Controls.Add(tabProfilePage);
            htcDashboard.Controls.Add(tabCropPage);
            htcDashboard.Controls.Add(tabEquipPage);
            htcDashboard.Location = new Point(89, 88);
            htcDashboard.Name = "htcDashboard";
            htcDashboard.SelectedIndex = 0;
            htcDashboard.Size = new Size(1036, 570);
            htcDashboard.TabIndex = 1;
            htcDashboard.SelectedIndexChanged += htcDashboard_SelectedIndexChanged;
            // 
            // tabHomePage
            // 
            tabHomePage.BackColor = Color.FromArgb(249, 250, 238);
            tabHomePage.Controls.Add(cmbSearchCategory);
            tabHomePage.Controls.Add(txtSearch);
            tabHomePage.Controls.Add(btnClearFilter);
            tabHomePage.Controls.Add(MCHomePage);
            tabHomePage.Controls.Add(dgvHistory);
            tabHomePage.Location = new Point(4, 24);
            tabHomePage.Name = "tabHomePage";
            tabHomePage.Padding = new Padding(3);
            tabHomePage.Size = new Size(1028, 542);
            tabHomePage.TabIndex = 0;
            tabHomePage.Text = "HomePage";
            // 
            // cmbSearchCategory
            // 
            cmbSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchCategory.FormattingEnabled = true;
            cmbSearchCategory.Location = new Point(232, 187);
            cmbSearchCategory.Name = "cmbSearchCategory";
            cmbSearchCategory.Size = new Size(130, 23);
            cmbSearchCategory.TabIndex = 4;
            cmbSearchCategory.Tag = "";
            cmbSearchCategory.SelectedIndexChanged += cmbSearchCategory_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 187);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Items or actions...";
            txtSearch.Size = new Size(220, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(22, 85, 59);
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.Location = new Point(851, 183);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(128, 27);
            btnClearFilter.TabIndex = 2;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // MCHomePage
            // 
            MCHomePage.BackColor = Color.FromArgb(213, 214, 199);
            MCHomePage.Location = new Point(793, 12);
            MCHomePage.Name = "MCHomePage";
            MCHomePage.TabIndex = 1;
            MCHomePage.DateChanged += MCHomePage_DateChanged;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.FromArgb(213, 214, 199);
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(6, 216);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(1014, 320);
            dgvHistory.TabIndex = 0;
            // 
            // tabProfilePage
            // 
            tabProfilePage.BackColor = Color.FromArgb(249, 250, 238);
            tabProfilePage.Controls.Add(panel3);
            tabProfilePage.Controls.Add(panel2);
            tabProfilePage.Controls.Add(btnLogOut);
            tabProfilePage.Controls.Add(pictureBox1);
            tabProfilePage.Location = new Point(4, 24);
            tabProfilePage.Name = "tabProfilePage";
            tabProfilePage.Padding = new Padding(3);
            tabProfilePage.Size = new Size(1028, 542);
            tabProfilePage.TabIndex = 1;
            tabProfilePage.Text = "ProfilePage";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(213, 214, 199);
            panel3.Controls.Add(lblUserIDShow);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(217, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 48);
            panel3.TabIndex = 10;
            // 
            // lblUserIDShow
            // 
            lblUserIDShow.Location = new Point(72, 10);
            lblUserIDShow.Name = "lblUserIDShow";
            lblUserIDShow.Size = new Size(160, 29);
            lblUserIDShow.TabIndex = 2;
            lblUserIDShow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 1;
            label4.Text = "Account ID:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(213, 214, 199);
            panel2.Controls.Add(lblUsernameShow);
            panel2.Controls.Add(lblUsernameProfilePage);
            panel2.Location = new Point(217, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 48);
            panel2.TabIndex = 9;
            // 
            // lblUsernameShow
            // 
            lblUsernameShow.Location = new Point(63, 10);
            lblUsernameShow.Name = "lblUsernameShow";
            lblUsernameShow.Size = new Size(64, 29);
            lblUsernameShow.TabIndex = 2;
            lblUsernameShow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsernameProfilePage
            // 
            lblUsernameProfilePage.Location = new Point(3, 10);
            lblUsernameProfilePage.Name = "lblUsernameProfilePage";
            lblUsernameProfilePage.Size = new Size(64, 29);
            lblUsernameProfilePage.TabIndex = 1;
            lblUsernameProfilePage.Text = "Username:";
            lblUsernameProfilePage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(22, 85, 59);
            btnLogOut.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(17, 496);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(120, 37);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(213, 214, 199);
            pictureBox1.Image = Properties.Resources.profile_icon_for_profile_page_removebg_preview;
            pictureBox1.Location = new Point(17, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabCropPage
            // 
            tabCropPage.BackColor = Color.FromArgb(249, 250, 238);
            tabCropPage.Controls.Add(label2);
            tabCropPage.Controls.Add(btnCropRemove);
            tabCropPage.Controls.Add(dgvCrop);
            tabCropPage.Controls.Add(cmbCropClassification);
            tabCropPage.Controls.Add(btnCropAdd);
            tabCropPage.Controls.Add(txtCropUnitCost);
            tabCropPage.Controls.Add(txtCropQuantity);
            tabCropPage.Controls.Add(lblCropUnitCost);
            tabCropPage.Controls.Add(lblCropQuantity);
            tabCropPage.Controls.Add(lblCropClassification);
            tabCropPage.Controls.Add(txtCropName);
            tabCropPage.Controls.Add(lblCropName);
            tabCropPage.Location = new Point(4, 24);
            tabCropPage.Name = "tabCropPage";
            tabCropPage.Size = new Size(1028, 542);
            tabCropPage.TabIndex = 2;
            tabCropPage.Text = "CropPage";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 85, 59);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 12;
            label2.Text = "Crops";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCropRemove
            // 
            btnCropRemove.BackColor = Color.FromArgb(22, 85, 59);
            btnCropRemove.FlatAppearance.BorderSize = 0;
            btnCropRemove.FlatStyle = FlatStyle.Flat;
            btnCropRemove.ForeColor = Color.White;
            btnCropRemove.Location = new Point(310, 477);
            btnCropRemove.Name = "btnCropRemove";
            btnCropRemove.Size = new Size(103, 34);
            btnCropRemove.TabIndex = 11;
            btnCropRemove.Text = "Remove";
            btnCropRemove.UseVisualStyleBackColor = false;
            btnCropRemove.Click += btnCropRemove_Click;
            // 
            // dgvCrop
            // 
            dgvCrop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCrop.BackgroundColor = Color.FromArgb(213, 214, 199);
            dgvCrop.BorderStyle = BorderStyle.None;
            dgvCrop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCrop.Location = new Point(3, 59);
            dgvCrop.Name = "dgvCrop";
            dgvCrop.ReadOnly = true;
            dgvCrop.RowHeadersVisible = false;
            dgvCrop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCrop.Size = new Size(715, 348);
            dgvCrop.TabIndex = 10;
            // 
            // cmbCropClassification
            // 
            cmbCropClassification.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCropClassification.FormattingEnabled = true;
            cmbCropClassification.Items.AddRange(new object[] { "Fruits", "Vegetables", "Grains", "Oilseeds" });
            cmbCropClassification.Location = new Point(113, 448);
            cmbCropClassification.Name = "cmbCropClassification";
            cmbCropClassification.Size = new Size(151, 23);
            cmbCropClassification.TabIndex = 9;
            cmbCropClassification.SelectedIndexChanged += cmbCropClassification_SelectedIndexChanged;
            // 
            // btnCropAdd
            // 
            btnCropAdd.BackColor = Color.FromArgb(22, 85, 59);
            btnCropAdd.FlatAppearance.BorderSize = 0;
            btnCropAdd.FlatStyle = FlatStyle.Flat;
            btnCropAdd.ForeColor = Color.White;
            btnCropAdd.Location = new Point(201, 477);
            btnCropAdd.Name = "btnCropAdd";
            btnCropAdd.Size = new Size(103, 34);
            btnCropAdd.TabIndex = 8;
            btnCropAdd.Text = "Add";
            btnCropAdd.UseVisualStyleBackColor = false;
            btnCropAdd.Click += btnCropAdd_Click;
            // 
            // txtCropUnitCost
            // 
            txtCropUnitCost.Location = new Point(442, 449);
            txtCropUnitCost.Name = "txtCropUnitCost";
            txtCropUnitCost.Size = new Size(147, 23);
            txtCropUnitCost.TabIndex = 7;
            // 
            // txtCropQuantity
            // 
            txtCropQuantity.Location = new Point(438, 412);
            txtCropQuantity.Name = "txtCropQuantity";
            txtCropQuantity.Size = new Size(151, 23);
            txtCropQuantity.TabIndex = 6;
            // 
            // lblCropUnitCost
            // 
            lblCropUnitCost.AutoSize = true;
            lblCropUnitCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCropUnitCost.Location = new Point(359, 447);
            lblCropUnitCost.Name = "lblCropUnitCost";
            lblCropUnitCost.Size = new Size(77, 21);
            lblCropUnitCost.TabIndex = 5;
            lblCropUnitCost.Text = "Unit Cost:";
            // 
            // lblCropQuantity
            // 
            lblCropQuantity.AutoSize = true;
            lblCropQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCropQuantity.Location = new Point(359, 410);
            lblCropQuantity.Name = "lblCropQuantity";
            lblCropQuantity.Size = new Size(73, 21);
            lblCropQuantity.TabIndex = 4;
            lblCropQuantity.Text = "Quantity:";
            // 
            // lblCropClassification
            // 
            lblCropClassification.AutoSize = true;
            lblCropClassification.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCropClassification.Location = new Point(3, 446);
            lblCropClassification.Name = "lblCropClassification";
            lblCropClassification.Size = new Size(104, 21);
            lblCropClassification.TabIndex = 2;
            lblCropClassification.Text = "Classification:";
            // 
            // txtCropName
            // 
            txtCropName.Location = new Point(64, 412);
            txtCropName.Name = "txtCropName";
            txtCropName.Size = new Size(200, 23);
            txtCropName.TabIndex = 1;
            // 
            // lblCropName
            // 
            lblCropName.AutoSize = true;
            lblCropName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCropName.Location = new Point(3, 410);
            lblCropName.Name = "lblCropName";
            lblCropName.Size = new Size(55, 21);
            lblCropName.TabIndex = 0;
            lblCropName.Text = "Name:";
            // 
            // tabEquipPage
            // 
            tabEquipPage.BackColor = Color.FromArgb(249, 250, 238);
            tabEquipPage.Controls.Add(label3);
            tabEquipPage.Controls.Add(btnEquipRemove);
            tabEquipPage.Controls.Add(dgvEquipments);
            tabEquipPage.Controls.Add(cmbEquipClassification);
            tabEquipPage.Controls.Add(btnEquipAdd);
            tabEquipPage.Controls.Add(txtEquipUnitCost);
            tabEquipPage.Controls.Add(txtEquipQuantity);
            tabEquipPage.Controls.Add(lblEquipUnitCost);
            tabEquipPage.Controls.Add(lblEquipQuantity);
            tabEquipPage.Controls.Add(lblEquipClassification);
            tabEquipPage.Controls.Add(txtEquipName);
            tabEquipPage.Controls.Add(lblEquipName);
            tabEquipPage.Location = new Point(4, 24);
            tabEquipPage.Name = "tabEquipPage";
            tabEquipPage.Size = new Size(1028, 542);
            tabEquipPage.TabIndex = 3;
            tabEquipPage.Text = "EquipPage";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 85, 59);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 22;
            label3.Text = "Equipments";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEquipRemove
            // 
            btnEquipRemove.BackColor = Color.FromArgb(22, 85, 59);
            btnEquipRemove.FlatAppearance.BorderSize = 0;
            btnEquipRemove.FlatStyle = FlatStyle.Flat;
            btnEquipRemove.ForeColor = Color.White;
            btnEquipRemove.Location = new Point(310, 477);
            btnEquipRemove.Name = "btnEquipRemove";
            btnEquipRemove.Size = new Size(103, 34);
            btnEquipRemove.TabIndex = 21;
            btnEquipRemove.Text = "Remove";
            btnEquipRemove.UseVisualStyleBackColor = false;
            btnEquipRemove.Click += btnEquipRemove_Click;
            // 
            // dgvEquipments
            // 
            dgvEquipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipments.BackgroundColor = Color.FromArgb(213, 214, 199);
            dgvEquipments.BorderStyle = BorderStyle.None;
            dgvEquipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipments.Location = new Point(3, 59);
            dgvEquipments.Name = "dgvEquipments";
            dgvEquipments.ReadOnly = true;
            dgvEquipments.RowHeadersVisible = false;
            dgvEquipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipments.Size = new Size(715, 348);
            dgvEquipments.TabIndex = 20;
            // 
            // cmbEquipClassification
            // 
            cmbEquipClassification.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipClassification.FormattingEnabled = true;
            cmbEquipClassification.Items.AddRange(new object[] { "Heavy Machinery", "Implements & Attachments", "Hand Tools", "Irrigation & Sprayers" });
            cmbEquipClassification.Location = new Point(113, 448);
            cmbEquipClassification.Name = "cmbEquipClassification";
            cmbEquipClassification.Size = new Size(151, 23);
            cmbEquipClassification.TabIndex = 19;
            // 
            // btnEquipAdd
            // 
            btnEquipAdd.BackColor = Color.FromArgb(22, 85, 59);
            btnEquipAdd.FlatAppearance.BorderSize = 0;
            btnEquipAdd.FlatStyle = FlatStyle.Flat;
            btnEquipAdd.ForeColor = Color.White;
            btnEquipAdd.Location = new Point(201, 477);
            btnEquipAdd.Name = "btnEquipAdd";
            btnEquipAdd.Size = new Size(103, 34);
            btnEquipAdd.TabIndex = 18;
            btnEquipAdd.Text = "Add";
            btnEquipAdd.UseVisualStyleBackColor = false;
            btnEquipAdd.Click += btnEquipAdd_Click;
            // 
            // txtEquipUnitCost
            // 
            txtEquipUnitCost.Location = new Point(442, 449);
            txtEquipUnitCost.Name = "txtEquipUnitCost";
            txtEquipUnitCost.Size = new Size(147, 23);
            txtEquipUnitCost.TabIndex = 17;
            // 
            // txtEquipQuantity
            // 
            txtEquipQuantity.Location = new Point(438, 412);
            txtEquipQuantity.Name = "txtEquipQuantity";
            txtEquipQuantity.Size = new Size(151, 23);
            txtEquipQuantity.TabIndex = 16;
            // 
            // lblEquipUnitCost
            // 
            lblEquipUnitCost.AutoSize = true;
            lblEquipUnitCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquipUnitCost.Location = new Point(359, 447);
            lblEquipUnitCost.Name = "lblEquipUnitCost";
            lblEquipUnitCost.Size = new Size(77, 21);
            lblEquipUnitCost.TabIndex = 15;
            lblEquipUnitCost.Text = "Unit Cost:";
            // 
            // lblEquipQuantity
            // 
            lblEquipQuantity.AutoSize = true;
            lblEquipQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquipQuantity.Location = new Point(359, 410);
            lblEquipQuantity.Name = "lblEquipQuantity";
            lblEquipQuantity.Size = new Size(73, 21);
            lblEquipQuantity.TabIndex = 14;
            lblEquipQuantity.Text = "Quantity:";
            // 
            // lblEquipClassification
            // 
            lblEquipClassification.AutoSize = true;
            lblEquipClassification.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquipClassification.Location = new Point(3, 446);
            lblEquipClassification.Name = "lblEquipClassification";
            lblEquipClassification.Size = new Size(104, 21);
            lblEquipClassification.TabIndex = 13;
            lblEquipClassification.Text = "Classification:";
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(64, 412);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(200, 23);
            txtEquipName.TabIndex = 12;
            // 
            // lblEquipName
            // 
            lblEquipName.AutoSize = true;
            lblEquipName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquipName.Location = new Point(3, 410);
            lblEquipName.Name = "lblEquipName";
            lblEquipName.Size = new Size(55, 21);
            lblEquipName.TabIndex = 11;
            lblEquipName.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 85, 59);
            panel1.BackgroundImage = Properties.Resources._360_F_230653258_1SCEgR7iyZLpxP7T8pDPqaPIfHFtl6Qd;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 82);
            panel1.TabIndex = 8;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 238);
            ClientSize = new Size(1125, 658);
            Controls.Add(panel1);
            Controls.Add(htcDashboard);
            Controls.Add(pnlTabs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            FormClosed += Dashboard_FormClosed;
            Load += Dashboard_Load;
            pnlTabs.ResumeLayout(false);
            pnlTabs.PerformLayout();
            htcDashboard.ResumeLayout(false);
            tabHomePage.ResumeLayout(false);
            tabHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            tabProfilePage.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabCropPage.ResumeLayout(false);
            tabCropPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCrop).EndInit();
            tabEquipPage.ResumeLayout(false);
            tabEquipPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTabs;
        private Button btnHomePage;
        private Button btnProfilePage;
        private HiddenTabControl htcDashboard;
        private TabPage tabHomePage;
        private TabPage tabProfilePage;
        private DataGridView dgvHistory;
        private Button btnCropPage;
        private Label lblProfilePage;
        private Label lblCrops;
        private Label lblHomePage;
        private TabPage tabCropPage;
        private MonthCalendar MCHomePage;
        private Label lblCropClassification;
        private TextBox txtCropName;
        private Label lblCropName;
        private Label lblCropQuantity;
        private Button btnCropAdd;
        private TextBox txtCropUnitCost;
        private TextBox txtCropQuantity;
        private Label lblCropUnitCost;
        private ComboBox cmbCropClassification;
        private DataGridView dgvCrop;
        private Label lblEquipments;
        private Button btnEquipPage;
        private TabPage tabEquipPage;
        private DataGridView dgvEquipments;
        private ComboBox cmbEquipClassification;
        private Button btnEquipAdd;
        private TextBox txtEquipUnitCost;
        private TextBox txtEquipQuantity;
        private Label lblEquipUnitCost;
        private Label lblEquipQuantity;
        private Label lblEquipClassification;
        private TextBox txtEquipName;
        private Label lblEquipName;
        private Button btnClearFilter;
        private TextBox txtSearch;
        private ComboBox cmbSearchCategory;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblUsernameProfilePage;
        private Button btnLogOut;
        private Button btnCropRemove;
        private Button btnEquipRemove;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label lblUsernameShow;
        private Panel panel3;
        private Label lblUserIDShow;
        private Label label4;
    }
}