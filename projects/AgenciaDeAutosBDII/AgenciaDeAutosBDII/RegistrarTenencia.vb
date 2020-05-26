Public Class RegistrarTenencia
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        dni.Clear()
        matricula.Clear()
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Dim str As String
        Dim matricula2 As String = matricula.Text
        Dim dni2 As String = dni.Text
        str = "Insert into Tener(matrivehiculo, dnipersona) values('" + matricula2 + "','" + dni2 + "')"
        INSERTAR(str)
        dni.Clear()
        matricula.Clear()
    End Sub
End Class
