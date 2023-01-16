Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Public Class frmMain

#Region "Environment"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Registry.CurrentUser.CreateSubKey("Larsoft\PowerMergeCopy")
        txtFrom.Text = My.Computer.Registry.CurrentUser.GetValue("From", "")
        txtTo.Text = My.Computer.Registry.CurrentUser.GetValue("To", "")
        txtFilter.Text = My.Computer.Registry.CurrentUser.GetValue("Filter", "*.*")
    End Sub

    Private Sub cmdFrom_Click(sender As Object, e As EventArgs) Handles cmdFrom.Click
        Dim fOpen As New System.Windows.Forms.FolderBrowserDialog
        fOpen.ShowDialog()
        txtFrom.Text = fOpen.SelectedPath
        RefreshListFiles()
    End Sub

    Private Sub txtFrom_LostFocus(sender As Object, e As EventArgs) Handles txtFrom.LostFocus
        RefreshListFiles()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        RefreshListFiles()
    End Sub

    Private Sub RefreshListFiles()
        Dim vFiles() As String = {}
        lstFiles.DataSource = Nothing
        If Directory.Exists(txtFrom.Text) Then
            vFiles = Directory.GetFiles(txtFrom.Text, txtFilter.Text, IO.SearchOption.AllDirectories)
        End If
        lstFiles.DataSource = vFiles
    End Sub

    Private Sub cmdTo_Click(sender As Object, e As EventArgs) Handles cmdTo.Click
        Dim fOpen As New System.Windows.Forms.FolderBrowserDialog
        fOpen.ShowDialog()
        txtTo.Text = fOpen.SelectedPath
    End Sub

    Private Sub cmdCopy_Click(sender As Object, e As EventArgs) Handles cmdCopy.Click
        CopyItens(txtFrom.Text, txtTo.Text, txtFilter.Text)
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Computer.Registry.CurrentUser.SetValue("From", txtFrom.Text)
        My.Computer.Registry.CurrentUser.SetValue("To", txtTo.Text)
        My.Computer.Registry.CurrentUser.SetValue("Filter", txtFilter.Text)
    End Sub

#End Region

#Region "Action!"

    Private Sub CopyItens(DirFrom As String, DirTo As String, Filter As String)
        Dim vSep As Integer = 0
        Dim vFileName As String = String.Empty
        Dim vFileDest As String = String.Empty
        Dim vEx As String = String.Empty
        Dim vFiles() As String = Directory.GetFiles(DirFrom, Filter, IO.SearchOption.AllDirectories)
        Dim vProg As Integer = 0

        lstFiles.DataSource = vFiles
        pgr01.Maximum = vFiles.Length

        If vFiles.Length = 0 Then
            vEx += "There is no files no process." + ControlChars.NewLine
        End If

        If Directory.Exists(DirTo) = False Then
            vEx += "The destination foldes does not exist." + ControlChars.NewLine
        End If

        If vEx > "" Then
            MessageBox.Show(vEx, "PowerMergeCopy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        For Each vSource As String In vFiles
            vSep = vSource.LastIndexOf("\")
            vFileName = vSource.Substring(vSep)
            vFileDest = DirTo + vFileName
            If File.Exists(vFileDest) = False Then
                File.Copy(vSource, vFileDest)
            End If

            lstFiles.SelectedIndex = vProg
            pgr01.Value = vProg
            vProg += 1
            Me.Refresh()
        Next

        pgr01.Value = pgr01.Maximum
        MessageBox.Show("Cópia concluída", "PowerMergeCopy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

End Class