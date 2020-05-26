<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprarBoleto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComprarBoleto))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Lug = New System.Windows.Forms.ComboBox()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Comprar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Atrrr = New System.Windows.Forms.Label()
        Me.Dur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CosHot = New System.Windows.Forms.TextBox()
        Me.CosAer = New System.Windows.Forms.TextBox()
        Me.CosLug = New System.Windows.Forms.TextBox()
        Me.Aer = New System.Windows.Forms.ComboBox()
        Me.Hot = New System.Windows.Forms.ComboBox()
        Me.Dni = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "DNI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 31)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Compra de Boleto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.ForeColor = System.Drawing.Color.White
        Me.Buscar.Location = New System.Drawing.Point(341, 102)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(104, 33)
        Me.Buscar.TabIndex = 124
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'Lug
        '
        Me.Lug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Lug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Lug.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lug.FormattingEnabled = True
        Me.Lug.Location = New System.Drawing.Point(211, 42)
        Me.Lug.Name = "Lug"
        Me.Lug.Size = New System.Drawing.Size(184, 26)
        Me.Lug.TabIndex = 130
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.ForeColor = System.Drawing.Color.White
        Me.Cancelar.Location = New System.Drawing.Point(504, 293)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(104, 33)
        Me.Cancelar.TabIndex = 129
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Comprar
        '
        Me.Comprar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Comprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Comprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comprar.ForeColor = System.Drawing.Color.White
        Me.Comprar.Location = New System.Drawing.Point(291, 293)
        Me.Comprar.Name = "Comprar"
        Me.Comprar.Size = New System.Drawing.Size(104, 33)
        Me.Comprar.TabIndex = 128
        Me.Comprar.Text = "Comprar"
        Me.Comprar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Lugar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Aerolinea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Hotel"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Atrrr)
        Me.GroupBox1.Controls.Add(Me.Dur)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CosHot)
        Me.GroupBox1.Controls.Add(Me.CosAer)
        Me.GroupBox1.Controls.Add(Me.CosLug)
        Me.GroupBox1.Controls.Add(Me.Aer)
        Me.GroupBox1.Controls.Add(Me.Hot)
        Me.GroupBox1.Controls.Add(Me.Lug)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Comprar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(3, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(886, 344)
        Me.GroupBox1.TabIndex = 131
        Me.GroupBox1.TabStop = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CheckBox3.Location = New System.Drawing.Point(679, 189)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox3.TabIndex = 141
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CheckBox2.Location = New System.Drawing.Point(679, 146)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox2.TabIndex = 140
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.Location = New System.Drawing.Point(679, 103)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox1.TabIndex = 139
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Atrrr
        '
        Me.Atrrr.AutoSize = True
        Me.Atrrr.BackColor = System.Drawing.Color.Transparent
        Me.Atrrr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Atrrr.Location = New System.Drawing.Point(618, 47)
        Me.Atrrr.Name = "Atrrr"
        Me.Atrrr.Size = New System.Drawing.Size(151, 16)
        Me.Atrrr.TabIndex = 138
        Me.Atrrr.Text = "Escoger atracciones"
        Me.Atrrr.Visible = False
        '
        'Dur
        '
        Me.Dur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dur.Location = New System.Drawing.Point(211, 222)
        Me.Dur.Name = "Dur"
        Me.Dur.Size = New System.Drawing.Size(85, 23)
        Me.Dur.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Duración del viaje"
        '
        'CosHot
        '
        Me.CosHot.Enabled = False
        Me.CosHot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosHot.Location = New System.Drawing.Point(428, 163)
        Me.CosHot.Name = "CosHot"
        Me.CosHot.ReadOnly = True
        Me.CosHot.Size = New System.Drawing.Size(85, 23)
        Me.CosHot.TabIndex = 135
        '
        'CosAer
        '
        Me.CosAer.Enabled = False
        Me.CosAer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosAer.Location = New System.Drawing.Point(428, 103)
        Me.CosAer.Name = "CosAer"
        Me.CosAer.ReadOnly = True
        Me.CosAer.Size = New System.Drawing.Size(85, 23)
        Me.CosAer.TabIndex = 134
        '
        'CosLug
        '
        Me.CosLug.Enabled = False
        Me.CosLug.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CosLug.Location = New System.Drawing.Point(428, 43)
        Me.CosLug.Name = "CosLug"
        Me.CosLug.ReadOnly = True
        Me.CosLug.Size = New System.Drawing.Size(85, 23)
        Me.CosLug.TabIndex = 133
        '
        'Aer
        '
        Me.Aer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Aer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Aer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aer.FormattingEnabled = True
        Me.Aer.Location = New System.Drawing.Point(211, 102)
        Me.Aer.Name = "Aer"
        Me.Aer.Size = New System.Drawing.Size(184, 26)
        Me.Aer.TabIndex = 132
        '
        'Hot
        '
        Me.Hot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Hot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Hot.Enabled = False
        Me.Hot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hot.FormattingEnabled = True
        Me.Hot.Location = New System.Drawing.Point(211, 162)
        Me.Hot.Name = "Hot"
        Me.Hot.Size = New System.Drawing.Size(184, 26)
        Me.Hot.TabIndex = 131
        '
        'Dni
        '
        Me.Dni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Dni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dni.FormattingEnabled = True
        Me.Dni.Location = New System.Drawing.Point(128, 106)
        Me.Dni.Name = "Dni"
        Me.Dni.Size = New System.Drawing.Size(184, 26)
        Me.Dni.TabIndex = 132
        '
        'ComprarBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.Dni)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "ComprarBoleto"
        Me.Size = New System.Drawing.Size(892, 519)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents Lug As ComboBox
    Friend WithEvents Comprar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Atrrr As Label
    Friend WithEvents Dur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CosHot As TextBox
    Friend WithEvents CosAer As TextBox
    Friend WithEvents CosLug As TextBox
    Friend WithEvents Aer As ComboBox
    Friend WithEvents Hot As ComboBox
    Friend WithEvents Cancelar As Button
    Friend WithEvents Dni As ComboBox
End Class
