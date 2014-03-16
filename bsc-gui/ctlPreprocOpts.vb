Public Class ctlPreprocOpts
    ' Checkbox booleans
    Dim disablePreproc As Boolean
    Dim enableSegments As Boolean
    Dim enableStructData As Boolean
    Dim disableLZP As Boolean

    ' Proxy Init Module
    Private Sub ctlPreprocOpts_Initialize()
        ' Preprocessing options
        disablePreproc = False
        enableSegments = False
        enableStructData = False
        disableLZP = False
    End Sub

    Private Sub ctlPreprocOpts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctlPreprocOpts_Initialize()
    End Sub

    ' Checkbox Set/Unset Handlers
    ' Disable preprocessing
    Private Sub chkBoxDsbPreoproc_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxDsbPreoproc.CheckedChanged
        disablePreproc = chkBoxDsbPreoproc.Checked
    End Sub

    ' Enable Segmentation (Adaptive Re-ordering)
    Private Sub chkBoxEnbSegments_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxEnbSegments.CheckedChanged
        enableSegments = chkBoxEnbSegments.Checked
    End Sub

    ' Enable Structured data re-ordering
    Private Sub chkBoxEnbStructData_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxEnbStructData.CheckedChanged
        enableStructData = chkBoxEnbStructData.Checked
    End Sub

    ' Disable Lempel-Ziv Preprocessing
    Private Sub chkBoxDsbLZP_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxDsbLZP.CheckedChanged
        disableLZP = chkBoxDsbLZP.Checked

        ' Disable / Enable options according to the previous change
        ctlLZPOpts.Enabled = Not disableLZP
    End Sub
    ' End Handlers
End Class
