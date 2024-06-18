using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDCDKT.Function;
using QLNSDH.Properties;

namespace QLNSDH
{
    public partial class Form1 : Form
    {
        
        public string quyenhan { get; set; }
        public string QH = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            function.Connect();
            QH = quyenhan;
        }
        public bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return true;
            return false;
        }

        private void cậpNhậtPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(QH!="Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if (!IsFormOpen(typeof(FormPHONGBAN)))
            {
                FormPHONGBAN fr = new FormPHONGBAN();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở"+QH+"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void cậpNhậtChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QH != "Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormOpen(typeof(FormCHUCVU)))
            {
                FormCHUCVU fr = new FormCHUCVU();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cậpNhậtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QH != "Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormOpen(typeof(FormNHANVIEN)))
            {
                FormNHANVIEN fr = new FormNHANVIEN();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QH != "Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormOpen(typeof(FormHOPDONG)))
            {
                FormHOPDONG fr = new FormHOPDONG();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cậpNhậtNghỉPhépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QH != "Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormOpen(typeof(FormNGHIPHEP)))
            {
                FormNGHIPHEP fr = new FormNGHIPHEP();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cậpNhậtLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QH != "Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormOpen(typeof(FormLUONG)))
            {
                FormLUONG fr = new FormLUONG();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cậpNhậtBảngChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QH != "Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormOpen(typeof(FormCHAMCONG)))
            {
                FormCHAMCONG fr = new FormCHAMCONG();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cậpNhậtThanhToánLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QH != "Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormOpen(typeof(FormTTL)))
            {
                FormTTL fr = new FormTTL();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void thốngKêNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen(typeof(FormBAOCAONHANVIEN)))
            {
                FormBAOCAONHANVIEN fr = new FormBAOCAONHANVIEN();
            fr.MdiParent = this;
            fr.Show();
        }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void bảngLươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            if (!IsFormOpen(typeof(FormBAOCAOLUONG)))
            {
                FormBAOCAOLUONG fr = new FormBAOCAOLUONG();
            fr.MdiParent = this;
            fr.Show();
        }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void quarnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cậpNhậtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QH != "Admin")
            {
                MessageBox.Show("Bạn không có quyền hạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsFormOpen(typeof(FormHOSO)))
            {
                FormHOSO fr = new FormHOSO();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Form đã được mở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDANGNHAP fr=new FormDANGNHAP();
            fr.Show();
        }

        private void quanLýLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
