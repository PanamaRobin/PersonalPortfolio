Imports System.Data.SqlClient
Public Class EliminarViajeros

    Private Sub EliminarViajeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        str = "Select * from Viajeros"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Dni.DataSource = tabla
        Dni.DisplayMember = "dni"
        Dni.ValueMember = "dni"
        CN.Close()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim dni2 As String = Dni.SelectedValue
        str = "Delete from Viajeros where dni = '" + dni2 + "'"
        If dni2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                Dni.ResetText()
            End If
        Else
            MsgBox("Seleccione el dni del viajero.")
        End If
    End Sub
End Class
