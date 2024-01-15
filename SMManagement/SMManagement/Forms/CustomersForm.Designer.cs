namespace SMManagement.Forms
{
    partial class CustomersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_customerID = new System.Windows.Forms.TextBox();
            this.tb_customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_customerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_customerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_customerSID = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_newCustomer = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tb_customerSurnameS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_customerNameS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_customerIDS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tb_customerID
            // 
            this.tb_customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerID.Location = new System.Drawing.Point(177, 35);
            this.tb_customerID.Name = "tb_customerID";
            this.tb_customerID.ReadOnly = true;
            this.tb_customerID.Size = new System.Drawing.Size(172, 27);
            this.tb_customerID.TabIndex = 1;
            // 
            // tb_customerName
            // 
            this.tb_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerName.Location = new System.Drawing.Point(177, 68);
            this.tb_customerName.Name = "tb_customerName";
            this.tb_customerName.Size = new System.Drawing.Size(172, 27);
            this.tb_customerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // tb_customerSurname
            // 
            this.tb_customerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerSurname.Location = new System.Drawing.Point(177, 101);
            this.tb_customerSurname.Name = "tb_customerSurname";
            this.tb_customerSurname.Size = new System.Drawing.Size(172, 27);
            this.tb_customerSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(111, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // tb_customerPhone
            // 
            this.tb_customerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerPhone.Location = new System.Drawing.Point(177, 134);
            this.tb_customerPhone.Name = "tb_customerPhone";
            this.tb_customerPhone.Size = new System.Drawing.Size(172, 27);
            this.tb_customerPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(140, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(262, 177);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 32);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_customerSID);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_newCustomer);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.tb_customerSurnameS);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_customerNameS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_customerIDS);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_customerID);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_customerPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_customerName);
            this.panel1.Controls.Add(this.tb_customerSurname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 296);
            this.panel1.TabIndex = 9;
            // 
            // btn_customerSID
            // 
            this.btn_customerSID.Location = new System.Drawing.Point(264, 259);
            this.btn_customerSID.Name = "btn_customerSID";
            this.btn_customerSID.Size = new System.Drawing.Size(73, 30);
            this.btn_customerSID.TabIndex = 18;
            this.btn_customerSID.Text = "Ara";
            this.btn_customerSID.UseVisualStyleBackColor = true;
            this.btn_customerSID.Click += new System.EventHandler(this.btn_customerSID_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(675, 94);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 43);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_newCustomer
            // 
            this.btn_newCustomer.Location = new System.Drawing.Point(675, 38);
            this.btn_newCustomer.Name = "btn_newCustomer";
            this.btn_newCustomer.Size = new System.Drawing.Size(124, 43);
            this.btn_newCustomer.TabIndex = 16;
            this.btn_newCustomer.Text = "Yeni Müşteri";
            this.btn_newCustomer.UseVisualStyleBackColor = true;
            this.btn_newCustomer.Click += new System.EventHandler(this.btn_newCustomer_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(850, 259);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(87, 30);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tb_customerSurnameS
            // 
            this.tb_customerSurnameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerSurnameS.Location = new System.Drawing.Point(653, 260);
            this.tb_customerSurnameS.Name = "tb_customerSurnameS";
            this.tb_customerSurnameS.Size = new System.Drawing.Size(172, 27);
            this.tb_customerSurnameS.TabIndex = 14;
            this.tb_customerSurnameS.Click += new System.EventHandler(this.tb_customerSurnameS_Click);
            this.tb_customerSurnameS.TextChanged += new System.EventHandler(this.tb_customerSurnameS_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(587, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Soyad:";
            // 
            // tb_customerNameS
            // 
            this.tb_customerNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerNameS.Location = new System.Drawing.Point(391, 260);
            this.tb_customerNameS.Name = "tb_customerNameS";
            this.tb_customerNameS.Size = new System.Drawing.Size(172, 27);
            this.tb_customerNameS.TabIndex = 12;
            this.tb_customerNameS.Click += new System.EventHandler(this.tb_customerNameS_Click);
            this.tb_customerNameS.TextChanged += new System.EventHandler(this.tb_customerNameS_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(354, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ad:";
            // 
            // tb_customerIDS
            // 
            this.tb_customerIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerIDS.Location = new System.Drawing.Point(86, 260);
            this.tb_customerIDS.Name = "tb_customerIDS";
            this.tb_customerIDS.Size = new System.Drawing.Size(172, 27);
            this.tb_customerIDS.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID:";
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw.Location = new System.Drawing.Point(0, 296);
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(1022, 444);
            this.dgw.TabIndex = 10;
            this.dgw.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellEnter);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 740);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_customerID;
        private System.Windows.Forms.TextBox tb_customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_customerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_customerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox tb_customerSurnameS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_customerNameS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_customerIDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_newCustomer;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Button btn_customerSID;
    }
}