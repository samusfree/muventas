<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventasxidhistorico
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
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnserie = New System.Windows.Forms.Button()
        Me.btnMTCN = New System.Windows.Forms.Button()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgVentas
        '
        Me.dgVentas.AllowUserToAddRows = False
        Me.dgVentas.AllowUserToDeleteRows = False
        Me.dgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgVentas.Location = New System.Drawing.Point(28, 110)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.ReadOnly = True
        Me.dgVentas.Size = New System.Drawing.Size(1224, 609)
        Me.dgVentas.TabIndex = 9
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(832, 8)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(125, 44)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(356, 8)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(149, 44)
        Me.btnConsultar.TabIndex = 7
        Me.btnConsultar.Text = "C. ID"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(140, 20)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(197, 20)
        Me.txtLogin.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "INGRESE PARAMETRO"
        '
        'btnserie
        '
        Me.btnserie.Location = New System.Drawing.Point(523, 7)
        Me.btnserie.Name = "btnserie"
        Me.btnserie.Size = New System.Drawing.Size(139, 47)
        Me.btnserie.TabIndex = 10
        Me.btnserie.Text = "C. SERIE"
        Me.btnserie.UseVisualStyleBackColor = True
        '
        'btnMTCN
        '
        Me.btnMTCN.Location = New System.Drawing.Point(679, 7)
        Me.btnMTCN.Name = "btnMTCN"
        Me.btnMTCN.Size = New System.Drawing.Size(135, 45)
        Me.btnMTCN.TabIndex = 11
        Me.btnMTCN.Text = "MTCN / OP"
        Me.btnMTCN.UseVisualStyleBackColor = True
        '
        'ventasxidhistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnMTCN)
        Me.Controls.Add(Me.btnserie)
        Me.Controls.Add(Me.dgVentas)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ventasxidhistorico"
        Me.Text = "VENTAS  HISTORICO"
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgVentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnserie As System.Windows.Forms.Button
    Friend WithEvents btnMTCN As System.Windows.Forms.Button
End Class
