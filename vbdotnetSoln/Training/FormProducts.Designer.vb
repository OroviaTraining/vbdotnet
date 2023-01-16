<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonLookup = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewProducts = New System.Windows.Forms.DataGridView()
        Me.ButtonFast = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 516)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 41)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(863, 41)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(863, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Maintenance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ButtonFast)
        Me.Panel3.Controls.Add(Me.ButtonLookup)
        Me.Panel3.Controls.Add(Me.ButtonSave)
        Me.Panel3.Controls.Add(Me.txtCost)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.txtID)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(863, 189)
        Me.Panel3.TabIndex = 2
        '
        'ButtonLookup
        '
        Me.ButtonLookup.Location = New System.Drawing.Point(268, 34)
        Me.ButtonLookup.Name = "ButtonLookup"
        Me.ButtonLookup.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLookup.TabIndex = 7
        Me.ButtonLookup.Text = "Lookup"
        Me.ButtonLookup.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(162, 137)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(162, 95)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(162, 66)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(226, 20)
        Me.txtName.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(162, 34)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cost :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID :"
        '
        'DataGridViewProducts
        '
        Me.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewProducts.Location = New System.Drawing.Point(0, 230)
        Me.DataGridViewProducts.Name = "DataGridViewProducts"
        Me.DataGridViewProducts.Size = New System.Drawing.Size(863, 286)
        Me.DataGridViewProducts.TabIndex = 3
        '
        'ButtonFast
        '
        Me.ButtonFast.Location = New System.Drawing.Point(349, 34)
        Me.ButtonFast.Name = "ButtonFast"
        Me.ButtonFast.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFast.TabIndex = 8
        Me.ButtonFast.Text = "Lookup qry"
        Me.ButtonFast.UseVisualStyleBackColor = True
        '
        'FormProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 557)
        Me.Controls.Add(Me.DataGridViewProducts)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormProducts"
        Me.Text = "FormProducts"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonSave As Button
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewProducts As DataGridView
    Friend WithEvents ButtonLookup As Button
    Friend WithEvents ButtonFast As Button
End Class
