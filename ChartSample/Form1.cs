using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace ChartSample
{
    public partial class Form1 : Form
    {

        // 取得データの履歴
        const int MAX_HISTORY = 40;
        Queue<int> countHistory = new Queue<int>();

        // CPU使用率の取得用カウンタ
        PerformanceCounter pc = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);


        int count = 0;
        int[] array = new int[10];


        public Form1()
        {
            InitializeComponent();

            // チャートの表示を初期化
            initChart(chart1);

            // 1秒周期でチャートを再描画
            timer1.Interval = 1000;
            timer1.Enabled = true;


        }

        private void initChart(Chart chart)
        {

            // チャート全体の背景色を設定
            chart.BackColor = Color.Black;
            chart.ChartAreas[0].BackColor = Color.Transparent;

            // チャート表示エリア周囲の余白をカットする
            chart.ChartAreas[0].InnerPlotPosition.Auto = false;
            chart.ChartAreas[0].InnerPlotPosition.Width = 100; // 100%
            chart.ChartAreas[0].InnerPlotPosition.Height = 90;  // 90%(横軸のメモリラベル印字分の余裕を設ける)
            chart.ChartAreas[0].InnerPlotPosition.X = 8;
            chart.ChartAreas[0].InnerPlotPosition.Y = 0;
            

            // X,Y軸情報のセット関数を定義
            Action<Axis> setAxis = (axisInfo) => {
                // 軸のメモリラベルのフォントサイズ上限値を制限
                axisInfo.LabelAutoFitMaxFontSize = 8;

                // 軸のメモリラベルの文字色をセット
                axisInfo.LabelStyle.ForeColor = Color.White;

                // 軸タイトルの文字色をセット(今回はTitle未使用なので関係ないが...)
                axisInfo.TitleForeColor = Color.White;

                // 軸の色をセット
                axisInfo.MajorGrid.Enabled = true;
                axisInfo.MajorGrid.LineColor = ColorTranslator.FromHtml("#008242");
                axisInfo.MinorGrid.Enabled = false;
                axisInfo.MinorGrid.LineColor = ColorTranslator.FromHtml("#008242");
            };

            // X,Y軸の表示方法を定義
            setAxis(chart.ChartAreas[0].AxisY);
            setAxis(chart.ChartAreas[0].AxisX);
            chart.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            chart.ChartAreas[0].AxisY.Maximum = 100;    // 縦軸の最大値を100にする

            chart.AntiAliasing = AntiAliasingStyles.None;

            // 折れ線グラフとして表示
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            // 線の色を指定
            chart.Series[0].Color = ColorTranslator.FromHtml("#00FF00");

            // 凡例を非表示,各値に数値を表示しない
            chart.Series[0].IsVisibleInLegend = false;
            chart.Series[0].IsValueShownAsLabel = false;

            // チャートに表示させる値の履歴を全て0クリア
            while (countHistory.Count <= MAX_HISTORY)
            {
                countHistory.Enqueue(0);
            }
        }

        private void showChart(Chart chart)
        {

            //-----------------------
            // チャートに値をセット
            //-----------------------
            chart.Series[0].Points.Clear();
            foreach (int value in countHistory)
            {

                // データをチャートに追加
                chart.Series[0].Points.Add(new DataPoint(0, value));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //---------------------------------
            // CPUの使用率を取得し、履歴に登録
            //---------------------------------
            int value = (int)pc.NextValue();
            countHistory.Enqueue(value);


            //ヒストグラム用の配列を生成
            
            if(value < 10)
            {
                array[0] += 1;
            }
            else if(value < 20)
            {
                array[1] += 1;
            }
            else if(value < 30)
            {
                array[2] += 1;
            }
            else if(value < 40)
            {
                array[3] += 1;
            }
            else if(value < 50)
            {
                array[4] += 1;
            }
            else if(value < 60)
            {
                array[5] += 1;
            }
            else if(value < 70)
            {
                array[6] += 1;
            }
            else if(value < 80)
            {
                array[7] = +1;
            }else if(value < 90)
            {
                array[8] += 1;
            }
            else if(value <=100)
            {
                array[9] += 1;
            }
            
            //Console.Write()

            count = count + 1;
            //------------------------------------------------
            // 履歴の最大数を超えていたら、古いものを削除する
            //------------------------------------------------
            while (countHistory.Count > MAX_HISTORY)
            {
                countHistory.Dequeue();
            }

            //------------------------------------------------
            // グラフを再描画する
            //------------------------------------------------
            showChart(chart1);
        }
    }


}
