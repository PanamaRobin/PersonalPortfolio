Imports System.Data.SqlClient
Public Class EliminarTours

    Private Sub EliminarTours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Atr.Enabled = True
        Dim str As String
        str = "Select * from Tours where codlugar = '" + Lug.SelectedValue.ToString + "'"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Atr.DisplayMember = "nomatraccion"
        Atr.ValueMember = "nomatraccion"
        Atr.DataSource = tabla
        CN.Close()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim atr2 As String = Atr.SelectedValue
        str = "Delete from Tours where codlugar = '" + Lug.SelectedValue.ToString + "' and nomatraccion = '" + atr2 + "'"
        If atr2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                Lug.ResetText()
                Atr.ResetText()
            End If
        Else
            MsgBox("Seleccione la atraccion a eliminar.")
        End If
    End Sub
End Class
