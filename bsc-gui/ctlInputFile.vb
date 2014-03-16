Public Class ctlInputFile
    Dim inFileName As String

    ' Proxy Init Module
    Private Sub ctlInputFile_Initialize()
        inFileName = Nothing
    End Sub

    ' Text box handler
    Private Sub txtInFile_TextChanged(sender As Object, e As EventArgs) Handles txtInFile.TextChanged
        inFileName = txtInFile.Text
    End Sub
    ' End Handler

    ' File Open button handler
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtInFile.Text = openFileDialog.FileName
            inFileName = txtInFile.Text
        End If
    End Sub
    ' End Handler
End Class
