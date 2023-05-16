namespace LinguaLearn
{
    partial class aboutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.duoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.babLinkLabel = new System.Windows.Forms.LinkLabel();
            this.memLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.legoPictureBox = new System.Windows.Forms.PictureBox();
            this.resoursePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.legoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoursePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // duoLinkLabel
            // 
            this.duoLinkLabel.AutoSize = true;
            this.duoLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duoLinkLabel.Location = new System.Drawing.Point(12, 177);
            this.duoLinkLabel.Name = "duoLinkLabel";
            this.duoLinkLabel.Size = new System.Drawing.Size(157, 16);
            this.duoLinkLabel.TabIndex = 0;
            this.duoLinkLabel.TabStop = true;
            this.duoLinkLabel.Text = "https://www.duolingo.com";
            this.duoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.duoLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Additional documents\r\nLanguage Learning Resources:\r\n";
            // 
            // babLinkLabel
            // 
            this.babLinkLabel.AutoSize = true;
            this.babLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babLinkLabel.Location = new System.Drawing.Point(12, 208);
            this.babLinkLabel.Name = "babLinkLabel";
            this.babLinkLabel.Size = new System.Drawing.Size(148, 16);
            this.babLinkLabel.TabIndex = 2;
            this.babLinkLabel.TabStop = true;
            this.babLinkLabel.Text = "https://www.babbel.com";
            this.babLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.babLinkLabel_LinkClicked);
            // 
            // memLinkLabel
            // 
            this.memLinkLabel.AutoSize = true;
            this.memLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memLinkLabel.Location = new System.Drawing.Point(12, 242);
            this.memLinkLabel.Name = "memLinkLabel";
            this.memLinkLabel.Size = new System.Drawing.Size(157, 16);
            this.memLinkLabel.TabIndex = 3;
            this.memLinkLabel.TabStop = true;
            this.memLinkLabel.Text = "https://www.memrise.com";
            this.memLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.memLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "About the Application:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Made by Nabil Ramadan,\r\n Simon Ménard, Brandon Pannunzio";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.png");
            // 
            // legoPictureBox
            // 
            this.legoPictureBox.Image = global::LinguaLearn.Properties.Resources.aboutLogo;
            this.legoPictureBox.InitialImage = global::LinguaLearn.Properties.Resources.aboutLogo;
            this.legoPictureBox.Location = new System.Drawing.Point(15, 12);
            this.legoPictureBox.Name = "legoPictureBox";
            this.legoPictureBox.Size = new System.Drawing.Size(128, 100);
            this.legoPictureBox.TabIndex = 6;
            this.legoPictureBox.TabStop = false;
            // 
            // resoursePictureBox
            // 
            this.resoursePictureBox.InitialImage = null;
            this.resoursePictureBox.Location = new System.Drawing.Point(222, 168);
            this.resoursePictureBox.Name = "resoursePictureBox";
            this.resoursePictureBox.Size = new System.Drawing.Size(125, 90);
            this.resoursePictureBox.TabIndex = 7;
            this.resoursePictureBox.TabStop = false;
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 283);
            this.Controls.Add(this.resoursePictureBox);
            this.Controls.Add(this.legoPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memLinkLabel);
            this.Controls.Add(this.babLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duoLinkLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutForm";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.legoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoursePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel duoLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel babLinkLabel;
        private System.Windows.Forms.LinkLabel memLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox legoPictureBox;
        private System.Windows.Forms.PictureBox resoursePictureBox;
    }
}