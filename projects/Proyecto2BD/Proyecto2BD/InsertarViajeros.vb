Public Class InsertarViajeros
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Nom.Clear()
        Dni.Clear()
        Tel.Clear()
        Dir.Clear()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim nom2 As String = Nom.Text
        Dim dni2 As String = Dni.Text
        Dim tel2 As String = Tel.Text
        Dim dir2 As String = Dir.Text
        str = "Insert into Viajeros(dni, nombre,	direccion, tel) values('" + dni2 + "','" + nom2 + "','" + dir2 + "','" + tel2 + "')"
        INSERTAR(str)
        Nom.Clear()
        Dni.Clear()
        Tel.Clear()
        Dir.Clear()
    End Sub
End Class
