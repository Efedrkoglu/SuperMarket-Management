namespace SMManagement.Forms
{
    partial class Products
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_searchSID = new System.Windows.Forms.Button();
            this.tb_supplierIDS = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_searchPID = new System.Windows.Forms.Button();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.cb_priceType = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_newProduct = new System.Windows.Forms.Button();
            this.chb_stok = new System.Windows.Forms.CheckBox();
            this.tb_supplier = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_productID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_productNameS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_productIDS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_searchSID);
            this.panel1.Controls.Add(this.tb_supplierIDS);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_searchPID);
            this.panel1.Controls.Add(this.cb_categories);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.cb_priceType);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_newProduct);
            this.panel1.Controls.Add(this.chb_stok);
            this.panel1.Controls.Add(this.tb_supplier);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_category);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_productName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_productID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_productNameS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_productIDS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 257);
            this.panel1.TabIndex = 0;
            // 
            // btn_searchSID
            // 
            this.btn_searchSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_searchSID.Location = new System.Drawing.Point(693, 188);
            this.btn_searchSID.Name = "btn_searchSID";
            this.btn_searchSID.Size = new System.Drawing.Size(90, 31);
            this.btn_searchSID.TabIndex = 31;
            this.btn_searchSID.Text = "Ara";
            this.btn_searchSID.UseVisualStyleBackColor = true;
            this.btn_searchSID.Click += new System.EventHandler(this.btn_searchSID_Click);
            // 
            // tb_supplierIDS
            // 
            this.tb_supplierIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierIDS.Location = new System.Drawing.Point(494, 190);
            this.tb_supplierIDS.Name = "tb_supplierIDS";
            this.tb_supplierIDS.Size = new System.Drawing.Size(193, 27);
            this.tb_supplierIDS.TabIndex = 30;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_refresh.Location = new System.Drawing.Point(880, 193);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(153, 45);
            this.btn_refresh.TabIndex = 29;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_searchPID
            // 
            this.btn_searchPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_searchPID.Location = new System.Drawing.Point(292, 188);
            this.btn_searchPID.Name = "btn_searchPID";
            this.btn_searchPID.Size = new System.Drawing.Size(90, 31);
            this.btn_searchPID.TabIndex = 28;
            this.btn_searchPID.Text = "Ara";
            this.btn_searchPID.UseVisualStyleBackColor = true;
            this.btn_searchPID.Click += new System.EventHandler(this.btn_searchPID_Click);
            // 
            // cb_categories
            // 
            this.cb_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(577, 222);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(206, 28);
            this.cb_categories.TabIndex = 26;
            this.cb_categories.SelectedIndexChanged += new System.EventHandler(this.cb_categories_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(693, 111);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 31);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cb_priceType
            // 
            this.cb_priceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_priceType.FormattingEnabled = true;
            this.cb_priceType.Location = new System.Drawing.Point(358, 38);
            this.cb_priceType.Name = "cb_priceType";
            this.cb_priceType.Size = new System.Drawing.Size(171, 28);
            this.cb_priceType.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(880, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 45);
            this.button3.TabIndex = 23;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_newProduct
            // 
            this.btn_newProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_newProduct.Location = new System.Drawing.Point(880, 38);
            this.btn_newProduct.Name = "btn_newProduct";
            this.btn_newProduct.Size = new System.Drawing.Size(153, 45);
            this.btn_newProduct.TabIndex = 22;
            this.btn_newProduct.Text = "Yeni Ürün Ekle";
            this.btn_newProduct.UseVisualStyleBackColor = true;
            this.btn_newProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // chb_stok
            // 
            this.chb_stok.AutoSize = true;
            this.chb_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_stok.Location = new System.Drawing.Point(566, 116);
            this.chb_stok.Name = "chb_stok";
            this.chb_stok.Size = new System.Drawing.Size(68, 26);
            this.chb_stok.TabIndex = 20;
            this.chb_stok.Text = "Stok";
            this.chb_stok.UseVisualStyleBackColor = true;
            // 
            // tb_supplier
            // 
            this.tb_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier.Location = new System.Drawing.Point(640, 75);
            this.tb_supplier.Name = "tb_supplier";
            this.tb_supplier.Size = new System.Drawing.Size(171, 27);
            this.tb_supplier.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(536, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tedarikçi ID:";
            // 
            // tb_category
            // 
            this.tb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_category.Location = new System.Drawing.Point(640, 38);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(171, 27);
            this.tb_category.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(536, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kategori ID:";
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_price.Location = new System.Drawing.Point(359, 75);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(171, 27);
            this.tb_price.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(302, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(270, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fiyat Tipi:";
            // 
            // tb_productName
            // 
            this.tb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_productName.Location = new System.Drawing.Point(93, 71);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(171, 27);
            this.tb_productName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ürün İsmi:";
            // 
            // tb_productID
            // 
            this.tb_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_productID.Location = new System.Drawing.Point(93, 38);
            this.tb_productID.Name = "tb_productID";
            this.tb_productID.ReadOnly = true;
            this.tb_productID.Size = new System.Drawing.Size(171, 27);
            this.tb_productID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(388, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tedarikçi ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(495, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori:";
            // 
            // tb_productNameS
            // 
            this.tb_productNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_productNameS.Location = new System.Drawing.Point(93, 223);
            this.tb_productNameS.Name = "tb_productNameS";
            this.tb_productNameS.Size = new System.Drawing.Size(385, 27);
            this.tb_productNameS.TabIndex = 3;
            this.tb_productNameS.TextChanged += new System.EventHandler(this.tb_productNameS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün İsmi:";
            // 
            // tb_productIDS
            // 
            this.tb_productIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_productIDS.Location = new System.Drawing.Point(93, 190);
            this.tb_productIDS.Name = "tb_productIDS";
            this.tb_productIDS.Size = new System.Drawing.Size(193, 27);
            this.tb_productIDS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 470);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 470);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_productNameS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_productIDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chb_stok;
        private System.Windows.Forms.TextBox tb_supplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_productID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btn_newProduct;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_priceType;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cb_categories;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_searchPID;
        private System.Windows.Forms.Button btn_searchSID;
        private System.Windows.Forms.TextBox tb_supplierIDS;
    }
}