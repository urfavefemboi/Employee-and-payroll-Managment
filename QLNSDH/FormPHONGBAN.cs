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
    public partial class FormPHONGBAN : Form
    {
        public FormPHONGBAN()
        {
            InitializeComponent();
        }
        public void Dinhdangdulieu()
        {
            dtgpb.Columns[0].HeaderText = "Mã phòng ban";
            dtgpb.Columns[1].HeaderText = "Tên phòng ban";
            dtgpb.Columns[0].Width = 100;
            dtgpb.Columns[1].Width = 100;
        }
        public void Laydulieulengrid()
        {
            string sql = "select * from PhongBan";           
            dtgpb.DataSource= function.Laydulieulengird(sql);
            Dinhdangdulieu();
        }
         static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") ||  ctr.Name == "btnluu" ||  ctr.Name == "btnhuy")
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnthem" || ctr.Name == "btnsua" )
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

        private void FormPHONGBAN_Load(object sender, EventArgs e)
        {
           Laydulieulengrid();
        }

        private void dtgpb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            enable_control(true,this);
            txtma.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                string sql="";
                if (Capnhat == "T")
                {
                    if (txtma.Text == ""|| txtten.Text=="")
                    {
                        MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string sqlcheckkey = "SELECT MaPB,TenPB FROM PhongBan " +
                           "WHERE MaPB = '" + txtma.Text + "' AND TenPB = '" + txtten.Text + "'";
                    if(function.CheckKey(sqlcheckkey)==true) {
                        MessageBox.Show("Đã tồn tại phòng ban này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        sql = "INSERT INTO PhongBan VALUES('"
                        + txtma.Text.Trim() + "','"
                        + txtten.Text + "')";
                    }
                }
                else if(Capnhat == "S")
                {
                    if (txtma.Text == "" || txtten.Text == "")
                    {
                        MessageBox.Show("Ko được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    sql = "update  PhongBan set TenPB='" + txtten.Text.Trim() +
                         "' where MaPB='" + txtma.Text.Trim() + "'";
                }
                function.Runsql(sql);
                enable_control(false, this);
                Laydulieulengrid();
                Cleartext();
                
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgpb_Click(object sender, EventArgs e)
        {
            txtma.Text = dtgpb.CurrentRow.Cells["MaPB"].Value.ToString();
            txtten.Text= dtgpb.CurrentRow.Cells["TenPB"].Value.ToString();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            enable_control(false, this);
            Cleartext();
        }

        private void dtgpb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                sql = "delete PhongBan where MaPB='" + txtma.Text + "'";
                function.Runsql(sql);
                Cleartext();
                Laydulieulengrid();

            }
        }
    }
}
