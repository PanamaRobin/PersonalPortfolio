Imports System.Data.SqlClient
Public Class ActAutos
    Private Sub ActAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        ABRIRCONEXION()
        Dim cmd As New SqlCommand("Select * from Vehiculo", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        mat.DataSource = tabla
        mat.DisplayMember = "matrivehiculo"
        mat.ValueMember = "matrivehiculo"
        CN.Close()
    End Sub

    Private Sub act_Click(sender As Object, e As EventArgs) Handles act.Click
        Dim str As String
        Dim mat2 As String = mat.SelectedValue
        Dim mar2 As String = mar.Text
        Dim modelo2 As String = modelo.Text
        'Dim opcion As MsgBoxResult
        str = "Update Vehiculo set marcvehiculo='" + mar2 + "',modevehiculo='" + modelo2 + "' where matrivehiculo='" + mat2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        mat.Refresh()
        mar.Clear()
        modelo.Clear()
    End Sub

    Private Sub busc_Click(sender As Object, e As EventArgs) Handles busc.Click
        Dim str As String
        Dim mat2 As String = mat.SelectedValue
        str = "Select * from Vehiculo where matrivehiculo = '" + mat2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            mar.Text = reader.Item("nompersona")
            modelo.Text = reader.Item("apepersona")
        End While
        reader.Close()
        CN.Close()
    End Sub
End Class
