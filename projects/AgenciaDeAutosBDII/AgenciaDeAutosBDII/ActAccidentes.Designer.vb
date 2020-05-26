<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActAccidentes
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
        Me.ref = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hora = New System.Windows.Forms.MaskedTextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.act = New System.Windows.Forms.Button()
        Me.lug = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.busc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ref
        '
        Me.ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ref.FormattingEnabled = True
        Me.ref.Location = New System.Drawing.Point(609, 136)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(178, 28)
        Me.ref.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hora)
        Me.GroupBox1.Controls.Add(Me.fecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.act)
        Me.GroupBox1.Controls.Add(Me.lug)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1092, 443)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'hora
        '
        Me.hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.hora.Location = New System.Drawing.Point(486, 254)
        Me.hora.Mask = "90:00"
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(66, 26)
        Me.hora.TabIndex = 46
        Me.hora.ValidatingType = GetType(Date)
        '
        'fecha
        '
        Me.fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.fecha.Location = New System.Drawing.Point(486, 203)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(174, 22)
        Me.fecha.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(420, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Hora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(402, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(285, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Edite el campo que desea actualizar:"
        '
        'act
        '
        Me.act.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.act.Location = New System.Drawing.Point(505, 342)
        Me.act.Name = "act"
        Me.act.Size = New System.Drawing.Size(104, 33)
        Me.act.TabIndex = 41
        Me.act.Text = "Actualizar"
        Me.act.UseVisualStyleBackColor = True
        '
        'lug
        '
        Me.lug.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lug.Location = New System.Drawing.Point(486, 141)
        Me.lug.Name = "lug"
        Me.lug.Size = New System.Drawing.Size(176, 27)
        Me.lug.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(420, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(422, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Lugar"
        '
        'busc
        '
        Me.busc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busc.Location = New System.Drawing.Point(508, 192)
        Me.busc.Name = "busc"
        Me.busc.Size = New System.Drawing.Size(104, 33)
        Me.busc.TabIndex = 42
        Me.busc.Text = "Buscar"
        Me.busc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(332, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Introduzca el no. de referencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 38)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Actualizar accidentes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ActAccidentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.busc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ActAccidentes"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ref As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents act As Button
    Friend WithEvents lug As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents busc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents hora As MaskedTextBox
End Class
