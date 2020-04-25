namespace kursovaya
{
    partial class AddCustForm
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя заказчика:";
            // 
            // CustTB
            // 
            this.CustTB.Location = new System.Drawing.Point(240, 13);
            this.CustTB.Name = "CustTB";
            this.CustTB.Size = new System.Drawing.Size(179, 22);
            this.CustTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите телефон заказчика:";
            // 
            // TelTB
            // 
            this.TelTB.Location = new System.Drawing.Point(240, 46);
            this.TelTB.Name = "TelTB";
            this.TelTB.Size = new System.Drawing.Size(179, 22);
            this.TelTB.TabIndex = 3;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(19, 75);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(83, 23);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // AddCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 110);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.TelTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustTB);
            this.Controls.Add(this.label1);
            this.Name = "AddCustForm";
            this.Text = "AddCustForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TelTB;
        private System.Windows.Forms.Button Add_button;
    }
}