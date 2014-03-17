<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBlkSortingOpts
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
        Me.grpBoxBlockSort = New System.Windows.Forms.GroupBox()
        Me.ctlAlgs = New bsc_gui.ctlAlgs()
        Me.comboContext = New System.Windows.Forms.ComboBox()
        Me.lblContext = New System.Windows.Forms.Label()
        Me.lblBlkSize = New System.Windows.Forms.Label()
        Me.numBlkSize = New System.Windows.Forms.NumericUpDown()
        Me.grpBoxBlockSort.SuspendLayout()
        CType(Me.numBlkSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxBlockSort
        '
        Me.grpBoxBlockSort.Controls.Add(Me.ctlAlgs)
        Me.grpBoxBlockSort.Controls.Add(Me.comboContext)
        Me.grpBoxBlockSort.Controls.Add(Me.lblContext)
        Me.grpBoxBlockSort.Controls.Add(Me.lblBlkSize)
        Me.grpBoxBlockSort.Controls.Add(Me.numBlkSize)
        Me.grpBoxBlockSort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBoxBlockSort.Location = New System.Drawing.Point(0, 0)
        Me.grpBoxBlockSort.Name = "grpBoxBlockSort"
        Me.grpBoxBlockSort.Size = New System.Drawing.Size(325, 206)
        Me.grpBoxBlockSort.TabIndex = 2
        Me.grpBoxBlockSort.TabStop = False
        Me.grpBoxBlockSort.Text = "Block Sorting"
        '
        'ctlAlgs
        '
        Me.ctlAlgs.Location = New System.Drawing.Point(3, 70)
        Me.ctlAlgs.Name = "ctlAlgs"
        Me.ctlAlgs.Size = New System.Drawing.Size(316, 130)
        Me.ctlAlgs.TabIndex = 13
        '
        'comboContext
        '
        Me.comboContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboContext.FormattingEnabled = True
        Me.comboContext.ItemHeight = 13
        Me.comboContext.Items.AddRange(New Object() {"Following", "Preceding", "Autodetect"})
        Me.comboContext.Location = New System.Drawing.Point(199, 46)
        Me.comboContext.Name = "comboContext"
        Me.comboContext.Size = New System.Drawing.Size(120, 21)
        Me.comboContext.TabIndex = 8
        '
        'lblContext
        '
        Me.lblContext.AutoSize = True
        Me.lblContext.Location = New System.Drawing.Point(6, 46)
        Me.lblContext.Name = "lblContext"
        Me.lblContext.Size = New System.Drawing.Size(100, 13)
        Me.lblContext.TabIndex = 12
        Me.lblContext.Text = "Contexts for sorting:"
        '
        'lblBlkSize
        '
        Me.lblBlkSize.AutoSize = True
        Me.lblBlkSize.Location = New System.Drawing.Point(6, 20)
        Me.lblBlkSize.Name = "lblBlkSize"
        Me.lblBlkSize.Size = New System.Drawing.Size(85, 13)
        Me.lblBlkSize.TabIndex = 10
        Me.lblBlkSize.Text = "Block Size (MB):"
        '
        'numBlkSize
        '
        Me.numBlkSize.Location = New System.Drawing.Point(199, 16)
        Me.numBlkSize.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.numBlkSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBlkSize.Name = "numBlkSize"
        Me.numBlkSize.Size = New System.Drawing.Size(120, 20)
        Me.numBlkSize.TabIndex = 0
        Me.numBlkSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBlkSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'ctlBlkSortingOpts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpBoxBlockSort)
        Me.Name = "ctlBlkSortingOpts"
        Me.Size = New System.Drawing.Size(325, 206)
        Me.grpBoxBlockSort.ResumeLayout(False)
        Me.grpBoxBlockSort.PerformLayout()
        CType(Me.numBlkSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBoxBlockSort As System.Windows.Forms.GroupBox
    Friend WithEvents comboContext As System.Windows.Forms.ComboBox
    Friend WithEvents lblContext As System.Windows.Forms.Label
    Friend WithEvents lblBlkSize As System.Windows.Forms.Label
    Friend WithEvents numBlkSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents ctlAlgs As bsc_gui.ctlAlgs

End Class
