namespace CourseWorkAt4.Forms
{
	partial class EditSchedule
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.comboBoxDayOfWeek = new System.Windows.Forms.ComboBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelId = new System.Windows.Forms.Label();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.buttonSaveChanges = new System.Windows.Forms.Button();
			this.labelDayOfWeek = new System.Windows.Forms.Label();
			this.labelRangeTime = new System.Windows.Forms.Label();
			this.labelStartTime = new System.Windows.Forms.Label();
			this.labelEndTime = new System.Windows.Forms.Label();
			this.maskedTextBoxStartTime = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBoxEndTime = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBoxRangeTime = new System.Windows.Forms.MaskedTextBox();
			this.labelMsg = new System.Windows.Forms.Label();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelFormMain.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelFormMain, 1, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanelMain.TabIndex = 1;
			// 
			// tableLayoutPanelFormMain
			// 
			this.tableLayoutPanelFormMain.ColumnCount = 1;
			this.tableLayoutPanelFormMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFormMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanelFormMain.Controls.Add(this.labelMsg, 0, 1);
			this.tableLayoutPanelFormMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFormMain.Location = new System.Drawing.Point(53, 28);
			this.tableLayoutPanelFormMain.Name = "tableLayoutPanelFormMain";
			this.tableLayoutPanelFormMain.RowCount = 2;
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelFormMain.Size = new System.Drawing.Size(694, 394);
			this.tableLayoutPanelFormMain.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.comboBoxDayOfWeek, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.textBoxName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelId, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxId, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonSaveChanges, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelDayOfWeek, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelRangeTime, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelStartTime, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelEndTime, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStartTime, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxEndTime, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxRangeTime, 2, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 328);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// comboBoxDayOfWeek
			// 
			this.comboBoxDayOfWeek.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxDayOfWeek.FormattingEnabled = true;
			this.comboBoxDayOfWeek.Location = new System.Drawing.Point(3, 233);
			this.comboBoxDayOfWeek.Name = "comboBoxDayOfWeek";
			this.comboBoxDayOfWeek.Size = new System.Drawing.Size(323, 28);
			this.comboBoxDayOfWeek.TabIndex = 11;
			// 
			// textBoxName
			// 
			this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxName.Location = new System.Drawing.Point(3, 49);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(323, 27);
			this.textBoxName.TabIndex = 10;
			// 
			// labelName
			// 
			this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelName.Location = new System.Drawing.Point(3, 18);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(110, 28);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Имя врача";
			// 
			// labelId
			// 
			this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelId.AutoSize = true;
			this.labelId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelId.Location = new System.Drawing.Point(362, 18);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(175, 28);
			this.labelId.TabIndex = 0;
			this.labelId.Text = "ID (опционально)";
			// 
			// textBoxId
			// 
			this.textBoxId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxId.Location = new System.Drawing.Point(362, 49);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(323, 27);
			this.textBoxId.TabIndex = 5;
			// 
			// buttonSaveChanges
			// 
			this.buttonSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveChanges.AutoSize = true;
			this.buttonSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSaveChanges.Location = new System.Drawing.Point(492, 279);
			this.buttonSaveChanges.Name = "buttonSaveChanges";
			this.buttonSaveChanges.Size = new System.Drawing.Size(193, 38);
			this.buttonSaveChanges.TabIndex = 2;
			this.buttonSaveChanges.Text = "Сохранить данные";
			this.buttonSaveChanges.UseVisualStyleBackColor = true;
			this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
			// 
			// labelDayOfWeek
			// 
			this.labelDayOfWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDayOfWeek.AutoSize = true;
			this.labelDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDayOfWeek.Location = new System.Drawing.Point(3, 202);
			this.labelDayOfWeek.Name = "labelDayOfWeek";
			this.labelDayOfWeek.Size = new System.Drawing.Size(129, 28);
			this.labelDayOfWeek.TabIndex = 0;
			this.labelDayOfWeek.Text = "День недели";
			// 
			// labelRangeTime
			// 
			this.labelRangeTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelRangeTime.AutoSize = true;
			this.labelRangeTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelRangeTime.Location = new System.Drawing.Point(362, 202);
			this.labelRangeTime.Name = "labelRangeTime";
			this.labelRangeTime.Size = new System.Drawing.Size(317, 28);
			this.labelRangeTime.TabIndex = 0;
			this.labelRangeTime.Text = "Интервал времени приема (мин)";
			// 
			// labelStartTime
			// 
			this.labelStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelStartTime.AutoSize = true;
			this.labelStartTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelStartTime.Location = new System.Drawing.Point(3, 110);
			this.labelStartTime.Name = "labelStartTime";
			this.labelStartTime.Size = new System.Drawing.Size(138, 28);
			this.labelStartTime.TabIndex = 0;
			this.labelStartTime.Text = "Время начала";
			// 
			// labelEndTime
			// 
			this.labelEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelEndTime.AutoSize = true;
			this.labelEndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelEndTime.Location = new System.Drawing.Point(362, 110);
			this.labelEndTime.Name = "labelEndTime";
			this.labelEndTime.Size = new System.Drawing.Size(175, 28);
			this.labelEndTime.TabIndex = 0;
			this.labelEndTime.Text = "Время окончания";
			// 
			// maskedTextBoxStartTime
			// 
			this.maskedTextBoxStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maskedTextBoxStartTime.Location = new System.Drawing.Point(3, 141);
			this.maskedTextBoxStartTime.Mask = "00:00";
			this.maskedTextBoxStartTime.Name = "maskedTextBoxStartTime";
			this.maskedTextBoxStartTime.Size = new System.Drawing.Size(323, 27);
			this.maskedTextBoxStartTime.TabIndex = 12;
			this.maskedTextBoxStartTime.ValidatingType = typeof(System.DateTime);
			// 
			// maskedTextBoxEndTime
			// 
			this.maskedTextBoxEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maskedTextBoxEndTime.Location = new System.Drawing.Point(362, 141);
			this.maskedTextBoxEndTime.Mask = "00:00";
			this.maskedTextBoxEndTime.Name = "maskedTextBoxEndTime";
			this.maskedTextBoxEndTime.Size = new System.Drawing.Size(323, 27);
			this.maskedTextBoxEndTime.TabIndex = 13;
			this.maskedTextBoxEndTime.ValidatingType = typeof(System.DateTime);
			// 
			// maskedTextBoxRangeTime
			// 
			this.maskedTextBoxRangeTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maskedTextBoxRangeTime.Location = new System.Drawing.Point(362, 233);
			this.maskedTextBoxRangeTime.Mask = "00:00";
			this.maskedTextBoxRangeTime.Name = "maskedTextBoxRangeTime";
			this.maskedTextBoxRangeTime.Size = new System.Drawing.Size(323, 27);
			this.maskedTextBoxRangeTime.TabIndex = 14;
			this.maskedTextBoxRangeTime.ValidatingType = typeof(System.DateTime);
			// 
			// labelMsg
			// 
			this.labelMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelMsg.AutoSize = true;
			this.labelMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMsg.ForeColor = System.Drawing.Color.Brown;
			this.labelMsg.Location = new System.Drawing.Point(347, 350);
			this.labelMsg.Name = "labelMsg";
			this.labelMsg.Size = new System.Drawing.Size(0, 28);
			this.labelMsg.TabIndex = 0;
			this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EditSchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "EditSchedule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактировать расписание";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditSchedule_FormClosed);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelFormMain.ResumeLayout(false);
			this.tableLayoutPanelFormMain.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutPanelFormMain;
		private TableLayoutPanel tableLayoutPanel1;
		private TextBox textBoxName;
		private Label labelName;
		private Label labelId;
		private TextBox textBoxId;
		private Button buttonSaveChanges;
		private Label labelDayOfWeek;
		private Label labelRangeTime;
		private Label labelStartTime;
		private Label labelEndTime;
		private Label labelMsg;
		private ComboBox comboBoxDayOfWeek;
		private MaskedTextBox maskedTextBoxStartTime;
		private MaskedTextBox maskedTextBoxEndTime;
		private MaskedTextBox maskedTextBoxRangeTime;
	}
}