Public Class Class1
    Public tablero(7, 7) As Integer
    Public xx, yy As Integer
    Public fichasn As Integer = 18
    Public fichasb As Integer = 18
    'Public minEval, maxEval, eval As Integer
    Public puntajenegro As Integer = 0
    Public puntajeblanco As Integer = 0
    Public puestasb As Integer = 0
    Public puestasn As Integer = 0
    Public negrocomidas As Integer = 0
    Public blancocomidas As Integer = 0
    'Public puntnfalso As Integer
    Public fichasnfalsas As Integer
    Public fichasbfalsas As Integer

    Public Sub New()
        tablero = {{0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0},
                 {0, 0, 0, 0, 0, 0, 0, 0}}
    End Sub
    Sub Chequear(ByVal x, ByVal y)
        If (tablero(y, x) = 0) Then
            Form1.pb(y, x).Image = My.Resources.V_Move
        Else
            Form1.pb(y, x).Image = My.Resources.bMove
        End If
    End Sub

    Function Click(ByVal x, ByVal y, ByVal caso)
        If (gameover() = False) Then
            If (tablero(y, x) = 0) Then
                If (Condicion(x, y, caso) = True) Then
                    Form1.pb(y, x).BackgroundImage = My.Resources.blanco
                    tablero(y, x) = 1
                    fichasb -= 1
                    puestasb += tablero(y, x)
                    puntajeblanco = puestasb + blancocomidas
                Else
                    If (Condicion(x, y, caso) = False) Then
                        MsgBox("Tu ficha ha sido comida.", vbOKOnly, "AVISO")
                        Form1.pb(y, x).BackgroundImage = My.Resources.negro
                        tablero(y, x) = -2
                        fichasb -= 1
                        negrocomidas -= tablero(y, x)
                        puntajenegro = puestasn + negrocomidas
                    End If
                End If
                Form1.b.Text = puntajeblanco
                Form1.n.Text = puntajenegro
                Form1.restantesb.Text = fichasb
                Form1.restantesn.Text = fichasn
                Form1.cb.Text = blancocomidas / 2
                Form1.cn.Text = negrocomidas / 2
                Return True
            Else
                MsgBox("Debe colocar la ficha en una posición vacía.", vbOKOnly, "AVISO")
                Return False
            End If
        End If
        Return Nothing
        'Dim cadena As String = ""
        'For i = 0 To 7
        '    For j = 0 To 7
        '        cadena &= tablero(i, j).ToString & " "
        '    Next
        '    cadena &= vbCrLf
        'Next
        'MsgBox(cadena)
    End Function

    Sub ClickOrdenador(ByVal x, ByVal y, ByVal caso)
        If (gameover() = False) Then
            If (tablero(y, x) = 0) Then
                If (CondicionOrdenador(x, y, caso) = True) Then
                    Form1.pb(y, x).BackgroundImage = My.Resources.negro
                    tablero(y, x) = -1
                    fichasn -= 1
                    puestasn -= tablero(y, x)
                    puntajenegro = puestasn + negrocomidas
                Else
                    If (CondicionOrdenador(x, y, caso) = False) Then
                        MsgBox("La ficha del ordenador ha sido comida.", vbOKOnly, "AVISO")
                        Form1.pb(y, x).BackgroundImage = My.Resources.blanco
                        tablero(y, x) = 2
                        fichasn -= 1
                        blancocomidas += tablero(y, x)
                        puntajeblanco = puestasb + blancocomidas
                    End If
                End If
                Form1.b.Text = puntajeblanco
                Form1.n.Text = puntajenegro
                Form1.restantesb.Text = fichasb
                Form1.restantesn.Text = fichasn
                Form1.cb.Text = blancocomidas / 2
                Form1.cn.Text = negrocomidas / 2
            End If
        End If
    End Sub

    Sub ClickOrdenadorFalso(ByVal i, ByVal j, ByVal caso)
        If (CondicionOrdenador(j, i, caso) = True) Then
            tablero(i, j) = -1
            fichasnfalsas -= 1
        Else
            If (CondicionOrdenador(j, i, caso) = False) Then
                tablero(i, j) = 2
                fichasnfalsas -= 1
            End If
        End If
    End Sub

    Sub ClickFalso(ByVal i, ByVal j, ByVal caso)
        If (Condicion(j, i, caso) = True) Then
            tablero(i, j) = 1
            fichasbfalsas -= 1
        Else
            If (Condicion(j, i, caso) = False) Then
                tablero(i, j) = -2
                fichasbfalsas -= 1
            End If
        End If
    End Sub

    Function Condicion(ByVal x, ByVal y, ByVal caso)
        Select Case caso
            Case 1     'CENTRO
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x - 2) > -1 And tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x - 2) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 2     'BANDA IZQUIERDA 1
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 3
                If (tablero(y - 1, x - 2) > -1 And tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x - 2) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 4
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x - 2) > -1 And      'ARRIBA
                    tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x - 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 5
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x - 2) > -1 And tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 1, x - 2) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 6
                If (tablero(y - 2, x + 1) > -1 And tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 2, x + 1) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 7
                If (tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x - 2) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 8
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 1, x - 2) > -1 And      'ARRIBA
                    tablero(y + 2, x - 1) > -1 And tablero(y + 1, x - 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 9
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x - 2) > -1 And tablero(y - 1, x + 2) > -1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
            Case 10
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 11
                If (tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 12
                If (tablero(y - 1, x - 2) > -1 And      'ARRIBA
                    tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x - 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 13
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x - 2) > -1 And      'ARRIBA
                    tablero(y + 1, x - 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 14
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x + 2) > -1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
            Case 15
                If (tablero(y - 2, x + 1) > -1 And tablero(y - 1, x + 2) > -1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
            Case 16
                If (tablero(y - 2, x + 1) > -1 And tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 17
                If (tablero(y - 1, x + 2) > -1 And      'ARRIBA
                    tablero(y + 2, x + 1) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 18
                If (tablero(y + 2, x + 1) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 19
                If (tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x + 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 20
                If (tablero(y + 2, x - 1) > -1 And tablero(y + 2, x + 1) > -1 And tablero(y + 1, x - 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 21
                If (tablero(y + 2, x - 1) > -1 And tablero(y + 1, x - 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 22
                If (tablero(y - 1, x - 2) > -1 And      'ARRIBA
                    tablero(y + 2, x - 1) > -1 And tablero(y + 1, x - 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 23
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 1, x - 2) > -1 And      'ARRIBA
                    tablero(y + 1, x - 2) > -1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 24
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 1, x - 2) > -1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
            Case 25
                If (tablero(y - 2, x - 1) > -1 And tablero(y - 2, x + 1) > -1 And tablero(y - 1, x - 2) > -1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
        End Select
        Return Nothing
    End Function

    Function CondicionOrdenador(ByVal x, ByVal y, ByVal caso)
        Select Case caso
            Case 1     'CENTRO
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x - 2) < 1 And tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x - 2) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 2     'BANDA IZQUIERDA 1
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 3
                If (tablero(y - 1, x - 2) < 1 And tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x - 2) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 4
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x - 2) < 1 And      'ARRIBA
                    tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x - 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 5
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x - 2) < 1 And tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 1, x - 2) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 6
                If (tablero(y - 2, x + 1) < 1 And tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 2, x + 1) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 7
                If (tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x - 2) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 8
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 1, x - 2) < 1 And      'ARRIBA
                    tablero(y + 2, x - 1) < 1 And tablero(y + 1, x - 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 9
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x - 2) < 1 And tablero(y - 1, x + 2) < 1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
            Case 10
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 11
                If (tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 12
                If (tablero(y - 1, x - 2) < 1 And      'ARRIBA
                    tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x - 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 13
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x - 2) < 1 And      'ARRIBA
                    tablero(y + 1, x - 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 14
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x + 2) < 1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
            Case 15
                If (tablero(y - 2, x + 1) < 1 And tablero(y - 1, x + 2) < 1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
            Case 16
                If (tablero(y - 2, x + 1) < 1 And tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 17
                If (tablero(y - 1, x + 2) < 1 And      'ARRIBA
                    tablero(y + 2, x + 1) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 18
                If (tablero(y + 2, x + 1) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 19
                If (tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x + 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 20
                If (tablero(y + 2, x - 1) < 1 And tablero(y + 2, x + 1) < 1 And tablero(y + 1, x - 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 21
                If (tablero(y + 2, x - 1) < 1 And tablero(y + 1, x - 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 22
                If (tablero(y - 1, x - 2) < 1 And      'ARRIBA
                    tablero(y + 2, x - 1) < 1 And tablero(y + 1, x - 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 23
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 1, x - 2) < 1 And      'ARRIBA
                    tablero(y + 1, x - 2) < 1) Then    'ABAJO
                    Return True
                Else
                    Return False
                End If
            Case 24
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 1, x - 2) < 1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
            Case 25
                If (tablero(y - 2, x - 1) < 1 And tablero(y - 2, x + 1) < 1 And tablero(y - 1, x - 2) < 1) Then    'ARRIBA
                    Return True
                Else
                    Return False
                End If
        End Select
        Return Nothing
    End Function

    Function Casos(ByVal i, ByVal j)
        'CASO 1
        If (i = 2 And j = 2) Or (i = 2 And j = 3) Or (i = 2 And j = 4) Or (i = 2 And j = 5) Then
            Return 1
        End If
        If (i = 3 And j = 2) Or (i = 3 And j = 3) Or (i = 3 And j = 4) Or (i = 3 And j = 5) Then
            Return 1
        End If
        If (i = 4 And j = 2) Or (i = 4 And j = 3) Or (i = 4 And j = 4) Or (i = 4 And j = 5) Then
            Return 1
        End If
        If (i = 5 And j = 2) Or (i = 5 And j = 3) Or (i = 5 And j = 4) Or (i = 5 And j = 5) Then
            Return 1
        End If

        'CASO 2
        If (i = 2 And j = 1) Or (i = 3 And j = 1) Or (i = 4 And j = 1) Or (i = 5 And j = 1) Then
            Return 2
        End If

        'CASO 3
        If (i = 1 And j = 2) Or (i = 1 And j = 3) Or (i = 1 And j = 4) Or (i = 1 And j = 5) Then
            Return 3
        End If

        'CASO 4
        If (i = 2 And j = 6) Or (i = 3 And j = 6) Or (i = 4 And j = 6) Or (i = 5 And j = 6) Then
            Return 4
        End If

        'CASO 5
        If (i = 6 And j = 2) Or (i = 6 And j = 3) Or (i = 6 And j = 4) Or (i = 6 And j = 5) Then
            Return 5
        End If

        'CASO 6
        If (i = 2 And j = 0) Or (i = 3 And j = 0) Or (i = 4 And j = 0) Or (i = 5 And j = 0) Then
            Return 6
        End If

        'CASO 7
        If (i = 0 And j = 2) Or (i = 0 And j = 3) Or (i = 0 And j = 4) Or (i = 0 And j = 5) Then
            Return 7
        End If

        'CASO 8
        If (i = 2 And j = 7) Or (i = 3 And j = 7) Or (i = 4 And j = 7) Or (i = 5 And j = 7) Then
            Return 8
        End If

        'CASO 9
        If (i = 7 And j = 2) Or (i = 7 And j = 3) Or (i = 7 And j = 4) Or (i = 7 And j = 5) Then
            Return 9
        End If

        'CASO 10
        If (i = 6 And j = 1) Then
            Return 10
        End If

        'CASO 11
        If (i = 1 And i = j) Then
            Return 11
        End If

        'CASO 12
        If (i = 1 And j = 6) Then
            Return 12
        End If

        'CASO 13
        If (i = 6 And j = 6) Then
            Return 13
        End If

        'CASO 14
        If (i = 7 And j = 1) Then
            Return 14
        End If

        'CASO 15
        If (i = 7 And j = 0) Then
            Return 15
        End If

        'CASO 16
        If (j = 0 And i = 6) Then
            Return 16
        End If

        'CASO 17
        If (j = 0 And i = 1) Then
            Return 17
        End If

        'CASO 18
        If (i = 0 And j = 0) Then
            Return 18
        End If

        'CASO 19
        If (j = 1 And i = 0) Then
            Return 19
        End If

        'CASO 20
        If (j = 6 And i = 0) Then
            Return 20
        End If

        'CASO 21
        If (j = 7 And i = 0) Then
            Return 21
        End If

        'CASO 22
        If (j = 7 And i = 1) Then
            Return 22
        End If

        'CASO 23
        If (j = 7 And i = 6) Then
            Return 23
        End If

        'CASO 24
        If (j = 7 And i = 7) Then
            Return 24
        End If

        'CASO 25
        If (j = 6 And i = 7) Then
            Return 25
        End If
        Return Nothing
    End Function

    Public Function Max(ByVal depth, ByVal maxEval, ByVal minEval, ByVal eval)
        If gameoverpc() = True Or depth = 0 Then
            Dim puntnfalso, puntbfalso As Integer
            For i = 0 To 7
                For j = 0 To 7
                    If tablero(i, j) < 0 Then
                        puntnfalso += tablero(i, j)
                    End If
                    If tablero(i, j) > 0 Then
                        puntbfalso += tablero(i, j)
                    End If
                Next
            Next
            depth += 1
            Return Math.Abs(puntnfalso)
            'If Math.Abs(puntnfalso) > puntbfalso Then
            '    Return 1
            'Else
            '    Return -1
            'End If
        Else
            If gameoverpc() = False And depth > 0 Then
                'Dim maxEval As Integer = Integer.MinValue
                'Dim eval As Integer
                For i = 0 To 7
                    For j = 0 To 7
                        If tablero(i, j) = 0 Then
                            Dim caso As Integer = Casos(i, j)
                            ClickOrdenadorFalso(i, j, caso)
                            'MessageBox.Show(i & "," & j & " caso " & caso & " fichasbfalsas " & fichasbfalsas & " fichasnfalsas " & fichasnfalsas & " eval " & eval & " maxeval " & maxEval & " depth " & depth)
                            eval = Min(depth - 1, maxEval, minEval, eval)
                            If maxEval < eval Then
                                maxEval = eval
                                xx = j
                                yy = i
                                'tablero(i, j) = 0
                                'fichasnfalsas += 1
                                'Exit Function
                            End If
                            tablero(i, j) = 0
                            fichasnfalsas += 1
                        End If
                    Next
                Next
                Return maxEval
            Else
                Exit Function
            End If
        End If
    End Function

    Public Function Min(ByVal depth, ByVal maxEval, ByVal minEval, ByVal eval)
        If gameoverpc() = True Or depth = 0 Then
            Dim puntnfalso, puntbfalso As Integer
            For i = 0 To 7
                For j = 0 To 7
                    If tablero(i, j) < 0 Then
                        puntnfalso += tablero(i, j)
                    End If
                    If tablero(i, j) > 0 Then
                        puntbfalso += tablero(i, j)
                    End If
                Next
            Next
            depth += 1
            Return Math.Abs(puntnfalso)
            'If Math.Abs(puntnfalso) > puntbfalso Then
            '    Return 1
            'Else
            '    Return -1
            'End If
        Else
            If gameoverpc() = False And depth > 0 Then
                'Dim minEval As Integer = Integer.MaxValue                    
                'Dim eval As Integer
                For i = 0 To 7
                    For j = 0 To 7
                        If tablero(i, j) = 0 Then
                            Dim caso As Integer = Casos(i, j)
                            ClickFalso(i, j, caso)
                            'MessageBox.Show(i & "," & j & " caso " & caso & " fichasbfalsas " & fichasbfalsas & " fichasnfalsas " & fichasnfalsas & " eval " & eval & " mineval " & minEval & " depth " & depth)
                            eval = Max(depth - 1, maxEval, minEval, eval)
                            If minEval > eval Then
                                minEval = eval
                                xx = j
                                yy = i
                                'tablero(i, j) = 0
                                'fichasnfalsas += 1
                                'Exit Function
                            End If
                            tablero(i, j) = 0
                            fichasbfalsas += 1
                        End If
                    Next
                Next
                Return minEval
            Else
                Exit Function
            End If
        End If
    End Function

    Sub ordenador()
        fichasnfalsas = fichasn
        fichasbfalsas = fichasb
        Dim caso As Integer
        'Dim xx, yy As Integer
        Dim maxEval As Integer = Integer.MinValue
        Dim minEval As Integer = Integer.MaxValue
        Dim eval As Integer
        For i = 0 To 7
            For j = 0 To 7
                If tablero(i, j) = 0 Then
                    Dim depth As Integer = 3
                    caso = Casos(i, j)
                    ClickOrdenadorFalso(i, j, caso)
                    'MessageBox.Show(i & "," & j & " caso " & caso & " fichasbfalsas " & fichasbfalsas & " fichasnfalsas " & fichasnfalsas & " eval " & eval & " maxeval " & maxEval & " depth " & depth)
                    eval = Min(depth - 1, maxEval, minEval, eval)
                    If maxEval < eval Then
                        maxEval = eval
                        xx = j
                        yy = i
                        'tablero(i, j) = 0
                        'fichasnfalsas += 1
                    End If
                    tablero(i, j) = 0
                    fichasnfalsas += 1
                End If
            Next
        Next
        caso = Casos(yy, xx)
        ClickOrdenador(xx, yy, caso)
    End Sub

    Function gameoverpc()
        If fichasnfalsas = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function gameover()
        If fichasn = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
