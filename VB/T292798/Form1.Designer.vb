Namespace T292798
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
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.btConfigureConnection = New System.Windows.Forms.Button()
            Me.btEditQuery = New System.Windows.Forms.Button()
            Me.tableLayoutPanel1.SuspendLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "Northwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "DefaultQuery"
            tableInfo1.Name = "Products"
            columnInfo1.Name = "ProductID"
            columnInfo2.Name = "ProductName"
            columnInfo3.Name = "SupplierID"
            columnInfo4.Name = "CategoryID"
            columnInfo5.Name = "QuantityPerUnit"
            columnInfo6.Name = "UnitPrice"
            columnInfo7.Name = "UnitsInStock"
            columnInfo8.Name = "UnitsOnOrder"
            columnInfo9.Name = "ReorderLevel"
            columnInfo10.Name = "Discontinued"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.Controls.Add(Me.gridControl1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.btConfigureConnection, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.btEditQuery, 1, 1)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 3
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(632, 278)
            Me.tableLayoutPanel1.TabIndex = 1
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataMember = "DefaultQuery"
            Me.gridControl1.DataSource = Me.sqlDataSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(3, 3)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.tableLayoutPanel1.SetRowSpan(Me.gridControl1, 3)
            Me.gridControl1.Size = New System.Drawing.Size(495, 272)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colProductID
            ' 
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            Me.colProductID.Visible = True
            Me.colProductID.VisibleIndex = 0
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            ' 
            ' colSupplierID
            ' 
            Me.colSupplierID.FieldName = "SupplierID"
            Me.colSupplierID.Name = "colSupplierID"
            Me.colSupplierID.Visible = True
            Me.colSupplierID.VisibleIndex = 2
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.Visible = True
            Me.colCategoryID.VisibleIndex = 3
            ' 
            ' colQuantityPerUnit
            ' 
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            Me.colQuantityPerUnit.Visible = True
            Me.colQuantityPerUnit.VisibleIndex = 4
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 5
            ' 
            ' colUnitsInStock
            ' 
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.Visible = True
            Me.colUnitsInStock.VisibleIndex = 6
            ' 
            ' colUnitsOnOrder
            ' 
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            Me.colUnitsOnOrder.Visible = True
            Me.colUnitsOnOrder.VisibleIndex = 7
            ' 
            ' colReorderLevel
            ' 
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            Me.colReorderLevel.Visible = True
            Me.colReorderLevel.VisibleIndex = 8
            ' 
            ' colDiscontinued
            ' 
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 9
            ' 
            ' btConfigureConnection
            ' 
            Me.btConfigureConnection.Location = New System.Drawing.Point(504, 3)
            Me.btConfigureConnection.Name = "btConfigureConnection"
            Me.btConfigureConnection.Size = New System.Drawing.Size(125, 23)
            Me.btConfigureConnection.TabIndex = 1
            Me.btConfigureConnection.Text = "Configure Connection"
            Me.btConfigureConnection.UseVisualStyleBackColor = True
            ' 
            ' btEditQuery
            ' 
            Me.btEditQuery.AutoSize = True
            Me.btEditQuery.Location = New System.Drawing.Point(504, 32)
            Me.btEditQuery.Name = "btEditQuery"
            Me.btEditQuery.Size = New System.Drawing.Size(125, 23)
            Me.btEditQuery.TabIndex = 2
            Me.btEditQuery.Text = "Edit Query"
            Me.btEditQuery.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(632, 278)
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private WithEvents btConfigureConnection As System.Windows.Forms.Button
        Private WithEvents btEditQuery As System.Windows.Forms.Button
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colSupplierID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
        Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn

    End Class
End Namespace

