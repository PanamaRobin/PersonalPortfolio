﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarHoteles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsertarHoteles))
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Registrar = New System.Windows.Forms.Button()
        Me.Cos = New System.Windows.Forms.TextBox()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lug = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.ForeColor = System.Drawing.Color.White
        Me.Limpiar.Location = New System.Drawing.Point(503, 458)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(104, 33)
        Me.Limpiar.TabIndex = 40
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Registrar
        '
        Me.Registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrar.ForeColor = System.Drawing.Color.White
        Me.Registrar.Location = New System.Drawing.Point(290, 458)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.Size = New System.Drawing.Size(104, 33)
        Me.Registrar.TabIndex = 39
        Me.Registrar.Text = "Registrar"
        Me.Registrar.UseVisualStyleBackColor = False
        '
        'Cos
        '
        Me.Cos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cos.Location = New System.Drawing.Point(380, 308)
        Me.Cos.Name = "Cos"
        Me.Cos.Size = New System.Drawing.Size(91, 23)
        Me.Cos.TabIndex = 38
        '
        'Nom
        '
        Me.Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom.Location = New System.Drawing.Point(378, 231)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(255, 23)
        Me.Nom.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(272, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(272, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Costo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Lugar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 31)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Registro de Hoteles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lug
        '
        Me.Lug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Lug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Lug.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lug.FormattingEnabled = True
        Me.Lug.Location = New System.Drawing.Point(378, 152)
        Me.Lug.Name = "Lug"
        Me.Lug.Size = New System.Drawing.Size(209, 26)
        Me.Lug.TabIndex = 41
        '
        'InsertarHoteles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.Lug)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Registrar)
        Me.Controls.Add(Me.Cos)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "InsertarHoteles"
        Me.Size = New System.Drawing.Size(892, 519)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Limpiar As Button
    Friend WithEvents Registrar As Button
    Friend WithEvents Cos As TextBox
    Friend WithEvents Nom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lug As ComboBox
End Class
