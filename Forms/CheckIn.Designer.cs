namespace CourseWorkAt4.Forms
{
	partial class CheckIn
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
			this.tableLayoutPanelFormMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.labelDate = new System.Windows.Forms.Label();
			this.labelId = new System.Windows.Forms.Label();
			this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.buttonDateNow = new System.Windows.Forms.Button();
			this.buttonSaveCheckIn = new System.Windows.Forms.Button();
			this.labelMsg = new System.Windows.Forms.Label();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelFormMain.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelFormMain, 1, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(429, 451);
			this.tableLayoutPanelMain.TabIndex = 3;
			// 
			// tableLayoutPanelFormMain
			// 
			this.tableLayoutPanelFormMain.ColumnCount = 1;
			this.tableLayoutPanelFormMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFormMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanelFormMain.Controls.Add(this.labelMsg, 0, 1);
			this.tableLayoutPanelFormMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFormMain.Location = new System.Drawing.Point(17, 53);
			this.tableLayoutPanelFormMain.Name = "tableLayoutPanelFormMain";
			this.tableLayoutPanelFormMain.RowCount = 2;
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelFormMain.Size = new System.Drawing.Size(394, 344);
			this.tableLayoutPanelFormMain.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.labelDate, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.labelId, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxTime, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBoxId, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.buttonDateNow, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.buttonSaveCheckIn, 0, 5);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 6;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 252);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// labelDate
			// 
			this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDate.Location = new System.Drawing.Point(3, 98);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(59, 28);
			this.labelDate.TabIndex = 0;
			this.labelDate.Text = "Дата ";
			// 
			// labelId
			// 
			this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelId.AutoSize = true;
			this.labelId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelId.Location = new System.Drawing.Point(3, 14);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(90, 28);
			this.labelId.TabIndex = 0;
			this.labelId.Text = "ID Врача";
			// 
			// maskedTextBoxTime
			// 
			this.maskedTextBoxTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maskedTextBoxTime.Location = new System.Drawing.Point(3, 129);
			this.maskedTextBoxTime.Mask = "00-00-0000";
			this.maskedTextBoxTime.Name = "maskedTextBoxTime";
			this.maskedTextBoxTime.Size = new System.Drawing.Size(382, 27);
			this.maskedTextBoxTime.TabIndex = 15;
			this.maskedTextBoxTime.ValidatingType = typeof(System.DateTime);
			// 
			// textBoxId
			// 
			this.textBoxId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxId.Location = new System.Drawing.Point(3, 45);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(382, 27);
			this.textBoxId.TabIndex = 18;
			// 
			// buttonDateNow
			// 
			this.buttonDateNow.AutoSize = true;
			this.buttonDateNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonDateNow.Location = new System.Drawing.Point(3, 171);
			this.buttonDateNow.Name = "buttonDateNow";
			this.buttonDateNow.Size = new System.Drawing.Size(115, 36);
			this.buttonDateNow.TabIndex = 2;
			this.buttonDateNow.Text = "Сегодня";
			this.buttonDateNow.UseVisualStyleBackColor = true;
			this.buttonDateNow.Click += new System.EventHandler(this.buttonDateNow_Click);
			// 
			// buttonSaveCheckIn
			// 
			this.buttonSaveCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveCheckIn.AutoSize = true;
			this.buttonSaveCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSaveCheckIn.Location = new System.Drawing.Point(185, 213);
			this.buttonSaveCheckIn.Name = "buttonSaveCheckIn";
			this.buttonSaveCheckIn.Size = new System.Drawing.Size(200, 36);
			this.buttonSaveCheckIn.TabIndex = 2;
			this.buttonSaveCheckIn.Text = "Сохранить отметку";
			this.buttonSaveCheckIn.UseVisualStyleBackColor = true;
			this.buttonSaveCheckIn.Click += new System.EventHandler(this.buttonWatchAppoint_Click);
			// 
			// labelMsg
			// 
			this.labelMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelMsg.AutoSize = true;
			this.labelMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMsg.ForeColor = System.Drawing.Color.Brown;
			this.labelMsg.Location = new System.Drawing.Point(197, 287);
			this.labelMsg.Name = "labelMsg";
			this.labelMsg.Size = new System.Drawing.Size(0, 28);
			this.labelMsg.TabIndex = 0;
			this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CheckIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 451);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CheckIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Отметка ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckIn_FormClosed);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelFormMain.ResumeLayout(false);
			this.tableLayoutPanelFormMain.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutPanelFormMain;
		private TableLayoutPanel tableLayoutPanel2;
		private Label labelDate;
		private Label labelId;
		private MaskedTextBox maskedTextBoxTime;
		private TextBox textBoxId;
		private Button buttonDateNow;
		private Button buttonSaveCheckIn;
		private Label labelMsg;
	}
}