using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using AuthLibrary;
using MenuLibrary;

namespace DataDrivenApp
{
    public partial class MainForm : Form
    {
        private readonly UserRights _userRights;

        public MainForm(UserRights userRights)
        {
            _userRights = userRights;
            InitializeComponent();
            BuildMenu();
        }

        private void BuildMenu()
        {
            // 1. Создаём словарь обработчиков на основе данных из menu.txt
            var handlers = LoadHandlersFromFile("menu.txt");

            // 2. Загружаем структуру меню из файла
            var menuBuilder = new MenuBuilder();
            if (!menuBuilder.LoadMenu("menu.txt"))
            {
                MessageBox.Show("Не удалось загрузить меню.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Строим MenuStrip с учётом прав пользователя
            var menuStrip = menuBuilder.BuildMenuStrip(handlers, _userRights);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        /// <summary>
        /// Загружает файл menu.txt и создаёт словарь обработчиков.
        /// Ключ — имя метода, значение — действие, выводящее название пункта.
        /// </summary>
        private Dictionary<string, Action> LoadHandlersFromFile(string filePath)
        {
            var handlers = new Dictionary<string, Action>();

            if (!File.Exists(filePath))
                return handlers;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                // Нам нужны строки, где есть как минимум три элемента: уровень, название, имя_метода
                if (parts.Length >= 3)
                {
                    string level = parts[0];
                    string itemText = parts[1];
                    string methodName = parts[2];

                    // Создаём обработчик, который захватывает название пункта через замыкание
                    Action handler = () => ShowMessage(itemText);
                    // Если метод уже есть в словаре, можно перезаписать (в задании дубликатов нет)
                    handlers[methodName] = handler;
                }
            }

            return handlers;
        }

        private void ShowMessage(string menuItemName)
        {
            MessageBox.Show($"Выбран пункт: {menuItemName}", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}