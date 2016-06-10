Public Class ventaentrefechas
    Dim WithEvents venta As New ClaseVenta
    Dim WithEvents ventaDAO As New VentaDAOImpl

    Dim tipollamada As Integer = 0
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(Nothing, Nothing, Nothing, dtFecha1.Text, dtFecha2.Text, 1)
        txtTotalVendido.Text = venta.totalventaentrefechasNormal(dtFecha1.Text, dtFecha2.Text).ToString
        tipollamada = 1
    End Sub

    Private Sub ventaentrefechas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        Me.WindowState = 2
    End Sub

    Private Sub btnNorCam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNorCam.Click
        dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(Nothing, Nothing, Nothing, dtFecha1.Text, dtFecha2.Text, 2)
        txtTotalVendido.Text = venta.totalvendientrefechas(dtFecha1.Text, dtFecha2.Text).ToString
        tipollamada = 0
    End Sub

    Private Sub btnhisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhisto.Click
        dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(Nothing, Nothing, Nothing, dtFecha1.Text, dtFecha2.Text, 3)
        txtTotalVendido.Text = venta.totalvendientrefechas(dtFecha1.Text, dtFecha2.Text).ToString
        tipollamada = 0
    End Sub

   
    Private Sub dgVentas_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgVentas.CellContentDoubleClick
        If tipollamada = 1 Then
            Dim cod_venta As Integer = Nothing
            Dim cod_item As Integer = Nothing
            Dim serie As String = Nothing
            cod_venta = dgVentas.CurrentRow.Cells(10).Value
            cod_item = dgVentas.CurrentRow.Cells(11).Value
            serie = dgVentas.CurrentRow.Cells(4).Value
            actualizarDetalle.definirvalores(cod_item, cod_venta, serie)
            actualizarDetalle.Show()
        End If
    End Sub

    Private Sub venta_mensaje(ByVal contenido As String) Handles venta.mensaje
        MsgBox(contenido)
    End Sub

    Private Sub ventaDAO_mensaje(ByVal contenido As String) Handles ventaDAO.mensaje
        MsgBox(contenido)
    End Sub

End Class