﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScreenSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GraphicsToolStripMenuItem, Me.ScreenSizeToolStripMenuItem, Me.ProcessorsToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'GraphicsToolStripMenuItem
        '
        Me.GraphicsToolStripMenuItem.Name = "GraphicsToolStripMenuItem"
        Me.GraphicsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GraphicsToolStripMenuItem.Text = "Graphics"
        '
        'ScreenSizeToolStripMenuItem
        '
        Me.ScreenSizeToolStripMenuItem.Name = "ScreenSizeToolStripMenuItem"
        Me.ScreenSizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ScreenSizeToolStripMenuItem.Text = "Screen Size"
        '
        'ProcessorsToolStripMenuItem
        '
        Me.ProcessorsToolStripMenuItem.Name = "ProcessorsToolStripMenuItem"
        Me.ProcessorsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProcessorsToolStripMenuItem.Text = "Processors"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraphicsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScreenSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcessorsToolStripMenuItem As ToolStripMenuItem
End Class
