namespace QLNSDH
{
    partial class FormHOSO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHOSO));
            this.label3 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dtgdn = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.txthqh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdn)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(280, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "TÀI KHOẢN";
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = global::QLNSDH.Properties.Resources.Delete;
            this.btnhuy.Location = new System.Drawing.Point(670, 346);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(42, 39);
            this.btnhuy.TabIndex = 44;
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Image = global::QLNSDH.Properties.Resources.Save;
            this.btnluu.Location = new System.Drawing.Point(599, 346);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(42, 39);
            this.btnluu.TabIndex = 43;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QLNSDH.Properties.Resources.Edit;
            this.btnsua.Location = new System.Drawing.Point(523, 346);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(42, 39);
            this.btnsua.TabIndex = 42;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QLNSDH.Properties.Resources.Add;
            this.btnthem.Location = new System.Drawing.Point(441, 346);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(42, 39);
            this.btnthem.TabIndex = 41;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dtgdn
            // 
            this.dtgdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdn.Location = new System.Drawing.Point(425, 95);
            this.dtgdn.Name = "dtgdn";
            this.dtgdn.Size = new System.Drawing.Size(302, 245);
            this.dtgdn.TabIndex = 40;
            this.dtgdn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdn_CellDoubleClick);
            this.dtgdn.Click += new System.EventHandler(this.dtgdn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "MẬT KHẨU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "TÊN ĐĂNG NHẬP";
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(259, 174);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 37;
            // 
            // txtdn
            // 
            this.txtdn.Enabled = false;
            this.txtdn.Location = new System.Drawing.Point(259, 131);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(100, 20);
            this.txtdn.TabIndex = 36;
            // 
            // txthqh
            // 
            this.txthqh.FormattingEnabled = true;
            this.txthqh.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.txthqh.Location = new System.Drawing.Point(259, 216);
            this.txthqh.Name = "txthqh";
            this.txthqh.Size = new System.Drawing.Size(100, 21);
            this.txthqh.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "QUYỀN HẠN";
            // 
            // FormHOSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthqh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtgdn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.txtdn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHOSO";
            this.Text = "HOSO";
            this.Load += new System.EventHandler(this.FormHOSO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dtgdn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.ComboBox txthqh;
        private System.Windows.Forms.Label label4;
    }
}