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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // getUname_txtbox
            // 
            resources.ApplyResources(this.getUname_txtbox, "getUname_txtbox");
            this.getUname_txtbox.Name = "getUname_txtbox";
            // 
            // get_btn
            // 
            resources.ApplyResources(this.get_btn, "get_btn");
            this.get_btn.Name = "get_btn";
            this.get_btn.UseVisualStyleBackColor = true;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // goRegister
            // 
            resources.ApplyResources(this.goRegister, "goRegister");
            this.goRegister.Name = "goRegister";
            this.goRegister.TabStop = true;
            this.goRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goRegister_LinkClicked);
            // 
            // getPword_txtbox
            // 
            resources.ApplyResources(this.getPword_txtbox, "getPword_txtbox");
            this.getPword_txtbox.Name = "getPword_txtbox";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.getPword_txtbox);
            this.Controls.Add(this.goRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getUname_txtbox);
            this.Controls.Add(this.get_btn);
            this.Name = "LoginForm";
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}