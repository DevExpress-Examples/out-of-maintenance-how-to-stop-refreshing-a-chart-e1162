Namespace ChartUpdateExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo10 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo11 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo12 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.Form1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.simpleButton1item = New DevExpress.XtraLayout.LayoutControlItem()
			Me.chartControl1item = New DevExpress.XtraLayout.LayoutControlItem()
			Me.pivotGridControl1item = New DevExpress.XtraLayout.LayoutControlItem()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.Form1layoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Form1layoutControl1ConvertedLayout.SuspendLayout()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.simpleButton1item, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.chartControl1item, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pivotGridControl1item, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldProductName1, Me.fieldSalesPerson1, Me.fieldExtendedPrice1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(465, 391)
			Me.pivotGridControl1.TabIndex = 0
            ' 
            ' excelDataSource1
            ' 
            Me.excelDataSource1.FileName = "SalesPerson.xlsx"
            Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "CategoryName"
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Country"
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "FirstName"
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "LastName"
			fieldInfo4.Type = GetType(String)
			fieldInfo5.Name = "ProductName"
			fieldInfo5.Type = GetType(String)
			fieldInfo6.Name = "Sales Person"
			fieldInfo6.Type = GetType(String)
			fieldInfo7.Name = "OrderDate"
			fieldInfo7.Type = GetType(Date)
			fieldInfo8.Name = "OrderID"
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "Quantity"
			fieldInfo9.Type = GetType(Double)
			fieldInfo10.Name = "Discount"
			fieldInfo10.Type = GetType(Double)
			fieldInfo11.Name = "Extended Price"
			fieldInfo11.Type = GetType(Double)
			fieldInfo12.Name = "UnitPrice"
			fieldInfo12.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9, fieldInfo10, fieldInfo11, fieldInfo12})
			excelWorksheetSettings1.CellRange = Nothing
            excelWorksheetSettings1.WorksheetName = "Data"
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.excelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' chartControl1
			' 
			Me.chartControl1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chartControl1.Legend.Name = "Default Legend"
			Me.chartControl1.Location = New System.Drawing.Point(481, 12)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.Size = New System.Drawing.Size(330, 391)
			Me.chartControl1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 407)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(799, 22)
			Me.simpleButton1.StyleController = Me.Form1layoutControl1ConvertedLayout
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Update Chart"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			' 
			' Form1layoutControl1ConvertedLayout
			' 
			Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.simpleButton1)
			Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.chartControl1)
			Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.pivotGridControl1)
			Me.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
			Me.Form1layoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
			Me.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout"
			Me.Form1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
			Me.Form1layoutControl1ConvertedLayout.Size = New System.Drawing.Size(823, 441)
			Me.Form1layoutControl1ConvertedLayout.TabIndex = 3
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.simpleButton1item, Me.chartControl1item, Me.pivotGridControl1item})
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(823, 441)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' simpleButton1item
			' 
			Me.simpleButton1item.Control = Me.simpleButton1
			Me.simpleButton1item.Location = New System.Drawing.Point(0, 395)
			Me.simpleButton1item.Name = "simpleButton1item"
			Me.simpleButton1item.Size = New System.Drawing.Size(803, 26)
			Me.simpleButton1item.TextSize = New System.Drawing.Size(0, 0)
			Me.simpleButton1item.TextVisible = False
			' 
			' chartControl1item
			' 
			Me.chartControl1item.Control = Me.chartControl1
			Me.chartControl1item.Location = New System.Drawing.Point(469, 0)
			Me.chartControl1item.Name = "chartControl1item"
			Me.chartControl1item.Size = New System.Drawing.Size(334, 395)
			Me.chartControl1item.TextSize = New System.Drawing.Size(0, 0)
			Me.chartControl1item.TextVisible = False
			' 
			' pivotGridControl1item
			' 
			Me.pivotGridControl1item.Control = Me.pivotGridControl1
			Me.pivotGridControl1item.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1item.Name = "pivotGridControl1item"
			Me.pivotGridControl1item.Size = New System.Drawing.Size(469, 395)
			Me.pivotGridControl1item.TextSize = New System.Drawing.Size(0, 0)
			Me.pivotGridControl1item.TextVisible = False
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName1.AreaIndex = 0
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson1.AreaIndex = 0
			Me.fieldSalesPerson1.Caption = "Sales Person"
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			' 
			' Form1
			' 
			Me.ClientSize = New System.Drawing.Size(823, 441)
			Me.Controls.Add(Me.Form1layoutControl1ConvertedLayout)
			Me.Name = "Form1"
			Me.Text = "ChartUpdateExample"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.Form1layoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
			Me.Form1layoutControl1ConvertedLayout.ResumeLayout(False)
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.simpleButton1item, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.chartControl1item, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pivotGridControl1item, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private Form1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private simpleButton1item As DevExpress.XtraLayout.LayoutControlItem
		Private chartControl1item As DevExpress.XtraLayout.LayoutControlItem
		Private pivotGridControl1item As DevExpress.XtraLayout.LayoutControlItem
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

