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
    public partial class FormBAOCAOLUONG : Form
    {
        reportfunction rp;
        public FormBAOCAOLUONG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * " +
                "FROM ThanhToanLuong " +
                "WHERE Thang  like '%" + txtthang.Text + "%'or Nam like'%" + txttk.Text + "%'";
            rp = new reportfunction("DataSet1", "QLNSDH.RDLCform.ReportLUONG.rdlc", sql, reportViewer1);
            rp.handleShowReport();
        }

        private void FormBAOCAOLUONG_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
