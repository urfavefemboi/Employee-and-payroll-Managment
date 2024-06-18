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
    public partial class FormLUONG : Form
    {
        public FormLUONG()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtgl.Columns[0].HeaderText = "Mã lương";
            dtgl.Columns[1].HeaderText = "Mức lương";
            dtgl.Columns[0].Width = 100;
            dtgl.Columns[1].Width = 100;
            dtgl.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgl.AllowUserToAddRows = false;
        }
        public void Laydulieulengrid()
        {
            string sql = "select * from Luong";
            dtgl.DataSource = function.Laydulieulengird(sql);
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
            txtluong.Clear();
        }
        private void FormLUONG_Load(object sender, EventArgs e)
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
                    if (txtma.Text == "" || txtluong.Text == "")
                    {
                        MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string sqlcheckkey = "SELECT MaLuong,MucLuong FROM Luong " +
                           "WHERE MaLuong = '" + txtma.Text + "' AND MucLuong = '" + txtluong.Text + "'";
                    if (function.CheckKey(sqlcheckkey) == true)
                    {
                        MessageBox.Show("Đã tồn tại chức vụ này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        sql = "INSERT INTO Luong VALUES('"
                        + txtma.Text.Trim() + "','"
                        + txtluong.Text + "')";
                    }
                }
                else if (Capnhat == "S")
                {
                    if (txtma.Text == "" || txtluong.Text == "")
                    {
                        MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    sql = "update  Luong set MucLuong='" + txtluong.Text.Trim() +
                         "' where MaLuong='" + txtma.Text.Trim() + "'";
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

        private void dtgl_Click(object sender, EventArgs e)
        {
            txtma.Text = dtgl.CurrentRow.Cells["MaLuong"].Value.ToString();
            txtluong.Text = dtgl.CurrentRow.Cells["MucLuong"].Value.ToString();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            Cleartext();
        }

        private void dtgl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete Luong where MaLuong='" + txtma.Text + "'";
                function.Runsql(sql);
                Cleartext();
                Laydulieulengrid();

            }
        }
    }
}
