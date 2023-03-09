<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFileProcessing
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgvCountry = New System.Windows.Forms.DataGridView()
        Me.btnMethod1 = New System.Windows.Forms.Button()
        Me.btnMethod2 = New System.Windows.Forms.Button()
        Me.btnMethod3 = New System.Windows.Forms.Button()
        Me.btnMethod4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnMethod4)
        Me.Panel1.Controls.Add(Me.btnMethod3)
        Me.Panel1.Controls.Add(Me.btnMethod2)
        Me.Panel1.Controls.Add(Me.btnMethod1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnChoose)
        Me.Panel1.Controls.Add(Me.txtFile)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 81)
        Me.Panel1.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(818, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnChoose
        '
        Me.btnChoose.Location = New System.Drawing.Point(469, 8)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(75, 23)
        Me.btnChoose.TabIndex = 2
        Me.btnChoose.Text = "Choose ..."
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(59, 10)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(404, 20)
        Me.txtFile.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "C:\Ramith\PythonMadeEasy\Papa\Data"
        '
        'dgvCountry
        '
        Me.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCountry.Location = New System.Drawing.Point(0, 81)
        Me.dgvCountry.Name = "dgvCountry"
        Me.dgvCountry.Size = New System.Drawing.Size(915, 369)
        Me.dgvCountry.TabIndex = 1
        '
        'btnMethod1
        '
        Me.btnMethod1.Enabled = False
        Me.btnMethod1.Location = New System.Drawing.Point(59, 52)
        Me.btnMethod1.Name = "btnMethod1"
        Me.btnMethod1.Size = New System.Drawing.Size(75, 23)
        Me.btnMethod1.TabIndex = 4
        Me.btnMethod1.Text = "Method 1"
        Me.btnMethod1.UseVisualStyleBackColor = True
        '
        'btnMethod2
        '
        Me.btnMethod2.Enabled = False
        Me.btnMethod2.Location = New System.Drawing.Point(140, 52)
        Me.btnMethod2.Name = "btnMethod2"
        Me.btnMethod2.Size = New System.Drawing.Size(75, 23)
        Me.btnMethod2.TabIndex = 5
        Me.btnMethod2.Text = "Method 2"
        Me.btnMethod2.UseVisualStyleBackColor = True
        '
        'btnMethod3
        '
        Me.btnMethod3.Enabled = False
        Me.btnMethod3.Location = New System.Drawing.Point(221, 52)
        Me.btnMethod3.Name = "btnMethod3"
        Me.btnMethod3.Size = New System.Drawing.Size(75, 23)
        Me.btnMethod3.TabIndex = 6
        Me.btnMethod3.Text = "Method 3"
        Me.btnMethod3.UseVisualStyleBackColor = True
        '
        'btnMethod4
        '
        Me.btnMethod4.Enabled = False
        Me.btnMethod4.Location = New System.Drawing.Point(302, 52)
        Me.btnMethod4.Name = "btnMethod4"
        Me.btnMethod4.Size = New System.Drawing.Size(75, 23)
        Me.btnMethod4.TabIndex = 7
        Me.btnMethod4.Text = "Method 4"
        Me.btnMethod4.UseVisualStyleBackColor = True
        '
        'FormFileProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 450)
        Me.Controls.Add(Me.dgvCountry)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormFileProcessing"
        Me.Text = "FormFileProcessing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnChoose As Button
    Friend WithEvents txtFile As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgvCountry As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnMethod2 As Button
    Friend WithEvents btnMethod1 As Button
    Friend WithEvents btnMethod3 As Button
    Friend WithEvents btnMethod4 As Button
End Class
