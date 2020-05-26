Imports System.Data.SqlClient
Public Class ConsultaMulta
    Private Sub ConsultaMulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ABRIRCONEXION()
        Dim cmd As New SqlCommand("Select * from Multa", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim cmd2 = New SqlCommandBuilder(adp)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        DataGridView1.DataSource = tabla
        CN.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ABRIRCONEXION()
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        Dim cmd2 As New SqlCommand("Select Persona.dnipersona, Persona.nompersona from Persona, Aplica where Aplica.dnipersona = Persona.dnipersona and Aplica.numrefemulta = '" + dgv.Cells(0).Value.ToString() + "'", CN)
        Dim adp2 As New SqlDataAdapter(cmd2)
        Dim tabla2 As New DataTable
        adp2.Fill(tabla2)
        DataGridView2.DataSource = tabla2
        CN.Close()
    End Sub
End Class
