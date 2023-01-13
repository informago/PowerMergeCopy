<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdFrom = New System.Windows.Forms.Button()
        Me.cmdTo = New System.Windows.Forms.Button()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.pgr01 = New System.Windows.Forms.ProgressBar()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdFrom
        '
        resources.ApplyResources(Me.cmdFrom, "cmdFrom")
        Me.cmdFrom.Name = "cmdFrom"
        Me.cmdFrom.UseVisualStyleBackColor = True
        '
        'cmdTo
        '
        resources.ApplyResources(Me.cmdTo, "cmdTo")
        Me.cmdTo.Name = "cmdTo"
        Me.cmdTo.UseVisualStyleBackColor = True
        '
        'txtFrom
        '
        resources.ApplyResources(Me.txtFrom, "txtFrom")
        Me.txtFrom.Name = "txtFrom"
        '
        'txtTo
        '
        resources.ApplyResources(Me.txtTo, "txtTo")
        Me.txtTo.Name = "txtTo"
        '
        'cmdCopy
        '
        resources.ApplyResources(Me.cmdCopy, "cmdCopy")
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'pgr01
        '
        resources.ApplyResources(Me.pgr01, "pgr01")
        Me.pgr01.Name = "pgr01"
        '
        'cmdExit
        '
        resources.ApplyResources(Me.cmdExit, "cmdExit")
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        resources.ApplyResources(Me.txtFilter, "txtFilter")
        Me.txtFilter.Name = "txtFilter"
        '
        'lblFilter
        '
        resources.ApplyResources(Me.lblFilter, "lblFilter")
        Me.lblFilter.Name = "lblFilter"
        '
        'lstFiles
        '
        resources.ApplyResources(Me.lstFiles, "lstFiles")
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.Name = "lstFiles"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.pgr01)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.cmdTo)
        Me.Controls.Add(Me.cmdFrom)
        Me.Name = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdFrom As Button
    Friend WithEvents cmdTo As Button
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents cmdCopy As Button
    Friend WithEvents pgr01 As ProgressBar
    Friend WithEvents cmdExit As Button
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents lstFiles As ListBox
End Class
