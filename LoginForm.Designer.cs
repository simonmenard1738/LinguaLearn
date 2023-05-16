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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label4 = new System.Windows.Forms.Label();
            this.getUname_txtbox = new System.Windows.Forms.TextBox();
            this.get_btn = new System.Windows.Forms.Button();
            this.goRegister = new System.Windows.Forms.LinkLabel();
            this.getPword_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Log In";
            // 
            // getUname_txtbox
            // 
            this.getUname_txtbox.Location = new System.Drawing.Point(40, 57);
            this.getUname_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.getUname_txtbox.Name = "getUname_txtbox";
            this.getUname_txtbox.Size = new System.Drawing.Size(141, 20);
            this.getUname_txtbox.TabIndex = 18;
            // 
            // get_btn
            // 
            this.get_btn.Location = new System.Drawing.Point(68, 114);
            this.get_btn.Margin = new System.Windows.Forms.Padding(2);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(84, 35);
            this.get_btn.TabIndex = 17;
            this.get_btn.Text = "Log In";
            this.get_btn.UseVisualStyleBackColor = true;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // goRegister
            // 
            this.goRegister.AutoSize = true;
            this.goRegister.Location = new System.Drawing.Point(43, 168);
            this.goRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goRegister.Name = "goRegister";
            this.goRegister.Size = new System.Drawing.Size(141, 13);
            this.goRegister.TabIndex = 20;
            this.goRegister.TabStop = true;
            this.goRegister.Text = "Want to register? Click here.";
            this.goRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goRegister_LinkClicked);
            // 
            // getPword_txtbox
            // 
            this.getPword_txtbox.Location = new System.Drawing.Point(40, 80);
            this.getPword_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.getPword_txtbox.Name = "getPword_txtbox";
            this.getPword_txtbox.Size = new System.Drawing.Size(141, 20);
            this.getPword_txtbox.TabIndex = 21;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 212);
            this.Controls.Add(this.getPword_txtbox);
            this.Controls.Add(this.goRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getUname_txtbox);
            this.Controls.Add(this.get_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Login Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
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