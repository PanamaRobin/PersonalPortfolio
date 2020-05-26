<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaMultaLugar
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
        Me.busc = New System.Windows.Forms.Button()
        Me.hora = New System.Windows.Forms.MaskedTextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.filtro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'busc
        '
        Me.busc.Enabled = False
        Me.busc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busc.Location = New System.Drawing.Point(272, 239)
        Me.busc.Name = "busc"
        Me.busc.Size = New System.Drawing.Size(104, 33)
        Me.busc.TabIndex = 64
        Me.busc.Text = "Buscar"
        Me.busc.UseVisualStyleBackColor = True
        '
        'hora
        '
        Me.hora.Enabled = False
        Me.hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.hora.Location = New System.Drawing.Point(647, 177)
        Me.hora.Mask = "90:00"
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(66, 26)
        Me.hora.TabIndex = 63
        Me.hora.ValidatingType = GetType(Date)
        Me.hora.Visible = False
        '
        'fecha
        '
        Me.fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.fecha.CustomFormat = "yyyy-mm-dd"
        Me.fecha.Enabled = False
        Me.fecha.Location = New System.Drawing.Point(647, 178)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(174, 22)
        Me.fecha.TabIndex = 62
        Me.fecha.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(586, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Hora"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(577, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Fecha"
        Me.Label3.Visible = False
        '
        'filtro
        '
        Me.filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.filtro.FormattingEnabled = True
        Me.filtro.Items.AddRange(New Object() {"fecha", "hora"})
        Me.filtro.Location = New System.Drawing.Point(407, 177)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(121, 28)
        Me.filtro.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(268, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Escoja el filtro"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(198, 299)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(698, 294)
        Me.DataGridView1.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(414, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 38)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Listado de multas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ConsultaMultaLugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.busc)
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.filtro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaMultaLugar"
        Me.Size = New System.Drawing.Size(1095, 677)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents busc As Button
    Friend WithEvents hora As MaskedTextBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents filtro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
