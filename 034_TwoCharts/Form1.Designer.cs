namespace _034_TwoCharts
{
    partial class Form1
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOneCharts = new System.Windows.Forms.Button();
            this.btnTwoCharts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(961, 461);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnOneCharts
            // 
            this.btnOneCharts.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOneCharts.Location = new System.Drawing.Point(164, 511);
            this.btnOneCharts.Name = "btnOneCharts";
            this.btnOneCharts.Size = new System.Drawing.Size(195, 72);
            this.btnOneCharts.TabIndex = 1;
            this.btnOneCharts.Text = "합쳐서 그리기";
            this.btnOneCharts.UseVisualStyleBackColor = true;
            this.btnOneCharts.Click += new System.EventHandler(this.btnOneCharts_Click);
            // 
            // btnTwoCharts
            // 
            this.btnTwoCharts.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTwoCharts.Location = new System.Drawing.Point(560, 511);
            this.btnTwoCharts.Name = "btnTwoCharts";
            this.btnTwoCharts.Size = new System.Drawing.Size(195, 72);
            this.btnTwoCharts.TabIndex = 2;
            this.btnTwoCharts.Text = "나누어 그리기";
            this.btnTwoCharts.UseVisualStyleBackColor = true;
            this.btnTwoCharts.Click += new System.EventHandler(this.btnTwoCharts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 641);
            this.Controls.Add(this.btnTwoCharts);
            this.Controls.Add(this.btnOneCharts);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnOneCharts;
        private System.Windows.Forms.Button btnTwoCharts;
    }
}

