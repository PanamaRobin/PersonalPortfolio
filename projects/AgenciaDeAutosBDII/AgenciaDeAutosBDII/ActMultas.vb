Imports System.Data.SqlClient
Public Class ActMultas
    Private Sub ActMultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        ABRIRCONEXION()
        Dim cmd As New SqlCommand("Select * from Multa", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        reff.DataSource = tabla
        reff.DisplayMember = "numrefemulta"
        reff.ValueMember = "numrefemulta"
        CN.Close()
    End Sub

    Private Sub busc_Click(sender As Object, e As EventArgs) Handles busc.Click
        Dim str As String
        Dim ref2 As String = reff.SelectedValue
        str = "Select * from Multa where numrefemulta = '" + ref2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            lug.Text = reader.Item("lugmulta")
            fec.Text = reader.Item("fecmulta")
            hora.Text = reader.Item("hormulta")
            mon.Text = reader.Item("impomulta")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub act_Click(sender As Object, e As EventArgs) Handles act.Click
        Dim str As String
        Dim ref2 As String = reff.SelectedValue
        Dim lug2 As String = lug.Text
        Dim fec2 As String = fec.Text
        Dim hora2 As String = hora.Text
        Dim mon2 As String = mon.Text
        str = "Update Multa set lugmulta='" + lug2 + "',fecmulta='" + fec2 + "',hormulta='" + hora2 + "',impomulta='" + mon2 + "' where numrefemulta='" + ref2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        reff.Refresh()
        lug.Clear()
        fec.Clear()
        hora.Clear()
        mon.Clear()
    End Sub
End Class
