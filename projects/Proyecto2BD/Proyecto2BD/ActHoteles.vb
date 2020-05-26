Imports System.Data.SqlClient
Public Class ActHoteles
    Private Sub ActHoteles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Hoteles", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Hot.DataSource = tabla
        Hot.DisplayMember = "codhotel"
        Hot.ValueMember = "codhotel"
        CN.Close()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        Dim hot2 As String = Hot.SelectedValue
        str = "Select * from Hoteles where codhotel = '" + hot2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Lug.Text = reader.Item("codlugar")
            Nom.Text = reader.Item("nomhotel")
            Cos.Text = reader.Item("costonoche")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim str As String
        Dim hot2 As String = Hot.SelectedValue
        Dim lug2 As String = Lug.Text
        Dim nom2 As String = Nom.Text
        Dim cos2 As String = Cos.Text
        str = "Update Hoteles set codlugar='" + lug2 + "',nomhotel='" + nom2 + "',costonoche='" + cos2 + "' where codhotel='" + hot2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        Lug.Clear()
        Nom.Clear()
        Cos.Clear()
        GroupBox1.Enabled = False
    End Sub
End Class
