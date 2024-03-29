Imports System.Data
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms

Public Class ventas
    Dim parametros As New ParametroDAOImpl
    Dim WithEvents usuario As New ClaseUsuario
    Dim WithEvents itemDAO As ItemDAO = New ItemDAOImpl
    Dim WithEvents venta As New ClaseVenta
    Dim temporal As New VentaTempUtil

    Private Sub ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = menuPrincipal
        RemoveHandler cboTipoItem.SelectedIndexChanged, AddressOf cboTipoItem_SelectedIndexChanged
        'agregando seleccion por defecto
        Dim dtTipoItems As DataTable = parametros.listado(AppConstants.ParametroTipoItem, Nothing)
        Dim rowTipoItems As DataRow = dtTipoItems.NewRow
        rowTipoItems("descripcion") = "Seleccione un Item"
        rowTipoItems("codigo") = "0"
        dtTipoItems.Rows.InsertAt(rowTipoItems, 0)

        cboTipoItem.DataSource = dtTipoItems
        cboTipoItem.DisplayMember = "descripcion"
        cboTipoItem.ValueMember = "codigo"

        txtVendedor.Text = menuPrincipal.cod_usuario
        With cboModalidadPago.Items
            .Add("EFECTIVO")
            If menuPrincipal.usuario.tipousuario.Equals("Administrador") Then
                .Add("DEPOSITO NACIONAL")
                .Add("DEPOSITO EXTRANJERO")
                .Add("VENTAS VENEZUELA")
            End If
            .Add("REPOSICI�N")
            .Add("OTROS")
        End With

        cboNivel.Items.Add("13")
        cboNivel.Items.Add("15")

        cboNivel.SelectedIndex = 1
        cboModalidadPago.SelectedIndex = 0
        cboTipoItem.SelectedIndex = 0

        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE", False)
        limpiar()
        Me.WindowState = 2
        AddHandler cboTipoItem.SelectedIndexChanged, AddressOf cboTipoItem_SelectedIndexChanged

    End Sub


    Private Sub cboModalidadPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModalidadPago.SelectedIndexChanged
        If cboModalidadPago.Text = "DEPOSITO EXTRANJERO" Or cboModalidadPago.Text = "DEPOSITO NACIONAL" Or cboModalidadPago.Text = "VENTAS VENEZUELA" Then
            fechaDeposito.Enabled = True
            txtMTCN.Enabled = True
        Else
            fechaDeposito.Enabled = False
            txtMTCN.Enabled = False
        End If
    End Sub


    Private Sub usuario_mensaje(ByVal mensaje As String) Handles usuario.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If cboTipoItem.SelectedIndex > 0 And cboItem.SelectedIndex > 0 And txtPrecioVenta.Text <> "" And txtSerie.Text.Trim <> "" Then
            Try
                Dim detalle As New BeanDetalleMixto
                detalle.cod_item = cboItem.SelectedValue
                detalle.login = txtIDJugador.Text
                detalle.cod_tipoitem = cboTipoItem.SelectedValue
                detalle.descripcion = cboItem.Text
                detalle.precioventa = txtPrecioVenta.Text
                detalle.cantidad = 1
                detalle.serie = txtSerie.Text.Trim
                detalle.nivel = cboNivel.SelectedItem
                txtSerie.Text = ""
                txtPrecioVenta.Text = ""
                txtSerie.Focus()
                temporal.agregar(detalle)
                dgDetalle.DataSource = temporal.registro
                'sumar la columna monto, es decir totoalixar
                txtTotalPagado.Text = temporal.registro.Compute("Sum(precio)", "")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Por favor ingrese todos los campos del Item a vender", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub venta_confirmacion(ByVal contenido As String) Handles venta.confirmacion
        MessageBox.Show(contenido, "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub venta_mensaje(ByVal contenido As String) Handles venta.mensaje
        MessageBox.Show(contenido, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try 'si hay registros totaliza
            'quiitar un productop
            temporal.quitar(dgDetalle.CurrentRow.Index)
            'volver a listasr
            dgDetalle.DataSource = temporal.registro
            txtTotalPagado.Text =
            temporal.registro.Compute("Sum(precio)", "")
        Catch ex As Exception ' si no hay o erro 

        End Try
    End Sub

    Sub limpiar()
        txtIDJugador.Text = ""
        txtNombreApellido.Text = ""
        txtObservacion.Text = ""
        txtTotalPagado.Text = 0.0
        cboModalidadPago.SelectedIndex = 0
        fechaVenta.Value = Today
        txtIDJugador.Focus()
        txtIDJugador.Enabled = True
        txtMTCN.Text = ""
        dgDetalle.DataSource = temporal.registro
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Public Sub btnLimpiarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarDetalle.Click
        temporal = New VentaTempUtil
        dgDetalle.DataSource = temporal.registro
    End Sub
    Sub limpiardatosdetalle()
        cboItem.SelectedIndex = 0
        cboTipoItem.SelectedIndex = 0
        txtPrecioVenta.Text = ""
        cboNivel.SelectedIndex = 1
        txtSerie.Text = ""
        txtSerie.Focus()
    End Sub

    Private Sub btnGuardarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarVenta.Click
        If txtIDJugador.Text <> "" AndAlso temporal.registro.Rows.Count > 0 Then
            Dim bean As New BeanVenta
            bean.cod_usuario = txtVendedor.Text()
            bean.fecha_venta = fechaVenta.Text
            bean.id_jugador = txtIDJugador.Text.Trim
            bean.modalidad = cboModalidadPago.Text
            bean.nombresapellidos = txtNombreApellido.Text
            bean.observacion = txtObservacion.Text
            If fechaDeposito.Enabled = False Then
                bean.fechadeposito = "null"
                bean.mtcn = "null"
            Else
                bean.fechadeposito = fechaDeposito.Text
                bean.mtcn = txtMTCN.Text
            End If
            venta.grabar(bean, temporal.registro)
            limpiardatosdetalle()
            txtSerie.Text = ""
            temporal = New VentaTempUtil
            limpiar()
        Else
            MessageBox.Show("Falta Llenar Datos o no se agreg� Items",
            "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cboTipoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoItem.SelectedIndexChanged
        Dim dtItems As DataTable = parametros.listado(AppConstants.ParametroItem, cboTipoItem.SelectedValue)
        Dim rowItems As DataRow = dtItems.NewRow
        rowItems("descripcion") = "Seleccione un Item"
        rowItems("codigo") = "0"
        dtItems.Rows.InsertAt(rowItems, 0)

        cboItem.DataSource = dtItems
        With cboItem
            .DisplayMember = "descripcion"
            .ValueMember = "codigo"
        End With

    End Sub

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged

        Try
            Dim data As DataTable = itemDAO.devolverListaItemsHijos(cboItem.SelectedValue)
            If data IsNot Nothing And data.Rows.Count > 0 Then
                Dim detalle As New agregarDetalleItemsVenta
                detalle.definirParametros(cboItem.SelectedValue)
                detalle.setVenta(Me)
                detalle.Show()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub agregarItems(ByVal lista As List(Of BeanDetalleMixto))
        Try
            For Each detalle As BeanDetalleMixto In lista
                temporal.agregar(detalle)
            Next

            dgDetalle.DataSource = temporal.registro
            'sumar la columna monto, es decir totoalixar
            txtTotalPagado.Text = temporal.registro.Compute("Sum(precio)", "")
            limpiardatosdetalle()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub itemDAO_mensaje(mensaje As String) Handles itemDAO.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class