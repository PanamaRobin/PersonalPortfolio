Public Class InsertarAerolineas
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Nom.Clear()
        Cos.Clear()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim nom2 As String = Nom.Text
        Dim cos2 As String = Cos.Text
        str = "Insert into Aerolineas(nombre, costoaero) values('" + nom2 + "','" + cos2 + "')"
        INSERTAR(str)
        Nom.Clear()
        Cos.Clear()
    End Sub
End Class
