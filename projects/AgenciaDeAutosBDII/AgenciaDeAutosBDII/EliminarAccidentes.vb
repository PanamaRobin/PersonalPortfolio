Public Class EliminarAccidentes
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        ref.Clear()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim str As String
        Dim ref2 As String = ref.Text
        str = "Delete from Accidente where numreferencia = '" + ref2 + "'"
        If ref2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                ref.Clear()
            End If
        Else
            MsgBox("Introduzca el numero de referencia.")
        End If
    End Sub
End Class
