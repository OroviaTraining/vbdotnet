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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboRegions = New System.Windows.Forms.ComboBox()
        Me.cboTerri = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEmployees = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.cboProducts.Location = New System.Drawing.Point(128, 23)
        Me.cboProducts.Name = "cboProducts"
        Me.cboProducts.Size = New System.Drawing.Size(282, 21)
        Me.cboProducts.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Products :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Region"
        '
        'cboRegions
        '
        Me.cboRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegions.FormattingEnabled = True
        Me.cboRegions.Location = New System.Drawing.Point(128, 111)
        Me.cboRegions.Name = "cboRegions"
        Me.cboRegions.Size = New System.Drawing.Size(282, 21)
        Me.cboRegions.TabIndex = 4
        '
        'cboTerri
        '
        Me.cboTerri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTerri.FormattingEnabled = True
        Me.cboTerri.Location = New System.Drawing.Point(128, 138)
        Me.cboTerri.Name = "cboTerri"
        Me.cboTerri.Size = New System.Drawing.Size(282, 21)
        Me.cboTerri.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Territory"
        '
        'cboEmployees
        '
        Me.cboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployees.FormattingEnabled = True
        Me.cboEmployees.Location = New System.Drawing.Point(128, 165)
        Me.cboEmployees.Name = "cboEmployees"
        Me.cboEmployees.Size = New System.Drawing.Size(282, 21)
        Me.cboEmployees.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Employees"
        '
        'FormDataBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 450)
        Me.Controls.Add(Me.cboEmployees)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboTerri)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboRegions)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents cboRegions As ComboBox
    Friend WithEvents cboTerri As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboEmployees As ComboBox
    Friend WithEvents Label4 As Label
End Class
