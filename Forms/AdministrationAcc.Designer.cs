namespace CourseWorkAt4.Forms
{
	partial class AdministrationAcc
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
			tableLayoutPanelMain = new TableLayoutPanel();
			tableLayoutPanelFormMain = new TableLayoutPanel();
			tableLayoutPanel1 = new TableLayoutPanel();
			textBoxPassword = new TextBox();
			labelUserType = new Label();
			labelId = new Label();
			comboBoxUserType = new ComboBox();
			buttonCheck = new Button();
			labelLogin = new Label();
			labelPassword = new Label();
			buttonSaveChanges = new Button();
			textBoxId = new TextBox();
			textBoxLogin = new TextBox();
			buttonCreateUser = new Button();
			panel1 = new Panel();
			labelName = new Label();
			labelNameFix = new Label();
			labelMsg = new Label();
			tableLayoutPanelMain.SuspendLayout();
			tableLayoutPanelFormMain.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			tableLayoutPanelMain.ColumnCount = 3;
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 700F));
			tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.Controls.Add(tableLayoutPanelFormMain, 1, 1);
			tableLayoutPanelMain.Dock = DockStyle.Fill;
			tableLayoutPanelMain.Location = new Point(0, 0);
			tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			tableLayoutPanelMain.RowCount = 3;
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
			tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanelMain.Size = new Size(820, 516);
			tableLayoutPanelMain.TabIndex = 0;
			// 
			// tableLayoutPanelFormMain
			// 
			tableLayoutPanelFormMain.ColumnCount = 1;
			tableLayoutPanelFormMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelFormMain.Controls.Add(tableLayoutPanel1, 0, 0);
			tableLayoutPanelFormMain.Controls.Add(labelMsg, 0, 1);
			tableLayoutPanelFormMain.Dock = DockStyle.Fill;
			tableLayoutPanelFormMain.Location = new Point(63, 61);
			tableLayoutPanelFormMain.Name = "tableLayoutPanelFormMain";
			tableLayoutPanelFormMain.RowCount = 2;
			tableLayoutPanelFormMain.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
			tableLayoutPanelFormMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanelFormMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelFormMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelFormMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelFormMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelFormMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanelFormMain.Size = new Size(694, 394);
			tableLayoutPanelFormMain.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(textBoxPassword, 2, 4);
			tableLayoutPanel1.Controls.Add(labelUserType, 0, 0);
			tableLayoutPanel1.Controls.Add(labelId, 2, 0);
			tableLayoutPanel1.Controls.Add(comboBoxUserType, 0, 1);
			tableLayoutPanel1.Controls.Add(buttonCheck, 2, 2);
			tableLayoutPanel1.Controls.Add(labelLogin, 0, 3);
			tableLayoutPanel1.Controls.Add(labelPassword, 2, 3);
			tableLayoutPanel1.Controls.Add(buttonSaveChanges, 2, 5);
			tableLayoutPanel1.Controls.Add(textBoxId, 2, 1);
			tableLayoutPanel1.Controls.Add(textBoxLogin, 0, 4);
			tableLayoutPanel1.Controls.Add(buttonCreateUser, 0, 5);
			tableLayoutPanel1.Controls.Add(panel1, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 6;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(688, 328);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// textBoxPassword
			// 
			textBoxPassword.Dock = DockStyle.Fill;
			textBoxPassword.Location = new Point(362, 219);
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.Size = new Size(323, 27);
			textBoxPassword.TabIndex = 7;
			// 
			// labelUserType
			// 
			labelUserType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelUserType.AutoSize = true;
			labelUserType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelUserType.Location = new Point(3, 26);
			labelUserType.Name = "labelUserType";
			labelUserType.Size = new Size(177, 28);
			labelUserType.TabIndex = 0;
			labelUserType.Text = "Тип пользователя";
			// 
			// labelId
			// 
			labelId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelId.AutoSize = true;
			labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelId.Location = new Point(362, 26);
			labelId.Name = "labelId";
			labelId.Size = new Size(287, 28);
			labelId.TabIndex = 0;
			labelId.Text = "Индив. номер или мед. полис\r\n";
			// 
			// comboBoxUserType
			// 
			comboBoxUserType.Dock = DockStyle.Fill;
			comboBoxUserType.FormattingEnabled = true;
			comboBoxUserType.Location = new Point(3, 57);
			comboBoxUserType.Name = "comboBoxUserType";
			comboBoxUserType.Size = new Size(323, 28);
			comboBoxUserType.TabIndex = 1;
			// 
			// buttonCheck
			// 
			buttonCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonCheck.AutoSize = true;
			buttonCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCheck.Location = new Point(572, 111);
			buttonCheck.Name = "buttonCheck";
			buttonCheck.Size = new Size(113, 38);
			buttonCheck.TabIndex = 2;
			buttonCheck.Text = "Проверка";
			buttonCheck.UseVisualStyleBackColor = true;
			buttonCheck.Click += buttonCheck_Click;
			// 
			// labelLogin
			// 
			labelLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelLogin.AutoSize = true;
			labelLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelLogin.Location = new Point(3, 188);
			labelLogin.Name = "labelLogin";
			labelLogin.Size = new Size(69, 28);
			labelLogin.TabIndex = 0;
			labelLogin.Text = "Логин";
			// 
			// labelPassword
			// 
			labelPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelPassword.AutoSize = true;
			labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelPassword.Location = new Point(362, 188);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new Size(81, 28);
			labelPassword.TabIndex = 0;
			labelPassword.Text = "Пароль";
			// 
			// buttonSaveChanges
			// 
			buttonSaveChanges.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonSaveChanges.AutoSize = true;
			buttonSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			buttonSaveChanges.Location = new Point(492, 273);
			buttonSaveChanges.Name = "buttonSaveChanges";
			buttonSaveChanges.Size = new Size(193, 38);
			buttonSaveChanges.TabIndex = 2;
			buttonSaveChanges.Text = "Сохранить данные";
			buttonSaveChanges.UseVisualStyleBackColor = true;
			buttonSaveChanges.Click += buttonSaveChanges_Click;
			// 
			// textBoxId
			// 
			textBoxId.Dock = DockStyle.Fill;
			textBoxId.Location = new Point(362, 57);
			textBoxId.Name = "textBoxId";
			textBoxId.Size = new Size(323, 27);
			textBoxId.TabIndex = 5;
			// 
			// textBoxLogin
			// 
			textBoxLogin.Dock = DockStyle.Fill;
			textBoxLogin.Location = new Point(3, 219);
			textBoxLogin.Name = "textBoxLogin";
			textBoxLogin.Size = new Size(323, 27);
			textBoxLogin.TabIndex = 6;
			// 
			// buttonCreateUser
			// 
			buttonCreateUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			buttonCreateUser.AutoSize = true;
			buttonCreateUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			buttonCreateUser.Location = new Point(101, 273);
			buttonCreateUser.Name = "buttonCreateUser";
			buttonCreateUser.Size = new Size(225, 38);
			buttonCreateUser.TabIndex = 2;
			buttonCreateUser.Text = "Создать пользователя";
			buttonCreateUser.UseVisualStyleBackColor = true;
			buttonCreateUser.Click += buttonCreateUser_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(labelName);
			panel1.Controls.Add(labelNameFix);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(3, 111);
			panel1.Name = "panel1";
			panel1.Size = new Size(323, 48);
			panel1.TabIndex = 8;
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelName.Location = new Point(50, 13);
			labelName.Name = "labelName";
			labelName.Size = new Size(0, 25);
			labelName.TabIndex = 0;
			labelName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelNameFix
			// 
			labelNameFix.AutoSize = true;
			labelNameFix.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			labelNameFix.Location = new Point(0, 13);
			labelNameFix.Name = "labelNameFix";
			labelNameFix.Size = new Size(58, 25);
			labelNameFix.TabIndex = 0;
			labelNameFix.Text = "Имя: ";
			labelNameFix.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelMsg
			// 
			labelMsg.Anchor = AnchorStyles.None;
			labelMsg.AutoSize = true;
			labelMsg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelMsg.ForeColor = Color.Brown;
			labelMsg.Location = new Point(347, 350);
			labelMsg.Name = "labelMsg";
			labelMsg.Size = new Size(0, 28);
			labelMsg.TabIndex = 0;
			labelMsg.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// AdministrationAcc
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(820, 516);
			Controls.Add(tableLayoutPanelMain);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "AdministrationAcc";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Редактирование аккаунта";
			FormClosed += AdministrationAcc_FormClosed;
			tableLayoutPanelMain.ResumeLayout(false);
			tableLayoutPanelFormMain.ResumeLayout(false);
			tableLayoutPanelFormMain.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanelMain;
		private TableLayoutPanel tableLayoutPanelFormMain;
		private TableLayoutPanel tableLayoutPanel1;
		private TextBox textBoxPassword;
		private Label labelUserType;
		private Label labelId;
		private ComboBox comboBoxUserType;
		private Button buttonCheck;
		private Label labelLogin;
		private Label labelPassword;
		private Button buttonSaveChanges;
		private TextBox textBoxId;
		private TextBox textBoxLogin;
		private Button buttonCreateUser;
		private Panel panel1;
		private Label labelMsg;
		private Label labelName;
		private Label labelNameFix;
	}
}