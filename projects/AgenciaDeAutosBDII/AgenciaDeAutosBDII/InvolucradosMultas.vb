Public Class InvolucradosMultas
    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Dim str As String
        Dim ref2 As String = ref.Text
        Dim dni2 As String = dni.Text
        Dim mat2 As String = mat.Text
        str = "Insert into Aplica(numrefemulta,	dnipersona,	matrivehiculo) values('" + ref2 + "','" + dni2 + "','" + mat2 + "')"
        INSERTAR(str)
        ref.Clear()
        dni.Clear()
        mat.Clear()
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        ref.Clear()
        dni.Clear()
        mat.Clear()
    End Sub
End Class
