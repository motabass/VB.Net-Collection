
' **************************************************************
' *
' *   Explorer TreeView Komponenten-Klasse (VB.Net 2005)
' *
' *   Diese Klasse stellt ein Explorer TreeView zur Vergügung.
' *   Mit der überladenen Methode "ShowTree" wird das TreeView
' *   initialisiert.
' *
' *   Februar 2007 - VB-Power.net
' *   http://www.vb-power.net/
' *
' **************************************************************

Option Explicit On
Option Strict On

Imports System.IO

Public Class ExView


    Inherits System.Windows.Forms.TreeView

    Public Sub New()
        Me.Sort()
        Me.HotTracking = True
        Me.HideSelection = False
    End Sub

    Public Sub ShowTree()
        For Each d As DriveInfo In DriveInfo.GetDrives
            Me.ShowTree(d.Name)
        Next
    End Sub

    Public Sub ShowTree(ByVal Path As String)
        Dim nNode As New TreeNode(Path)
        Me.Nodes.Add(nNode)
        Me.FillTreeNode(nNode)
    End Sub

    Public Sub ShowTree(ByVal DriveType As DriveType)
        For Each d As DriveInfo In DriveInfo.GetDrives
            If d.DriveType = DriveType Then
                Me.ShowTree(d.Name)
            End If
        Next
    End Sub

    Private Sub FillTreeNode(ByVal dNode As TreeNode)
        Try
            Dim d As New DirectoryInfo(dNode.FullPath)
            For Each di As DirectoryInfo In d.GetDirectories
                Dim nNode As New TreeNode(di.Name)
                dNode.Nodes.Add(nNode)
                nNode.Nodes.Add("")
            Next
        Catch : End Try
    End Sub

    Protected Overrides Sub OnBeforeExpand( _
      ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)

        Dim n As TreeNode = CType(e.Node, TreeNode)
        If n.Nodes(0).Text = "" Then
            Me.BeginUpdate()
            n.Nodes.Clear()
            Me.FillTreeNode(n)
            Me.EndUpdate()
        End If
        MyBase.OnBeforeExpand(e)
    End Sub

End Class
