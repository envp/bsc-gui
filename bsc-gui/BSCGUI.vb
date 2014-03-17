
Public Class BSCGUI
    ' String parameters
    ' Preserve mode to be updated on modeChanged Event
    Dim mode As String

    ' Proxy Init Module
    ' Create a random getter for greeting status label
    Private Sub BSCGUI_Initialize()
        lblStatus.Text = "Ready to pack!"
    End Sub

    ' Loader
    Private Sub BSCGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BSCGUI_Initialize()
    End Sub

    ' Handlers for exit / OK
    Private Sub btnOK_Click() Handles ctlBtnGrpConfirm.ActionOK
        ' Command-builder method pls

    End Sub
    Private Sub btnCancel_Click() Handles ctlBtnGrpConfirm.ActionCancel
        Me.Close()
    End Sub
    ' End Handlers for exit / OK

    Private Sub ctlModeSelect_Changed(n As UInteger) Handles ctlModeSelect.modeChanged
        If n = 0 Then
            mode = "e"
            tableCOpts.Enabled = True
        ElseIf n = 1 Then
            mode = "d"
            tableCOpts.Enabled = False
        End If
    End Sub

    Private Sub prgBarTask_Click(sender As Object, e As EventArgs) Handles prgBarTask.Click
        prgBarTask.Value = 100
    End Sub
End Class
