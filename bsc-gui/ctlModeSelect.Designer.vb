<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlModeSelect
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.comboMode = New System.Windows.Forms.ComboBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comboMode
        '
        Me.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMode.FormattingEnabled = True
        Me.comboMode.ItemHeight = 13
        Me.comboMode.Items.AddRange(New Object() {"Compression", "Decompression"})
        Me.comboMode.Location = New System.Drawing.Point(45, 3)
        Me.comboMode.Name = "comboMode"
        Me.comboMode.Size = New System.Drawing.Size(120, 21)
        Me.comboMode.TabIndex = 9
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(2, 6)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(37, 13)
        Me.lblMode.TabIndex = 8
        Me.lblMode.Text = "Mode:"
        '
        'ctlModeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.comboMode)
        Me.Controls.Add(Me.lblMode)
        Me.Name = "ctlModeSelect"
        Me.Size = New System.Drawing.Size(166, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboMode As System.Windows.Forms.ComboBox
    Friend WithEvents lblMode As System.Windows.Forms.Label

End Class
