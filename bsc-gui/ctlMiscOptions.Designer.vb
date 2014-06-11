<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlMiscOptions
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
        Me.chkBoxDsbMCS = New System.Windows.Forms.CheckBox()
        Me.chkBoxEnbRAM = New System.Windows.Forms.CheckBox()
        Me.chkBoxDsbParallel = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkBoxDsbMCS
        '
        Me.chkBoxDsbMCS.AutoSize = True
        Me.chkBoxDsbMCS.Location = New System.Drawing.Point(0, 26)
        Me.chkBoxDsbMCS.Name = "chkBoxDsbMCS"
        Me.chkBoxDsbMCS.Size = New System.Drawing.Size(187, 17)
        Me.chkBoxDsbMCS.TabIndex = 22
        Me.chkBoxDsbMCS.Text = "Disable multi-core systems support"
        Me.chkBoxDsbMCS.UseVisualStyleBackColor = True
        '
        'chkBoxEnbRAM
        '
        Me.chkBoxEnbRAM.AutoSize = True
        Me.chkBoxEnbRAM.Location = New System.Drawing.Point(0, 49)
        Me.chkBoxEnbRAM.Name = "chkBoxEnbRAM"
        Me.chkBoxEnbRAM.Size = New System.Drawing.Size(169, 17)
        Me.chkBoxEnbRAM.TabIndex = 21
        Me.chkBoxEnbRAM.Text = "Enable large 2MB RAM pages"
        Me.chkBoxEnbRAM.UseVisualStyleBackColor = True
        '
        'chkBoxDsbParallel
        '
        Me.chkBoxDsbParallel.AutoSize = True
        Me.chkBoxDsbParallel.Location = New System.Drawing.Point(0, 3)
        Me.chkBoxDsbParallel.Name = "chkBoxDsbParallel"
        Me.chkBoxDsbParallel.Size = New System.Drawing.Size(185, 17)
        Me.chkBoxDsbParallel.TabIndex = 20
        Me.chkBoxDsbParallel.Text = "Disable parallel blocks processing"
        Me.chkBoxDsbParallel.UseVisualStyleBackColor = True
        '
        'ctlMiscOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkBoxDsbMCS)
        Me.Controls.Add(Me.chkBoxEnbRAM)
        Me.Controls.Add(Me.chkBoxDsbParallel)
        Me.Name = "ctlMiscOptions"
        Me.Size = New System.Drawing.Size(187, 69)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkBoxDsbMCS As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxEnbRAM As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbParallel As System.Windows.Forms.CheckBox

End Class
