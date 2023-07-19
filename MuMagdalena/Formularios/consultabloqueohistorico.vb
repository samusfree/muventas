Public Class consultabloqueohistorico
    Dim bloqueo As New claseBloqueo



    Private Sub consultabloqueohistorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        Me.WindowState = 2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dgBloqueo.DataSource = bloqueo.listarbloqueohistorico
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dgBloqueo.DataSource = Nothing
    End Sub

    Private Sub btnBLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBLogin.Click
        dgBloqueo.DataSource = bloqueo.busquedabloqueohistorico(txtLogin.Text.Trim)
    End Sub
End Class