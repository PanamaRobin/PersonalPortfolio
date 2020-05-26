Imports System.Data.SqlClient
Public Class ActViajeros
    Private Sub ActViajeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Viajeros", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Dni.DataSource = tabla
        Dni.DisplayMember = "dni"
        Dni.ValueMember = "dni"
        CN.Close()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        Dim dni2 As String = Dni.SelectedValue
        str = "Select * from Viajeros where dni = '" + dni2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Nom.Text = reader.Item("nombre")
            Tel.Text = reader.Item("tel")
            Dir.Text = reader.Item("direccion")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim str As String
        Dim dni2 As String = Dni.SelectedValue
        Dim nom2 As String = Nom.Text
        Dim tel2 As String = Tel.Text
        Dim dir2 As String = Dir.Text
        str = "Update Viajeros set nombre='" + nom2 + "',direccion='" + dir2 + "',tel='" + tel2 + "' where dni='" + dni2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        Nom.Clear()
        Tel.Clear()
        Dir.Clear()
        GroupBox1.Enabled = False
    End Sub
End Class
