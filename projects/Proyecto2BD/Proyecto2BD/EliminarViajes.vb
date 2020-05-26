Imports System.Data.SqlClient
Public Class EliminarViajes

    Private Sub EliminarViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        str = "Select * from Viajes"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Via.DataSource = tabla
        Via.DisplayMember = "codviaje"
        Via.ValueMember = "codviaje"
        CN.Close()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim via2 As String = Via.SelectedValue
        str = "Delete from Viajes where codviaje = '" + via2 + "'"
        If via2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                Via.ResetText()
            End If
        Else
            MsgBox("Seleccione el codigo del viaje.")
        End If
    End Sub
End Class
