<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambioDatos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtMTCN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFechaDeposito = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboModalidadPago = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtPagado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtProdNuevo = New System.Windows.Forms.TextBox()
        Me.txtProAnt = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtDNINue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDNIAnt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.errProRequerido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCorreoNuevo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCorreoAnt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.errProRequerido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMTCN
        '
        Me.txtMTCN.Location = New System.Drawing.Point(114, 309)
        Me.txtMTCN.Name = "txtMTCN"
        Me.txtMTCN.Size = New System.Drawing.Size(109, 20)
        Me.txtMTCN.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 316)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "MTCN"
        '
        'txtFechaDeposito
        '
        Me.txtFechaDeposito.Enabled = False
        Me.txtFechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaDeposito.Location = New System.Drawing.Point(456, 315)
        Me.txtFechaDeposito.Name = "txtFechaDeposito"
        Me.txtFechaDeposito.Size = New System.Drawing.Size(109, 20)
        Me.txtFechaDeposito.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(323, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "FECHA DEPOSITO"
        '
        'cboModalidadPago
        '
        Me.cboModalidadPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModalidadPago.FormattingEnabled = True
        Me.cboModalidadPago.Location = New System.Drawing.Point(456, 267)
        Me.cboModalidadPago.Name = "cboModalidadPago"
        Me.cboModalidadPago.Size = New System.Drawing.Size(144, 21)
        Me.cboModalidadPago.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(323, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "MODALIDAD DE PAGO"
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(109, 12)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(140, 20)
        Me.txtVendedor.TabIndex = 62
        '
        'txtPagado
        '
        Me.txtPagado.Location = New System.Drawing.Point(114, 263)
        Me.txtPagado.Name = "txtPagado"
        Me.txtPagado.Size = New System.Drawing.Size(140, 20)
        Me.txtPagado.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "PAGADO"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(304, 10)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(200, 20)
        Me.txtFecha.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "FECHA"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(653, 51)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 57
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(653, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 56
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtProdNuevo
        '
        Me.txtProdNuevo.Location = New System.Drawing.Point(322, 99)
        Me.txtProdNuevo.Name = "txtProdNuevo"
        Me.txtProdNuevo.Size = New System.Drawing.Size(274, 20)
        Me.txtProdNuevo.TabIndex = 53
        '
        'txtProAnt
        '
        Me.txtProAnt.Location = New System.Drawing.Point(23, 99)
        Me.txtProAnt.Name = "txtProAnt"
        Me.txtProAnt.Size = New System.Drawing.Size(274, 20)
        Me.txtProAnt.TabIndex = 52
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(109, 48)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(140, 20)
        Me.txtID.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "NUEVO PROPIETARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "ANTIGUO PROPIETARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "VENDENDOR"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(28, 364)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(662, 83)
        Me.txtObservacion.TabIndex = 72
        '
        'txtDNINue
        '
        Me.txtDNINue.Location = New System.Drawing.Point(322, 168)
        Me.txtDNINue.Name = "txtDNINue"
        Me.txtDNINue.Size = New System.Drawing.Size(274, 20)
        Me.txtDNINue.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "DNI NUEVO (opcional)"
        '
        'txtDNIAnt
        '
        Me.txtDNIAnt.Location = New System.Drawing.Point(23, 168)
        Me.txtDNIAnt.Name = "txtDNIAnt"
        Me.txtDNIAnt.Size = New System.Drawing.Size(274, 20)
        Me.txtDNIAnt.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "DNI ANTIGUO (opcional)"
        '
        'errProRequerido
        '
        Me.errProRequerido.ContainerControl = Me
        '
        'txtCorreoNuevo
        '
        Me.txtCorreoNuevo.Location = New System.Drawing.Point(327, 228)
        Me.txtCorreoNuevo.Name = "txtCorreoNuevo"
        Me.txtCorreoNuevo.Size = New System.Drawing.Size(274, 20)
        Me.txtCorreoNuevo.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "CORREO NUEVO"
        '
        'txtCorreoAnt
        '
        Me.txtCorreoAnt.Location = New System.Drawing.Point(28, 228)
        Me.txtCorreoAnt.Name = "txtCorreoAnt"
        Me.txtCorreoAnt.Size = New System.Drawing.Size(274, 20)
        Me.txtCorreoAnt.TabIndex = 78
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "CORREO ANTIGUO"
        '
        'cambioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 457)
        Me.Controls.Add(Me.txtCorreoNuevo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCorreoAnt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDNINue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDNIAnt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.txtMTCN)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtFechaDeposito)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboModalidadPago)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.txtPagado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtProdNuevo)
        Me.Controls.Add(Me.txtProAnt)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cambioDatos"
        Me.Text = "cambioDatos"
        CType(Me.errProRequerido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMTCN As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFechaDeposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboModalidadPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtProdNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtProAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents txtDNINue As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDNIAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents errProRequerido As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCorreoNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCorreoAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
