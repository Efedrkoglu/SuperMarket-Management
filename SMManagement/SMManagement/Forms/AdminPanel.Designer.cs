namespace SMManagement.Forms
{
    partial class AdminPanel
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_categories = new System.Windows.Forms.Button();
            this.btn_suppliers = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(69, 66);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(122, 45);
            this.btn_products.TabIndex = 0;
            this.btn_products.Text = "Ürünler";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(197, 212);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(122, 45);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_categories
            // 
            this.btn_categories.Location = new System.Drawing.Point(197, 66);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Size = new System.Drawing.Size(122, 45);
            this.btn_categories.TabIndex = 2;
            this.btn_categories.Text = "Kategoriler";
            this.btn_categories.UseVisualStyleBackColor = true;
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // btn_suppliers
            // 
            this.btn_suppliers.Location = new System.Drawing.Point(325, 66);
            this.btn_suppliers.Name = "btn_suppliers";
            this.btn_suppliers.Size = new System.Drawing.Size(122, 45);
            this.btn_suppliers.TabIndex = 3;
            this.btn_suppliers.Text = "Tedarikçiler";
            this.btn_suppliers.UseVisualStyleBackColor = true;
            this.btn_suppliers.Click += new System.EventHandler(this.btn_suppliers_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.Location = new System.Drawing.Point(69, 117);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(122, 45);
            this.btn_employees.TabIndex = 4;
            this.btn_employees.Text = "Çalışanlar";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(197, 117);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(122, 45);
            this.btn_customers.TabIndex = 5;
            this.btn_customers.Text = "Müşteriler";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(325, 117);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(122, 45);
            this.btn_sales.TabIndex = 6;
            this.btn_sales.Text = "Satışlar";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 336);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.btn_suppliers);
            this.Controls.Add(this.btn_categories);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Süpermarket Yönetim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_categories;
        private System.Windows.Forms.Button btn_suppliers;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_sales;
    }
}