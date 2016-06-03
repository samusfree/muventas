Imports System.Windows.Forms

Public Class mantenimientoUsuarios
    Dim WithEvents usuario As New claseUsuario

    Private Sub mantenimientoUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = menuPrincipal
        dgUsuarios.DataSource = usuario.listarnicks
        With cboTipousuario.Items
            .Add("Administrador")
            .Add("Vendendor")
        End With
        cboTipousuario.SelectedIndex = 0
    End Sub

    Private Sub dgUsuarios_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsuarios.CellClick
        Try
            txtNick.Text = dgUsuarios.CurrentRow.Cells(0).Value
            cboTipousuario.SelectedItem = dgUsuarios.CurrentRow.Cells(1).Value
            txtPassword.Focus()
            txtNick.Enabled = False
            btnAgregar.Enabled = False
            btnModificar.Enabled = True
            btnCamClave.Enabled = True
        Catch ex As Exception
            txtNick.Enabled = True
            btnAgregar.Enabled = True
            btnModificar.Enabled = False
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim pass As String = InputBox("Confirmar la Clave")
        If pass.Equals(txtPassword.Text.Trim) AndAlso txtPassword.Text <> "" AndAlso txtNick.Text <> "" Then
            If txtNick.Text = "" Then
                Exit Sub
            End If
            usuario.agregarUsuario(txtNick.Text.Trim, txtPassword.Text.Trim, cboTipousuario.Text)
            actulizardata()
            limpiar()
        Else
            MessageBox.Show("Verifique los datos", "Mensaje de Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub
    Public Sub actulizardata()
        dgUsuarios.DataSource = usuario.listarnicks
    End Sub

    Private Sub usuario_mensaje(ByVal mensaje As String) Handles usuario.mensaje
        MessageBox.Show(mensaje, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub limpiar()
        txtNick.Text = ""
        txtPassword.Text = ""
        txtPassword.Focus()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim confirmacion As Integer = MessageBox.Show("Desea Actualizar los Datos", "Confirmación", _
        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If confirmacion = 1 Then
            usuario.actualizar(txtNick.Text.Trim, cboTipousuario.Text)
            actulizardata()
            limpiar()
            btnModificar.Enabled = False
            btnCamClave.Enabled = False
            btnAgregar.Enabled = True
            MessageBox.Show("Se actualizaron los datos", "Mensaje de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNick.Enabled = True
            txtNick.Focus()
        Else
            MessageBox.Show("Verifique los datos", "Mensaje de Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
        btnModificar.Enabled = False
        btnCamClave.Enabled = False
        btnAgregar.Enabled = True
        txtNick.Enabled = True
        txtNick.Focus()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCamClave.Click
        Dim confirmacion As String = InputBox("Ingrese Nuevamente la Contraseña")
        If confirmacion.Equals(txtPassword.Text.Trim) AndAlso txtPassword.Text <> "" Then
            usuario.modificarClave(txtNick.Text.Trim, txtPassword.Text)
            actulizardata()
            limpiar()
            btnModificar.Enabled = False
            btnCamClave.Enabled = False
            btnAgregar.Enabled = True
            MessageBox.Show("Se Cambio el Password", "Mensaje de Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNick.Enabled = True
            txtNick.Focus()
        Else
            MessageBox.Show("Verifique los datos", "Mensaje de Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
    End Sub
End Class