Imports System.Data.SqlClient
Public Class ConsultarTours

    Private Sub ConsultarTours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        str = "Select * from Lugares"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Lug.DataSource = tabla
        Lug.DisplayMember = "nombre"
        Lug.ValueMember = "codlugar"
        CN.Close()
    End Sub

    Private Sub Lug_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lug.SelectedIndexChanged
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Tours where codlugar = '" + Lug.ValueMember.ToString + "'", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        DataGridView1.DataSource = tabla
        CN.Close()
    End Sub
End Class
