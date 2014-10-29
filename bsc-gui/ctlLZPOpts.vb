Public Class CtlLZPOpts
    Event lzpDictSizeChanged(ByVal lzpDictSize As UInteger)
    Event lzpMatchLengthChanged(ByVal lzpMinMatchLength As UInteger)

    ' Variables for spinners
    Private lzpDictSize As UInteger
    Private lzpMinMatchLength As UInteger

    ' Proxy Init Module
    Private Sub ctlLZPOpts_Initialize()
        numDictSize.Value = 16
        numMatchLength.Value = 128

        ' LZP options
        lzpDictSize = numDictSize.Value
        lzpMinMatchLength = numMatchLength.Value
    End Sub

    Private Sub ctLZPOpts_Load(ByVal sender As Object, e As EventArgs) Handles MyBase.Load
        ctlLZPOpts_Initialize()
    End Sub

    ' Handlers for spinner value changes
    ' Dictionary Size
    Private Sub numDictSize_ValueChanged(sender As Object, e As EventArgs) Handles numDictSize.ValueChanged
        lzpDictSize = numDictSize.Value
    End Sub

    ' Minimum Match Length
    Private Sub numMatchLength_ValueChanged(sender As Object, e As EventArgs) Handles numMatchLength.ValueChanged
        lzpMinMatchLength = numMatchLength.Value
    End Sub
    ' End spinner value handlers
End Class
