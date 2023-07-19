<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actualizarDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFechaVenta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMTCN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombreApellido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.cboModalidadPago = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFechaDepo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboNivel = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIPO DE ITEM"
        '
        'cboTipoItem
        '
        Me.cboTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoItem.FormattingEnabled = True
        Me.cboTipoItem.Location = New System.Drawing.Point(128, 29)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Size = New System.Drawing.Size(290, 21)
        Me.cboTipoItem.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CODIGO VENTA"
        '
        'txtCodigoVenta
        '
        Me.txtCodigoVenta.Enabled = False
        Me.txtCodigoVenta.Location = New System.Drawing.Point(128, 3)
        Me.txtCodigoVenta.Name = "txtCodigoVenta"
        Me.txtCodigoVenta.Size = New System.Drawing.Size(217, 20)
        Me.txtCodigoVenta.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ITEM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SERIAL"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(128, 86)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(174, 20)
        Me.txtSerie.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PRECIO VENTA"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(128, 112)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(174, 20)
        Me.txtPrecioVenta.TabIndex = 9
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(806, 106)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(155, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(806, 43)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(155, 23)
        Me.btnCambiar.TabIndex = 13
        Me.btnCambiar.Text = "SET PARA CAMBIO"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(437, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "VENDEDOR"
        '
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Location = New System.Drawing.Point(538, 7)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(144, 20)
        Me.txtVendedor.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(437, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ID"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(538, 40)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(247, 20)
        Me.txtLogin.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(437, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "FECHA VENTA"
        '
        'txtFechaVenta
        '
        Me.txtFechaVenta.Enabled = False
        Me.txtFechaVenta.Location = New System.Drawing.Point(538, 74)
        Me.txtFechaVenta.Name = "txtFechaVenta"
        Me.txtFechaVenta.ReadOnly = True
        Me.txtFechaVenta.Size = New System.Drawing.Size(247, 20)
        Me.txtFechaVenta.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(437, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "MODALIDAD"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(437, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "MTCN // OP"
        '
        'txtMTCN
        '
        Me.txtMTCN.Enabled = False
        Me.txtMTCN.Location = New System.Drawing.Point(538, 135)
        Me.txtMTCN.Name = "txtMTCN"
        Me.txtMTCN.Size = New System.Drawing.Size(247, 20)
        Me.txtMTCN.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "NOMBRES APELLIDOS"
        '
        'txtNombreApellido
        '
        Me.txtNombreApellido.Location = New System.Drawing.Point(170, 206)
        Me.txtNombreApellido.Name = "txtNombreApellido"
        Me.txtNombreApellido.Size = New System.Drawing.Size(512, 20)
        Me.txtNombreApellido.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "CANTIDAD"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(128, 143)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(174, 20)
        Me.txtCantidad.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(41, 236)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "OBSERVACION"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(40, 252)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(560, 192)
        Me.txtObservacion.TabIndex = 30
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(806, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(155, 23)
        Me.btnActualizar.TabIndex = 31
        Me.btnActualizar.Text = "ACTUALIZAR DATOS"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'cboItem
        '
        Me.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(128, 58)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(290, 21)
        Me.cboItem.TabIndex = 32
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(806, 74)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(155, 23)
        Me.btnAnular.TabIndex = 33
        Me.btnAnular.Text = "ANULAR VENTA"
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'cboModalidadPago
        '
        Me.cboModalidadPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModalidadPago.FormattingEnabled = True
        Me.cboModalidadPago.Location = New System.Drawing.Point(538, 105)
        Me.cboModalidadPago.Name = "cboModalidadPago"
        Me.cboModalidadPago.Size = New System.Drawing.Size(247, 21)
        Me.cboModalidadPago.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(437, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "FECHA DEPOSITO"
        '
        'txtFechaDepo
        '
        Me.txtFechaDepo.Enabled = False
        Me.txtFechaDepo.Location = New System.Drawing.Point(538, 164)
        Me.txtFechaDepo.Name = "txtFechaDepo"
        Me.txtFechaDepo.ReadOnly = True
        Me.txtFechaDepo.Size = New System.Drawing.Size(247, 20)
        Me.txtFechaDepo.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "NIVEL"
        '
        'cboNivel
        '
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(128, 170)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(121, 21)
        Me.cboNivel.TabIndex = 38
        '
        'actualizarDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 671)
        Me.Controls.Add(Me.cboNivel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtFechaDepo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboModalidadPago)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNombreApellido)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMTCN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFechaVenta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigoVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoItem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "actualizarDetalle"
        Me.Text = "ACTUALIZAR VENTA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFechaVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMTCN As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNombreApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents cboModalidadPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFechaDepo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
End Class
