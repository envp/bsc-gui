<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlOutputFile
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
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.txtOutFile = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Location = New System.Drawing.Point(589, 14)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(100, 22)
        Me.btnSaveFile.TabIndex = 8
        Me.btnSaveFile.Text = "Save As..."
        Me.btnSaveFile.UseVisualStyleBackColor = True
        '
        'txtOutFile
        '
        Me.txtOutFile.Location = New System.Drawing.Point(12, 16)
        Me.txtOutFile.Name = "txtOutFile"
        Me.txtOutFile.Size = New System.Drawing.Size(571, 20)
        Me.txtOutFile.TabIndex = 7
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(9, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(42, 13)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.Text = "Output:"
        '
        'saveFileDialog
        '
        Me.saveFileDialog.Filter = "All files (*.*)|*.*|Block Archives (*.bsc)|*.bsc"
        '
        'ctlOutputFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSaveFile)
        Me.Controls.Add(Me.txtOutFile)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "ctlOutputFile"
        Me.Size = New System.Drawing.Size(698, 36)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveFile As System.Windows.Forms.Button
    Friend WithEvents txtOutFile As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog

End Class
