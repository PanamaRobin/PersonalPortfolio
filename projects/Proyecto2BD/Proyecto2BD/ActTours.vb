Imports System.Data.SqlClient
Public Class ActTours
    Private Sub ActTours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Tours", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Tou.DisplayMember = "codtour"
        Tou.ValueMember = "codtour"
        Tou.DataSource = tabla
        CN.Close()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim str As String
        Dim tou2 As String = Tou.SelectedValue
        Dim lug2 As String = Lug.Text
        Dim nom2 As String = Nom.Text
        Dim cos2 As String = Cos.Text
        str = "Update Tours set codlugar='" + lug2 + "',nomatraccion='" + nom2 + "',costoatraccion='" + cos2 + "' where codtour='" + tou2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        Lug.Clear()
        Nom.Clear()
        Cos.Clear()
        GroupBox1.Enabled = False
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        Dim tou2 As String = Tou.SelectedValue
        str = "Select * from Tours where codtour = '" + tou2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Lug.Text = reader.Item("codlugar")
            Nom.Text = reader.Item("nomatraccion")
            Cos.Text = reader.Item("costoatraccion")
        End While
        reader.Close()
        CN.Close()
    End Sub
End Class
