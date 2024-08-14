using AProject.CMatch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.FMatch
{
    public partial class FrmPreferMainten : Form
    {
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        private int _position;
        private DataTable originalDataTable;
        public FrmPreferMainten()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FrmPreferMainten_Load);
        }

        private void FrmPreferMainten_Load(object sender, EventArgs e)
        {
            displayBysql("SELECT * FROM tUserPrefer");
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");

            LoadHobbyList();
            LoadTraitsList();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            {
                string query = @"
                 SELECT *
                FROM tUserPrefer";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                originalDataTable = dt; // 儲存所有資料到 originalDataTable
                dataGridView1.DataSource = dt;
            }
        }

        private void LoadTraitsList()
        {
            checkedListBox2.Items.Clear();

            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            {
                string query = "SELECT fTraitsId, fTraitsName FROM tTraits";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string TraitName = reader["fTraitsName"].ToString();
                        string TraitId = reader["fTraitsId"].ToString();
                        checkedListBox2.Items.Add(new { Text = TraitName, Value = TraitId });
                    }
                    reader.Close();

                    checkedListBox2.DisplayMember = "Text";
                    checkedListBox2.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadHobbyList()
        {
            checkedListBox1.Items.Clear();
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            {
                string query = "SELECT fHobbyId, fHobbyName FROM tHobby";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string hobbyName = reader["fHobbyName"].ToString();
                            string hobbyId = reader["fHobbyId"].ToString();
                            checkedListBox1.Items.Add(new { Text = hobbyName, Value = hobbyId });
                        }
                    }
                    else
                    {
                        MessageBox.Show("No rows found in tHobby.");
                    }
                    reader.Close();

                    checkedListBox1.DisplayMember = "Text";
                    checkedListBox1.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void displayBysql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _builder = new SqlCommandBuilder(_adapter);

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //DataTable dt = dataGridView1.DataSource as DataTable;
            //DataRow dr = dt.Rows[_position];
            //dr.Delete();
            //_adapter.Update(dataGridView1.DataSource as DataTable);
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int _position = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[_position];

                DataTable dt = dataGridView1.DataSource as DataTable;
                if (dt != null && _position >= 0 && _position < dt.Rows.Count)
                {
                    DataRow dr = dt.Rows[_position];
                    dr.Delete();
                    if (_adapter != null)
                    {
                        _adapter.Update(dt);
                        MessageBox.Show("資料已成功刪除。");
                    }
                    else
                    {
                        MessageBox.Show("適配器未正確配置。");
                    }
                }
                else
                {
                    MessageBox.Show("選中行的位置無效。");
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的行。");
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                int userId = Convert.ToInt32(selectedRow.Cells["fUserId"].Value);
                LoadMemberAgeRange(userId);
                LoadMemberHobbyPrefer(userId);
                LoadMemberTraitsPrefer(userId);
            }
        }

        private void LoadMemberTraitsPrefer(int userId)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            {
                string query = @"
                SELECT fTraitsId
                FROM tTraitsPrefer
                WHERE fUserId = @fUserId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@fUserId", SqlDbType.Int).Value = userId;

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int traitsId = Convert.ToInt32(reader["fTraitsId"]);

                        for (int i = 0; i < checkedListBox2.Items.Count; i++)
                        {
                            var item = checkedListBox2.Items[i];
                            var itemValue = item.GetType().GetProperty("Value").GetValue(item).ToString();
                            if (itemValue == traitsId.ToString())
                            {
                                checkedListBox2.SetItemChecked(i, true);
                            }
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadMemberHobbyPrefer(int userId)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            {
                string query = @"
                SELECT fHobbyId
                FROM tHobbyPrefer
                WHERE fUserId = @fUserId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@fUserId", SqlDbType.Int).Value = userId;

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int hobbyId = Convert.ToInt32(reader["fHobbyId"]);
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            var item = checkedListBox1.Items[i];
                            var itemValue = item.GetType().GetProperty("Value").GetValue(item).ToString();
                            if (itemValue == hobbyId.ToString())
                            {
                                checkedListBox1.SetItemChecked(i, true);
                            }
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadMemberAgeRange(int userId)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            {
                string query = @"
                SELECT fMinAge, fMaxAge, fGender, fMinHeight, fMaxHeight
                FROM tUserPrefer
                WHERE fUserId = @fUserId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@fUserId", SqlDbType.Int).Value = userId;

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        numericMinAge.Value = Convert.ToInt32(reader["fMinAge"]);
                        numericMaxAge.Value = Convert.ToInt32(reader["fMaxAge"]);

                        bool genderBit = Convert.ToBoolean(reader["fGender"]);
                        string genderPrefer = genderBit ? "Male" : "Female";
                        comboBox1.SelectedItem = genderPrefer;

                        numericMinHeight.Value = Convert.ToDecimal(reader["fMinHeight"]);
                        numericMaxHeight.Value = Convert.ToDecimal(reader["fMaxHeight"]);
                    }
                    else
                    {
                        numericMinAge.Value = numericMinAge.Minimum;
                        numericMaxAge.Value = numericMaxAge.Maximum;
                        comboBox1.SelectedIndex = -1; // 清除 ComboBox 的選擇
                        numericMinHeight.Value = numericMinHeight.Minimum;
                        numericMaxHeight.Value = numericMaxHeight.Maximum;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void numericMinAge_ValueChanged(object sender, EventArgs e)
        {
            if (numericMinAge.Value > numericMaxAge.Value)
            {
                numericMinAge.Value = numericMaxAge.Value;
            }
        }

        private void numericMaxAge_ValueChanged(object sender, EventArgs e)
        {
            if (numericMaxAge.Value < numericMinAge.Value)
            {
                numericMaxAge.Value = numericMinAge.Value;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                int userId = Convert.ToInt32(selectedRow.Cells["fUserId"].Value);
                SaveMemberPrefer(userId);
            }
            else
            {
                MessageBox.Show("請選擇一個會員。");
            }
        }

        private void SaveMemberPrefer(int userId)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // 更新身高與年齡上下限，偏好性別
                    string query = @"
                UPDATE tUserPrefer 
                SET fMinAge = @MinAge, fMaxAge = @MaxAge, 
                    fMinHeight = @MinHeight, fMaxHeight = @MaxHeight, 
                    fGender = @Gender 
                WHERE fUserId = @UserId";

                    SqlCommand cmd = new SqlCommand(query, con, transaction);
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    cmd.Parameters.Add("@MinAge", SqlDbType.Int).Value = numericMinAge.Value;
                    cmd.Parameters.Add("@MaxAge", SqlDbType.Int).Value = numericMaxAge.Value;
                    cmd.Parameters.Add("@MinHeight", SqlDbType.Decimal).Value = numericMinHeight.Value;
                    cmd.Parameters.Add("@MaxHeight", SqlDbType.Decimal).Value = numericMaxHeight.Value;
                    bool genderBit = comboBox1.SelectedItem.ToString() == "Male" ? true : false;
                    cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = genderBit;

                    cmd.ExecuteNonQuery();
                    // 刪除並插入會員的興趣偏好
                    cmd = new SqlCommand("DELETE FROM tHobbyPrefer WHERE fUserId = @UserId", con, transaction);
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    cmd.ExecuteNonQuery();

                    foreach (var item in checkedListBox1.CheckedItems)
                    {
                        var itemValue = item.GetType().GetProperty("Value").GetValue(item).ToString();
                        cmd = new SqlCommand("INSERT INTO tHobbyPrefer (fUserId, fHobbyId) VALUES (@UserId, @HobbyId)", con, transaction);
                        cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                        cmd.Parameters.Add("@HobbyId", SqlDbType.Int).Value = itemValue;
                        cmd.ExecuteNonQuery();
                    }
                    // 刪除並插入會員的特質偏好
                    cmd = new SqlCommand("DELETE FROM tTraitsPrefer WHERE fUserId = @UserId", con, transaction);
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                    cmd.ExecuteNonQuery();

                    foreach (var item in checkedListBox2.CheckedItems)
                    {
                        var itemValue = item.GetType().GetProperty("Value").GetValue(item).ToString();
                        cmd = new SqlCommand("INSERT INTO tTraitsPrefer (fUserId, fTraitsId) VALUES (@UserId, @TraitsId)", con, transaction);
                        cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                        cmd.Parameters.Add("@TraitsId", SqlDbType.Int).Value = itemValue;
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    MessageBox.Show("會員偏好已成功保存。");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("保存失敗: " + ex.Message);
                }
            }
        }


        private void btnSearchId_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearchId.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView1.DataSource = originalDataTable;
            }
            else if (int.TryParse(searchText, out int searchId))
            {
                FilterDataGridViewById(searchId);
            }
            else
            {
                MessageBox.Show("請輸入有效的會員ID。");
            }

        }

        private void FilterDataGridViewById(int searchId)
        {
            if (originalDataTable != null)
            {
                DataView dv = new DataView(originalDataTable);
                dv.RowFilter = $"fUserId = {searchId}";

                dataGridView1.DataSource = dv;

                if (dv.Count == 0)
                {
                    MessageBox.Show("找不到對應的會員。");
                }
            }
            else
            {
                MessageBox.Show("DataGridView 尚未綁定數據。");
            }
        }
        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 0;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[1].HeaderText = "會員Id";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[2].HeaderText = "暱稱";
            dataGridView1.Columns[3].Width = 0;
            dataGridView1.Columns[3].HeaderText = "地區";
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[4].HeaderText = "身高";
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[5].HeaderText = "年齡";
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[6].HeaderText = "偏好身高上限";
            dataGridView1.Columns[7].Width = 60;
            dataGridView1.Columns[7].HeaderText = "偏好身高下限";
            dataGridView1.Columns[8].Width = 50;
            dataGridView1.Columns[8].HeaderText = "偏好年齡上限";
            dataGridView1.Columns[9].Width = 50;
            dataGridView1.Columns[9].HeaderText = "偏好年齡下限";
            dataGridView1.Columns[10].Width = 50;
            dataGridView1.Columns[10].HeaderText = "偏好性別";
            bool isColorChange = false;
            int count = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
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

        private void FrmPreferMainten_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }
    }
}
