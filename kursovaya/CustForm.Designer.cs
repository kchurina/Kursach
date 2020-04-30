namespace kursovaya
{
    partial class CustForm
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
            this.CustTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TelTB = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.IdCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя заказчика:";
            // 
            // CustTB
            // 
            this.CustTB.Location = new System.Drawing.Point(170, 49);
            this.CustTB.Name = "CustTB";
            this.CustTB.Size = new System.Drawing.Size(179, 22);
            this.CustTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон заказчика:";
            // 
            // TelTB
            // 
            this.TelTB.Location = new System.Drawing.Point(170, 82);
            this.TelTB.Name = "TelTB";
            this.TelTB.Size = new System.Drawing.Size(179, 22);
            this.TelTB.TabIndex = 3;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(15, 111);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(95, 23);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // IdCB
            // 
            this.IdCB.FormattingEnabled = true;
            this.IdCB.Location = new System.Drawing.Point(170, 12);
            this.IdCB.Name = "IdCB";
            this.IdCB.Size = new System.Drawing.Size(179, 24);
            this.IdCB.TabIndex = 5;
            this.IdCB.SelectedIndexChanged += new System.EventHandler(this.IdCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID пользователя";
            // 
            // CustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 146);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdCB);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.TelTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustTB);
            this.Controls.Add(this.label1);
            this.Name = "CustForm";
            this.Text = "CustForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TelTB;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ComboBox IdCB;
        private System.Windows.Forms.Label label3;
    }
}