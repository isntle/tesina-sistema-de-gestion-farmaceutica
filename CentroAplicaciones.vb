Public Class CentroAplicaciones

    Dim reset As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            reset = 0
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

    Private Sub p_Click(sender As Object, e As EventArgs) Handles p.Click

    End Sub
    Private Sub p2_Click(sender As Object, e As EventArgs) Handles p.Click
        Me.Hide()
        Ticket.Show()
    End Sub
    Private Sub p3_Click(sender As Object, e As EventArgs) Handles p.Click
        Me.Hide()
        Calculo.Show()
    End Sub
    Private Sub p4_Click(sender As Object, e As EventArgs) Handles p.Click
        Me.Hide()
        Estadisticas.Show()
    End Sub
    Private Sub p5_Click(sender As Object, e As EventArgs) Handles p.Click
        Me.Hide()
        BD.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim i As Integer

        For i = 1 To 2
            If i = 1 Then
                My.Computer.Audio.Stop()
            Else
                End
            End If

        Next
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Ticket.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Calculo.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Estadisticas.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        BD.Show()
    End Sub
End Class