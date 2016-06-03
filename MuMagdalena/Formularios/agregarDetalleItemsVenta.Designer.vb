<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agregarDetalleItemsVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgItems = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgItems
        '
        Me.dgItems.AllowUserToAddRows = False
        Me.dgItems.AllowUserToDeleteRows = False
        Me.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.correlativo, Me.cod_item, Me.descripcion, Me.precio, Me.serie})
        Me.dgItems.Location = New System.Drawing.Point(12, 12)
        Me.dgItems.Name = "dgItems"
        Me.dgItems.Size = New System.Drawing.Size(676, 467)
        Me.dgItems.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(793, 12)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 44)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Agregar Items"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'correlativo
        '
        Me.correlativo.DataPropertyName = "correlativo"
        Me.correlativo.HeaderText = "#"
        Me.correlativo.Name = "correlativo"
        Me.correlativo.Width = 39
        '
        'cod_item
        '
        Me.cod_item.DataPropertyName = "cod_item"
        Me.cod_item.HeaderText = "Codigo Item"
        Me.cod_item.Name = "cod_item"
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Nombre"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 120
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'serie
        '
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        '
        'agregarDetalleItemsVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 491)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgItems)
        Me.Name = "agregarDetalleItemsVenta"
        Me.Text = "Agregar datos de Items del Set"
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgItems As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents correlativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
