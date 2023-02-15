<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductDetails
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
        Dim DiscontinuedLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim QuantityPerUnitLabel As System.Windows.Forms.Label
        Dim ReorderLevelLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim UnitsInStockLabel As System.Windows.Forms.Label
        Dim UnitsOnOrderLabel As System.Windows.Forms.Label
        Dim CategoryIDLabel1 As System.Windows.Forms.Label
        Dim CategoryNameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.CategoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.DiscontinuedCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityPerUnitTextBox = New System.Windows.Forms.TextBox()
        Me.ReorderLevelTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.UnitsInStockTextBox = New System.Windows.Forms.TextBox()
        Me.UnitsOnOrderTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.CategoryNameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        CategoryIDLabel = New System.Windows.Forms.Label()
        DiscontinuedLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        QuantityPerUnitLabel = New System.Windows.Forms.Label()
        ReorderLevelLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        UnitPriceLabel = New System.Windows.Forms.Label()
        UnitsInStockLabel = New System.Windows.Forms.Label()
        UnitsOnOrderLabel = New System.Windows.Forms.Label()
        CategoryIDLabel1 = New System.Windows.Forms.Label()
        CategoryNameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(138, 58)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(66, 13)
        CategoryIDLabel.TabIndex = 1
        CategoryIDLabel.Text = "Category ID:"
        '
        'CategoryIDTextBox
        '
        Me.CategoryIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "CategoryID", True))
        Me.CategoryIDTextBox.Location = New System.Drawing.Point(234, 55)
        Me.CategoryIDTextBox.Name = "CategoryIDTextBox"
        Me.CategoryIDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CategoryIDTextBox.TabIndex = 2
        '
        'DiscontinuedLabel
        '
        DiscontinuedLabel.AutoSize = True
        DiscontinuedLabel.Location = New System.Drawing.Point(138, 86)
        DiscontinuedLabel.Name = "DiscontinuedLabel"
        DiscontinuedLabel.Size = New System.Drawing.Size(72, 13)
        DiscontinuedLabel.TabIndex = 3
        DiscontinuedLabel.Text = "Discontinued:"
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductBindingSource, "Discontinued", True))
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(234, 81)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DiscontinuedCheckBox.TabIndex = 4
        Me.DiscontinuedCheckBox.Text = "CheckBox1"
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(138, 114)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(61, 13)
        ProductIDLabel.TabIndex = 5
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(234, 111)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ProductIDTextBox.TabIndex = 6
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(138, 140)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(78, 13)
        ProductNameLabel.TabIndex = 7
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(234, 137)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ProductNameTextBox.TabIndex = 8
        '
        'QuantityPerUnitLabel
        '
        QuantityPerUnitLabel.AutoSize = True
        QuantityPerUnitLabel.Location = New System.Drawing.Point(138, 166)
        QuantityPerUnitLabel.Name = "QuantityPerUnitLabel"
        QuantityPerUnitLabel.Size = New System.Drawing.Size(90, 13)
        QuantityPerUnitLabel.TabIndex = 9
        QuantityPerUnitLabel.Text = "Quantity Per Unit:"
        '
        'QuantityPerUnitTextBox
        '
        Me.QuantityPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "QuantityPerUnit", True))
        Me.QuantityPerUnitTextBox.Location = New System.Drawing.Point(234, 163)
        Me.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox"
        Me.QuantityPerUnitTextBox.Size = New System.Drawing.Size(104, 20)
        Me.QuantityPerUnitTextBox.TabIndex = 10
        '
        'ReorderLevelLabel
        '
        ReorderLevelLabel.AutoSize = True
        ReorderLevelLabel.Location = New System.Drawing.Point(138, 192)
        ReorderLevelLabel.Name = "ReorderLevelLabel"
        ReorderLevelLabel.Size = New System.Drawing.Size(77, 13)
        ReorderLevelLabel.TabIndex = 11
        ReorderLevelLabel.Text = "Reorder Level:"
        '
        'ReorderLevelTextBox
        '
        Me.ReorderLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ReorderLevel", True))
        Me.ReorderLevelTextBox.Location = New System.Drawing.Point(234, 189)
        Me.ReorderLevelTextBox.Name = "ReorderLevelTextBox"
        Me.ReorderLevelTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ReorderLevelTextBox.TabIndex = 12
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(138, 218)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(62, 13)
        SupplierIDLabel.TabIndex = 13
        SupplierIDLabel.Text = "Supplier ID:"
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "SupplierID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(234, 215)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SupplierIDTextBox.TabIndex = 14
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(138, 244)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 15
        UnitPriceLabel.Text = "Unit Price:"
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "UnitPrice", True))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(234, 241)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitPriceTextBox.TabIndex = 16
        '
        'UnitsInStockLabel
        '
        UnitsInStockLabel.AutoSize = True
        UnitsInStockLabel.Location = New System.Drawing.Point(138, 270)
        UnitsInStockLabel.Name = "UnitsInStockLabel"
        UnitsInStockLabel.Size = New System.Drawing.Size(77, 13)
        UnitsInStockLabel.TabIndex = 17
        UnitsInStockLabel.Text = "Units In Stock:"
        '
        'UnitsInStockTextBox
        '
        Me.UnitsInStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "UnitsInStock", True))
        Me.UnitsInStockTextBox.Location = New System.Drawing.Point(234, 267)
        Me.UnitsInStockTextBox.Name = "UnitsInStockTextBox"
        Me.UnitsInStockTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitsInStockTextBox.TabIndex = 18
        '
        'UnitsOnOrderLabel
        '
        UnitsOnOrderLabel.AutoSize = True
        UnitsOnOrderLabel.Location = New System.Drawing.Point(138, 296)
        UnitsOnOrderLabel.Name = "UnitsOnOrderLabel"
        UnitsOnOrderLabel.Size = New System.Drawing.Size(80, 13)
        UnitsOnOrderLabel.TabIndex = 19
        UnitsOnOrderLabel.Text = "Units On Order:"
        '
        'UnitsOnOrderTextBox
        '
        Me.UnitsOnOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "UnitsOnOrder", True))
        Me.UnitsOnOrderTextBox.Location = New System.Drawing.Point(234, 293)
        Me.UnitsOnOrderTextBox.Name = "UnitsOnOrderTextBox"
        Me.UnitsOnOrderTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitsOnOrderTextBox.TabIndex = 20
        '
        'CategoryIDLabel1
        '
        CategoryIDLabel1.AutoSize = True
        CategoryIDLabel1.Location = New System.Drawing.Point(138, 356)
        CategoryIDLabel1.Name = "CategoryIDLabel1"
        CategoryIDLabel1.Size = New System.Drawing.Size(66, 13)
        CategoryIDLabel1.TabIndex = 21
        CategoryIDLabel1.Text = "Category ID:"
        '
        'CategoryIDTextBox1
        '
        Me.CategoryIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Category.CategoryID", True))
        Me.CategoryIDTextBox1.Location = New System.Drawing.Point(227, 353)
        Me.CategoryIDTextBox1.Name = "CategoryIDTextBox1"
        Me.CategoryIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CategoryIDTextBox1.TabIndex = 22
        '
        'CategoryNameLabel
        '
        CategoryNameLabel.AutoSize = True
        CategoryNameLabel.Location = New System.Drawing.Point(138, 382)
        CategoryNameLabel.Name = "CategoryNameLabel"
        CategoryNameLabel.Size = New System.Drawing.Size(83, 13)
        CategoryNameLabel.TabIndex = 23
        CategoryNameLabel.Text = "Category Name:"
        '
        'CategoryNameTextBox
        '
        Me.CategoryNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Category.CategoryName", True))
        Me.CategoryNameTextBox.Location = New System.Drawing.Point(227, 379)
        Me.CategoryNameTextBox.Name = "CategoryNameTextBox"
        Me.CategoryNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryNameTextBox.TabIndex = 24
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(138, 408)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 25
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Category.Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(227, 405)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescriptionTextBox.TabIndex = 26
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(InventorySystem.Product)
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(510, 270)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 27
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'FormProductDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 465)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(CategoryIDLabel1)
        Me.Controls.Add(Me.CategoryIDTextBox1)
        Me.Controls.Add(CategoryNameLabel)
        Me.Controls.Add(Me.CategoryNameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(CategoryIDLabel)
        Me.Controls.Add(Me.CategoryIDTextBox)
        Me.Controls.Add(DiscontinuedLabel)
        Me.Controls.Add(Me.DiscontinuedCheckBox)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(QuantityPerUnitLabel)
        Me.Controls.Add(Me.QuantityPerUnitTextBox)
        Me.Controls.Add(ReorderLevelLabel)
        Me.Controls.Add(Me.ReorderLevelTextBox)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDTextBox)
        Me.Controls.Add(UnitPriceLabel)
        Me.Controls.Add(Me.UnitPriceTextBox)
        Me.Controls.Add(UnitsInStockLabel)
        Me.Controls.Add(Me.UnitsInStockTextBox)
        Me.Controls.Add(UnitsOnOrderLabel)
        Me.Controls.Add(Me.UnitsOnOrderTextBox)
        Me.Name = "FormProductDetails"
        Me.Text = "FormProductDetails"
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents CategoryIDTextBox As TextBox
    Friend WithEvents DiscontinuedCheckBox As CheckBox
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents QuantityPerUnitTextBox As TextBox
    Friend WithEvents ReorderLevelTextBox As TextBox
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents UnitPriceTextBox As TextBox
    Friend WithEvents UnitsInStockTextBox As TextBox
    Friend WithEvents UnitsOnOrderTextBox As TextBox
    Friend WithEvents CategoryIDTextBox1 As TextBox
    Friend WithEvents CategoryNameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents ButtonUpdate As Button
End Class
