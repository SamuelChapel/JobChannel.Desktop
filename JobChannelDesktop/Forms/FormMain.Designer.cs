namespace JobChannelDesktop;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.TilteLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CompanyBtn = new System.Windows.Forms.Button();
            this.JobOfferBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelMain.Controls.Add(this.TilteLabel, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(785, 548);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // TilteLabel
            // 
            this.TilteLabel.AutoSize = true;
            this.TilteLabel.BackColor = System.Drawing.Color.Gray;
            this.TilteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilteLabel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TilteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TilteLabel.Location = new System.Drawing.Point(3, 0);
            this.TilteLabel.Name = "TilteLabel";
            this.TilteLabel.Size = new System.Drawing.Size(779, 120);
            this.TilteLabel.TabIndex = 0;
            this.TilteLabel.Text = "JobChannel";
            this.TilteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.ExitBtn, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.CompanyBtn, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.JobOfferBtn, 0, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(779, 422);
            this.tableLayoutPanelButtons.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitBtn.Location = new System.Drawing.Point(484, 266);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(200, 100);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Quitter";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(94, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CompanyBtn
            // 
            this.CompanyBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompanyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompanyBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompanyBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CompanyBtn.Location = new System.Drawing.Point(484, 55);
            this.CompanyBtn.Name = "CompanyBtn";
            this.CompanyBtn.Size = new System.Drawing.Size(200, 100);
            this.CompanyBtn.TabIndex = 1;
            this.CompanyBtn.Text = "Entreprises";
            this.CompanyBtn.UseVisualStyleBackColor = false;
            // 
            // JobOfferBtn
            // 
            this.JobOfferBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JobOfferBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.JobOfferBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JobOfferBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JobOfferBtn.Location = new System.Drawing.Point(94, 55);
            this.JobOfferBtn.Name = "JobOfferBtn";
            this.JobOfferBtn.Size = new System.Drawing.Size(200, 100);
            this.JobOfferBtn.TabIndex = 0;
            this.JobOfferBtn.Text = "Offres d\'emploi";
            this.JobOfferBtn.UseVisualStyleBackColor = false;
            this.JobOfferBtn.Click += new System.EventHandler(this.JobOfferBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 548);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MaximumSize = new System.Drawing.Size(1298, 824);
            this.MinimumSize = new System.Drawing.Size(803, 595);
            this.Name = "FormMain";
            this.Text = "JobChannel";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tableLayoutPanelMain;
    private Label TilteLabel;
    private TableLayoutPanel tableLayoutPanelButtons;
    private Button JobOfferBtn;
    private Button ExitBtn;
    private Button button2;
    private Button CompanyBtn;
}
