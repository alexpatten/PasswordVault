namespace PasswordVault
{
    partial class CredentialsForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.setupBtn = new System.Windows.Forms.Button();
            this.credLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(88, 111);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(90, 41);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // setupBtn
            // 
            this.setupBtn.Location = new System.Drawing.Point(184, 111);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(90, 41);
            this.setupBtn.TabIndex = 1;
            this.setupBtn.Text = "Setup";
            this.setupBtn.UseVisualStyleBackColor = true;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // credLabel
            // 
            this.credLabel.AutoSize = true;
            this.credLabel.Location = new System.Drawing.Point(37, 21);
            this.credLabel.Name = "credLabel";
            this.credLabel.Size = new System.Drawing.Size(284, 13);
            this.credLabel.TabIndex = 2;
            this.credLabel.Text = "Please login or setup credentials to access this application.";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(13, 52);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(56, 13);
            this.pwLabel.TabIndex = 3;
            this.pwLabel.Text = "Password:";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(28, 85);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(75, 49);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(250, 20);
            this.pwTextBox.TabIndex = 5;
            this.pwTextBox.UseSystemPasswordChar = true;
            // 
            // CredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 164);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.credLabel);
            this.Controls.Add(this.setupBtn);
            this.Controls.Add(this.loginBtn);
            this.Name = "CredentialsForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button setupBtn;
        private System.Windows.Forms.Label credLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox pwTextBox;
    }
}