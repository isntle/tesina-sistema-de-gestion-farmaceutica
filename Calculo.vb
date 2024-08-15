Public Class Calculo

    Dim reset As Integer
    Dim cu, embalaje, transporte, carga, descarga As Double
    Dim cantidad As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CentroAplicaciones.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Ticket.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Estadisticas.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        BD.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        reset = reset + 1
        If reset = 1 Then
            My.Computer.Audio.Play(My.Resources.LOFI_Shelo, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Stop()
            Reset = 0
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Creditos.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim i As Integer

        For i = 1 To 2
            If i = 1 Then
                My.Computer.Audio.Stop()
            Else
                End
            End If

        Next
    End Sub

    Dim cm, embalaje1, transporte1, carga1, descarga1 As Double
    Dim cantidad1 As Integer

    Dim ctu, ctm, diff, iva As Double

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If t1.Text = "" Then
            cu = 0
        Else
            cu = Double.Parse(t1.Text)
            cu = Math.Round(cu, 2)
        End If

        If t2.Text = "" Then
            cantidad = 0
        Else
            cantidad = Integer.Parse(t2.Text)
            cantidad = Math.Round(cantidad, 2)
        End If

        If t3.Text = "" Then
            embalaje = 0
        Else
            embalaje = Double.Parse(t3.Text)
            embalaje = Math.Round(embalaje, 2)
        End If

        If t4.Text = "" Then
            transporte = 0
        Else
            transporte = Double.Parse(t4.Text)
            transporte = Math.Round(transporte, 2)
        End If

        If t5.Text = "" Then
            carga = 0
        Else
            carga = Double.Parse(t5.Text)
            carga = Math.Round(carga, 2)
        End If

        If t6.Text = "" Then
            descarga = 0
        Else
            descarga = Double.Parse(t6.Text)
            descarga = Math.Round(descarga, 2)
        End If

        If t7.Text = "" Then
            cm = 0
        Else
            cm = Double.Parse(t7.Text)
            cm = Math.Round(cm, 2)
        End If

        If t8.Text = "" Then
            cantidad1 = 0
        Else
            cantidad1 = Integer.Parse(t8.Text)
        End If

        If t9.Text = "" Then
            embalaje1 = 0
        Else
            embalaje1 = Double.Parse(t9.Text)
            embalaje1 = Math.Round(embalaje1, 2)
        End If

        If t10.Text = "" Then
            transporte1 = 0
        Else
            transporte1 = Double.Parse(t10.Text)
            transporte1 = Math.Round(transporte1, 2)
        End If

        If t11.Text = "" Then
            carga1 = 0
        Else
            carga1 = Double.Parse(t11.Text)
            carga1 = Math.Round(carga1, 2)
        End If

        If t12.Text = "" Then
            descarga1 = 0
        Else
            descarga1 = Double.Parse(t12.Text)
            descarga1 = Math.Round(descarga1, 2)
        End If

        ctu = cu * cantidad
        ctu = Math.Round(ctu, 2)

        ctm = cm * cantidad1
        ctm = Math.Round(ctm, 2)

        If ctu > ctm Then
            diff = ctu - ctm
            diff = Math.Round(diff, 2)

            iva = ctu * 0.16
            iva = Math.Round(iva, 2)

            l1.Text = ctu
            l2.Text = ctm
            l3.Text = diff
            l4.Text = "mayoreo"
            l5.Text = iva
            l6.Text = embalaje
            l7.Text = transporte
            l8.Text = carga
            l9.Text = descarga
        Else
            diff = ctm - ctu
            diff = Math.Round(diff, 2)

            iva = ctu * 0.16
            iva = Math.Round(iva, 2)

            l1.Text = ctu
            l2.Text = ctm
            l3.Text = diff
            l4.Text = "unitario"
            l5.Text = iva
            l6.Text = embalaje1
            l7.Text = transporte1
            l8.Text = carga1
            l9.Text = descarga1
        End If

        If l1.Text = 0 Then
            l1.Text = ""
        End If
        If l2.Text = 0 Then
            l2.Text = ""
        End If
        If l3.Text = 0 Then
            l3.Text = ""
        End If
        If l1.Text = "" Or l2.Text = "" Or l3.Text = "" Or l4.Text = "" Or l5.Text = "" Or l6.Text = "" Or l7.Text = "" Or l8.Text = "" Or l9.Text = "" Then
            l4.Text = "Error"
            MsgBox("Se deben llenar todos los campos")
        End If
        If l5.Text = 0 Then
            l5.Text = ""
        End If
        If l6.Text = 0 Then
            l6.Text = ""
        End If
        If l7.Text = 0 Then
            l7.Text = ""
        End If
        If l8.Text = 0 Then
            l8.Text = ""
        End If
        If l9.Text = 0 Then
            l9.Text = ""
        End If

    End Sub
End Class