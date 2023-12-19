namespace multiplication_table
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(158, 90);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(481, 28);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(143, 213);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(506, 47);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(347, 150);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 22);
            this.answerTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Проверка таблицы умножения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox answerTextBox;
    }
}

