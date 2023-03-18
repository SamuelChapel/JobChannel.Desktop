namespace JobChannelDesktop;

partial class FormJobChannel
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
        components = new System.ComponentModel.Container();
        tLPMain = new TableLayoutPanel();
        btResetFilters = new Button();
        tLPFilters = new TableLayoutPanel();
        cBContract = new ComboBox();
        contractBindingSource = new BindingSource(components);
        lblJob = new Label();
        labelFiltre = new Label();
        labelCity = new Label();
        labelDepartment = new Label();
        cbRegion = new ComboBox();
        regionBindingSource = new BindingSource(components);
        labelRegion = new Label();
        cbDepartment = new ComboBox();
        departmentsBS = new BindingSource(components);
        cbCity = new ComboBox();
        cityGetResponseBindingSource = new BindingSource(components);
        cBJob = new ComboBox();
        jobBindingSource = new BindingSource(components);
        lblContract = new Label();
        TilteLabel = new Label();
        tLPSearchbar = new TableLayoutPanel();
        labelSearch = new Label();
        tBSearch = new TextBox();
        dGVJobOffers = new DataGridView();
        titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        publicationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        urlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        experienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        jobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        contractDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        regionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        companyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        jobOfferBS = new BindingSource(components);
        flowLayoutPanel1 = new FlowLayoutPanel();
        btAdd = new Button();
        btUpdate = new Button();
        btDelete = new Button();
        timerRecherche = new System.Windows.Forms.Timer(components);
        tLPMain.SuspendLayout();
        tLPFilters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)contractBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)regionBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)departmentsBS).BeginInit();
        ((System.ComponentModel.ISupportInitialize)cityGetResponseBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)jobBindingSource).BeginInit();
        tLPSearchbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dGVJobOffers).BeginInit();
        ((System.ComponentModel.ISupportInitialize)jobOfferBS).BeginInit();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tLPMain
        // 
        tLPMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        tLPMain.ColumnCount = 2;
        tLPMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
        tLPMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tLPMain.Controls.Add(btResetFilters, 0, 2);
        tLPMain.Controls.Add(tLPFilters, 0, 1);
        tLPMain.Controls.Add(TilteLabel, 0, 0);
        tLPMain.Controls.Add(tLPSearchbar, 1, 0);
        tLPMain.Controls.Add(dGVJobOffers, 1, 1);
        tLPMain.Controls.Add(flowLayoutPanel1, 1, 2);
        tLPMain.Dock = DockStyle.Fill;
        tLPMain.Location = new Point(0, 0);
        tLPMain.Name = "tLPMain";
        tLPMain.RowCount = 3;
        tLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tLPMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tLPMain.Size = new Size(1626, 865);
        tLPMain.TabIndex = 0;
        // 
        // btResetFilters
        // 
        btResetFilters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        btResetFilters.Location = new Point(33, 817);
        btResetFilters.Margin = new Padding(20, 3, 20, 3);
        btResetFilters.Name = "btResetFilters";
        btResetFilters.Size = new Size(155, 44);
        btResetFilters.TabIndex = 6;
        btResetFilters.Text = "Reinitialiser Filtres";
        btResetFilters.UseVisualStyleBackColor = true;
        btResetFilters.Click += btResetFilters_Click;
        // 
        // tLPFilters
        // 
        tLPFilters.BackColor = SystemColors.ControlLightLight;
        tLPFilters.ColumnCount = 1;
        tLPFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tLPFilters.Controls.Add(cBContract, 0, 11);
        tLPFilters.Controls.Add(lblJob, 0, 8);
        tLPFilters.Controls.Add(labelFiltre, 0, 0);
        tLPFilters.Controls.Add(labelCity, 0, 6);
        tLPFilters.Controls.Add(labelDepartment, 0, 4);
        tLPFilters.Controls.Add(cbRegion, 0, 3);
        tLPFilters.Controls.Add(labelRegion, 0, 2);
        tLPFilters.Controls.Add(cbDepartment, 0, 5);
        tLPFilters.Controls.Add(cbCity, 0, 7);
        tLPFilters.Controls.Add(cBJob, 0, 9);
        tLPFilters.Controls.Add(lblContract, 0, 10);
        tLPFilters.Dock = DockStyle.Fill;
        tLPFilters.Location = new Point(4, 55);
        tLPFilters.Name = "tLPFilters";
        tLPFilters.RowCount = 13;
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.RowStyles.Add(new RowStyle());
        tLPFilters.Size = new Size(214, 755);
        tLPFilters.TabIndex = 1;
        // 
        // cBContract
        // 
        cBContract.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cBContract.DataSource = contractBindingSource;
        cBContract.DisplayMember = "Name";
        cBContract.DropDownStyle = ComboBoxStyle.DropDownList;
        cBContract.Enabled = false;
        cBContract.FormattingEnabled = true;
        cBContract.Location = new Point(3, 274);
        cBContract.Name = "cBContract";
        cBContract.Size = new Size(208, 28);
        cBContract.TabIndex = 10;
        cBContract.SelectionChangeCommitted += cBContract_SelectionChangeCommitted;
        // 
        // contractBindingSource
        // 
        contractBindingSource.DataSource = typeof(JobChannel.Domain.BO.Contract);
        // 
        // lblJob
        // 
        lblJob.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblJob.AutoSize = true;
        lblJob.Location = new Point(3, 197);
        lblJob.Name = "lblJob";
        lblJob.Size = new Size(208, 20);
        lblJob.TabIndex = 8;
        lblJob.Text = "Poste";
        lblJob.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelFiltre
        // 
        labelFiltre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        labelFiltre.AutoSize = true;
        labelFiltre.BorderStyle = BorderStyle.FixedSingle;
        labelFiltre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
        labelFiltre.Location = new Point(3, 0);
        labelFiltre.Name = "labelFiltre";
        labelFiltre.Size = new Size(208, 33);
        labelFiltre.TabIndex = 6;
        labelFiltre.Text = "Filtres";
        labelFiltre.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelCity
        // 
        labelCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        labelCity.AutoSize = true;
        labelCity.Location = new Point(3, 143);
        labelCity.Name = "labelCity";
        labelCity.Size = new Size(208, 20);
        labelCity.TabIndex = 5;
        labelCity.Text = "Ville";
        labelCity.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // labelDepartment
        // 
        labelDepartment.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        labelDepartment.AutoSize = true;
        labelDepartment.Location = new Point(3, 89);
        labelDepartment.Name = "labelDepartment";
        labelDepartment.Size = new Size(208, 20);
        labelDepartment.TabIndex = 4;
        labelDepartment.Text = "Département";
        labelDepartment.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cbRegion
        // 
        cbRegion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cbRegion.DataSource = regionBindingSource;
        cbRegion.DisplayMember = "Name";
        cbRegion.DropDownStyle = ComboBoxStyle.DropDownList;
        cbRegion.Enabled = false;
        cbRegion.FormattingEnabled = true;
        cbRegion.Location = new Point(3, 58);
        cbRegion.Name = "cbRegion";
        cbRegion.Size = new Size(208, 28);
        cbRegion.TabIndex = 0;
        cbRegion.SelectionChangeCommitted += cbRegion_SelectionChangeCommitted;
        // 
        // regionBindingSource
        // 
        regionBindingSource.DataSource = typeof(JobChannel.Domain.BO.Region);
        // 
        // labelRegion
        // 
        labelRegion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        labelRegion.AutoSize = true;
        labelRegion.Location = new Point(3, 35);
        labelRegion.Name = "labelRegion";
        labelRegion.Size = new Size(208, 20);
        labelRegion.TabIndex = 3;
        labelRegion.Text = "Région";
        labelRegion.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cbDepartment
        // 
        cbDepartment.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cbDepartment.DataSource = departmentsBS;
        cbDepartment.DisplayMember = "Name";
        cbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
        cbDepartment.Enabled = false;
        cbDepartment.FormattingEnabled = true;
        cbDepartment.Location = new Point(3, 112);
        cbDepartment.Name = "cbDepartment";
        cbDepartment.Size = new Size(208, 28);
        cbDepartment.TabIndex = 1;
        cbDepartment.SelectionChangeCommitted += cbDepartment_SelectionChangeCommitted;
        // 
        // departmentsBS
        // 
        departmentsBS.DataSource = typeof(BLL.Services.Geographic.Requests.DepartmentGetResponse);
        // 
        // cbCity
        // 
        cbCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cbCity.DataSource = cityGetResponseBindingSource;
        cbCity.DisplayMember = "Name";
        cbCity.DropDownStyle = ComboBoxStyle.DropDownList;
        cbCity.Enabled = false;
        cbCity.FormattingEnabled = true;
        cbCity.Location = new Point(3, 166);
        cbCity.Name = "cbCity";
        cbCity.Size = new Size(208, 28);
        cbCity.TabIndex = 2;
        cbCity.SelectionChangeCommitted += cbCity_SelectionChangeCommitted;
        // 
        // cityGetResponseBindingSource
        // 
        cityGetResponseBindingSource.DataSource = typeof(BLL.Services.Geographic.Requests.CityGetResponse);
        // 
        // cBJob
        // 
        cBJob.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cBJob.DataSource = jobBindingSource;
        cBJob.DisplayMember = "Name";
        cBJob.DropDownStyle = ComboBoxStyle.DropDownList;
        cBJob.Enabled = false;
        cBJob.FormattingEnabled = true;
        cBJob.Location = new Point(3, 220);
        cBJob.Name = "cBJob";
        cBJob.Size = new Size(208, 28);
        cBJob.TabIndex = 7;
        cBJob.SelectionChangeCommitted += cBJob_SelectionChangeCommitted;
        // 
        // jobBindingSource
        // 
        jobBindingSource.DataSource = typeof(JobChannel.Domain.BO.Job);
        // 
        // lblContract
        // 
        lblContract.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        lblContract.AutoSize = true;
        lblContract.Location = new Point(3, 251);
        lblContract.Name = "lblContract";
        lblContract.Size = new Size(208, 20);
        lblContract.TabIndex = 9;
        lblContract.Text = "Contrat";
        lblContract.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TilteLabel
        // 
        TilteLabel.AutoSize = true;
        TilteLabel.BackColor = Color.Gray;
        TilteLabel.Dock = DockStyle.Fill;
        TilteLabel.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
        TilteLabel.ForeColor = SystemColors.ActiveCaptionText;
        TilteLabel.Location = new Point(4, 1);
        TilteLabel.Name = "TilteLabel";
        TilteLabel.Size = new Size(214, 50);
        TilteLabel.TabIndex = 2;
        TilteLabel.Text = "JobChannel";
        TilteLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tLPSearchbar
        // 
        tLPSearchbar.ColumnCount = 2;
        tLPSearchbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        tLPSearchbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tLPSearchbar.Controls.Add(labelSearch, 0, 0);
        tLPSearchbar.Controls.Add(tBSearch, 1, 0);
        tLPSearchbar.Dock = DockStyle.Fill;
        tLPSearchbar.Location = new Point(225, 4);
        tLPSearchbar.Name = "tLPSearchbar";
        tLPSearchbar.RowCount = 1;
        tLPSearchbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tLPSearchbar.Size = new Size(1397, 44);
        tLPSearchbar.TabIndex = 3;
        // 
        // labelSearch
        // 
        labelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        labelSearch.AutoSize = true;
        labelSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        labelSearch.Location = new Point(30, 0);
        labelSearch.Margin = new Padding(30, 0, 3, 0);
        labelSearch.Name = "labelSearch";
        labelSearch.Size = new Size(89, 44);
        labelSearch.TabIndex = 0;
        labelSearch.Text = "Recherche";
        labelSearch.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tBSearch
        // 
        tBSearch.Anchor = AnchorStyles.Left;
        tBSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        tBSearch.Location = new Point(153, 7);
        tBSearch.Name = "tBSearch";
        tBSearch.PlaceholderText = "Entrez votre recherche";
        tBSearch.Size = new Size(436, 30);
        tBSearch.TabIndex = 1;
        tBSearch.TextChanged += TBSearch_TextChanged;
        // 
        // dGVJobOffers
        // 
        dGVJobOffers.AllowUserToAddRows = false;
        dGVJobOffers.AllowUserToDeleteRows = false;
        dGVJobOffers.AllowUserToResizeRows = false;
        dGVJobOffers.AutoGenerateColumns = false;
        dGVJobOffers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dGVJobOffers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dGVJobOffers.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, publicationDateDataGridViewTextBoxColumn, urlDataGridViewTextBoxColumn, experienceDataGridViewTextBoxColumn, jobDataGridViewTextBoxColumn, contractDataGridViewTextBoxColumn, regionDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, companyDataGridViewTextBoxColumn });
        dGVJobOffers.DataSource = jobOfferBS;
        dGVJobOffers.Dock = DockStyle.Fill;
        dGVJobOffers.Location = new Point(225, 55);
        dGVJobOffers.Name = "dGVJobOffers";
        dGVJobOffers.ReadOnly = true;
        dGVJobOffers.RowHeadersVisible = false;
        dGVJobOffers.RowHeadersWidth = 51;
        dGVJobOffers.RowTemplate.Height = 29;
        dGVJobOffers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dGVJobOffers.Size = new Size(1397, 755);
        dGVJobOffers.TabIndex = 4;
        dGVJobOffers.CellDoubleClick += dGVJobOffers_CellDoubleClick;
        // 
        // titleDataGridViewTextBoxColumn
        // 
        titleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
        titleDataGridViewTextBoxColumn.HeaderText = "Titre";
        titleDataGridViewTextBoxColumn.MinimumWidth = 250;
        titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
        titleDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // publicationDateDataGridViewTextBoxColumn
        // 
        publicationDateDataGridViewTextBoxColumn.DataPropertyName = "PublicationDate";
        publicationDateDataGridViewTextBoxColumn.HeaderText = "Date d'ajout";
        publicationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
        publicationDateDataGridViewTextBoxColumn.Name = "publicationDateDataGridViewTextBoxColumn";
        publicationDateDataGridViewTextBoxColumn.ReadOnly = true;
        publicationDateDataGridViewTextBoxColumn.Width = 120;
        // 
        // urlDataGridViewTextBoxColumn
        // 
        urlDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
        urlDataGridViewTextBoxColumn.HeaderText = "Url";
        urlDataGridViewTextBoxColumn.MinimumWidth = 100;
        urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
        urlDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // experienceDataGridViewTextBoxColumn
        // 
        experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
        experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
        experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
        experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
        experienceDataGridViewTextBoxColumn.ReadOnly = true;
        experienceDataGridViewTextBoxColumn.Width = 110;
        // 
        // jobDataGridViewTextBoxColumn
        // 
        jobDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
        jobDataGridViewTextBoxColumn.HeaderText = "Poste";
        jobDataGridViewTextBoxColumn.MinimumWidth = 150;
        jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
        jobDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // contractDataGridViewTextBoxColumn
        // 
        contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
        contractDataGridViewTextBoxColumn.HeaderText = "Contrat";
        contractDataGridViewTextBoxColumn.MinimumWidth = 6;
        contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
        contractDataGridViewTextBoxColumn.ReadOnly = true;
        contractDataGridViewTextBoxColumn.Width = 87;
        // 
        // regionDataGridViewTextBoxColumn
        // 
        regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
        regionDataGridViewTextBoxColumn.HeaderText = "Région";
        regionDataGridViewTextBoxColumn.MinimumWidth = 6;
        regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
        regionDataGridViewTextBoxColumn.ReadOnly = true;
        regionDataGridViewTextBoxColumn.Width = 85;
        // 
        // departmentDataGridViewTextBoxColumn
        // 
        departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
        departmentDataGridViewTextBoxColumn.HeaderText = "Département";
        departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
        departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
        departmentDataGridViewTextBoxColumn.ReadOnly = true;
        departmentDataGridViewTextBoxColumn.Width = 126;
        // 
        // cityDataGridViewTextBoxColumn
        // 
        cityDataGridViewTextBoxColumn.DataPropertyName = "City";
        cityDataGridViewTextBoxColumn.HeaderText = "Ville";
        cityDataGridViewTextBoxColumn.MinimumWidth = 6;
        cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
        cityDataGridViewTextBoxColumn.ReadOnly = true;
        cityDataGridViewTextBoxColumn.Width = 67;
        // 
        // salaryDataGridViewTextBoxColumn
        // 
        salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
        salaryDataGridViewTextBoxColumn.HeaderText = "Salaire";
        salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
        salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
        salaryDataGridViewTextBoxColumn.ReadOnly = true;
        salaryDataGridViewTextBoxColumn.Width = 83;
        // 
        // companyDataGridViewTextBoxColumn
        // 
        companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
        companyDataGridViewTextBoxColumn.HeaderText = "Entreprise";
        companyDataGridViewTextBoxColumn.MinimumWidth = 6;
        companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
        companyDataGridViewTextBoxColumn.ReadOnly = true;
        companyDataGridViewTextBoxColumn.Width = 104;
        // 
        // jobOfferBS
        // 
        jobOfferBS.DataSource = typeof(BLL.Services.JobOffers.Resquests.JobOfferFindResponse);
        jobOfferBS.CurrentChanged += jobOfferBS_CurrentChanged;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        flowLayoutPanel1.Controls.Add(btAdd);
        flowLayoutPanel1.Controls.Add(btUpdate);
        flowLayoutPanel1.Controls.Add(btDelete);
        flowLayoutPanel1.Location = new Point(655, 817);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(537, 44);
        flowLayoutPanel1.TabIndex = 5;
        // 
        // btAdd
        // 
        btAdd.Location = new Point(20, 3);
        btAdd.Margin = new Padding(20, 3, 20, 3);
        btAdd.Name = "btAdd";
        btAdd.Size = new Size(137, 41);
        btAdd.TabIndex = 0;
        btAdd.Text = "Ajouter";
        btAdd.UseVisualStyleBackColor = true;
        btAdd.Click += btAdd_Click;
        // 
        // btUpdate
        // 
        btUpdate.Enabled = false;
        btUpdate.Location = new Point(197, 3);
        btUpdate.Margin = new Padding(20, 3, 20, 3);
        btUpdate.Name = "btUpdate";
        btUpdate.Size = new Size(137, 41);
        btUpdate.TabIndex = 1;
        btUpdate.Text = "Modifier";
        btUpdate.UseVisualStyleBackColor = true;
        btUpdate.Click += btUpdate_Click;
        // 
        // btDelete
        // 
        btDelete.Enabled = false;
        btDelete.Location = new Point(374, 3);
        btDelete.Margin = new Padding(20, 3, 20, 3);
        btDelete.Name = "btDelete";
        btDelete.Size = new Size(137, 41);
        btDelete.TabIndex = 2;
        btDelete.Text = "Supprimer";
        btDelete.UseVisualStyleBackColor = true;
        btDelete.Click += BtDelete_Click;
        // 
        // timerRecherche
        // 
        timerRecherche.Interval = 400;
        timerRecherche.Tick += TimerRecherche_Tick;
        // 
        // FormJobChannel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1626, 865);
        Controls.Add(tLPMain);
        MinimumSize = new Size(1600, 900);
        Name = "FormJobChannel";
        Text = "Job Channel";
        Load += FormJobChannel_Load;
        tLPMain.ResumeLayout(false);
        tLPMain.PerformLayout();
        tLPFilters.ResumeLayout(false);
        tLPFilters.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)contractBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)regionBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)departmentsBS).EndInit();
        ((System.ComponentModel.ISupportInitialize)cityGetResponseBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)jobBindingSource).EndInit();
        tLPSearchbar.ResumeLayout(false);
        tLPSearchbar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dGVJobOffers).EndInit();
        ((System.ComponentModel.ISupportInitialize)jobOfferBS).EndInit();
        flowLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tLPMain;
    private ComboBox cbRegion;
    private ComboBox cbDepartment;
    private ComboBox cbCity;
    private Label labelRegion;
    private TableLayoutPanel tLPFilters;
    private Label labelCity;
    private Label labelDepartment;
    private Label labelFiltre;
    private Label TilteLabel;
    private TableLayoutPanel tLPSearchbar;
    private Label labelSearch;
    private TextBox tBSearch;
    private DataGridView dGVJobOffers;
    private System.Windows.Forms.Timer timerRecherche;
    private BindingSource regionBindingSource;
    private BindingSource jobOfferBS;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button btAdd;
    private Button btUpdate;
    private Button btDelete;
    private BindingSource departmentsBS;
    private BindingSource cityGetResponseBindingSource;
    private Button btResetFilters;
    private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn publicationDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
    private Label lblJob;
    private ComboBox cBJob;
    private BindingSource jobBindingSource;
    private Label lblContract;
    private ComboBox cBContract;
    private BindingSource contractBindingSource;
}