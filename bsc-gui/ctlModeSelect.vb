Public Class ctlModeSelect
    ' Custom Event to notify if comboBox has changed
    Public Event modeChanged(ByVal num As UInteger)

    ' Proxy Init Module
    Private Sub ctlModeSelect_Initialize()
        comboMode.Text = "Compression"
    End Sub

    ' Handler for load
    Private Sub ctlModeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctlModeSelect_Initialize()
    End Sub

    ' Set / Unset Handlers
    Private Sub comboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMode.SelectedIndexChanged
        If comboMode.Text = "Decompression" Then
            RaiseEvent modeChanged(1)
        ElseIf comboMode.Text = "Compression" Then
            RaiseEvent modeChanged(0)
        End If
    End Sub
    ' End Set / Unset Handlers
End Class
