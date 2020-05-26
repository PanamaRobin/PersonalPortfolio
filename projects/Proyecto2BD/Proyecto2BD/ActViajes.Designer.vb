<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActViajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActViajes))
        Me.Via = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Hor = New System.Windows.Forms.MaskedTextBox()
        Me.Fec = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Via
        '
        Me.Via.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Via.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Via.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Via.FormattingEnabled = True
        Me.Via.Location = New System.Drawing.Point(412, 128)
        Me.Via.Name = "Via"
        Me.Via.Size = New System.Drawing.Size(184, 26)
        Me.Via.TabIndex = 127
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(276, 133)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(118, 16)
        Me.Label.TabIndex = 126
        Me.Label.Text = "Codigo de viaje"
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.ForeColor = System.Drawing.Color.White
        Me.Buscar.Location = New System.Drawing.Point(387, 193)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(104, 33)
        Me.Buscar.TabIndex = 125
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(327, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 31)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Actualizar Viajes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Hor)
        Me.GroupBox1.Controls.Add(Me.Fec)
        Me.GroupBox1.Controls.Add(Me.Cod)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Actualizar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(0, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(886, 284)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        '
        'Cod
        '
        Me.Cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod.Location = New System.Drawing.Point(683, 94)
        Me.Cod.Name = "Cod"
        Me.Cod.Size = New System.Drawing.Size(110, 23)
        Me.Cod.TabIndex = 101
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(548, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Codigo de ruta"
        '
        'Actualizar
        '
        Me.Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actualizar.ForeColor = System.Drawing.Color.White
        Me.Actualizar.Location = New System.Drawing.Point(387, 230)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(104, 33)
        Me.Actualizar.TabIndex = 96
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(265, 16)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Edite el campo que desea actualizar:"
        '
        'Hor
        '
        Me.Hor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hor.Location = New System.Drawing.Point(113, 146)
        Me.Hor.Mask = "90:00"
        Me.Hor.Name = "Hor"
        Me.Hor.Size = New System.Drawing.Size(59, 24)
        Me.Hor.TabIndex = 103
        Me.Hor.ValidatingType = GetType(Date)
        '
        'Fec
        '
        Me.Fec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fec.Location = New System.Drawing.Point(113, 93)
        Me.Fec.Name = "Fec"
        Me.Fec.Size = New System.Drawing.Size(246, 24)
        Me.Fec.TabIndex = 102
        '
        'ActViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.Via)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "ActViajes"
        Me.Size = New System.Drawing.Size(892, 519)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Via As ComboBox
    Friend WithEvents Label As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cod As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Actualizar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Hor As MaskedTextBox
    Friend WithEvents Fec As DateTimePicker
End Class
