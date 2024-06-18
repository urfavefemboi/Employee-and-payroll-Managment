namespace QLNSDH
{
    partial class FormDANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDANGNHAP));
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(305, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtck);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtmk);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtdn);
            this.panel1.Location = new System.Drawing.Point(310, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 125);
            this.panel1.TabIndex = 32;
            // 
            // txtck
            // 
            this.txtck.AutoSize = true;
            this.txtck.Location = new System.Drawing.Point(254, 81);
            this.txtck.Name = "txtck";
            this.txtck.Size = new System.Drawing.Size(38, 17);
            this.txtck.TabIndex = 5;
            this.txtck.Text = "👁️";
            this.txtck.UseVisualStyleBackColor = true;
            this.txtck.CheckedChanged += new System.EventHandler(this.txtck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(92, 81);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(156, 20);
            this.txtmk.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tài Khoản";
            // 
            // txtdn
            // 
            this.txtdn.Location = new System.Drawing.Point(92, 17);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(156, 20);
            this.txtdn.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Đăng nhập";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // FormDANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDANGNHAP";
            this.Text = "DANGNHAP";
            this.Load += new System.EventHandler(this.FormDANGNHAP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox txtck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}