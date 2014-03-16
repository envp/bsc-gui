<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPreprocOpts
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
        Me.grpBoxPreproc = New System.Windows.Forms.GroupBox()
        Me.chkBoxEnbStructData = New System.Windows.Forms.CheckBox()
        Me.chkBoxDsbLZP = New System.Windows.Forms.CheckBox()
        Me.chkBoxEnbSegments = New System.Windows.Forms.CheckBox()
        Me.chkBoxDsbPreoproc = New System.Windows.Forms.CheckBox()
        Me.grpBoxLZP = New System.Windows.Forms.GroupBox()
        Me.numDictSize = New System.Windows.Forms.NumericUpDown()
        Me.numMatchLength = New System.Windows.Forms.NumericUpDown()
        Me.lblLZPMatchLength = New System.Windows.Forms.Label()
        Me.lblLZPDictSize = New System.Windows.Forms.Label()
        Me.grpBoxPreproc.SuspendLayout()
        Me.grpBoxLZP.SuspendLayout()
        CType(Me.numDictSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMatchLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxPreproc
        '
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxEnbStructData)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxDsbLZP)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxEnbSegments)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxDsbPreoproc)
        Me.grpBoxPreproc.Controls.Add(Me.grpBoxLZP)
        Me.grpBoxPreproc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBoxPreproc.Location = New System.Drawing.Point(0, 0)
        Me.grpBoxPreproc.Name = "grpBoxPreproc"
        Me.grpBoxPreproc.Size = New System.Drawing.Size(325, 206)
        Me.grpBoxPreproc.TabIndex = 1
        Me.grpBoxPreproc.TabStop = False
        Me.grpBoxPreproc.Text = "Preprocessing"
        '
        'chkBoxEnbStructData
        '
        Me.chkBoxEnbStructData.AutoSize = True
        Me.chkBoxEnbStructData.Location = New System.Drawing.Point(6, 65)
        Me.chkBoxEnbStructData.Name = "chkBoxEnbStructData"
        Me.chkBoxEnbStructData.Size = New System.Drawing.Size(183, 17)
        Me.chkBoxEnbStructData.TabIndex = 3
        Me.chkBoxEnbStructData.Text = "Enable structured data reordering"
        Me.chkBoxEnbStructData.UseVisualStyleBackColor = True
        '
        'chkBoxDsbLZP
        '
        Me.chkBoxDsbLZP.AutoSize = True
        Me.chkBoxDsbLZP.Location = New System.Drawing.Point(6, 88)
        Me.chkBoxDsbLZP.Name = "chkBoxDsbLZP"
        Me.chkBoxDsbLZP.Size = New System.Drawing.Size(185, 17)
        Me.chkBoxDsbLZP.TabIndex = 2
        Me.chkBoxDsbLZP.Text = "Disable Lempel-Ziv preprocessing"
        Me.chkBoxDsbLZP.UseVisualStyleBackColor = True
        '
        'chkBoxEnbSegments
        '
        Me.chkBoxEnbSegments.AutoSize = True
        Me.chkBoxEnbSegments.Location = New System.Drawing.Point(6, 42)
        Me.chkBoxEnbSegments.Name = "chkBoxEnbSegments"
        Me.chkBoxEnbSegments.Size = New System.Drawing.Size(225, 17)
        Me.chkBoxEnbSegments.TabIndex = 1
        Me.chkBoxEnbSegments.Text = "Enable segmentation (adaptive block size)"
        Me.chkBoxEnbSegments.UseVisualStyleBackColor = True
        '
        'chkBoxDsbPreoproc
        '
        Me.chkBoxDsbPreoproc.AutoSize = True
        Me.chkBoxDsbPreoproc.Location = New System.Drawing.Point(6, 19)
        Me.chkBoxDsbPreoproc.Name = "chkBoxDsbPreoproc"
        Me.chkBoxDsbPreoproc.Size = New System.Drawing.Size(198, 17)
        Me.chkBoxDsbPreoproc.TabIndex = 0
        Me.chkBoxDsbPreoproc.Text = "Disable all preprocessing techniques"
        Me.chkBoxDsbPreoproc.UseVisualStyleBackColor = True
        '
        'grpBoxLZP
        '
        Me.grpBoxLZP.Controls.Add(Me.numDictSize)
        Me.grpBoxLZP.Controls.Add(Me.numMatchLength)
        Me.grpBoxLZP.Controls.Add(Me.lblLZPMatchLength)
        Me.grpBoxLZP.Controls.Add(Me.lblLZPDictSize)
        Me.grpBoxLZP.Location = New System.Drawing.Point(6, 111)
        Me.grpBoxLZP.Name = "grpBoxLZP"
        Me.grpBoxLZP.Size = New System.Drawing.Size(313, 89)
        Me.grpBoxLZP.TabIndex = 8
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
        'ctlPreprocOpts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpBoxPreproc)
        Me.Name = "ctlPreprocOpts"
        Me.Size = New System.Drawing.Size(325, 206)
        Me.grpBoxPreproc.ResumeLayout(False)
        Me.grpBoxPreproc.PerformLayout()
        Me.grpBoxLZP.ResumeLayout(False)
        Me.grpBoxLZP.PerformLayout()
        CType(Me.numDictSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMatchLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBoxPreproc As System.Windows.Forms.GroupBox
    Friend WithEvents chkBoxEnbStructData As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbLZP As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxEnbSegments As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbPreoproc As System.Windows.Forms.CheckBox
    Friend WithEvents grpBoxLZP As System.Windows.Forms.GroupBox
    Friend WithEvents numDictSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMatchLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLZPMatchLength As System.Windows.Forms.Label
    Friend WithEvents lblLZPDictSize As System.Windows.Forms.Label

End Class
