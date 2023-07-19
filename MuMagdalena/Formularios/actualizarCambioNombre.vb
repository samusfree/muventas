Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms

Public Class actualizarCambioNombre
    Dim WithEvents cambio_nombre As New clasecambionombre
    Dim cod_cambio As Integer = Nothing
    Dim bean As BeanCambionombre
    Dim tipo As Integer
    Dim parametro As New ParametroDAOImpl

    Private Sub actualizarCambioNombre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MdiParent = menuPrincipal

        If tipo = 2 Then
            Button1.Enabled = False
            Button2.Enabled = False
        Else
            Button1.Enabled = True
            Button2.Enabled = True
        End If


        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-PE", False)

        Try
            cboRaza.Items.Clear()
            cboRaza.DataSource = parametro.listado(AppConstants.ParametroRaza, Nothing)
            cboRaza.DisplayMember = "descripcion"
            cboRaza.ValueMember = "codigo"

            bean = New BeanCambionombre()
            bean = cambio_nombre.obtenerCambioNombre(Me.cod_cambio)
            txtCodigo.Text = bean.cod_cambio
            txtCantResets.Text = bean.cantResets
            txtFecha.Text = bean.fechacambio
            txtIdAntiguo.Text = bean.idAntiguo
            txtIDNuevo.Text = bean.idNuevo
            txtPjAntiguo.Text = bean.nickAntiguo
            txtPJNuevo.Text = bean.nickNuevo
            txtVendedor.Text = bean.cod_usuario
            cboRaza.SelectedValue = bean.cod_raza

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ' Me.Dispose()
        End Try
    End Sub

    Public Sub definirValores(ByVal codcambio As Integer, ByVal tipo As Integer)
        Me.cod_cambio = codcambio
        Me.tipo = tipo
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub cambio_nombre_confirmacion(ByVal mensaje As String) Handles cambio_nombre.confirmacion
        MessageBox.Show(mensaje, "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cambio_nombre_mensaje(ByVal mensaje As String) Handles cambio_nombre.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim opcion As Integer = MessageBox.Show("Desea Actualizar los Datos", "Confirmación", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If opcion = 1 Then
                Dim beanupdate As New BeanCambionombre
                beanupdate.cod_cambio = txtCodigo.Text
                beanupdate.cantResets = txtCantResets.Text
                beanupdate.nickNuevo = txtPJNuevo.Text
                beanupdate.nickAntiguo = txtPjAntiguo.Text
                beanupdate.idNuevo = txtIDNuevo.Text
                beanupdate.idAntiguo = txtIdAntiguo.Text
                beanupdate.cod_raza = cboRaza.SelectedValue
                cambio_nombre.actualizarCambioNombre(beanupdate)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim opcion As Integer = MessageBox.Show("Desea Anular el cambio de Nombre", "Confirmación", _
              MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If opcion = 1 Then
            Try
                cambio_nombre.anularCambioNombre(bean.cod_cambio)
            Catch ex As Exception
            End Try
        Else
            Exit Sub
        End If
    End Sub
End Class