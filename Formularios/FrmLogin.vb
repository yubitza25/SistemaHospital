Public Class FrmLogin


    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim IniciarUsuario As New FrmRegistrarUsuario
        Me.Hide()
        IniciarUsuario.ShowDialog()
        Me.Close()
    End Sub

End Class
