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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.applaButton = new System.Windows.Forms.Button();
            this.vocabButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grammerButton = new System.Windows.Forms.Button();
            this.vocabularyButton = new System.Windows.Forms.Button();
            this.matchButton = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "          LinguaLearn \r\nLanguage Learning App";
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(273, 12);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(162, 16);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "French",
            "Spanish?"});
            this.comboBox1.Location = new System.Drawing.Point(273, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Choose a Language to Learn";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(15, 214);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(86, 23);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // applaButton
            // 
            this.applaButton.Location = new System.Drawing.Point(15, 172);
            this.applaButton.Name = "applaButton";
            this.applaButton.Size = new System.Drawing.Size(86, 23);
            this.applaButton.TabIndex = 4;
            this.applaButton.Text = "App Language";
            this.applaButton.UseVisualStyleBackColor = true;
            // 
            // vocabButton
            // 
            this.vocabButton.Location = new System.Drawing.Point(15, 128);
            this.vocabButton.Name = "vocabButton";
            this.vocabButton.Size = new System.Drawing.Size(86, 23);
            this.vocabButton.TabIndex = 5;
            this.vocabButton.Text = "Vocabulary";
            this.vocabButton.UseVisualStyleBackColor = true;
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(15, 84);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(86, 23);
            this.statusButton.TabIndex = 6;
            this.statusButton.Text = "Status";
            this.statusButton.UseVisualStyleBackColor = true;
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
            this.groupBox1.Text = "Quizes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(107, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 186);
            this.panel1.TabIndex = 8;
            // 
            // grammerButton
            // 
            this.grammerButton.Location = new System.Drawing.Point(15, 71);
            this.grammerButton.Name = "grammerButton";
            this.grammerButton.Size = new System.Drawing.Size(86, 38);
            this.grammerButton.TabIndex = 9;
            this.grammerButton.Text = "Grammer";
            this.grammerButton.UseVisualStyleBackColor = true;
            // 
            // vocabularyButton
            // 
            this.vocabularyButton.Location = new System.Drawing.Point(119, 71);
            this.vocabularyButton.Name = "vocabularyButton";
            this.vocabularyButton.Size = new System.Drawing.Size(86, 38);
            this.vocabularyButton.TabIndex = 10;
            this.vocabularyButton.Text = "Vocabulary";
            this.vocabularyButton.UseVisualStyleBackColor = true;
            // 
            // matchButton
            // 
            this.matchButton.Location = new System.Drawing.Point(222, 71);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(86, 38);
            this.matchButton.TabIndex = 11;
            this.matchButton.Text = "Matching";
            this.matchButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 274);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.vocabButton);
            this.Controls.Add(this.applaButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button applaButton;
        private System.Windows.Forms.Button vocabButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vocabularyButton;
        private System.Windows.Forms.Button grammerButton;
        private System.Windows.Forms.Button matchButton;
    }
}