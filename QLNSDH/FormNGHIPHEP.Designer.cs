namespace QLNSDH
{
    partial class FormNGHIPHEP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNGHIPHEP));
            this.txthethan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnghi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtmaphong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dtgnp = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlido = new System.Windows.Forms.RichTextBox();
            this.rdofalse = new System.Windows.Forms.RadioButton();
            this.rdotrue = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgnp)).BeginInit();
            this.SuspendLayout();
            // 
            // txthethan
            // 
            this.txthethan.Enabled = false;
            this.txthethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txthethan.Location = new System.Drawing.Point(807, 181);
            this.txthethan.Name = "txthethan";
            this.txthethan.Size = new System.Drawing.Size(99, 20);
            this.txthethan.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ngày Nghỉ Đến";
            // 
            // txtnghi
            // 
            this.txtnghi.Enabled = false;
            this.txtnghi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtnghi.Location = new System.Drawing.Point(595, 179);
            this.txtnghi.Name = "txtnghi";
            this.txtnghi.Size = new System.Drawing.Size(100, 20);
            this.txtnghi.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ngày Nghỉ";
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.FormattingEnabled = true;
            this.txtmanv.Location = new System.Drawing.Point(806, 132);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 21);
            this.txtmanv.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã Nghỉ";
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(595, 133);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 37;
            // 
            // txtmaphong
            // 
            this.txtmaphong.FormattingEnabled = true;
            this.txtmaphong.Location = new System.Drawing.Point(154, 108);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(100, 21);
            this.txtmaphong.TabIndex = 51;
            this.txtmaphong.SelectedIndexChanged += new System.EventHandler(this.txtmaphong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Mã Phòng ban";
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = global::QLNSDH.Properties.Resources.Delete;
            this.btnhuy.Location = new System.Drawing.Point(383, 386);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(42, 39);
            this.btnhuy.TabIndex = 49;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Image = global::QLNSDH.Properties.Resources.Save;
            this.btnluu.Location = new System.Drawing.Point(312, 386);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(42, 39);
            this.btnluu.TabIndex = 48;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QLNSDH.Properties.Resources.Edit;
            this.btnsua.Location = new System.Drawing.Point(236, 386);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(42, 39);
            this.btnsua.TabIndex = 47;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QLNSDH.Properties.Resources.Add;
            this.btnthem.Location = new System.Drawing.Point(154, 386);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(42, 39);
            this.btnthem.TabIndex = 46;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dtgnp
            // 
            this.dtgnp.AllowUserToAddRows = false;
            this.dtgnp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgnp.Location = new System.Drawing.Point(69, 135);
            this.dtgnp.Name = "dtgnp";
            this.dtgnp.Size = new System.Drawing.Size(440, 245);
            this.dtgnp.TabIndex = 45;
            this.dtgnp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgnp_CellDoubleClick);
            this.dtgnp.Click += new System.EventHandler(this.dtgnp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Lý Do";
            // 
            // txtlido
            // 
            this.txtlido.Enabled = false;
            this.txtlido.Location = new System.Drawing.Point(590, 223);
            this.txtlido.Name = "txtlido";
            this.txtlido.Size = new System.Drawing.Size(210, 96);
            this.txtlido.TabIndex = 53;
            this.txtlido.Text = "";
            // 
            // rdofalse
            // 
            this.rdofalse.AutoSize = true;
            this.rdofalse.Enabled = false;
            this.rdofalse.Location = new System.Drawing.Point(807, 277);
            this.rdofalse.Name = "rdofalse";
            this.rdofalse.Size = new System.Drawing.Size(56, 17);
            this.rdofalse.TabIndex = 56;
            this.rdofalse.TabStop = true;
            this.rdofalse.Text = "Không";
            this.rdofalse.UseVisualStyleBackColor = true;
            // 
            // rdotrue
            // 
            this.rdotrue.AutoSize = true;
            this.rdotrue.Enabled = false;
            this.rdotrue.Location = new System.Drawing.Point(807, 254);
            this.rdotrue.Name = "rdotrue";
            this.rdotrue.Size = new System.Drawing.Size(41, 17);
            this.rdotrue.TabIndex = 55;
            this.rdotrue.TabStop = true;
            this.rdotrue.Text = "Có ";
            this.rdotrue.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Nghỉ Hưởng Lương";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(394, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 29);
            this.label9.TabIndex = 58;
            this.label9.Text = "NGHỈ PHÉP";
            // 
            // FormNGHIPHEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 452);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdofalse);
            this.Controls.Add(this.rdotrue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtlido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtgnp);
            this.Controls.Add(this.txthethan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnghi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNGHIPHEP";
            this.Text = "NGHIPHEP";
            this.Load += new System.EventHandler(this.FormNGHIPHEP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgnp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txthethan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtnghi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.ComboBox txtmaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dtgnp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtlido;
        private System.Windows.Forms.RadioButton rdofalse;
        private System.Windows.Forms.RadioButton rdotrue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}