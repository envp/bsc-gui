
Public Class BSCGUI
    ' String parameters
    ' Preserve mode to be updated on modeChanged Event
    Dim mode As String

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

End Class
