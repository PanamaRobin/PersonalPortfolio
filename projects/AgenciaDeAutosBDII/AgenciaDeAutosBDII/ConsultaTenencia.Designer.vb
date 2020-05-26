<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaTenencia
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.per = New System.Windows.Forms.ComboBox()
        Me.ConsultaNombreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgenciaDeSegurosDataSet2 = New AgenciaDeAutosBDII.AgenciaDeSegurosDataSet2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AgenciaDeSegurosDataSet = New AgenciaDeAutosBDII.AgenciaDeSegurosDataSet()
        Me.AgenciaDeSegurosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaNombreTableAdapter = New AgenciaDeAutosBDII.AgenciaDeSegurosDataSet2TableAdapters.ConsultaNombreTableAdapter()
        CType(Me.ConsultaNombreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaDeSegurosDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaDeSegurosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaDeSegurosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'per
        '
        Me.per.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.per.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.per.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.per.FormattingEnabled = True
        Me.per.Location = New System.Drawing.Point(399, 234)
        Me.per.Name = "per"
        Me.per.Size = New System.Drawing.Size(243, 28)
        Me.per.TabIndex = 44
        '
        'ConsultaNombreBindingSource
        '
        Me.ConsultaNombreBindingSource.DataMember = "ConsultaNombre"
        Me.ConsultaNombreBindingSource.DataSource = Me.AgenciaDeSegurosDataSet2
        '
        'AgenciaDeSegurosDataSet2
        '
        Me.AgenciaDeSegurosDataSet2.DataSetName = "AgenciaDeSegurosDataSet2"
        Me.AgenciaDeSegurosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 38)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Personas con vehiculo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AgenciaDeSegurosDataSet
        '
        Me.AgenciaDeSegurosDataSet.DataSetName = "AgenciaDeSegurosDataSet"
        Me.AgenciaDeSegurosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgenciaDeSegurosDataSetBindingSource
        '
        Me.AgenciaDeSegurosDataSetBindingSource.DataSource = Me.AgenciaDeSegurosDataSet
        Me.AgenciaDeSegurosDataSetBindingSource.Position = 0
        '
        'ConsultaNombreTableAdapter
        '
        Me.ConsultaNombreTableAdapter.ClearBeforeFill = True
        '
        'ConsultaTenencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.per)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaTenencia"
        Me.Size = New System.Drawing.Size(1095, 677)
        CType(Me.ConsultaNombreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaDeSegurosDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaDeSegurosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaDeSegurosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents per As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ConsultaNombreBindingSource As BindingSource
    Friend WithEvents AgenciaDeSegurosDataSet2 As AgenciaDeSegurosDataSet2
    Friend WithEvents AgenciaDeSegurosDataSet As AgenciaDeSegurosDataSet
    Friend WithEvents AgenciaDeSegurosDataSetBindingSource As BindingSource
    Friend WithEvents ConsultaNombreTableAdapter As AgenciaDeSegurosDataSet2TableAdapters.ConsultaNombreTableAdapter
End Class
