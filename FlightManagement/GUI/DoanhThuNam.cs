using FlightManagement.Controller;
using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement
{
    public partial class DoanhThuNam : Form
    {
        public DoanhThuNam()
        {
            InitializeComponent();
            txtTongDT_BCDTN.BackColor = DefaultBackColor;
            txtTongDT_BCDTN.ForeColor = Color.Red;
            txtThang_BCDTN.BackColor = DefaultBackColor;
            txtThang_BCDTN.ForeColor = Color.Red;
            txtTongDT_BCDTN.ReadOnly = true;
            txtThang_BCDTN.ReadOnly = true;
            dtgvCTDT_BCDTN.Columns[0].Visible = false;

        }

        private void btnBaoCao_DTNam_Click_1(object sender, EventArgs e)
        {
            chartDoanhThu.Series["DoanhThu"].Points.Clear();
            chartTyle.Series["TyLe"].Points.Clear();
            Regex reg = new Regex("^[2]{1}[0-9]{3}$");
            if (txtNam_BCDTN.Text == "")
            {
                
                DateTime x = DateTime.Now;
                int namhientai = int.Parse(x.Year.ToString());
                int namtruoc = namhientai - 1;
                MessageBox.Show("Bạn không nhập năm nên hệ thống sẽ in ra doanh thu năm trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable table = DataProvider.Instance.ExecuteQuery("exec BAOCAODOANHTHUNAM " + namtruoc);
                dtgvCTDT_BCDTN.DataSource = table;
                string Max_dt = DataProvider.Instance.ExecuteQuery("EXEC GETMAXDOANHTHUTHANG " + namtruoc).Rows[0][0].ToString();
                txtThang_BCDTN.Text = Max_dt.ToString();
                txtThang_BCDTN.ForeColor = Color.Red;

                double Sum_dt = double.Parse(DataProvider.Instance.ExecuteQuery("EXEC SUMDTNAM " + namtruoc).Rows[0][0].ToString());
                CultureInfo culture = new CultureInfo("vi-VN");
                txtTongDT_BCDTN.Text = Sum_dt.ToString("c",culture);
                List<CTDTNam> listDTNam = CTDTNamController.Instance.listDTThang(namtruoc);
                chartTyle.DataSource = listDTNam;
                chartTyle.Series["TyLe"].XValueMember = "Thang";
                chartTyle.Series["TyLe"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartTyle.Series["TyLe"].YValueMembers = "Tylethang1";
                chartTyle.Series["TyLe"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    chartDoanhThu.Series["DoanhThu"].Points.AddXY(table.Rows[i]["Thang"], table.Rows[i]["TongDT_Thang"]);
                }


            }
            else if (!reg.IsMatch(txtNam_BCDTN.Text))
            {
                errorNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorNam.SetError(txtNam_BCDTN, "Năm bạn nhập không hợp lệ");
            }
            else if (int.Parse(txtNam_BCDTN.Text) > DateTime.Now.Year)
            {
                errorNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorNam.SetError(txtNam_BCDTN, "Năm bạn nhập lớn hơn năm hiện tại");
            }
            else
            {
                int nam = int.Parse((txtNam_BCDTN.Text));
                DataTable table = DataProvider.Instance.ExecuteQuery("exec BAOCAODOANHTHUNAM " + nam);
                List<CTDTNam> listDTNam = CTDTNamController.Instance.listDTThang(nam);
                int flag = 0;
                foreach (CTDTNam item in listDTNam)
                {
                    if (item.Tong_dt_thang != 0)
                        flag = 1;
                }
                    
                if (flag == 1)
                {

                    dtgvCTDT_BCDTN.DataSource = table;
                    string Max_dt = DataProvider.Instance.ExecuteQuery("EXEC GETMAXDOANHTHUTHANG " + nam).Rows[0][0].ToString();
                    CultureInfo culture = new CultureInfo("vi-VN");
                    txtThang_BCDTN.Text = Max_dt.ToString();
                    txtThang_BCDTN.ForeColor = Color.Red;

                    double Sum_dt = double.Parse(DataProvider.Instance.ExecuteQuery("EXEC SUMDTNAM " + nam).Rows[0][0].ToString());
                    txtTongDT_BCDTN.Text = Sum_dt.ToString("c", culture);
                    chartTyle.DataSource = listDTNam;
                    chartTyle.Series["TyLe"].XValueMember = "Thang";
                    chartTyle.Series["TyLe"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                    chartTyle.Series["TyLe"].YValueMembers = "Tylethang1";
                    chartTyle.Series["TyLe"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                    chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                    chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        chartDoanhThu.Series["DoanhThu"].Points.AddXY(table.Rows[i]["Thang"], table.Rows[i]["TongDT_Thang"]);
                    }
                    
                }
                else
                {
                    
                    chartDoanhThu.Series["DoanhThu"].Points.Clear();
                    chartTyle.Series["TyLe"].Points.Clear();
                    txtTongDT_BCDTN.Text = "";
                    txtThang_BCDTN.Text = "";
                    dtgvCTDT_BCDTN.Columns.Clear();
                    MessageBox.Show("Hiện tại chưa có doanh thu tháng nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                    
                
            }
        }


        private void btnThoat_DTNam_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnXuatFile_baocaonam_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[2]{1}[0-9]{3}$");
            if (txtNam_BCDTN.Text == "")
            {
                DateTime x = DateTime.Now;
                int namhientai = int.Parse(x.Year.ToString());
                int namtruoc = namhientai - 1;
                DataTable table = DataProvider.Instance.ExecuteQuery("exec BAOCAODOANHTHUNAM " + namtruoc);
                txtNam_BCDTN.Text = namtruoc.ToString();
                ReportYear baocaonam = new ReportYear();
                baocaonam.SetDataSource(table);
                BaoCao frmbaocaothang = new BaoCao();
                frmbaocaothang.crystalReportViewer1.ReportSource = baocaonam;
                frmbaocaothang.ShowDialog();
            }
            else if (!reg.IsMatch(txtNam_BCDTN.Text))
            {
                errorNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorNam.SetError(txtNam_BCDTN, "Năm bạn nhập không hợp lệ");
            }
            else if (int.Parse(txtNam_BCDTN.Text) > DateTime.Now.Year)
            {
                errorNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorNam.SetError(txtNam_BCDTN, "Năm bạn nhập lớn hơn năm hiện tại");
            }
            else
            {

                int nam = int.Parse(txtNam_BCDTN.Text.ToString());
                DataTable table = DataProvider.Instance.ExecuteQuery("exec BAOCAODOANHTHUNAM " + nam);
                ReportYear baocaonam = new ReportYear();
                baocaonam.SetDataSource(table);
                BaoCao frmbaocaothang = new BaoCao();
                frmbaocaothang.crystalReportViewer1.ReportSource = baocaonam;
                frmbaocaothang.ShowDialog();
            }
        }

        private void btnClose_DTNam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoanhThuNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                btnXuatFile_baocaonam_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnThoat_DTNam_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.F)
            {
                btnBaoCao_DTNam_Click_1(this, new EventArgs());
            }

        }

        private void txtNam_DTNam_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNam_BCDTN.Text))
            {
                errorNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errorNam.SetError(txtNam_BCDTN, "Năm bạn nhập không hợp lệ");
            }   
            else
            {
                errorNam.SetError(txtNam_BCDTN, "");
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}