Imports System.Threading
Imports System.Globalization
Imports System.Windows.Forms

Public Class actualizarDetalle
    Dim WithEvents tipoitem As New claseTipoItem
    Dim WithEvents item As New claseItem
    Dim WithEvents venta As New claseVenta
    Dim cod_venta As Integer = Nothing
    Dim cod_item As Integer = Nothing
    Dim serie As String = Nothing
    Dim bean As BeanDetalleCompleto = Nothing

    Private Sub actualizarDetalle_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        ventaxID.borrardgventas()
    End Sub
    Private Sub actualizarDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtCodigoVenta.Enabled = False
            MdiParent = menuPrincipal
            Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE", False)
            With cboModalidadPago.Items
                .Add("EFECTIVO")
                .Add("DEPOSITO NACIONAL")
                .Add("DEPOSITO EXTRANJERO")
                .Add("DEPOSITO EXTRANJERO")
                .Add("VENTAS VENEZUELA")
                .Add("REPOSICIÓN")
                .Add("OTROS")
            End With
            cboNivel.Items.Add("13")
            cboNivel.Items.Add("15")
            bean = New BeanDetalleCompleto
            bean = venta.obteneritemxventa(cod_venta, cod_item, serie)
            txtCodigoVenta.Text = bean.cod_venta
            txtCantidad.Text = bean.cantidad
            If bean.mtcn <> "null" Then
                txtMTCN.Text = bean.mtcn
                txtMTCN.Enabled = True
            Else
                txtMTCN.Text = ""
                txtMTCN.Enabled = False
            End If
            txtFechaVenta.Text = bean.fecha_venta
            'quito el evento
            RemoveHandler cboTipoItem.SelectedIndexChanged, AddressOf cboTipoItem_SelectedIndexChanged
            cboTipoItem.DataSource = tipoitem.listar
            cboTipoItem.DisplayMember = "descripcion"
            cboTipoItem.ValueMember = "cod_tipoitem"
            cboTipoItem.SelectedValue = bean.cod_tipoitem
            cboItem.DataSource = item.listarporTipoItem(cboTipoItem.SelectedValue)
            cboItem.DisplayMember = "descripcion"
            cboItem.ValueMember = "cod_item"
            cboItem.SelectedValue = bean.cod_item
            txtLogin.Text = bean.login
            cboModalidadPago.SelectedItem = bean.modalidad
            txtNombreApellido.Text = bean.nombreapellidos
            txtObservacion.Text = bean.observacion
            txtPrecioVenta.Text = bean.precioventa
            txtSerie.Text = bean.serie
            txtVendedor.Text = bean.usuario
            txtFechaDepo.Text = bean.fechadepo
            cboNivel.SelectedItem = bean.nivel.ToString
            If menuPrincipal.usuario.tipousuario.Equals("Administrador") Then
                btnActualizar.Enabled = True
            Else
                btnActualizar.Enabled = False
            End If


            'enlazo el evento

            AddHandler cboTipoItem.SelectedIndexChanged, AddressOf cboTipoItem_SelectedIndexChanged

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ' Me.Dispose()
        End Try
    End Sub
    Public Sub definirvalores(ByVal cod_item As Integer, ByVal cod_venta As Integer, ByVal serie As String)
        Me.cod_item = cod_item
        Me.cod_venta = cod_venta
        Me.serie = serie
    End Sub

    Private Sub tipoitem_mensaje(ByVal mensaje As String) Handles tipoitem.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        ventaxID.borrardgventas()
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        Dim opcion As Integer = MessageBox.Show("Desea Poner el Item o Set para Cambio", "Confirmación", _
               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If opcion = 1 Then
            Try
                venta.cambiarventa(bean.cod_venta, cod_item, bean.serie)
                MessageBox.Show("Item Para Cambio", "Mensaje de Confirmacion", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
            End Try
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim opcion As Integer = MessageBox.Show("Desea Actualizar los Datos", "Confirmación", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If opcion = 1 Then
                Dim beanupdate As New BeanVentaActualizar
                beanupdate.cod_venta = txtCodigoVenta.Text
                beanupdate.cod_itema = bean.cod_item
                beanupdate.cod_itemn = cboItem.SelectedValue
                beanupdate.login = txtLogin.Text
                beanupdate.seriea = bean.serie
                beanupdate.serien = txtSerie.Text
                beanupdate.observacion = txtObservacion.Text
                beanupdate.cantidad = txtCantidad.Text
                beanupdate.modalidad = cboModalidadPago.Text
                beanupdate.precioventa = txtPrecioVenta.Text
                beanupdate.nombreapellido = txtNombreApellido.Text
                beanupdate.nivel = cboNivel.SelectedItem
                If txtMTCN.Enabled = True Then
                    beanupdate.mtcn = txtMTCN.Text
                Else
                    beanupdate.mtcn = DBNull.Value.ToString
                End If
                venta.actualizarventa(beanupdate)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CboTipoItem_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Dim opcion As Integer = MessageBox.Show("Desea Anular la Venta", "Confirmación", _
              MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If opcion = 1 Then
            Try
                venta.anularventa(bean.cod_venta, cod_item, bean.serie)
                MessageBox.Show("Venta Anulada", "Mensaje de Confirmacion", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
            End Try
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cboModalidadPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModalidadPago.SelectedIndexChanged
        If cboModalidadPago.SelectedItem = "DEPOSITO NACIONAL" Or cboModalidadPago.SelectedItem = "DEPOSITO EXTRANJERO" _
            Or cboModalidadPago.SelectedItem = "VENTAS VENEZUELA" Then
            txtMTCN.Enabled = True
        Else
            txtMTCN.Enabled = False
        End If
    End Sub

    Private Sub cboTipoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoItem.SelectedIndexChanged
        cboItem.DataSource = item.listarporTipoItem(cboTipoItem.SelectedValue)
        With cboItem
            .DisplayMember = "descripcion"
            .ValueMember = "cod_item"
        End With
    End Sub
End Class