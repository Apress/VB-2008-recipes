﻿Imports System
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe09-07.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe09_07

    Private counter As Integer = 0
    '  Button click event handler adds 20 new items to the ListBox.
    Private Sub cmdTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTest.Click

        '  Add 20 items.
        For i As Integer = 1 To 20
            counter += 1
            listBox1.Items.Add("Item " & counter.ToString())
        Next

        '  Set the TopIndex  property of the ListBox to ensure the
        '  most recently added items are visible.  SelectedIndex
        '  is then used to select the new item.
        listBox1.TopIndex = listBox1.Items.Count - 1
        listBox1.SelectedIndex = listBox1.Items.Count - 1

    End Sub

End Class
