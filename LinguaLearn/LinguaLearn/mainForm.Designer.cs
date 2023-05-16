namespace LinguaLearn
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.applaButton = new System.Windows.Forms.Button();
            this.vocabButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matchButton = new System.Windows.Forms.Button();
            this.vocabularyButton = new System.Windows.Forms.Button();
            this.grammerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "          LinguaLearn \r\nLanguage Learning App";
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(364, 15);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(216, 20);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "French",
            "Spanish"});
            this.languageComboBox.Location = new System.Drawing.Point(364, 54);
            this.languageComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(215, 24);
            this.languageComboBox.TabIndex = 2;
            this.languageComboBox.Text = "Choose a Language to Learn";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(20, 211);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(115, 28);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // applaButton
            // 
            this.applaButton.Location = new System.Drawing.Point(20, 175);
            this.applaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applaButton.Name = "applaButton";
            this.applaButton.Size = new System.Drawing.Size(115, 28);
            this.applaButton.TabIndex = 4;
            this.applaButton.Text = "App Language";
            this.applaButton.UseVisualStyleBackColor = true;
            // 
            // vocabButton
            // 
            this.vocabButton.Location = new System.Drawing.Point(20, 139);
            this.vocabButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vocabButton.Name = "vocabButton";
            this.vocabButton.Size = new System.Drawing.Size(115, 28);
            this.vocabButton.TabIndex = 5;
            this.vocabButton.Text = "Vocabulary";
            this.vocabButton.UseVisualStyleBackColor = true;
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(20, 103);
            this.statusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(115, 28);
            this.statusButton.TabIndex = 6;
            this.statusButton.Text = "Status";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matchButton);
            this.groupBox1.Controls.Add(this.vocabularyButton);
            this.groupBox1.Controls.Add(this.grammerButton);
            this.groupBox1.Location = new System.Drawing.Point(5, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(433, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quizzes";
            // 
            // matchButton
            // 
            this.matchButton.Location = new System.Drawing.Point(296, 34);
            this.matchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(115, 47);
            this.matchButton.TabIndex = 11;
            this.matchButton.Text = "Matching";
            this.matchButton.UseVisualStyleBackColor = true;
            // 
            // vocabularyButton
            // 
            this.vocabularyButton.Location = new System.Drawing.Point(159, 34);
            this.vocabularyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vocabularyButton.Name = "vocabularyButton";
            this.vocabularyButton.Size = new System.Drawing.Size(115, 47);
            this.vocabularyButton.TabIndex = 10;
            this.vocabularyButton.Text = "Vocabulary";
            this.vocabularyButton.UseVisualStyleBackColor = true;
            this.vocabularyButton.Click += new System.EventHandler(this.vocabularyButton_Click);
            // 
            // grammerButton
            // 
            this.grammerButton.Location = new System.Drawing.Point(20, 34);
            this.grammerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grammerButton.Name = "grammerButton";
            this.grammerButton.Size = new System.Drawing.Size(115, 47);
            this.grammerButton.TabIndex = 9;
            this.grammerButton.Text = "Grammar";
            this.grammerButton.UseVisualStyleBackColor = true;
            this.grammerButton.Click += new System.EventHandler(this.grammerButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(143, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 229);
            this.panel1.TabIndex = 8;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(20, 287);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 29);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 337);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.vocabButton);
            this.Controls.Add(this.applaButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button applaButton;
        private System.Windows.Forms.Button vocabButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vocabularyButton;
        private System.Windows.Forms.Button grammerButton;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Button exitButton;
    }
}