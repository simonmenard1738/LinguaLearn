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
            this.vocabButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            resources.ApplyResources(this.displayLabel, "displayLabel");
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Name = "displayLabel";
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // aboutButton
            // 
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // vocabButton
            // 
            resources.ApplyResources(this.vocabButton, "vocabButton");
            this.vocabButton.Name = "vocabButton";
            this.vocabButton.UseVisualStyleBackColor = true;
            this.vocabButton.Click += new System.EventHandler(this.vocabButton_Click);
            // 
            // statusButton
            // 
            resources.ApplyResources(this.statusButton, "statusButton");
            this.statusButton.Name = "statusButton";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.vocabularyButton);
            this.groupBox1.Controls.Add(this.grammerButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // vocabularyButton
            // 
            resources.ApplyResources(this.vocabularyButton, "vocabularyButton");
            this.vocabularyButton.Name = "vocabularyButton";
            this.vocabularyButton.UseVisualStyleBackColor = true;
            this.vocabularyButton.Click += new System.EventHandler(this.vocabularyButton_Click);
            // 
            // grammerButton
            // 
            resources.ApplyResources(this.grammerButton, "grammerButton");
            this.grammerButton.Name = "grammerButton";
            this.grammerButton.UseVisualStyleBackColor = true;
            this.grammerButton.Click += new System.EventHandler(this.grammerButton_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Name = "panel1";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // legoPictureBox
            // 
            resources.ApplyResources(this.legoPictureBox, "legoPictureBox");
            this.legoPictureBox.Image = global::LinguaLearn.Properties.Resources.aboutLogo;
            this.legoPictureBox.InitialImage = global::LinguaLearn.Properties.Resources.aboutLogo;
            this.legoPictureBox.Name = "legoPictureBox";
            this.legoPictureBox.TabStop = false;
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.legoPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.vocabButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.displayLabel);
            this.Name = "mainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.legoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button vocabButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vocabularyButton;
        private System.Windows.Forms.Button grammerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox legoPictureBox;
    }
}