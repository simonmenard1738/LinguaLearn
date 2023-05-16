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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
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
            this.legoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(317, 29);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(162, 16);
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
            this.languageComboBox.Location = new System.Drawing.Point(317, 61);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(162, 21);
            this.languageComboBox.TabIndex = 2;
            this.languageComboBox.Text = "Choose a Language to Learn";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(36, 212);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(86, 23);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // applaButton
            // 
            this.applaButton.Location = new System.Drawing.Point(36, 183);
            this.applaButton.Name = "applaButton";
            this.applaButton.Size = new System.Drawing.Size(86, 23);
            this.applaButton.TabIndex = 4;
            this.applaButton.Text = "App Language";
            this.applaButton.UseVisualStyleBackColor = true;
            // 
            // vocabButton
            // 
            this.vocabButton.Location = new System.Drawing.Point(36, 154);
            this.vocabButton.Name = "vocabButton";
            this.vocabButton.Size = new System.Drawing.Size(86, 23);
            this.vocabButton.TabIndex = 5;
            this.vocabButton.Text = "Vocabulary";
            this.vocabButton.UseVisualStyleBackColor = true;
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(36, 125);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(86, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quizzes";
            // 
            // matchButton
            // 
            this.matchButton.Location = new System.Drawing.Point(224, 48);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(86, 38);
            this.matchButton.TabIndex = 11;
            this.matchButton.Text = "Matching";
            this.matchButton.UseVisualStyleBackColor = true;
            // 
            // vocabularyButton
            // 
            this.vocabularyButton.Location = new System.Drawing.Point(121, 48);
            this.vocabularyButton.Name = "vocabularyButton";
            this.vocabularyButton.Size = new System.Drawing.Size(86, 38);
            this.vocabularyButton.TabIndex = 10;
            this.vocabularyButton.Text = "Vocabulary";
            this.vocabularyButton.UseVisualStyleBackColor = true;
            this.vocabularyButton.Click += new System.EventHandler(this.vocabularyButton_Click);
            // 
            // grammerButton
            // 
            this.grammerButton.Location = new System.Drawing.Point(17, 48);
            this.grammerButton.Name = "grammerButton";
            this.grammerButton.Size = new System.Drawing.Size(86, 38);
            this.grammerButton.TabIndex = 9;
            this.grammerButton.Text = "Grammar";
            this.grammerButton.UseVisualStyleBackColor = true;
            this.grammerButton.Click += new System.EventHandler(this.grammerButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(150, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 186);
            this.panel1.TabIndex = 8;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(36, 263);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 24);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // legoPictureBox
            // 
            this.legoPictureBox.Image = global::LinguaLearn.Properties.Resources.aboutLogo;
            this.legoPictureBox.InitialImage = global::LinguaLearn.Properties.Resources.aboutLogo;
            this.legoPictureBox.Location = new System.Drawing.Point(16, 8);
            this.legoPictureBox.Name = "legoPictureBox";
            this.legoPictureBox.Size = new System.Drawing.Size(128, 100);
            this.legoPictureBox.TabIndex = 10;
            this.legoPictureBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 303);
            this.Controls.Add(this.legoPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.vocabButton);
            this.Controls.Add(this.applaButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.displayLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.legoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.PictureBox legoPictureBox;
    }
}