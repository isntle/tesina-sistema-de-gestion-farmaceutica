Imports System.Web.UI.WebControls

Public Class Ticket

    Dim reset As Integer
    Dim cantidad As Integer
    Dim precio, monto, pagaC, cambio As Double
    Dim sucursal, numero As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CentroAplicaciones.Show()
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Creditos.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If t1.Text = "" Then
            cantidad = 0
        Else
            cantidad = Integer.Parse(c1.Text)
            cantidad = Math.Round(cantidad, 2)
        End If


        If t2.Text = "" Then
            precio = 0
        Else
            precio = Double.Parse(t2.Text)
            precio = Math.Round(precio, 2)
        End If


        If t3.Text = "" Then
            pagaC = 0
        Else
            pagaC = Double.Parse(t3.Text)
            pagaC = Math.Round(pagaC, 2)
        End If

        If t1.Text = "" Or t2.Text = "" Or t3.Text = "" Then
            MsgBox("Se deben llenar todos los campos")

            l1.Text = "0"
            l2.Text = "error"
            l3.Text = "0"
            l4.Text = "error"
            l5.Text = "error"
            l6.Text = "0"
            l7.Text = "error"
            l8.Text = "0"
            l9.Text = "Error"
            l10.Text = "Error"
        Else
            monto = precio * cantidad

            cambio = pagaC - monto
            sucursal = tSucursal.Text
            numero = tNum.text

            If pagaC >= monto Then
                l1.Text = cantidad
                l2.Text = t1.Text
                l3.Text = "$" & precio
                l4.Text = c2.Text
                l5.Text = t3.Text
                l6.Text = "$" & cambio
                l7.Text = c3.Text
                l8.Text = "$" & monto
                l9.Text = numero
                l10.Text = sucursal
            Else
                MsgBox("No puede pagar menos que el monto total de la venta", vbInformation, "Error de venta")
            End If
        End If





    End Sub

End Class