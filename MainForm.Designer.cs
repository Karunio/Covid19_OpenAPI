namespace UtilizeOpenAPI
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.DtBegin = new MetroFramework.Controls.MetroDateTime();
            this.DtEnd = new MetroFramework.Controls.MetroDateTime();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.FlwpCorona = new System.Windows.Forms.FlowLayoutPanel();
            this.MetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.MtpNewCumulate = new MetroFramework.Controls.MetroTabPage();
            this.ChartNewCumal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MtpDetail = new MetroFramework.Controls.MetroTabPage();
            this.DgvDetail = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.MetroTabControl.SuspendLayout();
            this.MtpNewCumulate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNewCumal)).BeginInit();
            this.MtpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.DtBegin);
            this.splitContainer1.Panel1.Controls.Add(this.DtEnd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 640);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(875, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "종료일";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(604, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "시작일";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1138, 9);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(89, 29);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseSelectable = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DtBegin
            // 
            this.DtBegin.Location = new System.Drawing.Point(661, 9);
            this.DtBegin.MaxDate = new System.DateTime(2020, 7, 13, 0, 0, 0, 0);
            this.DtBegin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DtBegin.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtBegin.Name = "DtBegin";
            this.DtBegin.Size = new System.Drawing.Size(200, 29);
            this.DtBegin.TabIndex = 0;
            this.DtBegin.Value = new System.DateTime(2020, 7, 13, 0, 0, 0, 0);
            // 
            // DtEnd
            // 
            this.DtEnd.Location = new System.Drawing.Point(932, 9);
            this.DtEnd.MaxDate = new System.DateTime(2020, 7, 13, 0, 0, 0, 0);
            this.DtEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtEnd.Name = "DtEnd";
            this.DtEnd.Size = new System.Drawing.Size(200, 29);
            this.DtEnd.TabIndex = 0;
            this.DtEnd.Value = new System.DateTime(2020, 7, 13, 0, 0, 0, 0);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.FlwpCorona);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MetroTabControl);
            this.splitContainer2.Size = new System.Drawing.Size(1240, 591);
            this.splitContainer2.SplitterDistance = 410;
            this.splitContainer2.TabIndex = 0;
            // 
            // FlwpCorona
            // 
            this.FlwpCorona.AutoScroll = true;
            this.FlwpCorona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlwpCorona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwpCorona.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlwpCorona.Location = new System.Drawing.Point(0, 0);
            this.FlwpCorona.Name = "FlwpCorona";
            this.FlwpCorona.Padding = new System.Windows.Forms.Padding(5);
            this.FlwpCorona.Size = new System.Drawing.Size(410, 591);
            this.FlwpCorona.TabIndex = 0;
            this.FlwpCorona.WrapContents = false;
            // 
            // MetroTabControl
            // 
            this.MetroTabControl.Controls.Add(this.MtpNewCumulate);
            this.MetroTabControl.Controls.Add(this.MtpDetail);
            this.MetroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetroTabControl.Location = new System.Drawing.Point(0, 0);
            this.MetroTabControl.Name = "MetroTabControl";
            this.MetroTabControl.SelectedIndex = 0;
            this.MetroTabControl.Size = new System.Drawing.Size(826, 591);
            this.MetroTabControl.TabIndex = 0;
            this.MetroTabControl.UseSelectable = true;
            // 
            // MtpNewCumulate
            // 
            this.MtpNewCumulate.Controls.Add(this.ChartNewCumal);
            this.MtpNewCumulate.HorizontalScrollbarBarColor = false;
            this.MtpNewCumulate.HorizontalScrollbarHighlightOnWheel = false;
            this.MtpNewCumulate.HorizontalScrollbarSize = 10;
            this.MtpNewCumulate.Location = new System.Drawing.Point(4, 38);
            this.MtpNewCumulate.Name = "MtpNewCumulate";
            this.MtpNewCumulate.Size = new System.Drawing.Size(818, 549);
            this.MtpNewCumulate.TabIndex = 1;
            this.MtpNewCumulate.Text = "누적 / 신규 확진자";
            this.MtpNewCumulate.VerticalScrollbarBarColor = false;
            this.MtpNewCumulate.VerticalScrollbarHighlightOnWheel = false;
            this.MtpNewCumulate.VerticalScrollbarSize = 10;
            // 
            // ChartNewCumal
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.ChartNewCumal.ChartAreas.Add(chartArea1);
            this.ChartNewCumal.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartNewCumal.Legends.Add(legend1);
            this.ChartNewCumal.Location = new System.Drawing.Point(0, 0);
            this.ChartNewCumal.Name = "ChartNewCumal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "누적";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.Yellow;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "신규";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValuesPerPoint = 6;
            this.ChartNewCumal.Series.Add(series1);
            this.ChartNewCumal.Series.Add(series2);
            this.ChartNewCumal.Size = new System.Drawing.Size(818, 549);
            this.ChartNewCumal.TabIndex = 2;
            this.ChartNewCumal.Text = "chart1";
            // 
            // MtpDetail
            // 
            this.MtpDetail.Controls.Add(this.DgvDetail);
            this.MtpDetail.HorizontalScrollbarBarColor = false;
            this.MtpDetail.HorizontalScrollbarHighlightOnWheel = false;
            this.MtpDetail.HorizontalScrollbarSize = 10;
            this.MtpDetail.Location = new System.Drawing.Point(4, 38);
            this.MtpDetail.Name = "MtpDetail";
            this.MtpDetail.Size = new System.Drawing.Size(818, 549);
            this.MtpDetail.TabIndex = 2;
            this.MtpDetail.Text = "상세 현황";
            this.MtpDetail.VerticalScrollbarBarColor = false;
            this.MtpDetail.VerticalScrollbarHighlightOnWheel = false;
            this.MtpDetail.VerticalScrollbarSize = 10;
            // 
            // DgvDetail
            // 
            this.DgvDetail.AllowUserToAddRows = false;
            this.DgvDetail.AllowUserToDeleteRows = false;
            this.DgvDetail.AllowUserToResizeRows = false;
            this.DgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDetail.EnableHeadersVisualStyles = false;
            this.DgvDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvDetail.Location = new System.Drawing.Point(0, 0);
            this.DgvDetail.Name = "DgvDetail";
            this.DgvDetail.ReadOnly = true;
            this.DgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvDetail.RowTemplate.Height = 23;
            this.DgvDetail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvDetail.Size = new System.Drawing.Size(818, 549);
            this.DgvDetail.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "코로나 현황";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.MetroTabControl.ResumeLayout(false);
            this.MtpNewCumulate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartNewCumal)).EndInit();
            this.MtpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroDateTime DtBegin;
        private MetroFramework.Controls.MetroDateTime DtEnd;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel FlwpCorona;
        private MetroFramework.Controls.MetroTabControl MetroTabControl;
        private MetroFramework.Controls.MetroTabPage MtpNewCumulate;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartNewCumal;
        private MetroFramework.Controls.MetroTabPage MtpDetail;
        private MetroFramework.Controls.MetroGrid DgvDetail;
    }
}

