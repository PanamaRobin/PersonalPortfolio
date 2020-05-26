Public Class InsertarLugares
    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim str As String
        Dim nom2 As String = Nom.Text
        str = "Insert into Lugares(nombre) values('" + nom2 + "')"
        INSERTAR(str)
        Nom.Clear()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Nom.Clear()
    End Sub
End Class
