<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCatg1
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
        Dim CategoryIDLabel As System.Windows.Forms.Label
        Dim CategoryNameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.CategoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryNameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        CategoryIDLabel = New System.Windows.Forms.Label()
        CategoryNameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(48, 22)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(66, 13)
        CategoryIDLabel.TabIndex = 1
        CategoryIDLabel.Text = "Category ID:"
        '
        'CategoryIDTextBox
        '
        Me.CategoryIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "CategoryID", True))
        Me.CategoryIDTextBox.Location = New System.Drawing.Point(137, 19)
        Me.CategoryIDTextBox.Name = "CategoryIDTextBox"
        Me.CategoryIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryIDTextBox.TabIndex = 2
        '
        'CategoryNameLabel
        '
        CategoryNameLabel.AutoSize = True
        CategoryNameLabel.Location = New System.Drawing.Point(48, 48)
        CategoryNameLabel.Name = "CategoryNameLabel"
        CategoryNameLabel.Size = New System.Drawing.Size(83, 13)
        CategoryNameLabel.TabIndex = 3
        CategoryNameLabel.Text = "Category Name:"
        '
        'CategoryNameTextBox
        '
        Me.CategoryNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "CategoryName", True))
        Me.CategoryNameTextBox.Location = New System.Drawing.Point(137, 45)
        Me.CategoryNameTextBox.Name = "CategoryNameTextBox"
        Me.CategoryNameTextBox.Size = New System.Drawing.Size(337, 20)
        Me.CategoryNameTextBox.TabIndex = 4
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(48, 74)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(137, 71)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(337, 65)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataSource = GetType(InventorySystem.Category)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(179, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Prev"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Last"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(418, 142)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "First"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(69, 184)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CategoryDataGridView
        '
        Me.CategoryDataGridView.AutoGenerateColumns = False
        Me.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CategoryDataGridView.DataSource = Me.CategoryBindingSource
        Me.CategoryDataGridView.Location = New System.Drawing.Point(28, 249)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.Size = New System.Drawing.Size(743, 313)
        Me.CategoryDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CategoryID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CategoryID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CategoryName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CategoryName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Picture"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Picture"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(179, 184)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "ADD"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'FormCatg1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 583)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.CategoryDataGridView)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CategoryIDLabel)
        Me.Controls.Add(Me.CategoryIDTextBox)
        Me.Controls.Add(CategoryNameLabel)
        Me.Controls.Add(Me.CategoryNameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Name = "FormCatg1"
        Me.Text = "FormCatg1"
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryIDTextBox As TextBox
    Friend WithEvents CategoryNameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
End Class
