# TapeInspector C# HALCON
https://github.com/fukuzai/CCharp_ChartSample

# 概要
C#のchartを使ってリアルタイムにグラフを描画する

こちらを参考にした
http://nanoappli.com/blog/archives/2584

# 環境
<ul>
  <li>Windows10 64bit</li>
  <li>Visual Stuio 2015 pro (C#)</li>
  </ul>

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
