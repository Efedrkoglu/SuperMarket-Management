namespace SMManagement.Forms
{
    partial class ProductsUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.btn_searchSID = new System.Windows.Forms.Button();
            this.tb_supplierIDS = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_searchPID = new System.Windows.Forms.Button();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_productNameS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_productIDS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_searchSID);
            this.panel1.Controls.Add(this.tb_supplierIDS);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_searchPID);
            this.panel1.Controls.Add(this.cb_categories);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_productNameS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_productIDS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 205);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 522);
            this.panel2.TabIndex = 1;
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw.Location = new System.Drawing.Point(0, 0);
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(1090, 522);
            this.dgw.TabIndex = 0;
            // 
            // btn_searchSID
            // 
            this.btn_searchSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_searchSID.Location = new System.Drawing.Point(708, 58);
            this.btn_searchSID.Name = "btn_searchSID";
            this.btn_searchSID.Size = new System.Drawing.Size(90, 31);
            this.btn_searchSID.TabIndex = 42;
            this.btn_searchSID.Text = "Ara";
            this.btn_searchSID.UseVisualStyleBackColor = true;
            this.btn_searchSID.Click += new System.EventHandler(this.btn_searchSID_Click);
            // 
            // tb_supplierIDS
            // 
            this.tb_supplierIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierIDS.Location = new System.Drawing.Point(509, 60);
            this.tb_supplierIDS.Name = "tb_supplierIDS";
            this.tb_supplierIDS.Size = new System.Drawing.Size(193, 27);
            this.tb_supplierIDS.TabIndex = 41;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_refresh.Location = new System.Drawing.Point(896, 44);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(153, 45);
            this.btn_refresh.TabIndex = 40;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_searchPID
            // 
            this.btn_searchPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_searchPID.Location = new System.Drawing.Point(307, 58);
            this.btn_searchPID.Name = "btn_searchPID";
            this.btn_searchPID.Size = new System.Drawing.Size(90, 31);
            this.btn_searchPID.TabIndex = 39;
            this.btn_searchPID.Text = "Ara";
            this.btn_searchPID.UseVisualStyleBackColor = true;
            this.btn_searchPID.Click += new System.EventHandler(this.btn_searchPID_Click);
            // 
            // cb_categories
            // 
            this.cb_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(592, 104);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(206, 28);
            this.cb_categories.TabIndex = 38;
            this.cb_categories.SelectedIndexChanged += new System.EventHandler(this.cb_categories_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(403, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tedarikçi ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(510, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kategori:";
            // 
            // tb_productNameS
            // 
            this.tb_productNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_productNameS.Location = new System.Drawing.Point(108, 105);
            this.tb_productNameS.Name = "tb_productNameS";
            this.tb_productNameS.Size = new System.Drawing.Size(385, 27);
            this.tb_productNameS.TabIndex = 35;
            this.tb_productNameS.TextChanged += new System.EventHandler(this.tb_productNameS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ürün İsmi:";
            // 
            // tb_productIDS
            // 
            this.tb_productIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_productIDS.Location = new System.Drawing.Point(108, 60);
            this.tb_productIDS.Name = "tb_productIDS";
            this.tb_productIDS.Size = new System.Drawing.Size(193, 27);
            this.tb_productIDS.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ürün ID:";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.Location = new System.Drawing.Point(896, 95);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(153, 45);
            this.btn_exit.TabIndex = 43;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ProductsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductsUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.ProductsUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_searchSID;
        private System.Windows.Forms.TextBox tb_supplierIDS;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_searchPID;
        private System.Windows.Forms.ComboBox cb_categories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_productNameS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_productIDS;
        private System.Windows.Forms.Label label1;
    }
}