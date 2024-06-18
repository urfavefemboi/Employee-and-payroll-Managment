namespace QLNSDH
{
    partial class FormCHUCVU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCHUCVU));
            this.dtgcv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgcv
            // 
            this.dtgcv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcv.Location = new System.Drawing.Point(394, 112);
            this.dtgcv.Name = "dtgcv";
            this.dtgcv.Size = new System.Drawing.Size(302, 245);
            this.dtgcv.TabIndex = 14;
            this.dtgcv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgcv_CellDoubleClick);
            this.dtgcv.Click += new System.EventHandler(this.dtgcv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // txtten
            // 
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(193, 200);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 11;
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(193, 143);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 10;
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Image = global::QLNSDH.Properties.Resources.Delete;
            this.btnhuy.Location = new System.Drawing.Point(639, 363);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(42, 39);
            this.btnhuy.TabIndex = 19;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Image = global::QLNSDH.Properties.Resources.Save;
            this.btnluu.Location = new System.Drawing.Point(568, 363);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(42, 39);
            this.btnluu.TabIndex = 18;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QLNSDH.Properties.Resources.Edit;
            this.btnsua.Location = new System.Drawing.Point(492, 363);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(42, 39);
            this.btnsua.TabIndex = 17;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QLNSDH.Properties.Resources.Add;
            this.btnthem.Location = new System.Drawing.Point(410, 363);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(42, 39);
            this.btnthem.TabIndex = 16;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(306, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "CHỨC VỤ";
            // 
            // FormCHUCVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtgcv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCHUCVU";
            this.Text = "CHUCVU";
            this.Load += new System.EventHandler(this.FormCHUCVU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgcv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dtgcv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label4;
    }
}