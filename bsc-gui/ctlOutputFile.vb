Public Class ctlOutputFile
    Dim outFileName As String

    ' Some filler initialization routine without with VB
    ' Won't show the control
    Private Sub ctlOutputFile_Initialize()
        outFileName = Nothing
    End Sub

    ' Textbox handler
    Private Sub txtOutFile_TextChanged(sender As Object, e As EventArgs) Handles txtOutFile.TextChanged
        outFileName = txtOutFile.Text
    End Sub
    ' End Handler

    ' File Save button handler
    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOutFile.Text = SaveFileDialog.FileName
            outFileName = txtOutFile.Text
        End If
    End Sub
    ' End Handler
End Class
