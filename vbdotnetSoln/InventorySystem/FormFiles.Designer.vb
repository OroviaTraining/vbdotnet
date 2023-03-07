<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFiles
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
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnFolder = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtData
        '
        Me.txtData.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtData.Location = New System.Drawing.Point(0, 0)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(800, 413)
        Me.txtData.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(703, 413)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 37)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRead.Location = New System.Drawing.Point(606, 413)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(97, 37)
        Me.btnRead.TabIndex = 2
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnAppend
        '
        Me.btnAppend.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAppend.Location = New System.Drawing.Point(509, 413)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(97, 37)
        Me.btnAppend.TabIndex = 3
        Me.btnAppend.Text = "Append"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "C:\Temp\Training"
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'btnFolder
        '
        Me.btnFolder.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFolder.Location = New System.Drawing.Point(0, 413)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.Size = New System.Drawing.Size(97, 37)
        Me.btnFolder.TabIndex = 4
        Me.btnFolder.Text = "Save To Folder"
        Me.btnFolder.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(412, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Open Dialog"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Location = New System.Drawing.Point(315, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Save Dialog"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFolder)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtData)
        Me.Name = "FormFiles"
        Me.Text = "FormFiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtData As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnAppend As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnFolder As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
