Public Class ctlBlkSortingOpts
    ' Unsigned integer parameters
    Dim blkSize As UInteger
    Dim nParallel As UInteger

    'String Parameters
    Dim context As String

    Private Function estMemUsage(blkSize As UInteger, nParallel As UInteger) As UInteger
        Return 16 + 5 * blkSize * nParallel
    End Function

    Private Sub ctlBlkSortingOpts_Initialize()
        comboContext.Text = "Following"
        numBlkSize.Value = 25

        ' Block Sorting options
        blkSize = numBlkSize.Value
        context = comboContext.Text

        ' TODO Change/Fix later (Detect number of cores to be run on)
        nParallel = 1

        ' Misc Stuff
        ctlAlgs.lblMemUsageNum.Text = estMemUsage(blkSize, nParallel).ToString & " " & "MB"
    End Sub


    Private Sub ctlBlkSortingOpts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctlBlkSortingOpts_Initialize()
    End Sub

    ' Handlers for Block Sorting options
    Private Sub numBlkSize_ValueChanged(sender As Object, e As EventArgs) Handles numBlkSize.ValueChanged
        blkSize = numBlkSize.Value
        ctlAlgs.lblMemUsageNum.Text = estMemUsage(blkSize, nParallel).ToString & " " & "MB"
    End Sub

    Private Sub comboContext_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboContext.SelectedIndexChanged
        context = comboContext.Text
    End Sub


End Class
