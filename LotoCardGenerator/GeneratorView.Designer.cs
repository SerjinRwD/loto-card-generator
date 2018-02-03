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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnMakeBatch = new System.Windows.Forms.Button();
            this.nudBatchSize = new System.Windows.Forms.NumericUpDown();
            this.lblBatchSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.savePdfDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConsole.Location = new System.Drawing.Point(0, 80);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(426, 114);
            this.txtConsole.TabIndex = 1;
            // 
            // btnMakeBatch
            // 
            this.btnMakeBatch.Location = new System.Drawing.Point(301, 7);
            this.btnMakeBatch.Name = "btnMakeBatch";
            this.btnMakeBatch.Size = new System.Drawing.Size(112, 23);
            this.btnMakeBatch.TabIndex = 8;
            this.btnMakeBatch.Text = "Создать партию";
            this.btnMakeBatch.UseVisualStyleBackColor = true;
            this.btnMakeBatch.Click += new System.EventHandler(this.btnMakeBatch_Click);
            // 
            // nudBatchSize
            // 
            this.nudBatchSize.Location = new System.Drawing.Point(12, 26);
            this.nudBatchSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBatchSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudBatchSize.Name = "nudBatchSize";
            this.nudBatchSize.Size = new System.Drawing.Size(110, 20);
            this.nudBatchSize.TabIndex = 9;
            this.nudBatchSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudBatchSize.ValueChanged += new System.EventHandler(this.nudBatchSize_ValueChanged);
            // 
            // lblBatchSize
            // 
            this.lblBatchSize.AutoSize = true;
            this.lblBatchSize.Location = new System.Drawing.Point(9, 7);
            this.lblBatchSize.Name = "lblBatchSize";
            this.lblBatchSize.Size = new System.Drawing.Size(92, 13);
            this.lblBatchSize.TabIndex = 10;
            this.lblBatchSize.Text = "Количество карт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Расчётное количество страниц:";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(183, 49);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(13, 13);
            this.lblPageCount.TabIndex = 12;
            this.lblPageCount.Text = "1";
            // 
            // savePdfDialog
            // 
            this.savePdfDialog.Filter = "PDF file|*.pdf";
            // 
            // GeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 194);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBatchSize);
            this.Controls.Add(this.nudBatchSize);
            this.Controls.Add(this.btnMakeBatch);
            this.Controls.Add(this.txtConsole);
            this.Name = "GeneratorView";
            this.Text = "Генератор карт лото";
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnMakeBatch;
        private System.Windows.Forms.NumericUpDown nudBatchSize;
        private System.Windows.Forms.Label lblBatchSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.SaveFileDialog savePdfDialog;
    }
}

