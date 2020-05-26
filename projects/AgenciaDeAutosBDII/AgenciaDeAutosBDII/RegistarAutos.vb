Public Class RegistarAutos
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        matricula.Clear()
        marca.Clear()
        modelo.Clear()
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Dim str As String
        Dim matricula2 As String = matricula.Text
        Dim marca2 As String = marca.Text
        Dim modelo2 As String = modelo.Text
        str = "Insert into Vehiculo(matrivehiculo, marcvehiculo, modevehiculo) values('" + matricula2 + "','" + marca2 + "','" + modelo2 + "')"
        INSERTAR(str)
        matricula.Clear()
        marca.Clear()
        modelo.Clear()
    End Sub
End Class
