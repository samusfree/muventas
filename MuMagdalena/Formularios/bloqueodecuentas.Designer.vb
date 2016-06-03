<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bloqueodecuentas
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
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSancion = New System.Windows.Forms.TextBox()
        Me.txtRazonBloqueo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSancion = New System.Windows.Forms.ComboBox()
        Me.txtPersonaje = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.dtFecha_Bloqueo = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(547, 32)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 35)
        Me.btnGrabar.TabIndex = 18
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(547, 78)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 32)
        Me.btnLimpiar.TabIndex = 19
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVendedor)
        Me.GroupBox1.Controls.Add(Me.txtSancion)
        Me.GroupBox1.Controls.Add(Me.txtRazonBloqueo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboSancion)
        Me.GroupBox1.Controls.Add(Me.txtPersonaje)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Controls.Add(Me.dtFecha_Bloqueo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 338)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS "
        '
        'txtSancion
        '
        Me.txtSancion.Enabled = False
        Me.txtSancion.Location = New System.Drawing.Point(140, 172)
        Me.txtSancion.Name = "txtSancion"
        Me.txtSancion.Size = New System.Drawing.Size(353, 20)
        Me.txtSancion.TabIndex = 31
        '
        'txtRazonBloqueo
        '
        Me.txtRazonBloqueo.Location = New System.Drawing.Point(140, 200)
        Me.txtRazonBloqueo.Multiline = True
        Me.txtRazonBloqueo.Name = "txtRazonBloqueo"
        Me.txtRazonBloqueo.Size = New System.Drawing.Size(353, 52)
        Me.txtRazonBloqueo.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "RAZON BLOQUEO"
        '
        'cboSancion
        '
        Me.cboSancion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSancion.FormattingEnabled = True
        Me.cboSancion.Location = New System.Drawing.Point(140, 145)
        Me.cboSancion.Name = "cboSancion"
        Me.cboSancion.Size = New System.Drawing.Size(353, 21)
        Me.cboSancion.TabIndex = 27
        '
        'txtPersonaje
        '
        Me.txtPersonaje.Location = New System.Drawing.Point(140, 115)
        Me.txtPersonaje.Name = "txtPersonaje"
        Me.txtPersonaje.Size = New System.Drawing.Size(165, 20)
        Me.txtPersonaje.TabIndex = 26
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(140, 83)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(165, 20)
        Me.txtLogin.TabIndex = 25
        '
        'dtFecha_Bloqueo
        '
        Me.dtFecha_Bloqueo.Enabled = False
        Me.dtFecha_Bloqueo.Location = New System.Drawing.Point(140, 22)
        Me.dtFecha_Bloqueo.Name = "dtFecha_Bloqueo"
        Me.dtFecha_Bloqueo.Size = New System.Drawing.Size(200, 20)
        Me.dtFecha_Bloqueo.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "SANCION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "PERSONAJE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "VENDEDOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "FECHA"
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(140, 53)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(165, 20)
        Me.txtVendedor.TabIndex = 32
        '
        'bloqueodecuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 356)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Name = "bloqueodecuentas"
        Me.Text = "BLOQUEO DE CUENTAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRazonBloqueo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSancion As System.Windows.Forms.ComboBox
    Friend WithEvents txtPersonaje As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha_Bloqueo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSancion As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
End Class
