Public Class Estadisticas

    Dim reset As Integer
    Dim u1 As Integer
    Dim per1, per2, diffper As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CentroAplicaciones.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Ticket.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Calculo.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        BD.Show()
    End Sub

    Dim pbu, ct, cc, cd, g As Double

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

    Dim u As Integer

    Dim pbu1, ct1, cc1, cd1, g1 As Double

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Creditos.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        reset = reset + 1
        If reset = 1 Then
            My.Computer.Audio.Play(My.Resources.LOFI_Shelo, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Stop()
            reset = 0
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If t2.Text = "" Then
            pbu = 0
        Else
            pbu = Integer.Parse(t2.Text)
        End If

        If t3.Text = "" Then
            u = 0
        Else
            u = Double.Parse(t3.Text)
            u = Math.Round(u, 2)
        End If

        If t4.Text = "" Then
            ct = 0
        Else
            ct = Double.Parse(t4.Text)
            ct = Math.Round(ct, 2)
        End If

        If t5.Text = "" Then
            cc = 0
        Else
            cc = Double.Parse(t5.Text)
            cc = Math.Round(cc, 2)
        End If

        If t6.Text = "" Then
            cd = 0
        Else
            cd = Double.Parse(t6.Text)
            cd = Math.Round(cd, 2)
        End If

        If t7.Text = "" Then
            g = 0
        Else
            g = Double.Parse(t7.Text)
            g = Math.Round(g, 2)
        End If

        If t9.Text = "" Then
            pbu1 = 0
        Else
            pbu1 = Integer.Parse(t9.Text)
        End If

        If t10.Text = "" Then
            u1 = 0
        Else
            u1 = Double.Parse(t10.Text)
            u1 = Math.Round(u1, 2)
        End If

        If t11.Text = "" Then
            ct1 = 0
        Else
            ct1 = Double.Parse(t11.Text)
            ct1 = Math.Round(ct1, 2)
        End If

        If t12.Text = "" Then
            cc1 = 0
        Else
            cc1 = Double.Parse(t12.Text)
            cc1 = Math.Round(cc1, 2)
        End If

        If t13.Text = "" Then
            cd1 = 0
        Else
            cd1 = Double.Parse(t13.Text)
            cd1 = Math.Round(cd1, 2)
        End If

        If t14.Text = "" Then
            g1 = 0
        Else
            g1 = Double.Parse(t14.Text)
            g1 = Math.Round(g1, 2)
        End If


        per1 = g * 100 / (pbu * u + ct + cc + cd)

        per2 = g1 * 100 / (pbu1 * u1 + ct1 + cc1 + cd1)

        If per1 > per2 Then
            diffper = per1 - per2
        Else
            diffper = per2 - per1
        End If

        per1 = Math.Round(per1, 2)
        per2 = Math.Round(per2, 2)
        diffper = Math.Round(diffper, 2)


        l1.Text = per1 & "%"
        l2.Text = per2 & "%"
        l3.Text = diffper & "%"

        If l1.Text = "NaN%" Then
            l1.Text = ""
        End If

        If l2.Text = "NaN%" Then
            l2.Text = ""
        End If

        If l3.Text = "NaN%" Then
            l3.Text = ""
        End If

        If t2.Text = "" Or t3.Text = "" Or t4.Text = "" Or t5.Text = "" Or t6.Text = "" Or t7.Text = "" Or t9.Text = "" Or t10.Text = "" Or t11.Text = "" Or t12.Text = "" Or t13.Text = "" Or t14.Text = "" Then
            MsgBox("Se deben llenar todos los campos")
        End If
    End Sub
End Class