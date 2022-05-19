<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582587/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1162)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ChartUpdateExample/Form1.cs) (VB: [Form1.vb](./VB/ChartUpdateExample/Form1.vb))
<!-- default file list end -->
# How to Pass the PivoGridControl's Data to a Chart


A chart bound to a pivot is redrawn frequently and may result in a slow application performance. This example demonstrates how to update the chart on demand.

To manually update the chart, copy the PivotGridControl's data to the IList data source and bind the ChartControl to that intermediate data source.

![screenshot](./images/screenshot.png)
