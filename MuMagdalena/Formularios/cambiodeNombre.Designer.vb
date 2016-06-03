<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambiodeNombre
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCantResets = New System.Windows.Forms.TextBox()
        Me.txtNickNuevo = New System.Windows.Forms.TextBox()
        Me.txtIDNuevo = New System.Windows.Forms.TextBox()
        Me.txtNickAntiguo = New System.Windows.Forms.TextBox()
        Me.txtIdAntiguo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboRaza = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPagado = New System.Windows.Forms.TextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.cboModalidadPago = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fechaDeposito = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMTCN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(517, 59)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 31
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(517, 23)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCantResets
        '
        Me.txtCantResets.Location = New System.Drawing.Point(345, 127)
        Me.txtCantResets.Name = "txtCantResets"
        Me.txtCantResets.Size = New System.Drawing.Size(82, 20)
        Me.txtCantResets.TabIndex = 29
        '
        'txtNickNuevo
        '
        Me.txtNickNuevo.Location = New System.Drawing.Point(336, 88)
        Me.txtNickNuevo.Name = "txtNickNuevo"
        Me.txtNickNuevo.Size = New System.Drawing.Size(140, 20)
        Me.txtNickNuevo.TabIndex = 27
        '
        'txtIDNuevo
        '
        Me.txtIDNuevo.Location = New System.Drawing.Point(336, 57)
        Me.txtIDNuevo.Name = "txtIDNuevo"
        Me.txtIDNuevo.Size = New System.Drawing.Size(140, 20)
        Me.txtIDNuevo.TabIndex = 25
        '
        'txtNickAntiguo
        '
        Me.txtNickAntiguo.Location = New System.Drawing.Point(101, 95)
        Me.txtNickAntiguo.Name = "txtNickAntiguo"
        Me.txtNickAntiguo.Size = New System.Drawing.Size(140, 20)
        Me.txtNickAntiguo.TabIndex = 26
        '
        'txtIdAntiguo
        '
        Me.txtIdAntiguo.Location = New System.Drawing.Point(101, 56)
        Me.txtIdAntiguo.Name = "txtIdAntiguo"
        Me.txtIdAntiguo.Size = New System.Drawing.Size(140, 20)
        Me.txtIdAntiguo.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "RAZA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(247, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "PJ  NUEVO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "CANT. RESETS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ID NUEVO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "PJ  ANTIGUO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID ANTIGUO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "VENDENDOR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(247, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "FECHA"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(295, 17)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(200, 20)
        Me.txtFecha.TabIndex = 33
        '
        'cboRaza
        '
        Me.cboRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRaza.FormattingEnabled = True
        Me.cboRaza.Location = New System.Drawing.Point(101, 127)
        Me.cboRaza.Name = "cboRaza"
        Me.cboRaza.Size = New System.Drawing.Size(140, 21)
        Me.cboRaza.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "PAGADO"
        '
        'txtPagado
        '
        Me.txtPagado.Location = New System.Drawing.Point(101, 163)
        Me.txtPagado.Name = "txtPagado"
        Me.txtPagado.Size = New System.Drawing.Size(140, 20)
        Me.txtPagado.TabIndex = 35
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(101, 20)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(140, 20)
        Me.txtVendedor.TabIndex = 36
        '
        'cboModalidadPago
        '
        Me.cboModalidadPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModalidadPago.FormattingEnabled = True
        Me.cboModalidadPago.Location = New System.Drawing.Point(138, 198)
        Me.cboModalidadPago.Name = "cboModalidadPago"
        Me.cboModalidadPago.Size = New System.Drawing.Size(144, 21)
        Me.cboModalidadPago.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "MODALIDAD DE PAGO"
        '
        'fechaDeposito
        '
        Me.fechaDeposito.Enabled = False
        Me.fechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaDeposito.Location = New System.Drawing.Point(155, 235)
        Me.fechaDeposito.Name = "fechaDeposito"
        Me.fechaDeposito.Size = New System.Drawing.Size(109, 20)
        Me.fechaDeposito.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "FECHA DEPOSITO"
        '
        'txtMTCN
        '
        Me.txtMTCN.Location = New System.Drawing.Point(345, 153)
        Me.txtMTCN.Name = "txtMTCN"
        Me.txtMTCN.Size = New System.Drawing.Size(109, 20)
        Me.txtMTCN.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(251, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "MTCN"
        '
        'cambiodeNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 270)
        Me.Controls.Add(Me.txtMTCN)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.fechaDeposito)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboModalidadPago)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.txtPagado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboRaza)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCantResets)
        Me.Controls.Add(Me.txtNickNuevo)
        Me.Controls.Add(Me.txtIDNuevo)
        Me.Controls.Add(Me.txtNickAntiguo)
        Me.Controls.Add(Me.txtIdAntiguo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cambiodeNombre"
        Me.Text = "CAMBIO DE NOMBRE "
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtCantResets As System.Windows.Forms.TextBox
    Friend WithEvents txtNickNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtIDNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtNickAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents txtIdAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboRaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPagado As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents cboModalidadPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fechaDeposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMTCN As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
