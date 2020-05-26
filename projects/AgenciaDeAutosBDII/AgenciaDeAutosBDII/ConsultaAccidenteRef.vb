Imports System.Data.SqlClient
Public Class ConsultaAccidenteRef
    Private Sub ref_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ref.SelectedIndexChanged
        ABRIRCONEXION()
        Dim cmd As New SqlCommand("Select * from Accidente where numreferencia = '" + ref.Text + "'", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        DataGridView1.DataSource = tabla
        CN.Close()

        ABRIRCONEXION()
        Dim cmd2 As New SqlCommand("Select Persona.dnipersona, Persona.nompersona from Persona, Involucra where Involucra.dnipersona = Persona.dnipersona and Involucra.numreferencia = '" + ref.Text + "'", CN)
        Dim adp2 As New SqlDataAdapter(cmd2)
        Dim tabla2 As New DataTable
        adp2.Fill(tabla2)
        DataGridView2.DataSource = tabla2
        CN.Close()
    End Sub

    Private Sub ConsultaAccidenteRef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class
