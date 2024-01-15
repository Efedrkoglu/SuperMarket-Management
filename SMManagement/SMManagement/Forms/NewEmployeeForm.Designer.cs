namespace SMManagement.Forms
{
    partial class NewEmployeeForm
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
            this.btn_add = new System.Windows.Forms.Button();
            this.dtp_doStart = new System.Windows.Forms.DateTimePicker();
            this.dtp_doBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_employeeSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_employeeCatID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_employeeSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_employeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_employeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(766, 136);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(106, 34);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dtp_doStart
            // 
            this.dtp_doStart.CustomFormat = "yyyy-MM-dd";
            this.dtp_doStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_doStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_doStart.Location = new System.Drawing.Point(420, 119);
            this.dtp_doStart.Name = "dtp_doStart";
            this.dtp_doStart.Size = new System.Drawing.Size(178, 27);
            this.dtp_doStart.TabIndex = 31;
            // 
            // dtp_doBirth
            // 
            this.dtp_doBirth.CustomFormat = "yyyy-MM-dd";
            this.dtp_doBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_doBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_doBirth.Location = new System.Drawing.Point(420, 84);
            this.dtp_doBirth.Name = "dtp_doBirth";
            this.dtp_doBirth.Size = new System.Drawing.Size(178, 27);
            this.dtp_doBirth.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(295, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "İşe Başlama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(287, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // tb_employeeSalary
            // 
            this.tb_employeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_employeeSalary.Location = new System.Drawing.Point(691, 85);
            this.tb_employeeSalary.Name = "tb_employeeSalary";
            this.tb_employeeSalary.Size = new System.Drawing.Size(181, 27);
            this.tb_employeeSalary.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(630, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Maaş:";
            // 
            // tb_employeeCatID
            // 
            this.tb_employeeCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_employeeCatID.Location = new System.Drawing.Point(420, 150);
            this.tb_employeeCatID.Name = "tb_employeeCatID";
            this.tb_employeeCatID.Size = new System.Drawing.Size(178, 27);
            this.tb_employeeCatID.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(304, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kategori ID:";
            // 
            // tb_employeeSurname
            // 
            this.tb_employeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_employeeSurname.Location = new System.Drawing.Point(91, 147);
            this.tb_employeeSurname.Name = "tb_employeeSurname";
            this.tb_employeeSurname.Size = new System.Drawing.Size(176, 27);
            this.tb_employeeSurname.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Soyad:";
            // 
            // tb_employeeName
            // 
            this.tb_employeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_employeeName.Location = new System.Drawing.Point(91, 114);
            this.tb_employeeName.Name = "tb_employeeName";
            this.tb_employeeName.Size = new System.Drawing.Size(176, 27);
            this.tb_employeeName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ad:";
            // 
            // tb_employeeID
            // 
            this.tb_employeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_employeeID.Location = new System.Drawing.Point(91, 81);
            this.tb_employeeID.Name = "tb_employeeID";
            this.tb_employeeID.Size = new System.Drawing.Size(176, 27);
            this.tb_employeeID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID:";
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 262);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtp_doStart);
            this.Controls.Add(this.dtp_doBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_employeeSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_employeeCatID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_employeeSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_employeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_employeeID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Çalışan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewEmployeeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dtp_doStart;
        private System.Windows.Forms.DateTimePicker dtp_doBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_employeeSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_employeeCatID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_employeeSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_employeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_employeeID;
        private System.Windows.Forms.Label label1;
    }
}