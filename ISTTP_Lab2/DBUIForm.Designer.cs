namespace ISTTP_Lab2
{
    partial class DBUIForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBUIForm));
            this.tabTitles = new System.Windows.Forms.TabPage();
            this.titlesDeleteBtn = new System.Windows.Forms.Button();
            this.titlesSaveBtn = new System.Windows.Forms.Button();
            this.dGVTitles = new System.Windows.Forms.DataGridView();
            this.titleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.federationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.federationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubHasTitlesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.federationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerHasTitlesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.playersDeleteBtn = new System.Windows.Forms.Button();
            this.playersSaveBtn = new System.Windows.Forms.Button();
            this.dGVPlayers = new System.Windows.Forms.DataGridView();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heightCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerHasTitlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabClubs = new System.Windows.Forms.TabPage();
            this.deleteClubBtn = new System.Windows.Forms.Button();
            this.saveClubBtn = new System.Windows.Forms.Button();
            this.dGVClubs = new System.Windows.Forms.DataGridView();
            this.clubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfFoundationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leagueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.leagueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubHasTitlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leagueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabLeagues = new System.Windows.Forms.TabPage();
            this.leaguesDeleteBtn = new System.Windows.Forms.Button();
            this.leaguesSaveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leagueNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leagueLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberOfCLPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leagueIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubsSearchBtn = new System.Windows.Forms.Button();
            this.tabTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.federationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            this.tabPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.tabClubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.tabLeagues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTitles
            // 
            this.tabTitles.Controls.Add(this.titlesDeleteBtn);
            this.tabTitles.Controls.Add(this.titlesSaveBtn);
            this.tabTitles.Controls.Add(this.dGVTitles);
            resources.ApplyResources(this.tabTitles, "tabTitles");
            this.tabTitles.Name = "tabTitles";
            this.tabTitles.UseVisualStyleBackColor = true;
            // 
            // titlesDeleteBtn
            // 
            resources.ApplyResources(this.titlesDeleteBtn, "titlesDeleteBtn");
            this.titlesDeleteBtn.Name = "titlesDeleteBtn";
            this.titlesDeleteBtn.UseVisualStyleBackColor = true;
            this.titlesDeleteBtn.Click += new System.EventHandler(this.titlesDeleteBtn_Click);
            // 
            // titlesSaveBtn
            // 
            resources.ApplyResources(this.titlesSaveBtn, "titlesSaveBtn");
            this.titlesSaveBtn.Name = "titlesSaveBtn";
            this.titlesSaveBtn.UseVisualStyleBackColor = true;
            this.titlesSaveBtn.Click += new System.EventHandler(this.titlesSaveBtn_Click);
            // 
            // dGVTitles
            // 
            resources.ApplyResources(this.dGVTitles, "dGVTitles");
            this.dGVTitles.AutoGenerateColumns = false;
            this.dGVTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTitles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleNameDataGridViewTextBoxColumn,
            this.federationIDDataGridViewTextBoxColumn,
            this.clubHasTitlesDataGridViewTextBoxColumn1,
            this.federationDataGridViewTextBoxColumn,
            this.playerHasTitlesDataGridViewTextBoxColumn1,
            this.titleIDDataGridViewTextBoxColumn});
            this.dGVTitles.DataSource = this.titleBindingSource;
            this.dGVTitles.Name = "dGVTitles";
            this.dGVTitles.RowTemplate.Height = 33;
            // 
            // titleNameDataGridViewTextBoxColumn
            // 
            this.titleNameDataGridViewTextBoxColumn.DataPropertyName = "TitleName";
            resources.ApplyResources(this.titleNameDataGridViewTextBoxColumn, "titleNameDataGridViewTextBoxColumn");
            this.titleNameDataGridViewTextBoxColumn.Name = "titleNameDataGridViewTextBoxColumn";
            // 
            // federationIDDataGridViewTextBoxColumn
            // 
            this.federationIDDataGridViewTextBoxColumn.DataPropertyName = "FederationID";
            this.federationIDDataGridViewTextBoxColumn.DataSource = this.federationBindingSource;
            this.federationIDDataGridViewTextBoxColumn.DisplayMember = "FederationName";
            resources.ApplyResources(this.federationIDDataGridViewTextBoxColumn, "federationIDDataGridViewTextBoxColumn");
            this.federationIDDataGridViewTextBoxColumn.Name = "federationIDDataGridViewTextBoxColumn";
            this.federationIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.federationIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.federationIDDataGridViewTextBoxColumn.ValueMember = "FederationID";
            // 
            // federationBindingSource
            // 
            this.federationBindingSource.DataSource = typeof(FCDataEF.Federation);
            // 
            // clubHasTitlesDataGridViewTextBoxColumn1
            // 
            this.clubHasTitlesDataGridViewTextBoxColumn1.DataPropertyName = "ClubHasTitles";
            resources.ApplyResources(this.clubHasTitlesDataGridViewTextBoxColumn1, "clubHasTitlesDataGridViewTextBoxColumn1");
            this.clubHasTitlesDataGridViewTextBoxColumn1.Name = "clubHasTitlesDataGridViewTextBoxColumn1";
            // 
            // federationDataGridViewTextBoxColumn
            // 
            this.federationDataGridViewTextBoxColumn.DataPropertyName = "Federation";
            resources.ApplyResources(this.federationDataGridViewTextBoxColumn, "federationDataGridViewTextBoxColumn");
            this.federationDataGridViewTextBoxColumn.Name = "federationDataGridViewTextBoxColumn";
            // 
            // playerHasTitlesDataGridViewTextBoxColumn1
            // 
            this.playerHasTitlesDataGridViewTextBoxColumn1.DataPropertyName = "PlayerHasTitles";
            resources.ApplyResources(this.playerHasTitlesDataGridViewTextBoxColumn1, "playerHasTitlesDataGridViewTextBoxColumn1");
            this.playerHasTitlesDataGridViewTextBoxColumn1.Name = "playerHasTitlesDataGridViewTextBoxColumn1";
            // 
            // titleIDDataGridViewTextBoxColumn
            // 
            this.titleIDDataGridViewTextBoxColumn.DataPropertyName = "TitleID";
            resources.ApplyResources(this.titleIDDataGridViewTextBoxColumn, "titleIDDataGridViewTextBoxColumn");
            this.titleIDDataGridViewTextBoxColumn.Name = "titleIDDataGridViewTextBoxColumn";
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataSource = typeof(FCDataEF.Title);
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.playersDeleteBtn);
            this.tabPlayers.Controls.Add(this.playersSaveBtn);
            this.tabPlayers.Controls.Add(this.dGVPlayers);
            resources.ApplyResources(this.tabPlayers, "tabPlayers");
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // playersDeleteBtn
            // 
            resources.ApplyResources(this.playersDeleteBtn, "playersDeleteBtn");
            this.playersDeleteBtn.Name = "playersDeleteBtn";
            this.playersDeleteBtn.UseVisualStyleBackColor = true;
            this.playersDeleteBtn.Click += new System.EventHandler(this.playersDeleteBtn_Click);
            // 
            // playersSaveBtn
            // 
            resources.ApplyResources(this.playersSaveBtn, "playersSaveBtn");
            this.playersSaveBtn.Name = "playersSaveBtn";
            this.playersSaveBtn.UseVisualStyleBackColor = true;
            this.playersSaveBtn.Click += new System.EventHandler(this.playersSaveBtn_Click);
            // 
            // dGVPlayers
            // 
            resources.ApplyResources(this.dGVPlayers, "dGVPlayers");
            this.dGVPlayers.AutoGenerateColumns = false;
            this.dGVPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.contractIDDataGridViewTextBoxColumn,
            this.heightCMDataGridViewTextBoxColumn,
            this.contractsDataGridViewTextBoxColumn1,
            this.playerHasTitlesDataGridViewTextBoxColumn,
            this.playerIDDataGridViewTextBoxColumn});
            this.dGVPlayers.DataSource = this.playerBindingSource;
            this.dGVPlayers.Name = "dGVPlayers";
            this.dGVPlayers.RowTemplate.Height = 33;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            resources.ApplyResources(this.playerNameDataGridViewTextBoxColumn, "playerNameDataGridViewTextBoxColumn");
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            resources.ApplyResources(this.dateOfBirthDataGridViewTextBoxColumn, "dateOfBirthDataGridViewTextBoxColumn");
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // contractIDDataGridViewTextBoxColumn
            // 
            this.contractIDDataGridViewTextBoxColumn.DataPropertyName = "ContractID";
            this.contractIDDataGridViewTextBoxColumn.DataSource = this.contractBindingSource;
            this.contractIDDataGridViewTextBoxColumn.DisplayMember = "ClubID";
            resources.ApplyResources(this.contractIDDataGridViewTextBoxColumn, "contractIDDataGridViewTextBoxColumn");
            this.contractIDDataGridViewTextBoxColumn.Name = "contractIDDataGridViewTextBoxColumn";
            this.contractIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.contractIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.contractIDDataGridViewTextBoxColumn.ValueMember = "ContractID";
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(FCDataEF.Contract);
            // 
            // heightCMDataGridViewTextBoxColumn
            // 
            this.heightCMDataGridViewTextBoxColumn.DataPropertyName = "HeightCM";
            resources.ApplyResources(this.heightCMDataGridViewTextBoxColumn, "heightCMDataGridViewTextBoxColumn");
            this.heightCMDataGridViewTextBoxColumn.Name = "heightCMDataGridViewTextBoxColumn";
            // 
            // contractsDataGridViewTextBoxColumn1
            // 
            this.contractsDataGridViewTextBoxColumn1.DataPropertyName = "Contracts";
            resources.ApplyResources(this.contractsDataGridViewTextBoxColumn1, "contractsDataGridViewTextBoxColumn1");
            this.contractsDataGridViewTextBoxColumn1.Name = "contractsDataGridViewTextBoxColumn1";
            // 
            // playerHasTitlesDataGridViewTextBoxColumn
            // 
            this.playerHasTitlesDataGridViewTextBoxColumn.DataPropertyName = "PlayerHasTitles";
            resources.ApplyResources(this.playerHasTitlesDataGridViewTextBoxColumn, "playerHasTitlesDataGridViewTextBoxColumn");
            this.playerHasTitlesDataGridViewTextBoxColumn.Name = "playerHasTitlesDataGridViewTextBoxColumn";
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID";
            resources.ApplyResources(this.playerIDDataGridViewTextBoxColumn, "playerIDDataGridViewTextBoxColumn");
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(FCDataEF.Player);
            // 
            // tabClubs
            // 
            this.tabClubs.Controls.Add(this.clubsSearchBtn);
            this.tabClubs.Controls.Add(this.deleteClubBtn);
            this.tabClubs.Controls.Add(this.saveClubBtn);
            this.tabClubs.Controls.Add(this.dGVClubs);
            resources.ApplyResources(this.tabClubs, "tabClubs");
            this.tabClubs.Name = "tabClubs";
            this.tabClubs.UseVisualStyleBackColor = true;
            // 
            // deleteClubBtn
            // 
            resources.ApplyResources(this.deleteClubBtn, "deleteClubBtn");
            this.deleteClubBtn.Name = "deleteClubBtn";
            this.deleteClubBtn.UseVisualStyleBackColor = true;
            this.deleteClubBtn.Click += new System.EventHandler(this.deleteClubBtn_Click);
            // 
            // saveClubBtn
            // 
            resources.ApplyResources(this.saveClubBtn, "saveClubBtn");
            this.saveClubBtn.Name = "saveClubBtn";
            this.saveClubBtn.UseVisualStyleBackColor = true;
            this.saveClubBtn.Click += new System.EventHandler(this.saveClubBtn_Click);
            // 
            // dGVClubs
            // 
            resources.ApplyResources(this.dGVClubs, "dGVClubs");
            this.dGVClubs.AutoGenerateColumns = false;
            this.dGVClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubIDDataGridViewTextBoxColumn,
            this.clubNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.yearOfFoundationDataGridViewTextBoxColumn,
            this.leagueIDDataGridViewTextBoxColumn,
            this.clubHasTitlesDataGridViewTextBoxColumn,
            this.leagueDataGridViewTextBoxColumn,
            this.contractsDataGridViewTextBoxColumn});
            this.dGVClubs.DataSource = this.clubBindingSource;
            this.dGVClubs.Name = "dGVClubs";
            this.dGVClubs.RowTemplate.Height = 33;
            this.dGVClubs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVClubs_DataError);
            // 
            // clubIDDataGridViewTextBoxColumn
            // 
            this.clubIDDataGridViewTextBoxColumn.DataPropertyName = "ClubID";
            resources.ApplyResources(this.clubIDDataGridViewTextBoxColumn, "clubIDDataGridViewTextBoxColumn");
            this.clubIDDataGridViewTextBoxColumn.Name = "clubIDDataGridViewTextBoxColumn";
            // 
            // clubNameDataGridViewTextBoxColumn
            // 
            this.clubNameDataGridViewTextBoxColumn.DataPropertyName = "ClubName";
            resources.ApplyResources(this.clubNameDataGridViewTextBoxColumn, "clubNameDataGridViewTextBoxColumn");
            this.clubNameDataGridViewTextBoxColumn.Name = "clubNameDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            resources.ApplyResources(this.locationDataGridViewTextBoxColumn, "locationDataGridViewTextBoxColumn");
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // yearOfFoundationDataGridViewTextBoxColumn
            // 
            this.yearOfFoundationDataGridViewTextBoxColumn.DataPropertyName = "YearOfFoundation";
            resources.ApplyResources(this.yearOfFoundationDataGridViewTextBoxColumn, "yearOfFoundationDataGridViewTextBoxColumn");
            this.yearOfFoundationDataGridViewTextBoxColumn.Name = "yearOfFoundationDataGridViewTextBoxColumn";
            // 
            // leagueIDDataGridViewTextBoxColumn
            // 
            this.leagueIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.leagueIDDataGridViewTextBoxColumn.DataPropertyName = "LeagueID";
            this.leagueIDDataGridViewTextBoxColumn.DataSource = this.leagueBindingSource;
            this.leagueIDDataGridViewTextBoxColumn.DisplayMember = "LeagueName";
            resources.ApplyResources(this.leagueIDDataGridViewTextBoxColumn, "leagueIDDataGridViewTextBoxColumn");
            this.leagueIDDataGridViewTextBoxColumn.Name = "leagueIDDataGridViewTextBoxColumn";
            this.leagueIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.leagueIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.leagueIDDataGridViewTextBoxColumn.ValueMember = "LeagueID";
            // 
            // leagueBindingSource
            // 
            this.leagueBindingSource.DataSource = typeof(FCDataEF.League);
            // 
            // clubHasTitlesDataGridViewTextBoxColumn
            // 
            this.clubHasTitlesDataGridViewTextBoxColumn.DataPropertyName = "ClubHasTitles";
            resources.ApplyResources(this.clubHasTitlesDataGridViewTextBoxColumn, "clubHasTitlesDataGridViewTextBoxColumn");
            this.clubHasTitlesDataGridViewTextBoxColumn.Name = "clubHasTitlesDataGridViewTextBoxColumn";
            // 
            // leagueDataGridViewTextBoxColumn
            // 
            this.leagueDataGridViewTextBoxColumn.DataPropertyName = "League";
            resources.ApplyResources(this.leagueDataGridViewTextBoxColumn, "leagueDataGridViewTextBoxColumn");
            this.leagueDataGridViewTextBoxColumn.Name = "leagueDataGridViewTextBoxColumn";
            // 
            // contractsDataGridViewTextBoxColumn
            // 
            this.contractsDataGridViewTextBoxColumn.DataPropertyName = "Contracts";
            resources.ApplyResources(this.contractsDataGridViewTextBoxColumn, "contractsDataGridViewTextBoxColumn");
            this.contractsDataGridViewTextBoxColumn.Name = "contractsDataGridViewTextBoxColumn";
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataSource = typeof(FCDataEF.Club);
            // 
            // mainTabControl
            // 
            resources.ApplyResources(this.mainTabControl, "mainTabControl");
            this.mainTabControl.Controls.Add(this.tabClubs);
            this.mainTabControl.Controls.Add(this.tabPlayers);
            this.mainTabControl.Controls.Add(this.tabTitles);
            this.mainTabControl.Controls.Add(this.tabLeagues);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            // 
            // tabLeagues
            // 
            this.tabLeagues.Controls.Add(this.leaguesDeleteBtn);
            this.tabLeagues.Controls.Add(this.leaguesSaveBtn);
            this.tabLeagues.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.tabLeagues, "tabLeagues");
            this.tabLeagues.Name = "tabLeagues";
            this.tabLeagues.UseVisualStyleBackColor = true;
            // 
            // leaguesDeleteBtn
            // 
            resources.ApplyResources(this.leaguesDeleteBtn, "leaguesDeleteBtn");
            this.leaguesDeleteBtn.Name = "leaguesDeleteBtn";
            this.leaguesDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // leaguesSaveBtn
            // 
            resources.ApplyResources(this.leaguesSaveBtn, "leaguesSaveBtn");
            this.leaguesSaveBtn.Name = "leaguesSaveBtn";
            this.leaguesSaveBtn.UseVisualStyleBackColor = true;
            this.leaguesSaveBtn.Click += new System.EventHandler(this.leaguesSaveBtn_Click);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leagueNameDataGridViewTextBoxColumn,
            this.leagueLevelDataGridViewTextBoxColumn,
            this.countryIDDataGridViewTextBoxColumn,
            this.numberOfCLPlacesDataGridViewTextBoxColumn,
            this.clubsDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.leagueIDDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.leagueBindingSource;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // leagueNameDataGridViewTextBoxColumn
            // 
            this.leagueNameDataGridViewTextBoxColumn.DataPropertyName = "LeagueName";
            resources.ApplyResources(this.leagueNameDataGridViewTextBoxColumn, "leagueNameDataGridViewTextBoxColumn");
            this.leagueNameDataGridViewTextBoxColumn.Name = "leagueNameDataGridViewTextBoxColumn";
            // 
            // leagueLevelDataGridViewTextBoxColumn
            // 
            this.leagueLevelDataGridViewTextBoxColumn.DataPropertyName = "LeagueLevel";
            resources.ApplyResources(this.leagueLevelDataGridViewTextBoxColumn, "leagueLevelDataGridViewTextBoxColumn");
            this.leagueLevelDataGridViewTextBoxColumn.Name = "leagueLevelDataGridViewTextBoxColumn";
            // 
            // countryIDDataGridViewTextBoxColumn
            // 
            this.countryIDDataGridViewTextBoxColumn.DataPropertyName = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.DataSource = this.countryBindingSource;
            this.countryIDDataGridViewTextBoxColumn.DisplayMember = "Countryname";
            resources.ApplyResources(this.countryIDDataGridViewTextBoxColumn, "countryIDDataGridViewTextBoxColumn");
            this.countryIDDataGridViewTextBoxColumn.Name = "countryIDDataGridViewTextBoxColumn";
            this.countryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.countryIDDataGridViewTextBoxColumn.ValueMember = "CountryID";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(FCDataEF.Country);
            // 
            // numberOfCLPlacesDataGridViewTextBoxColumn
            // 
            this.numberOfCLPlacesDataGridViewTextBoxColumn.DataPropertyName = "NumberOfCLPlaces";
            resources.ApplyResources(this.numberOfCLPlacesDataGridViewTextBoxColumn, "numberOfCLPlacesDataGridViewTextBoxColumn");
            this.numberOfCLPlacesDataGridViewTextBoxColumn.Name = "numberOfCLPlacesDataGridViewTextBoxColumn";
            // 
            // clubsDataGridViewTextBoxColumn
            // 
            this.clubsDataGridViewTextBoxColumn.DataPropertyName = "Clubs";
            resources.ApplyResources(this.clubsDataGridViewTextBoxColumn, "clubsDataGridViewTextBoxColumn");
            this.clubsDataGridViewTextBoxColumn.Name = "clubsDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            resources.ApplyResources(this.countryDataGridViewTextBoxColumn, "countryDataGridViewTextBoxColumn");
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // leagueIDDataGridViewTextBoxColumn1
            // 
            this.leagueIDDataGridViewTextBoxColumn1.DataPropertyName = "LeagueID";
            resources.ApplyResources(this.leagueIDDataGridViewTextBoxColumn1, "leagueIDDataGridViewTextBoxColumn1");
            this.leagueIDDataGridViewTextBoxColumn1.Name = "leagueIDDataGridViewTextBoxColumn1";
            // 
            // clubsSearchBtn
            // 
            resources.ApplyResources(this.clubsSearchBtn, "clubsSearchBtn");
            this.clubsSearchBtn.Name = "clubsSearchBtn";
            this.clubsSearchBtn.UseVisualStyleBackColor = true;
            this.clubsSearchBtn.Click += new System.EventHandler(this.clubsSearchBtn_Click_2);
            // 
            // DBUIForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Name = "DBUIForm";
            this.Load += new System.EventHandler(this.DBUIForm_Load);
            this.tabTitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.federationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            this.tabPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.tabClubs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.tabLeagues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabTitles;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabClubs;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.DataGridView dGVTitles;
        private System.Windows.Forms.DataGridView dGVPlayers;
        private System.Windows.Forms.DataGridView dGVClubs;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private System.Windows.Forms.Button deleteClubBtn;
        private System.Windows.Forms.Button saveClubBtn;
        private System.Windows.Forms.BindingSource leagueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfFoundationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn leagueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubHasTitlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leagueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabLeagues;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource federationBindingSource;
        private System.Windows.Forms.BindingSource titleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn contractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerHasTitlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn federationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubHasTitlesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn federationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerHasTitlesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leagueNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leagueLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn countryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfCLPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leagueIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button titlesDeleteBtn;
        private System.Windows.Forms.Button titlesSaveBtn;
        private System.Windows.Forms.Button playersDeleteBtn;
        private System.Windows.Forms.Button playersSaveBtn;
        private System.Windows.Forms.Button leaguesDeleteBtn;
        private System.Windows.Forms.Button leaguesSaveBtn;
        private System.Windows.Forms.Button clubsSearchBtn;
    }
}

