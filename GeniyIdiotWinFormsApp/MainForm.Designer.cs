namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(67, 224);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(209, 107);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(113, 25);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoEllipsis = true;
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextLabel.Location = new System.Drawing.Point(12, 54);
            this.questionTextLabel.MaximumSize = new System.Drawing.Size(300, 150);
            this.questionTextLabel.MinimumSize = new System.Drawing.Size(25, 25);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(146, 25);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Текст вопроса";
            this.questionTextLabel.UseWaitCursor = true;
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(12, 161);
            this.userAnswerTextBox.Multiline = true;
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(227, 22);
            this.userAnswerTextBox.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 377);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.nextButton);
            this.Name = "MainForm";
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label questionNumberLabel;

        #endregion
    }
}