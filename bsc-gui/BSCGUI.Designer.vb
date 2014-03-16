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
        Me.comboMode = New System.Windows.Forms.ComboBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.tableCOpts = New System.Windows.Forms.TableLayoutPanel()
        Me.grpBoxBlockSort = New System.Windows.Forms.GroupBox()
        Me.comboContext = New System.Windows.Forms.ComboBox()
        Me.lblContext = New System.Windows.Forms.Label()
        Me.grpBoxEntEnc = New System.Windows.Forms.GroupBox()
        Me.lblMemUsageNum = New System.Windows.Forms.Label()
        Me.lblMemUsageTag = New System.Windows.Forms.Label()
        Me.chkBoxCUDA = New System.Windows.Forms.CheckBox()
        Me.numSortTransformOder = New System.Windows.Forms.NumericUpDown()
        Me.chkBoxSortTransform = New System.Windows.Forms.CheckBox()
        Me.rBtnEntEncAdaptive = New System.Windows.Forms.RadioButton()
        Me.rBtnEntEncStatic = New System.Windows.Forms.RadioButton()
        Me.lblEntEnc = New System.Windows.Forms.Label()
        Me.lblBlkSize = New System.Windows.Forms.Label()
        Me.numBlkSize = New System.Windows.Forms.NumericUpDown()
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
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtOutFile = New System.Windows.Forms.TextBox()
        Me.txtInFile = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MainPanel.SuspendLayout()
        Me.tableCOpts.SuspendLayout()
        Me.grpBoxBlockSort.SuspendLayout()
        Me.grpBoxEntEnc.SuspendLayout()
        CType(Me.numSortTransformOder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBlkSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxPreproc.SuspendLayout()
        Me.grpBoxLZP.SuspendLayout()
        CType(Me.numDictSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMatchLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.btnOK)
        Me.MainPanel.Controls.Add(Me.btnCancel)
        Me.MainPanel.Controls.Add(Me.chkBoxDsbMCS)
        Me.MainPanel.Controls.Add(Me.chkBoxEnbRAM)
        Me.MainPanel.Controls.Add(Me.chkBoxDsbParallel)
        Me.MainPanel.Controls.Add(Me.comboMode)
        Me.MainPanel.Controls.Add(Me.lblMode)
        Me.MainPanel.Controls.Add(Me.tableCOpts)
        Me.MainPanel.Controls.Add(Me.btnSaveFile)
        Me.MainPanel.Controls.Add(Me.btnOpenFile)
        Me.MainPanel.Controls.Add(Me.txtOutFile)
        Me.MainPanel.Controls.Add(Me.txtInFile)
        Me.MainPanel.Controls.Add(Me.lblOutput)
        Me.MainPanel.Controls.Add(Me.lblInput)
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
        'comboMode
        '
        Me.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMode.FormattingEnabled = True
        Me.comboMode.ItemHeight = 13
        Me.comboMode.Items.AddRange(New Object() {"Compression", "Decompression"})
        Me.comboMode.Location = New System.Drawing.Point(58, 102)
        Me.comboMode.Name = "comboMode"
        Me.comboMode.Size = New System.Drawing.Size(120, 21)
        Me.comboMode.TabIndex = 7
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(15, 105)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(37, 13)
        Me.lblMode.TabIndex = 0
        Me.lblMode.Text = "Mode:"
        '
        'tableCOpts
        '
        Me.tableCOpts.ColumnCount = 2
        Me.tableCOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.Controls.Add(Me.grpBoxBlockSort, 1, 0)
        Me.tableCOpts.Controls.Add(Me.grpBoxPreproc, 0, 0)
        Me.tableCOpts.Location = New System.Drawing.Point(15, 130)
        Me.tableCOpts.Name = "tableCOpts"
        Me.tableCOpts.RowCount = 1
        Me.tableCOpts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableCOpts.Size = New System.Drawing.Size(662, 212)
        Me.tableCOpts.TabIndex = 6
        '
        'grpBoxBlockSort
        '
        Me.grpBoxBlockSort.Controls.Add(Me.comboContext)
        Me.grpBoxBlockSort.Controls.Add(Me.lblContext)
        Me.grpBoxBlockSort.Controls.Add(Me.grpBoxEntEnc)
        Me.grpBoxBlockSort.Controls.Add(Me.lblBlkSize)
        Me.grpBoxBlockSort.Controls.Add(Me.numBlkSize)
        Me.grpBoxBlockSort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBoxBlockSort.Location = New System.Drawing.Point(334, 3)
        Me.grpBoxBlockSort.Name = "grpBoxBlockSort"
        Me.grpBoxBlockSort.Size = New System.Drawing.Size(325, 206)
        Me.grpBoxBlockSort.TabIndex = 1
        Me.grpBoxBlockSort.TabStop = False
        Me.grpBoxBlockSort.Text = "Block Sorting"
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
        'grpBoxEntEnc
        '
        Me.grpBoxEntEnc.Controls.Add(Me.lblMemUsageNum)
        Me.grpBoxEntEnc.Controls.Add(Me.lblMemUsageTag)
        Me.grpBoxEntEnc.Controls.Add(Me.chkBoxCUDA)
        Me.grpBoxEntEnc.Controls.Add(Me.numSortTransformOder)
        Me.grpBoxEntEnc.Controls.Add(Me.chkBoxSortTransform)
        Me.grpBoxEntEnc.Controls.Add(Me.rBtnEntEncAdaptive)
        Me.grpBoxEntEnc.Controls.Add(Me.rBtnEntEncStatic)
        Me.grpBoxEntEnc.Controls.Add(Me.lblEntEnc)
        Me.grpBoxEntEnc.Location = New System.Drawing.Point(9, 73)
        Me.grpBoxEntEnc.Name = "grpBoxEntEnc"
        Me.grpBoxEntEnc.Size = New System.Drawing.Size(310, 127)
        Me.grpBoxEntEnc.TabIndex = 11
        Me.grpBoxEntEnc.TabStop = False
        Me.grpBoxEntEnc.Text = "Algorithm"
        '
        'lblMemUsageNum
        '
        Me.lblMemUsageNum.AutoSize = True
        Me.lblMemUsageNum.Location = New System.Drawing.Point(242, 98)
        Me.lblMemUsageNum.Name = "lblMemUsageNum"
        Me.lblMemUsageNum.Size = New System.Drawing.Size(32, 13)
        Me.lblMemUsageNum.TabIndex = 18
        Me.lblMemUsageNum.Text = "0 MB"
        Me.lblMemUsageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMemUsageTag
        '
        Me.lblMemUsageTag.AutoSize = True
        Me.lblMemUsageTag.Location = New System.Drawing.Point(6, 96)
        Me.lblMemUsageTag.Name = "lblMemUsageTag"
        Me.lblMemUsageTag.Size = New System.Drawing.Size(193, 13)
        Me.lblMemUsageTag.TabIndex = 17
        Me.lblMemUsageTag.Text = "Estimated Memory Usage (Single Core):"
        '
        'chkBoxCUDA
        '
        Me.chkBoxCUDA.AutoSize = True
        Me.chkBoxCUDA.Enabled = False
        Me.chkBoxCUDA.Location = New System.Drawing.Point(9, 65)
        Me.chkBoxCUDA.Name = "chkBoxCUDA"
        Me.chkBoxCUDA.Size = New System.Drawing.Size(238, 17)
        Me.chkBoxCUDA.TabIndex = 16
        Me.chkBoxCUDA.Text = "Enable Sort Transform Acceleration (NVIDIA)"
        Me.chkBoxCUDA.UseVisualStyleBackColor = True
        '
        'numSortTransformOder
        '
        Me.numSortTransformOder.Enabled = False
        Me.numSortTransformOder.Location = New System.Drawing.Point(184, 39)
        Me.numSortTransformOder.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.numSortTransformOder.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numSortTransformOder.Name = "numSortTransformOder"
        Me.numSortTransformOder.Size = New System.Drawing.Size(120, 20)
        Me.numSortTransformOder.TabIndex = 13
        Me.numSortTransformOder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSortTransformOder.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'chkBoxSortTransform
        '
        Me.chkBoxSortTransform.AutoSize = True
        Me.chkBoxSortTransform.Location = New System.Drawing.Point(9, 42)
        Me.chkBoxSortTransform.Name = "chkBoxSortTransform"
        Me.chkBoxSortTransform.Size = New System.Drawing.Size(164, 17)
        Me.chkBoxSortTransform.TabIndex = 9
        Me.chkBoxSortTransform.Text = "Use Nth order Sort Transform"
        Me.chkBoxSortTransform.UseVisualStyleBackColor = True
        '
        'rBtnEntEncAdaptive
        '
        Me.rBtnEntEncAdaptive.AutoSize = True
        Me.rBtnEntEncAdaptive.Location = New System.Drawing.Point(234, 18)
        Me.rBtnEntEncAdaptive.Name = "rBtnEntEncAdaptive"
        Me.rBtnEntEncAdaptive.Size = New System.Drawing.Size(67, 17)
        Me.rBtnEntEncAdaptive.TabIndex = 15
        Me.rBtnEntEncAdaptive.Text = "Adaptive"
        Me.rBtnEntEncAdaptive.UseVisualStyleBackColor = True
        '
        'rBtnEntEncStatic
        '
        Me.rBtnEntEncStatic.AutoSize = True
        Me.rBtnEntEncStatic.Checked = True
        Me.rBtnEntEncStatic.Location = New System.Drawing.Point(137, 19)
        Me.rBtnEntEncStatic.Name = "rBtnEntEncStatic"
        Me.rBtnEntEncStatic.Size = New System.Drawing.Size(52, 17)
        Me.rBtnEntEncStatic.TabIndex = 14
        Me.rBtnEntEncStatic.TabStop = True
        Me.rBtnEntEncStatic.Text = "Static"
        Me.rBtnEntEncStatic.UseVisualStyleBackColor = True
        '
        'lblEntEnc
        '
        Me.lblEntEnc.AutoSize = True
        Me.lblEntEnc.Location = New System.Drawing.Point(6, 19)
        Me.lblEntEnc.Name = "lblEntEnc"
        Me.lblEntEnc.Size = New System.Drawing.Size(94, 13)
        Me.lblEntEnc.TabIndex = 13
        Me.lblEntEnc.Text = "Entropy Encoding:"
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
        'grpBoxPreproc
        '
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxEnbStructData)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxDsbLZP)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxEnbSegments)
        Me.grpBoxPreproc.Controls.Add(Me.chkBoxDsbPreoproc)
        Me.grpBoxPreproc.Controls.Add(Me.grpBoxLZP)
        Me.grpBoxPreproc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBoxPreproc.Location = New System.Drawing.Point(3, 3)
        Me.grpBoxPreproc.Name = "grpBoxPreproc"
        Me.grpBoxPreproc.Size = New System.Drawing.Size(325, 206)
        Me.grpBoxPreproc.TabIndex = 0
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
        'btnSaveFile
        '
        Me.btnSaveFile.Location = New System.Drawing.Point(592, 68)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(100, 22)
        Me.btnSaveFile.TabIndex = 5
        Me.btnSaveFile.Text = "Save As..."
        Me.btnSaveFile.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(592, 25)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(100, 22)
        Me.btnOpenFile.TabIndex = 4
        Me.btnOpenFile.Text = "Open File..."
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtOutFile
        '
        Me.txtOutFile.Location = New System.Drawing.Point(15, 70)
        Me.txtOutFile.Name = "txtOutFile"
        Me.txtOutFile.Size = New System.Drawing.Size(571, 20)
        Me.txtOutFile.TabIndex = 3
        '
        'txtInFile
        '
        Me.txtInFile.Location = New System.Drawing.Point(15, 27)
        Me.txtInFile.Name = "txtInFile"
        Me.txtInFile.Size = New System.Drawing.Size(571, 20)
        Me.txtInFile.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(12, 54)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(42, 13)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Output:"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(12, 11)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(34, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input:"
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "All files (*.*)|*.*|Text (*.txt)|*.txt|Documents (*.doc, *.docx)|*.doc*|Excel (*." & _
    "xls, *.xlsx)|*.xls*|Powerpoint (*.ppt, *.pptx)|*.ppt*|PDF (*.pdf)|*.pdf"
        '
        'saveFileDialog
        '
        Me.saveFileDialog.Filter = "All files (*.*)|*.*|Block Archives (*.bsc)|*.bsc"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.grpBoxBlockSort.ResumeLayout(False)
        Me.grpBoxBlockSort.PerformLayout()
        Me.grpBoxEntEnc.ResumeLayout(False)
        Me.grpBoxEntEnc.PerformLayout()
        CType(Me.numSortTransformOder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBlkSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxPreproc.ResumeLayout(False)
        Me.grpBoxPreproc.PerformLayout()
        Me.grpBoxLZP.ResumeLayout(False)
        Me.grpBoxLZP.PerformLayout()
        CType(Me.numDictSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMatchLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents tableCOpts As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpBoxBlockSort As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxPreproc As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveFile As System.Windows.Forms.Button
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents txtOutFile As System.Windows.Forms.TextBox
    Friend WithEvents txtInFile As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents comboMode As System.Windows.Forms.ComboBox
    Friend WithEvents chkBoxEnbStructData As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbLZP As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxEnbSegments As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbPreoproc As System.Windows.Forms.CheckBox
    Friend WithEvents lblLZPMatchLength As System.Windows.Forms.Label
    Friend WithEvents lblLZPDictSize As System.Windows.Forms.Label
    Friend WithEvents grpBoxLZP As System.Windows.Forms.GroupBox
    Friend WithEvents numDictSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMatchLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBlkSize As System.Windows.Forms.Label
    Friend WithEvents numBlkSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpBoxEntEnc As System.Windows.Forms.GroupBox
    Friend WithEvents comboContext As System.Windows.Forms.ComboBox
    Friend WithEvents lblContext As System.Windows.Forms.Label
    Friend WithEvents numSortTransformOder As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkBoxSortTransform As System.Windows.Forms.CheckBox
    Friend WithEvents rBtnEntEncAdaptive As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnEntEncStatic As System.Windows.Forms.RadioButton
    Friend WithEvents lblEntEnc As System.Windows.Forms.Label
    Friend WithEvents chkBoxDsbMCS As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxEnbRAM As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxDsbParallel As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxCUDA As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblMemUsageNum As System.Windows.Forms.Label
    Friend WithEvents lblMemUsageTag As System.Windows.Forms.Label
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
