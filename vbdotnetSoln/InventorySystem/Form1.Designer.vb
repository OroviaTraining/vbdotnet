<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GraphicDataGridView = New System.Windows.Forms.DataGridView()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.GraphicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRefesh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.GraphicDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraphicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonRefesh)
        Me.Panel1.Controls.Add(Me.ButtonSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 508)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 44)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 46)
        Me.Panel2.TabIndex = 1
        '
        'GraphicDataGridView
        '
        Me.GraphicDataGridView.AllowUserToAddRows = False
        Me.GraphicDataGridView.AllowUserToDeleteRows = False
        Me.GraphicDataGridView.AutoGenerateColumns = False
        Me.GraphicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GraphicDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.GraphicDataGridView.DataSource = Me.GraphicBindingSource
        Me.GraphicDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GraphicDataGridView.Location = New System.Drawing.Point(0, 46)
        Me.GraphicDataGridView.Name = "GraphicDataGridView"
        Me.GraphicDataGridView.Size = New System.Drawing.Size(800, 462)
        Me.GraphicDataGridView.TabIndex = 3
        '
        'ButtonSave
        '
        Me.ButtonSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSave.Location = New System.Drawing.Point(725, 0)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 44)
        Me.ButtonSave.TabIndex = 0
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'GraphicBindingSource
        '
        Me.GraphicBindingSource.DataSource = GetType(InventorySystem.Graphic)
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "gname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "gname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "credate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "credate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "creuser"
        Me.DataGridViewTextBoxColumn4.HeaderText = "creuser"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "amddate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "amddate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "amduser"
        Me.DataGridViewTextBoxColumn6.HeaderText = "amduser"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ButtonRefesh
        '
        Me.ButtonRefesh.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonRefesh.Location = New System.Drawing.Point(650, 0)
        Me.ButtonRefesh.Name = "ButtonRefesh"
        Me.ButtonRefesh.Size = New System.Drawing.Size(75, 44)
        Me.ButtonRefesh.TabIndex = 1
        Me.ButtonRefesh.Text = "Referesh"
        Me.ButtonRefesh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 552)
        Me.Controls.Add(Me.GraphicDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GraphicDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraphicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GraphicBindingSource As BindingSource
    Friend WithEvents GraphicDataGridView As DataGridView
    Friend WithEvents ButtonSave As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonRefesh As Button
End Class
