Imports System.Windows.Forms

Public Class cambiodeNombre
    Dim WithEvents cnombre As New clasecambionombre
    Dim usuario As New ClaseUsuario
    Dim parametro As New ParametroDAOImpl


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtIdAntiguo.Text <> "" AndAlso txtIDNuevo.Text <> "" AndAlso txtNickAntiguo.Text <> "" _
        AndAlso txtNickNuevo.Text <> "" AndAlso txtCantResets.Text <> "" AndAlso txtPagado.Text <> "" Then
            Try
                Dim bean As New BeanCambionombre
                bean.cod_usuario = txtVendedor.Text
                bean.idAntiguo = txtIdAntiguo.Text
                bean.idNuevo = txtIDNuevo.Text
                bean.nickAntiguo = txtNickAntiguo.Text
                bean.nickNuevo = txtNickNuevo.Text
                bean.raza = cboRaza.Text
                bean.cantResets = txtCantResets.Text
                bean.fechacambio = txtFecha.Text
                bean.pagado = txtPagado.Text
                bean.cod_raza = cboRaza.SelectedValue
                bean.modalidad = cboModalidadPago.Text

                If fechaDeposito.Enabled = False Then
                    bean.fechadeposito = "null"
                    bean.mtcn = "null"
                Else
                    bean.fechadeposito = fechaDeposito.Text
                    bean.mtcn = txtMTCN.Text
                End If

                cnombre.agregarcambionombre(bean)
                limpiar()
            Catch ex As Exception
                MessageBox.Show( _
                ex.Message, "Mensaje de Error", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show( _
                    "Falta llenar datos", "Mensaje de Error", MessageBoxButtons.OK, _
                    MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtCantResets.Text = ""
        txtIdAntiguo.Text = ""
        txtIDNuevo.Text = ""
        txtNickAntiguo.Text = ""
        txtNickNuevo.Text = ""
        cboRaza.SelectedIndex = 0
        cboModalidadPago.SelectedIndex = 0
        txtMTCN.Text = ""
        txtMTCN.Enabled = False
        fechaDeposito.Enabled = False
        fechaDeposito.Value = Now
        txtPagado.Text = ""
        txtIdAntiguo.Focus()
    End Sub


    Private Sub cnombre_confirmacion(ByVal mensaje As String) Handles cnombre.confirmacion
        MessageBox.Show( _
        mensaje, "Mensaje de Confirmacion", MessageBoxButtons.OK, _
        MessageBoxIcon.Information)
    End Sub

    Private Sub cnombre_mensaje(ByVal mensaje As String) Handles cnombre.mensaje
        MessageBox.Show( _
                mensaje, "Mensaje de Error", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
    End Sub

    Private Sub cambiodeNombre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
        txtIdAntiguo.Focus()
        cboRaza.Items.Clear()
        cboRaza.DataSource = parametro.listado(AppConstants.ParametroRaza, Nothing)
        cboRaza.DisplayMember = "descripcion"
        cboRaza.ValueMember = "codigo"

        With cboModalidadPago.Items
            .Add("EFECTIVO")
            If menuPrincipal.usuario.tipousuario.Equals("Administrador") Then
                .Add("DEPOSITO NACIONAL")
                .Add("DEPOSITO EXTRANJERO")
                .Add("VENTAS VENEZUELA")
            End If
        End With

        cboModalidadPago.SelectedIndex = 0

        cboRaza.SelectedIndex = 0

        txtVendedor.Text = menuPrincipal.cod_usuario
    End Sub

    Private Sub cboModalidadPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModalidadPago.SelectedIndexChanged
        If cboModalidadPago.Text = "DEPOSITO EXTRANJERO" Or cboModalidadPago.Text = "DEPOSITO NACIONAL" _
             Or cboModalidadPago.Text = "VENTAS VENEZUELA" Then
            fechaDeposito.Enabled = True
            txtMTCN.Enabled = True
        Else
            fechaDeposito.Enabled = False
            txtMTCN.Enabled = False
        End If
    End Sub
End Class