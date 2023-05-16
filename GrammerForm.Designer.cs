namespace LinguaLearn
{
    partial class GrammerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrammerForm));
            this.thereButton = new System.Windows.Forms.RadioButton();
            this.theirButton = new System.Windows.Forms.RadioButton();
            this.theyreButton = new System.Windows.Forms.RadioButton();
            this.qLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thereButton
            // 
            this.thereButton.AutoSize = true;
            this.thereButton.Location = new System.Drawing.Point(200, 35);
            this.thereButton.Name = "thereButton";
            this.thereButton.Size = new System.Drawing.Size(49, 17);
            this.thereButton.TabIndex = 2;
            this.thereButton.TabStop = true;
            this.thereButton.Text = "there";
            this.thereButton.UseVisualStyleBackColor = true;
            this.thereButton.CheckedChanged += new System.EventHandler(this.Button_CheckedChanged);
            // 
            // theirButton
            // 
            this.theirButton.AutoSize = true;
            this.theirButton.Location = new System.Drawing.Point(200, 58);
            this.theirButton.Name = "theirButton";
            this.theirButton.Size = new System.Drawing.Size(45, 17);
            this.theirButton.TabIndex = 3;
            this.theirButton.TabStop = true;
            this.theirButton.Text = "their";
            this.theirButton.UseVisualStyleBackColor = true;
            this.theirButton.CheckedChanged += new System.EventHandler(this.Button_CheckedChanged);
            // 
            // theyreButton
            // 
            this.theyreButton.AutoSize = true;
            this.theyreButton.Location = new System.Drawing.Point(200, 81);
            this.theyreButton.Name = "theyreButton";
            this.theyreButton.Size = new System.Drawing.Size(56, 17);
            this.theyreButton.TabIndex = 4;
            this.theyreButton.TabStop = true;
            this.theyreButton.Text = "they\'re";
            this.theyreButton.UseVisualStyleBackColor = true;
            this.theyreButton.CheckedChanged += new System.EventHandler(this.Button_CheckedChanged);
            // 
            // qLabel
            // 
            this.qLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.qLabel.Location = new System.Drawing.Point(0, 9);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(444, 23);
            this.qLabel.TabIndex = 5;
            this.qLabel.Text = "label1";
            this.qLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.qLabel.Click += new System.EventHandler(this.qLabel_Click);
            // 
            // GrammerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 116);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.theyreButton);
            this.Controls.Add(this.theirButton);
            this.Controls.Add(this.thereButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrammerForm";
            this.Text = "Grammar Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GrammerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton thereButton;
        private System.Windows.Forms.RadioButton theirButton;
        private System.Windows.Forms.RadioButton theyreButton;
        private System.Windows.Forms.Label qLabel;
    }
}