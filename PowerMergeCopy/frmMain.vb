Imports System.ComponentModel

Public Class frmMain

#Region "Environment"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Registry.CurrentUser.CreateSubKey("Larsoft\PowerMergeCopy")
        txtFrom.Text = My.Computer.Registry.CurrentUser.GetValue("From", "")
        txtTo.Text = My.Computer.Registry.CurrentUser.GetValue("To", "")
        txtFilter.Text = My.Computer.Registry.CurrentUser.GetValue("Filter", "*.*")
    End Sub

    Private Sub cmdFrom_Click(sender As Object, e As EventArgs) Handles cmdFrom.Click
        Dim fOpen As New Windows.Forms.FolderBrowserDialog
        fOpen.ShowDialog()
        txtFrom.Text = fOpen.SelectedPath
    End Sub

    Private Sub cmdTo_Click(sender As Object, e As EventArgs) Handles cmdTo.Click
        Dim fOpen As New Windows.Forms.FolderBrowserDialog
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
    End Sub

#End Region

#Region "Action!"

    Private Sub CopyItens(DirFrom As String, DirTo As String, Filter As String)

    End Sub

#End Region

End Class