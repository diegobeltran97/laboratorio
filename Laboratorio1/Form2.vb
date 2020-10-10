Public Class Form2


    Dim edad
    Dim estatura
    Dim peso
    Dim contAs As Integer = 0
    Dim contAsSelected As Integer = 0

    Private Sub buttonEnviar_Click(sender As Object, e As EventArgs) Handles buttonEnviar.Click

        'Verificar datos no esten vacios'
        If inputNombre.Text = "" Or inputCedula.Text = "" Or
            inputTelefono.Text = "" Or
            inputDireccion.Text = "" Or inputEdad.Text = "" Or
            inputEstatura.Text = "" Or inputPeso.Text = "" Or checkMasculino.Checked = False And
            checkFemenino.Checked = False Or checkNo.Checked = False And checkSi.Checked = False Then
            MsgBox("Faltan datos")

        Else
            edad = Integer.Parse(inputEdad.Text)
            estatura = Double.Parse(inputEstatura.Text)
            peso = Double.Parse(inputPeso.Text)

            If verificar() Then
                MsgBox("Datos Correctos")
                contAsSelected = contAsSelected + 1
                Form3.lblAsPH.Text = contAsSelected
            End If

            contAs = contAs + 1
            Form3.t_usuarios.Text = contAs

        End If

    End Sub


    Function verificar() As Boolean

        If edad < 14 And edad > 18 Then
            MsgBox("No cumple con el requisito edad")
            Return False
        End If

        If estatura < 1.8 Then
            MsgBox("No cumple con el requisito estatura")
            Return False
        End If

        If peso > 160 Then
            MsgBox("No cumple con el requisito peso")
            Return False
        End If

        If checkNo.Checked = True Then
            MsgBox("No cumple con el requisito disponible para viajar")
            Return False
        End If

        Return True



    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class