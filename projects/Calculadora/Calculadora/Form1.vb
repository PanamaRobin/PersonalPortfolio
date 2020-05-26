Public Class Form1
    Dim x As String
    Dim operacion(10) As String
    Dim resultado As Double
    Dim valor(0 To 20) As Double
    Dim cadena As String
    Dim temp4 As Integer = 0
    Dim temp3 As String
    Dim temp2 As Double = 0
    Dim temp As Integer = 0
    Dim contnum, contpt, contclck, contop As Integer
    Dim contsalto As Integer = 0
    Dim tri As Integer = 0
    Dim expo As Integer = 0
    Dim nueva As Integer = 0
    Dim ans As Double

    Private Sub Cero_Click(sender As Object, e As EventArgs) Handles Cero.Click
        contclck += 1
        TextBox1.Text &= "0"
    End Sub

    Private Sub Uno_Click(sender As Object, e As EventArgs) Handles Uno.Click
        contclck += 1
        TextBox1.Text &= "1"
    End Sub

    Private Sub Dos_Click(sender As Object, e As EventArgs) Handles Dos.Click
        contclck += 1
        TextBox1.Text &= "2"
    End Sub

    Private Sub Tres_Click(sender As Object, e As EventArgs) Handles Tres.Click
        contclck += 1
        TextBox1.Text &= "3"
    End Sub

    Private Sub Cuatro_Click(sender As Object, e As EventArgs) Handles Cuatro.Click
        contclck += 1
        TextBox1.Text &= "4"
    End Sub

    Private Sub Cinco_Click(sender As Object, e As EventArgs) Handles Cinco.Click
        contclck += 1
        TextBox1.Text &= "5"
    End Sub

    Private Sub Seis_Click(sender As Object, e As EventArgs) Handles Seis.Click
        contclck += 1
        TextBox1.Text &= "6"
    End Sub

    Private Sub Siete_Click(sender As Object, e As EventArgs) Handles Siete.Click
        contclck += 1
        TextBox1.Text &= "7"
    End Sub

    Private Sub Ocho_Click(sender As Object, e As EventArgs) Handles Ocho.Click
        contclck += 1
        TextBox1.Text &= "8"
    End Sub

    Private Sub Nueve_Click(sender As Object, e As EventArgs) Handles Nueve.Click
        contclck += 1
        TextBox1.Text &= "9"
    End Sub

    Private Sub AC_Click(sender As Object, e As EventArgs) Handles AC.Click
        ans = valor(0)
        TextBox1.Text = ""
        contclck = 0
        contop = 0
        tri = 0
        expo = 0
        nueva = 0
        contsalto = 0
        contnum = 0
        contpt = 0
        temp = 0
        temp2 = 0
        cadena = ""
        resultado = 0
        x = ""
        For i = 0 To 20
            valor(i) = 0
        Next
        For i = 0 To 10
            operacion(i) = ""
        Next
    End Sub

    Private Sub Punto_Click(sender As Object, e As EventArgs) Handles Punto.Click
        contclck += 1
        Puntof()
    End Sub

    Public Sub Puntof()
        If (contop = contpt) Then
            TextBox1.Text &= "."
            contpt += 1
        Else
            MessageBox.Show("No se puede poner más de un punto.", "No entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Por_Click(sender As Object, e As EventArgs) Handles Por.Click
        contclck += 1
        operacion(contop) = "*"
        contop += 1
        funcion()
        TextBox1.Text &= "×"
    End Sub

    Private Sub Entre_Click(sender As Object, e As EventArgs) Handles Entre.Click
        contclck += 1
        operacion(contop) = "/"
        contop += 1
        funcion()
        TextBox1.Text &= "÷"
    End Sub

    Private Sub Mas_Click(sender As Object, e As EventArgs) Handles Mas.Click
        contclck += 1
        operacion(contop) = "+"
        contop += 1
        funcion()
        TextBox1.Text &= "+"
    End Sub

    Private Sub Coseno_Click(sender As Object, e As EventArgs) Handles Coseno.Click
        contclck += 4
        TextBox1.Text &= "Cos "
        tri = 1
    End Sub

    Private Sub Seno_Click(sender As Object, e As EventArgs) Handles Seno.Click
        contclck += 4
        TextBox1.Text &= "Sen "
        tri = 2
    End Sub

    Private Sub Tangente_Click(sender As Object, e As EventArgs) Handles Tangente.Click
        contclck += 4
        TextBox1.Text &= "Tan "
        tri = 3
    End Sub

    Private Sub Secante_Click(sender As Object, e As EventArgs) Handles Secante.Click
        contclck += 4
        TextBox1.Text &= "Sec "
        tri = 4
    End Sub

    Private Sub Cosecante_Click(sender As Object, e As EventArgs) Handles Cosecante.Click
        contclck += 4
        TextBox1.Text &= "Csc "
        tri = 5
    End Sub

    Private Sub Cotangente_Click(sender As Object, e As EventArgs) Handles Cotangente.Click
        contclck += 4
        TextBox1.Text &= "Cot "
        tri = 6
    End Sub

    Private Sub Log_Click(sender As Object, e As EventArgs) Handles Log.Click
        contclck += 4
        TextBox1.Text &= "Log "
        tri = 7
    End Sub

    Private Sub Ln_Click(sender As Object, e As EventArgs) Handles Ln.Click
        contclck += 3
        TextBox1.Text &= "Ln "
        tri = 8
    End Sub

    Private Sub Raiz_Click(sender As Object, e As EventArgs) Handles Raiz.Click
        contclck += 1
        TextBox1.Text &= "√"
        tri = 9
    End Sub

    Private Sub Cuadrado_Click(sender As Object, e As EventArgs) Handles Cuadrado.Click
        contclck += 1
        TextBox1.Text &= "²"
        tri = 10
    End Sub

    Private Sub Exponente_Click(sender As Object, e As EventArgs) Handles Exponente.Click
        contclck += 1
        nueva = contclck
        TextBox1.Text &= "^"
        tri = 11
    End Sub

    Private Sub Menos_Click(sender As Object, e As EventArgs) Handles Menos.Click
        contclck += 1
        operacion(contop) = "-"
        contop += 1
        funcion()
        TextBox1.Text &= "-"
    End Sub

    Private Sub Answer_Click(sender As Object, e As EventArgs) Handles Answer.Click
        temp3 = ans.ToString
        temp4 = temp3.length
        contclck += temp4
        TextBox1.Text &= ans
    End Sub

    Private Sub Igual_Click(sender As Object, e As EventArgs) Handles Igual.Click
        contop += 1
        funcion()
        resolver()
    End Sub


    Public Sub funcion()
        cadena = ""
        If contop > 1 Then
            x = TextBox1.Text
            temp = x.Length
            If (tri = 1) Then
                For i = contsalto + 4 To temp - 1
                    cadena &= x.Substring(i, 1)
                Next
                temp2 = Val(cadena)
                valor(contnum) = Math.Cos(temp2 * Math.PI / 180)
            Else
                If (tri = 2) Then
                    For i = contsalto + 4 To temp - 1
                        cadena &= x.Substring(i, 1)
                    Next
                    temp2 = Val(cadena)
                    valor(contnum) = Math.Sin(temp2 * Math.PI / 180)
                Else
                    If (tri = 3) Then
                        For i = contsalto + 4 To temp - 1
                            cadena &= x.Substring(i, 1)
                        Next
                        temp2 = Val(cadena)
                        valor(contnum) = Math.Tan(temp2 * Math.PI / 180)
                    Else
                        If (tri = 4) Then
                            For i = contsalto + 4 To temp - 1
                                cadena &= x.Substring(i, 1)
                            Next
                            temp2 = Val(cadena)
                            valor(contnum) = 1 / Math.Cos(temp2 * Math.PI / 180)
                        Else
                            If (tri = 5) Then
                                For i = contsalto + 4 To temp - 1
                                    cadena &= x.Substring(i, 1)
                                Next
                                temp2 = Val(cadena)
                                valor(contnum) = 1 / Math.Sin(temp2 * Math.PI / 180)
                            Else
                                If (tri = 6) Then
                                    For i = contsalto + 4 To temp - 1
                                        cadena &= x.Substring(i, 1)
                                    Next
                                    temp2 = Val(cadena)
                                    valor(contnum) = 1 / Math.Tan(temp2 * Math.PI / 180)
                                Else
                                    If (tri = 7) Then
                                        For i = contsalto + 4 To temp - 1
                                            cadena &= x.Substring(i, 1)
                                        Next
                                        temp2 = Val(cadena)
                                        valor(contnum) = Math.Log10(temp2)
                                    Else
                                        If (tri = 8) Then
                                            For i = contsalto + 3 To temp - 1
                                                cadena &= x.Substring(i, 1)
                                            Next
                                            temp2 = Val(cadena)
                                            valor(contnum) = Math.Log(temp2)
                                        Else
                                            If (tri = 9) Then
                                                For i = contsalto + 2 To temp - 1
                                                    cadena &= x.Substring(i, 1)
                                                Next
                                                temp2 = Val(cadena)
                                                valor(contnum) = Math.Sqrt(temp2)
                                            Else
                                                If (tri = 10) Then
                                                    For i = contsalto + 1 To temp - 2
                                                        cadena &= x.Substring(i, 1)
                                                    Next
                                                    temp2 = Val(cadena)
                                                    valor(contnum) = Math.Pow(temp2, 2)
                                                Else
                                                    If (tri = 11) Then
                                                        For i = contsalto + 1 To temp - 3
                                                            cadena &= x.Substring(i, 1)
                                                        Next
                                                        temp2 = Val(cadena)
                                                        cadena = ""
                                                        For i = nueva To temp - 1
                                                            cadena &= x.Substring(i, 1)
                                                        Next
                                                        expo = Val(cadena)
                                                        valor(contnum) = Math.Pow(temp2, expo)
                                                    Else
                                                        For i = contsalto + 1 To temp - 1
                                                            cadena &= x.Substring(i, 1)
                                                        Next
                                                        valor(contnum) = Val(cadena)
                                                        contsalto = x.Length
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            x = TextBox1.Text
            contsalto = x.Length
            If (tri = 1) Then
                For i = 4 To contsalto - 1
                    cadena &= x.Substring(i, 1)
                Next
                temp2 = Val(cadena)
                valor(contnum) = Math.Cos(temp2 * Math.PI / 180)
            Else
                If (tri = 2) Then
                    For i = 4 To contsalto - 1
                        cadena &= x.Substring(i, 1)
                    Next
                    temp2 = Val(cadena)
                    valor(contnum) = Math.Sin(temp2 * Math.PI / 180)
                Else
                    If (tri = 3) Then
                        For i = 4 To contsalto - 1
                            cadena &= x.Substring(i, 1)
                        Next
                        temp2 = Val(cadena)
                        valor(contnum) = Math.Tan(temp2 * Math.PI / 180)
                    Else
                        If (tri = 4) Then
                            For i = 4 To contsalto - 1
                                cadena &= x.Substring(i, 1)
                            Next
                            temp2 = Val(cadena)
                            valor(contnum) = 1 / Math.Cos(temp2 * Math.PI / 180)
                        Else
                            If (tri = 5) Then
                                For i = 4 To contsalto - 1
                                    cadena &= x.Substring(i, 1)
                                Next
                                temp2 = Val(cadena)
                                valor(contnum) = 1 / Math.Sin(temp2 * Math.PI / 180)
                            Else
                                If (tri = 6) Then
                                    For i = 4 To contsalto - 1
                                        cadena &= x.Substring(i, 1)
                                    Next
                                    temp2 = Val(cadena)
                                    valor(contnum) = 1 / Math.Tan(temp2 * Math.PI / 180)
                                Else
                                    If (tri = 7) Then
                                        For i = 4 To contsalto - 1
                                            cadena &= x.Substring(i, 1)
                                        Next
                                        temp2 = Val(cadena)
                                        valor(contnum) = Math.Log10(temp2)
                                    Else
                                        If (tri = 8) Then
                                            For i = 3 To contsalto - 1
                                                cadena &= x.Substring(i, 1)
                                            Next
                                            temp2 = Val(cadena)
                                            valor(contnum) = Math.Log(temp2)
                                        Else
                                            If (tri = 9) Then
                                                For i = 1 To contsalto - 1
                                                    cadena &= x.Substring(i, 1)
                                                Next
                                                temp2 = Val(cadena)
                                                valor(contnum) = Math.Sqrt(temp2)
                                            Else
                                                If (tri = 10) Then
                                                    For i = 0 To contsalto - 2
                                                        cadena &= x.Substring(i, 1)
                                                    Next
                                                    temp2 = Val(cadena)
                                                    valor(contnum) = Math.Pow(temp2, 2)
                                                Else
                                                    If (tri = 11) Then
                                                        For i = 0 To contsalto - 3
                                                            cadena &= x.Substring(i, 1)
                                                        Next
                                                        temp2 = Val(cadena)
                                                        cadena = ""
                                                        For i = nueva To contsalto - 1
                                                            cadena &= x.Substring(i, 1)
                                                        Next
                                                        expo = Val(cadena)
                                                        valor(contnum) = Math.Pow(temp2, expo)
                                                    Else
                                                        valor(contnum) = Val(x)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        contnum += 1
        tri = 0
    End Sub

    Public Sub resolver()
        Do While contop >= 1 And contnum > 1
            For i = 0 To contop - 1

                If (operacion(i) = "*") Then
                    resultado = valor(i) * valor(i + 1)
                    valor(i) = resultado
                    For vc = i + 1 To contnum
                        valor(vc) = valor(vc + 1)
                    Next
                    For vc = i To contop
                        operacion(vc) = operacion(vc + 1)
                    Next
                    contnum -= 1
                    contop -= 1
                Else
                    If (operacion(i) = "/") Then
                        resultado = valor(i) / valor(i + 1)
                        valor(i) = resultado
                        For vc = i + 1 To contnum
                            valor(vc) = valor(vc + 1)
                        Next
                        For vc = i To contop
                            operacion(vc) = operacion(vc + 1)
                        Next
                        contnum -= 1
                        contop -= 1
                    End If
                End If
            Next
            For i = 0 To contop - 1

                If (operacion(i) = "+") Then
                    resultado = valor(i) + valor(i + 1)
                    valor(i) = resultado
                    For vc = i + 1 To contnum
                        valor(vc) = valor(vc + 1)
                    Next
                    For vc = i To contop
                        operacion(vc) = operacion(vc + 1)
                    Next
                    contnum -= 1
                    contop -= 1
                Else
                    If (operacion(i) = "-") Then
                        resultado = valor(i) - valor(i + 1)
                        valor(i) = resultado
                        For vc = i + 1 To contnum
                            valor(vc) = valor(vc + 1)
                        Next
                        For vc = i To contop
                            operacion(vc) = operacion(vc + 1)
                        Next
                        contnum -= 1
                        contop -= 1
                    End If
                End If
            Next
        Loop
        TextBox1.Text = valor(0)
    End Sub
End Class