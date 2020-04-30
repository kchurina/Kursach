namespace kursovaya
{
    partial class DishForm
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
            this.AddB = new System.Windows.Forms.Button();
            this.IdCB = new System.Windows.Forms.ComboBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.cost_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID блюда:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название блюда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена блюда:";
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(12, 103);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(95, 23);
            this.AddB.TabIndex = 4;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // IdCB
            // 
            this.IdCB.FormattingEnabled = true;
            this.IdCB.Location = new System.Drawing.Point(159, 9);
            this.IdCB.Name = "IdCB";
            this.IdCB.Size = new System.Drawing.Size(154, 24);
            this.IdCB.TabIndex = 5;
            this.IdCB.SelectedIndexChanged += new System.EventHandler(this.IdCB_SelectedIndexChanged);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(159, 40);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(154, 22);
            this.name_box.TabIndex = 6;
            // 
            // cost_box
            // 
            this.cost_box.Location = new System.Drawing.Point(159, 69);
            this.cost_box.Name = "cost_box";
            this.cost_box.Size = new System.Drawing.Size(154, 22);
            this.cost_box.TabIndex = 7;
            // 
            // DishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 142);
            this.Controls.Add(this.cost_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.IdCB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DishForm";
            this.Text = "DishForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.ComboBox IdCB;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox cost_box;
    }
}