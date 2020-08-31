using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace UtilizeOpenAPI
{
    public partial class MainForm : MetroForm
    {
        private static readonly string url = @"http://openapi.data.go.kr/openapi/service/rest/Covid19/getCovid19InfStateJson";
        private static readonly string serviceKey = @"?ServiceKey=vEeQTVnjsPLoT2jA%2FmRDc9x87BT9JOmKAslzz5vpDXQWk7NpuEgUmCeQshCRaqnpOsYsr3EGD3%2BE1ZQS8o%2BQ9Q%3D%3D";
        private List<CoronaData> coronaDataList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DtBegin.MaxDate = DateTime.Today;
            DtEnd.MaxDate = DateTime.Today;

            DtBegin.Value = DateTime.Today;
            DtEnd.Value = DateTime.Today;
        }

        private DataSet GetCoronaDataSet(DateTime begin, DateTime end)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            builder.Append(serviceKey);
            builder.Append(@"&pageNo=1");
            builder.Append(@"&numOfRows=10");
            builder.Append($@"&startCreateDt={begin:yyyyMMdd}");
            builder.Append($@"&endCreateDt={end:yyyyMMdd}");

            WebClient client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string xmlData = client.DownloadString(builder.ToString());

            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlData);

            DataSet dataSet = new DataSet();
            using (XmlReader reader = new XmlNodeReader(document))
            {
                dataSet.ReadXml(reader);
            }

            return dataSet;
        }

        private CoronaData CreateCoronaData(DataRow dataRow)
        {
            CoronaData data = new CoronaData()
            {
                AccDefRate = float.Parse(dataRow["accDefRate"].ToString()),
                AccExamCnt = int.Parse(dataRow["accExamCnt"].ToString()),
                AccExamCompCnt = int.Parse(dataRow["accExamCompCnt"].ToString()),
                CareCnt = int.Parse(dataRow["careCnt"].ToString()),
                ClearCnt = int.Parse(dataRow["clearCnt"].ToString()),
                CreateDt = DateTime.Parse(dataRow["createDt"].ToString()),
                DeathCnt = int.Parse(dataRow["deathCnt"].ToString()),
                DecideCnt = int.Parse(dataRow["decideCnt"].ToString()),
                ExamCnt = int.Parse(dataRow["examCnt"].ToString()),
                ResultLNegCnt = int.Parse(dataRow["resutlNegCnt"].ToString()),
                StateDt = DateTime.Parse(dataRow["stateDt"].ToString().Insert(4, "-").Insert(7, "-"))
            };

            return data;
        }

        private List<CoronaData> CreateCoronaList(DataRowCollection rowCollection)
        {
            List<CoronaData> list = new List<CoronaData>();
            foreach (DataRow row in rowCollection)
            {
                CoronaData data = CreateCoronaData(row);
                list.Add(data);
            }
            return list;
        }

        private void AddTiles(List<CoronaData> coronaDatas)
        {
            FlwpCorona.Controls.Clear();

            int tabIndex = 3;
            for (int i = 0; i < coronaDatas.Count - 1; i++)
            {
                CoronaData data = coronaDatas[i];
                AddTileFromCoronaData(data, tabIndex++, i);
            }
        }

        private void AddTileFromCoronaData(CoronaData data, int tabIndex, int createIndex)
        {
            MetroTile tile = new MetroTile
            {
                ActiveControl = null,
                Name = $"Tile{data.StateDtFormat}",
                Size = new Size(370, 100),
                TabIndex = tabIndex++,
                Text = $"{data.StateDtLongFormat}",
                UseSelectable = true
            };
            tile.Click += new EventHandler(CoronaTile_Click);

            if (createIndex == 0)
            {
                tile.Location = new Point(8, 8);
                tile.Dock = DockStyle.None;
            }
            else
            {
                tile.Dock = DockStyle.Top;
            }
            FlwpCorona.Controls.Add(tile);
        }

        private void DrawChart(List<CoronaData> datas)
        {
            foreach (var item in ChartNewCumal.Series)
            {
                item.Points.Clear();
            }

            for (int i = datas.Count - 1; i > 0; i--)
            {
                CoronaData currentData = datas[i - 1];
                CoronaData prevData = datas[i];

                ChartNewCumal.Series["누적"].Points.AddXY(currentData.StateDtFormat, currentData.DecideCnt);
                ChartNewCumal.Series["신규"].Points.AddY(currentData.DecideCnt - prevData.DecideCnt);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DateTime begin = DtBegin.Value.AddDays(-1);
            DateTime end = DtEnd.Value;

            DataSet coronaDataSet = GetCoronaDataSet(begin, end);
            coronaDataList = CreateCoronaList(coronaDataSet.Tables["item"].Rows);
            AddTiles(coronaDataList);
            DrawChart(coronaDataList);

            MetroTabControl.SelectedTab = MtpNewCumulate;
        }

        private CoronaData FindCoronaData(MetroTile tile)
        {
            foreach (var item in coronaDataList)
            {
                if (item.StateDtLongFormat == tile.Text)
                {
                    return item;
                }
            }

            return null;
        }

        private void CoronaTile_Click(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            if (tile == null)
            {
                return;
            }

            CoronaData coronaData = FindCoronaData(tile);
            DgvDetail.DataSource = coronaData.GetDataTable();
            MetroTabControl.SelectedTab = MtpDetail;
        }
    }
}
