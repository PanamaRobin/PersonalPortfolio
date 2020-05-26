<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActTenencia
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
        Me.reg = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.act = New System.Windows.Forms.Button()
        Me.mat = New System.Windows.Forms.TextBox()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.busc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'reg
        '
        Me.reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.reg.FormattingEnabled = True
        Me.reg.Location = New System.Drawing.Point(651, 145)
        Me.reg.Name = "reg"
        Me.reg.Size = New System.Drawing.Size(178, 28)
        Me.reg.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.act)
        Me.GroupBox1.Controls.Add(Me.mat)
        Me.GroupBox1.Controls.Add(Me.dni)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1089, 377)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(424, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(285, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Edite el campo que desea actualizar:"
        '
        'act
        '
        Me.act.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.act.Location = New System.Drawing.Point(511, 275)
        Me.act.Name = "act"
        Me.act.Size = New System.Drawing.Size(104, 33)
        Me.act.TabIndex = 41
        Me.act.Text = "Actualizar"
        Me.act.UseVisualStyleBackColor = True
        '
        'mat
        '
        Me.mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat.Location = New System.Drawing.Point(565, 176)
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(176, 27)
        Me.mat.TabIndex = 37
        '
        'dni
        '
        Me.dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni.Location = New System.Drawing.Point(565, 129)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(176, 27)
        Me.dni.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(379, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Matricula del vehiculo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(379, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "DNI del conductor"
        '
        'busc
        '
        Me.busc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busc.Location = New System.Drawing.Point(514, 232)
        Me.busc.Name = "busc"
        Me.busc.Size = New System.Drawing.Size(104, 33)
        Me.busc.TabIndex = 37
        Me.busc.Text = "Buscar"
        Me.busc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(328, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(289, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Introduzca el no. de registro vehicular"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 38)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Actualizar tenencia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ActTenencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.reg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.busc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ActTenencia"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reg As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents act As Button
    Friend WithEvents mat As TextBox
    Friend WithEvents dni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents busc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
End Class
