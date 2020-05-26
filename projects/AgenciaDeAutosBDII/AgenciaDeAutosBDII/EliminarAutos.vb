Public Class EliminarAutos
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim str As String
        Dim matricula2 As String = matricula.Text
        str = "Delete from Vehiculo where matrivehiculo = '" + matricula2 + "'"
        If matricula2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                matricula.Clear()
            End If
        Else
            MsgBox("Introduzca la matricula del auto.")
        End If
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        matricula.Clear()
    End Sub
End Class
