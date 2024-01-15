namespace SMManagement.Forms
{
    partial class CategoriesForm
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
            this.categoryNameLbl = new System.Windows.Forms.Label();
            this.tb_categoryName = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_newCatName = new System.Windows.Forms.TextBox();
            this.newCategoryNameLbl = new System.Windows.Forms.Label();
            this.tb_newCatID = new System.Windows.Forms.TextBox();
            this.newCategoryIDLbl = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tb_categoryID = new System.Windows.Forms.TextBox();
            this.categoryIDLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_categoryID);
            this.panel1.Controls.Add(this.categoryIDLbl);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.tb_newCatID);
            this.panel1.Controls.Add(this.newCategoryIDLbl);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.tb_newCatName);
            this.panel1.Controls.Add(this.newCategoryNameLbl);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.tb_categoryName);
            this.panel1.Controls.Add(this.categoryNameLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 620);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(386, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 620);
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
            this.dgw.Size = new System.Drawing.Size(492, 620);
            this.dgw.TabIndex = 0;
            this.dgw.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellEnter);
            // 
            // categoryNameLbl
            // 
            this.categoryNameLbl.AutoSize = true;
            this.categoryNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryNameLbl.Location = new System.Drawing.Point(34, 157);
            this.categoryNameLbl.Name = "categoryNameLbl";
            this.categoryNameLbl.Size = new System.Drawing.Size(105, 20);
            this.categoryNameLbl.TabIndex = 0;
            this.categoryNameLbl.Text = "Kategori Adı:";
            // 
            // tb_categoryName
            // 
            this.tb_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_categoryName.Location = new System.Drawing.Point(145, 154);
            this.tb_categoryName.Name = "tb_categoryName";
            this.tb_categoryName.Size = new System.Drawing.Size(180, 27);
            this.tb_categoryName.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(220, 187);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 34);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(220, 414);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 34);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_newCatName
            // 
            this.tb_newCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_newCatName.Location = new System.Drawing.Point(145, 381);
            this.tb_newCatName.Name = "tb_newCatName";
            this.tb_newCatName.Size = new System.Drawing.Size(180, 27);
            this.tb_newCatName.TabIndex = 4;
            // 
            // newCategoryNameLbl
            // 
            this.newCategoryNameLbl.AutoSize = true;
            this.newCategoryNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newCategoryNameLbl.Location = new System.Drawing.Point(34, 384);
            this.newCategoryNameLbl.Name = "newCategoryNameLbl";
            this.newCategoryNameLbl.Size = new System.Drawing.Size(105, 20);
            this.newCategoryNameLbl.TabIndex = 3;
            this.newCategoryNameLbl.Text = "Kategori Adı:";
            // 
            // tb_newCatID
            // 
            this.tb_newCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_newCatID.Location = new System.Drawing.Point(145, 348);
            this.tb_newCatID.Name = "tb_newCatID";
            this.tb_newCatID.Size = new System.Drawing.Size(180, 27);
            this.tb_newCatID.TabIndex = 7;
            // 
            // newCategoryIDLbl
            // 
            this.newCategoryIDLbl.AutoSize = true;
            this.newCategoryIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newCategoryIDLbl.Location = new System.Drawing.Point(34, 351);
            this.newCategoryIDLbl.Name = "newCategoryIDLbl";
            this.newCategoryIDLbl.Size = new System.Drawing.Size(98, 20);
            this.newCategoryIDLbl.TabIndex = 6;
            this.newCategoryIDLbl.Text = "Kategori ID:";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.Location = new System.Drawing.Point(145, 518);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(121, 44);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_categoryID
            // 
            this.tb_categoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_categoryID.Location = new System.Drawing.Point(145, 121);
            this.tb_categoryID.Name = "tb_categoryID";
            this.tb_categoryID.ReadOnly = true;
            this.tb_categoryID.Size = new System.Drawing.Size(180, 27);
            this.tb_categoryID.TabIndex = 10;
            // 
            // categoryIDLbl
            // 
            this.categoryIDLbl.AutoSize = true;
            this.categoryIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryIDLbl.Location = new System.Drawing.Point(34, 124);
            this.categoryIDLbl.Name = "categoryIDLbl";
            this.categoryIDLbl.Size = new System.Drawing.Size(98, 20);
            this.categoryIDLbl.TabIndex = 9;
            this.categoryIDLbl.Text = "Kategori ID:";
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
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
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_newCatName;
        private System.Windows.Forms.Label newCategoryNameLbl;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_categoryName;
        private System.Windows.Forms.Label categoryNameLbl;
        private System.Windows.Forms.TextBox tb_newCatID;
        private System.Windows.Forms.Label newCategoryIDLbl;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox tb_categoryID;
        private System.Windows.Forms.Label categoryIDLbl;
    }
}