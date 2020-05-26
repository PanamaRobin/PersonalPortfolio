<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarMultas
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.ref = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(595, 509)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(104, 33)
        Me.limpiar.TabIndex = 49
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(382, 509)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(104, 33)
        Me.delete.TabIndex = 48
        Me.delete.Text = "Eliminar"
        Me.delete.UseVisualStyleBackColor = True
        '
        'ref
        '
        Me.ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.Location = New System.Drawing.Point(554, 279)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(176, 27)
        Me.ref.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(363, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "No. de referencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 38)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Eliminar multas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EliminarMultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EliminarMultas"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents limpiar As Button
    Friend WithEvents delete As Button
    Friend WithEvents ref As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
End Class
