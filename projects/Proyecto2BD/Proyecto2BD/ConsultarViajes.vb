Imports System.Data.SqlClient
Public Class ConsultarViajes
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim CN As New SqlConnection(connectionName)
        'NACIONALES
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Viajes where codruta like 'n%'", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        DataGridView1.DataSource = tabla
        CN.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim CN As New SqlConnection(connectionName)
        'INTERNACIONALES
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Viajes where codruta like 'i%'", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        DataGridView1.DataSource = tabla
        CN.Close()
    End Sub
End Class
