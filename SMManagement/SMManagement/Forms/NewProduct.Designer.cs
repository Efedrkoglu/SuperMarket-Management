namespace SMManagement.Forms
{
    partial class NewProduct
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
            this.cb_priceType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // cb_priceType
            // 
            this.cb_priceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_priceType.FormattingEnabled = true;
            this.cb_priceType.Location = new System.Drawing.Point(384, 90);
            this.cb_priceType.Name = "cb_priceType";
            this.cb_priceType.Size = new System.Drawing.Size(171, 28);
            this.cb_priceType.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(719, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chb_stok
            // 
            this.chb_stok.AutoSize = true;
            this.chb_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_stok.Location = new System.Drawing.Point(592, 172);
            this.chb_stok.Name = "chb_stok";
            this.chb_stok.Size = new System.Drawing.Size(68, 26);
            this.chb_stok.TabIndex = 36;
            this.chb_stok.Text = "Stok";
            this.chb_stok.UseVisualStyleBackColor = true;
            // 
            // tb_supplier
            // 
            this.tb_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplier.Location = new System.Drawing.Point(666, 126);
            this.tb_supplier.Name = "tb_supplier";
            this.tb_supplier.Size = new System.Drawing.Size(171, 27);
            this.tb_supplier.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(562, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tedarikçi ID:";
            // 
            // tb_category
            // 
            this.tb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_category.Location = new System.Drawing.Point(666, 90);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(171, 27);
            this.tb_category.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(562, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Kategori ID:";
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_price.Location = new System.Drawing.Point(385, 127);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(171, 27);
            this.tb_price.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(328, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(296, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fiyat Tipi:";
            // 
            // tb_productName
            // 
            this.tb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_productName.Location = new System.Drawing.Point(119, 123);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(171, 27);
            this.tb_productName.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ürün İsmi:";
            // 
            // tb_productID
            // 
            this.tb_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_productID.Location = new System.Drawing.Point(119, 90);
            this.tb_productID.Name = "tb_productID";
            this.tb_productID.Size = new System.Drawing.Size(171, 27);
            this.tb_productID.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ürün ID:";
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 290);
            this.Controls.Add(this.cb_priceType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chb_stok);
            this.Controls.Add(this.tb_supplier);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_category);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_productID);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewProduct_FormClosing);
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_priceType;
        private System.Windows.Forms.Button button1;
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
    }
}