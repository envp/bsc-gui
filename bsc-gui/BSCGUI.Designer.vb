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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkBoxDsbMCS = New System.Windows.Forms.CheckBox()
        Me.chkBoxEnbRAM = New System.Windows.Forms.CheckBox()
        Me.chkBoxDsbParallel = New System.Windows.Forms.CheckBox()
        Me.tableCOpts = New System.Windows.Forms.TableLayoutPanel()
        Me.ctlModeSelect = New bsc_gui.ctlModeSelect()
        Me.ctlOutputFile = New bsc_gui.ctlOutputFile()
        Me.ctlInputFile = New bsc_gui.ctlInputFile()
        Me.ctlPreprocOpts = New bsc_gui.ctlPreprocOpts()
        Me.CtlBlkSortingOpts1 = New bsc_gui.ctlBlkSortingOpts()
        Me.MainPanel.SuspendLayout()
        Me.tableCOpts.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.ctlModeSelect)
        Me.MainPanel.Controls.Add(Me.ctlOutputFile)
        Me.MainPanel.Controls.Add(Me.ctlInputFile)
        Me.MainPanel.Controls.Add(Me.btnOK)
        Me.MainPanel.Controls.Add(Me.btnCancel)
        Me.MainPanel.Controls.Add(Me.chkBoxDsbMCS)
        Me.MainPanel.Controls.Add(Me.chkBoxEnbRAM)
        Me.MainPanel.Controls.Add(Me.chkBoxDsbParallel)
        Me.MainPanel.Controls.Add(Me.tableCOpts)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(704, 442)
        Me.MainPanel.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(486, 407)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 23)
        Me.btnOK.TabIndex = 21
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(592, 407)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkBoxDsbMCS
        '
        Me.chkBoxDsbMCS.AutoSize = True
        Me.chkBoxDsbMCS.Location = New System.Drawing.Point(15, 371)
        Me.chkBoxDsbMCS.Name = "chkBoxDsbMCS"
        Me.chkBoxDsbMCS.Size = New System.Drawing.Size(187, 17)
        Me.chkBoxDsbMCS.TabIndex = 19
        Me.chkBoxDsbMCS.Text = "Disable multi-core systems support"
        Me.chkBoxDsbMCS.UseVisualStyleBackColor = True
        '
        'chkBoxEnbRAM
        '
        Me.chkBoxEnbRAM.AutoSize = True
        Me.chkBoxEnbRAM.Location = New System.Drawing.Point(15, 394)
        Me.chkBoxEnbRAM.Name = "chkBoxEnbRAM"
        Me.chkBoxEnbRAM.Size = New System.Drawing.Size(169, 17)
        Me.chkBoxEnbRAM.TabIndex = 18
        Me.chkBoxEnbRAM.Text = "Enable large 2MB RAM pages"
        Me.chkBoxEnbRAM.UseVisualStyleBackColor = True
        '
        'chkBoxDsbParallel
        '
        Me.chkBoxDsbParallel.AutoSize = True
        Me.chkBoxDsbParallel.Location = New System.Drawing.Point(15, 348)
        Me.chkBoxDsbParallel.Name = "chkBoxDsbParallel"
        Me.chkBoxDsbParallel.Size = New System.Drawing.Size(185, 17)
        Me.chkBoxDsbParallel.TabIndex = 17
        Me.chkBoxDsbParallel.Text = "Disable parallel blocks processing"
        Me.chkBoxDsbParallel.UseVisualStyleBackColor = True
        '
        'tableCOpts
        '
        Me.tableCOpts.ColumnCount = 2
        Me.tableCOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.Controls.Add(Me.ctlPreprocOpts, 0, 0)
        Me.tableCOpts.Controls.Add(Me.CtlBlkSortingOpts1, 1, 0)
        Me.tableCOpts.Location = New System.Drawing.Point(15, 130)
        Me.tableCOpts.Name = "tableCOpts"
        Me.tableCOpts.RowCount = 1
        Me.tableCOpts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.Size = New System.Drawing.Size(662, 212)
        Me.tableCOpts.TabIndex = 6
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
        'CtlBlkSortingOpts1
        '
        Me.CtlBlkSortingOpts1.Location = New System.Drawing.Point(334, 3)
        Me.CtlBlkSortingOpts1.Name = "CtlBlkSortingOpts1"
        Me.CtlBlkSortingOpts1.Size = New System.Drawing.Size(325, 206)
        Me.CtlBlkSortingOpts1.TabIndex = 14
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
    Friend WithEvents chkBoxDsbMCS As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxEnbRAM As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbParallel As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ctlInputFile As bsc_gui.ctlInputFile
    Friend WithEvents ctlOutputFile As bsc_gui.ctlOutputFile
    Friend WithEvents ctlModeSelect As bsc_gui.ctlModeSelect
    Friend WithEvents ctlPreprocOpts As bsc_gui.ctlPreprocOpts
    Friend WithEvents CtlBlkSortingOpts1 As bsc_gui.ctlBlkSortingOpts

End Class
