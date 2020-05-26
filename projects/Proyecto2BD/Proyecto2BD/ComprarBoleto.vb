Imports System.Data.SqlClient
Public Class ComprarBoleto
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim CN As New SqlConnection(connectionName)
        GroupBox1.Enabled = True

        'LUGARES
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Lugares", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Lug.DisplayMember = "nombre"
        Lug.ValueMember = "codlugar"
        Lug.DataSource = tabla
        CN.Close()

        'AEROLINEAS
        CN.Open()
        Dim cmd2 As New SqlCommand("Select * from Aerolineas", CN)
        Dim adp2 As New SqlDataAdapter(cmd2)
        Dim tabla2 As New DataTable
        adp2.Fill(tabla2)
        Aer.DisplayMember = "nombre"
        Aer.ValueMember = "codaero"
        Aer.DataSource = tabla2
        CN.Close()
    End Sub

    Private Sub ComprarBoleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Viajeros", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Dni.DisplayMember = "dni"
        Dni.ValueMember = "dni"
        Dni.DataSource = tabla
        CN.Close()
    End Sub

    Private Sub Lug_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lug.SelectedIndexChanged
        Dim CN As New SqlConnection(connectionName)

        'HOTELES
        Hot.Enabled = True
        CN.Open()
        Dim lug2 As String = Lug.SelectedValue.ToString
        Dim cmd As New SqlCommand("Select * from Hoteles where codlugar = " + lug2, CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)

        Hot.DisplayMember = "nomhotel"
        Hot.ValueMember = "codhotel"
        Hot.DataSource = tabla
        CN.Close()

        'COSTO
        Dim str As String
        str = "Select * from Rutas where coddestino = '" + lug2 + "'"
        CN.Open()
        Dim cmd2 As New SqlCommand(str, CN)
        reader = cmd2.ExecuteReader
        While reader.Read()
            CosLug.Text = reader.Item("costoruta")
        End While
        reader.Close()
        CN.Close()

        'ATRACCIONES
        Atrrr.Visible = True
        CheckBox1.Visible = True
        CheckBox2.Visible = True
        CheckBox3.Visible = True

        Dim lst As List(Of String)
        Dim var As String = Lug.SelectedValue.ToString
        'str = "Select nomatraccion from Tours where codlugar = '" + Lug.SelectedValue.ToString + "'"

        'Dim cont As Integer
        'cont = 0

        'For Each checkbox In Me.Controls.OfType(Of CheckBox)
        '    cont += 1
        'Next

        Try
            lst = traerdatos(var)
            CheckBox1.Text = lst.Item(0)
            CheckBox2.Text = lst.Item(1)
            CheckBox3.Text = lst.Item(2)
        Catch ex As Exception
        End Try
        CN.Close()


        CN.Close()
    End Sub

    Private Sub Aer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Aer.SelectedIndexChanged
        Dim CN As New SqlConnection(connectionName)

        'COSTO
        Dim str As String
        str = "Select * from Aerolineas where codaero = '" + Aer.SelectedValue.ToString + "'"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            CosAer.Text = reader.Item("costoaero")
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub Hot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hot.SelectedIndexChanged
        Dim CN As New SqlConnection(connectionName)

        'HOTELES
        Hot.Enabled = True
        CN.Open()
        Dim hot2 As String = Hot.SelectedValue
        Dim str As String = "Select * from Hoteles where codhotel = '" + hot2 + "'"
        Dim cmd As New SqlCommand(Str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            CosHot.Text = reader.Item("costonoche")
        End While
        reader.Close()
        CN.Close()
    End Sub
End Class
