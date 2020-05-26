<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarViajeros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EliminarViajeros))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dni = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Registrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 31)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Eliminar Viajeros"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Dni
        '
        Me.Dni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Dni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dni.FormattingEnabled = True
        Me.Dni.Location = New System.Drawing.Point(399, 198)
        Me.Dni.Name = "Dni"
        Me.Dni.Size = New System.Drawing.Size(184, 26)
        Me.Dni.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "DNI"
        '
        'Registrar
        '
        Me.Registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrar.ForeColor = System.Drawing.Color.White
        Me.Registrar.Location = New System.Drawing.Point(409, 438)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.Size = New System.Drawing.Size(104, 33)
        Me.Registrar.TabIndex = 74
        Me.Registrar.Text = "Eliminar"
        Me.Registrar.UseVisualStyleBackColor = False
        '
        'EliminarViajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.Registrar)
        Me.Controls.Add(Me.Dni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "EliminarViajeros"
        Me.Size = New System.Drawing.Size(892, 519)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Dni As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Registrar As Button
End Class
