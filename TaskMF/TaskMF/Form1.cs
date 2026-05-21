using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TaskMF
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class Form1 : Form
    {
        // Список задач
        private List<MyTask> tasks = new List<MyTask>();

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Filter.SelectedIndex = 0;
        }

        /// <summary>
        /// Добавляет новую задачу в список.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы кнопки.</param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Проверка названия
            if (textTitle.Text.Trim() == "")
            {
                MessageBox.Show("Введите название задачи!");
                return;
            }

            // Проверка приоритета
            if (Priority.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите приоритет задачи!");
                return;
            }

            // Создание задачи
            MyTask task = new MyTask();

            task.Title = textTitle.Text;
            task.Description = Description.Text;
            task.DueDate = DatePicker.Value;
            task.Priority = Priority.Text;
            task.IsCompleted = Checker.Checked;

            // Добавление
            tasks.Add(task);

            // Обновление списка
            Filter_SelectedIndexChanged(null, null);

            // Очистка полей
            ClearFields();
        }

        /// <summary>
        /// Редактирование задачи.
        /// </summary>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Проверка выбора
            if (ListBoxTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрана задача для выполнения действия");
                return;
            }

            // Проверка приоритета
            if (Priority.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите приоритет задачи!");
                return;
            }

            MyTask task = (MyTask)ListBoxTasks.SelectedItem;

            // Изменение данных
            task.Title = textTitle.Text;
            task.Description = Description.Text;
            task.DueDate = DatePicker.Value;
            task.Priority = Priority.Text;
            task.IsCompleted = Checker.Checked;

            Filter_SelectedIndexChanged(null, null);
            ClearFields();
        }

        /// <summary>
        /// Удаление выбранных задач.
        /// </summary>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Проверка выбора
            if (ListBoxTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрана задача для выполнения действия");
                return;
            }

            // Удаление нескольких задач
            for (int i = ListBoxTasks.SelectedItems.Count - 1; i >= 0; i--)
            {
                MyTask task = (MyTask)ListBoxTasks.SelectedItems[i];

                tasks.Remove(task);
            }

            Filter_SelectedIndexChanged(null, null);
            ClearFields();
        }

        /// <summary>
        /// Сортировка задач по дате.
        /// </summary>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            tasks.Sort((a, b) => a.DueDate.CompareTo(b.DueDate));

            Filter_SelectedIndexChanged(null, null);
        }

        /// <summary>
        /// Выбор задачи из списка.
        /// </summary>
        private void ListBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверка выбора
            if (ListBoxTasks.SelectedIndex == -1)
                return;

            MyTask task = (MyTask)ListBoxTasks.SelectedItem;

            // Заполнение полей
            textTitle.Text = task.Title;
            Description.Text = task.Description;
            DatePicker.Value = task.DueDate;
            Priority.Text = task.Priority;
            Checker.Checked = task.IsCompleted;
        }

        /// <summary>
        /// Отрисовка задач.
        /// </summary>
        private void ListBoxTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            MyTask task = (MyTask)ListBoxTasks.Items[e.Index];

            e.DrawBackground();

            // Цвет текста
            Brush color = Brushes.Black;

            // Просроченная задача
            if (task.DueDate.Date < DateTime.Today &&
                task.IsCompleted == false)
            {
                color = Brushes.Red;
            }

            if (task.IsCompleted)
            {
                color = Brushes.Green;
            }

            // Рисуем текст
            e.Graphics.DrawString(
                task.ToString(),
                e.Font,
                color,
                e.Bounds
            );

            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Обновление списка задач.
        /// </summary>
        private void UpdateList()
        {
            ListBoxTasks.Items.Clear();

            foreach (MyTask task in tasks)
            {
                ListBoxTasks.Items.Add(task);
            }
        }

        /// <summary>
        /// Очистка полей формы.
        /// </summary>
        private void ClearFields()
        {
            textTitle.Clear();

            Description.Clear();

            DatePicker.Value = DateTime.Today;

            // Убираем выбранный приоритет
            Priority.SelectedIndex = -1;

            Checker.Checked = false;
        }

        /// <summary>
        /// Фильтр задач.
        /// </summary>
        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxTasks.Items.Clear();

            if (Filter.Text == "Все")
            {
                foreach (MyTask task in tasks)
                {
                    ListBoxTasks.Items.Add(task);
                }
            }

            else if (Filter.Text == "Низкий")
            {
                foreach (MyTask task in tasks)
                {
                    if (task.Priority == "Низкий")
                    {
                        ListBoxTasks.Items.Add(task);
                    }
                }
            }

            else if (Filter.Text == "Средний")
            {
                foreach (MyTask task in tasks)
                {
                    if (task.Priority == "Средний")
                    {
                        ListBoxTasks.Items.Add(task);
                    }
                }
            }

            else if (Filter.Text == "Высокий")
            {
                foreach (MyTask task in tasks)
                {
                    if (task.Priority == "Высокий")
                    {
                        ListBoxTasks.Items.Add(task);
                    }
                }
            }

            else if (Filter.Text == "Просрочены")
            {
                foreach (MyTask task in tasks)
                {
                    if (task.DueDate.Date < DateTime.Today &&
                        task.IsCompleted == false)
                    {
                        ListBoxTasks.Items.Add(task);
                    }
                }
            }

            else if (Filter.Text == "Сделаны")
            {
                foreach (MyTask task in tasks)
                {
                    if (task.IsCompleted == true)
                    {
                        ListBoxTasks.Items.Add(task);
                    }
                }
            }

            else if (Filter.Text == "Не сделаны")
            {
                foreach (MyTask task in tasks)
                {
                    if (task.IsCompleted == false)
                    {
                        ListBoxTasks.Items.Add(task);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Класс задачи.
    /// </summary>
    public class MyTask
    {
        /// <summary>
        /// Название задачи.
        /// </summary>
        public string Title;

        /// <summary>
        /// Описание задачи.
        /// </summary>
        public string Description;

        /// <summary>
        /// Дата выполнения.
        /// </summary>
        public DateTime DueDate;

        /// <summary>
        /// Приоритет задачи.
        /// </summary>
        public string Priority;

        /// <summary>
        /// Статус выполнения.
        /// </summary>
        public bool IsCompleted;

        /// <summary>
        /// Текст задачи для ListBox.
        /// </summary>
        public override string ToString()
        {
            string status = "[ ]";

            if (IsCompleted)
            {
                status = "[Сделано]";
            }

            return status + " " +
                   Title + " (" +
                   DueDate.ToShortDateString() +
                   ", " + Priority + ")";
        }
    }
}