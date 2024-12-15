Imports System.Data.OleDb

Public Class BD

    Dim reset As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PRODUCTOSBindingNavigator.Visible = False
        PRODUCTOSDataGridView.ReadOnly = True

        Label5.Text = "Base de datos"
        t1.Text = ""
        Label6.Text = ""

        Me.Hide()
        CentroAplicaciones.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PRODUCTOSBindingNavigator.Visible = False
        PRODUCTOSDataGridView.ReadOnly = True

        Label5.Text = "Base de datos"
        t1.Text = ""
        Label6.Text = ""

        Me.Hide()
        Ticket.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PRODUCTOSBindingNavigator.Visible = False
        PRODUCTOSDataGridView.ReadOnly = True

        Label5.Text = "Base de datos"
        t1.Text = ""
        Label6.Text = ""

        Me.Hide()
        Calculo.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PRODUCTOSBindingNavigator.Visible = False
        PRODUCTOSDataGridView.ReadOnly = True

        Label5.Text = "Base de datos"
        t1.Text = ""
        Label6.Text = ""

        Me.Hide()
        Estadisticas.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub PRODUCTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRODUCTOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRODUCTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PRODUCTOS_FARMACEUTICADataSet)

    End Sub

    Private Sub BD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PRODUCTOS_FARMACEUTICADataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.PRODUCTOS_FARMACEUTICADataSet.PRODUCTOS)
        PRODUCTOSBindingNavigator.Visible = False
        PRODUCTOSDataGridView.ReadOnly = True
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim i As Integer

        For i = 1 To 2
            If i = 1 Then
                My.Computer.Audio.Stop()
            Else
                End
            End If

        Next


        End
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim conexion As New OleDb.OleDbConnection
        Dim comandos As New OleDbCommand
        Dim adaptador As New OleDbDataAdapter
        Dim lector As OleDbDataReader
        Dim admin As Integer

        admin = 0

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ADMINMODE.accdb"
            conexion.Open()
            admin = 1
        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos", vbExclamation, "Error")
            admin = 0
        End Try

        If admin = 1 Then

            Dim consulta As String
            consulta = "SELECT *FROM ADMINMODE WHERE ADMIN='" & t1.Text & "'"
            comandos = New OleDbCommand(consulta, conexion)
            adaptador.SelectCommand = comandos
            lector = comandos.ExecuteReader
            If lector.Read = True Then
                MsgBox("Modo administrador activado", vbInformation, "Correcto")
                PRODUCTOSBindingNavigator.Visible = True
                PRODUCTOSDataGridView.ReadOnly = False
                Label5.Text = "Base de datos"
                t1.Text = ""
                Label6.Text = "MODO ADMINISTRADOR ACTIVADO"
            Else
                MsgBox("Incorrecto, esa no es la contraseña", vbExclamation, "Consigue la contraseña de admin")
            End If

        End If
    End Sub
    '''Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PRODUCTOS_FARMACEUTICA.accdb
End Class