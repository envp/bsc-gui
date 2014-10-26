Imports bsc_gui.Helpers
Imports bsc_gui.ArgBuilder
Public Class BSCGUI
    Dim mode As String
    Public appArgs As ArgsList

    ' Proxy Init Module
    Private Sub BSCGUI_Initialize()
        lblStatus.Text = "Ready to pack!"
        appArgs.setMode("e")
    End Sub

    ' Loader
    Private Sub BSCGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BSCGUI_Initialize()
        ' Register event handlers! (https://stackoverflow.com/questions/24227158/)
        AddHandler ctlInputFile.InFileSelected, AddressOf ArgBuilder.ctlInputFile_FileSelected

        AddHandler ctlOutputFile.OutFileSelected, AddressOf ArgBuilder.ctlOutputFile_FileSelected

        AddHandler ctlModeSelect.modeChanged, AddressOf ArgBuilder.ctlModeSelect_ModeChanged

        AddHandler ctlPreprocOpts.preprocDisabled, AddressOf ArgBuilder.ctlPreProcOpts_PreprocDisabled
        AddHandler ctlPreprocOpts.segmentsEnabled, AddressOf ArgBuilder.ctlPreProcOpts_SegmentsEnabled
        AddHandler ctlPreprocOpts.structDataEnabled, AddressOf ArgBuilder.ctlPreProcOpts_StructDataEnabled
        AddHandler ctlPreprocOpts.lzpDisabled, AddressOf ArgBuilder.ctlPreProcOpts_LZPDisabled

        AddHandler ctlBlkSortingOpts.blkSizeChanged, AddressOf ArgBuilder.ctlBlkSortingOpts_BlkSizeChanged
        AddHandler ctlBlkSortingOpts.contextChanged, AddressOf ArgBuilder.ctlBlkSortingOpts_ContextChanged

        AddHandler ctlBlkSortingOpts.ctlAlgs.useSTChanged, AddressOf ArgBuilder.ctlAlgs_UseSTChanged
        AddHandler ctlBlkSortingOpts.ctlAlgs.useCUDAChanged, AddressOf ArgBuilder.ctlAlgs_UseCUDAChanged
        AddHandler ctlBlkSortingOpts.ctlAlgs.useEntropyCodeChanged, AddressOf ArgBuilder.ctlAlgs_UseEntropyCodeChanged
        AddHandler ctlBlkSortingOpts.ctlAlgs.sTOrderChanged, AddressOf ArgBuilder.ctlAlgs_STOrderChanged
    End Sub

    ' Handlers for exit / OK
    Private Sub btnOK_Click() Handles ctlBtnGrpConfirm.ActionOK
        ' Build the CLI args based on events fired by all submodules
    End Sub
    Private Sub btnCancel_Click() Handles ctlBtnGrpConfirm.ActionCancel
        Me.Close()
    End Sub
    ' End Handlers for exit / OK

    Private Sub prgBarTask_Click(sender As Object, e As EventArgs) Handles prgBarTask.Click
        prgBarTask.Value = 64
    End Sub
End Class
