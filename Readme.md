<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1162)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
<!-- default file list end -->
# How to stop refreshing a chart


<p>When a chart is bound to a pivot, it may cause performance issues with some chart diagrams. There is a way to prevent a chart from updating, while the user is selecting cells in the pivot. <br />
1)  Use the PivotGrid and IList interfaces, which provide access to the current PivotGridControl's data. <br />
2)  Copy this data from this list to any IList data source and bind the ChartControl to it.<br />
3)  Execute these steps when you need to rebind the ChartControl to data.</p>

<br/>


