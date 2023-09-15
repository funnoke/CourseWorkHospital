namespace CourseWorkAt4.Forms
{
	partial class UserPatient
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
			this.buttonSingUpAppointment = new System.Windows.Forms.Button();
			this.buttonWatchSchedule = new System.Windows.Forms.Button();
			this.buttonEditService = new System.Windows.Forms.Button();
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
			this.tableLayoutPanel1.Controls.Add(this.buttonSingUpAppointment, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonWatchSchedule, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonEditService, 0, 2);
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
			// buttonSingUpAppointment
			// 
			this.buttonSingUpAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonSingUpAppointment.AutoSize = true;
			this.buttonSingUpAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSingUpAppointment.Location = new System.Drawing.Point(61, 29);
			this.buttonSingUpAppointment.Name = "buttonSingUpAppointment";
			this.buttonSingUpAppointment.Size = new System.Drawing.Size(372, 38);
			this.buttonSingUpAppointment.TabIndex = 0;
			this.buttonSingUpAppointment.Text = "Записать на прием к врачу";
			this.buttonSingUpAppointment.UseVisualStyleBackColor = true;
			this.buttonSingUpAppointment.Click += new System.EventHandler(this.buttonSingUpAppointment_Click);
			// 
			// buttonWatchSchedule
			// 
			this.buttonWatchSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonWatchSchedule.AutoSize = true;
			this.buttonWatchSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonWatchSchedule.Location = new System.Drawing.Point(61, 126);
			this.buttonWatchSchedule.Name = "buttonWatchSchedule";
			this.buttonWatchSchedule.Size = new System.Drawing.Size(372, 38);
			this.buttonWatchSchedule.TabIndex = 0;
			this.buttonWatchSchedule.Text = "Посмотреть график работы врача";
			this.buttonWatchSchedule.UseVisualStyleBackColor = true;
			this.buttonWatchSchedule.Click += new System.EventHandler(this.buttonWatchSchedule_Click);
			// 
			// buttonEditService
			// 
			this.buttonEditService.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonEditService.AutoSize = true;
			this.buttonEditService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonEditService.Location = new System.Drawing.Point(61, 225);
			this.buttonEditService.Name = "buttonEditService";
			this.buttonEditService.Size = new System.Drawing.Size(372, 38);
			this.buttonEditService.TabIndex = 0;
			this.buttonEditService.Text = "Посмотреть историю посещения";
			this.buttonEditService.UseVisualStyleBackColor = true;
			this.buttonEditService.Click += new System.EventHandler(this.buttonEditService_Click);
			// 
			// UserPatient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 596);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UserPatient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Учетная запись: Пациент";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPatient_FormClosed);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutPanel1;
		private Button buttonSingUpAppointment;
		private Button buttonWatchSchedule;
		private Button buttonEditService;
	}

}
