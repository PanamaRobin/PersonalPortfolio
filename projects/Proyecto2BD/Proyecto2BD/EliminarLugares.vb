Imports System.Data.SqlClient
Public Class EliminarLugares

    Private Sub EliminarLugares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim lug2 As String = Lug.SelectedValue
        str = "Delete from Lugares where codlugar = '" + lug2 + "'"
        If lug2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                Lug.ResetText()
            End If
        Else
            MsgBox("Seleccione el lugar a eliminar.")
        End If
    End Sub
End Class
