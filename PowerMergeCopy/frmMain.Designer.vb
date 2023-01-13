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
        Me.SuspendLayout()
        '
        'cmdFrom
        '
        Me.cmdFrom.Location = New System.Drawing.Point(22, 24)
        Me.cmdFrom.Name = "cmdFrom"
        Me.cmdFrom.Size = New System.Drawing.Size(225, 69)
        Me.cmdFrom.TabIndex = 0
        Me.cmdFrom.Text = "From"
        Me.cmdFrom.UseVisualStyleBackColor = True
        '
        'cmdTo
        '
        Me.cmdTo.Location = New System.Drawing.Point(22, 117)
        Me.cmdTo.Name = "cmdTo"
        Me.cmdTo.Size = New System.Drawing.Size(225, 69)
        Me.cmdTo.TabIndex = 1
        Me.cmdTo.Text = "To"
        Me.cmdTo.UseVisualStyleBackColor = True
        '
        'txtFrom
        '
        Me.txtFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFrom.Location = New System.Drawing.Point(285, 31)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(1606, 55)
        Me.txtFrom.TabIndex = 2
        '
        'txtTo
        '
        Me.txtTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTo.Location = New System.Drawing.Point(285, 124)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(1606, 55)
        Me.txtTo.TabIndex = 3
        '
        'cmdCopy
        '
        Me.cmdCopy.Location = New System.Drawing.Point(285, 299)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(355, 69)
        Me.cmdCopy.TabIndex = 4
        Me.cmdCopy.Text = "Copy"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'pgr01
        '
        Me.pgr01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgr01.Location = New System.Drawing.Point(22, 399)
        Me.pgr01.Name = "pgr01"
        Me.pgr01.Size = New System.Drawing.Size(1869, 69)
        Me.pgr01.TabIndex = 5
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(1666, 299)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(225, 69)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.Location = New System.Drawing.Point(285, 216)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(1606, 55)
        Me.txtFilter.TabIndex = 7
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(85, 219)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(100, 48)
        Me.lblFilter.TabIndex = 8
        Me.lblFilter.Text = "Filter"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 48.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1938, 914)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.pgr01)
        Me.Controls.Add(Me.cmdCopy)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.cmdTo)
        Me.Controls.Add(Me.cmdFrom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "PowerMergeCopy"
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
End Class
