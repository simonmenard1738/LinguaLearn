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
            this.label1 = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.vocabButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matchButton = new System.Windows.Forms.Button();
            this.vocabularyButton = new System.Windows.Forms.Button();
            this.grammerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // displayLabel
            // 
            resources.ApplyResources(this.displayLabel, "displayLabel");
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Name = "displayLabel";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            this.comboBox1.Name = "comboBox1";
            // 
            // aboutButton
            // 
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // vocabButton
            // 
            resources.ApplyResources(this.vocabButton, "vocabButton");
            this.vocabButton.Name = "vocabButton";
            this.vocabButton.UseVisualStyleBackColor = true;
            // 
            // statusButton
            // 
            resources.ApplyResources(this.statusButton, "statusButton");
            this.statusButton.Name = "statusButton";
            this.statusButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.matchButton);
            this.groupBox1.Controls.Add(this.vocabularyButton);
            this.groupBox1.Controls.Add(this.grammerButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // matchButton
            // 
            resources.ApplyResources(this.matchButton, "matchButton");
            this.matchButton.Name = "matchButton";
            this.matchButton.UseVisualStyleBackColor = true;
            // 
            // vocabularyButton
            // 
            resources.ApplyResources(this.vocabularyButton, "vocabularyButton");
            this.vocabularyButton.Name = "vocabularyButton";
            this.vocabularyButton.UseVisualStyleBackColor = true;
            // 
            // grammerButton
            // 
            resources.ApplyResources(this.grammerButton, "grammerButton");
            this.grammerButton.Name = "grammerButton";
            this.grammerButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Name = "panel1";
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.vocabButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button vocabButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vocabularyButton;
        private System.Windows.Forms.Button grammerButton;
        private System.Windows.Forms.Button matchButton;
    }
}