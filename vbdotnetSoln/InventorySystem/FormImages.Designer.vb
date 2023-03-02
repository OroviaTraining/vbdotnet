<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormImages
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employees")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PF")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bacs")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edupay", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode4})
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvMain = New System.Windows.Forms.TreeView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvMain)
        Me.SplitContainer1.Size = New System.Drawing.Size(1165, 546)
        Me.SplitContainer1.SplitterDistance = 387
        Me.SplitContainer1.TabIndex = 0
        '
        'tvMain
        '
        Me.tvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvMain.Location = New System.Drawing.Point(0, 0)
        Me.tvMain.Name = "tvMain"
        TreeNode1.Name = "Node1"
        TreeNode1.Tag = "10"
        TreeNode1.Text = "Employees"
        TreeNode2.Name = "Node5"
        TreeNode2.Tag = "12"
        TreeNode2.Text = "PF"
        TreeNode3.Name = "Node7"
        TreeNode3.Tag = "13"
        TreeNode3.Text = "Bacs"
        TreeNode4.Name = "Node4"
        TreeNode4.Tag = "11"
        TreeNode4.Text = "Reports"
        TreeNode5.Name = "Node0"
        TreeNode5.Text = "Edupay"
        Me.tvMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5})
        Me.tvMain.Size = New System.Drawing.Size(387, 546)
        Me.tvMain.TabIndex = 0
        '
        'FormImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 546)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormImages"
        Me.Text = "FormImages"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tvMain As TreeView
End Class
