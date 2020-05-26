<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActConductores
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.busc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.act = New System.Windows.Forms.Button()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.pob = New System.Windows.Forms.TextBox()
        Me.dir = New System.Windows.Forms.TextBox()
        Me.ape = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dni = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(341, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Introduzca el dni del conductor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 38)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Actualizar conductores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'busc
        '
        Me.busc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busc.Location = New System.Drawing.Point(507, 231)
        Me.busc.Name = "busc"
        Me.busc.Size = New System.Drawing.Size(104, 33)
        Me.busc.TabIndex = 31
        Me.busc.Text = "Buscar"
        Me.busc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.act)
        Me.GroupBox1.Controls.Add(Me.tel)
        Me.GroupBox1.Controls.Add(Me.pob)
        Me.GroupBox1.Controls.Add(Me.dir)
        Me.GroupBox1.Controls.Add(Me.ape)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1089, 380)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(416, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(285, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Edite el campo que desea actualizar:"
        '
        'act
        '
        Me.act.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.act.Location = New System.Drawing.Point(504, 288)
        Me.act.Name = "act"
        Me.act.Size = New System.Drawing.Size(104, 33)
        Me.act.TabIndex = 41
        Me.act.Text = "Actualizar"
        Me.act.UseVisualStyleBackColor = True
        '
        'tel
        '
        Me.tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel.Location = New System.Drawing.Point(736, 155)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(176, 27)
        Me.tel.TabIndex = 40
        '
        'pob
        '
        Me.pob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pob.Location = New System.Drawing.Point(736, 108)
        Me.pob.Name = "pob"
        Me.pob.Size = New System.Drawing.Size(176, 27)
        Me.pob.TabIndex = 39
        '
        'dir
        '
        Me.dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dir.Location = New System.Drawing.Point(304, 200)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(176, 27)
        Me.dir.TabIndex = 38
        '
        'ape
        '
        Me.ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ape.Location = New System.Drawing.Point(304, 155)
        Me.ape.Name = "ape"
        Me.ape.Size = New System.Drawing.Size(176, 27)
        Me.ape.TabIndex = 37
        '
        'nom
        '
        Me.nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(304, 108)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(176, 27)
        Me.nom.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(628, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(628, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Poblacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(196, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(198, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(198, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nombre"
        '
        'dni
        '
        Me.dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dni.FormattingEnabled = True
        Me.dni.Location = New System.Drawing.Point(629, 149)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(178, 28)
        Me.dni.TabIndex = 34
        '
        'ActConductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.busc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ActConductores"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents busc As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents act As Button
    Friend WithEvents tel As TextBox
    Friend WithEvents pob As TextBox
    Friend WithEvents dir As TextBox
    Friend WithEvents ape As TextBox
    Friend WithEvents nom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dni As ComboBox
End Class
