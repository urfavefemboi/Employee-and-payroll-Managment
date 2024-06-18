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
    public partial class FormNGHIPHEP : Form
    {
        public FormNGHIPHEP()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {      
                dtgnp.Columns[0].HeaderText = "Mã Nghỉ";
                dtgnp.Columns[1].HeaderText = "Mã Nhân Viên";
                dtgnp.Columns[2].HeaderText = "Ngày Nghỉ";
                dtgnp.Columns[3].HeaderText = "Nghỉ Đến";
                dtgnp.Columns[4].HeaderText = "Lí Do";
                dtgnp.Columns[5].HeaderText = "Hưởng Lương";
            for (int i = 0; i < dtgnp.Columns.Count; i++)
            {
                dtgnp.Columns[i].Width = 100;
            }
            dtgnp.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        public void Dulieunghiphep()
        {
            string sql = "Select * from NghiPhep";
            dtgnp.DataSource = function.Laydulieulengird(sql);
            Dinhdangdulieu();
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name == "btnluu" || ctr.Name == "btnhuy" || ctr.Name.StartsWith("rdo"))
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnthem" || ctr.Name == "btnsua")
                {
                    ctr.Enabled = !e;
                }
            }
        }
        private void FormNGHIPHEP_Load(object sender, EventArgs e)
        {
            Dulieunghiphep();
            Dulieuphongban();
        }
        public void Cleartext()
        {

            txtma.Text = "";
            rdofalse.Checked = false;
            txtlido.Text = "";
            rdotrue.Checked = false;

        }
        public void Dulieuphongban()
        {
            function.Fillcombo("select MaPB from PhongBan", txtmaphong, "MaPB", "MaPB");

        }
        string Capnhat = "";
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
            txtmaphong.Enabled = false;
            txtmanv.Enabled = false;
           
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                string hieuluc = "";
                string sql = "";
                if (Capnhat == "T")
                {
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    if ((txthethan.Value.DayOfWeek - txtnghi.Value.DayOfWeek) < 0 || (txthethan.Value.Year - txtnghi.Value.Year) < 0)
                    {
                        MessageBox.Show("Ngày nghỉ không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                        txthethan.Focus();
                        return;
                    }
                    if (rdofalse.Checked == true)
                    {
                        hieuluc = "false";
                    }
                    else if (rdotrue.Checked == true)
                    {
                        hieuluc = "true";
                    }
                    if (function.CheckKey("select MaNghi from NghiPhep where MaNghi='" + txtma.Text + "'"))
                    {
                        MessageBox.Show("Mã nghỉ đã tồn tại đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        sql = "Insert into NghiPhep values('" + txtma.Text + "','"
                         + txtmanv.Text + "','"
                         + txtnghi.Text + "','"
                         + txthethan.Text + "','" + txtlido.Text + "','" + hieuluc + "')";
                    }
                }
                else if (Capnhat == "S")
                {
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    if ((txthethan.Value.DayOfWeek - txtnghi.Value.DayOfWeek) < 0 || (txthethan.Value.Year - txtnghi.Value.Year) < 0)
                    {
                        MessageBox.Show("Ngày nghỉ không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                        txthethan.Focus();
                        return;
                    }
                    if (rdofalse.Checked == true)
                    {
                        hieuluc = "false";
                    }
                    else if (rdotrue.Checked == true)
                    {
                        hieuluc = "true";
                    }
                    sql = "update  NghiPhep  set MaNV='" + txtmanv.Text + "',NgayNghi='" + txtnghi.Text
                           + "',NghiDen='" + txthethan.Text + "',HuongLuong='" + hieuluc
                           + "',LiDo='" + txtlido.Text
                           + "' where MaNghi='" + txtma.Text + "'";
                }
                function.Runsql(sql);
                enable_control(false, this);
                Dulieunghiphep();
                Cleartext();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(" " + ex, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void txtmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            function.Fillcombo("select MaNV from NhanVien where MaPB='" + txtmaphong.Text + "'", txtmanv, "MaNV", "MaNV");
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            Cleartext();
        }

        private void dtgnp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlhopdong;
                sqlhopdong = "delete NghiPhep where MaNghi='" + txtma.Text + "'";
                function.Runsql(sqlhopdong);
                Cleartext();
                Dulieunghiphep() ;
            }
        }

        private void dtgnp_Click(object sender, EventArgs e)
        {
            txtma.Text = dtgnp.CurrentRow.Cells["MaNghi"].Value.ToString();
            txtmanv.Text = dtgnp.CurrentRow.Cells["MaNV"].Value.ToString();
            txtnghi.Text = dtgnp.CurrentRow.Cells["NgayNghi"].Value.ToString();
            txthethan.Text = dtgnp.CurrentRow.Cells["NghiDen"].Value.ToString();
            if (dtgnp.CurrentRow.Cells["HuongLuong"].Value.Equals("true"))
            {
                rdotrue.Checked = true;
            }
            else if (dtgnp.CurrentRow.Cells["HuongLuong"].Value.Equals("false"))
            {
                rdofalse.Checked = false;
            }
        }
    }
}
