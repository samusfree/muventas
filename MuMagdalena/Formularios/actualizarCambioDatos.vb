Imports System.Windows.Forms

Public Class actualizarCambioDatos
    Dim tipoFormulario As Integer = 0
    Dim codCambioDatos As Integer = 0
    Dim cambioDatos As New ClaseCambioDatos

    Private Sub actualizarCambioDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        If tipoFormulario = 2 Then
            btnAnular.Enabled = False
        End If

        With cboModalidadPago.Items
            .Add("EFECTIVO")
            .Add("DEPOSITO NACIONAL")
            .Add("DEPOSITO EXTRANJERO")
            .Add("VENTAS VENEZUELA")
        End With

        Dim bean As BeanCambioDatos = cambioDatos.obtenerCambioDatos(codCambioDatos)

        txtID.Text = bean.cod_cambiodatos
        txtProAnt.Text = bean.proantiguo
        txtProdNuevo.Text = bean.pronuevo
        txtDNIAnt.Text = bean.dniantiguo
        txtDNINue.Text = bean.dninuevo
        txtPagado.Text = bean.pagado
        txtFecha.Value = bean.fecha
        txtObservacion.Text = bean.observacion
        cboModalidadPago.SelectedItem = bean.modalidad
        txtVendedor.Text = bean.cod_usuario
        txtCorreoAnt.Text = bean.correoant
        txtCorreoNuevo.Text = bean.correonuevo

        If bean.modalidad <> "EFECTIVO" Then
            txtMTCN.Text = bean.mtcn
            txtFechaDeposito.Value = bean.fecha_deposito
        End If

    End Sub


    Public Sub setTipoFormulario(ByVal tipo As Integer)
        tipoFormulario = tipo
    End Sub

    Public Sub setCodCambioDatos(ByVal cod_cambioDatos As Integer)
        codCambioDatos = cod_cambioDatos
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        cambioDatos.anularCambioDatos(txtID.Text, txtObservacion.Text)
        MessageBox.Show("Se realizó la anulación", _
                            "Mensaje de Informacion", MessageBoxButtons.OK, _
              MessageBoxIcon.Information)
        btnAnular.Enabled = False
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()

        If tipoFormulario = 1 Then
            consultaCambioDatos.limpiar()
        Else
            consultaCambioDatosHistorico.limpiar()
        End If

    End Sub
End Class