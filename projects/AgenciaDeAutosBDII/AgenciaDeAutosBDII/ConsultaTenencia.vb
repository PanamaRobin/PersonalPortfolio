Imports System.Data.SqlClient
Public Class ConsultaTenencia
    Private Sub ConsultaTenencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ABRIRCONEXION()
        Dim cmd As New SqlCommand("Select Persona.nompersona from Persona,Tener where Persona.dnipersona = Tener.dnipersona", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim cmd2 = New SqlCommandBuilder(adp)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        per.DataSource = tabla
        per.DisplayMember = "nompersona"
        per.ValueMember = "nompersona"

        'Dim cmd As New SqlCommand("Select Persona.nompersona from Persona,Tener where Persona.dnipersona = Tener.dnipersona", CN)
        'reader = cmd.ExecuteReader
        'While reader.Read()
        '    per.AutoCompleteCustomSource.Add(reader.Item("nompersona"))
        '    per.Items.Add(reader.Item("nompersona"))
        'End While
        'reader.Close()
        CN.Close()
    End Sub
End Class
