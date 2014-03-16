
Public Class BSCGUI
    ' String parameters

    ' Preserve mode to be updated on DecompressEnabled
    ' or CompressEnabled events
    Dim mode As String
    Dim context As String

    'Dim inFileName As String
    'Dim outFileName As String

    ' Boolean options, set to False to imply not ticked/selected
    Dim disablePreproc As Boolean
    Dim disableSegments As Boolean
    Dim enableStructData As Boolean
    Dim disableLZP As Boolean
    Dim disableParallel As Boolean
    Dim disableMCS As Boolean
    Dim enableRAMPages As Boolean
    Dim useSortTransform As Boolean
    Dim useCudaAccel As Boolean
    Dim useStatEntEnc As Boolean

    ' Unsigned integer parameters
    Dim blkSize As UInteger
    Dim lzpDictSize As UInteger
    Dim lzpMinMatchLength As UInteger
    Dim sortTransformOrder As UInteger
    Dim estMemUsage As UInteger
    Dim nParallel As UInteger = 1
    ' Loader to set everything to its defaul value / state
    Private Sub initLoader()
        ' Set options on UI, extract later
        'comboMode.Text = "Compression"
        comboContext.Text = "Following"

        numDictSize.Value = 16
        numMatchLength.Value = 128
        numBlkSize.Value = 25

        ' Preprocessing options
        disablePreproc = False
        disableSegments = False
        enableStructData = False
        disableLZP = False

        ' LZP options
        lzpDictSize = numDictSize.Value
        lzpMinMatchLength = numMatchLength.Value

        ' Block Sorting options
        blkSize = numBlkSize.Value
        context = comboContext.Text

        ' Algorithm options
        useStatEntEnc = rBtnEntEncStatic.Checked
        useSortTransform = chkBoxSortTransform.Checked
        useCudaAccel = chkBoxCUDA.Checked

        ' Est Memory Usage = 16Mb + 5 * block_size * parallel_cores_used
        estMemUsage = 16 + 5 * blkSize * nParallel
        lblMemUsageNum.Text = estMemUsage.ToString & " " & "MB"
    End Sub

    Private Sub BSCGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'inFileName = txtInFile.Text
        'outFileName = txtOutFile.Text
        initLoader()
    End Sub

    '' Set / Unset Handlers
    'Private Sub comboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMode.SelectedIndexChanged
    '    If comboMode.Text = "Decompression" Then
    '        tableCOpts.Enabled = False
    '        mode = "d"
    '    ElseIf comboMode.Text = "Compression" Then
    '        tableCOpts.Enabled = True
    '        mode = "e"
    '    End If
    'End Sub
    '' End Set / Unset Handlers


    '' File Dialog Handlers
    'Private Sub btnOpenFile_Click(sender As Object, e As EventArgs)
    '    If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        txtInFile.Text = openFileDialog.FileName
    '        inFileName = txtInFile.Text
    '    End If
    'End Sub

    'Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
    '    If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        txtOutFile.Text = saveFileDialog.FileName
    '        outFileName = txtOutFile.Text
    '    End If
    'End Sub
    '' End File Dialog Handlers

    ' Handlers for exit / OK
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' methods pls
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ' End Handlers for exit / OK

    Private Sub modeChanged_Change(n As UInteger) Handles ctlModeSelect.modeChanged
        If n = 0 Then
            mode = "e"
            tableCOpts.Enabled = True
        ElseIf n = 1 Then
            mode = "d"
            tableCOpts.Enabled = False
        End If
    End Sub
End Class
