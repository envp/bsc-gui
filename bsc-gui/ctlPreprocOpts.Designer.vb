<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlPreprocOpts
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
        Me.ctlLZPOpts = New bsc_gui.ctlLZPOpts()
        Me.grpBoxPreproc.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxPreproc
        '
        Me.grpBoxPreproc.Controls.Add(Me.ctlLZPOpts)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxEnbStructData)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxDsbLZP)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxEnbSegments)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxDsbPreoproc)
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
        'ctlLZPOpts
        '
        Me.ctlLZPOpts.Location = New System.Drawing.Point(3, 108)
        Me.ctlLZPOpts.Name = "ctlLZPOpts"
        Me.ctlLZPOpts.Size = New System.Drawing.Size(319, 95)
        Me.ctlLZPOpts.TabIndex = 4
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBoxPreproc As System.Windows.Forms.GroupBox
    Friend WithEvents chkBoxEnbStructData As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbLZP As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxEnbSegments As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbPreoproc As System.Windows.Forms.CheckBox
    Friend WithEvents ctlLZPOpts As bsc_gui.ctlLZPOpts

End Class
