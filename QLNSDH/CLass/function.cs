using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDCDKT.Function
{
    internal class function
    {
        public static SqlConnection con;
        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=k\\SQLEXPRESS;Initial Catalog=QLCHDH;Integrated Security=True";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                
            }
            else
            {
                MessageBox.Show("kết nối không thành công");
            }
        }
        // phương thức disconnect
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }
        // phương thức thực hiện select lấy dữ liệu
        public static DataTable Laydulieulengird(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(table);
            return table;
        }
        public static void OpenForm(Form fr,Form mdi)
        {
            fr=new Form();
            fr.MdiParent = mdi;
            fr.Show();
        }
        // phương thức thực hiện lệnh sql
        public static void Runsql(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;//gắn lệnh sql
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
       /* static public void enable_control(Boolean e, Form fr)
        {
            foreach (Control ctr in fr.Controls)
            {
                if (ctr.Name.StartsWith("txt") || ctr.Name.StartsWith("chk") || ctr.Name == "btnluu" || ctr.Name.StartsWith("cbo") || ctr.Name == "btnhuy")
                {
                    ctr.Enabled = e;

                }
                if (ctr.Name == "btnadd" || ctr.Name == "btnsua" || ctr.Name == "btnxoa" || ctr.Name == "btnanh")
                {
                    ctr.Enabled = !e;
                }
            }
        }*/
        // hàm đặt con tro trên grid
        static public void datcontro(DataGridView dgv, string ma)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
                if (dgv.Rows[i].Cells[0].Value.ToString().Trim() == ma.Trim())
                {
                    dgv.CurrentCell = dgv.Rows[i].Cells[0];
                }
        }
        public static bool CheckKey(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                return true;
            }
            else
                return false;
        }
        // Lấy giá trị trong đường dẫn
        public static string GetFieldValues(string sql)
        {
            string dulieu = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                dulieu = reader.GetValue(0).ToString();
            reader.Close();
            return dulieu;
        }
        public static void Fillcombo(string sql, ComboBox cbo, string ten, string ma)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            cbo.DataSource = tbl;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
       

    }
}

