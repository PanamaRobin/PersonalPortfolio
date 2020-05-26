Imports System.Data.SqlClient
Public Class EliminarRutas

    Private Sub EliminarRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        str = "Select * from Rutas"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Rut.DataSource = tabla
        Rut.DisplayMember = "codruta"
        Rut.ValueMember = "codruta"
        CN.Close()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim rut2 As String = Rut.SelectedValue
        str = "Delete from Rutas where codruta = '" + rut2 + "'"
        If rut2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                Rut.ResetText()
            End If
        Else
            MsgBox("Seleccione la ruta a eliminar.")
        End If
    End Sub
End Class
