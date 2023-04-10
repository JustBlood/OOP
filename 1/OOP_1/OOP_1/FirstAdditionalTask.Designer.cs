namespace OOP_1
{
    partial class FirstAdditionalTask
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
            this.convertFromChoice = new System.Windows.Forms.ComboBox();
            this.convertToChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convertFromTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTypeLabel = new System.Windows.Forms.Label();
            this.resultValueLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertFromChoice
            // 
            this.convertFromChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertFromChoice.FormattingEnabled = true;
            this.convertFromChoice.Items.AddRange(new object[] {
            "char",
            "string",
            "byte",
            "int",
            "float",
            "double",
            "decimal",
            "bool",
            "object"});
            this.convertFromChoice.Location = new System.Drawing.Point(175, 71);
            this.convertFromChoice.Name = "convertFromChoice";
            this.convertFromChoice.Size = new System.Drawing.Size(144, 21);
            this.convertFromChoice.TabIndex = 0;
            // 
            // convertToChoice
            // 
            this.convertToChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertToChoice.FormattingEnabled = true;
            this.convertToChoice.Items.AddRange(new object[] {
            "object",
            "bool",
            "decimal",
            "double",
            "float",
            "int",
            "byte",
            "string",
            "char"});
            this.convertToChoice.Location = new System.Drawing.Point(447, 71);
            this.convertToChoice.Name = "convertToChoice";
            this.convertToChoice.Size = new System.Drawing.Size(144, 21);
            this.convertToChoice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перевести из";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Перевести в";
            // 
            // convertFromTextBox
            // 
            this.convertFromTextBox.Location = new System.Drawing.Point(313, 129);
            this.convertFromTextBox.Name = "convertFromTextBox";
            this.convertFromTextBox.Size = new System.Drawing.Size(144, 20);
            this.convertFromTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // resultTypeLabel
            // 
            this.resultTypeLabel.AutoSize = true;
            this.resultTypeLabel.Location = new System.Drawing.Point(382, 303);
            this.resultTypeLabel.Name = "resultTypeLabel";
            this.resultTypeLabel.Size = new System.Drawing.Size(26, 13);
            this.resultTypeLabel.TabIndex = 7;
            this.resultTypeLabel.Text = "Тип";
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.Location = new System.Drawing.Point(382, 332);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(55, 13);
            this.resultValueLabel.TabIndex = 8;
            this.resultValueLabel.Text = "Значение";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(313, 189);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(143, 36);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert!";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тип:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Значение:";
            // 
            // FirstAdditionalTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.resultValueLabel);
            this.Controls.Add(this.resultTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.convertFromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertToChoice);
            this.Controls.Add(this.convertFromChoice);
            this.Name = "FirstAdditionalTask";
            this.Text = "FirstAdditionalTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox convertFromChoice;
        private System.Windows.Forms.ComboBox convertToChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox convertFromTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultTypeLabel;
        private System.Windows.Forms.Label resultValueLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}