Imports System.Data.OleDb

Public Class Login

    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim lector As OleDbDataReader
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged

        '''Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Usuarios.accdb
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\USER_PASSWORD.accdb"
            conexion.Open()
            MsgBox("Conectado a la base de datos existosamente", vbInformation, "Conectado")
        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos", vbExclamation, "Error")
        End Try
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim consulta As String
        consulta = "SELECT *FROM SESION WHERE USUARIO='" & t1.Text & "' AND CONTRASEÑA='" & t2.Text & "'"
        comandos = New OleDbCommand(consulta, conexion)
        adaptador.SelectCommand = comandos
        lector = comandos.ExecuteReader
        If lector.Read = True Then
            MsgBox("Si existe el usuario", vbInformation, "Correcto")
            btnContinuar.Visible = True
        Else
            MsgBox("No existe el usuario", vbExclamation, "Error")
        End If
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        Me.Hide()
        CentroAplicaciones.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()

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
