<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParentChild
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
        Me.BrandComboBox = New System.Windows.Forms.ComboBox()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BCategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BCategoriesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BCategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCategoriesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BrandComboBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 70)
        Me.Panel1.TabIndex = 0
        '
        'BrandComboBox
        '
        Me.BrandComboBox.DataSource = Me.BrandBindingSource
        Me.BrandComboBox.DisplayMember = "bname"
        Me.BrandComboBox.FormattingEnabled = True
        Me.BrandComboBox.Location = New System.Drawing.Point(211, 24)
        Me.BrandComboBox.Name = "BrandComboBox"
        Me.BrandComboBox.Size = New System.Drawing.Size(300, 21)
        Me.BrandComboBox.TabIndex = 0
        Me.BrandComboBox.ValueMember = "bid"
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataSource = GetType(InventorySystem.Brand)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 46)
        Me.Panel2.TabIndex = 1
        '
        'BCategoriesBindingSource
        '
        Me.BCategoriesBindingSource.DataMember = "BCategories"
        Me.BCategoriesBindingSource.DataSource = Me.BrandBindingSource
        '
        'BCategoriesDataGridView
        '
        Me.BCategoriesDataGridView.AutoGenerateColumns = False
        Me.BCategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BCategoriesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.BCategoriesDataGridView.DataSource = Me.BCategoriesBindingSource
        Me.BCategoriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BCategoriesDataGridView.Location = New System.Drawing.Point(0, 70)
        Me.BCategoriesDataGridView.Name = "BCategoriesDataGridView"
        Me.BCategoriesDataGridView.Size = New System.Drawing.Size(800, 375)
        Me.BCategoriesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cid"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(725, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 46)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FormParentChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.Controls.Add(Me.BCategoriesDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormParentChild"
        Me.Text = "FormParentChild"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BCategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCategoriesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BrandComboBox As ComboBox
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BCategoriesBindingSource As BindingSource
    Friend WithEvents BCategoriesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
End Class
