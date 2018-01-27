namespace LotoCardGenerator
{
    partial class GeneratorView
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
            this.btnNextNumber = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNextNumber
            // 
            this.btnNextNumber.Location = new System.Drawing.Point(13, 13);
            this.btnNextNumber.Name = "btnNextNumber";
            this.btnNextNumber.Size = new System.Drawing.Size(120, 23);
            this.btnNextNumber.TabIndex = 0;
            this.btnNextNumber.Text = "Следующее число";
            this.btnNextNumber.UseVisualStyleBackColor = true;
            this.btnNextNumber.Click += new System.EventHandler(this.btnNextNumber_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConsole.Location = new System.Drawing.Point(13, 42);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(259, 207);
            this.txtConsole.TabIndex = 1;
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(157, 13);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(115, 23);
            this.btnMark.TabIndex = 2;
            this.btnMark.Text = "Отметить";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // GeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnNextNumber);
            this.Name = "GeneratorView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextNumber;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnMark;
    }
}

