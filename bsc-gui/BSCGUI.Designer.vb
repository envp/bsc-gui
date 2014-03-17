<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BSCGUI
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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.tableCOpts = New System.Windows.Forms.TableLayoutPanel()
        Me.ctlMiscOptions = New bsc_gui.ctlMiscOptions()
        Me.ctlBtnGrpConfirm = New bsc_gui.ctlBtnGrpConfirm()
        Me.ctlModeSelect = New bsc_gui.ctlModeSelect()
        Me.ctlOutputFile = New bsc_gui.ctlOutputFile()
        Me.ctlInputFile = New bsc_gui.ctlInputFile()
        Me.ctlPreprocOpts = New bsc_gui.ctlPreprocOpts()
        Me.ctlBlkSortingOpts = New bsc_gui.ctlBlkSortingOpts()
        Me.prgBarTask = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.MainPanel.SuspendLayout()
        Me.tableCOpts.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.lblStatus)
        Me.MainPanel.Controls.Add(Me.ctlMiscOptions)
        Me.MainPanel.Controls.Add(Me.prgBarTask)
        Me.MainPanel.Controls.Add(Me.ctlBtnGrpConfirm)
        Me.MainPanel.Controls.Add(Me.ctlModeSelect)
        Me.MainPanel.Controls.Add(Me.ctlOutputFile)
        Me.MainPanel.Controls.Add(Me.ctlInputFile)
        Me.MainPanel.Controls.Add(Me.tableCOpts)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(704, 442)
        Me.MainPanel.TabIndex = 0
        '
        'tableCOpts
        '
        Me.tableCOpts.ColumnCount = 2
        Me.tableCOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.Controls.Add(Me.ctlPreprocOpts, 0, 0)
        Me.tableCOpts.Controls.Add(Me.ctlBlkSortingOpts, 1, 0)
        Me.tableCOpts.Location = New System.Drawing.Point(15, 130)
        Me.tableCOpts.Name = "tableCOpts"
        Me.tableCOpts.RowCount = 1
        Me.tableCOpts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.Size = New System.Drawing.Size(662, 212)
        Me.tableCOpts.TabIndex = 6
        '
        'ctlMiscOptions
        '
        Me.ctlMiscOptions.Location = New System.Drawing.Point(15, 345)
        Me.ctlMiscOptions.Name = "ctlMiscOptions"
        Me.ctlMiscOptions.Size = New System.Drawing.Size(187, 69)
        Me.ctlMiscOptions.TabIndex = 27
        '
        'ctlBtnGrpConfirm
        '
        Me.ctlBtnGrpConfirm.Location = New System.Drawing.Point(486, 388)
        Me.ctlBtnGrpConfirm.Name = "ctlBtnGrpConfirm"
        Me.ctlBtnGrpConfirm.Size = New System.Drawing.Size(206, 23)
        Me.ctlBtnGrpConfirm.TabIndex = 25
        '
        'ctlModeSelect
        '
        Me.ctlModeSelect.Location = New System.Drawing.Point(12, 98)
        Me.ctlModeSelect.Name = "ctlModeSelect"
        Me.ctlModeSelect.Size = New System.Drawing.Size(166, 26)
        Me.ctlModeSelect.TabIndex = 24
        '
        'ctlOutputFile
        '
        Me.ctlOutputFile.Location = New System.Drawing.Point(3, 54)
        Me.ctlOutputFile.Name = "ctlOutputFile"
        Me.ctlOutputFile.Size = New System.Drawing.Size(698, 36)
        Me.ctlOutputFile.TabIndex = 23
        '
        'ctlInputFile
        '
        Me.ctlInputFile.Location = New System.Drawing.Point(3, 12)
        Me.ctlInputFile.Name = "ctlInputFile"
        Me.ctlInputFile.Size = New System.Drawing.Size(698, 36)
        Me.ctlInputFile.TabIndex = 22
        '
        'ctlPreprocOpts
        '
        Me.ctlPreprocOpts.Location = New System.Drawing.Point(3, 3)
        Me.ctlPreprocOpts.Name = "ctlPreprocOpts"
        Me.ctlPreprocOpts.Size = New System.Drawing.Size(325, 206)
        Me.ctlPreprocOpts.TabIndex = 13
        '
        'ctlBlkSortingOpts
        '
        Me.ctlBlkSortingOpts.Location = New System.Drawing.Point(334, 3)
        Me.ctlBlkSortingOpts.Name = "ctlBlkSortingOpts"
        Me.ctlBlkSortingOpts.Size = New System.Drawing.Size(325, 206)
        Me.ctlBlkSortingOpts.TabIndex = 14
        '
        'prgBarTask
        '
        Me.prgBarTask.Location = New System.Drawing.Point(15, 417)
        Me.prgBarTask.Name = "prgBarTask"
        Me.prgBarTask.Size = New System.Drawing.Size(677, 4)
        Me.prgBarTask.Step = 1
        Me.prgBarTask.TabIndex = 26
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 424)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblStatus.TabIndex = 28
        Me.lblStatus.Text = "Label1"
        '
        'BSCGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 442)
        Me.Controls.Add(Me.MainPanel)
        Me.MaximumSize = New System.Drawing.Size(720, 480)
        Me.MinimumSize = New System.Drawing.Size(720, 480)
        Me.Name = "BSCGUI"
        Me.Text = "Block Sorting Compressor"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.tableCOpts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents tableCOpts As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ctlInputFile As bsc_gui.ctlInputFile
    Friend WithEvents ctlOutputFile As bsc_gui.ctlOutputFile
    Friend WithEvents ctlModeSelect As bsc_gui.ctlModeSelect
    Friend WithEvents ctlPreprocOpts As bsc_gui.ctlPreprocOpts
    Friend WithEvents ctlBlkSortingOpts As bsc_gui.ctlBlkSortingOpts
    Friend WithEvents ctlBtnGrpConfirm As bsc_gui.ctlBtnGrpConfirm
    Friend WithEvents ctlMiscOptions As bsc_gui.ctlMiscOptions
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents prgBarTask As System.Windows.Forms.ProgressBar

End Class
