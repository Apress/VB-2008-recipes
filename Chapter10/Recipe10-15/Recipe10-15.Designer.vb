﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe10_15
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
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(92, 216)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(100, 28)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'Recipe10_15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 257)
        Me.Controls.Add(Me.cmdPrint)
        Me.Name = "Recipe10_15"
        Me.Text = "Multi-Page Print"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdPrint As System.Windows.Forms.Button

End Class
