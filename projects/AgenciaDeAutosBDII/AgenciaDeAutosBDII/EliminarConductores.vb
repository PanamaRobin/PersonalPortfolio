Public Class EliminarConductores
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        dni.Clear()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim str As String
        Dim dni2 As String = dni.Text
        str = "Delete from Persona where dnipersona = '" + dni2 + "'"
        If dni2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                dni.Clear()
            End If
        Else
            MsgBox("Introduzca el dni del conductor.")
        End If
    End Sub
End Class
