<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventaxID
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
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.btnSerie = New System.Windows.Forms.Button()
        Me.btnVentasMTCN = New System.Windows.Forms.Button()
        Me.btnCambio = New System.Windows.Forms.Button()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESE PARAMETRO"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(180, 15)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(211, 20)
        Me.txtLogin.TabIndex = 1
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(440, 5)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(127, 39)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "C. ID"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(850, 5)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(123, 39)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgVentas
        '
        Me.dgVentas.AllowUserToAddRows = False
        Me.dgVentas.AllowUserToDeleteRows = False
        Me.dgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgVentas.Location = New System.Drawing.Point(12, 55)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.ReadOnly = True
        Me.dgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVentas.Size = New System.Drawing.Size(1112, 511)
        Me.dgVentas.TabIndex = 4
        '
        'btnSerie
        '
        Me.btnSerie.Location = New System.Drawing.Point(583, 5)
        Me.btnSerie.Name = "btnSerie"
        Me.btnSerie.Size = New System.Drawing.Size(132, 39)
        Me.btnSerie.TabIndex = 5
        Me.btnSerie.Text = "C. SERIE"
        Me.btnSerie.UseVisualStyleBackColor = True
        '
        'btnVentasMTCN
        '
        Me.btnVentasMTCN.Location = New System.Drawing.Point(721, 5)
        Me.btnVentasMTCN.Name = "btnVentasMTCN"
        Me.btnVentasMTCN.Size = New System.Drawing.Size(123, 39)
        Me.btnVentasMTCN.TabIndex = 8
        Me.btnVentasMTCN.Text = "C. MTCN o OP"
        Me.btnVentasMTCN.UseVisualStyleBackColor = True
        '
        'btnCambio
        '
        Me.btnCambio.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCambio.Location = New System.Drawing.Point(997, 5)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(127, 39)
        Me.btnCambio.TabIndex = 9
        Me.btnCambio.Text = "Set para cambio"
        Me.btnCambio.UseVisualStyleBackColor = False
        Me.btnCambio.Visible = False
        '
        'ventaxID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 578)
        Me.Controls.Add(Me.btnCambio)
        Me.Controls.Add(Me.btnVentasMTCN)
        Me.Controls.Add(Me.btnSerie)
        Me.Controls.Add(Me.dgVentas)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ventaxID"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "CONSULTA DE VENTAS  ACTUALES"
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgVentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnSerie As System.Windows.Forms.Button
    Friend WithEvents btnVentasMTCN As System.Windows.Forms.Button
    Friend WithEvents btnCambio As Windows.Forms.Button
End Class
