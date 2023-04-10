namespace OOP_1
{
    partial class FirstExercise
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToSecondExerciseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ToFirstExtraTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число";
            // 
            // ToSecondExerciseButton
            // 
            this.ToSecondExerciseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToSecondExerciseButton.Location = new System.Drawing.Point(602, 344);
            this.ToSecondExerciseButton.Name = "ToSecondExerciseButton";
            this.ToSecondExerciseButton.Size = new System.Drawing.Size(186, 94);
            this.ToSecondExerciseButton.TabIndex = 2;
            this.ToSecondExerciseButton.Text = "Перейти ко 2 заданию";
            this.ToSecondExerciseButton.UseVisualStyleBackColor = true;
            this.ToSecondExerciseButton.Click += new System.EventHandler(this.ToSecondExerciseButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(602, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 94);
            this.button1.TabIndex = 3;
            this.button1.Text = "Перейти к 3 заданию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToFirstExtraTaskButton
            // 
            this.ToFirstExtraTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToFirstExtraTaskButton.Location = new System.Drawing.Point(15, 221);
            this.ToFirstExtraTaskButton.Name = "ToFirstExtraTaskButton";
            this.ToFirstExtraTaskButton.Size = new System.Drawing.Size(186, 94);
            this.ToFirstExtraTaskButton.TabIndex = 4;
            this.ToFirstExtraTaskButton.Text = "Перейти к доп. заданию №1 (Приведение типов)";
            this.ToFirstExtraTaskButton.UseVisualStyleBackColor = true;
            this.ToFirstExtraTaskButton.Click += new System.EventHandler(this.ToFirstExtraTaskButton_Click);
            // 
            // FirstExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToFirstExtraTaskButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToSecondExerciseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FirstExercise";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToSecondExerciseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ToFirstExtraTaskButton;
    }
}

