Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DataAccess.UI.Sql

Namespace T292798
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            sqlDataSource1.Fill()
        End Sub

        Private Sub btConfigureConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btConfigureConnection.Click
            SqlDataSourceUIHelper.ConfigureConnection(sqlDataSource1)
        End Sub

        Private Sub btEditQuery_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btEditQuery.Click
            SqlDataSourceUIHelper.EditQuery(sqlDataSource1.Queries("DefaultQuery"))

            sqlDataSource1.Fill()

            gridView1.PopulateColumns()
        End Sub
    End Class
End Namespace
