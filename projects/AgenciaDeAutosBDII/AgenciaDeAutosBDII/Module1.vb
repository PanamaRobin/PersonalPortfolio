Imports System.Data.SqlClient
Module Module1
    Public CN As SqlConnection
    Public opcion As MsgBoxResult
    Public reader As SqlDataReader
    Public Sub ABRIRCONEXION()
        CN = New SqlConnection("Server=DESKTOP-1E83J98\SQLEXPRESS;Database=AgenciaDeSeguros;Integrated Security=true")
        Try
            CN.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Function CONSULTAR() As DataTable
    '    CN.Open()
    '    Dim cmd As New SqlCommand("Select * from EMPLEADO", CN)
    '    Dim empleados As New DataTable
    '    Try
    '        reader = cmd.ExecuteReader
    '        empleados.Load(reader)
    '        reader.Close()
    '        CN.Close()
    '        Return empleados
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        CN.Close()
    '        Return Nothing
    '    End Try
    'End Function

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
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
            CN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CN.Close()
        End Try
    End Sub
End Module
