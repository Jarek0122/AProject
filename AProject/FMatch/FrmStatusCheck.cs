using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.FMatch
{
    public partial class FrmStatusCheck : Form
    {
        public FrmStatusCheck()
        {
            InitializeComponent();
        }

        private void LoadMatchStatus()
        {
            //using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            using (SqlConnection con = new SqlConnection(@"Data Source=192.168.35.57,1433;Initial Catalog=Aproject;User ID=Yucheng;Encrypt=False"))
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT fMatchId, fUserId, fUserId2, fMatchDate, fStatus, fUpdateDate 
                FROM tMatch";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMatchStatus.DataSource = dt;  // 將數據綁定到DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加載配對狀態時出錯: " + ex.Message);
                }
            }
        }
        private void FrmStatusCheck_Load(object sender, EventArgs e)
        {
            LoadMatchStatus();  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchUserId = txtSearchUserId.Text.Trim();

            if (string.IsNullOrEmpty(searchUserId))
            {
                LoadMatchStatus();
            }
            else
            {
                //using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                using (SqlConnection con = new SqlConnection(@"Data Source=192.168.35.57,1433;Initial Catalog=Aproject;User ID=Yucheng;Encrypt=False"))
                {
                    try
                    {
                        con.Open();
                        string query = @"
                SELECT fMatchId, fUserId, fUserId2, fMatchDate, fStatus, fUpdateDate 
                FROM tMatch
                WHERE fUserId = @searchUserId OR fUserId2 = @searchUserId";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@searchUserId", searchUserId);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvMatchStatus.DataSource = dt;  // 將數據綁定到DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("搜尋配對狀態時出錯: " + ex.Message);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 文件|*.xlsx";
            saveFileDialog.Title = "匯出配對狀態";
            saveFileDialog.FileName = "MatchStatusExport";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToExcel(saveFileDialog.FileName);
                    MessageBox.Show("匯出成功！", "匯出", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("匯出過程中出錯: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ExportToExcel(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("MatchStatus");
                // 寫入列標題
                for (int i = 0; i < dgvMatchStatus.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvMatchStatus.Columns[i].HeaderText;
                }
                // 寫入行數據
                for (int i = 0; i < dgvMatchStatus.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvMatchStatus.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvMatchStatus.Rows[i].Cells[j].Value?.ToString();
                    }
                }
                package.SaveAs(new FileInfo(filePath));
            }
        }
        private void resetGridStyle()
        {
            dgvMatchStatus.Columns[0].Width = 0;
            dgvMatchStatus.Columns[1].Width = 200;
            dgvMatchStatus.Columns[1].HeaderText = "會員Id";
            dgvMatchStatus.Columns[2].Width = 200;
            dgvMatchStatus.Columns[2].HeaderText = "配對會員Id";
            dgvMatchStatus.Columns[3].Width = 100;
            dgvMatchStatus.Columns[3].HeaderText = "配對日期";
            dgvMatchStatus.Columns[4].Width = 100;
            dgvMatchStatus.Columns[4].HeaderText = "配對狀態";
            dgvMatchStatus.Columns[5].Width = 100;
            dgvMatchStatus.Columns[5].HeaderText = "更新日期";
            bool isColorChange = false;
            int count = 0;
            foreach (DataGridViewRow r in dgvMatchStatus.Rows)
            {
                count++;
                isColorChange = !isColorChange;
                r.DefaultCellStyle.BackColor = Color.White;
                if (isColorChange)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 11);
                r.Height = 50;
                r.HeaderCell.Value = count.ToString();
            }
        }

        private void FrmStatusCheck_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }
    }
}
