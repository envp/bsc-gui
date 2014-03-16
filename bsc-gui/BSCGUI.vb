
Public Class BSCGUI
    ' String parameters

    ' Preserve mode to be updated on modeChanged Event
    Dim mode As String

    ' Boolean options, set to False to imply not ticked/selected
    Dim disableParallel As Boolean
    Dim disableMCS As Boolean
    Dim enableRAMPages As Boolean

    ' Handlers for exit / OK
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Builder method pls
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
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
