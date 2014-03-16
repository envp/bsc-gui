<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlLZPOpts
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
        Me.grpBoxLZP = New System.Windows.Forms.GroupBox()
        Me.numDictSize = New System.Windows.Forms.NumericUpDown()
        Me.numMatchLength = New System.Windows.Forms.NumericUpDown()
        Me.lblLZPMatchLength = New System.Windows.Forms.Label()
        Me.lblLZPDictSize = New System.Windows.Forms.Label()
        Me.grpBoxLZP.SuspendLayout()
        CType(Me.numDictSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMatchLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxLZP
        '
        Me.grpBoxLZP.Controls.Add(Me.numDictSize)
        Me.grpBoxLZP.Controls.Add(Me.numMatchLength)
        Me.grpBoxLZP.Controls.Add(Me.lblLZPMatchLength)
        Me.grpBoxLZP.Controls.Add(Me.lblLZPDictSize)
        Me.grpBoxLZP.Location = New System.Drawing.Point(3, 3)
        Me.grpBoxLZP.Name = "grpBoxLZP"
        Me.grpBoxLZP.Size = New System.Drawing.Size(313, 89)
        Me.grpBoxLZP.TabIndex = 9
        Me.grpBoxLZP.TabStop = False
        Me.grpBoxLZP.Text = "Lempel-Ziv Preprocessing"
        '
        'numDictSize
        '
        Me.numDictSize.BackColor = System.Drawing.SystemColors.Window
        Me.numDictSize.Location = New System.Drawing.Point(207, 30)
        Me.numDictSize.Maximum = New Decimal(New Integer() {28, 0, 0, 0})
        Me.numDictSize.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numDictSize.Name = "numDictSize"
        Me.numDictSize.Size = New System.Drawing.Size(100, 20)
        Me.numDictSize.TabIndex = 9
        Me.numDictSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDictSize.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'numMatchLength
        '
        Me.numMatchLength.Location = New System.Drawing.Point(207, 58)
        Me.numMatchLength.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numMatchLength.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numMatchLength.Name = "numMatchLength"
        Me.numMatchLength.Size = New System.Drawing.Size(100, 20)
        Me.numMatchLength.TabIndex = 8
        Me.numMatchLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMatchLength.ThousandsSeparator = True
        Me.numMatchLength.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'lblLZPMatchLength
        '
        Me.lblLZPMatchLength.AutoSize = True
        Me.lblLZPMatchLength.Location = New System.Drawing.Point(6, 58)
        Me.lblLZPMatchLength.Name = "lblLZPMatchLength"
        Me.lblLZPMatchLength.Size = New System.Drawing.Size(142, 13)
        Me.lblLZPMatchLength.TabIndex = 7
        Me.lblLZPMatchLength.Text = "Minimum Match Length (bits)"
        '
        'lblLZPDictSize
        '
        Me.lblLZPDictSize.AutoSize = True
        Me.lblLZPDictSize.Location = New System.Drawing.Point(6, 32)
        Me.lblLZPDictSize.Name = "lblLZPDictSize"
        Me.lblLZPDictSize.Size = New System.Drawing.Size(102, 13)
        Me.lblLZPDictSize.TabIndex = 6
        Me.lblLZPDictSize.Text = "Dictionary Size (bits)"
        '
        'ctlLZPOpts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpBoxLZP)
        Me.Name = "ctlLZPOpts"
        Me.Size = New System.Drawing.Size(319, 95)
        Me.grpBoxLZP.ResumeLayout(False)
        Me.grpBoxLZP.PerformLayout()
        CType(Me.numDictSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMatchLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBoxLZP As System.Windows.Forms.GroupBox
    Friend WithEvents numDictSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMatchLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLZPMatchLength As System.Windows.Forms.Label
    Friend WithEvents lblLZPDictSize As System.Windows.Forms.Label

End Class
