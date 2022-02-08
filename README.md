# 
CCharp_ChartSample
https://github.com/fukuzai/CCharp_ChartSample

# 概要
C#の「chart」を使ってリアルタイムにグラフを描画する

こちらを参考にした
http://nanoappli.com/blog/archives/2584

# 環境
<ul>
  <li>Windows10 64bit</li>
  <li>Visual Stuio 2015 pro (C#)</li>
  </ul>

# グラフの種類
https://docs.microsoft.com/ja-jp/dotnet/api/system.windows.forms.datavisualization.charting.seriescharttype?view=netframework-4.8

<table>
    <tr>
    <th>種別名</th>
    <th>内容</th>
    </tr>
    <tr>
    <td>Point</td>
    <td>ポイント グラフ</td>
    </tr>
    <tr>
    <td>FastPoint</td>
    <td>FastPoint グラフ</td>
    </tr>
    <tr>
    <td>Bubble</td>
    <td>バブル チャート</td>
    </tr>
    <tr>
    <td>Line</td>
    <td>折れ線グラフ</td>
    </tr>
    <tr>
    <td>Spline</td>
    <td>スプライン グラフ</td>
    </tr>
    <tr>
    <td>StepLine</td>
    <td>StepLine グラフ</td>
    </tr>
    <tr>
    <td>FastLine</td>
    <td>FastLine グラフ</td>
    </tr>
    <tr>
    <td>Bar</td>
    <td>横棒グラフ</td>
    </tr>
    <tr>
    <td>StackedBar</td>
    <td>積み上げ横棒グラフ</td>
    </tr>
    <tr>
    <td>StackedBar100</td>
    <td>100% 積み上げ横棒グラフ</td>
    </tr>
    <tr>
    <td>Column</td>
    <td>縦棒グラフ</td>
    </tr>
    <tr>
    <td>StackedColumn</td>
    <td>積み上げ縦棒グラフ</td>
    </tr>
    <tr>
    <td>StackedColumn100</td>
    <td>100% 積み上げ縦棒グラフ</td>
    </tr>
    <tr>
    <td>Area</td>
    <td>面グラフ</td>
    </tr>
    <tr>
    <td>SplineArea</td>
    <td>スプライン面グラフ</td>
    </tr>
    <tr>
    <td>StackedArea</td>
    <td>積み上げ面グラフ</td>
    </tr>
    <tr>
    <td>StackedArea100</td>
    <td>100% 積み上げ面グラフ</td>
    </tr>
    <tr>
    <td>Pie</td>
    <td>円グラフ</td>
    </tr>
    <tr>
    <td>Doughnut</td>
    <td>ドーナツ グラフ</td>
    </tr>
    <tr>
    <td>Stock</td>
    <td>株価チャート</td>
    </tr>
    <tr>
    <td>Candlestick</td>
    <td>ローソク足チャート</td>
    </tr>
    <tr>
    <td>Range</td>
    <td>範囲グラフ</td>
    </tr>
    <tr>
    <td>SplineRange</td>
    <td>スプライン範囲グラフ</td>
    </tr>
    <tr>
    <td>RangeBar</td>
    <td>RangeBar グラフ</td>
    </tr>
    <tr>
    <td>RangeColumn</td>
    <td>範囲縦棒グラフ</td>
    </tr>
    <tr>
    <td>Radar</td>
    <td>レーダー チャート</td>
    </tr>
    <tr>
    <td>Polar</td>
    <td>極座標グラフ</td>
    </tr>
    <tr>
    <td>ErrorBar</td>
    <td>誤差範囲グラフ</td>
    </tr>
    <tr>
    <td>BoxPlot</td>
    <td>ボックス プロット グラフ</td>
    </tr>
    <tr>
    <td>Renko</td>
    <td>練行足チャート</td>
    </tr>
    <tr>
    <td>ThreeLineBreak</td>
    <td>ThreeLineBreak グラフ</td>
    </tr>
    <tr>
    <td>Kagi</td>
    <td>かぎ足チャート</td>
    </tr>
    <tr>
    <td>PointAndFigure</td>
    <td>PointAndFigure グラフ</td>
    </tr>
    <tr>
    <td>Funnel</td>
    <td>じょうごグラフ</td>
    </tr>
    <tr>
    <td>Pyramid</td>
    <td>ピラミッド グラフ</td>
    </tr>
</table>

# screenshot
入力画像<br>
![screenshot](https://github.com/fukuzai/CCharp_ChartSample/blob/master/screenshot1.png)

![screenshot](https://github.com/fukuzai/CCharp_ChartSample/blob/master/screenshot2.png)

# 改定履歴
<ul>
  <li>2020-12-03　初版</li>
</ul>

# 苦労した点
・chartを使うためのusingは：using System.Windows.Forms.DataVisualization.Charting;（参考URLに記載なし）<br>
・CPU使用率を使うためのusingは：using System.Diagnostics;（参考URLに記載なし）<br>
・timerは「ツールボックス」→コンポーネント」→「Timer」をGUI上にドラッグして追加する（参考URLに記載なし）<br>
・timer1_Tickのイベントハンドラは直接コードをコピペしたら動かず。デザイナのtimer1をダブルクリックして、空のイベントハンドラを自動生成した上で、コードをコピペしたら動いた。<br>
