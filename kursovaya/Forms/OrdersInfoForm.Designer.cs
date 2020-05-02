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
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ShowTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestListTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DishListTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustListTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOrderTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDishTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRestTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditOrdetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDishTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditRestTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCustTSIM = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelOrdTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DelDishTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DelRestTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DelCustTCMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(12, 43);
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
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата заказа";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя заказчика";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Телефон заказчика";
            this.columnHeader4.Width = 153;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Общая стоимость";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Статус заказа";
            this.columnHeader6.Width = 171;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Кол-во блюд";
            this.columnHeader7.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(304, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для просмотра подробностей заказа \r\nщелкните дважды левой кнопкой мыши по строке " +
    "нужного заказа :)\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowTSMenuItem,
            this.AddTSMenuItem,
            this.EditTSMenuItem,
            this.DeleteTSMenuItem,
            this.UpdateTSMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ShowTSMenuItem
            // 
            this.ShowTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestListTSMItem,
            this.DishListTSMItem,
            this.CustListTSMItem});
            this.ShowTSMenuItem.Name = "ShowTSMenuItem";
            this.ShowTSMenuItem.Size = new System.Drawing.Size(85, 24);
            this.ShowTSMenuItem.Text = "Показать";
            // 
            // RestListTSMItem
            // 
            this.RestListTSMItem.Name = "RestListTSMItem";
            this.RestListTSMItem.Size = new System.Drawing.Size(220, 26);
            this.RestListTSMItem.Text = "Список ресторанов";
            this.RestListTSMItem.Click += new System.EventHandler(this.RestListTSMItem_Click);
            // 
            // DishListTSMItem
            // 
            this.DishListTSMItem.Name = "DishListTSMItem";
            this.DishListTSMItem.Size = new System.Drawing.Size(220, 26);
            this.DishListTSMItem.Text = "Список блюд";
            this.DishListTSMItem.Click += new System.EventHandler(this.DishListTSMItem_Click);
            // 
            // CustListTSMItem
            // 
            this.CustListTSMItem.Name = "CustListTSMItem";
            this.CustListTSMItem.Size = new System.Drawing.Size(220, 26);
            this.CustListTSMItem.Text = "Список заказчиков";
            this.CustListTSMItem.Click += new System.EventHandler(this.CustListTSMItem_Click);
            // 
            // AddTSMenuItem
            // 
            this.AddTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOrderTSMItem,
            this.AddDishTSMItem,
            this.AddRestTSMItem,
            this.AddCustTSMItem});
            this.AddTSMenuItem.Name = "AddTSMenuItem";
            this.AddTSMenuItem.Size = new System.Drawing.Size(88, 24);
            this.AddTSMenuItem.Text = "Добавить";
            // 
            // AddOrderTSMItem
            // 
            this.AddOrderTSMItem.Name = "AddOrderTSMItem";
            this.AddOrderTSMItem.Size = new System.Drawing.Size(216, 26);
            this.AddOrderTSMItem.Text = "Заказ";
            this.AddOrderTSMItem.Click += new System.EventHandler(this.AddOrderTSMItem_Click);
            // 
            // AddDishTSMItem
            // 
            this.AddDishTSMItem.Name = "AddDishTSMItem";
            this.AddDishTSMItem.Size = new System.Drawing.Size(216, 26);
            this.AddDishTSMItem.Text = "Блюдо";
            this.AddDishTSMItem.Click += new System.EventHandler(this.AddDishTSMItem_Click);
            // 
            // AddRestTSMItem
            // 
            this.AddRestTSMItem.Name = "AddRestTSMItem";
            this.AddRestTSMItem.Size = new System.Drawing.Size(216, 26);
            this.AddRestTSMItem.Text = "Ресторан";
            this.AddRestTSMItem.Click += new System.EventHandler(this.AddRestTSMItem_Click);
            // 
            // AddCustTSMItem
            // 
            this.AddCustTSMItem.Name = "AddCustTSMItem";
            this.AddCustTSMItem.Size = new System.Drawing.Size(216, 26);
            this.AddCustTSMItem.Text = "Заказчик";
            this.AddCustTSMItem.Click += new System.EventHandler(this.AddCustTSMItem_Click);
            // 
            // EditTSMenuItem
            // 
            this.EditTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditOrdetTSMI,
            this.EditDishTSMI,
            this.EditRestTSMI,
            this.EditCustTSIM});
            this.EditTSMenuItem.Name = "EditTSMenuItem";
            this.EditTSMenuItem.Size = new System.Drawing.Size(123, 24);
            this.EditTSMenuItem.Text = "Редактировать";
            // 
            // EditOrdetTSMI
            // 
            this.EditOrdetTSMI.Name = "EditOrdetTSMI";
            this.EditOrdetTSMI.Size = new System.Drawing.Size(216, 26);
            this.EditOrdetTSMI.Text = "Заказ";
            this.EditOrdetTSMI.Click += new System.EventHandler(this.EditOrdetTSMI_Click);
            // 
            // EditDishTSMI
            // 
            this.EditDishTSMI.Name = "EditDishTSMI";
            this.EditDishTSMI.Size = new System.Drawing.Size(216, 26);
            this.EditDishTSMI.Text = "Блюдо";
            this.EditDishTSMI.Click += new System.EventHandler(this.EditDishTSMI_Click);
            // 
            // EditRestTSMI
            // 
            this.EditRestTSMI.Name = "EditRestTSMI";
            this.EditRestTSMI.Size = new System.Drawing.Size(216, 26);
            this.EditRestTSMI.Text = "Ресторан";
            this.EditRestTSMI.Click += new System.EventHandler(this.EditRestTSMI_Click);
            // 
            // EditCustTSIM
            // 
            this.EditCustTSIM.Name = "EditCustTSIM";
            this.EditCustTSIM.Size = new System.Drawing.Size(216, 26);
            this.EditCustTSIM.Text = "Заказчик";
            this.EditCustTSIM.Click += new System.EventHandler(this.EditCustTSIM_Click);
            // 
            // DeleteTSMenuItem
            // 
            this.DeleteTSMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelOrdTSMI,
            this.DelDishTSMI,
            this.DelRestTSMI,
            this.DelCustTCMI});
            this.DeleteTSMenuItem.Name = "DeleteTSMenuItem";
            this.DeleteTSMenuItem.Size = new System.Drawing.Size(77, 24);
            this.DeleteTSMenuItem.Text = "Удалить";
            // 
            // DelOrdTSMI
            // 
            this.DelOrdTSMI.Name = "DelOrdTSMI";
            this.DelOrdTSMI.Size = new System.Drawing.Size(216, 26);
            this.DelOrdTSMI.Text = "Заказ";
            this.DelOrdTSMI.Click += new System.EventHandler(this.DelOrdTSMI_Click);
            // 
            // DelDishTSMI
            // 
            this.DelDishTSMI.Name = "DelDishTSMI";
            this.DelDishTSMI.Size = new System.Drawing.Size(216, 26);
            this.DelDishTSMI.Text = "Блюдо";
            this.DelDishTSMI.Click += new System.EventHandler(this.DelDishTSMI_Click);
            // 
            // DelRestTSMI
            // 
            this.DelRestTSMI.Name = "DelRestTSMI";
            this.DelRestTSMI.Size = new System.Drawing.Size(216, 26);
            this.DelRestTSMI.Text = "Ресторан";
            this.DelRestTSMI.Click += new System.EventHandler(this.DelRestTSMI_Click);
            // 
            // DelCustTCMI
            // 
            this.DelCustTCMI.Name = "DelCustTCMI";
            this.DelCustTCMI.Size = new System.Drawing.Size(216, 26);
            this.DelCustTCMI.Text = "Заказчик";
            this.DelCustTCMI.Click += new System.EventHandler(this.DelCustTCMI_Click);
            // 
            // UpdateTSMenuItem
            // 
            this.UpdateTSMenuItem.Name = "UpdateTSMenuItem";
            this.UpdateTSMenuItem.Size = new System.Drawing.Size(99, 24);
            this.UpdateTSMenuItem.Text = "Обновить...";
            this.UpdateTSMenuItem.Click += new System.EventHandler(this.UpdateTSMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.Text = "Order\'s Info";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestListTSMItem;
        private System.Windows.Forms.ToolStripMenuItem DishListTSMItem;
        private System.Windows.Forms.ToolStripMenuItem CustListTSMItem;
        private System.Windows.Forms.ToolStripMenuItem AddOrderTSMItem;
        private System.Windows.Forms.ToolStripMenuItem AddDishTSMItem;
        private System.Windows.Forms.ToolStripMenuItem AddRestTSMItem;
        private System.Windows.Forms.ToolStripMenuItem AddCustTSMItem;
        private System.Windows.Forms.ToolStripMenuItem EditOrdetTSMI;
        private System.Windows.Forms.ToolStripMenuItem EditDishTSMI;
        private System.Windows.Forms.ToolStripMenuItem EditRestTSMI;
        private System.Windows.Forms.ToolStripMenuItem EditCustTSIM;
        private System.Windows.Forms.ToolStripMenuItem DelOrdTSMI;
        private System.Windows.Forms.ToolStripMenuItem DelDishTSMI;
        private System.Windows.Forms.ToolStripMenuItem DelRestTSMI;
        private System.Windows.Forms.ToolStripMenuItem DelCustTCMI;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem UpdateTSMenuItem;
    }
}

