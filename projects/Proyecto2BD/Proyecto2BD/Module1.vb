Imports System.Data.SqlClient
Module Module1
    Public CN As SqlConnection
    Public opcion As MsgBoxResult
    Public reader As SqlDataReader
    Public connectionName As String = "Server=DESKTOP-1E83J98\SQLEXPRESS;Database=DBViajes;Integrated Security=true"
    Public Sub ABRIRCONEXION()
        CN = New SqlConnection(connectionName)
        Try
            CN.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Public Sub CONSULTAR(str As String)
        CN.Open()
        Try
            Dim cmd As New SqlCommand(str, CN)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i >= 1 Then
                MsgBox("El registro ha sido eliminado.")
            Else
                MsgBox("Revise su llave, el registro no existe.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Public Sub INSERTAR(str As String)
        CN.Open()
        Try
            Dim cmd As New SqlCommand(str, CN)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i >= 1 Then
                MsgBox("El registro ha sido guardado.")
            Else
                MsgBox("El registro no pudo ser completado.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Public Sub ELIMINAR(str As String)
        CN.Open()
        Try
            Dim cmd As New SqlCommand(str, CN)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i >= 1 Then
                MsgBox("El registro ha sido eliminado.")
            Else
                MsgBox("Revise su llave, el registro no existe.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Public Sub UPDATE1(str As String)
        CN.Open()
        Try
            Dim cmd As New SqlCommand(str, CN)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i >= 1 Then
                MsgBox("El registro ha sido actualizado.")
            Else
                MsgBox("Revise su llave, el registro no existe.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Function traerdatos(cod As String) As List(Of String)
        CN.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("Select nomatraccion from Tours where codlugar = @cod", CN)
        cmd.Parameters.AddWithValue("@cod", cod)
        Dim lista As New List(Of String)
        Try
            reader = cmd.ExecuteReader
            If (reader.Read) Then
                lista.Add(reader.GetString(0))
                While (reader.Read())
                    lista.Add(reader.GetString(0))
                End While

                'For i As Integer = 0 To 2
                '    lista.Add(reader(i))
                'Next
                reader.Close()
                Return lista
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            CN.Close()
        End Try
    End Function

End Module
