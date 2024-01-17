namespace SMManagement.Forms
{
    partial class directLoginForm
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
            this.btn_userLogin = new System.Windows.Forms.Button();
            this.btn_adminLogin = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_userLogin
            // 
            this.btn_userLogin.Location = new System.Drawing.Point(193, 135);
            this.btn_userLogin.Name = "btn_userLogin";
            this.btn_userLogin.Size = new System.Drawing.Size(116, 51);
            this.btn_userLogin.TabIndex = 0;
            this.btn_userLogin.Text = "Kullanıcı Girişi";
            this.btn_userLogin.UseVisualStyleBackColor = true;
            this.btn_userLogin.Click += new System.EventHandler(this.btn_userLogin_Click);
            // 
            // btn_adminLogin
            // 
            this.btn_adminLogin.Location = new System.Drawing.Point(328, 135);
            this.btn_adminLogin.Name = "btn_adminLogin";
            this.btn_adminLogin.Size = new System.Drawing.Size(116, 51);
            this.btn_adminLogin.TabIndex = 1;
            this.btn_adminLogin.Text = "Yönetici Girişi";
            this.btn_adminLogin.UseVisualStyleBackColor = true;
            this.btn_adminLogin.Click += new System.EventHandler(this.btn_adminLogin_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerLbl.Location = new System.Drawing.Point(109, 62);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(430, 36);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "Süpermarket Yönetim Sistemi";
            // 
            // directLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 257);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.btn_adminLogin);
            this.Controls.Add(this.btn_userLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "directLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direct Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_userLogin;
        private System.Windows.Forms.Button btn_adminLogin;
        private System.Windows.Forms.Label headerLbl;
    }
}