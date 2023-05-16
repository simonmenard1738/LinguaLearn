namespace LinguaLearn
{
    partial class DictationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictationForm));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(100, 74);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(269, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(186, 116);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(75, 23);
            this.answerButton.TabIndex = 1;
            this.answerButton.Text = "Answer";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(183, 48);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(89, 13);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.Text = "Listen carefully....";
            // 
            // DictationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 191);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.inputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DictationForm";
            this.Text = "Dictation Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

