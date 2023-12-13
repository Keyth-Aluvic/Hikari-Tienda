Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String
        Dim pass As String
        user = txtUser.Text
        pass = txtPass.Text
        If (user.Equals("HikikoKari") And pass.Equals("DnD24")) Then
            MessageBox.Show("Ingreso exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MenuP.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaForm(Me)
    End Sub
End Class