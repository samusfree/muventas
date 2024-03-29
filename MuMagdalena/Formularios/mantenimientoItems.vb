Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms

Public Class mantenimientoItems
    Dim parametros As New ParametroDAOImpl
    Dim item As New claseItem
    Private Sub mantenimientoItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = menuPrincipal
        cboTipoItem.DataSource = parametros.listado(AppConstants.ParametroTipoItem, Nothing)
        cboTipoItem.DisplayMember = "descripcion"
        cboTipoItem.ValueMember = "codigo"
        actualizar()
        limpiar()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE", False)
        AddHandler cboTipoItem.SelectedIndexChanged,
        AddressOf cboTipoItem_SelectedIndexChanged
        Me.WindowState = 2
    End Sub
    Sub actualizar()
        dgItems.DataSource = item.listarporTipoItem(cboTipoItem.SelectedValue)
    End Sub

    Sub limpiar()
        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        txtDescripcion.Focus()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim miitem As New BeanItems
            miitem.cod_tipoitem = cboTipoItem.SelectedValue
            miitem.descripcion = txtDescripcion.Text
            miitem.precio = Double.Parse(txtPrecio.Text)
            item.agregarItem(miitem)
            limpiar()
            actualizar()
            MessageBox.Show("Se Agrego un nuevo ITEM", _
                   "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, _
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItems.CellClick
        Try
            txtCodigo.Text = dgItems.CurrentRow.Cells(0).Value
            cboTipoItem.SelectedValue = dgItems.CurrentRow.Cells(2).Value
            txtDescripcion.Text = dgItems.CurrentRow.Cells(1).Value
            txtPrecio.Text = dgItems.CurrentRow.Cells(4).Value
            btnAgregar.Enabled = False
            btnModificar.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim miitem As New BeanItems
            miitem.cod_item = txtCodigo.Text
            miitem.cod_tipoitem = cboTipoItem.SelectedValue
            miitem.descripcion = txtDescripcion.Text
            miitem.precio = Double.Parse(txtPrecio.Text)
            item.modificaritem(miitem)
            limpiar()
            actualizar()
            MessageBox.Show("Item Actualizado", _
                  "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, _
                               "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub cboTipoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizar()
    End Sub
End Class