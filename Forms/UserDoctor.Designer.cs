namespace CourseWorkAt4.Forms
{
	partial class UserDoctor
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonWatchSchedule = new System.Windows.Forms.Button();
			this.buttonWatchAttandance = new System.Windows.Forms.Button();
			this.buttonEditAttandance = new System.Windows.Forms.Button();
			this.tableLayoutPanelMain.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 1, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(559, 596);
			this.tableLayoutPanelMain.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.buttonWatchSchedule, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonWatchAttandance, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonEditAttandance, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 151);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 294);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// buttonWatchSchedule
			// 
			this.buttonWatchSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonWatchSchedule.AutoSize = true;
			this.buttonWatchSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonWatchSchedule.Location = new System.Drawing.Point(61, 29);
			this.buttonWatchSchedule.Name = "buttonWatchSchedule";
			this.buttonWatchSchedule.Size = new System.Drawing.Size(372, 38);
			this.buttonWatchSchedule.TabIndex = 0;
			this.buttonWatchSchedule.Text = "Посмотреть график работы врача";
			this.buttonWatchSchedule.UseVisualStyleBackColor = true;
			this.buttonWatchSchedule.Click += new System.EventHandler(this.buttonWatchSchedule_Click);
			// 
			// buttonWatchAttandance
			// 
			this.buttonWatchAttandance.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonWatchAttandance.AutoSize = true;
			this.buttonWatchAttandance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonWatchAttandance.Location = new System.Drawing.Point(61, 126);
			this.buttonWatchAttandance.Name = "buttonWatchAttandance";
			this.buttonWatchAttandance.Size = new System.Drawing.Size(372, 38);
			this.buttonWatchAttandance.TabIndex = 0;
			this.buttonWatchAttandance.Text = "Посмотреть историю посещения";
			this.buttonWatchAttandance.UseVisualStyleBackColor = true;
			this.buttonWatchAttandance.Click += new System.EventHandler(this.buttonWatchAttandance_Click);
			// 
			// buttonEditAttandance
			// 
			this.buttonEditAttandance.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonEditAttandance.AutoSize = true;
			this.buttonEditAttandance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonEditAttandance.Location = new System.Drawing.Point(61, 225);
			this.buttonEditAttandance.Name = "buttonEditAttandance";
			this.buttonEditAttandance.Size = new System.Drawing.Size(372, 38);
			this.buttonEditAttandance.TabIndex = 0;
			this.buttonEditAttandance.Text = "Редактировать историю посещения";
			this.buttonEditAttandance.UseVisualStyleBackColor = true;
			this.buttonEditAttandance.Click += new System.EventHandler(this.buttonEditAttandance_Click);
			// 
			// UserDoctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 596);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UserDoctor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Учетная запись: Врач";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDoctor_FormClosed);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutPanel1;
		private Button buttonWatchSchedule;
		private Button buttonWatchAttandance;
		private Button buttonEditAttandance;
	}
}