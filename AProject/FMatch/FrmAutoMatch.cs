using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.FMatch
{
    public partial class FrmAutoMatch : Form
    {
        private int matchedUserId = -1;
        public FrmAutoMatch()
        {
            InitializeComponent();
            LoadMemberData();  // 在初始化表單時加載會員資料
        }

        private void LoadMemberData()
        {
            //using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            using (SqlConnection con = new SqlConnection(@"Data Source=192.168.35.57,1433;Initial Catalog=Aproject;User ID=Yucheng;Encrypt=False"))
            {
                try
                {
                    con.Open();
                    string query = @"
                    SELECT fUserId, fNickName, fAge, fCity, fHeight, fGender 
                    FROM tUserPrefer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMembers.DataSource = dt;  // 將數據綁定到DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加載會員資料時出錯: " + ex.Message);
                }
            }
        }
        private int GetSelectedUserId()
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["fUserId"].Value);
                return userId;
            }
            return -1; // 沒有選擇會員時返回 -1
        }

        private void btnAutoMatch_Click(object sender, EventArgs e)
        {
            int selectedUserId = GetSelectedUserId();  // 獲取選中的會員ID

            if (selectedUserId != -1)
            {
                PerformAutoMatch(selectedUserId);
            }
            else
            {
                MessageBox.Show("請選擇一個會員進行配對。");
            }
        }

        private void PerformAutoMatch(int selectedUserId)
        {
            //using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
            using (SqlConnection con = new SqlConnection(@"Data Source=192.168.35.57,1433;Initial Catalog=Aproject;User ID=Yucheng;Encrypt=False"))
            {
                con.Open();

                // 1. 查詢選中會員的性別、年齡、身高和偏好條件
                string queryPreferences = @"
            SELECT u.fUserGender, p.fMinAge, p.fMaxAge, p.fMinHeight, p.fMaxHeight, p.fGender, p.fAge, p.fHeight, p.fNickName 
            FROM tUser u
            JOIN tUserPrefer p ON u.fUserId = p.fUserId
            WHERE u.fUserId = @UserId";

                SqlCommand cmd = new SqlCommand(queryPreferences, con);
                cmd.Parameters.AddWithValue("@UserId", selectedUserId);
                SqlDataReader reader = cmd.ExecuteReader();

                int minAge = 0, maxAge = 0;
                decimal minHeight = 0, maxHeight = 0;
                bool preferredGenderBit = false;  // 會員的偏好性別 (bit)
                string userGender = string.Empty;  // 會員自身性別 (string)
                int selectedUserAge = 0;
                decimal selectedUserHeight = 0;
                string selectedUserName = string.Empty;

                if (reader.Read())
                {
                    // 從查詢結果中提取數據
                    minAge = Convert.ToInt32(reader["fMinAge"]);
                    maxAge = Convert.ToInt32(reader["fMaxAge"]);
                    minHeight = Convert.ToDecimal(reader["fMinHeight"]);
                    maxHeight = Convert.ToDecimal(reader["fMaxHeight"]);

                    preferredGenderBit = Convert.ToBoolean(reader["fGender"]);  // 偏好性別 (從 tUserPrefer 表)
                    userGender = reader["fUserGender"].ToString();  // 會員自身性別 (從 tUser 表)

                    selectedUserAge = Convert.ToInt32(reader["fAge"]);  // 會員自身年齡
                    selectedUserHeight = Convert.ToDecimal(reader["fHeight"]);  // 會員自身身高
                    selectedUserName = reader["fNickName"].ToString();  // 會員暱稱
                }
                reader.Close();

                // 2. 查詢符合條件的會員，並考慮興趣和特質匹配
                string queryMatch = @"
            SELECT TOP 1 p.fUserId, p.fNickName, p.fAge, p.fHeight, u.fUserGender,
                (SELECT COUNT(*) 
                 FROM tUserHobby uh 
                 WHERE uh.fUserId = p.fUserId 
                 AND uh.fHobbyId IN 
                     (SELECT fHobbyId FROM tHobbyPrefer WHERE fUserId = @UserId)) AS HobbyMatchCount,
                (SELECT COUNT(*) 
                 FROM tUserTraits ut 
                 WHERE ut.fUserId = p.fUserId 
                 AND ut.fTraitsId IN 
                     (SELECT fTraitsId FROM tTraitsPrefer WHERE fUserId = @UserId)) AS TraitsMatchCount
            FROM tUserPrefer p
            JOIN tUser u ON p.fUserId = u.fUserId
            WHERE p.fAge BETWEEN @MinAge AND @MaxAge
            AND p.fHeight BETWEEN @MinHeight AND @MaxHeight
            AND u.fUserGender = @PreferredGender  -- 確保對方的性別符合選中會員的偏好
            AND p.fGender = @UserGender           -- 確保對方的偏好性別符合選中會員的性別
            AND p.fUserId <> @UserId
            ORDER BY 
                ((SELECT COUNT(*) 
                  FROM tUserHobby uh 
                  WHERE uh.fUserId = p.fUserId 
                  AND uh.fHobbyId IN 
                      (SELECT fHobbyId FROM tHobbyPrefer WHERE fUserId = @UserId))
                +
                (SELECT COUNT(*) 
                 FROM tUserTraits ut 
                 WHERE ut.fUserId = p.fUserId 
                 AND ut.fTraitsId IN 
                     (SELECT fTraitsId FROM tTraitsPrefer WHERE fUserId = @UserId))) DESC, 
                (ABS(p.fAge - @SelectedUserAge) + ABS(p.fHeight - @SelectedUserHeight)) ASC";

                SqlCommand cmdMatch = new SqlCommand(queryMatch, con);
                cmdMatch.Parameters.AddWithValue("@MinAge", minAge);
                cmdMatch.Parameters.AddWithValue("@MaxAge", maxAge);
                cmdMatch.Parameters.AddWithValue("@MinHeight", minHeight);
                cmdMatch.Parameters.AddWithValue("@MaxHeight", maxHeight);
                cmdMatch.Parameters.AddWithValue("@PreferredGender", userGender);  // 使用會員的性別來匹配對方的偏好性別
                cmdMatch.Parameters.AddWithValue("@UserGender", preferredGenderBit);  // 使用會員的偏好性別來匹配對方的性別
                cmdMatch.Parameters.AddWithValue("@UserId", selectedUserId);
                cmdMatch.Parameters.AddWithValue("@SelectedUserAge", selectedUserAge);
                cmdMatch.Parameters.AddWithValue("@SelectedUserHeight", selectedUserHeight);

                SqlDataReader matchReader = cmdMatch.ExecuteReader();

                if (matchReader.Read())
                {
                    // 3. 顯示配對結果在右側GroupBox中
                    lblMatchedName.Text = "姓名: " + matchReader["fNickName"].ToString();
                    lblMatchedAge.Text = "年齡: " + matchReader["fAge"].ToString();
                    lblMatchedHeight.Text = "身高: " + matchReader["fHeight"].ToString();
                    lblMatchedGender.Text = "性別: " + matchReader["fUserGender"].ToString();
                    lblMatchedHobbies.Text = "興趣匹配數: " + matchReader["HobbyMatchCount"].ToString();
                    lblMatchedTraits.Text = "特質匹配數: " + matchReader["TraitsMatchCount"].ToString();

                    matchedUserId = Convert.ToInt32(matchReader["fUserId"]);
                }
                else
                {
                    MessageBox.Show("沒有找到符合條件的會員。");
                    matchedUserId = -1;  // 如果沒有找到配對，重置 matchedUserId
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            int selectedUserId = GetSelectedUserId();  // 獲取選中的會員ID
            // 確保已選中會員且已找到匹配的會員
            if (selectedUserId != -1 && matchedUserId != -1)
            {
                // 獲取當前日期作為配對日期
                string matchDate = DateTime.Now.ToString("yyyy-MM-dd");

                //using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                using (SqlConnection con = new SqlConnection(@"Data Source=192.168.35.57,1433;Initial Catalog=Aproject;User ID=Yucheng;Encrypt=False"))
                {
                    con.Open();

                    // 檢查是否已經有這個配對的記錄
                    string queryCheck = @"
                SELECT COUNT(*) 
                FROM tMatch 
                WHERE (fUserId = @selectedUserId AND fUserId2 = @matchedUserId) 
                OR (fUserId = @matchedUserId AND fUserId2 = @selectedUserId)";

                    SqlCommand cmdCheck = new SqlCommand(queryCheck, con);
                    cmdCheck.Parameters.AddWithValue("@selectedUserId", selectedUserId);
                    cmdCheck.Parameters.AddWithValue("@matchedUserId", matchedUserId);

                    int matchExists = (int)cmdCheck.ExecuteScalar();

                    if (matchExists > 0)
                    {
                        // 如果記錄存在，則更新配對狀態和更新日期
                        string queryUpdate = @"
                    UPDATE tMatch 
                    SET fStatus = 'P', 
                        fUpdateDate = @updateDate 
                    WHERE (fUserId = @selectedUserId AND fUserId2 = @matchedUserId) 
                    OR (fUserId = @matchedUserId AND fUserId2 = @selectedUserId)";

                        SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con);
                        cmdUpdate.Parameters.AddWithValue("@updateDate", matchDate);
                        cmdUpdate.Parameters.AddWithValue("@selectedUserId", selectedUserId);
                        cmdUpdate.Parameters.AddWithValue("@matchedUserId", matchedUserId);
                        cmdUpdate.ExecuteNonQuery();
                    }
                    else
                    {
                        // 如果記錄不存在，則插入新的配對記錄
                        string queryInsert = @"
                    INSERT INTO tMatch (fUserId, fUserId2, fMatchDate, fStatus, fUpdateDate) 
                    VALUES (@selectedUserId, @matchedUserId, @matchDate, 'P', @updateDate)";

                        SqlCommand cmdInsert = new SqlCommand(queryInsert, con);
                        cmdInsert.Parameters.AddWithValue("@selectedUserId", selectedUserId);
                        cmdInsert.Parameters.AddWithValue("@matchedUserId", matchedUserId);
                        cmdInsert.Parameters.AddWithValue("@matchDate", matchDate);
                        cmdInsert.Parameters.AddWithValue("@updateDate", matchDate);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("配對通知已寄出", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("未能寄送配對通知。請確保已選擇會員並完成配對。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void resetGridStyle()
        {
            dgvMembers.Columns[0].Width = 50;
            dgvMembers.Columns[0].HeaderText = "會員Id";
            dgvMembers.Columns[1].Width = 80;
            dgvMembers.Columns[1].HeaderText = "暱稱";
            dgvMembers.Columns[2].Width = 80;
            dgvMembers.Columns[2].HeaderText = "年齡";
            dgvMembers.Columns[3].Width = 0;
            dgvMembers.Columns[3].HeaderText = "地區";
            dgvMembers.Columns[4].Width = 80;
            dgvMembers.Columns[4].HeaderText = "身高";
            dgvMembers.Columns[5].Width = 80;
            dgvMembers.Columns[5].HeaderText = "性別";
            bool isColorChange = false;
            int count = 0;
            foreach (DataGridViewRow r in dgvMembers.Rows)
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

        private void FrmAutoMatch_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void FrmAutoMatch_Load(object sender, EventArgs e)
        {

        }
    }  
}
