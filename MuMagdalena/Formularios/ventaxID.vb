Imports System.Windows.Forms

Public Class ventaxID
    Dim WithEvents venta As New ClaseVenta
    Dim WithEvents ventaDAO As New VentaDAOImpl
    Private Sub consultaPorID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        Me.WindowState = 2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If txtLogin.Text.Trim <> "" Then
            dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(txtLogin.Text.Trim, Nothing, Nothing, Nothing, Nothing, 1)
            End If 
    End Sub

    Private Sub venta_confirmacion(ByVal contenido As String) Handles venta.confirmacion
        MessageBox.Show(contenido, "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub venta_mensaje(ByVal contenido As String) Handles venta.mensaje
        MessageBox.Show(contenido, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub



    Private Sub dgVentas_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgVentas.CellContentDoubleClick
        Dim cod_venta As Integer = Nothing
        Dim cod_item As Integer = Nothing
        Dim serie As String = Nothing
        cod_venta = dgVentas.CurrentRow.Cells(10).Value
        cod_item = dgVentas.CurrentRow.Cells(11).Value
        serie = dgVentas.CurrentRow.Cells(4).Value
        actualizarDetalle.definirvalores(cod_item, cod_venta, serie)
        actualizarDetalle.Show()
    End Sub
    Public Sub borrardgventas()
        dgVentas.DataSource = Nothing
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtLogin.Text = ""
        txtLogin.Focus()
        dgVentas.DataSource = Nothing
    End Sub

    Private Sub btnSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSerie.Click
        If txtLogin.Text.Trim <> "" Then
            dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(Nothing, Nothing, txtLogin.Text, Nothing, Nothing, 1)
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentasMTCN.Click
        If txtLogin.Text.Trim <> "" Then
            dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(Nothing, txtLogin.Text, Nothing, Nothing, Nothing, 1)
        End If
    End Sub

    Private Sub ventaDAO_mensaje(mensaje As String) Handles ventaDAO.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class