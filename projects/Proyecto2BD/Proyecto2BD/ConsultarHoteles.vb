Imports System.Data.SqlClient
Public Class ConsultarHoteles

    Private Sub ConsultarHoteles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        str = "Select * from Lugares"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)

        Lug.DisplayMember = "nombre"
        Lug.ValueMember = "codlugar"
        Lug.DataSource = tabla
        CN.Close()
    End Sub

    Private Sub Lug_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lug.SelectedIndexChanged
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Hoteles where codlugar = '" + Lug.SelectedValue.ToString + "'", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        DataGridView1.DataSource = tabla
        CN.Close()
    End Sub
End Class
