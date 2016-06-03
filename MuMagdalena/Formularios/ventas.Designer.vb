<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventas
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
        Me.btnGuardarVenta = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtMTCN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.fechaDeposito = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalPagado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboModalidadPago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDJugador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboNivel = New System.Windows.Forms.ComboBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
        Me.cboTipoItem = New System.Windows.Forms.ComboBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnLimpiarDetalle = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardarVenta
        '
        Me.btnGuardarVenta.Location = New System.Drawing.Point(829, 12)
        Me.btnGuardarVenta.Name = "btnGuardarVenta"
        Me.btnGuardarVenta.Size = New System.Drawing.Size(152, 46)
        Me.btnGuardarVenta.TabIndex = 18
        Me.btnGuardarVenta.Text = "GRABAR VENTA"
        Me.btnGuardarVenta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVendedor)
        Me.GroupBox1.Controls.Add(Me.txtMTCN)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.fechaDeposito)
        Me.GroupBox1.Controls.Add(Me.txtTotalPagado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNombreApellido)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboModalidadPago)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.fechaVenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIDJugador)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 285)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE VENTA"
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(209, 26)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(184, 20)
        Me.txtVendedor.TabIndex = 36
        '
        'txtMTCN
        '
        Me.txtMTCN.Location = New System.Drawing.Point(599, 48)
        Me.txtMTCN.Name = "txtMTCN"
        Me.txtMTCN.Size = New System.Drawing.Size(143, 20)
        Me.txtMTCN.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(456, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "MTCN"
        '
        'fechaDeposito
        '
        Me.fechaDeposito.Enabled = False
        Me.fechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDeposito.Location = New System.Drawing.Point(599, 22)
        Me.fechaDeposito.Name = "fechaDeposito"
        Me.fechaDeposito.Size = New System.Drawing.Size(143, 20)
        Me.fechaDeposito.TabIndex = 33
        '
        'txtTotalPagado
        '
        Me.txtTotalPagado.Enabled = False
        Me.txtTotalPagado.Location = New System.Drawing.Point(599, 80)
        Me.txtTotalPagado.Name = "txtTotalPagado"
        Me.txtTotalPagado.Size = New System.Drawing.Size(143, 20)
        Me.txtTotalPagado.TabIndex = 32
        Me.txtTotalPagado.Text = "0"
        Me.txtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(456, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "TOTAL PAGADO"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(209, 183)
        Me.txtObservacion.MaxLength = 500
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservacion.Size = New System.Drawing.Size(533, 89)
        Me.txtObservacion.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "OBSERVACIÓN"
        '
        'txtNombreApellido
        '
        Me.txtNombreApellido.Location = New System.Drawing.Point(209, 150)
        Me.txtNombreApellido.Name = "txtNombreApellido"
        Me.txtNombreApellido.Size = New System.Drawing.Size(533, 20)
        Me.txtNombreApellido.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "NOMBRES Y APELLIDOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(456, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "FECHA DEPOSITO"
        '
        'cboModalidadPago
        '
        Me.cboModalidadPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModalidadPago.FormattingEnabled = True
        Me.cboModalidadPago.Location = New System.Drawing.Point(209, 119)
        Me.cboModalidadPago.Name = "cboModalidadPago"
        Me.cboModalidadPago.Size = New System.Drawing.Size(184, 21)
        Me.cboModalidadPago.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "MODALIDAD DE PAGO"
        '
        'fechaVenta
        '
        Me.fechaVenta.CustomFormat = "03/10/03"
        Me.fechaVenta.Enabled = False
        Me.fechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaVenta.Location = New System.Drawing.Point(209, 84)
        Me.fechaVenta.Name = "fechaVenta"
        Me.fechaVenta.Size = New System.Drawing.Size(184, 20)
        Me.fechaVenta.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "FECHA VENTA"
        '
        'txtIDJugador
        '
        Me.txtIDJugador.Location = New System.Drawing.Point(209, 58)
        Me.txtIDJugador.Name = "txtIDJugador"
        Me.txtIDJugador.Size = New System.Drawing.Size(184, 20)
        Me.txtIDJugador.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "VENDEDOR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cboNivel)
        Me.GroupBox2.Controls.Add(Me.txtSerie)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cboItem)
        Me.GroupBox2.Controls.Add(Me.dgDetalle)
        Me.GroupBox2.Controls.Add(Me.cboTipoItem)
        Me.GroupBox2.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 303)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(829, 336)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLE VENTA"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(508, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "NIVEL"
        '
        'cboNivel
        '
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(584, 63)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(115, 21)
        Me.cboNivel.TabIndex = 16
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(137, 69)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(120, 20)
        Me.txtSerie.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(61, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "SERIE"
        '
        'cboItem
        '
        Me.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(442, 19)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(257, 21)
        Me.cboItem.TabIndex = 9
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Location = New System.Drawing.Point(12, 102)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.ReadOnly = True
        Me.dgDetalle.Size = New System.Drawing.Size(811, 219)
        Me.dgDetalle.TabIndex = 8
        '
        'cboTipoItem
        '
        Me.cboTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoItem.FormattingEnabled = True
        Me.cboTipoItem.Location = New System.Drawing.Point(137, 24)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Size = New System.Drawing.Size(193, 21)
        Me.cboTipoItem.TabIndex = 6
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(387, 66)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(95, 20)
        Me.txtPrecioVenta.TabIndex = 5
        Me.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(276, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "PRECIO VENTA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(357, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ITEM/SET"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "TIPO ITEM"
        '
        'btnLimpiarDetalle
        '
        Me.btnLimpiarDetalle.Location = New System.Drawing.Point(849, 434)
        Me.btnLimpiarDetalle.Name = "btnLimpiarDetalle"
        Me.btnLimpiarDetalle.Size = New System.Drawing.Size(123, 48)
        Me.btnLimpiarDetalle.TabIndex = 11
        Me.btnLimpiarDetalle.Text = "LIMPIAR TABLA"
        Me.btnLimpiarDetalle.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(849, 374)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(123, 41)
        Me.btnQuitar.TabIndex = 10
        Me.btnQuitar.Text = "QUITAR"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(849, 311)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(123, 45)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "AGREGAR "
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(829, 92)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(152, 60)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "LIMPIAR CABECERA"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 636)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardarVenta)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnLimpiarDetalle)
        Me.Name = "ventas"
        Me.Text = "VENTA DE ITEMS / SETS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardarVenta As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fechaDeposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTotalPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNombreApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboModalidadPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fechaVenta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIDJugador As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiarDetalle As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtMTCN As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
End Class
