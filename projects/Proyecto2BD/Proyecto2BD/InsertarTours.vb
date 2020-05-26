Imports System.Data.SqlClient
Public Class InsertarTours
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Nom.Clear()
        Cos.Clear()
    End Sub

    Private Sub InsertarTours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Lugares", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Lug.DataSource = tabla
        Lug.DisplayMember = "nombre"
        Lug.ValueMember = "codlugar"
        CN.Close()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim lug2 As String = Lug.SelectedValue
        Dim nom2 As String = Nom.Text
        Dim cos2 As String = Cos.Text
        str = "Insert into Tours(codlugar,nomatraccion,costoatraccion) values('" + lug2 + "','" + nom2 + "','" + cos2 + "')"
        INSERTAR(str)
        Nom.Clear()
        Cos.Clear()
    End Sub
End Class
