namespace JobChannelDesktop.Forms;

partial class FormJobOffer
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
        tlpSecondary = new TableLayoutPanel();
        tbCompany = new TextBox();
        tbExperience = new TextBox();
        lblExperience = new Label();
        lblCompany = new Label();
        tbSalary = new TextBox();
        lblSalary = new Label();
        tbUrl = new TextBox();
        lblUrl = new Label();
        lblPublicationDate = new Label();
        tbDescription = new TextBox();
        lblDescription = new Label();
        tbTitle = new TextBox();
        lblTitle = new Label();
        dtpPublication = new DateTimePicker();
        tlpMain = new TableLayoutPanel();
        tableLayoutPanel1 = new TableLayoutPanel();
        cbCity = new ComboBox();
        cityGetResponseBindingSource = new BindingSource(components);
        cbContract = new ComboBox();
        contractBindingSource = new BindingSource(components);
        lblContract = new Label();
        lblCity = new Label();
        lblJob = new Label();
        cbJob = new ComboBox();
        jobBindingSource = new BindingSource(components);
        flowLayoutPanel1 = new FlowLayoutPanel();
        btValidate = new Button();
        btCancel = new Button();
        timerCities = new System.Windows.Forms.Timer(components);
        timerJobs = new System.Windows.Forms.Timer(components);
        tlpSecondary.SuspendLayout();
        tlpMain.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)cityGetResponseBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)contractBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)jobBindingSource).BeginInit();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tlpSecondary
        // 
        tlpSecondary.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
        tlpSecondary.ColumnCount = 2;
        tlpSecondary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        tlpSecondary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpSecondary.Controls.Add(tbCompany, 1, 6);
        tlpSecondary.Controls.Add(tbExperience, 1, 5);
        tlpSecondary.Controls.Add(lblExperience, 0, 5);
        tlpSecondary.Controls.Add(lblCompany, 0, 6);
        tlpSecondary.Controls.Add(tbSalary, 1, 4);
        tlpSecondary.Controls.Add(lblSalary, 0, 4);
        tlpSecondary.Controls.Add(tbUrl, 1, 3);
        tlpSecondary.Controls.Add(lblUrl, 0, 3);
        tlpSecondary.Controls.Add(lblPublicationDate, 0, 2);
        tlpSecondary.Controls.Add(tbDescription, 1, 1);
        tlpSecondary.Controls.Add(lblDescription, 0, 1);
        tlpSecondary.Controls.Add(tbTitle, 1, 0);
        tlpSecondary.Controls.Add(lblTitle, 0, 0);
        tlpSecondary.Controls.Add(dtpPublication, 1, 2);
        tlpSecondary.Dock = DockStyle.Fill;
        tlpSecondary.Location = new Point(3, 3);
        tlpSecondary.Name = "tlpSecondary";
        tlpSecondary.RowCount = 7;
        tlpSecondary.RowStyles.Add(new RowStyle());
        tlpSecondary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpSecondary.RowStyles.Add(new RowStyle());
        tlpSecondary.RowStyles.Add(new RowStyle());
        tlpSecondary.RowStyles.Add(new RowStyle());
        tlpSecondary.RowStyles.Add(new RowStyle());
        tlpSecondary.RowStyles.Add(new RowStyle());
        tlpSecondary.Size = new Size(1335, 516);
        tlpSecondary.TabIndex = 0;
        // 
        // tbCompany
        // 
        tbCompany.Dock = DockStyle.Top;
        tbCompany.Location = new Point(209, 483);
        tbCompany.Name = "tbCompany";
        tbCompany.PlaceholderText = "Renseignez l'entreprise";
        tbCompany.Size = new Size(1120, 27);
        tbCompany.TabIndex = 13;
        tbCompany.TextChanged += TbCompany_TextChanged;
        // 
        // tbExperience
        // 
        tbExperience.Dock = DockStyle.Top;
        tbExperience.Location = new Point(209, 447);
        tbExperience.Name = "tbExperience";
        tbExperience.PlaceholderText = "Renseignez l'experience";
        tbExperience.Size = new Size(1120, 27);
        tbExperience.TabIndex = 12;
        tbExperience.TextChanged += TbExperience_TextChanged;
        // 
        // lblExperience
        // 
        lblExperience.AutoSize = true;
        lblExperience.Dock = DockStyle.Fill;
        lblExperience.Location = new Point(6, 444);
        lblExperience.Name = "lblExperience";
        lblExperience.Size = new Size(194, 33);
        lblExperience.TabIndex = 11;
        lblExperience.Text = "Experience";
        lblExperience.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblCompany
        // 
        lblCompany.AutoSize = true;
        lblCompany.Dock = DockStyle.Fill;
        lblCompany.Location = new Point(6, 480);
        lblCompany.Name = "lblCompany";
        lblCompany.Size = new Size(194, 33);
        lblCompany.TabIndex = 10;
        lblCompany.Text = "Entreprise";
        lblCompany.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbSalary
        // 
        tbSalary.Dock = DockStyle.Top;
        tbSalary.Location = new Point(209, 411);
        tbSalary.Name = "tbSalary";
        tbSalary.PlaceholderText = "Entrez le salaire";
        tbSalary.Size = new Size(1120, 27);
        tbSalary.TabIndex = 9;
        tbSalary.TextChanged += TbSalary_TextChanged;
        // 
        // lblSalary
        // 
        lblSalary.AutoSize = true;
        lblSalary.Dock = DockStyle.Fill;
        lblSalary.Location = new Point(6, 408);
        lblSalary.Name = "lblSalary";
        lblSalary.Size = new Size(194, 33);
        lblSalary.TabIndex = 8;
        lblSalary.Text = "Salaire";
        lblSalary.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbUrl
        // 
        tbUrl.Dock = DockStyle.Top;
        tbUrl.Location = new Point(209, 375);
        tbUrl.Name = "tbUrl";
        tbUrl.PlaceholderText = "http://www.exemple.com";
        tbUrl.Size = new Size(1120, 27);
        tbUrl.TabIndex = 7;
        tbUrl.TextChanged += TbUrl_TextChanged;
        // 
        // lblUrl
        // 
        lblUrl.AutoSize = true;
        lblUrl.Dock = DockStyle.Fill;
        lblUrl.Location = new Point(6, 372);
        lblUrl.Name = "lblUrl";
        lblUrl.Size = new Size(194, 33);
        lblUrl.TabIndex = 6;
        lblUrl.Text = "Url";
        lblUrl.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblPublicationDate
        // 
        lblPublicationDate.AutoSize = true;
        lblPublicationDate.Dock = DockStyle.Fill;
        lblPublicationDate.Location = new Point(6, 336);
        lblPublicationDate.Name = "lblPublicationDate";
        lblPublicationDate.Size = new Size(194, 33);
        lblPublicationDate.TabIndex = 4;
        lblPublicationDate.Text = "Date de publication";
        lblPublicationDate.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbDescription
        // 
        tbDescription.Dock = DockStyle.Fill;
        tbDescription.Location = new Point(209, 42);
        tbDescription.Multiline = true;
        tbDescription.Name = "tbDescription";
        tbDescription.PlaceholderText = "Entrez votre description d'annonce";
        tbDescription.ScrollBars = ScrollBars.Vertical;
        tbDescription.Size = new Size(1120, 288);
        tbDescription.TabIndex = 3;
        tbDescription.TextChanged += TbDescription_TextChanged;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Dock = DockStyle.Fill;
        lblDescription.Location = new Point(6, 39);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(194, 294);
        lblDescription.TabIndex = 2;
        lblDescription.Text = "Description";
        lblDescription.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbTitle
        // 
        tbTitle.Dock = DockStyle.Top;
        tbTitle.Location = new Point(209, 6);
        tbTitle.Name = "tbTitle";
        tbTitle.PlaceholderText = "Entrez votre titre d'annonce";
        tbTitle.Size = new Size(1120, 27);
        tbTitle.TabIndex = 0;
        tbTitle.TextChanged += TbTitle_TextChanged;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Location = new Point(6, 3);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(194, 33);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Titre";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // dtpPublication
        // 
        dtpPublication.Dock = DockStyle.Fill;
        dtpPublication.Location = new Point(209, 339);
        dtpPublication.MaxDate = new DateTime(2035, 2, 1, 0, 0, 0, 0);
        dtpPublication.MinDate = new DateTime(2022, 12, 1, 0, 0, 0, 0);
        dtpPublication.Name = "dtpPublication";
        dtpPublication.Size = new Size(1120, 27);
        dtpPublication.TabIndex = 5;
        dtpPublication.Value = new DateTime(2023, 2, 1, 0, 0, 0, 0);
        dtpPublication.ValueChanged += DtpPublication_ValueChanged;
        // 
        // tlpMain
        // 
        tlpMain.ColumnCount = 1;
        tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpMain.Controls.Add(tlpSecondary, 0, 0);
        tlpMain.Controls.Add(tableLayoutPanel1, 0, 1);
        tlpMain.Controls.Add(flowLayoutPanel1, 0, 2);
        tlpMain.Dock = DockStyle.Fill;
        tlpMain.Location = new Point(0, 0);
        tlpMain.Name = "tlpMain";
        tlpMain.RowCount = 3;
        tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
        tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tlpMain.Size = new Size(1341, 672);
        tlpMain.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tableLayoutPanel1.Controls.Add(cbCity, 2, 1);
        tableLayoutPanel1.Controls.Add(cbContract, 1, 1);
        tableLayoutPanel1.Controls.Add(lblContract, 1, 0);
        tableLayoutPanel1.Controls.Add(lblCity, 2, 0);
        tableLayoutPanel1.Controls.Add(lblJob, 0, 0);
        tableLayoutPanel1.Controls.Add(cbJob, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 525);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(1335, 94);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // cbCity
        // 
        cbCity.DataSource = cityGetResponseBindingSource;
        cbCity.Dock = DockStyle.Fill;
        cbCity.FormattingEnabled = true;
        cbCity.Location = new Point(892, 50);
        cbCity.Name = "cbCity";
        cbCity.Size = new Size(440, 28);
        cbCity.TabIndex = 16;
        cbCity.SelectedIndexChanged += CbCity_SelectedIndexChanged;
        cbCity.TextUpdate += CbCity_TextUpdate;
        // 
        // cityGetResponseBindingSource
        // 
        cityGetResponseBindingSource.DataSource = typeof(BLL.Services.Geographic.Requests.CityGetResponse);
        // 
        // cbContract
        // 
        cbContract.DataSource = contractBindingSource;
        cbContract.DisplayMember = "Name";
        cbContract.Dock = DockStyle.Fill;
        cbContract.DropDownStyle = ComboBoxStyle.DropDownList;
        cbContract.FormattingEnabled = true;
        cbContract.Location = new Point(447, 50);
        cbContract.Name = "cbContract";
        cbContract.Size = new Size(439, 28);
        cbContract.TabIndex = 15;
        cbContract.SelectedIndexChanged += CbContract_SelectedIndexChanged;
        // 
        // contractBindingSource
        // 
        contractBindingSource.DataSource = typeof(JobChannel.Domain.BO.Contract);
        // 
        // lblContract
        // 
        lblContract.AutoSize = true;
        lblContract.Dock = DockStyle.Fill;
        lblContract.Location = new Point(447, 0);
        lblContract.Name = "lblContract";
        lblContract.Size = new Size(439, 47);
        lblContract.TabIndex = 13;
        lblContract.Text = "Contrat";
        lblContract.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblCity
        // 
        lblCity.AutoSize = true;
        lblCity.Dock = DockStyle.Fill;
        lblCity.Location = new Point(892, 0);
        lblCity.Name = "lblCity";
        lblCity.Size = new Size(440, 47);
        lblCity.TabIndex = 12;
        lblCity.Text = "Ville";
        lblCity.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblJob
        // 
        lblJob.AutoSize = true;
        lblJob.Dock = DockStyle.Fill;
        lblJob.Location = new Point(3, 0);
        lblJob.Name = "lblJob";
        lblJob.Size = new Size(438, 47);
        lblJob.TabIndex = 11;
        lblJob.Text = "Poste";
        lblJob.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cbJob
        // 
        cbJob.DataSource = jobBindingSource;
        cbJob.DisplayMember = "Name";
        cbJob.Dock = DockStyle.Fill;
        cbJob.FormattingEnabled = true;
        cbJob.Location = new Point(3, 50);
        cbJob.Name = "cbJob";
        cbJob.Size = new Size(438, 28);
        cbJob.TabIndex = 14;
        cbJob.SelectedIndexChanged += CbJob_SelectedIndexChanged;
        cbJob.TextUpdate += CbJob_TextUpdate;
        // 
        // jobBindingSource
        // 
        jobBindingSource.DataSource = typeof(JobChannel.Domain.BO.Job);
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        flowLayoutPanel1.Controls.Add(btValidate);
        flowLayoutPanel1.Controls.Add(btCancel);
        flowLayoutPanel1.Location = new Point(472, 625);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(396, 44);
        flowLayoutPanel1.TabIndex = 2;
        // 
        // btValidate
        // 
        btValidate.Enabled = false;
        btValidate.Location = new Point(30, 3);
        btValidate.Margin = new Padding(30, 3, 30, 3);
        btValidate.Name = "btValidate";
        btValidate.Size = new Size(137, 41);
        btValidate.TabIndex = 1;
        btValidate.Text = "Valider";
        btValidate.UseVisualStyleBackColor = true;
        btValidate.Click += BtValidate_Click;
        // 
        // btCancel
        // 
        btCancel.Location = new Point(227, 3);
        btCancel.Margin = new Padding(30, 3, 30, 3);
        btCancel.Name = "btCancel";
        btCancel.Size = new Size(137, 41);
        btCancel.TabIndex = 2;
        btCancel.Text = "Annuler";
        btCancel.UseVisualStyleBackColor = true;
        btCancel.Click += BtCancel_Click;
        // 
        // timerCities
        // 
        timerCities.Interval = 400;
        timerCities.Tick += TimerCities_Tick;
        // 
        // timerJobs
        // 
        timerJobs.Interval = 400;
        timerJobs.Tick += TimerJobs_Tick;
        // 
        // FormJobOffer
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1341, 672);
        Controls.Add(tlpMain);
        Name = "FormJobOffer";
        Text = "FormJobOffer";
        Load += FormJobOffer_Load;
        tlpSecondary.ResumeLayout(false);
        tlpSecondary.PerformLayout();
        tlpMain.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)cityGetResponseBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)contractBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)jobBindingSource).EndInit();
        flowLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tlpSecondary;
    private TextBox tbTitle;
    private Label lblTitle;
    private TextBox tbDescription;
    private Label lblDescription;
    private Label lblPublicationDate;
    private DateTimePicker dtpPublication;
    private Label lblSalary;
    private TextBox tbUrl;
    private Label lblUrl;
    private Label lblExperience;
    private Label lblCompany;
    private TextBox tbSalary;
    private TextBox tbCompany;
    private TextBox tbExperience;
    private TableLayoutPanel tlpMain;
    private TableLayoutPanel tableLayoutPanel1;
    private Label lblContract;
    private Label lblCity;
    private Label lblJob;
    private ComboBox cbCity;
    private ComboBox cbContract;
    private ComboBox cbJob;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button btValidate;
    private Button btCancel;
    private BindingSource contractBindingSource;
    private BindingSource jobBindingSource;
    private BindingSource cityGetResponseBindingSource;
    private System.Windows.Forms.Timer timerCities;
    private System.Windows.Forms.Timer timerJobs;
}