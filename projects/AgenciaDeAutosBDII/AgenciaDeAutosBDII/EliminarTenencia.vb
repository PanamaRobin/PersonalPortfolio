Public Class EliminarTenencia
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        reg.Clear()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim str As String
        Dim reg2 As String = reg.Text
        str = "Delete from Tener where constener = '" + reg2 + "'"
        If reg2 <> "" Then
            opcion = MessageBox.Show("El registro será eliminado permanentemente, ¿está seguro que desea eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                ELIMINAR(str)
                reg.Clear()
            End If
        Else
            MsgBox("Introduzca el numero de registro vehicular.")
        End If
    End Sub
End Class
