Imports System.Data.SqlClient
Public Class InsertarViajes

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim CN As New SqlConnection(connectionName)
        Nac.Enabled = True
        Int.Enabled = False
        Nac.Visible = True
        Int.Visible = False

        'NACIONALES
        Dim str As String
        str = "Select * from Rutas where codruta like 'n%'"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Nac.DataSource = tabla
        Nac.DisplayMember = "codruta"
        Nac.ValueMember = "codruta"
        CN.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim CN As New SqlConnection(connectionName)
        Nac.Enabled = False
        Int.Enabled = True
        Nac.Visible = False
        Int.Visible = True

        'INTERNACIONALES
        Dim str As String
        CN.Open()
        str = "Select * from Rutas where codruta like 'i%'"
        Dim cmd As New SqlCommand(str, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Int.DataSource = tabla
        Int.DisplayMember = "codruta"
        Int.ValueMember = "codruta"
        CN.Close()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Hor.Clear()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim rut2 As String = ""
        If (RadioButton1.Checked = True) Then
            rut2 = Nac.SelectedValue
        End If
        If (RadioButton2.Checked = True) Then
            rut2 = Int.SelectedValue
        End If
        str = "Insert into Viajes(numpasajeros, fecha, hora, codruta) values('0','" + Fec.Value.Date + "','" + Hor.Text + "','" + rut2 + "')"
        INSERTAR(str)
        Hor.Clear()
    End Sub
End Class
