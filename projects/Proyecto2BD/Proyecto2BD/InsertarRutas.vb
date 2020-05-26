Imports System.Data.SqlClient
Public Class InsertarRutas
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Cod.Clear()
        Ori.Clear()
        Des.Clear()
        Cos.Clear()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim cod2 As String = Cod.Text
        Dim ori2 As String = Ori.Text
        Dim des2 As String = Des.Text
        Dim cos2 As String = Cos.Text
        str = "Insert into Rutas(codruta,codorigen,coddestino,costoruta) values('" + cod2 + "','" + ori2 + "','" + des2 + "','" + cos2 + "')"
        INSERTAR(str)
        Cod.Clear()
        Ori.Clear()
        Des.Clear()
        Cos.Clear()
    End Sub

    Private Sub InsertarRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        ''INTERNACIONALES
        Dim str As String
        str = "Select top 1 * from Rutas where codruta like 'i%' order by codruta desc"
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Int.Text = reader.Item("codruta")
        End While
        reader.Close()
        CN.Close()

        ''NACIONALES
        str = "Select top 1 * from Rutas where codruta like 'n%' order by codruta desc"
        CN.Open()
        cmd = New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Nac.Text = reader.Item("codruta")
        End While
        reader.Close()
        CN.Close()
    End Sub
End Class
