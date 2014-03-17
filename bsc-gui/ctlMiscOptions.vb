Public Class ctlMiscOptions
    ' Boolean options, set to False to imply not ticked/selected
    Dim disableParallel As Boolean
    Dim disableMCS As Boolean
    Dim enableRAMPages As Boolean

    ' Proxy Init Method
    Private Sub ctlMiscOptions_Initialize()
        disableParallel = False
        disableMCS = False
        enableRAMPages = False
    End Sub

    ' Handler for initialization
    Private Sub ctlMiscOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctlMiscOptions_Initialize()
    End Sub

    Private Sub chkBoxEnbRAM_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxEnbRAM.CheckedChanged
        enableRAMPages = chkBoxEnbRAM.Checked
    End Sub

    Private Sub chkBoxDsbParallel_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxDsbParallel.CheckedChanged
        disableParallel = chkBoxDsbParallel.Checked

        ' Set nParallel = 1 and update memory usage if multicore caluculations were used
    End Sub

    Private Sub chkBoxDsbMCS_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxDsbMCS.CheckedChanged
        disableMCS = chkBoxDsbMCS.Checked
    End Sub
End Class
