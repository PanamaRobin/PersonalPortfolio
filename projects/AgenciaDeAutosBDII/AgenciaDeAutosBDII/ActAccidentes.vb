Imports System.Data.SqlClient
Public Class ActAccidentes
    Private Sub ActAccidentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        ABRIRCONEXION()
        Dim cmd As New SqlCommand("Select * from Accidente", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        ref.DataSource = tabla
        ref.DisplayMember = "numreferencia"
        ref.ValueMember = "numreferencia"
        CN.Close()
    End Sub

    Private Sub busc_Click(sender As Object, e As EventArgs) Handles busc.Click
        Dim str As String
        Dim ref2 As String = ref.SelectedValue
        str = "Select * from Accidente where numreferencia = '" + ref2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            lug.Text = reader.Item("lugaccidente")
            fecha.Value = reader.Item("fechaccidente")
            hora.Text = reader.Item("horaccidente")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub act_Click(sender As Object, e As EventArgs) Handles act.Click
        Dim str As String
        Dim ref2 As String = ref.SelectedValue
        Dim lug2 As String = lug.Text
        str = "Update Accidente set lugaccidente='" + lug2 + "',fechaccidente='" + fecha.Value.Date + "',horaccidente='" + hora.Text + "' where numreferencia='" + ref2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        ref.Refresh()
        lug.Clear()
        fecha.ResetText()
        hora.Clear()
    End Sub
End Class
