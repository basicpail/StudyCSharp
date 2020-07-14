using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp.SubItems
{
    public partial class DivMng : MetroForm
    {
        readonly string strTblName = "divTbl";
        public DivMng()
        {
            InitializeComponent();
        }

        private void DivMng_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Division, Names FROM {strTblName}";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(); //mysql에 명령 날리는 용도
                cmd.Connection = conn;
                cmd.CommandText = strQuery;

                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery,conn); //adapter 가 command,parameter,datareader의 역활을 다 한다.
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);
                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = strTblName;

            }
        }
           
    }

    }

