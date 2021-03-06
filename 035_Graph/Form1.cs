using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _035_Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Graph using Chart control";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChartSetting();
        }

        private void ChartSetting()
        {
            ch.ChartAreas["ChartArea1"].BackColor = Color.Black;

            // X축과 Y축을 설정
            ch.ChartAreas[0].AxisX.Minimum = -20;
            ch.ChartAreas[0].AxisX.Maximum = 20;
            ch.ChartAreas[0].AxisX.Interval = 2;
            ch.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            ch.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ch.ChartAreas[0].AxisY.Minimum = -1;
            ch.ChartAreas[0].AxisY.Maximum = 1;
            ch.ChartAreas[0].AxisY.Interval = 0.2;
            ch.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            ch.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Series[0] 설정 = sin(x)/x
            ch.Series[0].ChartType = SeriesChartType.Line;
            ch.Series[0].Color = Color.LightGreen;
            ch.Series[0].BorderWidth = 2;
            ch.Series[0].LegendText = "sin(x)";


            // Series 추가
            ch.Series.Add("Sin(x)/x");
            ch.Series["Sin(x)/x"].LegendText = "Sin(x) / x";
            ch.Series[1].ChartType = SeriesChartType.Line;
            ch.Series[1].Color = Color.Orange;
            ch.Series[1].BorderWidth = 2;

            // Series 추가
            ch.Series.Add("Cos(x)/x");
            ch.Series["Cos(x)/x"].LegendText = "Cos(x) / x";
            ch.Series[2].ChartType = SeriesChartType.Line;
            ch.Series[2].Color = Color.White;
            ch.Series[2].BorderWidth = 2;

            // 데이터 추가
            for (double x = -20; x < 20; x += 0.1)
            {
                double y = Math.Sin(x);
                ch.Series[0].Points.AddXY(x, y);

                y = Math.Sin(x) / x;
                ch.Series[1].Points.AddXY(x, y);

                y = Math.Cos(x) / x;
                ch.Series[2].Points.AddXY(x, y);
            }
        }
    }
}
