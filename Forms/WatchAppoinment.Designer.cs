namespace CourseWorkAt4.Forms
{
	partial class WatchAppoinment
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelFormMain = new System.Windows.Forms.TableLayoutPanel();
			this.listViewApp = new System.Windows.Forms.ListView();
			this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderTime = new System.Windows.Forms.ColumnHeader();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.labelNameFix = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelDateFix = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.labelTimeFix = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanelFormMain.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelFormMain, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 477);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanelFormMain
			// 
			this.tableLayoutPanelFormMain.ColumnCount = 2;
			this.tableLayoutPanelFormMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanelFormMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
			this.tableLayoutPanelFormMain.Controls.Add(this.listViewApp, 1, 0);
			this.tableLayoutPanelFormMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanelFormMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFormMain.Location = new System.Drawing.Point(26, 41);
			this.tableLayoutPanelFormMain.Name = "tableLayoutPanelFormMain";
			this.tableLayoutPanelFormMain.RowCount = 1;
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFormMain.Size = new System.Drawing.Size(544, 394);
			this.tableLayoutPanelFormMain.TabIndex = 0;
			// 
			// listViewApp
			// 
			this.listViewApp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderTime});
			this.listViewApp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewApp.Location = new System.Drawing.Point(193, 3);
			this.listViewApp.Name = "listViewApp";
			this.listViewApp.Size = new System.Drawing.Size(348, 388);
			this.listViewApp.TabIndex = 0;
			this.listViewApp.UseCompatibleStateImageBehavior = false;
			this.listViewApp.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "ФИО";
			this.columnHeaderName.Width = 100;
			// 
			// columnHeaderTime
			// 
			this.columnHeaderTime.Text = "Время";
			this.columnHeaderTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderTime.Width = 100;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.labelNameFix, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.labelName, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.labelDateFix, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.labelDate, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.labelTimeFix, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.labelTime, 0, 5);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 6;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02005F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02004F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02004F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02004F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02004F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.8998F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(184, 388);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// labelNameFix
			// 
			this.labelNameFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelNameFix.AutoSize = true;
			this.labelNameFix.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelNameFix.Location = new System.Drawing.Point(3, 13);
			this.labelNameFix.Name = "labelNameFix";
			this.labelNameFix.Size = new System.Drawing.Size(107, 25);
			this.labelNameFix.TabIndex = 0;
			this.labelNameFix.Text = "Имя Врача";
			this.labelNameFix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelName.Location = new System.Drawing.Point(3, 38);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(0, 25);
			this.labelName.TabIndex = 0;
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDateFix
			// 
			this.labelDateFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDateFix.AutoSize = true;
			this.labelDateFix.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDateFix.Location = new System.Drawing.Point(3, 89);
			this.labelDateFix.Name = "labelDateFix";
			this.labelDateFix.Size = new System.Drawing.Size(124, 25);
			this.labelDateFix.TabIndex = 0;
			this.labelDateFix.Text = "Дата приема";
			this.labelDateFix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDate.Location = new System.Drawing.Point(3, 114);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(0, 25);
			this.labelDate.TabIndex = 0;
			this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTimeFix
			// 
			this.labelTimeFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelTimeFix.AutoSize = true;
			this.labelTimeFix.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTimeFix.Location = new System.Drawing.Point(3, 165);
			this.labelTimeFix.Name = "labelTimeFix";
			this.labelTimeFix.Size = new System.Drawing.Size(138, 25);
			this.labelTimeFix.TabIndex = 0;
			this.labelTimeFix.Text = "Время приема";
			this.labelTimeFix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTime.Location = new System.Drawing.Point(3, 190);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(0, 25);
			this.labelTime.TabIndex = 0;
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WatchAppoinment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 477);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "WatchAppoinment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Записи на прием";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WatchAppoinment_FormClosed);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanelFormMain.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanelFormMain;
		private ListView listViewApp;
		private ColumnHeader columnHeaderName;
		private ColumnHeader columnHeaderTime;
		private TableLayoutPanel tableLayoutPanel2;
		private Label labelNameFix;
		private Label labelName;
		private Label labelDateFix;
		private Label labelDate;
		private Label labelTimeFix;
		private Label labelTime;
	}
}