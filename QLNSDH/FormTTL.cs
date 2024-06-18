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
    public partial class FormTTL : Form
    {
        public FormTTL()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtgttl.Columns[0].HeaderText = "Mã Thanh Toán Lương";
            dtgttl.Columns[1].HeaderText = "Mã Nhân Viên";
            dtgttl.Columns[2].HeaderText = "Mã Chấm Công";
            dtgttl.Columns[3].HeaderText = "Tháng";
            dtgttl.Columns[4].HeaderText = "Năm";
            dtgttl.Columns[5].HeaderText = "Khấu Trừ Bảo Hiểm";
            dtgttl.Columns[6].HeaderText = "Lĩnh Lương";
            dtgttl.Columns[7].HeaderText = "Mã Lương";
            for (int i = 0; i < dtgttl.Columns.Count; i++)
            {
                dtgttl.Columns[i].Width = 120;
            }
            dtgttl.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgttl.AllowUserToAddRows = false;          
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
        public void Laydulieucombobox()
        {
            string sqlpb = "select MaPB from PhongBan";
            function.Fillcombo(sqlpb, txtmaphong, "MaPB", "MaPB");

        }
        public void LayDulieuTTL()
        {
            string sql = "select * from ThanhToanLuong";
            dtgttl.DataSource = function.Laydulieulengird(sql);
            Dinhdangdulieu();
        }
        public void Cleartext()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.Name.StartsWith("txt"))
                {
                    ctr.Text = "";
                }
            }
            
        }
        private void FormTTL_Load(object sender, EventArgs e)
        {
            LayDulieuTTL();
            Laydulieucombobox();
        }

        private void txtmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlnv = "select MaNV from NhanVien";
            function.Fillcombo(sqlnv, txtmanv, "MaNV", "MaNV");
        }

        private void txtmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy dữ liệu mã công từ bảng chấm công
            string sqlmacong = "select MaCong from ChamCong where MaNV='"+txtmanv.Text+"'";
            function.Fillcombo(sqlmacong, txtmacc, "MaCong", "MaCong");
            // lấy dữ liệu mã lương từ bảng nhân viên
            string sqlmaluong = "select MaLuong from NhanVien where MaNV='"+txtmanv.Text+"'";
            maluong.Text = function.GetFieldValues(sqlmaluong);
        }

        private void txtmacc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy dữ liệu tháng từ mã công
            string sqlthang = "select Thang from ChamCong where MaCong='" + txtmacc.Text + "'";
            thang.Text = function.GetFieldValues(sqlthang);
            // lấy dữ liệu năm từ mã công
            string sqlnam = "select Nam from ChamCong where MaCong='" + txtmacc.Text + "'";
            nam.Text = function.GetFieldValues(sqlnam);
            // lấy dữ liệu số ngày công từ mã công
            string sqlngaycong = "select NgayCong from ChamCong where MaCong='" + txtmacc.Text + "'";
            ngaycong.Text = function.GetFieldValues(sqlngaycong);
            // lấy dữ liệu ngày nghỉ hưởng lương từ mã công
            string sqlhl = "select NgayNghiHL from ChamCong where MaCong='" + txtmacc.Text + "'";
            hl.Text = function.GetFieldValues(sqlhl);
        }
        string Capnhat = "";
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
            txtmanv.Enabled = false;
        }
      
        private void txtbaohiem_TextChanged(object sender, EventArgs e)
        {
            double tongtien,cong,nghihl,baohiem,hsl,tienlinhluong;
           
            if(txtbaohiem.Text=="")
            {
                tongtien = 0;
                baohiem = 0;
                hsl = 0;
                cong = 0;
                nghihl = 0;
            }    
            else
            {
                string sql = "select MucLuong from Luong where MaLuong='" + maluong.Text + "'";
                hsl = Convert.ToDouble(function.GetFieldValues(sql));
                baohiem =Math.Round(Convert.ToDouble(txtbaohiem.Text),1);
                cong = double.Parse(ngaycong.Text);
                nghihl = double.Parse(hl.Text);
                baohiem = Convert.ToDouble(txtbaohiem.Text);             
            }
            tongtien = (cong + nghihl) * (160000) * (hsl);
            baohiem = tongtien * baohiem;
            tienlinhluong = Math.Round((tongtien - baohiem),1);
            ll.Text = tienlinhluong.ToString();


        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
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
                    if (function.CheckKey("select MaCong from ThanhToanLuong where MaCong='" + txtmacc.Text +"'" ))
                    {
                        MessageBox.Show("Mã chấm công đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        sql = "Insert into ThanhToanLuong values('" + txtmattl.Text + "','"
                        + txtmanv.Text + "','" + txtmacc.Text + "','"
                        + thang.Text + "','"
                        + nam.Text + "','" + txtbaohiem.Text + "','" + ll.Text+ "','" + maluong.Text+ "')";
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
                

                    sql = "update  ThanhToanLuong  set MaNV='" + txtmanv.Text
                        + "',MaCong='" + txtmacc.Text + "',KhauTruBH='" + txtbaohiem.Text
                        + "',Thang='" + thang.Text + "',Nam='" + nam.Text
                        + "',LinhLuong='" + ll.Text + "',MaLuong='" + maluong.Text
                       + "' where MaTTL='" + txtmattl.Text + "'";
                }
                function.Runsql(sql);
                LayDulieuTTL();
                enable_control(false, this);
                Cleartext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void dtgttl_Click(object sender, EventArgs e)
        {
            txtmacc.Text = dtgttl.CurrentRow.Cells["MaCong"].Value.ToString();
            txtmanv.Text = dtgttl.CurrentRow.Cells["MaNV"].Value.ToString();
            txtmattl.Text = dtgttl.CurrentRow.Cells["MaTTL"].Value.ToString();

        }

        private void dtgttl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete ThanhToanLuong where MaTTL='" + txtmattl.Text + "'";
                function.Runsql(sql);
                Cleartext();
                LayDulieuTTL();
            }
        }
    }
}
