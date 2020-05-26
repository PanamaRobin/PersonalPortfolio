Imports System.Data.SqlClient
Public Class ActTenencia
    Private Sub ActTenencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        ABRIRCONEXION()
        Dim cmd As New SqlCommand("Select * from Tener", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        reg.DataSource = tabla
        reg.DisplayMember = "constener"
        reg.ValueMember = "constener"
        CN.Close()
    End Sub

    Private Sub busc_Click(sender As Object, e As EventArgs) Handles busc.Click
        Dim str As String
        Dim reg2 As String = reg.SelectedValue
        str = "Select * from Tener where constener = '" + reg2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            dni.Text = reader.Item("dnipersona")
            mat.Text = reader.Item("matrivehiculo")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub act_Click(sender As Object, e As EventArgs) Handles act.Click
        Dim str As String
        Dim reg2 As String = reg.SelectedValue
        Dim dni2 As String = dni.Text
        Dim mat2 As String = mat.Text
        'Dim opcion As MsgBoxResult
        str = "Update Vehiculo set dnipersona='" + dni2 + "',matrivehiculo='" + mat2 + "' where constener='" + reg2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        reg.Refresh()
        dni.Clear()
        mat.Clear()
    End Sub
End Class
