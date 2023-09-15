namespace CourseWorkAt4.Forms
{
	partial class UserAdmin
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonAddAcc = new System.Windows.Forms.Button();
			this.buttonAddUser = new System.Windows.Forms.Button();
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
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(559, 596);
			this.tableLayoutPanelMain.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.buttonAddAcc, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonAddUser, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 238);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 119);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// buttonAddAcc
			// 
			this.buttonAddAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonAddAcc.AutoSize = true;
			this.buttonAddAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonAddAcc.Location = new System.Drawing.Point(78, 70);
			this.buttonAddAcc.Name = "buttonAddAcc";
			this.buttonAddAcc.Size = new System.Drawing.Size(338, 38);
			this.buttonAddAcc.TabIndex = 2;
			this.buttonAddAcc.Text = "Редактировать аккаунты";
			this.buttonAddAcc.UseVisualStyleBackColor = true;
			this.buttonAddAcc.Click += new System.EventHandler(this.buttonAddAcc_Click);
			// 
			// buttonAddUser
			// 
			this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonAddUser.AutoSize = true;
			this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonAddUser.Location = new System.Drawing.Point(77, 10);
			this.buttonAddUser.Name = "buttonAddUser";
			this.buttonAddUser.Size = new System.Drawing.Size(340, 38);
			this.buttonAddUser.TabIndex = 1;
			this.buttonAddUser.Text = "Редактировать пользователей";
			this.buttonAddUser.UseVisualStyleBackColor = true;
			this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
			// 
			// UserAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 596);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "UserAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Учетная запись: Администратор";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserAdmin_FormClosed);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutPanel1;
		private Button buttonAddUser;
		private Button buttonAddAcc;
	}
}