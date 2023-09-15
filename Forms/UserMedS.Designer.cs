namespace CourseWorkAt4.Forms
{
	partial class UserMedS
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonSingUpAppointment = new System.Windows.Forms.Button();
			this.buttonWatchSchedule = new System.Windows.Forms.Button();
			this.buttonEditSchedule = new System.Windows.Forms.Button();
			this.buttonCheckSchedule = new System.Windows.Forms.Button();
			this.buttonAddUser = new System.Windows.Forms.Button();
			this.buttonAddAcc = new System.Windows.Forms.Button();
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
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
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
			this.tableLayoutPanel1.Controls.Add(this.buttonEditSchedule, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.buttonCheckSchedule, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.buttonAddUser, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.buttonAddAcc, 0, 5);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 51);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 494);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// buttonSingUpAppointment
			// 
			this.buttonSingUpAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonSingUpAppointment.AutoSize = true;
			this.buttonSingUpAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSingUpAppointment.Location = new System.Drawing.Point(61, 22);
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
			this.buttonWatchSchedule.Location = new System.Drawing.Point(61, 104);
			this.buttonWatchSchedule.Name = "buttonWatchSchedule";
			this.buttonWatchSchedule.Size = new System.Drawing.Size(372, 38);
			this.buttonWatchSchedule.TabIndex = 0;
			this.buttonWatchSchedule.Text = "Посмотреть график работы врача";
			this.buttonWatchSchedule.UseVisualStyleBackColor = true;
			this.buttonWatchSchedule.Click += new System.EventHandler(this.buttonWatchSchedule_Click);
			// 
			// buttonEditSchedule
			// 
			this.buttonEditSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonEditSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonEditSchedule.Location = new System.Drawing.Point(61, 186);
			this.buttonEditSchedule.Name = "buttonEditSchedule";
			this.buttonEditSchedule.Size = new System.Drawing.Size(372, 38);
			this.buttonEditSchedule.TabIndex = 0;
			this.buttonEditSchedule.Text = "Редактировать график работы врачей";
			this.buttonEditSchedule.UseVisualStyleBackColor = true;
			this.buttonEditSchedule.Click += new System.EventHandler(this.buttonEditSchedule_Click);
			// 
			// buttonCheckSchedule
			// 
			this.buttonCheckSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonCheckSchedule.AutoSize = true;
			this.buttonCheckSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonCheckSchedule.Location = new System.Drawing.Point(61, 268);
			this.buttonCheckSchedule.Name = "buttonCheckSchedule";
			this.buttonCheckSchedule.Size = new System.Drawing.Size(372, 38);
			this.buttonCheckSchedule.TabIndex = 0;
			this.buttonCheckSchedule.Text = "Отметить выход врача на смену";
			this.buttonCheckSchedule.UseVisualStyleBackColor = true;
			this.buttonCheckSchedule.Click += new System.EventHandler(this.buttonCheckSchedule_Click);
			// 
			// buttonAddUser
			// 
			this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonAddUser.AutoSize = true;
			this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonAddUser.Location = new System.Drawing.Point(61, 350);
			this.buttonAddUser.Name = "buttonAddUser";
			this.buttonAddUser.Size = new System.Drawing.Size(372, 38);
			this.buttonAddUser.TabIndex = 0;
			this.buttonAddUser.Text = "Редактировать пользователей";
			this.buttonAddUser.UseVisualStyleBackColor = true;
			this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
			// 
			// buttonAddAcc
			// 
			this.buttonAddAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonAddAcc.AutoSize = true;
			this.buttonAddAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonAddAcc.Location = new System.Drawing.Point(61, 433);
			this.buttonAddAcc.Name = "buttonAddAcc";
			this.buttonAddAcc.Size = new System.Drawing.Size(372, 38);
			this.buttonAddAcc.TabIndex = 0;
			this.buttonAddAcc.Text = "Редактировать аккаунты";
			this.buttonAddAcc.UseVisualStyleBackColor = true;
			this.buttonAddAcc.Click += new System.EventHandler(this.buttonAddAcc_Click);
			// 
			// UserMedS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 596);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UserMedS";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Учетная запись: регистратор";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMedS_FormClosed);
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
		private Button buttonEditSchedule;
		private Button buttonCheckSchedule;
		private Button buttonAddUser;
		private Button buttonAddAcc;
	}
}