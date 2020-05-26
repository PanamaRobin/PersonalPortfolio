Public Class RegistrarMultas
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        ref.Clear()
        lugar.Clear()
        fecha.ResetText()
        hora.Clear()
        monto.Clear()
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Dim str As String
        Dim ref2 As String = ref.Text
        Dim lugar2 As String = lugar.Text
        Dim monto2 As String = monto.Text
        str = "Insert into Multa(numrefemulta,	fecmulta, hormulta, lugmulta, impomulta) values('" + ref2 + "','" + fecha.Value.Date + "','" + hora.Text + "','" + lugar2 + "','" + monto2 + "')"
        INSERTAR(str)
        ref.Clear()
        lugar.Clear()
        fecha.ResetText()
        hora.Clear()
        monto.Clear()
    End Sub
End Class
