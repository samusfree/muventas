Imports System.Windows.Forms

Public Class ventaxID
    Dim WithEvents venta As New ClaseVenta
    Dim WithEvents ventaDAO As New VentaDAOImpl
    Dim tipoBusqueda As Integer = Nothing

    Private Sub consultaPorID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = menuPrincipal
        WindowState = 2
    End Sub

    Private Sub venta_confirmacion(contenido As String) Handles venta.confirmacion
        MessageBox.Show(contenido, "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub venta_mensaje(contenido As String) Handles venta.mensaje
        MessageBox.Show(contenido, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgVentas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVentas.CellContentDoubleClick
        Dim cod_venta As Integer = dgVentas.CurrentRow.Cells(10).Value
        Dim cod_item As Integer = dgVentas.CurrentRow.Cells(11).Value
        Dim serie As String = dgVentas.CurrentRow.Cells(4).Value
        actualizarDetalle.definirvalores(cod_item, cod_venta, serie, 1)
        actualizarDetalle.Show()
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtLogin.Text = ""
        txtLogin.Focus()
        tipoBusqueda = Nothing
        dgVentas.DataSource = Nothing
        btnCambio.Visible = False
    End Sub

    Private Sub ventaDAO_mensaje(mensaje As String) Handles ventaDAO.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnCambio_Click(sender As Object, e As EventArgs) Handles btnCambio.Click
        Dim selectedRowCount As Integer = dgVentas.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then
            Dim opcion As Integer = MessageBox.Show("Desea poner los items seleccionados para cambio", "Confirmación",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If opcion = 1 Then
                Dim list As IList(Of Integer) = New List(Of Integer)
                For index As Integer = 0 To selectedRowCount - 1
                    Dim cod_venta As Integer = dgVentas.SelectedRows(index).Cells(10).Value
                    list.Add(cod_venta)
                Next
                Try
                    venta.cambiarventaMasiva(list)
                    mostarInformacion()
                Catch ex As Exception
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Public Sub mostarInformacion()
        If tipoBusqueda = Nothing Then
            dgVentas.DataSource = Nothing
        End If

        If txtLogin.Text.Trim = "" Then
            MessageBox.Show("Ingrese valor para busqueda")
            Exit Sub
        End If

        Select Case tipoBusqueda
            Case 1
                dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(txtLogin.Text.Trim, Nothing, Nothing, Nothing, Nothing, 1)
            Case 2
                dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(Nothing, Nothing, txtLogin.Text, Nothing, Nothing, 1)
            Case 3
                dgVentas.DataSource = ventaDAO.listarVentasPorFiltros(Nothing, txtLogin.Text, Nothing, Nothing, Nothing, 1)
        End Select
        If dgVentas.Rows.Count > 0 Then
            btnCambio.Visible = True
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        tipoBusqueda = 1
        mostarInformacion()
    End Sub

    Private Sub btnSerie_Click(sender As Object, e As EventArgs) Handles btnSerie.Click
        tipoBusqueda = 2
        mostarInformacion()
    End Sub

    Private Sub btnVentasMTCN_Click(sender As Object, e As EventArgs) Handles btnVentasMTCN.Click
        tipoBusqueda = 3
        mostarInformacion()
    End Sub
End Class