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
            this.btnRenderCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastNumber = new System.Windows.Forms.Label();
            this.btnResetPool = new System.Windows.Forms.Button();
            this.btnResetSet = new System.Windows.Forms.Button();
            this.btnMakeBatch = new System.Windows.Forms.Button();
            this.nudBatchSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoublesOccurs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).BeginInit();
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
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConsole.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConsole.Location = new System.Drawing.Point(13, 80);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(559, 535);
            this.txtConsole.TabIndex = 1;
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(139, 38);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(115, 23);
            this.btnMark.TabIndex = 2;
            this.btnMark.Text = "Отметить";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnRenderCard
            // 
            this.btnRenderCard.Location = new System.Drawing.Point(294, 12);
            this.btnRenderCard.Name = "btnRenderCard";
            this.btnRenderCard.Size = new System.Drawing.Size(112, 23);
            this.btnRenderCard.TabIndex = 3;
            this.btnRenderCard.Text = "Нарисовать карту";
            this.btnRenderCard.UseVisualStyleBackColor = true;
            this.btnRenderCard.Click += new System.EventHandler(this.btnRenderCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущее число: ";
            // 
            // lblLastNumber
            // 
            this.lblLastNumber.AutoSize = true;
            this.lblLastNumber.Location = new System.Drawing.Point(110, 43);
            this.lblLastNumber.Name = "lblLastNumber";
            this.lblLastNumber.Size = new System.Drawing.Size(16, 13);
            this.lblLastNumber.TabIndex = 5;
            this.lblLastNumber.Text = "...";
            // 
            // btnResetPool
            // 
            this.btnResetPool.Location = new System.Drawing.Point(294, 38);
            this.btnResetPool.Name = "btnResetPool";
            this.btnResetPool.Size = new System.Drawing.Size(112, 23);
            this.btnResetPool.TabIndex = 6;
            this.btnResetPool.Text = "Сбросить пул";
            this.btnResetPool.UseVisualStyleBackColor = true;
            this.btnResetPool.Click += new System.EventHandler(this.btnResetPool_Click);
            // 
            // btnResetSet
            // 
            this.btnResetSet.Location = new System.Drawing.Point(139, 13);
            this.btnResetSet.Name = "btnResetSet";
            this.btnResetSet.Size = new System.Drawing.Size(115, 23);
            this.btnResetSet.TabIndex = 7;
            this.btnResetSet.Text = "Сбросить диапазон";
            this.btnResetSet.UseVisualStyleBackColor = true;
            this.btnResetSet.Click += new System.EventHandler(this.btnResetSet_Click);
            // 
            // btnMakeBatch
            // 
            this.btnMakeBatch.Location = new System.Drawing.Point(442, 38);
            this.btnMakeBatch.Name = "btnMakeBatch";
            this.btnMakeBatch.Size = new System.Drawing.Size(112, 23);
            this.btnMakeBatch.TabIndex = 8;
            this.btnMakeBatch.Text = "Создать партию";
            this.btnMakeBatch.UseVisualStyleBackColor = true;
            this.btnMakeBatch.Click += new System.EventHandler(this.btnMakeBatch_Click);
            // 
            // nudBatchSize
            // 
            this.nudBatchSize.Location = new System.Drawing.Point(442, 12);
            this.nudBatchSize.Maximum = new decimal(new int[] {
            110,
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
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сбросов из-за дублей:";
            // 
            // lblDoublesOccurs
            // 
            this.lblDoublesOccurs.AutoSize = true;
            this.lblDoublesOccurs.Location = new System.Drawing.Point(557, 64);
            this.lblDoublesOccurs.Name = "lblDoublesOccurs";
            this.lblDoublesOccurs.Size = new System.Drawing.Size(13, 13);
            this.lblDoublesOccurs.TabIndex = 11;
            this.lblDoublesOccurs.Text = "0";
            // 
            // GeneratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 627);
            this.Controls.Add(this.lblDoublesOccurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudBatchSize);
            this.Controls.Add(this.btnMakeBatch);
            this.Controls.Add(this.btnResetSet);
            this.Controls.Add(this.btnResetPool);
            this.Controls.Add(this.lblLastNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenderCard);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnNextNumber);
            this.Name = "GeneratorView";
            this.Text = "Генератор карт лото";
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextNumber;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnRenderCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastNumber;
        private System.Windows.Forms.Button btnResetPool;
        private System.Windows.Forms.Button btnResetSet;
        private System.Windows.Forms.Button btnMakeBatch;
        private System.Windows.Forms.NumericUpDown nudBatchSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoublesOccurs;
    }
}

