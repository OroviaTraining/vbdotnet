<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGrid
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
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxtPrice = New System.Windows.Forms.MaskedTextBox()
        Me.cboOp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonFilter = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkDisc = New System.Windows.Forms.CheckBox()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.LabelMessage = New System.Windows.Forms.Label()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CategoryID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.QuantityPerUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ColSID, Me.CategoryID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.QuantityPerUnit, Me.colEdit, Me.colDelete, Me.btnDelete})
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductDataGridView.Location = New System.Drawing.Point(0, 50)
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.Size = New System.Drawing.Size(957, 284)
        Me.ProductDataGridView.TabIndex = 1
        '
        'CategoryBindingSource
        '
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.AllowNew = False
        Me.ProductBindingSource.DataSource = GetType(InventorySystem.Product)
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelTop.Controls.Add(Me.GroupBox1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(957, 50)
        Me.PanelTop.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtxtPrice)
        Me.GroupBox1.Controls.Add(Me.cboOp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ButtonFilter)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkDisc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter By"
        '
        'mtxtPrice
        '
        Me.mtxtPrice.Location = New System.Drawing.Point(644, 19)
        Me.mtxtPrice.Mask = "00000"
        Me.mtxtPrice.Name = "mtxtPrice"
        Me.mtxtPrice.Size = New System.Drawing.Size(100, 20)
        Me.mtxtPrice.TabIndex = 7
        Me.mtxtPrice.ValidatingType = GetType(Integer)
        '
        'cboOp
        '
        Me.cboOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOp.FormattingEnabled = True
        Me.cboOp.Items.AddRange(New Object() {"Greater Than", "Less Than", "Equal To"})
        Me.cboOp.Location = New System.Drawing.Point(563, 18)
        Me.cboOp.Name = "cboOp"
        Me.cboOp.Size = New System.Drawing.Size(75, 21)
        Me.cboOp.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Unit Price:"
        '
        'ButtonFilter
        '
        Me.ButtonFilter.Location = New System.Drawing.Point(879, 15)
        Me.ButtonFilter.Name = "ButtonFilter"
        Me.ButtonFilter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFilter.TabIndex = 4
        Me.ButtonFilter.Text = "Filter"
        Me.ButtonFilter.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(213, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(249, 20)
        Me.txtName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name :"
        '
        'chkDisc
        '
        Me.chkDisc.AutoSize = True
        Me.chkDisc.Location = New System.Drawing.Point(12, 20)
        Me.chkDisc.Name = "chkDisc"
        Me.chkDisc.Size = New System.Drawing.Size(111, 17)
        Me.chkDisc.TabIndex = 1
        Me.chkDisc.Text = "Hide discontinued"
        Me.chkDisc.UseVisualStyleBackColor = True
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelBottom.Controls.Add(Me.ButtonCancel)
        Me.PanelBottom.Controls.Add(Me.LabelMessage)
        Me.PanelBottom.Controls.Add(Me.ButtonUpdate)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 400)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(957, 50)
        Me.PanelBottom.TabIndex = 3
        '
        'LabelMessage
        '
        Me.LabelMessage.AutoSize = True
        Me.LabelMessage.Location = New System.Drawing.Point(52, 24)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.Size = New System.Drawing.Size(39, 13)
        Me.LabelMessage.TabIndex = 1
        Me.LabelMessage.Text = "Label1"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(563, 15)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 0
        Me.ButtonUpdate.Text = "Save Changes"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.InventorySystem.My.Resources.Resources.angry_bird_green_icon
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ColSID
        '
        Me.ColSID.DataPropertyName = "SupplierID"
        Me.ColSID.DataSource = Me.SupplierBindingSource
        Me.ColSID.HeaderText = "SupplierID"
        Me.ColSID.Name = "ColSID"
        Me.ColSID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CategoryID
        '
        Me.CategoryID.DataPropertyName = "CategoryID"
        Me.CategoryID.DataSource = Me.CategoryBindingSource
        Me.CategoryID.HeaderText = "CategoryID"
        Me.CategoryID.Name = "CategoryID"
        Me.CategoryID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Discontinued"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'QuantityPerUnit
        '
        Me.QuantityPerUnit.DataPropertyName = "QuantityPerUnit"
        Me.QuantityPerUnit.HeaderText = "Qty"
        Me.QuantityPerUnit.Name = "QuantityPerUnit"
        '
        'colEdit
        '
        Me.colEdit.HeaderText = ""
        Me.colEdit.Name = "colEdit"
        Me.colEdit.Text = "Edit"
        Me.colEdit.UseColumnTextForLinkValue = True
        '
        'colDelete
        '
        Me.colDelete.HeaderText = ""
        Me.colDelete.Image = Global.InventorySystem.My.Resources.Resources.Close_2_icon
        Me.colDelete.Name = "colDelete"
        '
        'btnDelete
        '
        Me.btnDelete.HeaderText = ""
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseColumnTextForButtonValue = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxStock)
        Me.Panel1.Controls.Add(Me.TextBoxDesc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 334)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 66)
        Me.Panel1.TabIndex = 4
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Location = New System.Drawing.Point(22, 18)
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxDesc.TabIndex = 0
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(364, 18)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(409, 20)
        Me.TextBoxStock.TabIndex = 1
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(644, 14)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FormGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 450)
        Me.Controls.Add(Me.ProductDataGridView)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBottom)
        Me.Name = "FormGrid"
        Me.Text = "FormGrid"
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductDataGridView As DataGridView
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents LabelMessage As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkDisc As CheckBox
    Friend WithEvents ButtonFilter As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboOp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxtPrice As MaskedTextBox
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ColSID As DataGridViewComboBoxColumn
    Friend WithEvents CategoryID As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents QuantityPerUnit As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewLinkColumn
    Friend WithEvents colDelete As DataGridViewImageColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxDesc As TextBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents ButtonCancel As Button
End Class
