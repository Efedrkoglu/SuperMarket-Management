namespace SMManagement.Forms
{
    partial class SalesForm
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
            this.salesAvgLbl = new System.Windows.Forms.Label();
            this.salesTotalLbl = new System.Windows.Forms.Label();
            this.salesCountLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statisticsHeaderLbl = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_searchCustomerID = new System.Windows.Forms.Button();
            this.btn_searchSaleID = new System.Windows.Forms.Button();
            this.tb_customerIDS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_saleIDS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_searchDate = new System.Windows.Forms.Button();
            this.btn_searchYorM = new System.Windows.Forms.Button();
            this.cb_MonthsSearch = new System.Windows.Forms.ComboBox();
            this.dtp_dateSearch = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_YearSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgw_saleDetails = new System.Windows.Forms.DataGridView();
            this.dgw_sales = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_saleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.salesAvgLbl);
            this.panel1.Controls.Add(this.salesTotalLbl);
            this.panel1.Controls.Add(this.salesCountLbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.statisticsHeaderLbl);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_searchCustomerID);
            this.panel1.Controls.Add(this.btn_searchSaleID);
            this.panel1.Controls.Add(this.tb_customerIDS);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_saleIDS);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_searchDate);
            this.panel1.Controls.Add(this.btn_searchYorM);
            this.panel1.Controls.Add(this.cb_MonthsSearch);
            this.panel1.Controls.Add(this.dtp_dateSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_YearSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 327);
            this.panel1.TabIndex = 0;
            // 
            // salesAvgLbl
            // 
            this.salesAvgLbl.AutoSize = true;
            this.salesAvgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salesAvgLbl.Location = new System.Drawing.Point(849, 141);
            this.salesAvgLbl.Name = "salesAvgLbl";
            this.salesAvgLbl.Size = new System.Drawing.Size(43, 20);
            this.salesAvgLbl.TabIndex = 23;
            this.salesAvgLbl.Text = "0 TL";
            // 
            // salesTotalLbl
            // 
            this.salesTotalLbl.AutoSize = true;
            this.salesTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salesTotalLbl.Location = new System.Drawing.Point(878, 109);
            this.salesTotalLbl.Name = "salesTotalLbl";
            this.salesTotalLbl.Size = new System.Drawing.Size(43, 20);
            this.salesTotalLbl.TabIndex = 22;
            this.salesTotalLbl.Text = "0 TL";
            // 
            // salesCountLbl
            // 
            this.salesCountLbl.AutoSize = true;
            this.salesCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salesCountLbl.Location = new System.Drawing.Point(868, 79);
            this.salesCountLbl.Name = "salesCountLbl";
            this.salesCountLbl.Size = new System.Drawing.Size(18, 20);
            this.salesCountLbl.TabIndex = 21;
            this.salesCountLbl.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(760, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ortalama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(760, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Toplam Satış:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(760, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Satış Sayısı:";
            // 
            // statisticsHeaderLbl
            // 
            this.statisticsHeaderLbl.AutoSize = true;
            this.statisticsHeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statisticsHeaderLbl.Location = new System.Drawing.Point(760, 43);
            this.statisticsHeaderLbl.Name = "statisticsHeaderLbl";
            this.statisticsHeaderLbl.Size = new System.Drawing.Size(126, 20);
            this.statisticsHeaderLbl.TabIndex = 16;
            this.statisticsHeaderLbl.Text = "2024 Tüm Aylar";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(764, 242);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 40);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_searchCustomerID
            // 
            this.btn_searchCustomerID.Location = new System.Drawing.Point(607, 254);
            this.btn_searchCustomerID.Name = "btn_searchCustomerID";
            this.btn_searchCustomerID.Size = new System.Drawing.Size(80, 30);
            this.btn_searchCustomerID.TabIndex = 14;
            this.btn_searchCustomerID.Text = "Ara";
            this.btn_searchCustomerID.UseVisualStyleBackColor = true;
            this.btn_searchCustomerID.Click += new System.EventHandler(this.btn_searchCustomerID_Click);
            // 
            // btn_searchSaleID
            // 
            this.btn_searchSaleID.Location = new System.Drawing.Point(607, 221);
            this.btn_searchSaleID.Name = "btn_searchSaleID";
            this.btn_searchSaleID.Size = new System.Drawing.Size(80, 30);
            this.btn_searchSaleID.TabIndex = 13;
            this.btn_searchSaleID.Text = "Ara";
            this.btn_searchSaleID.UseVisualStyleBackColor = true;
            this.btn_searchSaleID.Click += new System.EventHandler(this.btn_searchSaleID_Click);
            // 
            // tb_customerIDS
            // 
            this.tb_customerIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerIDS.Location = new System.Drawing.Point(415, 255);
            this.tb_customerIDS.Name = "tb_customerIDS";
            this.tb_customerIDS.Size = new System.Drawing.Size(186, 27);
            this.tb_customerIDS.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(317, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Müşteri ID:";
            // 
            // tb_saleIDS
            // 
            this.tb_saleIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_saleIDS.Location = new System.Drawing.Point(415, 222);
            this.tb_saleIDS.Name = "tb_saleIDS";
            this.tb_saleIDS.Size = new System.Drawing.Size(186, 27);
            this.tb_saleIDS.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(335, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Satış ID:";
            // 
            // btn_searchDate
            // 
            this.btn_searchDate.Location = new System.Drawing.Point(588, 134);
            this.btn_searchDate.Name = "btn_searchDate";
            this.btn_searchDate.Size = new System.Drawing.Size(80, 30);
            this.btn_searchDate.TabIndex = 8;
            this.btn_searchDate.Text = "Ara";
            this.btn_searchDate.UseVisualStyleBackColor = true;
            this.btn_searchDate.Click += new System.EventHandler(this.btn_searchDate_Click);
            // 
            // btn_searchYorM
            // 
            this.btn_searchYorM.Location = new System.Drawing.Point(588, 86);
            this.btn_searchYorM.Name = "btn_searchYorM";
            this.btn_searchYorM.Size = new System.Drawing.Size(80, 30);
            this.btn_searchYorM.TabIndex = 7;
            this.btn_searchYorM.Text = "Ara";
            this.btn_searchYorM.UseVisualStyleBackColor = true;
            this.btn_searchYorM.Click += new System.EventHandler(this.btn_searchYorM_Click);
            // 
            // cb_MonthsSearch
            // 
            this.cb_MonthsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_MonthsSearch.FormattingEnabled = true;
            this.cb_MonthsSearch.Items.AddRange(new object[] {
            "Tüm Aylar",
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cb_MonthsSearch.Location = new System.Drawing.Point(415, 87);
            this.cb_MonthsSearch.Name = "cb_MonthsSearch";
            this.cb_MonthsSearch.Size = new System.Drawing.Size(167, 28);
            this.cb_MonthsSearch.TabIndex = 6;
            // 
            // dtp_dateSearch
            // 
            this.dtp_dateSearch.CustomFormat = "yyyy-MM-dd";
            this.dtp_dateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_dateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateSearch.Location = new System.Drawing.Point(415, 134);
            this.dtp_dateSearch.Name = "dtp_dateSearch";
            this.dtp_dateSearch.Size = new System.Drawing.Size(167, 27);
            this.dtp_dateSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(357, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(357, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay:";
            // 
            // dtp_YearSearch
            // 
            this.dtp_YearSearch.CustomFormat = "yyyy";
            this.dtp_YearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_YearSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_YearSearch.Location = new System.Drawing.Point(415, 43);
            this.dtp_YearSearch.Name = "dtp_YearSearch";
            this.dtp_YearSearch.Size = new System.Drawing.Size(167, 27);
            this.dtp_YearSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(357, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yıl:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgw_saleDetails);
            this.panel2.Controls.Add(this.dgw_sales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 407);
            this.panel2.TabIndex = 1;
            // 
            // dgw_saleDetails
            // 
            this.dgw_saleDetails.AllowUserToAddRows = false;
            this.dgw_saleDetails.AllowUserToDeleteRows = false;
            this.dgw_saleDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_saleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_saleDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgw_saleDetails.Location = new System.Drawing.Point(560, 0);
            this.dgw_saleDetails.Name = "dgw_saleDetails";
            this.dgw_saleDetails.ReadOnly = true;
            this.dgw_saleDetails.RowHeadersWidth = 51;
            this.dgw_saleDetails.RowTemplate.Height = 24;
            this.dgw_saleDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_saleDetails.Size = new System.Drawing.Size(779, 407);
            this.dgw_saleDetails.TabIndex = 1;
            // 
            // dgw_sales
            // 
            this.dgw_sales.AllowUserToAddRows = false;
            this.dgw_sales.AllowUserToDeleteRows = false;
            this.dgw_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_sales.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgw_sales.Location = new System.Drawing.Point(0, 0);
            this.dgw_sales.Name = "dgw_sales";
            this.dgw_sales.ReadOnly = true;
            this.dgw_sales.RowHeadersWidth = 51;
            this.dgw_sales.RowTemplate.Height = 24;
            this.dgw_sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_sales.Size = new System.Drawing.Size(554, 407);
            this.dgw_sales.TabIndex = 0;
            this.dgw_sales.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_sales_CellEnter);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(881, 242);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 40);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_saleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgw_saleDetails;
        private System.Windows.Forms.DataGridView dgw_sales;
        private System.Windows.Forms.DateTimePicker dtp_dateSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_YearSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_searchCustomerID;
        private System.Windows.Forms.Button btn_searchSaleID;
        private System.Windows.Forms.TextBox tb_customerIDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_saleIDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_searchDate;
        private System.Windows.Forms.Button btn_searchYorM;
        private System.Windows.Forms.ComboBox cb_MonthsSearch;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statisticsHeaderLbl;
        private System.Windows.Forms.Label salesAvgLbl;
        private System.Windows.Forms.Label salesTotalLbl;
        private System.Windows.Forms.Label salesCountLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_exit;
    }
}