using Microsoft.Reporting.WinForms;
using QLDCDKT.Function;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSDH.CLass
{
    internal class reportfunction
    {
        private SqlConnection connection;
        private string name;
        private string query;
        private ReportViewer reportViewer;
        private string file;
        public reportfunction()
        {

        }

        public reportfunction(string nameTable, string file, string query, ReportViewer reportViewer)
        {
            this.name = nameTable;
            this.file = file;
            this.query = query;
            this.connection = connection;
            this.reportViewer = reportViewer;

        }

        public void handleShowReport()
        {


            // Chuẩn bị câu truy vấn SQL kết hợp thông tin từ cả hai bảng
            string query = this.query;


            // Đặt nguồn dữ liệu cho reportViewer
            ReportDataSource reportDataSource = new ReportDataSource(this.name, function.Laydulieulengird(query));
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer.LocalReport.ReportEmbeddedResource = this.file; // Sử dụng đường dẫn tuyệt đối

            // Gán tên bảng trong báo cáo mẫu
            this.reportViewer.LocalReport.DataSources[0].Name = this.name; // Thay "YourTableName" bằng tên bảng trong báo cáo RDLC

            this.reportViewer.RefreshReport();

            // Đóng kết nối sau khi sử dụng

        }
    }
}
