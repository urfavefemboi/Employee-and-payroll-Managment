namespace QLNSDH
{
    partial class FormHOPDONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHOPDONG));
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dtghd = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.ComboBox();
            this.txtmaphong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtky = new System.Windows.Forms.DateTimePicker();
            this.txthethan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdotrue = new System.Windows.Forms.RadioButton();
            this.rdofalse = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtghd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = global::QLNSDH.Properties.Resources.Delete;
            this.btnhuy.Location = new System.Drawing.Point(415, 341);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(42, 39);
            this.btnhuy.TabIndex = 29;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Image = global::QLNSDH.Properties.Resources.Save;
            this.btnluu.Location = new System.Drawing.Point(344, 341);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(42, 39);
            this.btnluu.TabIndex = 28;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QLNSDH.Properties.Resources.Edit;
            this.btnsua.Location = new System.Drawing.Point(268, 341);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(42, 39);
            this.btnsua.TabIndex = 27;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QLNSDH.Properties.Resources.Add;
            this.btnthem.Location = new System.Drawing.Point(186, 341);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(42, 39);
            this.btnthem.TabIndex = 26;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dtghd
            // 
            this.dtghd.AllowUserToAddRows = false;
            this.dtghd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtghd.Location = new System.Drawing.Point(101, 90);
            this.dtghd.Name = "dtghd";
            this.dtghd.Size = new System.Drawing.Size(440, 245);
            this.dtghd.TabIndex = 24;
            this.dtghd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtghd_CellDoubleClick);
            this.dtghd.Click += new System.EventHandler(this.dtghd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(643, 126);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 20;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.FormattingEnabled = true;
            this.txtmanv.Location = new System.Drawing.Point(854, 125);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 21);
            this.txtmanv.TabIndex = 30;
            // 
            // txtmaphong
            // 
            this.txtmaphong.FormattingEnabled = true;
            this.txtmaphong.Location = new System.Drawing.Point(186, 63);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(100, 21);
            this.txtmaphong.TabIndex = 32;
            this.txtmaphong.SelectedIndexChanged += new System.EventHandler(this.txtmaphong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mã Phòng ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ngày Ký";
            // 
            // txtky
            // 
            this.txtky.Enabled = false;
            this.txtky.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtky.Location = new System.Drawing.Point(643, 167);
            this.txtky.Name = "txtky";
            this.txtky.Size = new System.Drawing.Size(100, 20);
            this.txtky.TabIndex = 34;
            // 
            // txthethan
            // 
            this.txthethan.Enabled = false;
            this.txthethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txthethan.Location = new System.Drawing.Point(855, 166);
            this.txthethan.Name = "txthethan";
            this.txthethan.Size = new System.Drawing.Size(99, 20);
            this.txthethan.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(773, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ngày Hết Hạn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Hiệu lực";
            // 
            // rdotrue
            // 
            this.rdotrue.AutoSize = true;
            this.rdotrue.Enabled = false;
            this.rdotrue.Location = new System.Drawing.Point(739, 214);
            this.rdotrue.Name = "rdotrue";
            this.rdotrue.Size = new System.Drawing.Size(78, 17);
            this.rdotrue.TabIndex = 38;
            this.rdotrue.TabStop = true;
            this.rdotrue.Text = "Có hiệu lực";
            this.rdotrue.UseVisualStyleBackColor = true;
            // 
            // rdofalse
            // 
            this.rdofalse.AutoSize = true;
            this.rdofalse.Enabled = false;
            this.rdofalse.Location = new System.Drawing.Point(739, 237);
            this.rdofalse.Name = "rdofalse";
            this.rdofalse.Size = new System.Drawing.Size(82, 17);
            this.rdofalse.TabIndex = 39;
            this.rdofalse.TabStop = true;
            this.rdofalse.Text = "Hết hiệu lực";
            this.rdofalse.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(421, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "HỢP ĐỒNG";
            // 
            // FormHOPDONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 420);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdofalse);
            this.Controls.Add(this.rdotrue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txthethan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtky);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtghd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHOPDONG";
            this.Text = "HOPDONG";
            this.Load += new System.EventHandler(this.FormHOPDONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtghd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dtghd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.ComboBox txtmanv;
        private System.Windows.Forms.ComboBox txtmaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtky;
        private System.Windows.Forms.DateTimePicker txthethan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdotrue;
        private System.Windows.Forms.RadioButton rdofalse;
        private System.Windows.Forms.Label label8;
    }
}