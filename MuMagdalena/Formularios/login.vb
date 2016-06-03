Imports System.Windows.Forms

Public Class login
    Dim WithEvents usuario As New claseUsuario
    Dim intentos As Integer = 0

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = menuPrincipal
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Dim bean As BeanUsuario = usuario.validar(txtCod_usuario.Text, txtPassword.Text)
        If bean IsNot Nothing Then
            menuPrincipal.mostrarmenus(bean)
            Me.Dispose()
        Else
            MessageBox.Show("Usuario o Password no Valido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            intentos += 1
            limpiar()
            If intentos = 3 Then
                menuPrincipal.Dispose()
            End If
        End If
    End Sub

    Private Sub usuario_mensaje(ByVal mensaje As String) Handles usuario.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub limpiar()
        txtCod_usuario.Text = ""
        txtPassword.Text = ""
        txtCod_usuario.Focus()
    End Sub
End Class