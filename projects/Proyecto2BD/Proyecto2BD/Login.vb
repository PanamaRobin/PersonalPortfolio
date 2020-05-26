Public Class Login
    Private Sub log_Click(sender As Object, e As EventArgs) Handles log.Click
        If (user.Text <> "" And pass.Text <> "") Then
            If (user.Text = "admin" And pass.Text = "123") Then
                Form1.Show()
                user.Clear()
                pass.Clear()
                user.Focus()
                Me.Hide()
            Else
                If (user.Text = "user" And pass.Text = "123") Then
                    Form1.Show()
                    user.Clear()
                    pass.Clear()
                    user.Focus()
                    Me.Hide()
                Else
                    MsgBox("Las credenciales del usuario y la contraseña no coinciden.")
                    user.Clear()
                    pass.Clear()
                    user.Focus()
                End If
            End If
        Else
            MsgBox("Introduzca el usuario y la contraseña.")
            user.Clear()
            pass.Clear()
            user.Focus()
        End If
    End Sub
End Class