Imports System.Data.SqlClient
Public Class EliminarHoteles

    Private Sub EliminarHoteles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Hot.Enabled = True
        Dim str As String
        str = "Select * from Hoteles where codlugar = " + Lug.SelectedValue.ToString
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Hot.DisplayMember = "nomhotel"
        Hot.ValueMember = "nomhotel"
        Hot.DataSource = tabla
        CN.Close()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim hot2 As String = Hot.SelectedValue.ToString
        str = "Delete from Hoteles where codlugar = '" + Lug.SelectedValue.ToString + "' and nomhotel = '" + hot2 + "'"
        If hot2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                Lug.ResetText()
                Hot.ResetText()
            End If
        Else
            MsgBox("Seleccione el hotel a eliminar.")
        End If
    End Sub
End Class
