<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarTenencia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.registrar = New System.Windows.Forms.Button()
        Me.matricula = New System.Windows.Forms.TextBox()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de tenencia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(602, 507)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(104, 33)
        Me.limpiar.TabIndex = 36
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'registrar
        '
        Me.registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrar.Location = New System.Drawing.Point(389, 507)
        Me.registrar.Name = "registrar"
        Me.registrar.Size = New System.Drawing.Size(104, 33)
        Me.registrar.TabIndex = 35
        Me.registrar.Text = "Registrar"
        Me.registrar.UseVisualStyleBackColor = True
        '
        'matricula
        '
        Me.matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matricula.Location = New System.Drawing.Point(552, 364)
        Me.matricula.Name = "matricula"
        Me.matricula.Size = New System.Drawing.Size(176, 27)
        Me.matricula.TabIndex = 33
        '
        'dni
        '
        Me.dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni.Location = New System.Drawing.Point(552, 251)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(176, 27)
        Me.dni.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(382, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Matricula del auto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(380, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "DNI del conductor"
        '
        'RegistrarTenencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.registrar)
        Me.Controls.Add(Me.matricula)
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrarTenencia"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents limpiar As Button
    Friend WithEvents registrar As Button
    Friend WithEvents matricula As TextBox
    Friend WithEvents dni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
