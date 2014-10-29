Public Class EvtHandlers
    Public Shared Sub RegisterHandlers()
        ' Register event handlers! (https://stackoverflow.com/questions/24227158/)
        AddHandler BSCGUI.ctlInputFile.InFileSelected, AddressOf ArgBuilder.ctlInputFile_FileSelected

        AddHandler BSCGUI.ctlOutputFile.OutFileSelected, AddressOf ArgBuilder.ctlOutputFile_FileSelected

        AddHandler BSCGUI.ctlModeSelect.modeChanged, AddressOf ArgBuilder.ctlModeSelect_ModeChanged

        AddHandler BSCGUI.ctlPreprocOpts.preprocDisabled, AddressOf ArgBuilder.ctlPreProcOpts_PreprocDisabled
        AddHandler BSCGUI.ctlPreprocOpts.segmentsEnabled, AddressOf ArgBuilder.ctlPreProcOpts_SegmentsEnabled
        AddHandler BSCGUI.ctlPreprocOpts.structDataEnabled, AddressOf ArgBuilder.ctlPreProcOpts_StructDataEnabled
        AddHandler BSCGUI.ctlPreprocOpts.lzpDisabled, AddressOf ArgBuilder.ctlPreProcOpts_LZPDisabled

        AddHandler BSCGUI.ctlPreprocOpts.ctlLZPOpts.lzpDictSizeChanged, AddressOf ArgBuilder.ctlLZPOpts_DictSizeChanged
        AddHandler BSCGUI.ctlPreprocOpts.ctlLZPOpts.lzpMatchLengthChanged, AddressOf ArgBuilder.ctlLZPOpts_MatchLengthChanged

        AddHandler BSCGUI.ctlBlkSortingOpts.blkSizeChanged, AddressOf ArgBuilder.ctlBlkSortingOpts_BlkSizeChanged
        AddHandler BSCGUI.ctlBlkSortingOpts.contextChanged, AddressOf ArgBuilder.ctlBlkSortingOpts_ContextChanged

        AddHandler BSCGUI.ctlBlkSortingOpts.ctlAlgs.useSTChanged, AddressOf ArgBuilder.ctlAlgs_UseSTChanged
        AddHandler BSCGUI.ctlBlkSortingOpts.ctlAlgs.useCUDAChanged, AddressOf ArgBuilder.ctlAlgs_UseCUDAChanged
        AddHandler BSCGUI.ctlBlkSortingOpts.ctlAlgs.useEntropyCodeChanged, AddressOf ArgBuilder.ctlAlgs_UseEntropyCodeChanged
        AddHandler BSCGUI.ctlBlkSortingOpts.ctlAlgs.sTOrderChanged, AddressOf ArgBuilder.ctlAlgs_STOrderChanged
    End Sub
End Class
