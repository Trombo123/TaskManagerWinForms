namespace TaskMF
{
    partial class Form1
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListBoxTasks = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Checker = new System.Windows.Forms.CheckBox();
            this.Priority = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ButtonSort);
            this.groupBox4.Controls.Add(this.Filter);
            this.groupBox4.Location = new System.Drawing.Point(346, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(247, 143);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сортировка и фильтры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Фильтры:";
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(10, 78);
            this.ButtonSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(117, 44);
            this.ButtonSort.TabIndex = 9;
            this.ButtonSort.Text = "Сортировать";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // Filter
            // 
            this.Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "Все",
            "Низкий",
            "Средний",
            "Высокий",
            "Просрочены",
            "Сделаны",
            "Не сделаны"});
            this.Filter.Location = new System.Drawing.Point(10, 46);
            this.Filter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(140, 23);
            this.Filter.TabIndex = 10;
            this.Filter.SelectedIndexChanged += new System.EventHandler(this.Filter_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListBoxTasks);
            this.groupBox3.Location = new System.Drawing.Point(601, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(420, 399);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список ";
            // 
            // ListBoxTasks
            // 
            this.ListBoxTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListBoxTasks.FormattingEnabled = true;
            this.ListBoxTasks.ItemHeight = 20;
            this.ListBoxTasks.Location = new System.Drawing.Point(10, 31);
            this.ListBoxTasks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBoxTasks.Name = "ListBoxTasks";
            this.ListBoxTasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxTasks.Size = new System.Drawing.Size(405, 344);
            this.ListBoxTasks.TabIndex = 8;
            this.ListBoxTasks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxTasks_DrawItem);
            this.ListBoxTasks.SelectedIndexChanged += new System.EventHandler(this.ListBoxTasks_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonAdd);
            this.groupBox2.Controls.Add(this.ButtonDelete);
            this.groupBox2.Controls.Add(this.ButtonEdit);
            this.groupBox2.Location = new System.Drawing.Point(348, 151);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(247, 249);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAdd.Location = new System.Drawing.Point(7, 28);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(117, 44);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonDelete.Location = new System.Drawing.Point(124, 28);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(117, 44);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(6, 87);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(121, 44);
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "Редактировать";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Checker);
            this.groupBox1.Controls.Add(this.Priority);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.textTitle);
            this.groupBox1.Location = new System.Drawing.Point(14, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(326, 399);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные задач";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выполнено? (да/нет):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Приоритет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // Checker
            // 
            this.Checker.AutoSize = true;
            this.Checker.Location = new System.Drawing.Point(146, 301);
            this.Checker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Checker.Name = "Checker";
            this.Checker.Size = new System.Drawing.Size(15, 14);
            this.Checker.TabIndex = 4;
            this.Checker.UseVisualStyleBackColor = true;
            // 
            // Priority
            // 
            this.Priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Priority.FormattingEnabled = true;
            this.Priority.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.Priority.Location = new System.Drawing.Point(7, 224);
            this.Priority.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(140, 23);
            this.Priority.TabIndex = 3;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(7, 270);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(182, 23);
            this.DatePicker.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(7, 90);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(255, 110);
            this.Description.TabIndex = 1;
            this.Description.Text = "";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(5, 46);
            this.textTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(170, 23);
            this.textTitle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 410);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.ComboBox Filter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListBoxTasks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Checker;
        private System.Windows.Forms.ComboBox Priority;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox textTitle;
    }
}

