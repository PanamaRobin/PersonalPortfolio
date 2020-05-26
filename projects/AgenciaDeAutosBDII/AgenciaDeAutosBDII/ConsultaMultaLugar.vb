Imports System.Data.SqlClient
Public Class ConsultaMultaLugar
    Private Sub ConsultaMultaLugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Visible = False
        fecha.Visible = False
        Label3.Enabled = False
        fecha.Enabled = False

        Label4.Visible = False
        hora.Visible = False
        Label4.Enabled = False
        hora.Enabled = False

        busc.Enabled = False
    End Sub

    Private Sub hora_TextChanged(sender As Object, e As EventArgs) Handles hora.TextChanged
        If hora.Text <> "" Then
            busc.Enabled = True
        End If
    End Sub



    Private Sub filtro_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged
        If (filtro.SelectedItem = "fecha") Then
            Label4.Visible = False
            hora.Visible = False
            Label4.Enabled = False
            hora.Enabled = False

            Label3.Visible = True
            fecha.Visible = True
            Label3.Enabled = True
            fecha.Enabled = True
        End If
        If (filtro.SelectedItem = "hora") Then
            Label3.Visible = False
            fecha.Visible = False
            Label3.Enabled = False
            fecha.Enabled = False

            Label4.Visible = True
            hora.Visible = True
            Label4.Enabled = True
            hora.Enabled = True
        End If
    End Sub

    Private Sub busc_Click_1(sender As Object, e As EventArgs) Handles busc.Click
        If filtro.SelectedItem = "fecha" Then
            ABRIRCONEXION()
            Dim cmd As New SqlCommand("Select * from Multa where fecmulta = '" + fecha.Value.Date + "'", CN)
            Dim adp As New SqlDataAdapter(cmd)
            'Dim cmd2 = New SqlCommandBuilder(adp)
            Dim tabla As New DataTable
            adp.Fill(tabla)
            DataGridView1.DataSource = tabla
            CN.Close()
        End If
        If filtro.SelectedItem = "hora" Then
            ABRIRCONEXION()
            Dim cmd As New SqlCommand("Select * from Multa where hormulta = '" + hora.Text + "'", CN)
            Dim adp As New SqlDataAdapter(cmd)
            'Dim cmd2 = New SqlCommandBuilder(adp)
            Dim tabla As New DataTable
            adp.Fill(tabla)
            DataGridView1.DataSource = tabla
            CN.Close()
        End If
    End Sub

    Private Sub fecha_TextChanged(sender As Object, e As EventArgs) Handles fecha.TextChanged
        busc.Enabled = True
    End Sub
End Class
