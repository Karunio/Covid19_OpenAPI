using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace UtilizeOpenAPI
{
    class CoronaData
    {
        /// <summary>
        /// 누적 환진률
        /// </summary>
        public float AccDefRate { get; set; }
        /// <summary>
        /// 누적 검사수
        /// </summary>
        public int AccExamCnt { get; set; }
        /// <summary>
        /// 누적 검사 완료 수
        /// </summary>
        public int AccExamCompCnt { get; set; }
        /// <summary>
        /// 치료중 환자 수
        /// </summary>
        public int CareCnt { get; set; }
        /// <summary>
        /// 격리해제 수
        /// </summary>
        public int ClearCnt { get; set; }
        /// <summary>
        /// 등록일시분초 yyyy-MM-dd hh:mm:ss.ff
        /// </summary>
        public DateTime CreateDt { get; set; }
        public string CreateDtFormat => CreateDt.ToString("yyyy-MM-dd hh:mm:ss.ff");
        /// <summary>
        /// 사망자 수
        /// </summary>
        public int DeathCnt { get; set; }
        /// <summary>
        /// 확진자 수
        /// </summary>
        public int DecideCnt { get; set; }
        /// <summary>
        /// 검사진행 수
        /// </summary>
        public int ExamCnt { get; set; }
        /// <summary>
        /// 결과 음성 수
        /// </summary>
        public int ResultLNegCnt { get; set; }
        /// <summary>
        /// 기준일 yyyyMMdd
        /// </summary>
        public DateTime StateDt { get; set; }
        public string StateDtFormat => StateDt.ToString("MM-dd");
        public string StateDtLongFormat => StateDt.ToLongDateString();

        public CoronaData()
        {

        }

        public MetroButton CreateButton()
        {
            MetroButton button = new MetroButton();

            return button;
        }

        public DataTable GetDataTable()
        {
            DataTable table = new DataTable();

            table.Columns.AddRange(new DataColumn[]{
                new DataColumn("누적 환진률"),
                new DataColumn("누적 검사수"),
                new DataColumn("누적 검사완료 수"),
                new DataColumn("치료중 환자 수"),
                new DataColumn("격리 해제 수"),
                new DataColumn("등록일시분초"),
                new DataColumn("사망자 수"),
                new DataColumn("확진자 수"),
                new DataColumn("검사진행 수"),
                new DataColumn("기준일")
            });

            table.Rows.Add(AccDefRate,
                           AccExamCnt,
                           AccExamCompCnt,
                           CareCnt,
                           ClearCnt,
                           CreateDt,
                           DeathCnt,
                           ExamCnt,
                           ResultLNegCnt,
                           StateDt);

            return table;
        }
    }
}
