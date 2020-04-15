namespace kursovaya
{
    partial class MainForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ShowTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокРесторановToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаказчиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ресторанToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ресторанToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдоToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ресторанToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФильтрациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(12, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1057, 242);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название заказа";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата заказа";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя заказчика";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Телефон заказчика";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Общая стоимость";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Статус заказа";
            this.columnHeader6.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(240, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для просмотра подробностей заказа \r\nщелкните дважды левой кнопкой мыши по строке " +
    "нужного заказа :)\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(844, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить фильтры";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(466, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Удалить заказ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Обновить форму";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(83, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 36);
            this.button6.TabIndex = 8;
            this.button6.Text = "Изменить заказ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowTSMenuItem,
            this.AddTSMenuItem,
            this.EditTSMenuItem,
            this.DeleteTSMenuItem,
            this.добавитьФильтрациюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ShowTSMenuItem
            // 
            this.ShowTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокРесторановToolStripMenuItem,
            this.списокБлюдToolStripMenuItem,
            this.списокЗаказчиковToolStripMenuItem});
            this.ShowTSMenuItem.Name = "ShowTSMenuItem";
            this.ShowTSMenuItem.Size = new System.Drawing.Size(128, 24);
            this.ShowTSMenuItem.Text = "Показать из БД";
            // 
            // списокРесторановToolStripMenuItem
            // 
            this.списокРесторановToolStripMenuItem.Name = "списокРесторановToolStripMenuItem";
            this.списокРесторановToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.списокРесторановToolStripMenuItem.Text = "Список ресторанов";
            // 
            // списокБлюдToolStripMenuItem
            // 
            this.списокБлюдToolStripMenuItem.Name = "списокБлюдToolStripMenuItem";
            this.списокБлюдToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.списокБлюдToolStripMenuItem.Text = "Список блюд";
            // 
            // списокЗаказчиковToolStripMenuItem
            // 
            this.списокЗаказчиковToolStripMenuItem.Name = "списокЗаказчиковToolStripMenuItem";
            this.списокЗаказчиковToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.списокЗаказчиковToolStripMenuItem.Text = "Список заказчиков";
            // 
            // AddTSMenuItem
            // 
            this.AddTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказToolStripMenuItem,
            this.блюдоToolStripMenuItem,
            this.ресторанToolStripMenuItem,
            this.заказчикаToolStripMenuItem});
            this.AddTSMenuItem.Name = "AddTSMenuItem";
            this.AddTSMenuItem.Size = new System.Drawing.Size(123, 24);
            this.AddTSMenuItem.Text = "Добавить в БД";
            // 
            // заказToolStripMenuItem
            // 
            this.заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            this.заказToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.заказToolStripMenuItem.Text = "Заказ";
            // 
            // блюдоToolStripMenuItem
            // 
            this.блюдоToolStripMenuItem.Name = "блюдоToolStripMenuItem";
            this.блюдоToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.блюдоToolStripMenuItem.Text = "Блюдо";
            // 
            // ресторанToolStripMenuItem
            // 
            this.ресторанToolStripMenuItem.Name = "ресторанToolStripMenuItem";
            this.ресторанToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.ресторанToolStripMenuItem.Text = "Ресторан";
            // 
            // заказчикаToolStripMenuItem
            // 
            this.заказчикаToolStripMenuItem.Name = "заказчикаToolStripMenuItem";
            this.заказчикаToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.заказчикаToolStripMenuItem.Text = "Заказчик";
            // 
            // EditTSMenuItem
            // 
            this.EditTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказToolStripMenuItem1,
            this.блюдоToolStripMenuItem1,
            this.ресторанToolStripMenuItem1,
            this.заказчикToolStripMenuItem});
            this.EditTSMenuItem.Name = "EditTSMenuItem";
            this.EditTSMenuItem.Size = new System.Drawing.Size(146, 24);
            this.EditTSMenuItem.Text = "Редактировать БД";
            // 
            // заказToolStripMenuItem1
            // 
            this.заказToolStripMenuItem1.Name = "заказToolStripMenuItem1";
            this.заказToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.заказToolStripMenuItem1.Text = "Заказ";
            // 
            // блюдоToolStripMenuItem1
            // 
            this.блюдоToolStripMenuItem1.Name = "блюдоToolStripMenuItem1";
            this.блюдоToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.блюдоToolStripMenuItem1.Text = "Блюдо";
            // 
            // ресторанToolStripMenuItem1
            // 
            this.ресторанToolStripMenuItem1.Name = "ресторанToolStripMenuItem1";
            this.ресторанToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.ресторанToolStripMenuItem1.Text = "Ресторан";
            // 
            // заказчикToolStripMenuItem
            // 
            this.заказчикToolStripMenuItem.Name = "заказчикToolStripMenuItem";
            this.заказчикToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.заказчикToolStripMenuItem.Text = "Заказчик";
            // 
            // DeleteTSMenuItem
            // 
            this.DeleteTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказToolStripMenuItem2,
            this.блюдоToolStripMenuItem2,
            this.ресторанToolStripMenuItem2,
            this.заказчикToolStripMenuItem1});
            this.DeleteTSMenuItem.Name = "DeleteTSMenuItem";
            this.DeleteTSMenuItem.Size = new System.Drawing.Size(120, 24);
            this.DeleteTSMenuItem.Text = "Удалить из БД";
            // 
            // заказToolStripMenuItem2
            // 
            this.заказToolStripMenuItem2.Name = "заказToolStripMenuItem2";
            this.заказToolStripMenuItem2.Size = new System.Drawing.Size(148, 26);
            this.заказToolStripMenuItem2.Text = "Заказ";
            // 
            // блюдоToolStripMenuItem2
            // 
            this.блюдоToolStripMenuItem2.Name = "блюдоToolStripMenuItem2";
            this.блюдоToolStripMenuItem2.Size = new System.Drawing.Size(148, 26);
            this.блюдоToolStripMenuItem2.Text = "Блюдо";
            // 
            // ресторанToolStripMenuItem2
            // 
            this.ресторанToolStripMenuItem2.Name = "ресторанToolStripMenuItem2";
            this.ресторанToolStripMenuItem2.Size = new System.Drawing.Size(148, 26);
            this.ресторанToolStripMenuItem2.Text = "Ресторан";
            // 
            // заказчикToolStripMenuItem1
            // 
            this.заказчикToolStripMenuItem1.Name = "заказчикToolStripMenuItem1";
            this.заказчикToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.заказчикToolStripMenuItem1.Text = "Заказчик";
            // 
            // добавитьФильтрациюToolStripMenuItem
            // 
            this.добавитьФильтрациюToolStripMenuItem.Name = "добавитьФильтрациюToolStripMenuItem";
            this.добавитьФильтрациюToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.добавитьФильтрациюToolStripMenuItem.Text = "Фильтрация...";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Кол-во блюд";
            this.columnHeader7.Width = 147;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 416);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Order\'s Info";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокРесторановToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаказчиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ресторанToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказчикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem блюдоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ресторанToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem заказчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem блюдоToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ресторанToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem заказчикToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьФильтрациюToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

