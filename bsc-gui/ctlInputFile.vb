Public Class ctlInputFile
    Dim inFileName As String
    Public Event InFileSelected(ByVal inFileName As String)

    ' Proxy Init Module
    Private Sub ctlInputFile_Initialize()
        inFileName = String.Empty
    End Sub

    ' Text box handler
    Private Sub txtInFile_TextChanged(sender As Object, e As EventArgs) Handles txtInFile.TextChanged
        inFileName = txtInFile.Text

        ' A little bit crude right now,
        ' change the text box to one of those autocomplete address bars
        If My.Computer.FileSystem.FileExists(inFileName) Then
            RaiseEvent InFileSelected(inFileName)
        End If
    End Sub
    ' End Handler

    ' File Open button handler
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtInFile.Text = openFileDialog.FileName
            inFileName = txtInFile.Text
            RaiseEvent InFileSelected(inFileName)
        End If
    End Sub
    ' End Handler

End Class