
namespace thi_giua_ky
{
    partial class Form2
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
            this.tb_mssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dtb = new System.Windows.Forms.TextBox();
            this.cbb_lopsinhhoat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_ngoaingu = new System.Windows.Forms.CheckBox();
            this.cb_hocba = new System.Windows.Forms.CheckBox();
            this.cb_anh = new System.Windows.Forms.CheckBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_mssv
            // 
            this.tb_mssv.Location = new System.Drawing.Point(118, 40);
            this.tb_mssv.Name = "tb_mssv";
            this.tb_mssv.Size = new System.Drawing.Size(121, 20);
            this.tb_mssv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "mssv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "lớp sinh hoạt";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(118, 80);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(121, 20);
            this.tb_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "dtb";
            // 
            // tb_dtb
            // 
            this.tb_dtb.Location = new System.Drawing.Point(516, 84);
            this.tb_dtb.Name = "tb_dtb";
            this.tb_dtb.Size = new System.Drawing.Size(121, 20);
            this.tb_dtb.TabIndex = 8;
            // 
            // cbb_lopsinhhoat
            // 
            this.cbb_lopsinhhoat.FormattingEnabled = true;
            this.cbb_lopsinhhoat.Location = new System.Drawing.Point(118, 119);
            this.cbb_lopsinhhoat.Name = "cbb_lopsinhhoat";
            this.cbb_lopsinhhoat.Size = new System.Drawing.Size(121, 21);
            this.cbb_lopsinhhoat.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_female);
            this.groupBox1.Controls.Add(this.rdb_male);
            this.groupBox1.Location = new System.Drawing.Point(69, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gender";
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(115, 31);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(56, 17);
            this.rdb_female.TabIndex = 1;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "female";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(6, 31);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(47, 17);
            this.rdb_male.TabIndex = 0;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "male";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_ngoaingu);
            this.groupBox2.Controls.Add(this.cb_hocba);
            this.groupBox2.Controls.Add(this.cb_anh);
            this.groupBox2.Location = new System.Drawing.Point(437, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "hồ sơ nộp";
            // 
            // cb_ngoaingu
            // 
            this.cb_ngoaingu.AutoSize = true;
            this.cb_ngoaingu.Location = new System.Drawing.Point(6, 65);
            this.cb_ngoaingu.Name = "cb_ngoaingu";
            this.cb_ngoaingu.Size = new System.Drawing.Size(73, 17);
            this.cb_ngoaingu.TabIndex = 2;
            this.cb_ngoaingu.Text = "ngoại ngữ";
            this.cb_ngoaingu.UseVisualStyleBackColor = true;
            // 
            // cb_hocba
            // 
            this.cb_hocba.AutoSize = true;
            this.cb_hocba.Location = new System.Drawing.Point(6, 42);
            this.cb_hocba.Name = "cb_hocba";
            this.cb_hocba.Size = new System.Drawing.Size(59, 17);
            this.cb_hocba.TabIndex = 1;
            this.cb_hocba.Text = "học bạ";
            this.cb_hocba.UseVisualStyleBackColor = true;
            // 
            // cb_anh
            // 
            this.cb_anh.AutoSize = true;
            this.cb_anh.Location = new System.Drawing.Point(6, 19);
            this.cb_anh.Name = "cb_anh";
            this.cb_anh.Size = new System.Drawing.Size(44, 17);
            this.cb_anh.TabIndex = 0;
            this.cb_anh.Text = "ảnh";
            this.cb_anh.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(130, 347);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 13;
            this.bt_ok.Text = "ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(390, 347);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 14;
            this.bt_cancel.Text = "cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(516, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbb_lopsinhhoat);
            this.Controls.Add(this.tb_dtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_mssv);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_mssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dtb;
        private System.Windows.Forms.ComboBox cbb_lopsinhhoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_ngoaingu;
        private System.Windows.Forms.CheckBox cb_hocba;
        private System.Windows.Forms.CheckBox cb_anh;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}