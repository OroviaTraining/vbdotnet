<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim AmddateLabel As System.Windows.Forms.Label
        Dim AmduserLabel As System.Windows.Forms.Label
        Dim CredateLabel As System.Windows.Forms.Label
        Dim CreuserLabel As System.Windows.Forms.Label
        Dim GnameLabel As System.Windows.Forms.Label
        Dim SeqnoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GraphicBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GraphicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GraphicBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AmddateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmduserTextBox = New System.Windows.Forms.TextBox()
        Me.CredateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CreuserTextBox = New System.Windows.Forms.TextBox()
        Me.GnameTextBox = New System.Windows.Forms.TextBox()
        Me.SeqnoTextBox = New System.Windows.Forms.TextBox()
        AmddateLabel = New System.Windows.Forms.Label()
        AmduserLabel = New System.Windows.Forms.Label()
        CredateLabel = New System.Windows.Forms.Label()
        CreuserLabel = New System.Windows.Forms.Label()
        GnameLabel = New System.Windows.Forms.Label()
        SeqnoLabel = New System.Windows.Forms.Label()
        CType(Me.GraphicBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GraphicBindingNavigator.SuspendLayout()
        CType(Me.GraphicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmddateLabel
        '
        AmddateLabel.AutoSize = True
        AmddateLabel.Location = New System.Drawing.Point(222, 91)
        AmddateLabel.Name = "AmddateLabel"
        AmddateLabel.Size = New System.Drawing.Size(51, 13)
        AmddateLabel.TabIndex = 1
        AmddateLabel.Text = "amddate:"
        '
        'AmduserLabel
        '
        AmduserLabel.AutoSize = True
        AmduserLabel.Location = New System.Drawing.Point(222, 116)
        AmduserLabel.Name = "AmduserLabel"
        AmduserLabel.Size = New System.Drawing.Size(50, 13)
        AmduserLabel.TabIndex = 3
        AmduserLabel.Text = "amduser:"
        '
        'CredateLabel
        '
        CredateLabel.AutoSize = True
        CredateLabel.Location = New System.Drawing.Point(222, 143)
        CredateLabel.Name = "CredateLabel"
        CredateLabel.Size = New System.Drawing.Size(46, 13)
        CredateLabel.TabIndex = 5
        CredateLabel.Text = "credate:"
        '
        'CreuserLabel
        '
        CreuserLabel.AutoSize = True
        CreuserLabel.Location = New System.Drawing.Point(222, 168)
        CreuserLabel.Name = "CreuserLabel"
        CreuserLabel.Size = New System.Drawing.Size(45, 13)
        CreuserLabel.TabIndex = 7
        CreuserLabel.Text = "creuser:"
        '
        'GnameLabel
        '
        GnameLabel.AutoSize = True
        GnameLabel.Location = New System.Drawing.Point(222, 194)
        GnameLabel.Name = "GnameLabel"
        GnameLabel.Size = New System.Drawing.Size(42, 13)
        GnameLabel.TabIndex = 9
        GnameLabel.Text = "gname:"
        '
        'SeqnoLabel
        '
        SeqnoLabel.AutoSize = True
        SeqnoLabel.Location = New System.Drawing.Point(222, 220)
        SeqnoLabel.Name = "SeqnoLabel"
        SeqnoLabel.Size = New System.Drawing.Size(39, 13)
        SeqnoLabel.TabIndex = 11
        SeqnoLabel.Text = "seqno:"
        '
        'GraphicBindingNavigator
        '
        Me.GraphicBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GraphicBindingNavigator.BindingSource = Me.GraphicBindingSource
        Me.GraphicBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GraphicBindingNavigator.DeleteItem = Nothing
        Me.GraphicBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.GraphicBindingNavigatorSaveItem})
        Me.GraphicBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GraphicBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GraphicBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GraphicBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GraphicBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GraphicBindingNavigator.Name = "GraphicBindingNavigator"
        Me.GraphicBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GraphicBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.GraphicBindingNavigator.TabIndex = 0
        Me.GraphicBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'GraphicBindingSource
        '
        Me.GraphicBindingSource.DataSource = GetType(InventorySystem.Graphic)
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'GraphicBindingNavigatorSaveItem
        '
        Me.GraphicBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GraphicBindingNavigatorSaveItem.Image = CType(resources.GetObject("GraphicBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GraphicBindingNavigatorSaveItem.Name = "GraphicBindingNavigatorSaveItem"
        Me.GraphicBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GraphicBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AmddateDateTimePicker
        '
        Me.AmddateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GraphicBindingSource, "amddate", True))
        Me.AmddateDateTimePicker.Location = New System.Drawing.Point(279, 87)
        Me.AmddateDateTimePicker.Name = "AmddateDateTimePicker"
        Me.AmddateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AmddateDateTimePicker.TabIndex = 2
        '
        'AmduserTextBox
        '
        Me.AmduserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GraphicBindingSource, "amduser", True))
        Me.AmduserTextBox.Location = New System.Drawing.Point(279, 113)
        Me.AmduserTextBox.Name = "AmduserTextBox"
        Me.AmduserTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmduserTextBox.TabIndex = 4
        '
        'CredateDateTimePicker
        '
        Me.CredateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GraphicBindingSource, "credate", True))
        Me.CredateDateTimePicker.Location = New System.Drawing.Point(279, 139)
        Me.CredateDateTimePicker.Name = "CredateDateTimePicker"
        Me.CredateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CredateDateTimePicker.TabIndex = 6
        '
        'CreuserTextBox
        '
        Me.CreuserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GraphicBindingSource, "creuser", True))
        Me.CreuserTextBox.Location = New System.Drawing.Point(279, 165)
        Me.CreuserTextBox.Name = "CreuserTextBox"
        Me.CreuserTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CreuserTextBox.TabIndex = 8
        '
        'GnameTextBox
        '
        Me.GnameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GnameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.GnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GraphicBindingSource, "gname", True))
        Me.GnameTextBox.Location = New System.Drawing.Point(279, 191)
        Me.GnameTextBox.Name = "GnameTextBox"
        Me.GnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GnameTextBox.TabIndex = 10
        '
        'SeqnoTextBox
        '
        Me.SeqnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GraphicBindingSource, "seqno", True))
        Me.SeqnoTextBox.Location = New System.Drawing.Point(279, 217)
        Me.SeqnoTextBox.Name = "SeqnoTextBox"
        Me.SeqnoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SeqnoTextBox.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(AmddateLabel)
        Me.Controls.Add(Me.AmddateDateTimePicker)
        Me.Controls.Add(AmduserLabel)
        Me.Controls.Add(Me.AmduserTextBox)
        Me.Controls.Add(CredateLabel)
        Me.Controls.Add(Me.CredateDateTimePicker)
        Me.Controls.Add(CreuserLabel)
        Me.Controls.Add(Me.CreuserTextBox)
        Me.Controls.Add(GnameLabel)
        Me.Controls.Add(Me.GnameTextBox)
        Me.Controls.Add(SeqnoLabel)
        Me.Controls.Add(Me.SeqnoTextBox)
        Me.Controls.Add(Me.GraphicBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.GraphicBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GraphicBindingNavigator.ResumeLayout(False)
        Me.GraphicBindingNavigator.PerformLayout()
        CType(Me.GraphicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GraphicBindingSource As BindingSource
    Friend WithEvents GraphicBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GraphicBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AmddateDateTimePicker As DateTimePicker
    Friend WithEvents AmduserTextBox As TextBox
    Friend WithEvents CredateDateTimePicker As DateTimePicker
    Friend WithEvents CreuserTextBox As TextBox
    Friend WithEvents GnameTextBox As TextBox
    Friend WithEvents SeqnoTextBox As TextBox
End Class
