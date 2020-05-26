<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActMultas
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
        Me.reff = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hora = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.act = New System.Windows.Forms.Button()
        Me.fec = New System.Windows.Forms.TextBox()
        Me.lug = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.busc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'reff
        '
        Me.reff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.reff.FormattingEnabled = True
        Me.reff.Location = New System.Drawing.Point(589, 150)
        Me.reff.Name = "reff"
        Me.reff.Size = New System.Drawing.Size(178, 28)
        Me.reff.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mon)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.hora)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.act)
        Me.GroupBox1.Controls.Add(Me.fec)
        Me.GroupBox1.Controls.Add(Me.lug)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 296)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1089, 378)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'mon
        '
        Me.mon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mon.Location = New System.Drawing.Point(671, 198)
        Me.mon.Name = "mon"
        Me.mon.Size = New System.Drawing.Size(176, 27)
        Me.mon.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(612, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Monto"
        '
        'hora
        '
        Me.hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hora.Location = New System.Drawing.Point(671, 124)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(176, 27)
        Me.hora.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(612, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Hora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(407, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(285, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Edite el campo que desea actualizar:"
        '
        'act
        '
        Me.act.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.act.Location = New System.Drawing.Point(494, 278)
        Me.act.Name = "act"
        Me.act.Size = New System.Drawing.Size(104, 33)
        Me.act.TabIndex = 41
        Me.act.Text = "Actualizar"
        Me.act.UseVisualStyleBackColor = True
        '
        'fec
        '
        Me.fec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fec.Location = New System.Drawing.Point(278, 202)
        Me.fec.Name = "fec"
        Me.fec.Size = New System.Drawing.Size(176, 27)
        Me.fec.TabIndex = 37
        '
        'lug
        '
        Me.lug.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lug.Location = New System.Drawing.Point(278, 124)
        Me.lug.Name = "lug"
        Me.lug.Size = New System.Drawing.Size(176, 27)
        Me.lug.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(219, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(219, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Lugar"
        '
        'busc
        '
        Me.busc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busc.Location = New System.Drawing.Point(497, 234)
        Me.busc.Name = "busc"
        Me.busc.Size = New System.Drawing.Size(104, 33)
        Me.busc.TabIndex = 47
        Me.busc.Text = "Buscar"
        Me.busc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(321, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Introduzca el no. de referencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(418, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 38)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Actualizar multas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ActMultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.reff)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.busc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ActMultas"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reff As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents hora As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents act As Button
    Friend WithEvents fec As TextBox
    Friend WithEvents lug As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents busc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
End Class
