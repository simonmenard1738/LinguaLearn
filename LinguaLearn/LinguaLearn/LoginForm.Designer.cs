namespace LinguaLearn
{
    partial class LoginForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.getUname_txtbox = new System.Windows.Forms.TextBox();
            this.get_btn = new System.Windows.Forms.Button();
            this.goRegister = new System.Windows.Forms.LinkLabel();
            this.getPword_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Log In";
            // 
            // getUname_txtbox
            // 
            this.getUname_txtbox.Location = new System.Drawing.Point(53, 70);
            this.getUname_txtbox.Name = "getUname_txtbox";
            this.getUname_txtbox.Size = new System.Drawing.Size(187, 22);
            this.getUname_txtbox.TabIndex = 18;
            // 
            // get_btn
            // 
            this.get_btn.Location = new System.Drawing.Point(91, 140);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(112, 43);
            this.get_btn.TabIndex = 17;
            this.get_btn.Text = "Log In";
            this.get_btn.UseVisualStyleBackColor = true;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // goRegister
            // 
            this.goRegister.AutoSize = true;
            this.goRegister.Location = new System.Drawing.Point(68, 210);
            this.goRegister.Name = "goRegister";
            this.goRegister.Size = new System.Drawing.Size(172, 16);
            this.goRegister.TabIndex = 20;
            this.goRegister.TabStop = true;
            this.goRegister.Text = "Want to register? Click here.";
            this.goRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goRegister_LinkClicked);
            // 
            // getPword_txtbox
            // 
            this.getPword_txtbox.Location = new System.Drawing.Point(53, 98);
            this.getPword_txtbox.Name = "getPword_txtbox";
            this.getPword_txtbox.Size = new System.Drawing.Size(187, 22);
            this.getPword_txtbox.TabIndex = 21;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 398);
            this.Controls.Add(this.getPword_txtbox);
            this.Controls.Add(this.goRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getUname_txtbox);
            this.Controls.Add(this.get_btn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox getUname_txtbox;
        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.LinkLabel goRegister;
        private System.Windows.Forms.TextBox getPword_txtbox;
    }
}