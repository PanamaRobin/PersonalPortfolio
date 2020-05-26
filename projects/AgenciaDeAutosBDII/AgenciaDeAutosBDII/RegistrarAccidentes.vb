Public Class RegistrarAccidentes
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        ref.Clear()
        lugar.Clear()
        fecha.ResetText()
        hora.Clear()
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Dim str As String
        Dim ref2 As String = ref.Text
        Dim lugar2 As String = lugar.Text
        'Dim fecha2 As String = fecha.ToString
        'Dim hora2 As String = hora.Text
        'MsgBox(fecha.Value.Date)
        str = "Insert into Accidente(numreferencia,	fechaccidente,	lugaccidente, horaccidente) values('" + ref2 + "','" + fecha.Value.Date + "','" + lugar2 + "','" + hora.Text + "')"
        INSERTAR(str)
        ref.Clear()
        lugar.Clear()
        fecha.ResetText()
        hora.Clear()
    End Sub
End Class
