﻿Imports System.Data.SqlClient
Public Class ActViajes
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim CN As New SqlConnection(connectionName)
        Dim str As String
        Dim via2 As String = Via.SelectedValue
        str = "Select * from Viajes where codviaje = '" + via2 + "'"
        GroupBox1.Enabled = True
        CN.Open()
        Dim cmd As New SqlCommand(str, CN)
        reader = cmd.ExecuteReader
        While reader.Read()
            Cod.Text = reader.Item("codruta")
            Fec.Value = reader.Item("fecha")
            Hor.Text = reader.Item("hora").ToString
        End While
        reader.Close()
        CN.Close()
    End Sub

    Private Sub ActViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As New SqlConnection(connectionName)
        CN.Open()
        Dim cmd As New SqlCommand("Select * from Viajes", CN)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tabla As New DataTable
        adp.Fill(tabla)
        Via.DisplayMember = "codviaje"
        Via.ValueMember = "codviaje"
        Via.DataSource = tabla
        CN.Close()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim str As String
        Dim via2 As String = Via.SelectedValue
        Dim cod2 As String = Cod.Text
        Dim hor2 As String = Hor.Text
        str = "Update Viajes set fecha='" + Fec.Value.Date + "',codruta='" + cod2 + "',hora='" + hor2 + "' where codviaje='" + via2 + "'"
        opcion = MessageBox.Show("El registro será actualizado permanentemente, ¿está seguro que desea actualizar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = vbYes Then
            UPDATE1(str)
        End If
        Hor.Clear()
        Cod.Clear()
        Fec.ResetText()
        GroupBox1.Enabled = False
    End Sub
End Class
