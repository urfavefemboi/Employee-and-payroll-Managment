using QLNSDH.CLass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using QLDCDKT.Function;


namespace QLNSDH
{
    public partial class FormBAOCAONHANVIEN : Form
    {
        reportfunction rp;
        public FormBAOCAONHANVIEN()
        {
            InitializeComponent();
        }
       

        private void FormBAOCAONHANVIEN_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaNV,MaPB,MaLuong,MaCV,HoTen,NgaySinh,GioiTinh,CMND,DiaChi,DienThoai,SoBHXH " +
                "FROM NhanVien " +
                "WHERE MaNV like '%" + txttk.Text + "%'or HoTen like'%"+txttk.Text+"%'";
            rp = new reportfunction("DataSet1", "QLNSDH.RDLCform.ReportNHANVIEN.rdlc", sql, reportViewer1);
            rp.handleShowReport();
        }
    }
}
