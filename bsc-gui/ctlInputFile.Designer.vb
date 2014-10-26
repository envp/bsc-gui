<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlInputFile
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
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtInFile = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "All files (*.*)|*.*|Text (*.txt)|*.txt|Documents (*.doc, *.docx)|*.doc*|Excel (*." & _
    "xls, *.xlsx)|*.xls*|Powerpoint (*.ppt, *.pptx)|*.ppt*|PDF (*.pdf)|*.pdf"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(589, 14)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(100, 22)
        Me.btnOpenFile.TabIndex = 7
        Me.btnOpenFile.Text = "Open File..."
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtInFile
        '
        Me.txtInFile.Location = New System.Drawing.Point(12, 16)
        Me.txtInFile.Name = "txtInFile"
        Me.txtInFile.Size = New System.Drawing.Size(571, 20)
        Me.txtInFile.TabIndex = 6
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(9, 0)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(34, 13)
        Me.lblInput.TabIndex = 5
        Me.lblInput.Text = "Input:"
        '
        'ctlInputFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.txtInFile)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "ctlInputFile"
        Me.Size = New System.Drawing.Size(698, 36)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents txtInFile As System.Windows.Forms.TextBox
    Friend WithEvents lblInput As System.Windows.Forms.Label

End Class
