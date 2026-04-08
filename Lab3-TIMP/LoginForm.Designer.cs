namespace DataDrivenApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTitle1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel panelTitle2;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Panel panelSubtitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblCapsLock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTitle1 = new Panel();
            lblTitle1 = new Label();
            panelTitle2 = new Panel();
            lblTitle2 = new Label();
            pictureBoxLogo = new PictureBox();
            panelSubtitle = new Panel();
            lblSubtitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            lblLanguage = new Label();
            lblCapsLock = new Label();
            panelTitle1.SuspendLayout();
            panelTitle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelSubtitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle1
            // 
            panelTitle1.BackColor = Color.Gold;
            panelTitle1.Controls.Add(lblTitle1);
            panelTitle1.Location = new Point(6, 15);
            panelTitle1.Name = "panelTitle1";
            panelTitle1.Size = new Size(383, 20);
            panelTitle1.TabIndex = 10;
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.BackColor = Color.Transparent;
            lblTitle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblTitle1.Location = new Point(243, 1);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(140, 19);
            lblTitle1.TabIndex = 0;
            lblTitle1.Text = "АИС Отдел кадров";
            // 
            // panelTitle2
            // 
            panelTitle2.BackColor = Color.Gold;
            panelTitle2.Controls.Add(lblTitle2);
            panelTitle2.Location = new Point(6, 37);
            panelTitle2.Name = "panelTitle2";
            panelTitle2.Size = new Size(383, 20);
            panelTitle2.TabIndex = 11;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblTitle2.Location = new Point(276, 1);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(107, 19);
            lblTitle2.TabIndex = 0;
            lblTitle2.Text = "Версия 1.0.0.0";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Location = new Point(6, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(55, 52);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 13;
            pictureBoxLogo.TabStop = false;
            // 
            // panelSubtitle
            // 
            panelSubtitle.BackColor = Color.White;
            panelSubtitle.Controls.Add(lblSubtitle);
            panelSubtitle.Location = new Point(6, 63);
            panelSubtitle.Name = "panelSubtitle";
            panelSubtitle.Size = new Size(383, 20);
            panelSubtitle.TabIndex = 12;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Location = new Point(115, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(265, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Введите имя пользователя и пароль\r\n";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Location = new Point(6, 92);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(142, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Имя пользователя:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Location = new Point(10, 142);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(65, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Пароль:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(164, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(211, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(164, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(211, 27);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(198, 178);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(288, 178);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblLanguage
            // 
            lblLanguage.BackColor = Color.Transparent;
            lblLanguage.Font = new Font("Segoe UI", 7.5F);
            lblLanguage.Location = new Point(6, 231);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(160, 14);
            lblLanguage.TabIndex = 8;
            lblLanguage.Text = "Язык ввода: Английский";
            lblLanguage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCapsLock
            // 
            lblCapsLock.BackColor = Color.Transparent;
            lblCapsLock.Font = new Font("Segoe UI", 7.5F);
            lblCapsLock.Location = new Point(218, 231);
            lblCapsLock.Name = "lblCapsLock";
            lblCapsLock.Size = new Size(155, 14);
            lblCapsLock.TabIndex = 9;
            lblCapsLock.Text = "CapsLock: выкл";
            lblCapsLock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            BackColor = Color.LightBlue;
            CancelButton = btnCancel;
            ClientSize = new Size(395, 259);
            Controls.Add(lblCapsLock);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblLanguage);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(panelSubtitle);
            Controls.Add(panelTitle2);
            Controls.Add(panelTitle1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            panelTitle1.ResumeLayout(false);
            panelTitle1.PerformLayout();
            panelTitle2.ResumeLayout(false);
            panelTitle2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelSubtitle.ResumeLayout(false);
            panelSubtitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}