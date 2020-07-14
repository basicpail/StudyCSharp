using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BookRentalShopApp.NewFolder1
{
    public partial class LoginForm : MetroForm
    {
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            //빈값비교 처리
            if(string.IsNullOrEmpty(TxtUserID.Text)||string.IsNullOrEmpty(TxtPassword.Text))
                //TxtUserID.Text == ""|| TxtUserID.Text ==null ||
                //TxtPassword.Text == "" || TxtPassword.Text ==null)
            {
                //MessageBox.Show("아이디나 패스워드를 입력하세요!", "로그인",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                MetroMessageBox.Show(this, "아이디나 패스워드를 입력하세요!", "로그인",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUserID.Focus();
                return;
            }
            //DB처리
            string resultid = string.Empty; //""

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
                {
                    conn.Open();
                    //MetroMessageBox.Show(this, $"DB접속 성공!!");
                    MySqlCommand cmd = new MySqlCommand(); //mysql에 명령 날리는 용도
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userID FROM userTBL " +
                                      "    WHERE userID = @userID " +
                                      "  AND password = @password "; //직접적으로 값을 안쓰고 파라미터를 이용한다.
                    MySqlParameter paramUserId = new MySqlParameter("@userID", MySqlDbType.VarChar, 12);
                    paramUserId.Value = TxtUserID.Text.Trim();
                    MySqlParameter paramPassword = new MySqlParameter("@password", MySqlDbType.VarChar);
                    paramPassword.Value = TxtPassword.Text.Trim();

                    cmd.Parameters.Add(paramUserId);
                    cmd.Parameters.Add(paramPassword);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if(!reader.HasRows)
                    {
                        MetroMessageBox.Show(this,"아이디나 패스워드를 정확히 입력하세요.", "로그인 실패",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
                        TxtUserID.Text = TxtPassword.Text = string.Empty;
                        TxtUserID.Focus();
                        return;
                    }

                    resultid = reader["userID"] != null ? reader["userID"].ToString() : string.Empty;
                    MetroMessageBox.Show(this, $"{resultid} 로그인 성공!");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"DB접속에러:{ex.Message}", "로그인에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(resultid))
            {
                MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요.", "로그인 실패",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserID.Text = TxtPassword.Text = string.Empty;
                TxtUserID.Focus();
                return;
            }
            else this.Close();
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                BtnOk_Click(sender, new EventArgs());
            }
        }
    }
}
