namespace CourseWorkAt4.Forms
{
	partial class Autorization
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanelGeneric = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelPassword = new System.Windows.Forms.TableLayoutPanel();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.tableLayoutPanelLogin = new System.Windows.Forms.TableLayoutPanel();
			this.labelLogin = new System.Windows.Forms.Label();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.tableLayoutPanelAutorization = new System.Windows.Forms.TableLayoutPanel();
			this.labelAutorization = new System.Windows.Forms.Label();
			this.labelMsg = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonSignUp = new System.Windows.Forms.Button();
			this.buttonLogIn = new System.Windows.Forms.Button();
			this.tableLayoutPanelGeneric.SuspendLayout();
			this.tableLayoutPanelPassword.SuspendLayout();
			this.tableLayoutPanelLogin.SuspendLayout();
			this.tableLayoutPanelAutorization.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelGeneric
			// 
			this.tableLayoutPanelGeneric.ColumnCount = 3;
			this.tableLayoutPanelGeneric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelGeneric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanelGeneric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelGeneric.Controls.Add(this.tableLayoutPanelPassword, 1, 3);
			this.tableLayoutPanelGeneric.Controls.Add(this.tableLayoutPanelLogin, 1, 2);
			this.tableLayoutPanelGeneric.Controls.Add(this.tableLayoutPanelAutorization, 1, 1);
			this.tableLayoutPanelGeneric.Controls.Add(this.labelMsg, 1, 5);
			this.tableLayoutPanelGeneric.Controls.Add(this.tableLayoutPanel1, 1, 4);
			this.tableLayoutPanelGeneric.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelGeneric.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelGeneric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanelGeneric.Name = "tableLayoutPanelGeneric";
			this.tableLayoutPanelGeneric.RowCount = 7;
			this.tableLayoutPanelGeneric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelGeneric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanelGeneric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanelGeneric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanelGeneric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanelGeneric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.tableLayoutPanelGeneric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelGeneric.Size = new System.Drawing.Size(406, 492);
			this.tableLayoutPanelGeneric.TabIndex = 0;
			this.tableLayoutPanelGeneric.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelGeneric_Paint_1);
			// 
			// tableLayoutPanelPassword
			// 
			this.tableLayoutPanelPassword.ColumnCount = 3;
			this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelPassword.Controls.Add(this.labelPassword, 0, 0);
			this.tableLayoutPanelPassword.Controls.Add(this.textBoxPassword, 1, 0);
			this.tableLayoutPanelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelPassword.Location = new System.Drawing.Point(6, 185);
			this.tableLayoutPanelPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanelPassword.Name = "tableLayoutPanelPassword";
			this.tableLayoutPanelPassword.RowCount = 1;
			this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPassword.Size = new System.Drawing.Size(394, 62);
			this.tableLayoutPanelPassword.TabIndex = 2;
			// 
			// labelPassword
			// 
			this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelPassword.Location = new System.Drawing.Point(15, 18);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(80, 25);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "Пароль";
			this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxPassword.Location = new System.Drawing.Point(101, 16);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(191, 30);
			this.textBoxPassword.TabIndex = 1;
			// 
			// tableLayoutPanelLogin
			// 
			this.tableLayoutPanelLogin.ColumnCount = 3;
			this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelLogin.Controls.Add(this.labelLogin, 0, 0);
			this.tableLayoutPanelLogin.Controls.Add(this.textBoxLogin, 1, 0);
			this.tableLayoutPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLogin.Location = new System.Drawing.Point(6, 115);
			this.tableLayoutPanelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanelLogin.Name = "tableLayoutPanelLogin";
			this.tableLayoutPanelLogin.RowCount = 1;
			this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLogin.Size = new System.Drawing.Size(394, 62);
			this.tableLayoutPanelLogin.TabIndex = 1;
			// 
			// labelLogin
			// 
			this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelLogin.AutoSize = true;
			this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelLogin.Location = new System.Drawing.Point(27, 18);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(68, 25);
			this.labelLogin.TabIndex = 0;
			this.labelLogin.Text = "Логин";
			this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxLogin.Location = new System.Drawing.Point(101, 16);
			this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(191, 30);
			this.textBoxLogin.TabIndex = 1;
			this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
			// 
			// tableLayoutPanelAutorization
			// 
			this.tableLayoutPanelAutorization.ColumnCount = 1;
			this.tableLayoutPanelAutorization.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelAutorization.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelAutorization.Controls.Add(this.labelAutorization, 0, 0);
			this.tableLayoutPanelAutorization.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelAutorization.Location = new System.Drawing.Point(6, 35);
			this.tableLayoutPanelAutorization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanelAutorization.Name = "tableLayoutPanelAutorization";
			this.tableLayoutPanelAutorization.RowCount = 1;
			this.tableLayoutPanelAutorization.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelAutorization.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelAutorization.Size = new System.Drawing.Size(394, 72);
			this.tableLayoutPanelAutorization.TabIndex = 4;
			// 
			// labelAutorization
			// 
			this.labelAutorization.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelAutorization.AutoSize = true;
			this.labelAutorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelAutorization.Location = new System.Drawing.Point(85, 16);
			this.labelAutorization.Name = "labelAutorization";
			this.labelAutorization.Size = new System.Drawing.Size(224, 39);
			this.labelAutorization.TabIndex = 0;
			this.labelAutorization.Text = "Авторизация";
			// 
			// labelMsg
			// 
			this.labelMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelMsg.AutoSize = true;
			this.labelMsg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelMsg.Location = new System.Drawing.Point(203, 351);
			this.labelMsg.Name = "labelMsg";
			this.labelMsg.Size = new System.Drawing.Size(0, 32);
			this.labelMsg.TabIndex = 5;
			this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.buttonSignUp, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonLogIn, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 254);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.94587F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.05413F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 94);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// buttonSignUp
			// 
			this.buttonSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonSignUp.AutoSize = true;
			this.buttonSignUp.BackColor = System.Drawing.SystemColors.Window;
			this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSignUp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonSignUp.Location = new System.Drawing.Point(142, 3);
			this.buttonSignUp.Name = "buttonSignUp";
			this.buttonSignUp.Size = new System.Drawing.Size(110, 32);
			this.buttonSignUp.TabIndex = 0;
			this.buttonSignUp.Text = "Регистрация";
			this.buttonSignUp.UseVisualStyleBackColor = false;
			this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
			// 
			// buttonLogIn
			// 
			this.buttonLogIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonLogIn.AutoSize = true;
			this.buttonLogIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonLogIn.Location = new System.Drawing.Point(150, 44);
			this.buttonLogIn.Name = "buttonLogIn";
			this.buttonLogIn.Size = new System.Drawing.Size(94, 42);
			this.buttonLogIn.TabIndex = 1;
			this.buttonLogIn.Text = "Вход";
			this.buttonLogIn.UseVisualStyleBackColor = true;
			this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click_1);
			// 
			// Autorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(406, 492);
			this.Controls.Add(this.tableLayoutPanelGeneric);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Autorization";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Autorization_FormClosed);
			this.tableLayoutPanelGeneric.ResumeLayout(false);
			this.tableLayoutPanelGeneric.PerformLayout();
			this.tableLayoutPanelPassword.ResumeLayout(false);
			this.tableLayoutPanelPassword.PerformLayout();
			this.tableLayoutPanelLogin.ResumeLayout(false);
			this.tableLayoutPanelLogin.PerformLayout();
			this.tableLayoutPanelAutorization.ResumeLayout(false);
			this.tableLayoutPanelAutorization.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label labelAutorization;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAutorization;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneric;
		private TableLayoutPanel tableLayoutPanelPassword;
		private Label labelPassword;
		private TextBox textBoxPassword;
		private TableLayoutPanel tableLayoutPanelLogin;
		private Label labelLogin;
		private TextBox textBoxLogin;
		private Label labelMsg;
		private TableLayoutPanel tableLayoutPanel1;
		private Button buttonSignUp;
		private Button buttonLogIn;
	}
}

