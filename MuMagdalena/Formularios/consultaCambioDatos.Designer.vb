<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultaCambioDatos
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBusquedaMTCN = New System.Windows.Forms.Button()
        Me.btnBusquedaID = New System.Windows.Forms.Button()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.dgCambioDatos = New System.Windows.Forms.DataGridView()
        CType(Me.dgCambioDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(610, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "CANCELAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBusquedaMTCN
        '
        Me.btnBusquedaMTCN.Location = New System.Drawing.Point(407, 15)
        Me.btnBusquedaMTCN.Name = "btnBusquedaMTCN"
        Me.btnBusquedaMTCN.Size = New System.Drawing.Size(196, 23)
        Me.btnBusquedaMTCN.TabIndex = 21
        Me.btnBusquedaMTCN.Text = "BUSQUEDA MTCN"
        Me.btnBusquedaMTCN.UseVisualStyleBackColor = True
        '
        'btnBusquedaID
        '
        Me.btnBusquedaID.Location = New System.Drawing.Point(268, 15)
        Me.btnBusquedaID.Name = "btnBusquedaID"
        Me.btnBusquedaID.Size = New System.Drawing.Size(131, 23)
        Me.btnBusquedaID.TabIndex = 20
        Me.btnBusquedaID.Text = "BUSQUEDA ID"
        Me.btnBusquedaID.UseVisualStyleBackColor = True
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(135, 17)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(121, 20)
        Me.txtLogin.TabIndex = 19
        '
        'dgCambioDatos
        '
        Me.dgCambioDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCambioDatos.Location = New System.Drawing.Point(12, 64)
        Me.dgCambioDatos.Name = "dgCambioDatos"
        Me.dgCambioDatos.Size = New System.Drawing.Size(799, 360)
        Me.dgCambioDatos.TabIndex = 17
        '
        'consultaCambioDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 436)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBusquedaMTCN)
        Me.Controls.Add(Me.btnBusquedaID)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.dgCambioDatos)
        Me.Name = "consultaCambioDatos"
        Me.Text = "consultaCambioDatos"
        CType(Me.dgCambioDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBusquedaMTCN As System.Windows.Forms.Button
    Friend WithEvents btnBusquedaID As System.Windows.Forms.Button
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents dgCambioDatos As System.Windows.Forms.DataGridView
End Class
