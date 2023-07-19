<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalleventa
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
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombreApellido = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtModalidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFechaVenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboTipoItem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMTCN = New System.Windows.Forms.TextBox()
        Me.txtFechaDepo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboItem
        '
        Me.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(105, 61)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(370, 21)
        Me.cboItem.TabIndex = 61
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(39, 235)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ReadOnly = True
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(785, 226)
        Me.txtObservacion.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(195, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "OBSERVACION"
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(105, 146)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(203, 20)
        Me.txtCantidad.TabIndex = 57
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "CANTIDAD"
        '
        'txtNombreApellido
        '
        Me.txtNombreApellido.Enabled = False
        Me.txtNombreApellido.Location = New System.Drawing.Point(141, 172)
        Me.txtNombreApellido.Name = "txtNombreApellido"
        Me.txtNombreApellido.Size = New System.Drawing.Size(334, 20)
        Me.txtNombreApellido.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "NOMBRES APELLIDOS"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(623, 143)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(249, 20)
        Me.txtEstado.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(522, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "ESTADO"
        '
        'txtModalidad
        '
        Me.txtModalidad.Enabled = False
        Me.txtModalidad.Location = New System.Drawing.Point(623, 108)
        Me.txtModalidad.Name = "txtModalidad"
        Me.txtModalidad.Size = New System.Drawing.Size(249, 20)
        Me.txtModalidad.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(522, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "MODALIDAD"
        '
        'txtFechaVenta
        '
        Me.txtFechaVenta.Enabled = False
        Me.txtFechaVenta.Location = New System.Drawing.Point(623, 75)
        Me.txtFechaVenta.Name = "txtFechaVenta"
        Me.txtFechaVenta.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaVenta.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(522, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "FECHA VENTA"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(623, 41)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(249, 20)
        Me.txtLogin.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(522, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "ID"
        '
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Location = New System.Drawing.Point(623, 8)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(249, 20)
        Me.txtVendedor.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(522, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "VENDEDOR"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Enabled = False
        Me.txtPrecioVenta.Location = New System.Drawing.Point(105, 115)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(203, 20)
        Me.txtPrecioVenta.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "PRECIO VENTA"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(105, 89)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(203, 20)
        Me.txtSerie.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "SERIAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "ITEM"
        '
        'txtCodigoVenta
        '
        Me.txtCodigoVenta.Enabled = False
        Me.txtCodigoVenta.Location = New System.Drawing.Point(105, 6)
        Me.txtCodigoVenta.Name = "txtCodigoVenta"
        Me.txtCodigoVenta.Size = New System.Drawing.Size(370, 20)
        Me.txtCodigoVenta.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "CODIGO VENTA"
        '
        'CboTipoItem
        '
        Me.CboTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoItem.FormattingEnabled = True
        Me.CboTipoItem.Location = New System.Drawing.Point(105, 32)
        Me.CboTipoItem.Name = "CboTipoItem"
        Me.CboTipoItem.Size = New System.Drawing.Size(370, 21)
        Me.CboTipoItem.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "TIPO DE ITEM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(525, 185)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "MTCN/OP"
        '
        'txtMTCN
        '
        Me.txtMTCN.Enabled = False
        Me.txtMTCN.Location = New System.Drawing.Point(623, 177)
        Me.txtMTCN.Name = "txtMTCN"
        Me.txtMTCN.Size = New System.Drawing.Size(249, 20)
        Me.txtMTCN.TabIndex = 63
        '
        'txtFechaDepo
        '
        Me.txtFechaDepo.Location = New System.Drawing.Point(623, 208)
        Me.txtFechaDepo.Name = "txtFechaDepo"
        Me.txtFechaDepo.ReadOnly = True
        Me.txtFechaDepo.Size = New System.Drawing.Size(249, 20)
        Me.txtFechaDepo.TabIndex = 65
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(525, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "FECHA DEPOSITO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 210)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "NIVEL"
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(59, 207)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(100, 20)
        Me.txtNivel.TabIndex = 67
        '
        'detalleventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.txtNivel)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtFechaDepo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtMTCN)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNombreApellido)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtModalidad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFechaVenta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigoVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboTipoItem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "detalleventa"
        Me.Text = "DETALLE DE VENTA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNombreApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtModalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFechaVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMTCN As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaDepo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNivel As System.Windows.Forms.TextBox
End Class
