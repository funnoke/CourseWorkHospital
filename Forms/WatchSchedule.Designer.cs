namespace CourseWorkAt4.Forms
{
	partial class WatchSchedule
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
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelInsideMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanelSearch = new System.Windows.Forms.TableLayoutPanel();
			this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
			this.listViewSchedule = new System.Windows.Forms.ListView();
			this.DoctorName = new System.Windows.Forms.ColumnHeader();
			this.Monday = new System.Windows.Forms.ColumnHeader();
			this.Tuesday = new System.Windows.Forms.ColumnHeader();
			this.Wednesday = new System.Windows.Forms.ColumnHeader();
			this.Thursday = new System.Windows.Forms.ColumnHeader();
			this.Friday = new System.Windows.Forms.ColumnHeader();
			this.Saturday = new System.Windows.Forms.ColumnHeader();
			this.Sunday = new System.Windows.Forms.ColumnHeader();
			this.RangeTime = new System.Windows.Forms.ColumnHeader();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelInsideMain.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanelSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelInsideMain, 1, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(898, 626);
			this.tableLayoutPanelMain.TabIndex = 0;
			// 
			// tableLayoutPanelInsideMain
			// 
			this.tableLayoutPanelInsideMain.ColumnCount = 1;
			this.tableLayoutPanelInsideMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelInsideMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanelInsideMain.Controls.Add(this.tableLayoutPanelSearch, 0, 1);
			this.tableLayoutPanelInsideMain.Controls.Add(this.listViewSchedule, 0, 2);
			this.tableLayoutPanelInsideMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelInsideMain.Location = new System.Drawing.Point(78, 16);
			this.tableLayoutPanelInsideMain.Name = "tableLayoutPanelInsideMain";
			this.tableLayoutPanelInsideMain.RowCount = 3;
			this.tableLayoutPanelInsideMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelInsideMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelInsideMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanelInsideMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelInsideMain.Size = new System.Drawing.Size(794, 594);
			this.tableLayoutPanelInsideMain.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 53);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(53, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Специальность врача";
			// 
			// tableLayoutPanelSearch
			// 
			this.tableLayoutPanelSearch.ColumnCount = 3;
			this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelSearch.Controls.Add(this.comboBoxSpeciality, 1, 0);
			this.tableLayoutPanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelSearch.Location = new System.Drawing.Point(3, 62);
			this.tableLayoutPanelSearch.Name = "tableLayoutPanelSearch";
			this.tableLayoutPanelSearch.RowCount = 1;
			this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelSearch.Size = new System.Drawing.Size(788, 53);
			this.tableLayoutPanelSearch.TabIndex = 0;
			// 
			// comboBoxSpeciality
			// 
			this.comboBoxSpeciality.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxSpeciality.FormattingEnabled = true;
			this.comboBoxSpeciality.Location = new System.Drawing.Point(53, 12);
			this.comboBoxSpeciality.Name = "comboBoxSpeciality";
			this.comboBoxSpeciality.Size = new System.Drawing.Size(363, 28);
			this.comboBoxSpeciality.TabIndex = 0;
			this.comboBoxSpeciality.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeciality_SelectedIndexChanged);
			// 
			// listViewSchedule
			// 
			this.listViewSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DoctorName,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday,
            this.RangeTime});
			this.listViewSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewSchedule.Location = new System.Drawing.Point(3, 121);
			this.listViewSchedule.Name = "listViewSchedule";
			this.listViewSchedule.Size = new System.Drawing.Size(788, 470);
			this.listViewSchedule.TabIndex = 1;
			this.listViewSchedule.UseCompatibleStateImageBehavior = false;
			this.listViewSchedule.View = System.Windows.Forms.View.Details;
			// 
			// DoctorName
			// 
			this.DoctorName.Text = "ФИО";
			this.DoctorName.Width = 100;
			// 
			// Monday
			// 
			this.Monday.Text = "Понедельник";
			this.Monday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Monday.Width = 80;
			// 
			// Tuesday
			// 
			this.Tuesday.Text = "Вторник";
			this.Tuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Tuesday.Width = 80;
			// 
			// Wednesday
			// 
			this.Wednesday.Text = "Среда";
			this.Wednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Wednesday.Width = 80;
			// 
			// Thursday
			// 
			this.Thursday.Text = "Четверг";
			this.Thursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Thursday.Width = 80;
			// 
			// Friday
			// 
			this.Friday.Text = "Пятница";
			this.Friday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Friday.Width = 80;
			// 
			// Saturday
			// 
			this.Saturday.Text = "Суббота";
			this.Saturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Saturday.Width = 80;
			// 
			// Sunday
			// 
			this.Sunday.Text = "Воскресенье";
			this.Sunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Sunday.Width = 80;
			// 
			// RangeTime
			// 
			this.RangeTime.Text = "Интервал времени";
			this.RangeTime.Width = 80;
			// 
			// WatchSchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 626);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "WatchSchedule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Расписание работы врача";
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelInsideMain.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanelSearch.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutPanelInsideMain;
		private TableLayoutPanel tableLayoutPanelSearch;
		private ComboBox comboBoxSpeciality;
		private ListView listViewSchedule;
		private ColumnHeader DoctorName;
		private ColumnHeader Monday;
		private ColumnHeader Tuesday;
		private ColumnHeader Wednesday;
		private ColumnHeader Thursday;
		private ColumnHeader Friday;
		private ColumnHeader Saturday;
		private ColumnHeader Sunday;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private ColumnHeader RangeTime;
	}
}