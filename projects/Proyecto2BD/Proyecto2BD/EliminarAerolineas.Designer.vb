<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarAerolineas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminarAerolineas))
        Me.Registrar = New System.Windows.Forms.Button()
        Me.Aer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Registrar
        '
        Me.Registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrar.ForeColor = System.Drawing.Color.White
        Me.Registrar.Location = New System.Drawing.Point(416, 440)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.Size = New System.Drawing.Size(104, 33)
        Me.Registrar.TabIndex = 84
        Me.Registrar.Text = "Eliminar"
        Me.Registrar.UseVisualStyleBackColor = False
        '
        'Aer
        '
        Me.Aer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Aer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Aer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aer.FormattingEnabled = True
        Me.Aer.Location = New System.Drawing.Point(416, 201)
        Me.Aer.Name = "Aer"
        Me.Aer.Size = New System.Drawing.Size(184, 26)
        Me.Aer.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Aerolinea"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 31)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Eliminar Aerolineas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EliminarAerolineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.Registrar)
        Me.Controls.Add(Me.Aer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "EliminarAerolineas"
        Me.Size = New System.Drawing.Size(892, 519)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Registrar As Button
    Friend WithEvents Aer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
