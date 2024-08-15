Public Class Creditos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CentroAplicaciones.Show()
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
End Class