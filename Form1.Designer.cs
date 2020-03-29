namespace ThreadMessages
{
    partial class Form1
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
            this.SendTextBoxUser1 = new System.Windows.Forms.TextBox();
            this.SendButtonUser1 = new System.Windows.Forms.Button();
            ReceiveTextBoxUser1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendTextBoxUser1
            // 
            this.SendTextBoxUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendTextBoxUser1.Location = new System.Drawing.Point(12, 47);
            this.SendTextBoxUser1.Multiline = true;
            this.SendTextBoxUser1.Name = "SendTextBoxUser1";
            this.SendTextBoxUser1.Size = new System.Drawing.Size(286, 391);
            this.SendTextBoxUser1.TabIndex = 0;
            // 
            // SendButtonUser1
            // 
            this.SendButtonUser1.Location = new System.Drawing.Point(631, 47);
            this.SendButtonUser1.Name = "SendButtonUser1";
            this.SendButtonUser1.Size = new System.Drawing.Size(157, 47);
            this.SendButtonUser1.TabIndex = 1;
            this.SendButtonUser1.Text = "Отправить";
            this.SendButtonUser1.UseVisualStyleBackColor = true;
            this.SendButtonUser1.Click += new System.EventHandler(this.SendButtonUser1_Click);
            // 
            // ReceiveTextBoxUser1
            // 
            ReceiveTextBoxUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ReceiveTextBoxUser1.Location = new System.Drawing.Point(328, 47);
            ReceiveTextBoxUser1.Multiline = true;
            ReceiveTextBoxUser1.Name = "ReceiveTextBoxUser1";
            ReceiveTextBoxUser1.Size = new System.Drawing.Size(286, 391);
            ReceiveTextBoxUser1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Отправить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(412, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Получить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(ReceiveTextBoxUser1);
            this.Controls.Add(this.SendButtonUser1);
            this.Controls.Add(this.SendTextBoxUser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SendTextBoxUser1;
        private System.Windows.Forms.Button SendButtonUser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        static private System.Windows.Forms.TextBox ReceiveTextBoxUser1;
    }
}

