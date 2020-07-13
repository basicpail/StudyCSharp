using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyStockSystem.Subitems
{
    public partial class SearchItemForm : MetroForm
    {
        public SearchItemForm()
        {
            InitializeComponent();
        }

        private void SearchItemForm_Load(object sender, EventArgs e)
        {
            DgvSearchItems.Font = new Font(@"NanumGothic",10,FontStyle.Regular);
            splitContainer1.SplitterDistance = 50;
        }

        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

           
            MainForm main = new MainForm();
            main.ShowDialog();
            main.Location = this.Location;

            this.Close();
        }

        private void DgvSearchItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtlButton_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient {Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1"); //OpenApi 기본 주소
            str.Append("?serviceKey=HT5y8I2UbypgQm8M5E3xjxPMoCRIgy0KfMqD4dp6rt2%2BWif9M8Tlqq02Bbk0vRFclOk6u0IwkOB6xI5OrRBIcA%3D%3D");// 인증키
            str.Append("&secnNm=" + TxtSearchItem.Text);//종목명
            str.Append("&numOfRows=200");//읽어올 데이터 수
            str.Append("&pageNo=1");//페이지 수
            str.Append("&martTpcd=11"); //주식시장종류 :11은 유가증권시장
            
            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");


            DgvSearchItems.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItems.Rows.Add(
                        item["isin"].InnerText, //isin표준코드
                        item["issuDt"].InnerText, //item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText, //주식발행일자
                        item["korSecnNm"].InnerText, //한글종목명
                        item["secnKacdNm"].InnerText, //보통주/우선주
                        item["shotnIsin"].InnerText)  ; //단축코드
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생:{ex.Message}", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            

            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
          
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) //enter누르면
            {
               BtlButton_Click(sender, new EventArgs());
            }
        }

        private void TxtSearchItem_Click(object sender, EventArgs e)
        {

        }
    }
}
