﻿Imports System
Imports System.IO
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe09-02.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe09_02

    Private Sub Recipe09_02_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '  Get all the files in the root directory/
        Dim rootDirectory As New DirectoryInfo("C:\")
        Dim files As FileInfo() = rootDirectory.GetFiles

        '  Display the name of each file in the ListView.
        For Each file As FileInfo In files
            Dim item As ListViewItem = listView1.Items.Add(file.Name)
            item.ImageIndex = 0

            '  Associate each FileInfo object with its ListViewItem.
            item.Tag = file
        Next

    End Sub
    Private Sub listView1_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles listView1.ItemActivate

        '  Get information from the linked FileInfo object and display
        '  it using a MessageBox.
        Dim item As ListViewItem = DirectCast(sender, ListView).SelectedItems(0)
        Dim file As FileInfo = DirectCast(item.Tag, FileInfo)
        Dim info As String = String.Format("{0} is {1} bytes.", file.FullName, file.Length)

        MessageBox.Show(info, "File Information")

    End Sub

End Class