namespace SMManagement.Forms
{
    partial class CustomersUserForm
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
            this.btn_customerSID = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tb_customerSurnameS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_customerNameS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_customerIDS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_newCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_newCustomer);
            this.panel1.Controls.Add(this.btn_customerSID);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.tb_customerSurnameS);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_customerNameS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_customerIDS);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 207);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 527);
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
            this.dgw.Size = new System.Drawing.Size(1022, 527);
            this.dgw.TabIndex = 0;
            // 
            // btn_customerSID
            // 
            this.btn_customerSID.Location = new System.Drawing.Point(257, 90);
            this.btn_customerSID.Name = "btn_customerSID";
            this.btn_customerSID.Size = new System.Drawing.Size(73, 30);
            this.btn_customerSID.TabIndex = 26;
            this.btn_customerSID.Text = "Ara";
            this.btn_customerSID.UseVisualStyleBackColor = true;
            this.btn_customerSID.Click += new System.EventHandler(this.btn_customerSID_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(581, 124);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(87, 30);
            this.btn_refresh.TabIndex = 25;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tb_customerSurnameS
            // 
            this.tb_customerSurnameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerSurnameS.Location = new System.Drawing.Point(384, 124);
            this.tb_customerSurnameS.Name = "tb_customerSurnameS";
            this.tb_customerSurnameS.Size = new System.Drawing.Size(172, 27);
            this.tb_customerSurnameS.TabIndex = 24;
            this.tb_customerSurnameS.Click += new System.EventHandler(this.tb_customerSurnameS_Click);
            this.tb_customerSurnameS.TextChanged += new System.EventHandler(this.tb_customerSurnameS_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(318, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Soyad:";
            // 
            // tb_customerNameS
            // 
            this.tb_customerNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerNameS.Location = new System.Drawing.Point(384, 91);
            this.tb_customerNameS.Name = "tb_customerNameS";
            this.tb_customerNameS.Size = new System.Drawing.Size(172, 27);
            this.tb_customerNameS.TabIndex = 22;
            this.tb_customerNameS.Click += new System.EventHandler(this.tb_customerNameS_Click);
            this.tb_customerNameS.TextChanged += new System.EventHandler(this.tb_customerNameS_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(347, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ad:";
            // 
            // tb_customerIDS
            // 
            this.tb_customerIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_customerIDS.Location = new System.Drawing.Point(79, 91);
            this.tb_customerIDS.Name = "tb_customerIDS";
            this.tb_customerIDS.Size = new System.Drawing.Size(172, 27);
            this.tb_customerIDS.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(42, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(814, 111);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 43);
            this.btn_exit.TabIndex = 28;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_newCustomer
            // 
            this.btn_newCustomer.Location = new System.Drawing.Point(814, 55);
            this.btn_newCustomer.Name = "btn_newCustomer";
            this.btn_newCustomer.Size = new System.Drawing.Size(124, 43);
            this.btn_newCustomer.TabIndex = 27;
            this.btn_newCustomer.Text = "Yeni Müşteri";
            this.btn_newCustomer.UseVisualStyleBackColor = true;
            this.btn_newCustomer.Click += new System.EventHandler(this.btn_newCustomer_Click);
            // 
            // CustomersUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomersUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.CustomersUserForm_Load);
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
        private System.Windows.Forms.Button btn_customerSID;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox tb_customerSurnameS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_customerNameS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_customerIDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_newCustomer;
    }
}