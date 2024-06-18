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
    public partial class FormHOPDONG : Form
    {
        public FormHOPDONG()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtghd.Columns[0].HeaderText = "Mã Hợp Đồng";
            dtghd.Columns[1].HeaderText = "Mã Nhân Viên";
            dtghd.Columns[2].HeaderText = "Ngày Ký";
            dtghd.Columns[3].HeaderText = "Hạn Hợp Đồng";
            dtghd.Columns[4].HeaderText = "Hiệu lực";
            for(int i=0;i<dtghd.Columns.Count;i++)
            {
                dtghd.Columns[i].Width = 100;
            }
            dtghd.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        public void Dulieuhopdong()
        {
            string sql = "Select * from HopDong";
            dtghd.DataSource = function.Laydulieulengird(sql);
            Dinhdangdulieu();
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name == "btnluu" || ctr.Name == "btnhuy" || ctr.Name.StartsWith("rdo") )
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
          
            txtma.Text = "";
            rdofalse.Checked = false;
            rdotrue.Checked = false;
           
        }
        public void Dulieuphongban()
        {
            function.Fillcombo("select MaPB from PhongBan", txtmaphong, "MaPB", "MaPB");

        }

        private void FormHOPDONG_Load(object sender, EventArgs e)
        {
            Dulieuhopdong();
            Dulieuphongban();
        }

        private void txtmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            function.Fillcombo("select MaNV from NhanVien where MaPB='" + txtmaphong.Text + "'", txtmanv, "MaNV", "MaNV");
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
            txtmaphong.Enabled = false;
            txtmanv.Enabled = false;
            txtma.Enabled = false;
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                string hieuluc = "";
                string sql = "";
                if(Capnhat=="T")
                {
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    if ((txthethan.Value.Year - txtky.Value.Year)<0)
                    {
                        MessageBox.Show("Ngày hạn hợp đồng không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                        txthethan.Focus();
                        return;
                    }
                    if(rdofalse.Checked==true)
                    {
                        hieuluc = "false";
                    }
                    else if(rdotrue.Checked==true) 
                    {
                    hieuluc = "true";
                    }
                    if (function.CheckKey("select MaHopDong from HopDong where MaHopDong='" + txtma.Text + "'"))
                    {
                        MessageBox.Show("Mã hợp đồng đã tồn tại đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                       sql= "Insert into HopDong values('" + txtma.Text + "','"
                        + txtmanv.Text + "','"
                        + txtky.Text + "','"
                        + txthethan.Text + "','" + hieuluc + "')";
                    }
                }
                else if(Capnhat=="S")
                {
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    if (rdofalse.Checked == true)
                    {
                        hieuluc = "false";
                    }
                    else if (rdotrue.Checked == true)
                    {
                        hieuluc = "true";
                    }
                 sql="update  HopDong  set MaNV='" + txtmanv.Text + "',Ngayky='" + txtky.Text
                        + "',HanHD='" + txthethan.Text + "',HieuLuc='" + hieuluc
                        + "' where MaHopDong='" + txtma.Text + "'";
                }
                function.Runsql(sql);
                enable_control(false, this);
                Dulieuhopdong();
                Cleartext();
            }
            catch(Exception ex)
            {
                MessageBox.Show(" " + ex, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            Cleartext();
        }

        private void dtghd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlhopdong;
                sqlhopdong = "delete HopDong where MaHopDong='" + txtma.Text + "'";
                function.Runsql(sqlhopdong);
                Cleartext();
                Dulieuhopdong();
            }
        }

        private void dtghd_Click(object sender, EventArgs e)
        {
            txtma.Text = dtghd.CurrentRow.Cells["MaHopDong"].Value.ToString();
            txtmanv.Text= dtghd.CurrentRow.Cells["MaNV"].Value.ToString();
            txtky.Text= dtghd.CurrentRow.Cells["NgayKy"].Value.ToString();
            txthethan.Text = dtghd.CurrentRow.Cells["HanHD"].Value.ToString();
            if(dtghd.CurrentRow.Cells["HieuLuc"].Value.Equals("true"))
            {
                rdotrue.Checked = true;
            }    
            else if(dtghd.CurrentRow.Cells["HieuLuc"].Value.Equals("false"))
            {
                rdofalse.Checked = false;
            }    
        }
    }
}
