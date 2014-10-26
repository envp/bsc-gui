Imports bsc_gui.Helpers
Imports bsc_gui.ArgBuilder
Public Class BSCGUI
    Dim mode As String
    Public appArgs As ArgsList

    ' Proxy Init Module
    Private Sub BSCGUI_Initialize()
        lblStatus.Text = "Ready to pack!"
        appArgs.mode = "e"
    End Sub

    ' Loader
    Private Sub BSCGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BSCGUI_Initialize()
        ' Register event handlers! (https://stackoverflow.com/questions/24227158/)
        AddHandler ctlInputFile.InFileSelected, AddressOf ArgBuilder.ctlInputFile_FileSelected
        AddHandler ctlOutputFile.OutFileSelected, AddressOf ArgBuilder.ctlOutputFile_FileSelected
        AddHandler ctlModeSelect.modeChanged, AddressOf ArgBuilder.ctlModeSelect_ModeChanged

    End Sub

    ' Handlers for exit / OK
    Private Sub btnOK_Click() Handles ctlBtnGrpConfirm.ActionOK
        ' Build the CLI args based on events fired by all submodules
        MsgBox(appArgs.inFileName)
        MsgBox(appArgs.outFileName)
        MsgBox(appArgs.mode)
    End Sub
    Private Sub btnCancel_Click() Handles ctlBtnGrpConfirm.ActionCancel
        Me.Close()
    End Sub
    ' End Handlers for exit / OK

    Private Sub prgBarTask_Click(sender As Object, e As EventArgs) Handles prgBarTask.Click
        prgBarTask.Value = 64
    End Sub
End Class
