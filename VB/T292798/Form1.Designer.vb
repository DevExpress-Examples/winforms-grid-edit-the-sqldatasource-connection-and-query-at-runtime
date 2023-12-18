Namespace T292798

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim allColumns1 As DevExpress.DataAccess.Sql.AllColumns = New DevExpress.DataAccess.Sql.AllColumns()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T292798.Form1))
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
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
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "Northwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""248"" />"
            table1.Name = "Products"
            allColumns1.Table = table1
            selectQuery1.Columns.Add(allColumns1)
            selectQuery1.Name = "DefaultQuery"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
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
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued})
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
            AddHandler Me.btConfigureConnection.Click, New System.EventHandler(AddressOf Me.btConfigureConnection_Click)
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
            AddHandler Me.btEditQuery.Click, New System.EventHandler(AddressOf Me.btEditQuery_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(632, 278)
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        Private btConfigureConnection As System.Windows.Forms.Button

        Private btEditQuery As System.Windows.Forms.Button

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
