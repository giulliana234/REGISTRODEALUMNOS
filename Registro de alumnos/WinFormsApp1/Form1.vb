Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Dim nombre As String
    Dim apellido As String
    Dim grado As Integer
    Dim edad As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        grado = txtGrado.Text
        edad = txtEdad.Text

        MsgBox(" Bienvenido " & nombre & " " & apellido & " " &
           "del " & grado & " grado " & " con la edad de  " & edad & " años")
        MsgBox("Se registro exitosamente")
    End Sub

    Private Sub btnCarnet_Click(sender As Object, e As EventArgs) Handles btnCarnet.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtGrado.Text = ""
        txtEdad.Text = ""
    End Sub
End Class
