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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim FieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo10 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo11 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo12 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim ExcelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim ExcelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(ExcelWorksheetSettings1)
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.Form1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.simpleButton1item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.chartControl1item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pivotGridControl1item = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Form1layoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Form1layoutControl1ConvertedLayout.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleButton1item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartControl1item, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotGridControl1item, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName, Me.fieldSalesPerson, Me.fieldExtendedPrice})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(465, 391)
            Me.pivotGridControl1.TabIndex = 0
            '
            'excelDataSource1
            '
            Me.excelDataSource1.FileName = "SalesPerson.xlsx"
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            FieldInfo1.Name = "CategoryName"
            FieldInfo1.OriginalName = Nothing
            FieldInfo1.Type = GetType(String)
            FieldInfo2.Name = "Country"
            FieldInfo2.OriginalName = Nothing
            FieldInfo2.Type = GetType(String)
            FieldInfo3.Name = "FirstName"
            FieldInfo3.OriginalName = Nothing
            FieldInfo3.Type = GetType(String)
            FieldInfo4.Name = "LastName"
            FieldInfo4.OriginalName = Nothing
            FieldInfo4.Type = GetType(String)
            FieldInfo5.Name = "ProductName"
            FieldInfo5.OriginalName = Nothing
            FieldInfo5.Type = GetType(String)
            FieldInfo6.Name = "Sales Person"
            FieldInfo6.OriginalName = Nothing
            FieldInfo6.Type = GetType(String)
            FieldInfo7.Name = "OrderDate"
            FieldInfo7.OriginalName = Nothing
            FieldInfo7.Type = GetType(Date)
            FieldInfo8.Name = "OrderID"
            FieldInfo8.OriginalName = Nothing
            FieldInfo8.Type = GetType(Double)
            FieldInfo9.Name = "Quantity"
            FieldInfo9.OriginalName = Nothing
            FieldInfo9.Type = GetType(Double)
            FieldInfo10.Name = "Discount"
            FieldInfo10.OriginalName = Nothing
            FieldInfo10.Type = GetType(Double)
            FieldInfo11.Name = "Extended Price"
            FieldInfo11.OriginalName = Nothing
            FieldInfo11.Type = GetType(Double)
            FieldInfo12.Name = "UnitPrice"
            FieldInfo12.OriginalName = Nothing
            FieldInfo12.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {FieldInfo1, FieldInfo2, FieldInfo3, FieldInfo4, FieldInfo5, FieldInfo6, FieldInfo7, FieldInfo8, FieldInfo9, FieldInfo10, FieldInfo11, FieldInfo12})
            ExcelWorksheetSettings1.CellRange = Nothing
            ExcelWorksheetSettings1.WorksheetIndex = Nothing
            ExcelWorksheetSettings1.WorksheetName = "Data"
            ExcelSourceOptions1.ImportSettings = ExcelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = ExcelSourceOptions1
            '
            'fieldProductName
            '
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product Name"
            DataSourceColumnBinding1.ColumnName = "ProductName"
            Me.fieldProductName.DataBinding = DataSourceColumnBinding1
            Me.fieldProductName.Name = "fieldProductName"
            '
            'fieldSalesPerson
            '
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson.AreaIndex = 0
            Me.fieldSalesPerson.Caption = "Sales Person"
            DataSourceColumnBinding2.ColumnName = "Sales Person"
            Me.fieldSalesPerson.DataBinding = DataSourceColumnBinding2
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            DataSourceColumnBinding3.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = DataSourceColumnBinding3
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Location = New System.Drawing.Point(481, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.Size = New System.Drawing.Size(330, 391)
            Me.chartControl1.TabIndex = 1
            '
            'simpleButton1
            '
            Me.simpleButton1.Location = New System.Drawing.Point(12, 407)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(799, 22)
            Me.simpleButton1.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.simpleButton1.TabIndex = 2
            Me.simpleButton1.Text = "Update Chart"
            '
            'Form1layoutControl1ConvertedLayout
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
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.simpleButton1item, Me.chartControl1item, Me.pivotGridControl1item})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(823, 441)
            Me.layoutControlGroup1.TextVisible = False
            '
            'simpleButton1item
            '
            Me.simpleButton1item.Control = Me.simpleButton1
            Me.simpleButton1item.Location = New System.Drawing.Point(0, 395)
            Me.simpleButton1item.Name = "simpleButton1item"
            Me.simpleButton1item.Size = New System.Drawing.Size(803, 26)
            Me.simpleButton1item.TextSize = New System.Drawing.Size(0, 0)
            Me.simpleButton1item.TextVisible = False
            '
            'chartControl1item
            '
            Me.chartControl1item.Control = Me.chartControl1
            Me.chartControl1item.Location = New System.Drawing.Point(469, 0)
            Me.chartControl1item.Name = "chartControl1item"
            Me.chartControl1item.Size = New System.Drawing.Size(334, 395)
            Me.chartControl1item.TextSize = New System.Drawing.Size(0, 0)
            Me.chartControl1item.TextVisible = False
            '
            'pivotGridControl1item
            '
            Me.pivotGridControl1item.Control = Me.pivotGridControl1
            Me.pivotGridControl1item.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1item.Name = "pivotGridControl1item"
            Me.pivotGridControl1item.Size = New System.Drawing.Size(469, 395)
            Me.pivotGridControl1item.TextSize = New System.Drawing.Size(0, 0)
            Me.pivotGridControl1item.TextVisible = False
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(823, 441)
            Me.Controls.Add(Me.Form1layoutControl1ConvertedLayout)
            Me.Name = "Form1"
            Me.Text = "ChartUpdateExample"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Form1layoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Form1layoutControl1ConvertedLayout.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleButton1item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1item, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotGridControl1item, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

