<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataBinding
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
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboProducts = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCategory
        '
        Me.cboCategory.DataSource = Me.CategoryBindingSource
        Me.cboCategory.DisplayMember = "CategoryName"
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(128, 62)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(282, 21)
        Me.cboCategory.TabIndex = 0
        Me.cboCategory.ValueMember = "CategoryID"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataSource = GetType(InventorySystem.Category)
        '
        'cboProducts
        '
        Me.cboProducts.FormattingEnabled = True
        Me.cboProducts.Location = New System.Drawing.Point(128, 126)
        Me.cboProducts.Name = "cboProducts"
        Me.cboProducts.Size = New System.Drawing.Size(282, 21)
        Me.cboProducts.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Products :"
        '
        'FormDataBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboProducts)
        Me.Controls.Add(Me.cboCategory)
        Me.Name = "FormDataBinding"
        Me.Text = "FormDataBinding"
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents cboProducts As ComboBox
    Friend WithEvents Label1 As Label
End Class
