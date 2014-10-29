Public Class ArgBuilder
    ' Create getters and setters for all relevant vars in the project
    ' Capture events from all over the place
    Structure ArgsList
        Private inFileName As String

        Private outFileName As String

        Private mode As String

        Private disablePreproc As Boolean
        Private enableSegments As Boolean
        Private enableStructData As Boolean
        Private disableLZP As Boolean

        Private blkSize As UInteger
        Private context As String

        Private useSortTransform As Boolean
        Private useCudaAccel As Boolean
        Private useStatEntEnc As Boolean
        Private sortTransformOrder As UInteger

        Private lzpDictSize As UInteger
        Private lzpMinMatchLength As UInteger

        ' A ton of setters
        ' There has to be some way to scaffold mutator/accessors in VB
        Public Sub setInFileName(ByVal fileName As String)
            inFileName = fileName
        End Sub

        Public Sub setOutFileName(ByVal fileName As String)
            outFileName = fileName
        End Sub

        Public Sub setMode(ByVal m As String)
            mode = m
        End Sub

        Public Sub setDisablePreproc(ByVal disable As Boolean)
            disablePreproc = disable
        End Sub

        Public Sub setEnableSegments(ByVal enable As Boolean)
            enableSegments = enable
        End Sub

        Public Sub setEnableStructData(ByVal enable As Boolean)
            enableStructData = enable
        End Sub

        Public Sub setDisableLZP(ByVal disable As Boolean)
            disableLZP = disable
        End Sub

        Public Sub setBlkSize(ByVal size As UInteger)
            blkSize = size
        End Sub

        Public Sub setContext(ByVal context As String)
            Me.context = context
        End Sub

        Public Sub setUseST(ByVal useST As Boolean)
            useSortTransform = useST
        End Sub

        Public Sub setUseCUDA(ByVal useCUDA As Boolean)
            useCudaAccel = useCUDA
        End Sub

        Public Sub setUseEntropyCode(ByVal useEntropy As Boolean)
            useStatEntEnc = useEntropy
        End Sub

        Public Sub setSTOrder(ByVal stOrder As UInteger)
            sortTransformOrder = stOrder
        End Sub

        Public Sub setLZPDictSize(ByVal dictSize As UInteger)
            lzpDictSize = dictSize
        End Sub

        Public Sub setLZPMatchLength(ByVal matchLength As UInteger)
            lzpMinMatchLength = matchLength
        End Sub

    End Structure

    ' CtlInputFile
    Public Shared Sub ctlInputFile_FileSelected(ByVal fileName As String)
        BSCGUI.lblStatus.Text = "Input File Selected..."
        BSCGUI.appArgs.setInFileName(fileName)
    End Sub

    ' CtlOutputFile
    Public Shared Sub ctlOutputFile_FileSelected(ByVal fileName As String)
        BSCGUI.lblStatus.Text = "Output File Selected..."
        BSCGUI.appArgs.setOutFileName(fileName)
    End Sub

    ' CtlModeSelect
    Public Shared Sub ctlModeSelect_ModeChanged(ByVal n As UInteger)
        If n = 0 Then
            BSCGUI.appArgs.setMode("e")
            BSCGUI.tableCOpts.Enabled = True
        ElseIf n = 1 Then
            BSCGUI.appArgs.setMode("d")
            BSCGUI.tableCOpts.Enabled = False
        End If
    End Sub

    ' CtlPreporcOpts
    Public Shared Sub ctlPreProcOpts_PreprocDisabled(ByVal disablePreproc As Boolean)
        BSCGUI.appArgs.setDisablePreproc(disablePreproc)
    End Sub

    Public Shared Sub ctlPreProcOpts_SegmentsEnabled(ByVal enableSegments As Boolean)
        BSCGUI.appArgs.setEnableSegments(enableSegments)
    End Sub

    Public Shared Sub ctlPreProcOpts_StructDataEnabled(ByVal enableStructData As Boolean)
        BSCGUI.appArgs.setEnableStructData(enableStructData)
    End Sub

    Public Shared Sub ctlPreProcOpts_LZPDisabled(ByVal disableLZP As Boolean)
        BSCGUI.appArgs.setDisableLZP(disableLZP)
    End Sub

    ' CtlPreporcOpts > ctlLZPOpts
    Shared Sub ctlLZPOpts_DictSizeChanged(lzpDictSize As UInteger)
        BSCGUI.appArgs.setLZPDictSize(lzpDictSize)
    End Sub

    Shared Sub ctlLZPOpts_MatchLengthChanged(lzpMinMatchLength As UInteger)
        BSCGUI.appArgs.setLZPMatchLength(lzpMinMatchLength)
    End Sub

    ' CtlBlkSortingOpts
    Public Shared Sub ctlBlkSortingOpts_BlkSizeChanged(ByVal blkSize As UInteger)
        BSCGUI.appArgs.setBlkSize(blkSize)
    End Sub

    Public Shared Sub ctlBlkSortingOpts_ContextChanged(ByVal context As String)
        BSCGUI.appArgs.setContext(context)
    End Sub

    ' CtlBlkSortingOpts > CtlAlgs
    Public Shared Sub ctlAlgs_UseSTChanged(ByVal useST As Boolean)
        BSCGUI.appArgs.setUseST(useST)
    End Sub

    Public Shared Sub ctlAlgs_UseCUDAChanged(ByVal useCUDA As Boolean)
        BSCGUI.appArgs.setUseCUDA(useCUDA)
    End Sub

    Public Shared Sub ctlAlgs_UseEntropyCodeChanged(ByVal useEntropy As Boolean)
        BSCGUI.appArgs.setUseEntropyCode(useEntropy)
    End Sub

    Public Shared Sub ctlAlgs_STOrderChanged(ByVal stOrder As UInteger)
        BSCGUI.appArgs.setSTOrder(stOrder)
    End Sub


End Class
