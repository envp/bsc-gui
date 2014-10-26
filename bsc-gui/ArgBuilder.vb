Public Class ArgBuilder
    ' Create getters and setters for all relevant vars in the project
    ' Capture events from all over the place
    Structure ArgsList
        Public inFileName As String
        Public outFileName As String
        Public mode As String
        Public Sub setInFileName(fileName)
            inFileName = fileName
        End Sub
    End Structure

    ' CtlInputFile
    Public Shared Sub ctlInputFile_FileSelected(ByVal fileName As String)
        BSCGUI.lblStatus.Text = "Input File Selected..."
        BSCGUI.appArgs.inFileName = fileName
    End Sub

    ' CtlOutputFile
    Public Shared Sub ctlOutputFile_FileSelected(ByVal fileName As String)
        BSCGUI.lblStatus.Text = "Output File Selected..."
        BSCGUI.appArgs.outFileName = fileName
    End Sub

    ' CtlModeSelect
    Public Shared Sub ctlModeSelect_ModeChanged(ByVal n As UInteger)
        If n = 0 Then
            BSCGUI.tableCOpts.Enabled = True
            BSCGUI.appArgs.mode = "e"
        ElseIf n = 1 Then
            BSCGUI.tableCOpts.Enabled = False
            BSCGUI.appArgs.mode = "d"

        End If
    End Sub

End Class
