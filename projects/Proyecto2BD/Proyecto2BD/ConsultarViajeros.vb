Imports System.Data.SqlClient
Public Class ConsultarViajeros

    Private Sub ConsultarViajeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Viajeros", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        DataGridView1.DataSource = tabla
        CN.Close()
    End Sub
End Class
