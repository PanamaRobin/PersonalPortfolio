Public Class Form1
    Public juego As Class1
    Dim bandera As Boolean
    Dim newgame As Integer
    Public x, y, caso, ss As Integer
    Public pb(7, 7) As PictureBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opcion As MessageBoxOptions
        If newgame > 0 Then
            opcion = MessageBox.Show("¿Está seguro que desea iniciar una nueva partida?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = vbYes Then
                pb = New PictureBox(7, 7) {{Me.c1, Me.c2, Me.c3, Me.c4, Me.c5, Me.c6, Me.c7, Me.c8},
                                    {Me.c9, Me.c10, Me.c11, Me.c12, Me.c13, Me.c14, Me.c15, Me.c16},
                                    {Me.c17, Me.c18, Me.c19, Me.c20, Me.c21, Me.c22, Me.c23, Me.c24},
                                    {Me.c25, Me.c26, Me.c27, Me.c28, Me.c29, Me.c30, Me.c31, Me.c32},
                                    {Me.c33, Me.c34, Me.c35, Me.c36, Me.c37, Me.c38, Me.c39, Me.c40},
                                    {Me.c41, Me.c42, Me.c43, Me.c44, Me.c45, Me.c46, Me.c47, Me.c48},
                                    {Me.c49, Me.c50, Me.c51, Me.c52, Me.c53, Me.c54, Me.c55, Me.c56},
                                    {Me.c57, Me.c58, Me.c59, Me.c60, Me.c61, Me.c62, Me.c63, Me.c64}}

                For i = 0 To 7
                    For j = 0 To 7
                        pb(i, j).Enabled = True
                    Next
                Next

                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                cn.Visible = True
                cb.Visible = True
                restantesb.Visible = True
                restantesn.Visible = True

                cb.Text = 0
                cn.Text = 0

                bandera = True
                juego = New Class1

                restantesn.Text = juego.fichasn
                restantesb.Text = juego.fichasb

                b.Text = 0
                n.Text = 0

                For i = 0 To 7
                    For j = 0 To 7
                        pb(i, j).BackgroundImage = Nothing
                    Next
                Next
            End If
        Else

            pb = New PictureBox(7, 7) {{Me.c1, Me.c2, Me.c3, Me.c4, Me.c5, Me.c6, Me.c7, Me.c8},
                                {Me.c9, Me.c10, Me.c11, Me.c12, Me.c13, Me.c14, Me.c15, Me.c16},
                                {Me.c17, Me.c18, Me.c19, Me.c20, Me.c21, Me.c22, Me.c23, Me.c24},
                                {Me.c25, Me.c26, Me.c27, Me.c28, Me.c29, Me.c30, Me.c31, Me.c32},
                                {Me.c33, Me.c34, Me.c35, Me.c36, Me.c37, Me.c38, Me.c39, Me.c40},
                                {Me.c41, Me.c42, Me.c43, Me.c44, Me.c45, Me.c46, Me.c47, Me.c48},
                                {Me.c49, Me.c50, Me.c51, Me.c52, Me.c53, Me.c54, Me.c55, Me.c56},
                                {Me.c57, Me.c58, Me.c59, Me.c60, Me.c61, Me.c62, Me.c63, Me.c64}}

            For i = 0 To 7
                For j = 0 To 7
                    pb(i, j).Enabled = True
                Next
            Next

            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            cn.Visible = True
            cb.Visible = True
            restantesb.Visible = True
            restantesn.Visible = True

            cb.Text = 0
            cn.Text = 0

            bandera = True
            juego = New Class1

            restantesn.Text = juego.fichasn
            restantesb.Text = juego.fichasb

            b.Text = 0
            n.Text = 0

            For i = 0 To 7
                For j = 0 To 7
                    pb(i, j).BackgroundImage = Nothing
                Next
            Next

            newgame += 1
        End If
    End Sub

    Private Sub c1_MouseHover(sender As Object, e As EventArgs) Handles c1.MouseHover
        x = 0
        y = 0
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c1_MouseLeave(sender As Object, e As EventArgs) Handles c1.MouseLeave
        If (bandera = True) Then
            c1.Image = Nothing
        End If
    End Sub

    Private Sub c2_MouseHover(sender As Object, e As EventArgs) Handles c2.MouseHover
        x = 1
        y = 0
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c2_MouseLeave(sender As Object, e As EventArgs) Handles c2.MouseLeave
        If (bandera = True) Then
            c2.Image = Nothing
        End If
    End Sub

    Private Sub c3_MouseHover(sender As Object, e As EventArgs) Handles c3.MouseHover
        x = 2
        y = 0
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c3_MouseLeave(sender As Object, e As EventArgs) Handles c3.MouseLeave
        If (bandera = True) Then
            c3.Image = Nothing
        End If
    End Sub

    Private Sub c4_MouseHover(sender As Object, e As EventArgs) Handles c4.MouseHover
        x = 3
        y = 0
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c4_MouseLeave(sender As Object, e As EventArgs) Handles c4.MouseLeave
        If (bandera = True) Then
            c4.Image = Nothing
        End If
    End Sub

    Private Sub c5_MouseHover(sender As Object, e As EventArgs) Handles c5.MouseHover
        x = 4
        y = 0
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c5_MouseLeave(sender As Object, e As EventArgs) Handles c5.MouseLeave
        If (bandera = True) Then
            c5.Image = Nothing
        End If
    End Sub

    Private Sub c6_MouseHover(sender As Object, e As EventArgs) Handles c6.MouseHover
        x = 5
        y = 0
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c6_MouseLeave(sender As Object, e As EventArgs) Handles c6.MouseLeave
        If (bandera = True) Then
            c6.Image = Nothing
        End If
    End Sub

    Private Sub c7_MouseHover(sender As Object, e As EventArgs) Handles c7.MouseHover
        x = 6
        y = 0
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c7_MouseLeave(sender As Object, e As EventArgs) Handles c7.MouseLeave
        If (bandera = True) Then
            c7.Image = Nothing
        End If
    End Sub

    Private Sub c8_MouseHover(sender As Object, e As EventArgs) Handles c8.MouseHover
        x = 7
        y = 0
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c8_MouseLeave(sender As Object, e As EventArgs) Handles c8.MouseLeave
        If (bandera = True) Then
            c8.Image = Nothing
        End If
    End Sub

    Private Sub c9_MouseHover(sender As Object, e As EventArgs) Handles c9.MouseHover
        x = 0
        y = 1
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c9_MouseLeave(sender As Object, e As EventArgs) Handles c9.MouseLeave
        If (bandera = True) Then
            c9.Image = Nothing
        End If
    End Sub

    Private Sub c10_MouseHover(sender As Object, e As EventArgs) Handles c10.MouseHover
        x = 1
        y = 1
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c10_MouseLeave(sender As Object, e As EventArgs) Handles c10.MouseLeave
        If (bandera = True) Then
            c10.Image = Nothing
        End If
    End Sub

    Private Sub c11_MouseHover(sender As Object, e As EventArgs) Handles c11.MouseHover
        x = 2
        y = 1
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c11_MouseLeave(sender As Object, e As EventArgs) Handles c11.MouseLeave
        If (bandera = True) Then
            c11.Image = Nothing
        End If
    End Sub

    Private Sub c12_MouseHover(sender As Object, e As EventArgs) Handles c12.MouseHover
        x = 3
        y = 1
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c12_MouseLeave(sender As Object, e As EventArgs) Handles c12.MouseLeave
        If (bandera = True) Then
            c12.Image = Nothing
        End If
    End Sub

    Private Sub c13_MouseHover(sender As Object, e As EventArgs) Handles c13.MouseHover
        x = 4
        y = 1
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c13_MouseLeave(sender As Object, e As EventArgs) Handles c13.MouseLeave
        If (bandera = True) Then
            c13.Image = Nothing
        End If
    End Sub

    Private Sub c14_MouseHover(sender As Object, e As EventArgs) Handles c14.MouseHover
        x = 5
        y = 1
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c14_MouseLeave(sender As Object, e As EventArgs) Handles c14.MouseLeave
        If (bandera = True) Then
            c14.Image = Nothing
        End If
    End Sub

    Private Sub c15_MouseHover(sender As Object, e As EventArgs) Handles c15.MouseHover
        x = 6
        y = 1
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c15_MouseLeave(sender As Object, e As EventArgs) Handles c15.MouseLeave
        If (bandera = True) Then
            c15.Image = Nothing
        End If
    End Sub

    Private Sub c16_MouseHover(sender As Object, e As EventArgs) Handles c16.MouseHover
        x = 7
        y = 1
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c16_MouseLeave(sender As Object, e As EventArgs) Handles c16.MouseLeave
        If (bandera = True) Then
            c16.Image = Nothing
        End If
    End Sub

    Private Sub c17_MouseHover(sender As Object, e As EventArgs) Handles c17.MouseHover
        x = 0
        y = 2
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c17_MouseLeave(sender As Object, e As EventArgs) Handles c17.MouseLeave
        If (bandera = True) Then
            c17.Image = Nothing
        End If
    End Sub

    Private Sub c18_MouseHover(sender As Object, e As EventArgs) Handles c18.MouseHover
        x = 1
        y = 2
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c18_MouseLeave(sender As Object, e As EventArgs) Handles c18.MouseLeave
        If (bandera = True) Then
            c18.Image = Nothing
        End If
    End Sub

    Private Sub c19_MouseHover(sender As Object, e As EventArgs) Handles c19.MouseHover
        x = 2
        y = 2
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c19_MouseLeave(sender As Object, e As EventArgs) Handles c19.MouseLeave
        If (bandera = True) Then
            c19.Image = Nothing
        End If
    End Sub

    Private Sub c20_MouseHover(sender As Object, e As EventArgs) Handles c20.MouseHover
        x = 3
        y = 2
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c20_MouseLeave(sender As Object, e As EventArgs) Handles c20.MouseLeave
        If (bandera = True) Then
            c20.Image = Nothing
        End If
    End Sub

    Private Sub c21_MouseHover(sender As Object, e As EventArgs) Handles c21.MouseHover
        x = 4
        y = 2
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c21_MouseLeave(sender As Object, e As EventArgs) Handles c21.MouseLeave
        If (bandera = True) Then
            c21.Image = Nothing
        End If
    End Sub

    Private Sub c22_MouseHover(sender As Object, e As EventArgs) Handles c22.MouseHover
        x = 5
        y = 2
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c22_MouseLeave(sender As Object, e As EventArgs) Handles c22.MouseLeave
        If (bandera = True) Then
            c22.Image = Nothing
        End If
    End Sub

    Private Sub c23_MouseHover(sender As Object, e As EventArgs) Handles c23.MouseHover
        x = 6
        y = 2
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c23_MouseLeave(sender As Object, e As EventArgs) Handles c23.MouseLeave
        If (bandera = True) Then
            c23.Image = Nothing
        End If
    End Sub

    Private Sub c24_MouseHover(sender As Object, e As EventArgs) Handles c24.MouseHover
        x = 7
        y = 2
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c24_MouseLeave(sender As Object, e As EventArgs) Handles c24.MouseLeave
        If (bandera = True) Then
            c24.Image = Nothing
        End If
    End Sub

    Private Sub c25_MouseHover(sender As Object, e As EventArgs) Handles c25.MouseHover
        x = 0
        y = 3
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c25_MouseLeave(sender As Object, e As EventArgs) Handles c25.MouseLeave
        If (bandera = True) Then
            c25.Image = Nothing
        End If
    End Sub

    Private Sub c26_MouseHover(sender As Object, e As EventArgs) Handles c26.MouseHover
        x = 1
        y = 3
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c26_MouseLeave(sender As Object, e As EventArgs) Handles c26.MouseLeave
        If (bandera = True) Then
            c26.Image = Nothing
        End If
    End Sub

    Private Sub c27_MouseHover(sender As Object, e As EventArgs) Handles c27.MouseHover
        x = 2
        y = 3
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c27_MouseLeave(sender As Object, e As EventArgs) Handles c27.MouseLeave
        If (bandera = True) Then
            c27.Image = Nothing
        End If
    End Sub

    Private Sub c28_MouseHover(sender As Object, e As EventArgs) Handles c28.MouseHover
        x = 3
        y = 3
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c28_MouseLeave(sender As Object, e As EventArgs) Handles c28.MouseLeave
        If (bandera = True) Then
            c28.Image = Nothing
        End If
    End Sub

    Private Sub c29_MouseHover(sender As Object, e As EventArgs) Handles c29.MouseHover
        x = 4
        y = 3
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c29_MouseLeave(sender As Object, e As EventArgs) Handles c29.MouseLeave
        If (bandera = True) Then
            c29.Image = Nothing
        End If
    End Sub

    Private Sub c30_MouseHover(sender As Object, e As EventArgs) Handles c30.MouseHover
        x = 5
        y = 3
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c30_MouseLeave(sender As Object, e As EventArgs) Handles c30.MouseLeave
        If (bandera = True) Then
            c30.Image = Nothing
        End If
    End Sub

    Private Sub c31_MouseHover(sender As Object, e As EventArgs) Handles c31.MouseHover
        x = 6
        y = 3
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c31_MouseLeave(sender As Object, e As EventArgs) Handles c31.MouseLeave
        If (bandera = True) Then
            c31.Image = Nothing
        End If
    End Sub

    Private Sub c32_MouseHover(sender As Object, e As EventArgs) Handles c32.MouseHover
        x = 7
        y = 3
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c32_MouseLeave(sender As Object, e As EventArgs) Handles c32.MouseLeave
        If (bandera = True) Then
            c32.Image = Nothing
        End If
    End Sub

    Private Sub c33_MouseHover(sender As Object, e As EventArgs) Handles c33.MouseHover
        x = 0
        y = 4
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c33_MouseLeave(sender As Object, e As EventArgs) Handles c33.MouseLeave
        If (bandera = True) Then
            c33.Image = Nothing
        End If
    End Sub

    Private Sub c34_MouseHover(sender As Object, e As EventArgs) Handles c34.MouseHover
        x = 1
        y = 4
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c34_MouseLeave(sender As Object, e As EventArgs) Handles c34.MouseLeave
        If (bandera = True) Then
            c34.Image = Nothing
        End If
    End Sub

    Private Sub c35_MouseHover(sender As Object, e As EventArgs) Handles c35.MouseHover
        x = 2
        y = 4
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c35_MouseLeave(sender As Object, e As EventArgs) Handles c35.MouseLeave
        If (bandera = True) Then
            c35.Image = Nothing
        End If
    End Sub

    Private Sub c36_MouseHover(sender As Object, e As EventArgs) Handles c36.MouseHover
        x = 3
        y = 4
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c36_MouseLeave(sender As Object, e As EventArgs) Handles c36.MouseLeave
        If (bandera = True) Then
            c36.Image = Nothing
        End If
    End Sub

    Private Sub c37_MouseHover(sender As Object, e As EventArgs) Handles c37.MouseHover
        x = 4
        y = 4
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c37_MouseLeave(sender As Object, e As EventArgs) Handles c37.MouseLeave
        If (bandera = True) Then
            c37.Image = Nothing
        End If
    End Sub

    Private Sub c38_MouseHover(sender As Object, e As EventArgs) Handles c38.MouseHover
        x = 5
        y = 4
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c38_MouseLeave(sender As Object, e As EventArgs) Handles c38.MouseLeave
        If (bandera = True) Then
            c38.Image = Nothing
        End If
    End Sub

    Private Sub c39_MouseHover(sender As Object, e As EventArgs) Handles c39.MouseHover
        x = 6
        y = 4
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c39_MouseLeave(sender As Object, e As EventArgs) Handles c39.MouseLeave
        If (bandera = True) Then
            c39.Image = Nothing
        End If
    End Sub

    Private Sub c40_MouseHover(sender As Object, e As EventArgs) Handles c40.MouseHover
        x = 7
        y = 4
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c40_MouseLeave(sender As Object, e As EventArgs) Handles c40.MouseLeave
        If (bandera = True) Then
            c40.Image = Nothing
        End If
    End Sub

    Private Sub c41_MouseHover(sender As Object, e As EventArgs) Handles c41.MouseHover
        x = 0
        y = 5
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c41_MouseLeave(sender As Object, e As EventArgs) Handles c41.MouseLeave
        If (bandera = True) Then
            c41.Image = Nothing
        End If
    End Sub

    Private Sub c42_MouseHover(sender As Object, e As EventArgs) Handles c42.MouseHover
        x = 1
        y = 5
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c42_MouseLeave(sender As Object, e As EventArgs) Handles c42.MouseLeave
        If (bandera = True) Then
            c42.Image = Nothing
        End If
    End Sub

    Private Sub c43_MouseHover(sender As Object, e As EventArgs) Handles c43.MouseHover
        x = 2
        y = 5
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c43_MouseLeave(sender As Object, e As EventArgs) Handles c43.MouseLeave
        If (bandera = True) Then
            c43.Image = Nothing
        End If
    End Sub

    Private Sub c44_MouseHover(sender As Object, e As EventArgs) Handles c44.MouseHover
        x = 3
        y = 5
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c44_MouseLeave(sender As Object, e As EventArgs) Handles c44.MouseLeave
        If (bandera = True) Then
            c44.Image = Nothing
        End If
    End Sub

    Private Sub c45_MouseHover(sender As Object, e As EventArgs) Handles c45.MouseHover
        x = 4
        y = 5
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c45_MouseLeave(sender As Object, e As EventArgs) Handles c45.MouseLeave
        If (bandera = True) Then
            c45.Image = Nothing
        End If
    End Sub

    Private Sub c46_MouseHover(sender As Object, e As EventArgs) Handles c46.MouseHover
        x = 5
        y = 5
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c46_MouseLeave(sender As Object, e As EventArgs) Handles c46.MouseLeave
        If (bandera = True) Then
            c46.Image = Nothing
        End If
    End Sub

    Private Sub c47_MouseHover(sender As Object, e As EventArgs) Handles c47.MouseHover
        x = 6
        y = 5
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c47_MouseLeave(sender As Object, e As EventArgs) Handles c47.MouseLeave
        If (bandera = True) Then
            c47.Image = Nothing
        End If
    End Sub

    Private Sub c48_MouseHover(sender As Object, e As EventArgs) Handles c48.MouseHover
        x = 7
        y = 5
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c48_MouseLeave(sender As Object, e As EventArgs) Handles c48.MouseLeave
        If (bandera = True) Then
            c48.Image = Nothing
        End If
    End Sub

    Private Sub c49_MouseHover(sender As Object, e As EventArgs) Handles c49.MouseHover
        x = 0
        y = 6
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c49_MouseLeave(sender As Object, e As EventArgs) Handles c49.MouseLeave
        If (bandera = True) Then
            c49.Image = Nothing
        End If
    End Sub

    Private Sub c50_MouseHover(sender As Object, e As EventArgs) Handles c50.MouseHover
        x = 1
        y = 6
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c50_MouseLeave(sender As Object, e As EventArgs) Handles c50.MouseLeave
        If (bandera = True) Then
            c50.Image = Nothing
        End If
    End Sub

    Private Sub c51_MouseHover(sender As Object, e As EventArgs) Handles c51.MouseHover
        x = 2
        y = 6
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c51_MouseLeave(sender As Object, e As EventArgs) Handles c51.MouseLeave
        If (bandera = True) Then
            c51.Image = Nothing
        End If
    End Sub

    Private Sub c52_MouseHover(sender As Object, e As EventArgs) Handles c52.MouseHover
        x = 3
        y = 6
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c52_MouseLeave(sender As Object, e As EventArgs) Handles c52.MouseLeave
        If (bandera = True) Then
            c52.Image = Nothing
        End If
    End Sub

    Private Sub c53_MouseHover(sender As Object, e As EventArgs) Handles c53.MouseHover
        x = 4
        y = 6
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c53_MouseLeave(sender As Object, e As EventArgs) Handles c53.MouseLeave
        If (bandera = True) Then
            c53.Image = Nothing
        End If
    End Sub

    Private Sub c54_MouseHover(sender As Object, e As EventArgs) Handles c54.MouseHover
        x = 5
        y = 6
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c54_MouseLeave(sender As Object, e As EventArgs) Handles c54.MouseLeave
        If (bandera = True) Then
            c54.Image = Nothing
        End If
    End Sub

    Private Sub c55_MouseHover(sender As Object, e As EventArgs) Handles c55.MouseHover
        x = 6
        y = 6
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c55_MouseLeave(sender As Object, e As EventArgs) Handles c55.MouseLeave
        If (bandera = True) Then
            c55.Image = Nothing
        End If
    End Sub

    Private Sub c56_MouseHover(sender As Object, e As EventArgs) Handles c56.MouseHover
        x = 7
        y = 6
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c56_MouseLeave(sender As Object, e As EventArgs) Handles c56.MouseLeave
        If (bandera = True) Then
            c56.Image = Nothing
        End If
    End Sub

    Private Sub c57_MouseHover(sender As Object, e As EventArgs) Handles c57.MouseHover
        x = 0
        y = 7
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c57_MouseLeave(sender As Object, e As EventArgs) Handles c57.MouseLeave
        If (bandera = True) Then
            c57.Image = Nothing
        End If
    End Sub

    Private Sub c58_MouseHover(sender As Object, e As EventArgs) Handles c58.MouseHover
        x = 1
        y = 7
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c58_MouseLeave(sender As Object, e As EventArgs) Handles c58.MouseLeave
        If (bandera = True) Then
            c58.Image = Nothing
        End If
    End Sub

    Private Sub c59_MouseHover(sender As Object, e As EventArgs) Handles c59.MouseHover
        x = 2
        y = 7
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c59_MouseLeave(sender As Object, e As EventArgs) Handles c59.MouseLeave
        If (bandera = True) Then
            c59.Image = Nothing
        End If
    End Sub

    Private Sub c60_MouseHover(sender As Object, e As EventArgs) Handles c60.MouseHover
        x = 3
        y = 7
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c60_MouseLeave(sender As Object, e As EventArgs) Handles c60.MouseLeave
        If (bandera = True) Then
            c60.Image = Nothing
        End If
    End Sub

    Private Sub c61_MouseHover(sender As Object, e As EventArgs) Handles c61.MouseHover
        x = 4
        y = 7
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c61_MouseLeave(sender As Object, e As EventArgs) Handles c61.MouseLeave
        If (bandera = True) Then
            c61.Image = Nothing
        End If
    End Sub

    Private Sub c62_MouseHover(sender As Object, e As EventArgs) Handles c62.MouseHover
        x = 5
        y = 7
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c62_MouseLeave(sender As Object, e As EventArgs) Handles c62.MouseLeave
        If (bandera = True) Then
            c62.Image = Nothing
        End If
    End Sub

    Private Sub c63_MouseHover(sender As Object, e As EventArgs) Handles c63.MouseHover
        x = 6
        y = 7
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c63_MouseLeave(sender As Object, e As EventArgs) Handles c63.MouseLeave
        If (bandera = True) Then
            c63.Image = Nothing
        End If
    End Sub

    Private Sub c64_MouseHover(sender As Object, e As EventArgs) Handles c64.MouseHover
        x = 7
        y = 7
        If (bandera = True) Then
            juego.Chequear(x, y)
        End If
    End Sub

    Private Sub c64_MouseLeave(sender As Object, e As EventArgs) Handles c64.MouseLeave
        If (bandera = True) Then
            c64.Image = Nothing
        End If
    End Sub

    Private Sub C19_Click(sender As Object, e As EventArgs) Handles c19.Click
        x = 2
        y = 2
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C20_Click(sender As Object, e As EventArgs) Handles c20.Click
        x = 3
        y = 2
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C21_Click(sender As Object, e As EventArgs) Handles c21.Click
        x = 4
        y = 2
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C22_Click(sender As Object, e As EventArgs) Handles c22.Click
        x = 5
        y = 2
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C27_Click(sender As Object, e As EventArgs) Handles c27.Click
        x = 2
        y = 3
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C28_Click(sender As Object, e As EventArgs) Handles c28.Click
        x = 3
        y = 3
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C29_Click(sender As Object, e As EventArgs) Handles c29.Click
        x = 4
        y = 3
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C30_Click(sender As Object, e As EventArgs) Handles c30.Click
        x = 5
        y = 3
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C35_Click(sender As Object, e As EventArgs) Handles c35.Click
        x = 2
        y = 4
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C36_Click(sender As Object, e As EventArgs) Handles c36.Click
        x = 3
        y = 4
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C37_Click(sender As Object, e As EventArgs) Handles c37.Click
        x = 4
        y = 4
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C38_Click(sender As Object, e As EventArgs) Handles c38.Click
        x = 5
        y = 4
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C43_Click(sender As Object, e As EventArgs) Handles c43.Click
        x = 2
        y = 5
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C44_Click(sender As Object, e As EventArgs) Handles c44.Click
        x = 3
        y = 5
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C45_Click(sender As Object, e As EventArgs) Handles c45.Click
        x = 4
        y = 5
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c9_Click(sender As Object, e As EventArgs) Handles c9.Click
        x = 0
        y = 1
        caso = 17
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c17_Click(sender As Object, e As EventArgs) Handles c17.Click
        x = 0
        y = 2
        caso = 6
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c25_Click(sender As Object, e As EventArgs) Handles c25.Click
        x = 0
        y = 3
        caso = 6
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c33_Click(sender As Object, e As EventArgs) Handles c33.Click
        x = 0
        y = 4
        caso = 6
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c41_Click(sender As Object, e As EventArgs) Handles c41.Click
        x = 0
        y = 5
        caso = 6
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c49_Click(sender As Object, e As EventArgs) Handles c49.Click
        x = 0
        y = 6
        caso = 16
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub
    Private Sub c50_Click(sender As Object, e As EventArgs) Handles c50.Click
        x = 1
        y = 6
        caso = 10
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub
    Private Sub c57_Click(sender As Object, e As EventArgs) Handles c57.Click
        x = 0
        y = 7
        caso = 15
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub
    Private Sub c58_Click(sender As Object, e As EventArgs) Handles c58.Click
        x = 1
        y = 7
        caso = 14
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c10_Click(sender As Object, e As EventArgs) Handles c10.Click
        x = 1
        y = 1
        caso = 11
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        x = 1
        y = 0
        caso = 19
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c18_Click(sender As Object, e As EventArgs) Handles c18.Click
        x = 1
        y = 2
        caso = 2
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c26_Click(sender As Object, e As EventArgs) Handles c26.Click
        x = 1
        y = 3
        caso = 2
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c34_Click(sender As Object, e As EventArgs) Handles c34.Click
        x = 1
        y = 4
        caso = 2
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c42_Click(sender As Object, e As EventArgs) Handles c42.Click
        x = 1
        y = 5
        caso = 2
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c3_Click(sender As Object, e As EventArgs) Handles c3.Click
        x = 2
        y = 0
        caso = 7
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c4_Click(sender As Object, e As EventArgs) Handles c4.Click
        x = 3
        y = 0
        caso = 7
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c5_Click(sender As Object, e As EventArgs) Handles c5.Click
        x = 4
        y = 0
        caso = 7
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c6_Click(sender As Object, e As EventArgs) Handles c6.Click
        x = 5
        y = 0
        caso = 7
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c7_Click(sender As Object, e As EventArgs) Handles c7.Click
        x = 6
        y = 0
        caso = 20
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c8_Click(sender As Object, e As EventArgs) Handles c8.Click
        x = 7
        y = 0
        caso = 21
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c11_Click(sender As Object, e As EventArgs) Handles c11.Click
        x = 2
        y = 1
        caso = 3
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c12_Click(sender As Object, e As EventArgs) Handles c12.Click
        x = 3
        y = 1
        caso = 3
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c13_Click(sender As Object, e As EventArgs) Handles c13.Click
        x = 4
        y = 1
        caso = 3
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c14_Click(sender As Object, e As EventArgs) Handles c14.Click
        x = 5
        y = 1
        caso = 3
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c15_Click(sender As Object, e As EventArgs) Handles c15.Click
        x = 6
        y = 1
        caso = 12
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c16_Click(sender As Object, e As EventArgs) Handles c16.Click
        x = 7
        y = 1
        caso = 22
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c23_Click(sender As Object, e As EventArgs) Handles c23.Click
        x = 6
        y = 2
        caso = 4
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c31_Click(sender As Object, e As EventArgs) Handles c31.Click
        x = 6
        y = 3
        caso = 4
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c39_Click(sender As Object, e As EventArgs) Handles c39.Click
        x = 6
        y = 4
        caso = 4
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c47_Click(sender As Object, e As EventArgs) Handles c47.Click
        x = 6
        y = 5
        caso = 4
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c55_Click(sender As Object, e As EventArgs) Handles c55.Click
        x = 6
        y = 6
        caso = 13
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub
    Private Sub c63_Click(sender As Object, e As EventArgs) Handles c63.Click
        x = 6
        y = 7
        caso = 25
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub
    Private Sub c64_Click(sender As Object, e As EventArgs) Handles c64.Click
        x = 7
        y = 7
        caso = 24
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c56_Click(sender As Object, e As EventArgs) Handles c56.Click
        x = 7
        y = 6
        caso = 23
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c48_Click(sender As Object, e As EventArgs) Handles c48.Click
        x = 7
        y = 5
        caso = 8
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c40_Click(sender As Object, e As EventArgs) Handles c40.Click
        x = 7
        y = 4
        caso = 8
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c32_Click(sender As Object, e As EventArgs) Handles c32.Click
        x = 7
        y = 3
        caso = 8
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c24_Click(sender As Object, e As EventArgs) Handles c24.Click
        x = 7
        y = 2
        caso = 8
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c51_Click(sender As Object, e As EventArgs) Handles c51.Click
        x = 2
        y = 6
        caso = 5
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c52_Click(sender As Object, e As EventArgs) Handles c52.Click
        x = 3
        y = 6
        caso = 5
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c53_Click(sender As Object, e As EventArgs) Handles c53.Click
        x = 4
        y = 6
        caso = 5
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c54_Click(sender As Object, e As EventArgs) Handles c54.Click
        x = 5
        y = 6
        caso = 5
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C46_Click(sender As Object, e As EventArgs) Handles c46.Click
        x = 5
        y = 5
        caso = 1
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles c1.Click
        x = 0
        y = 0
        caso = 18
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c59_Click(sender As Object, e As EventArgs) Handles c59.Click
        x = 2
        y = 7
        caso = 9
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a As Integer
        a += 1
        If a = 1 Then
            Timer1.Stop()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub c60_Click(sender As Object, e As EventArgs) Handles c60.Click
        x = 3
        y = 7
        caso = 9
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c61_Click(sender As Object, e As EventArgs) Handles c61.Click
        x = 4
        y = 7
        caso = 9
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub

    Private Sub c62_Click(sender As Object, e As EventArgs) Handles c62.Click
        x = 5
        y = 7
        caso = 9
        If (juego.Click(x, y, caso) = True) Then
            juego.ordenador()
        End If
    End Sub
End Class
