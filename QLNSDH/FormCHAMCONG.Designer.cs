namespace QLNSDH
{
    partial class FormCHAMCONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCHAMCONG));
            this.txtmaphong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dtgcc = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmacc = new System.Windows.Forms.TextBox();
            this.hl = new System.Windows.Forms.TextBox();
            this.txtngaycong = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtthang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmaphong
            // 
            this.txtmaphong.FormattingEnabled = true;
            this.txtmaphong.Location = new System.Drawing.Point(86, 200);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(100, 21);
            this.txtmaphong.TabIndex = 71;
            this.txtmaphong.SelectedIndexChanged += new System.EventHandler(this.txtmaphong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Mã Phòng ban";
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = global::QLNSDH.Properties.Resources.Delete;
            this.btnhuy.Location = new System.Drawing.Point(578, 451);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(42, 39);
            this.btnhuy.TabIndex = 69;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Image = global::QLNSDH.Properties.Resources.Save;
            this.btnluu.Location = new System.Drawing.Point(507, 451);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(42, 39);
            this.btnluu.TabIndex = 68;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QLNSDH.Properties.Resources.Edit;
            this.btnsua.Location = new System.Drawing.Point(431, 451);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(42, 39);
            this.btnsua.TabIndex = 67;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QLNSDH.Properties.Resources.Add;
            this.btnthem.Location = new System.Drawing.Point(349, 451);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(42, 39);
            this.btnthem.TabIndex = 66;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dtgcc
            // 
            this.dtgcc.AllowUserToAddRows = false;
            this.dtgcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcc.Location = new System.Drawing.Point(192, 200);
            this.dtgcc.Name = "dtgcc";
            this.dtgcc.Size = new System.Drawing.Size(640, 245);
            this.dtgcc.TabIndex = 65;
            this.dtgcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgcc_CellDoubleClick);
            this.dtgcc.Click += new System.EventHandler(this.dtgcc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Ngày Nghỉ Hưởng Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Ngày Công";
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.FormattingEnabled = true;
            this.txtmanv.Location = new System.Drawing.Point(246, 108);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 21);
            this.txtmanv.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Mã Chấm Công";
            // 
            // txtmacc
            // 
            this.txtmacc.Enabled = false;
            this.txtmacc.Location = new System.Drawing.Point(468, 88);
            this.txtmacc.Name = "txtmacc";
            this.txtmacc.Size = new System.Drawing.Size(100, 20);
            this.txtmacc.TabIndex = 57;
            // 
            // hl
            // 
            this.hl.Enabled = false;
            this.hl.Location = new System.Drawing.Point(732, 139);
            this.hl.Name = "hl";
            this.hl.Size = new System.Drawing.Size(100, 20);
            this.hl.TabIndex = 72;
            this.hl.Text = "0";
            this.hl.TextChanged += new System.EventHandler(this.txthl_TextChanged);
            // 
            // txtngaycong
            // 
            this.txtngaycong.Enabled = false;
            this.txtngaycong.Location = new System.Drawing.Point(732, 90);
            this.txtngaycong.Name = "txtngaycong";
            this.txtngaycong.Size = new System.Drawing.Size(100, 20);
            this.txtngaycong.TabIndex = 73;
            // 
            // txtnam
            // 
            this.txtnam.Enabled = false;
            this.txtnam.Location = new System.Drawing.Point(521, 136);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(47, 20);
            this.txtnam.TabIndex = 76;
            this.txtnam.TextChanged += new System.EventHandler(this.txtnam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Năm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Tháng";
            // 
            // txtthang
            // 
            this.txtthang.Enabled = false;
            this.txtthang.FormattingEnabled = true;
            this.txtthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtthang.Location = new System.Drawing.Point(422, 136);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(47, 21);
            this.txtthang.TabIndex = 77;
            this.txtthang.SelectedIndexChanged += new System.EventHandler(this.txtthang_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(406, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 29);
            this.label9.TabIndex = 79;
            this.label9.Text = "CHẤM CÔNG";
            // 
            // FormCHAMCONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 498);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtngaycong);
            this.Controls.Add(this.hl);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtgcc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmacc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCHAMCONG";
            this.Text = "CHAMCONG";
            this.Load += new System.EventHandler(this.FormCHAMCONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtmaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dtgcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmacc;
        private System.Windows.Forms.TextBox hl;
        private System.Windows.Forms.TextBox txtngaycong;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtthang;
        private System.Windows.Forms.Label label9;
    }
}