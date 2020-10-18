Public Class Form2


    Dim edad
    Dim estatura
    Dim peso
    Dim contAs As Integer = 0
    Dim contAsH As Integer = 0
    Dim contAsM As Integer = 0
    Dim contAsSelected As Integer = 0
    Dim contAsSH As Integer = 0
    Dim contAsSM As Integer = 0
    Dim contEdadHS As Integer = 0
    Dim contEdadMS As Integer = 0
    Dim contEstaturaPHS As Double = 0
    Dim contEstaturaPMS As Double = 0
    Dim contRechazos As Integer = 0
    Dim contRechazosH As Integer = 0
    Dim contRechazosM As Integer = 0



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
                Form3.lblAsSelected.Text = contAsSelected

                If checkMasculino.Checked = True Then
                    contAsSH = contAsSH + 1

                    Form3.lblHSelected.Text = contAsSH




                    contEdadHS = contEdadHS + edad


                    contEstaturaPHS = contEstaturaPHS + estatura


                End If
                Form3.lblPHSelected.Text = contAsSH * 100 / contAsSelected
                Form3.lblEdadPHS.Text = contEdadHS / contAsSH
                Form3.lblEstaturaPHS.Text = contEstaturaPHS / contAsSH

                If checkFemenino.Checked = True Then
                    contAsSM = contAsSM + 1

                    Form3.lblMSelected.Text = contAsSM



                    contEdadMS = contEdadMS + edad


                    contEstaturaPMS = contEstaturaPMS + estatura



                End If

                If estatura > Double.Parse(Form3.label_estatura_alto.Text) Then
                    Form3.label_estatura_alto.Text = estatura
                    Form3.label_estatura_nombre_alto.Text = inputNombre.Text

                End If



                If estatura < Double.Parse(Form3.label_estatura_bajo.Text) Then
                    Form3.label_estatura_nombre_bajo.Text = estatura
                    Form3.label_estatura_nombre_bajo.Text = inputNombre.Text

                End If


                Form3.lblPMSelected.Text = contAsSM * 100 / contAsSelected
                Form3.lblEdadPMS.Text = contEdadMS / contAsSM
                Form3.lblEstaturaPMS.Text = contEstaturaPMS / contAsSM

            Else
                If checkMasculino.Checked = True Then
                    contRechazosH = contRechazosH + 1
                End If

                If checkFemenino.Checked = True Then
                    contRechazosM = contRechazosM + 1
                End If

                contRechazos = contRechazosM + contRechazosH

                Form3.lblRechazados.Text = contRechazos

                Form3.lblRechazadosH.Text = contRechazosH
                Form3.lblRechazadosM.Text = contRechazosM


                Form3.lblPHRechazo.Text = contRechazosH * 100 / contRechazos
                Form3.lblPMRechazo.Text = contRechazosM * 100 / contRechazos




            End If



            contAs = contAs + 1
            Form3.t_usuarios.Text = contAs

            Form3.lblAsPH.Text = contAsH * 100 / contAs
            Form3.lblAsPM.Text = contAsM * 100 / contAs
            Form3.lblRechazados.Text = contAs - contAsSelected

        End If

    End Sub


    Function verificar() As Boolean

        If checkMasculino.Checked = True Then
            contAsH = contAsH + 1
        End If

        If checkFemenino.Checked = True Then
            contAsM = contAsM + 1
        End If

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

    Private Sub inputEdad_TextChanged(sender As Object, e As EventArgs) Handles inputEdad.TextChanged

    End Sub
End Class