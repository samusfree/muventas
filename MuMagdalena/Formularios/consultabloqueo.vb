Imports System.Windows.Forms

Public Class consultabloqueo
    Dim WithEvents bloqueo As New claseBloqueo


    Private Sub btnBLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBLogin.Click
        dgBloqueo.DataSource = bloqueo.busquedabloqueo(txtLogin.Text.Trim)
    End Sub

    Private Sub consultabloqueo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        Me.WindowState = 2
        txtLogin.Focus()
    End Sub

    Private Sub btnToos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToos.Click
        dgBloqueo.DataSource = bloqueo.listarbloqueo
    End Sub


    Private Sub bloqueo_mensaje(ByVal mensaje As String) Handles bloqueo.mensaje
        MessageBox.Show(mensaje, _
                   "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtLogin.Text = ""
        txtLogin.Focus()
        dgBloqueo.DataSource = Nothing
    End Sub


    Private Sub dgBloqueo_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBloqueo.CellContentDoubleClick
        Dim cod_bloqueo = dgBloqueo.CurrentRow.Cells(8).Value
        desbloqueocuentas.definivalor(cod_bloqueo)
        desbloqueocuentas.Show()
    End Sub

End Class