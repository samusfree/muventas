Imports System.Windows.Forms

Public Class cambioDatos

    Dim cambioDatos As New ClaseCambioDatos

    Private Sub cambioDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        txtID.Focus()

        With cboModalidadPago.Items
            .Add("EFECTIVO")
            If menuPrincipal.usuario.tipousuario.Equals("Administrador") Then
                .Add("DEPOSITO NACIONAL")
                .Add("DEPOSITO EXTRANJERO")
                .Add("VENTAS VENEZUELA")
            End If
        End With

        cboModalidadPago.SelectedIndex = 0

        txtVendedor.Text = menuPrincipal.cod_usuario
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validacion() = 1 Then
            Exit Sub
        End If

        Try
            Dim bean As New beanCambioDatos
            bean.cod_usuario = txtVendedor.Text
            bean.idcuenta = txtID.Text
            bean.proantiguo = txtProAnt.Text
            bean.pronuevo = txtProdNuevo.Text
            bean.dniantiguo = txtDNIAnt.Text
            bean.dninuevo = txtDNINue.Text
            bean.fecha = txtFecha.Value
            bean.modalidad = cboModalidadPago.Text
            bean.correoant = txtCorreoAnt.Text
            bean.correonuevo = txtCorreoNuevo.Text
            If cboModalidadPago.SelectedIndex > 0 Then
                bean.mtcn = txtMTCN.Text
                bean.fecha_deposito = txtFechaDeposito.Value
            End If
            bean.observacion = txtObservacion.Text

            cambioDatos.guardarDatos(bean)

            limpiar()

            MessageBox.Show("Se guardaron los datos", _
                            "Mensaje de Informacion", MessageBoxButtons.OK, _
              MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show( _
               ex.Message, "Mensaje de Error", MessageBoxButtons.OK, _
               MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub limpiar()
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is System.Windows.Forms.TextBox And ctl.Name <> "txtVendedor" Then
                ctl.Text = ""
            End If
        Next

        cboModalidadPago.SelectedIndex = 0
        txtMTCN.Enabled = False
        txtFechaDeposito.Value = Now
        txtFechaDeposito.Enabled = False
        txtID.Focus()
    End Sub

    Private Function validacion() As Integer

        Dim returnValue As Integer = 0

        errProRequerido.Clear()

        If txtID.Text.Equals("") Then
            errProRequerido.SetError(txtID, "Requerido")
            returnValue = 1
        End If

        If txtProAnt.Text.Equals("") Then
            errProRequerido.SetError(txtProAnt, "Requerido")
            returnValue = 1
        End If

        If txtProdNuevo.Text.Equals("") Then
            errProRequerido.SetError(txtProdNuevo, "Requerido")
            returnValue = 1
        End If

        If txtPagado.Text.Equals("") Then
            errProRequerido.SetError(txtPagado, "Requerido")
            returnValue = 1
        End If

        If cboModalidadPago.SelectedIndex > 0 Then
            If txtMTCN.Text.Equals("") Then
                errProRequerido.SetError(txtMTCN, "Requerido")
                returnValue = 1
            End If
        End If

        If txtCorreoAnt.Text.Equals("") Then
            errProRequerido.SetError(txtCorreoAnt, "Requerido")
            returnValue = 1
        End If

        If txtCorreoNuevo.Text.Equals("") Then
            errProRequerido.SetError(txtCorreoNuevo, "Requerido")
            returnValue = 1
        End If

        If txtObservacion.Text.Equals("") Then
            errProRequerido.SetError(txtObservacion, "Requerido")
            returnValue = 1
        End If

        Return returnValue

    End Function

    Private Sub cboModalidadPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModalidadPago.SelectedIndexChanged
        If cboModalidadPago.Text = "DEPOSITO EXTRANJERO" Or cboModalidadPago.Text = "DEPOSITO NACIONAL" _
           Or cboModalidadPago.Text = "VENTAS VENEZUELA" Then
            txtFechaDeposito.Enabled = True
            txtMTCN.Enabled = True
        Else
            txtFechaDeposito.Enabled = False
            txtMTCN.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
End Class