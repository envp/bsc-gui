Imports bsc_gui.Helpers
Imports bsc_gui.ArgBuilder
Imports bsc_gui.EvtHandlers

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
        EvtHandlers.RegisterHandlers()
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
