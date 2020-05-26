<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvolucradosMultas
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
        Me.mat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.registrar = New System.Windows.Forms.Button()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.ref = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mat
        '
        Me.mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat.Location = New System.Drawing.Point(561, 386)
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(162, 27)
        Me.mat.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(394, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Matricula del auto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 38)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Registro de involucrados en multas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(609, 531)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(104, 33)
        Me.limpiar.TabIndex = 60
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'registrar
        '
        Me.registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrar.Location = New System.Drawing.Point(396, 531)
        Me.registrar.Name = "registrar"
        Me.registrar.Size = New System.Drawing.Size(104, 33)
        Me.registrar.TabIndex = 59
        Me.registrar.Text = "Registrar"
        Me.registrar.UseVisualStyleBackColor = True
        '
        'dni
        '
        Me.dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni.Location = New System.Drawing.Point(561, 303)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(176, 27)
        Me.dni.TabIndex = 58
        '
        'ref
        '
        Me.ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.Location = New System.Drawing.Point(561, 215)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(120, 27)
        Me.ref.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(394, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "DNI del conductor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(394, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "No. de referencia"
        '
        'InvolucradosMultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.registrar)
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "InvolucradosMultas"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents limpiar As Button
    Friend WithEvents registrar As Button
    Friend WithEvents dni As TextBox
    Friend WithEvents ref As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
