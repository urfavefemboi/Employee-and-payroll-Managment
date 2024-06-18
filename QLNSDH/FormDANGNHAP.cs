using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using QLDCDKT.Function;
using QLNSDH.CLass;

namespace QLNSDH
{
    public partial class FormDANGNHAP : Form
    {
       
        
        public FormDANGNHAP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        Form1 fr = new Form1();
        private void FormDANGNHAP_Load(object sender, EventArgs e)
        {
            function.Connect();
            txtmk.UseSystemPasswordChar = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "Select [User] , Pass from DangNhap where [User]='" + txtdn.Text.Trim() +
                "'and Pass='" + txtmk.Text.Trim() + "'";
           
            if (function.CheckKey(sql))
            {
                string sqlquyenhan = "select QuyenHan from DangNhap where [User]='" + txtdn.Text.Trim() + "'";
                fr.quyenhan = function.GetFieldValues(sqlquyenhan);
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdn.Clear();
            txtmk.Clear();
            txtdn.Focus();
        }

        private void txtck_CheckedChanged(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = !txtck.Checked;
        }
    }
}
