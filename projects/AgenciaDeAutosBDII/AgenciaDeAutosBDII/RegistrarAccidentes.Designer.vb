<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarAccidentes
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
        Me.lugar = New System.Windows.Forms.TextBox()
        Me.ref = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.hora = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de accidentes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'limpiar
        '
        Me.limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.Location = New System.Drawing.Point(595, 514)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(104, 33)
        Me.limpiar.TabIndex = 28
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'registrar
        '
        Me.registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrar.Location = New System.Drawing.Point(382, 514)
        Me.registrar.Name = "registrar"
        Me.registrar.Size = New System.Drawing.Size(104, 33)
        Me.registrar.TabIndex = 27
        Me.registrar.Text = "Registrar"
        Me.registrar.UseVisualStyleBackColor = True
        '
        'lugar
        '
        Me.lugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lugar.Location = New System.Drawing.Point(309, 365)
        Me.lugar.Name = "lugar"
        Me.lugar.Size = New System.Drawing.Size(196, 27)
        Me.lugar.TabIndex = 22
        '
        'ref
        '
        Me.ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ref.Location = New System.Drawing.Point(385, 252)
        Me.ref.Name = "ref"
        Me.ref.Size = New System.Drawing.Size(120, 27)
        Me.ref.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(620, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(618, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(218, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Lugar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(218, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "No. de referencia"
        '
        'fecha
        '
        Me.fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.fecha.Location = New System.Drawing.Point(714, 255)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(174, 22)
        Me.fecha.TabIndex = 29
        '
        'hora
        '
        Me.hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.hora.Location = New System.Drawing.Point(714, 365)
        Me.hora.Mask = "90:00"
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(57, 26)
        Me.hora.TabIndex = 30
        Me.hora.ValidatingType = GetType(Date)
        '
        'RegistrarAccidentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.registrar)
        Me.Controls.Add(Me.lugar)
        Me.Controls.Add(Me.ref)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrarAccidentes"
        Me.Size = New System.Drawing.Size(1095, 677)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents limpiar As Button
    Friend WithEvents registrar As Button
    Friend WithEvents lugar As TextBox
    Friend WithEvents ref As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents hora As MaskedTextBox
End Class
