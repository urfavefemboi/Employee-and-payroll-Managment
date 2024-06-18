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
    public partial class FormNHANVIEN : Form
    {
        public FormNHANVIEN()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtghs.Columns[0].HeaderText = "Mã Nhân viên";
            dtghs.Columns[1].HeaderText = "Mã Phòng Ban";
            dtghs.Columns[2].HeaderText = "Mã Chức Vụ";
            dtghs.Columns[3].HeaderText = "Họ Tên";
            dtghs.Columns[4].HeaderText = "Ngày Sinh";
            dtghs.Columns[5].HeaderText = "Giới Tính";
            dtghs.Columns[6].HeaderText = "CMND";
            dtghs.Columns[7].HeaderText = "Địa Chỉ";
            dtghs.Columns[8].HeaderText = "Điện Thoại";
            dtghs.Columns[9].HeaderText = "Số BHXH";
            dtghs.Columns[10].HeaderText = "Ảnh";
            for(int i=0;i<dtghs.Columns.Count;i++)
            {
                dtghs.Columns[i].Width = 120;
            }
            dtghs.EditMode= DataGridViewEditMode.EditProgrammatically;
            dtghs.AllowUserToAddRows= false;

        }
        public void Dulieuhoso()
        {
            string sql = "select * from NhanVien";
            dtghs.DataSource = function.Laydulieulengird(sql);
            Dinhdangdulieu();
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name == "btnluu" || ctr.Name == "btnhuy"|| ctr.Name.StartsWith("rdo")||ctr.Name=="btnanh")
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnthem" || ctr.Name == "btnsua")
                {
                    ctr.Enabled = !e;
                }
            }
        }
        public void Laydulieucombobox()
        {
            string sqlmapb = "select MaPB from PhongBan";
            function.Fillcombo(sqlmapb, txtmapb, "MaPB", "MaPB");
            string sqlmacv = "select MaCV from ChucVu";
            function.Fillcombo(sqlmacv, txtmacv, "MaCV", "MaCV");
            string sqlluong = "select MaLuong from Luong";
            function.Fillcombo(sqlluong, txtluong, "MaLuong", "MaLuong");
        }
        public void Cleartext()
        {
            foreach(Control ctr in this.Controls)
            {
               if( ctr.Name.StartsWith("txt"))
                {
                    ctr.Text = "";
                }    
            }
            
            rdonam.Checked = false;
            rdonu.Checked = false;
          
            pic1.ImageLocation = null;
        }
       
        private void FormNHANVIEN_Load(object sender, EventArgs e)
        {
            Dulieuhoso();
            Laydulieucombobox();
        }
        string Capnhat = "";
        private void btnthem_Click(object sender, EventArgs e)
        {
            Capnhat = "T";
            Cleartext();
            enable_control(true, this);
        }
       public string txtanh="";
        private void btnanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgopen.FilterIndex = 2;
            dlgopen.Title = "ch" +
                "ọn ảnh";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                pic1.Image = Image.FromFile(dlgopen.FileName);
                txtanh = dlgopen.FileName;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Capnhat = "S";
            enable_control(true, this);
            txtmanv.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                string gt = "";
                string sql = "";
                if (Capnhat == "T")
                {
                    if (rdonam.Checked == false && rdonu.Checked == false)
                    {
                        MessageBox.Show("Hãy chọn giới tính", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    if (rdonam.Checked)
                    {
                        gt = rdonam.Text;
                    }
                    else
                    {
                        gt = rdonu.Text;
                    }
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    if ((DateTime.Now.Year - txtngaysinh.Value.Year) < 16)
                    {
                        MessageBox.Show("Nhân viên chưa đủ 17 tuổi", "Thông báo", MessageBoxButtons.OK);
                        txtngaysinh.Focus();
                        return;
                    }
                    if (txtanh.Trim().Equals(""))
                    {
                        MessageBox.Show("Hãy chọn ảnh", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    if (function.CheckKey("select MaNV from NhanVien where MaNV='" + txtmanv.Text + "'"))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        sql = "Insert into NhanVien values('" + txtmanv.Text + "','"
                        + txtmapb.Text + "','" + txtluong.Text + "','"
                        + txtmacv.Text + "','"
                        + txtten.Text + "','" + txtngaysinh.Text + "','" + gt + "','" + txtcmnd.Text
                        + "','" + txtdc.Text + "','" + txtsdt.Text + "','" + txtbhxh.Text + "','"
                        + txtanh + "')";
                    }
                }
                else if (Capnhat == "S")
                {
                    if (rdonam.Checked == false && rdonu.Checked == false)
                    {
                        MessageBox.Show("Hãy chọn giới tính", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    if (rdonam.Checked)
                    {
                        gt = rdonam.Text;
                    }
                    else
                    {
                        gt = rdonu.Text;
                    }
                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr.Name.StartsWith("txt").Equals(""))
                        {
                            MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    if ((DateTime.Now.Year - txtngaysinh.Value.Year) < 16)
                    {
                        MessageBox.Show("Nhân viên chưa đủ 17 tuổi", "Thông báo", MessageBoxButtons.OK);
                        txtngaysinh.Focus();
                        return;
                    }
                    if (txtanh.Equals(""))
                    {
                        MessageBox.Show("Hãy chọn ảnh", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    sql = "update  NhanVien  set HoTen='" + txtten.Text + "',Gioitinh='" + gt
                        + "',Ngaysinh='" + txtngaysinh.Text + "',CMND='" + txtcmnd.Text
                        + "',Diachi='" + txtdc.Text + "',DienThoai='" + txtsdt.Text + "',MaLuong='" + txtluong.Text 
                        + "',MaCV='" + txtmacv.Text + "',MaPB='" + txtmapb.Text + "',SoBHXH='" + txtbhxh.Text
                        + "',Anh='" + txtanh.Trim() + "' where MaNV='" + txtmanv + "'";
                }
                function.Runsql(sql);
                Dulieuhoso();
                enable_control(false, this);
                Cleartext();
            }
            catch(Exception ex)
            {
                MessageBox.Show(" "+ex, "Thông báo", MessageBoxButtons.OK);
                return;
            }
            }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            Cleartext();
        }

        private void dtghs_Click(object sender, EventArgs e)
        {
            txtmanv.Text = dtghs.CurrentRow.Cells["MaNV"].Value.ToString();
            txtmapb.Text = dtghs.CurrentRow.Cells["MaPB"].Value.ToString();
            txtmacv.Text= dtghs.CurrentRow.Cells["MaCV"].Value.ToString();
            txtten.Text= dtghs.CurrentRow.Cells["HoTen"].Value.ToString();
            txtngaysinh.Text= dtghs.CurrentRow.Cells["NgaySinh"].Value.ToString();
            if(dtghs.CurrentRow.Cells["GioiTinh"].Value.ToString()=="F")
            {
                rdonu.Checked = true;
            }
            else if(dtghs.CurrentRow.Cells["GioiTinh"].Value.ToString()=="M")
            {
                rdonam.Checked = true;
            } 
            txtcmnd.Text= dtghs.CurrentRow.Cells["CMND"].Value.ToString();
            txtdc.Text= dtghs.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtsdt.Text= dtghs.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtbhxh.Text= dtghs.CurrentRow.Cells["SoBHXH"].Value.ToString();
            txtanh=function.GetFieldValues("select Anh from NhanVien where MaNV='"+txtmanv.Text+"'");
            pic1.ImageLocation = txtanh;
        }

        private void dtghs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql, sqlhopdong;
                sqlhopdong = "delete HopDong where MaNV='" + txtmanv.Text + "'";
                function.Runsql(sqlhopdong);
                sql = "delete NhanVien where MaNV='" + txtmanv.Text + "'";
                function.Runsql(sql);
                Cleartext();
                Dulieuhoso();
            }
        }
    }
}
