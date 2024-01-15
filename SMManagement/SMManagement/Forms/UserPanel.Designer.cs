namespace SMManagement.Forms
{
    partial class UserPanel
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
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(68, 83);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(122, 45);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = "Ürünler";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(196, 83);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(122, 45);
            this.btn_customers.TabIndex = 2;
            this.btn_customers.Text = "Müşteriler";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.Location = new System.Drawing.Point(324, 83);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(122, 45);
            this.btn_sell.TabIndex = 3;
            this.btn_sell.Text = "Sat";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(196, 196);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(122, 45);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 336);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Button btn_exit;
    }
}