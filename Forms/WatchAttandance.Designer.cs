namespace CourseWorkAt4.Forms
{
	partial class WatchAttandance
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
			this.tableLayoutPaneDateDB = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxHI = new System.Windows.Forms.TextBox();
			this.labelHI = new System.Windows.Forms.Label();
			this.labelDateTime = new System.Windows.Forms.Label();
			this.labelId = new System.Windows.Forms.Label();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.maskedTextBoxDateTime = new System.Windows.Forms.MaskedTextBox();
			this.buttonDateNow = new System.Windows.Forms.Button();
			this.tableLayoutPanelMedFAndSave = new System.Windows.Forms.TableLayoutPanel();
			this.buttonCheck = new System.Windows.Forms.Button();
			this.labelMedFind = new System.Windows.Forms.Label();
			this.textBoxMedFind = new System.Windows.Forms.TextBox();
			this.labelMsg = new System.Windows.Forms.Label();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanelFormMain.SuspendLayout();
			this.tableLayoutPaneDateDB.SuspendLayout();
			this.tableLayoutPanelMedFAndSave.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelFormMain, 1, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(544, 541);
			this.tableLayoutPanelMain.TabIndex = 1;
			this.tableLayoutPanelMain.UseWaitCursor = true;
			// 
			// tableLayoutPanelFormMain
			// 
			this.tableLayoutPanelFormMain.ColumnCount = 1;
			this.tableLayoutPanelFormMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelFormMain.Controls.Add(this.tableLayoutPaneDateDB, 0, 0);
			this.tableLayoutPanelFormMain.Controls.Add(this.tableLayoutPanelMedFAndSave, 0, 1);
			this.tableLayoutPanelFormMain.Controls.Add(this.labelMsg, 0, 2);
			this.tableLayoutPanelFormMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelFormMain.Location = new System.Drawing.Point(25, 23);
			this.tableLayoutPanelFormMain.Name = "tableLayoutPanelFormMain";
			this.tableLayoutPanelFormMain.RowCount = 3;
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.42574F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.77228F));
			this.tableLayoutPanelFormMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.80198F));
			this.tableLayoutPanelFormMain.Size = new System.Drawing.Size(494, 494);
			this.tableLayoutPanelFormMain.TabIndex = 0;
			this.tableLayoutPanelFormMain.UseWaitCursor = true;
			// 
			// tableLayoutPaneDateDB
			// 
			this.tableLayoutPaneDateDB.ColumnCount = 2;
			this.tableLayoutPaneDateDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPaneDateDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPaneDateDB.Controls.Add(this.textBoxHI, 0, 1);
			this.tableLayoutPaneDateDB.Controls.Add(this.labelHI, 0, 0);
			this.tableLayoutPaneDateDB.Controls.Add(this.labelDateTime, 1, 0);
			this.tableLayoutPaneDateDB.Controls.Add(this.labelId, 0, 2);
			this.tableLayoutPaneDateDB.Controls.Add(this.textBoxId, 0, 3);
			this.tableLayoutPaneDateDB.Controls.Add(this.maskedTextBoxDateTime, 1, 1);
			this.tableLayoutPaneDateDB.Controls.Add(this.buttonDateNow, 1, 2);
			this.tableLayoutPaneDateDB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPaneDateDB.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPaneDateDB.Name = "tableLayoutPaneDateDB";
			this.tableLayoutPaneDateDB.RowCount = 4;
			this.tableLayoutPaneDateDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPaneDateDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPaneDateDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPaneDateDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPaneDateDB.Size = new System.Drawing.Size(488, 178);
			this.tableLayoutPaneDateDB.TabIndex = 0;
			this.tableLayoutPaneDateDB.UseWaitCursor = true;
			// 
			// textBoxHI
			// 
			this.textBoxHI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxHI.Location = new System.Drawing.Point(3, 47);
			this.textBoxHI.Name = "textBoxHI";
			this.textBoxHI.Size = new System.Drawing.Size(238, 27);
			this.textBoxHI.TabIndex = 0;
			this.textBoxHI.UseWaitCursor = true;
			// 
			// labelHI
			// 
			this.labelHI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelHI.AutoSize = true;
			this.labelHI.Location = new System.Drawing.Point(3, 24);
			this.labelHI.Name = "labelHI";
			this.labelHI.Size = new System.Drawing.Size(157, 20);
			this.labelHI.TabIndex = 1;
			this.labelHI.Text = "Мед. полис пациента";
			this.labelHI.UseWaitCursor = true;
			// 
			// labelDateTime
			// 
			this.labelDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDateTime.AutoSize = true;
			this.labelDateTime.Location = new System.Drawing.Point(247, 24);
			this.labelDateTime.Name = "labelDateTime";
			this.labelDateTime.Size = new System.Drawing.Size(137, 20);
			this.labelDateTime.TabIndex = 1;
			this.labelDateTime.Text = "Время посещения";
			this.labelDateTime.UseWaitCursor = true;
			// 
			// labelId
			// 
			this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelId.AutoSize = true;
			this.labelId.Location = new System.Drawing.Point(3, 112);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(70, 20);
			this.labelId.TabIndex = 1;
			this.labelId.Text = "ID Врача";
			this.labelId.UseWaitCursor = true;
			// 
			// textBoxId
			// 
			this.textBoxId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxId.Location = new System.Drawing.Point(3, 135);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(238, 27);
			this.textBoxId.TabIndex = 2;
			this.textBoxId.UseWaitCursor = true;
			// 
			// maskedTextBoxDateTime
			// 
			this.maskedTextBoxDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.maskedTextBoxDateTime.Location = new System.Drawing.Point(247, 47);
			this.maskedTextBoxDateTime.Mask = "00-00-0000 00:00";
			this.maskedTextBoxDateTime.Name = "maskedTextBoxDateTime";
			this.maskedTextBoxDateTime.Size = new System.Drawing.Size(238, 27);
			this.maskedTextBoxDateTime.TabIndex = 3;
			this.maskedTextBoxDateTime.UseWaitCursor = true;
			this.maskedTextBoxDateTime.ValidatingType = typeof(System.DateTime);
			// 
			// buttonDateNow
			// 
			this.buttonDateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDateNow.Location = new System.Drawing.Point(391, 91);
			this.buttonDateNow.Name = "buttonDateNow";
			this.buttonDateNow.Size = new System.Drawing.Size(94, 29);
			this.buttonDateNow.TabIndex = 4;
			this.buttonDateNow.Text = "Сегодня";
			this.buttonDateNow.UseVisualStyleBackColor = true;
			this.buttonDateNow.UseWaitCursor = true;
			this.buttonDateNow.Click += new System.EventHandler(this.buttonDateNow_Click);
			// 
			// tableLayoutPanelMedFAndSave
			// 
			this.tableLayoutPanelMedFAndSave.ColumnCount = 1;
			this.tableLayoutPanelMedFAndSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMedFAndSave.Controls.Add(this.buttonCheck, 0, 2);
			this.tableLayoutPanelMedFAndSave.Controls.Add(this.labelMedFind, 0, 0);
			this.tableLayoutPanelMedFAndSave.Controls.Add(this.textBoxMedFind, 0, 1);
			this.tableLayoutPanelMedFAndSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMedFAndSave.Location = new System.Drawing.Point(3, 187);
			this.tableLayoutPanelMedFAndSave.Name = "tableLayoutPanelMedFAndSave";
			this.tableLayoutPanelMedFAndSave.RowCount = 3;
			this.tableLayoutPanelMedFAndSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.68504F));
			this.tableLayoutPanelMedFAndSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.62992F));
			this.tableLayoutPanelMedFAndSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.68504F));
			this.tableLayoutPanelMedFAndSave.Size = new System.Drawing.Size(488, 205);
			this.tableLayoutPanelMedFAndSave.TabIndex = 1;
			this.tableLayoutPanelMedFAndSave.UseWaitCursor = true;
			// 
			// buttonCheck
			// 
			this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCheck.Location = new System.Drawing.Point(372, 167);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new System.Drawing.Size(113, 29);
			this.buttonCheck.TabIndex = 7;
			this.buttonCheck.Text = "Посмотреть";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.UseWaitCursor = true;
			this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click_1);
			// 
			// labelMedFind
			// 
			this.labelMedFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelMedFind.AutoSize = true;
			this.labelMedFind.Location = new System.Drawing.Point(3, 20);
			this.labelMedFind.Name = "labelMedFind";
			this.labelMedFind.Size = new System.Drawing.Size(94, 20);
			this.labelMedFind.TabIndex = 1;
			this.labelMedFind.Text = "Заключение";
			this.labelMedFind.UseWaitCursor = true;
			// 
			// textBoxMedFind
			// 
			this.textBoxMedFind.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxMedFind.Location = new System.Drawing.Point(3, 43);
			this.textBoxMedFind.Multiline = true;
			this.textBoxMedFind.Name = "textBoxMedFind";
			this.textBoxMedFind.ReadOnly = true;
			this.textBoxMedFind.Size = new System.Drawing.Size(482, 118);
			this.textBoxMedFind.TabIndex = 2;
			this.textBoxMedFind.UseWaitCursor = true;
			// 
			// labelMsg
			// 
			this.labelMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMsg.AutoSize = true;
			this.labelMsg.ForeColor = System.Drawing.Color.Brown;
			this.labelMsg.Location = new System.Drawing.Point(247, 395);
			this.labelMsg.Name = "labelMsg";
			this.labelMsg.Size = new System.Drawing.Size(0, 20);
			this.labelMsg.TabIndex = 2;
			this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMsg.UseWaitCursor = true;
			// 
			// WatchAttandance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 541);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "WatchAttandance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "История посещений";
			this.UseWaitCursor = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WatchAttandance_FormClosed);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelFormMain.ResumeLayout(false);
			this.tableLayoutPanelFormMain.PerformLayout();
			this.tableLayoutPaneDateDB.ResumeLayout(false);
			this.tableLayoutPaneDateDB.PerformLayout();
			this.tableLayoutPanelMedFAndSave.ResumeLayout(false);
			this.tableLayoutPanelMedFAndSave.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutPanelFormMain;
		private TableLayoutPanel tableLayoutPaneDateDB;
		private TextBox textBoxHI;
		private Label labelHI;
		private Label labelDateTime;
		private Label labelId;
		private TextBox textBoxId;
		private MaskedTextBox maskedTextBoxDateTime;
		private Button buttonDateNow;
		private TableLayoutPanel tableLayoutPanelMedFAndSave;
		private Label labelMedFind;
		private TextBox textBoxMedFind;
		private Label labelMsg;
		private Button buttonCheck;
	}
}