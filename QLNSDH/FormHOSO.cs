using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNSDH.Properties;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
using QLDCDKT.Function;

namespace QLNSDH
{
    public partial class FormHOSO : Form
    {
        public FormHOSO()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtgdn.Columns[0].HeaderText = "Tên Đăng Nhập";
            dtgdn.Columns[1].HeaderText = "Mật Khẩu";
            dtgdn.Columns[2].HeaderText = "Quyền Hạn";
            dtgdn.Columns[0].Width = 100;
            dtgdn.Columns[1].Width = 100;
            dtgdn.Columns[2].Width = 100;
            dtgdn.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgdn.AllowUserToAddRows = false;
        }
        public void Laydulieulengrid()
        {
            string sql = "select * from DangNhap";
            dtgdn.DataSource = function.Laydulieulengird(sql);
            Dinhdangdulieu();
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name == "btnluu" || ctr.Name == "btnhuy")
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnthem" || ctr.Name == "btnsua")
                {
                    ctr.Enabled = !e;
                }
            }
        }
        public void Cleartext()
        {
            txtma.Clear();
            txtdn.Clear();
        }
        private void FormHOSO_Load(object sender, EventArgs e)
        {
            Laydulieulengrid();
        }
        String Capnhat = "";
        private void btnthem_Click(object sender, EventArgs e)
        {
            Capnhat = "T";
            Cleartext();
            enable_control(true, this);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Capnhat = "S";
            enable_control(true, this);
            txtma.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (Capnhat == "T")
                {
                    if (txtma.Text == "" || txtdn.Text == "")
                    {
                        MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string sqlcheckkey = "SELECT [User],Pass FROM DangNhap " +
                           "WHERE [User] = '" + txtdn.Text + "' AND Pass = '" + txtma.Text + "'";
                    if (function.CheckKey(sqlcheckkey) == true)
                    {
                        MessageBox.Show("Đã tồn tại tài khoản này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        sql = "INSERT INTO DangNhap VALUES('"
                        + txtdn.Text.Trim() + "','"
                        + txtma.Text.Trim() + "','"+ txthqh.Text.Trim() + "')";
                    }
                }
                else if (Capnhat == "S")
                {
                    if (txtma.Text == "" || txtdn.Text == "")
                    {
                        MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    sql = "update  DangNhap set Pass='" + txtma.Text.Trim() +
                         ", QuyenHan='"+txthqh.Text+"' where [User]='" + txtdn.Text.Trim() + "'";
                }
                function.Runsql(sql);
                enable_control(false, this);
                Laydulieulengrid();
                Cleartext();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgdn_Click(object sender, EventArgs e)
        {
            txtdn.Text = dtgdn.CurrentRow.Cells["User"].Value.ToString();
            txtma.Text = dtgdn.CurrentRow.Cells["Pass"].Value.ToString();         
            txthqh.Text = dtgdn.CurrentRow.Cells["QuyenHan"].Value.ToString();
        }

        private void dtgdn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete DangNhap where [User]='" + txtdn.Text + "'";
                function.Runsql(sql);
                Cleartext();
                Laydulieulengrid();

            }
        }
    }
}
