<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaAccidenteLugar
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filtro = New System.Windows.Forms.ComboBox()
        Me.hora = New System.Windows.Forms.MaskedTextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.busc = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(196, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(698, 294)
        Me.DataGridView1.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 38)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Listado de accidentes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(266, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Escoja el filtro"
        '
        'filtro
        '
        Me.filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.filtro.FormattingEnabled = True
        Me.filtro.Items.AddRange(New Object() {"fecha", "hora"})
        Me.filtro.Location = New System.Drawing.Point(405, 168)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(121, 28)
        Me.filtro.TabIndex = 50
        '
        'hora
        '
        Me.hora.Enabled = False
        Me.hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.hora.Location = New System.Drawing.Point(645, 168)
        Me.hora.Mask = "90:00"
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(66, 26)
        Me.hora.TabIndex = 54
        Me.hora.ValidatingType = GetType(Date)
        Me.hora.Visible = False
        '
        'fecha
        '
        Me.fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.fecha.CustomFormat = "yyyy-mm-dd"
        Me.fecha.Enabled = False
        Me.fecha.Location = New System.Drawing.Point(645, 169)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(174, 22)
        Me.fecha.TabIndex = 53
        Me.fecha.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(584, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Hora"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(575, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Fecha"
        Me.Label3.Visible = False
        '
        'busc
        '
        Me.busc.Enabled = False
        Me.busc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busc.Location = New System.Drawing.Point(270, 230)
        Me.busc.Name = "busc"
        Me.busc.Size = New System.Drawing.Size(104, 33)
        Me.busc.TabIndex = 55
        Me.busc.Text = "Buscar"
        Me.busc.UseVisualStyleBackColor = True
        '
        'ConsultaAccidenteLugar
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
        Me.Name = "ConsultaAccidenteLugar"
        Me.Size = New System.Drawing.Size(1095, 677)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents filtro As ComboBox
    Friend WithEvents hora As MaskedTextBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents busc As Button
End Class
