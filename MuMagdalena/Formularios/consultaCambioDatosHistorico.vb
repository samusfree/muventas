Public Class consultaCambioDatosHistorico
    Dim claseCambioDatos As New ClaseCambioDatos
    Dim tipoBusqueda = 2

    Private Sub btnBusquedaMTCN_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusquedaMTCN.Click
        dgCambioDatos.DataSource = Nothing
        If txtLogin.Text.Trim <> "" Then
            dgCambioDatos.DataSource = claseCambioDatos.busqueda(txtLogin.Text, 2, tipoBusqueda)
        End If
    End Sub

    Private Sub btnBusquedaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusquedaID.Click
        dgCambioDatos.DataSource = Nothing
        If txtLogin.Text.Trim <> "" Then
            dgCambioDatos.DataSource = claseCambioDatos.busqueda(txtLogin.Text, 1, tipoBusqueda)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar()
    End Sub

    Private Sub dgCambioDatos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCambioDatos.CellContentDoubleClick
        actualizarCambioDatos.setCodCambioDatos(dgCambioDatos.CurrentRow.Cells(1).Value)
        actualizarCambioDatos.setTipoFormulario(tipoBusqueda)
        actualizarCambioDatos.Show()
    End Sub

    Private Sub consultaCambioDatosHistorico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = menuPrincipal
        Me.WindowState = 2
    End Sub

    Public Sub limpiar()
        dgCambioDatos.DataSource = Nothing
        txtLogin.Text = ""
        txtLogin.Focus()
    End Sub
End Class