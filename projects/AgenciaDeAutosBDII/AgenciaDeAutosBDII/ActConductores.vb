Imports System.Data.SqlClient
Public Class ActConductores
    Private Sub ActConductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        ABRIRCONEXION()
        Dim cmd As New SqlCommand("Select * from Persona", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        dni.DataSource = tabla
        dni.DisplayMember = "dnipersona"
        dni.ValueMember = "dnipersona"
        CN.Close()
    End Sub

    Private Sub busc_Click(sender As Object, e As EventArgs) Handles busc.Click
        Dim str As String
        Dim dni2 As String = dni.SelectedValue
        str = "Select * from Persona where dnipersona = '" + dni2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            nom.Text = reader.Item("nompersona")
            ape.Text = reader.Item("apepersona")
            dir.Text = reader.Item("direcpersona")
            pob.Text = reader.Item("poblacion")
            tel.Text = reader.Item("telefono")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub act_Click_1(sender As Object, e As EventArgs) Handles act.Click
        Dim str As String
        Dim dni2 As String = dni.SelectedValue
        Dim nom2 As String = nom.Text
        Dim ape2 As String = ape.Text
        Dim tel2 As String = tel.Text
        Dim pob2 As String = pob.Text
        Dim dir2 As String = dir.Text
        'Dim opcion As MsgBoxResult
        str = "Update Persona set nompersona='" + nom2 + "',apepersona='" + ape2 + "',direcpersona='" + dir2 + "',poblacion='" + pob2 + "',telefono='" + tel2 + "' where dnipersona='" + dni2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        dni.Refresh()
        nom.Clear()
        ape.Clear()
        dir.Clear()
        pob.Clear()
        tel.Clear()
    End Sub
End Class
