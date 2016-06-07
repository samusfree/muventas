Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms

Public Class detalleventa
    Dim parametros As New ParametroDAOImpl
    Dim WithEvents item As New claseItem
    Dim WithEvents venta As New claseVenta
    Dim cod_venta As Integer = Nothing
    Dim cod_item As Integer = Nothing
    Dim serie As String = Nothing
    Dim bean As BeanDetalleCompleto = Nothing
    Private Sub detalleventa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCodigoVenta.Enabled = False
        MdiParent = menuPrincipal
        CboTipoItem.DataSource = parametros.listado(AppConstants.ParametroTipoItem, Nothing)
        CboTipoItem.DisplayMember = "descripcion"
        CboTipoItem.ValueMember = "codigo"
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE", False)
        Try
            bean = New BeanDetalleCompleto
            bean = venta.obteneritemxventa(cod_venta, cod_item, serie)
            txtCodigoVenta.Text = bean.cod_venta
            CboTipoItem.SelectedValue = bean.cod_tipoitem
            txtCantidad.Text = bean.cantidad
            txtEstado.Text = bean.estado
            txtFechaVenta.Text = bean.fecha_venta
            cboItem.DataSource = parametros.listado(AppConstants.ParametroItem, CboTipoItem.SelectedValue)
            cboItem.DisplayMember = "descripcion"
            cboItem.ValueMember = "codigo"
            cboItem.SelectedValue = bean.cod_item
            txtLogin.Text = bean.login
            txtModalidad.Text = bean.modalidad
            txtNombreApellido.Text = bean.nombreapellidos
            txtObservacion.Text = bean.observacion
            txtPrecioVenta.Text = bean.precioventa
            txtSerie.Text = bean.serie
            txtVendedor.Text = bean.usuario
            If (bean.mtcn <> Nothing) Then
                txtMTCN.Text = bean.mtcn
                txtMTCN.Enabled = True
            End If

            If bean.fechadepo <> Nothing Then
                txtFechaDepo.Text = bean.fechadepo
            End If
            txtNivel.Text = bean.nivel

        Catch ex As Exception
            Me.Dispose()
        End Try
    End Sub
    Public Sub definirvalores(ByVal cod_item As Integer, ByVal cod_venta As Integer, ByVal serie As String)
        Me.cod_item = cod_item
        Me.cod_venta = cod_venta
        Me.serie = serie
    End Sub

    Private Sub venta_confirmacion(ByVal contenido As String) Handles venta.confirmacion
        MessageBox.Show(contenido, "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub venta_mensaje(ByVal contenido As String) Handles venta.mensaje
        MessageBox.Show(contenido, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub item_mensaje(ByVal mensaje As String) Handles item.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub txtObservacion_TextChanged(sender As Object, e As EventArgs) Handles txtObservacion.TextChanged

    End Sub
End Class