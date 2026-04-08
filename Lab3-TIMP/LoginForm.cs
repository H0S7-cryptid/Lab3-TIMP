using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using AuthLibrary;

namespace DataDrivenApp
{
    public partial class LoginForm : Form
    {
        public UserRights AuthorizedUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();

            pictureBoxLogo.Image = Image.FromFile("keys.png");
            //pictureBoxLogo.BringToFront();

            this.KeyPreview = true;
            this.Load += LoginForm_Load;
            this.InputLanguageChanged += LoginForm_InputLanguageChanged;
            this.KeyDown += LoginForm_KeyDown;
            this.Activated += LoginForm_Activated;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string login = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите имя пользователя и пароль.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var authManager = new AuthManager();
            string usersFile = "users.txt";
            if (!authManager.LoadUsers(usersFile))
            {
                MessageBox.Show("Не удалось загрузить файл пользователей.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userRights = authManager.Authenticate(login, password);
            if (userRights != null)
            {
                AuthorizedUser = userRights;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Обработка состояний клавиатуры.

        // Обновление отображения языка ввода
        private void UpdateLanguageStatus()
        {
            InputLanguage currentLang = InputLanguage.CurrentInputLanguage;
            string langName = currentLang.Culture.DisplayName;
            lblLanguage.Text = $"Язык ввода: {langName}";
        }

        // Обновление отображения состояния CapsLock
        private void UpdateCapsLockStatus()
        {
            bool capsOn = Control.IsKeyLocked(Keys.CapsLock);
            lblCapsLock.Text = capsOn ? "CapsLock: вкл" : "CapsLock: выкл";
        }

        // Событие при загрузке формы
        private void LoginForm_Load(object sender, EventArgs e)
        {
            UpdateLanguageStatus();
            UpdateCapsLockStatus();
        }

        // Событие при смене раскладки клавиатуры
        private void LoginForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            UpdateLanguageStatus();
        }

        // Событие при нажатии клавиши (отслеживаем CapsLock)
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                UpdateCapsLockStatus();
            }
        }

        // Событие при активации окна (на случай, если CapsLock изменился вне формы)
        private void LoginForm_Activated(object sender, EventArgs e)
        {
            UpdateCapsLockStatus();
            UpdateLanguageStatus();
        }

        #endregion
    }
}