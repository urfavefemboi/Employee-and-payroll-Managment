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
    public partial class FormCHAMCONG : Form
    {
        public FormCHAMCONG()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtgcc.Columns[0].HeaderText = "Mã Chấm Công";
            dtgcc.Columns[1].HeaderText = "Mã Nhân Viên";
            dtgcc.Columns[2].HeaderText = "Ngày Công";
            dtgcc.Columns[3].HeaderText = "Ngày Nghỉ Hưởng Lương";
            dtgcc.Columns[4].HeaderText = "Tháng";
            dtgcc.Columns[5].HeaderText = "Năm";        
            for (int i = 0; i < dtgcc.Columns.Count; i++)
            {
                dtgcc.Columns[i].Width = 120;
            }
            dtgcc.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgcc.AllowUserToAddRows = false;
            txtthang.SelectedIndex = 0;
        }
        public void LayDulieuChamCong()
        {
            string sql = "select * from ChamCong";
            dtgcc.DataSource = function.Laydulieulengird(sql);
            Dinhdangdulieu();
        }
        static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name == "btnluu" || ctr.Name == "btnhuy" )
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

        private void FormCHAMCONG_Load(object sender, EventArgs e)
        {
            LayDulieuChamCong();
            Laydulieucombobox();
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
            txtthang.SelectedIndex = 0;      
        }
        public void NgayNghiHL()
        {
                  
            string sql = "SELECT ISNULL(DATEDIFF(day, NgayNghi, NghiDen),0)" +
                " AS DaysToShip FROM NghiPhep" +
                " where MaNV='" + txtmanv.Text + "' and HuongLuong='true'" +
                " and MONTH(NgayNghi)='" + txtthang.Text + "'and YEAR(NgayNghi)='"+txtnam.Text+"'";
           hl.Text = function.GetFieldValues(sql);
            
             
        }
        private void txtmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlma = "select MaNV from NhanVien";
            function.Fillcombo(sqlma, txtmanv, "MaNV", "MaNV");
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

        private void txtthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            NgayNghiHL();
        }

        private void txtnam_TextChanged(object sender, EventArgs e)
        {
            NgayNghiHL();
        }

        private void txthl_TextChanged(object sender, EventArgs e)
        {
            if(hl.Text=="")
            {
                hl.Text="0";
            }    
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
                    if (int.Parse(txtngaycong.Text) - int.Parse(hl.Text) < 0)
                    {
                        MessageBox.Show("Ngày chấm công không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                        txtngaycong.Focus();
                        return;
                    }
                    if (function.CheckKey("select Thang,Nam from ChamCong where MaNV='" + txtmanv.Text + "'" +
                      "and Thang='" + txtthang.Text + "'and Nam='" + txtnam.Text + "'"))
                    {
                        MessageBox.Show("Mã chấm công hoặc tháng, năm đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        sql = "Insert into ChamCong values('" + txtmacc.Text + "','"
                        + txtmanv.Text + "','" + txtngaycong.Text + "','"
                        + hl.Text + "','"
                        + txtthang.Text + "','" + txtnam.Text + "')";
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
                    if (int.Parse(txtngaycong.Text) - int.Parse(hl.Text) < 0)
                    {
                        MessageBox.Show("Ngày chấm công không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                        txtngaycong.Focus();
                        return;
                    }
           
                        sql = "update  ChamCong  set MaNV='" + txtmanv.Text 
                            + "',NgayCong='" + txtngaycong.Text + "',NgayNghiHL='" + hl.Text
                            + "',Thang='" + txtthang.Text + "',Nam='" + txtnam.Text 
                           + "' where MaCong='" + txtmacc.Text + "'";                   
                }
                function.Runsql(sql);
                LayDulieuChamCong();
                enable_control(false, this);
                Cleartext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void dtgcc_Click(object sender, EventArgs e)
        {
            txtmacc.Text = dtgcc.CurrentRow.Cells["MaCong"].Value.ToString();
            txtmanv.Text = dtgcc.CurrentRow.Cells["MaNV"].Value.ToString();
            txtngaycong.Text = dtgcc.CurrentRow.Cells["NgayCong"].Value.ToString();
            hl.Text = dtgcc.CurrentRow.Cells["NgayNghiHL"].Value.ToString();
            txtthang.Text = dtgcc.CurrentRow.Cells["Thang"].Value.ToString();
            txtnam.Text = dtgcc.CurrentRow.Cells["Nam"].Value.ToString();         
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            Cleartext();
        }

        private void dtgcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql, sqlttl;
                sqlttl = "delete ThanhToanLuong where MaCong='" + txtmacc.Text + "'";
                function.Runsql(sqlttl);
                sql = "delete ChamCong where MaCong='" + txtmacc.Text + "'";
                function.Runsql(sql);
                Cleartext();
                LayDulieuChamCong();
            }
        }
    }
}
