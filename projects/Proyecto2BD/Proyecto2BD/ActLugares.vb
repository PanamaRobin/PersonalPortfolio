Imports System.Data.SqlClient
Public Class ActLugares
    Private Sub ActLugares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Lugares", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Lug.DataSource = tabla
        Lug.DisplayMember = "codlugar"
        Lug.ValueMember = "codlugar"
        CN.Close()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        Dim lug2 As String = Lug.SelectedValue
        str = "Select * from Lugares where codlugar = '" + lug2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Nom.Text = reader.Item("nombre")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim str As String
        Dim lug2 As String = Lug.SelectedValue
        Dim nom2 As String = Nom.Text
        str = "Update Lugares set nombre='" + nom2 + "' where codlugar='" + lug2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        Nom.Clear()
        GroupBox1.Enabled = False
    End Sub
End Class
