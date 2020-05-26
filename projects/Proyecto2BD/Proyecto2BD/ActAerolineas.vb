Imports System.Data.SqlClient
Public Class ActAerolineas
    Private Sub ActAerolineas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Aerolineas", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Aer.DataSource = tabla
        Aer.DisplayMember = "codaero"
        Aer.ValueMember = "codaero"
        CN.Close()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        Dim aer2 As String = Aer.SelectedValue
        str = "Select * from Aerolineas where codaero = '" + aer2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Nom.Text = reader.Item("nombre")
            Cos.Text = reader.Item("costoaero")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim str As String
        Dim aer2 As String = Aer.SelectedValue
        Dim nom2 As String = Nom.Text
        Dim cos2 As String = Cos.Text
        str = "Update Aerolineas set nombre='" + nom2 + "',costoaero='" + cos2 + "' where codaero='" + aer2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        Nom.Clear()
        Cos.Clear()
        GroupBox1.Enabled = False
    End Sub
End Class
