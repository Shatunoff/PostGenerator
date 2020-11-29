namespace PostGenerator
{
    partial class ShedulerSettingsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudImageTimeout = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTextTimeout = new System.Windows.Forms.NumericUpDown();
            this.nudPubHoursRangeFrom = new System.Windows.Forms.NumericUpDown();
            this.nudPubHoursRangeTo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudIntervalBetweenPosts = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTextTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPubHoursRangeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPubHoursRangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalBetweenPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudIntervalBetweenPosts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudPubHoursRangeTo);
            this.groupBox1.Controls.Add(this.nudPubHoursRangeFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudTextTimeout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudImageTimeout);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Планирование публикаций";
            // 
            // nudImageTimeout
            // 
            this.nudImageTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudImageTimeout.Location = new System.Drawing.Point(203, 19);
            this.nudImageTimeout.Name = "nudImageTimeout";
            this.nudImageTimeout.Size = new System.Drawing.Size(60, 20);
            this.nudImageTimeout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тайм-аут для изображений (дней):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тайм-аут для текстов (дней):";
            // 
            // nudTextTimeout
            // 
            this.nudTextTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTextTimeout.Location = new System.Drawing.Point(203, 45);
            this.nudTextTimeout.Name = "nudTextTimeout";
            this.nudTextTimeout.Size = new System.Drawing.Size(60, 20);
            this.nudTextTimeout.TabIndex = 2;
            // 
            // nudPubHoursRangeFrom
            // 
            this.nudPubHoursRangeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPubHoursRangeFrom.Location = new System.Drawing.Point(203, 71);
            this.nudPubHoursRangeFrom.Name = "nudPubHoursRangeFrom";
            this.nudPubHoursRangeFrom.Size = new System.Drawing.Size(60, 20);
            this.nudPubHoursRangeFrom.TabIndex = 4;
            // 
            // nudPubHoursRangeTo
            // 
            this.nudPubHoursRangeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPubHoursRangeTo.Location = new System.Drawing.Point(203, 97);
            this.nudPubHoursRangeTo.Name = "nudPubHoursRangeTo";
            this.nudPubHoursRangeTo.Size = new System.Drawing.Size(60, 20);
            this.nudPubHoursRangeTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Диапазон часов публикации, ОТ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Диапазон часов публикации, ДО:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Интервал между постами, ОТ (мин):";
            // 
            // nudIntervalBetweenPosts
            // 
            this.nudIntervalBetweenPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIntervalBetweenPosts.Location = new System.Drawing.Point(203, 123);
            this.nudIntervalBetweenPosts.Name = "nudIntervalBetweenPosts";
            this.nudIntervalBetweenPosts.Size = new System.Drawing.Size(60, 20);
            this.nudIntervalBetweenPosts.TabIndex = 9;
            // 
            // ShedulerSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ShedulerSettingsControl";
            this.Size = new System.Drawing.Size(269, 155);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTextTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPubHoursRangeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPubHoursRangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalBetweenPosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPubHoursRangeTo;
        private System.Windows.Forms.NumericUpDown nudPubHoursRangeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTextTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudImageTimeout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudIntervalBetweenPosts;
    }
}
