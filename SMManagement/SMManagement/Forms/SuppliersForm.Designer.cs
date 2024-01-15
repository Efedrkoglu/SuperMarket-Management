namespace SMManagement.Forms
{
    partial class SuppliersForm
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
            this.tb_supplierID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_supplierTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_supplierAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_supplierSID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_supplierName = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_newSupplier = new System.Windows.Forms.Button();
            this.btn_searchID = new System.Windows.Forms.Button();
            this.tb_supplierSAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_supplierSName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi ID:";
            // 
            // tb_supplierID
            // 
            this.tb_supplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierID.Location = new System.Drawing.Point(181, 35);
            this.tb_supplierID.Name = "tb_supplierID";
            this.tb_supplierID.ReadOnly = true;
            this.tb_supplierID.Size = new System.Drawing.Size(179, 27);
            this.tb_supplierID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tedarikçi Adı:";
            // 
            // tb_supplierTel
            // 
            this.tb_supplierTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierTel.Location = new System.Drawing.Point(435, 35);
            this.tb_supplierTel.Name = "tb_supplierTel";
            this.tb_supplierTel.Size = new System.Drawing.Size(179, 27);
            this.tb_supplierTel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(366, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tel No:";
            // 
            // tb_supplierAdd
            // 
            this.tb_supplierAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierAdd.Location = new System.Drawing.Point(435, 68);
            this.tb_supplierAdd.Name = "tb_supplierAdd";
            this.tb_supplierAdd.Size = new System.Drawing.Size(179, 27);
            this.tb_supplierAdd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(371, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adres:";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(516, 101);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(98, 34);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_supplierSID
            // 
            this.tb_supplierSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierSID.Location = new System.Drawing.Point(120, 175);
            this.tb_supplierSID.Name = "tb_supplierSID";
            this.tb_supplierSID.Size = new System.Drawing.Size(244, 27);
            this.tb_supplierSID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tedarikçi ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_supplierName);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_newSupplier);
            this.panel1.Controls.Add(this.btn_searchID);
            this.panel1.Controls.Add(this.tb_supplierSAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_supplierSName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_supplierID);
            this.panel1.Controls.Add(this.tb_supplierSID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.tb_supplierAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_supplierTel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 242);
            this.panel1.TabIndex = 11;
            // 
            // tb_supplierName
            // 
            this.tb_supplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierName.Location = new System.Drawing.Point(181, 68);
            this.tb_supplierName.Name = "tb_supplierName";
            this.tb_supplierName.Size = new System.Drawing.Size(179, 27);
            this.tb_supplierName.TabIndex = 19;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_refresh.Location = new System.Drawing.Point(844, 175);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(135, 34);
            this.btn_refresh.TabIndex = 18;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.Location = new System.Drawing.Point(830, 87);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(160, 43);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_newSupplier
            // 
            this.btn_newSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_newSupplier.Location = new System.Drawing.Point(830, 38);
            this.btn_newSupplier.Name = "btn_newSupplier";
            this.btn_newSupplier.Size = new System.Drawing.Size(160, 43);
            this.btn_newSupplier.TabIndex = 16;
            this.btn_newSupplier.Text = "Yeni Tedarikçi";
            this.btn_newSupplier.UseVisualStyleBackColor = true;
            this.btn_newSupplier.Click += new System.EventHandler(this.btn_newSupplier_Click);
            // 
            // btn_searchID
            // 
            this.btn_searchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_searchID.Location = new System.Drawing.Point(370, 175);
            this.btn_searchID.Name = "btn_searchID";
            this.btn_searchID.Size = new System.Drawing.Size(86, 27);
            this.btn_searchID.TabIndex = 15;
            this.btn_searchID.Text = "Ara";
            this.btn_searchID.UseVisualStyleBackColor = true;
            this.btn_searchID.Click += new System.EventHandler(this.btn_searchID_Click);
            // 
            // tb_supplierSAdd
            // 
            this.tb_supplierSAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierSAdd.Location = new System.Drawing.Point(434, 208);
            this.tb_supplierSAdd.Name = "tb_supplierSAdd";
            this.tb_supplierSAdd.Size = new System.Drawing.Size(244, 27);
            this.tb_supplierSAdd.TabIndex = 14;
            this.tb_supplierSAdd.Click += new System.EventHandler(this.tb_supplierSAdd_Click);
            this.tb_supplierSAdd.TextChanged += new System.EventHandler(this.tb_supplierSAdd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(370, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adres:";
            // 
            // tb_supplierSName
            // 
            this.tb_supplierSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_supplierSName.Location = new System.Drawing.Point(120, 208);
            this.tb_supplierSName.Name = "tb_supplierSName";
            this.tb_supplierSName.Size = new System.Drawing.Size(244, 27);
            this.tb_supplierSName.TabIndex = 12;
            this.tb_supplierSName.Click += new System.EventHandler(this.tb_supplierSName_Click);
            this.tb_supplierSName.TextChanged += new System.EventHandler(this.tb_supplierSName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tedarikçi Adı:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 496);
            this.panel2.TabIndex = 12;
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw.Location = new System.Drawing.Point(0, 0);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersWidth = 51;
            this.dgw.RowTemplate.Height = 24;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(1086, 496);
            this.dgw.TabIndex = 0;
            this.dgw.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellEnter);
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SuppliersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçiler";
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_supplierID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_supplierTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_supplierAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_supplierSID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_supplierSName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_searchID;
        private System.Windows.Forms.TextBox tb_supplierSAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_newSupplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.TextBox tb_supplierName;
    }
}