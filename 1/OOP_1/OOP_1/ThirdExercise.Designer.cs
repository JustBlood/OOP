namespace OOP_1
{
    partial class ThirdExercise
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
            this.toBinaryTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertedValueLabel = new System.Windows.Forms.Label();
            this.systemToConvert = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // toBinaryTextBox
            // 
            this.toBinaryTextBox.Location = new System.Drawing.Point(30, 33);
            this.toBinaryTextBox.Name = "toBinaryTextBox";
            this.toBinaryTextBox.Size = new System.Drawing.Size(252, 20);
            this.toBinaryTextBox.TabIndex = 0;
            this.toBinaryTextBox.Text = "O";
            this.toBinaryTextBox.TextChanged += new System.EventHandler(this.toBinaryTextBox_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertButton.Location = new System.Drawing.Point(480, 33);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(98, 20);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // convertedValueLabel
            // 
            this.convertedValueLabel.AutoSize = true;
            this.convertedValueLabel.Location = new System.Drawing.Point(27, 70);
            this.convertedValueLabel.Name = "convertedValueLabel";
            this.convertedValueLabel.Size = new System.Drawing.Size(15, 13);
            this.convertedValueLabel.TabIndex = 2;
            this.convertedValueLabel.Text = "O";
            // 
            // systemToConvert
            // 
            this.systemToConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemToConvert.FormattingEnabled = true;
            this.systemToConvert.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.systemToConvert.Location = new System.Drawing.Point(314, 32);
            this.systemToConvert.Name = "systemToConvert";
            this.systemToConvert.Size = new System.Drawing.Size(121, 21);
            this.systemToConvert.TabIndex = 3;
            // 
            // ThirdExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.systemToConvert);
            this.Controls.Add(this.convertedValueLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.toBinaryTextBox);
            this.Name = "ThirdExercise";
            this.Text = "Перевод в системы счисления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toBinaryTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label convertedValueLabel;
        private System.Windows.Forms.ComboBox systemToConvert;
    }
}