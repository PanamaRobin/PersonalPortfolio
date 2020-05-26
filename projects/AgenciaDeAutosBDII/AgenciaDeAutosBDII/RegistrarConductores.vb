Public Class RegistrarConductores
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        nom.Clear()
        ape.Clear()
        dni.Clear()
        tel.Clear()
        pob.Clear()
        dir.Clear()
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Dim str As String
        Dim nom2 As String = nom.Text
        Dim ape2 As String = ape.Text
        Dim dni2 As String = dni.Text
        Dim tel2 As String = tel.Text
        Dim pob2 As String = pob.Text
        Dim dir2 As String = dir.Text
        str = "Insert into Persona(dnipersona,	nompersona,	apepersona,	direcpersona, poblacion, telefono) values('" + dni2 + "','" + nom2 + "','" + ape2 + "','" + dir2 + "','" + pob2 + "','" + tel2 + "')"
        INSERTAR(str)
        nom.Clear()
        ape.Clear()
        dni.Clear()
        tel.Clear()
        pob.Clear()
        dir.Clear()
    End Sub
End Class
