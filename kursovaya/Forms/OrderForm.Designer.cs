namespace kursovaya
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerCB = new System.Windows.Forms.ComboBox();
            this.TelTB = new System.Windows.Forms.TextBox();
            this.costTB = new System.Windows.Forms.TextBox();
            this.statusLB = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RestCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addDishButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.DelTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.IdCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата Заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заказчик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Телефон заказчика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Общая стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Статус заказа";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(163, 63);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 6;
            // 
            // CustomerCB
            // 
            this.CustomerCB.FormattingEnabled = true;
            this.CustomerCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustomerCB.Location = new System.Drawing.Point(163, 97);
            this.CustomerCB.Name = "CustomerCB";
            this.CustomerCB.Size = new System.Drawing.Size(200, 24);
            this.CustomerCB.TabIndex = 7;
            this.CustomerCB.SelectedIndexChanged += new System.EventHandler(this.CustomerCB_SelectedIndexChanged);
            // 
            // TelTB
            // 
            this.TelTB.BackColor = System.Drawing.SystemColors.Control;
            this.TelTB.Location = new System.Drawing.Point(163, 136);
            this.TelTB.Name = "TelTB";
            this.TelTB.ReadOnly = true;
            this.TelTB.Size = new System.Drawing.Size(200, 22);
            this.TelTB.TabIndex = 8;
            // 
            // costTB
            // 
            this.costTB.Location = new System.Drawing.Point(163, 217);
            this.costTB.Name = "costTB";
            this.costTB.ReadOnly = true;
            this.costTB.Size = new System.Drawing.Size(200, 22);
            this.costTB.TabIndex = 9;
            // 
            // statusLB
            // 
            this.statusLB.FormattingEnabled = true;
            this.statusLB.ItemHeight = 16;
            this.statusLB.Items.AddRange(new object[] {
            "Выполнено ",
            "В процессе"});
            this.statusLB.Location = new System.Drawing.Point(163, 286);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(103, 36);
            this.statusLB.TabIndex = 14;
            this.statusLB.SelectedIndexChanged += new System.EventHandler(this.statusLB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ресторан";
            // 
            // RestCB
            // 
            this.RestCB.FormattingEnabled = true;
            this.RestCB.Location = new System.Drawing.Point(163, 173);
            this.RestCB.Name = "RestCB";
            this.RestCB.Size = new System.Drawing.Size(200, 24);
            this.RestCB.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Блюда";
            // 
            // addDishButton
            // 
            this.addDishButton.Location = new System.Drawing.Point(20, 366);
            this.addDishButton.Name = "addDishButton";
            this.addDishButton.Size = new System.Drawing.Size(86, 23);
            this.addDishButton.TabIndex = 18;
            this.addDishButton.Text = "Добавить";
            this.addDishButton.UseVisualStyleBackColor = true;
            this.addDishButton.Click += new System.EventHandler(this.addDishButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(163, 245);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(103, 23);
            this.countButton.TabIndex = 19;
            this.countButton.Text = "Рассчитать";
            this.countButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(20, 396);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(86, 23);
            this.DelButton.TabIndex = 20;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DelTextBox
            // 
            this.DelTextBox.Location = new System.Drawing.Point(20, 426);
            this.DelTextBox.Name = "DelTextBox";
            this.DelTextBox.Size = new System.Drawing.Size(86, 22);
            this.DelTextBox.TabIndex = 21;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(20, 482);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(86, 45);
            this.AddOrderButton.TabIndex = 22;
            this.AddOrderButton.Text = "Добавить заказ";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID заказа";
            // 
            // IdCB
            // 
            this.IdCB.FormattingEnabled = true;
            this.IdCB.Location = new System.Drawing.Point(163, 21);
            this.IdCB.Name = "IdCB";
            this.IdCB.Size = new System.Drawing.Size(200, 24);
            this.IdCB.TabIndex = 24;
            this.IdCB.SelectedIndexChanged += new System.EventHandler(this.IdCB_SelectedIndexChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(469, 575);
            this.Controls.Add(this.IdCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.DelTextBox);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.addDishButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RestCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusLB);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.TelTB);
            this.Controls.Add(this.CustomerCB);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox CustomerCB;
        private System.Windows.Forms.TextBox TelTB;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.ListBox statusLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RestCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addDishButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.TextBox DelTextBox;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox IdCB;
    }
}