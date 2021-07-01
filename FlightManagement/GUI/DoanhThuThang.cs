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
    public partial class DoanhThuThang : Form
    {
        public DoanhThuThang()
        {
            InitializeComponent();
            txtTongDT_BCDTT.BackColor = DefaultBackColor;
            txtMCB_BCDTT.ForeColor = Color.Red;
            txtMCB_BCDTT.BackColor = DefaultBackColor;
            txtTongDT_BCDTT.ForeColor = Color.Red;
            txtTongDT_BCDTT.ReadOnly = true;
            txtMCB_BCDTT.ReadOnly = true;
            dtgvCTDT_BCDTT.Columns[1].Visible = false;
            dtgvCTDT_BCDTT.Columns[2].Visible = false;
        }


        private void btnBaoCao_DTThang_Click_1(object sender, EventArgs e)
        {
            chart1.Series["DoanhThu"].Points.Clear();
            chartTyLe.Series["TyLe"].Points.Clear();
            Regex reg = new Regex("^[2]{1}[0-9]{3}$");
            if (cbbThang_BCDTT.SelectedIndex == -1 || string.IsNullOrEmpty(txtNam_BCDTT.Text))
            {
                if (cbbThang_BCDTT.SelectedIndex == -1 && string.IsNullOrEmpty(txtNam_BCDTT.Text))
                {
                    int a = DateTime.Now.Month;
                    a = a - 1;
                    int b = DateTime.Now.Year;
                    MessageBox.Show("Bạn không nhập thông tin nên hệ thống sẽ xuất ra thông tin doanh thu tháng " + a + " năm " + b, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable table = DataProvider.Instance.ExecuteQuery("exec TONGDOANHTHUTHANG " + a + "," + b);
                    if (table.Rows.Count > 0)
                    {
                        dtgvCTDT_BCDTT.DataSource = table;
                        string Max_dt = DataProvider.Instance.ExecuteQuery("EXEC GETMAXDOANHTHUCB " + a + "," + b).Rows[0][0].ToString();
                        txtMCB_BCDTT.Text = Max_dt.ToString();

                        double Sum_dt = double.Parse(DataProvider.Instance.ExecuteQuery("EXEC SUMDTTHANG " + a + "," + b).Rows[0][0].ToString());
                        CultureInfo culture = new CultureInfo("vi-VN");
                        txtTongDT_BCDTT.Text = Sum_dt.ToString("c", culture);
                        List<CTDTThang> listDTThang = CTDTThangController.Instance.ListCB_BCThang(a, b);
                        chartTyLe.DataSource = listDTThang;
                        chartTyLe.Series["TyLe"].XValueMember = "Macb";
                        chartTyLe.Series["TyLe"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                        chartTyLe.Series["TyLe"].YValueMembers = "Tyletungchuyenbay";
                        chartTyLe.Series["TyLe"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                        chart1.ChartAreas["ChartArea1"].AxisX.Title = "Chuyến bay";
                        chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            chart1.Series["DoanhThu"].Points.AddXY(table.Rows[i]["MaChuyenBay"], table.Rows[i]["DoanhThu"]);
                        }
                    }
                    else
                    {
                        dtgvCTDT_BCDTT.Columns.Clear();
                        chart1.Series["DoanhThu"].Points.Clear();
                        chartTyLe.Series["TyLe"].Points.Clear();
                        txtTongDT_BCDTT.Text = "";
                        txtMCB_BCDTT.Text = "";
                        MessageBox.Show("Hiện tại chưa có chuyến bay nào trong tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                        

                }
                else if (cbbThang_BCDTT.SelectedIndex == -1)
                {
                    errThang.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errThang.SetError(cbbThang_BCDTT, "Bạn hãy nhập tháng vào");
                }
                else
                {
                    errNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errNam.SetError(txtNam_BCDTT, "Bạn hãy nhập năm vào");
                }

            }
            else if (!reg.IsMatch(txtNam_BCDTT.Text))
            {
                errNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errNam.SetError(txtNam_BCDTT, "Năm bạn nhập vào chưa hợp lệ");
            }
          
            else
            {
                int a = int.Parse(cbbThang_BCDTT.SelectedItem.ToString());
                int b = int.Parse(txtNam_BCDTT.Text);
                DataTable table = DataProvider.Instance.ExecuteQuery("exec TONGDOANHTHUTHANG " + a + "," + b);
                
                if (table.Rows.Count > 0)
                {

                    dtgvCTDT_BCDTT.DataSource = table;
                    string Max_dt = DataProvider.Instance.ExecuteQuery("EXEC GETMAXDOANHTHUCB " + a + "," + b).Rows[0][0].ToString();
                    txtMCB_BCDTT.Text = Max_dt.ToString();

                    double Sum_dt = double.Parse(DataProvider.Instance.ExecuteQuery("EXEC SUMDTTHANG " + a + "," + b).Rows[0][0].ToString());
                    CultureInfo culture = new CultureInfo("vi-VN");
                    txtTongDT_BCDTT.Text = Sum_dt.ToString("c",culture);
                    List<CTDTThang> listDTThang = CTDTThangController.Instance.ListCB_BCThang(a, b);
                    chartTyLe.DataSource = listDTThang;
                    chartTyLe.Series["TyLe"].XValueMember = "Macb";
                    chartTyLe.Series["TyLe"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chartTyLe.Series["TyLe"].YValueMembers = "Tyletungchuyenbay";
                    chartTyLe.Series["TyLe"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Chuyến bay";
                    chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        chart1.Series["DoanhThu"].Points.AddXY(table.Rows[i]["MaChuyenBay"], table.Rows[i]["DoanhThu"]);
                    }
                }
                else
                {
                    dtgvCTDT_BCDTT.Columns.Clear();
                    chart1.Series["DoanhThu"].Points.Clear();
                    chartTyLe.Series["TyLe"].Points.Clear();
                    txtTongDT_BCDTT.Text = "";
                    txtMCB_BCDTT.Text = "";
                    MessageBox.Show("Hiện tại chưa có chuyến bay nào trong tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }
        }

      

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnXuatfile_baocaothang_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[2]{1}[0-9]{3}$");
            if (cbbThang_BCDTT.SelectedIndex == -1 || string.IsNullOrEmpty(txtNam_BCDTT.Text))
            {
                if (cbbThang_BCDTT.SelectedIndex == -1 && string.IsNullOrEmpty(txtNam_BCDTT.Text))
                {
                    int a = DateTime.Now.Month;
                    a = a - 1;
                    int b = DateTime.Now.Year;
                    DataTable table = DataProvider.Instance.ExecuteQuery("exec TONGDOANHTHUTHANG " + a + "," + b);
                    ReportMonth baocaothang = new ReportMonth();
                    baocaothang.SetDataSource(table);
                    BaoCao frmbaocaothang = new BaoCao();
                    frmbaocaothang.crystalReportViewer1.ReportSource = baocaothang;
                    frmbaocaothang.ShowDialog();
                }
                else if (cbbThang_BCDTT.SelectedIndex == -1)
                {
                    errThang.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errThang.SetError(cbbThang_BCDTT, "Bạn hãy nhập tháng vào");
                }
                else
                {
                    errNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                    errNam.SetError(txtNam_BCDTT, "Bạn hãy nhập năm vào");
                }

            }
            else if (!reg.IsMatch(txtNam_BCDTT.Text))
            {
                errNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errNam.SetError(txtNam_BCDTT, "Năm bạn nhập vào chưa hợp lệ");
            }
            else if (int.Parse(txtNam_BCDTT.Text) > DateTime.Now.Year)
            {
                errNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errNam.SetError(txtNam_BCDTT, "Năm bạn nhập lớn hơn năm hiện tại");
            }
            else
            {
                int thang = int.Parse(cbbThang_BCDTT.Text.ToString());
                int nam = int.Parse(txtNam_BCDTT.Text.ToString());
                DataTable table = DataProvider.Instance.ExecuteQuery("exec TONGDOANHTHUTHANG " + thang + "," + nam);
                ReportMonth baocaothang = new ReportMonth();
                baocaothang.SetDataSource(table);
                BaoCao frmbaocaothang = new BaoCao();
                frmbaocaothang.crystalReportViewer1.ReportSource = baocaothang;
                frmbaocaothang.ShowDialog();
            }
        }

        private void cbThang_DTThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThang_BCDTT.SelectedIndex == -1)
            {
                errThang.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errThang.SetError(cbbThang_BCDTT, "Bạn hãy nhập tháng vào");
            }
            else
            {
                errThang.SetError(cbbThang_BCDTT, "");

            }

        }

        private void txtNam_DTThang_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (string.IsNullOrEmpty(txtNam_BCDTT.Text))
            {
                errNam.SetError(txtNam_BCDTT, "");
            }
            else if (reg.IsMatch(txtNam_BCDTT.Text) == false)
            {
                errNam.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                errNam.SetError(txtNam_BCDTT, "Tỷ lệ phải là các kí tự số");
            }
            else
            {
                errNam.SetError(txtNam_BCDTT, "");
            }
        }

        private void btnClose_DTThang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
                    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoanhThuThang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                btnXuatfile_baocaothang_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                bunifuThinButton21_Click(this, new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.F)
            {
                btnBaoCao_DTThang_Click_1(this, new EventArgs());
            }
        }
    }
}
