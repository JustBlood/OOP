namespace OOP_1
{
    partial class SecondExercise
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
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.dotNetLabel = new System.Windows.Forms.Label();
            this.newtoneLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.inaccuracyLabel = new System.Windows.Forms.Label();
            this.getNextIteration = new System.Windows.Forms.Button();
            this.inaccurancyIterations = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iterationsValue = new System.Windows.Forms.Label();
            this.resultInaccurancy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(48, 59);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(567, 20);
            this.valueTextBox.TabIndex = 0;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            // 
            // dotNetLabel
            // 
            this.dotNetLabel.AutoSize = true;
            this.dotNetLabel.Location = new System.Drawing.Point(45, 100);
            this.dotNetLabel.Name = "dotNetLabel";
            this.dotNetLabel.Size = new System.Drawing.Size(117, 13);
            this.dotNetLabel.TabIndex = 1;
            this.dotNetLabel.Text = "Using .NET Framework";
            // 
            // newtoneLabel
            // 
            this.newtoneLabel.AutoSize = true;
            this.newtoneLabel.Location = new System.Drawing.Point(45, 129);
            this.newtoneLabel.Name = "newtoneLabel";
            this.newtoneLabel.Size = new System.Drawing.Size(80, 13);
            this.newtoneLabel.TabIndex = 2;
            this.newtoneLabel.Text = "Using Newtone";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(621, 59);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(133, 20);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.сalculateButton_Click);
            // 
            // inaccuracyLabel
            // 
            this.inaccuracyLabel.AutoSize = true;
            this.inaccuracyLabel.Location = new System.Drawing.Point(45, 164);
            this.inaccuracyLabel.Name = "inaccuracyLabel";
            this.inaccuracyLabel.Size = new System.Drawing.Size(210, 13);
            this.inaccuracyLabel.TabIndex = 4;
            this.inaccuracyLabel.Text = "Погрешность между .NET и Ньютоном: ";
            // 
            // getNextIteration
            // 
            this.getNextIteration.Location = new System.Drawing.Point(621, 30);
            this.getNextIteration.Name = "getNextIteration";
            this.getNextIteration.Size = new System.Drawing.Size(133, 23);
            this.getNextIteration.TabIndex = 5;
            this.getNextIteration.Text = "Выполнить итерацию";
            this.getNextIteration.UseVisualStyleBackColor = true;
            this.getNextIteration.Click += new System.EventHandler(this.getNextIteration_Click);
            // 
            // inaccurancyIterations
            // 
            this.inaccurancyIterations.AutoSize = true;
            this.inaccurancyIterations.Location = new System.Drawing.Point(45, 258);
            this.inaccurancyIterations.Name = "inaccurancyIterations";
            this.inaccurancyIterations.Size = new System.Drawing.Size(131, 13);
            this.inaccurancyIterations.TabIndex = 6;
            this.inaccurancyIterations.Text = "Погрешность итерации: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сбросить итерации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.iterationButton_Click);
            // 
            // iterationsValue
            // 
            this.iterationsValue.AutoSize = true;
            this.iterationsValue.Location = new System.Drawing.Point(45, 225);
            this.iterationsValue.Name = "iterationsValue";
            this.iterationsValue.Size = new System.Drawing.Size(204, 13);
            this.iterationsValue.TabIndex = 8;
            this.iterationsValue.Text = "Значение итерационного вычисления: ";
            // 
            // resultInaccurancy
            // 
            this.resultInaccurancy.AutoSize = true;
            this.resultInaccurancy.Location = new System.Drawing.Point(45, 290);
            this.resultInaccurancy.Name = "resultInaccurancy";
            this.resultInaccurancy.Size = new System.Drawing.Size(117, 13);
            this.resultInaccurancy.TabIndex = 9;
            this.resultInaccurancy.Text = "Общая погрешность: ";
            // 
            // SecondExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultInaccurancy);
            this.Controls.Add(this.iterationsValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inaccurancyIterations);
            this.Controls.Add(this.getNextIteration);
            this.Controls.Add(this.inaccuracyLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.newtoneLabel);
            this.Controls.Add(this.dotNetLabel);
            this.Controls.Add(this.valueTextBox);
            this.Name = "SecondExercise";
            this.Text = "SecondExercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label dotNetLabel;
        private System.Windows.Forms.Label newtoneLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label inaccuracyLabel;
        private System.Windows.Forms.Button getNextIteration;
        private System.Windows.Forms.Label inaccurancyIterations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label iterationsValue;
        private System.Windows.Forms.Label resultInaccurancy;
    }
}