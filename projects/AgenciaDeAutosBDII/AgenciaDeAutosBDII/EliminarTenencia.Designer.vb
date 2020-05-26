<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarTenencia
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
        Me.reg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(610, 505)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(104, 33)
        Me.limpiar.TabIndex = 39
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(397, 505)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(104, 33)
        Me.delete.TabIndex = 38
        Me.delete.Text = "Eliminar"
        Me.delete.UseVisualStyleBackColor = True
        '
        'reg
        '
        Me.reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg.Location = New System.Drawing.Point(569, 275)
        Me.reg.Name = "reg"
        Me.reg.Size = New System.Drawing.Size(176, 27)
        Me.reg.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(378, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "No. registro vehicular"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 38)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Eliminar tenencia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EliminarTenencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.reg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EliminarTenencia"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents limpiar As Button
    Friend WithEvents delete As Button
    Friend WithEvents reg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
End Class
