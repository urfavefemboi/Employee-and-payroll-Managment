using QLDCDKT.Function;
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

namespace QLNSDH
{
    public partial class FormCHUCVU : Form
    {
        public FormCHUCVU()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtgcv.Columns[0].HeaderText = "Mã chức vụ";
            dtgcv.Columns[1].HeaderText = "Tên chức vụ";
            dtgcv.Columns[0].Width = 100;
            dtgcv.Columns[1].Width = 100;
        }
        public void Laydulieulengrid()
        {
            string sql = "select * from ChucVu";
            dtgcv.DataSource = function.Laydulieulengird(sql);
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
            txtten.Clear();
        }
        private void FormCHUCVU_Load(object sender, EventArgs e)
        {
            Laydulieulengrid();
        }
        String Capnhat = "";
        private void btnthem_Click(object sender, EventArgs e)
        {
            Capnhat = "T";
            enable_control(true, this);
            Cleartext();
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
                    if (txtma.Text == "" || txtten.Text == "")
                    {
                        MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string sqlcheckkey = "SELECT MaCV,ChucVu FROM ChucVu " +
                           "WHERE MaCV = '" + txtma.Text + "' AND ChucVu = '" + txtten.Text + "'";
                    if (function.CheckKey(sqlcheckkey) == true)
                    {
                        MessageBox.Show("Đã tồn tại chức vụ này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        sql = "INSERT INTO ChucVu VALUES('"
                        + txtma.Text.Trim() + "','"
                        + txtten.Text + "')";
                    }
                }
                else if (Capnhat == "S")
                {
                    if (txtma.Text == "" || txtten.Text == "")
                    {
                        MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    sql = "update  ChucVu set ChucVu='" + txtten.Text.Trim() +
                         "' where MaCV='" + txtma.Text.Trim() + "'";
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

        private void dtgcv_Click(object sender, EventArgs e)
        {
            txtma.Text = dtgcv.CurrentRow.Cells["MaCV"].Value.ToString();
            txtten.Text = dtgcv.CurrentRow.Cells["ChucVu"].Value.ToString();
        }

        private void dtgcv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete ChucVu where MaCV='" + txtma.Text + "'";
                function.Runsql(sql);
                Cleartext();
                Laydulieulengrid();

            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            Cleartext();
        }
    }
}
