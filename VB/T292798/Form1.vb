Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.DataAccess.UI.Sql

Namespace T292798

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            sqlDataSource1.Fill()
        End Sub

        Private Sub btConfigureConnection_Click(ByVal sender As Object, ByVal e As EventArgs)
            sqlDataSource1.ConfigureConnection
        End Sub

        Private Sub btEditQuery_Click(ByVal sender As Object, ByVal e As EventArgs)
            sqlDataSource1.Queries("DefaultQuery").EditQuery()
            sqlDataSource1.Fill()
            gridView1.PopulateColumns()
        End Sub
    End Class
End Namespace
