Imports System.Data.SqlClient
Public Class EliminarAerolineas

    Private Sub EliminarAerolineas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        str = "Select * from Aerolineas"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Aer.DataSource = tabla
        Aer.DisplayMember = "nombre"
        Aer.ValueMember = "codaero"
        CN.Close()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        Dim aer2 As String = Aer.SelectedValue
        str = "Delete from Aerolineas where codaero = '" + aer2 + "'"
        If aer2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                Aer.ResetText()
            End If
        Else
            MsgBox("Seleccione la aerolinea a eliminar.")
        End If
    End Sub
End Class
