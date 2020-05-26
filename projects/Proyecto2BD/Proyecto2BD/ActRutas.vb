Imports System.Data.SqlClient
Public Class ActRutas
    Private Sub ActRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Rutas", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Rut.DataSource = tabla
        Rut.DisplayMember = "codruta"
        Rut.ValueMember = "codruta"
        CN.Close()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        Dim rut2 As String = Rut.SelectedValue
        str = "Select * from Rutas where codruta = '" + rut2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Ori.Text = reader.Item("codorigen")
            Des.Text = reader.Item("coddestino")
            Cos.Text = reader.Item("costoruta")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim str As String
        Dim rut2 As String = Rut.SelectedValue
        Dim ori2 As String = Ori.Text
        Dim des2 As String = Des.Text
        Dim cos2 As String = Cos.Text
        str = "Update Rutas set codorigen='" + ori2 + "',coddestino='" + des2 + "',costoruta='" + cos2 + "' where codruta='" + rut2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        Ori.Clear()
        Des.Clear()
        Cos.Clear()
        GroupBox1.Enabled = False
    End Sub
End Class
