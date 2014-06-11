Public Class CtlAlgs
    ' Boolean options
    Dim useSortTransform As Boolean
    Dim useCudaAccel As Boolean
    Dim useStatEntEnc As Boolean

    'Unsigned Integer Options
    Dim sortTransformOrder As UInteger

    Dim helper As New Helpers

    Public Event MultipleRadioButtonsCheckedError()

    ' Proxy Init Module
    Private Sub ctlAlgs_Initialize()
        ' Algorithm options
        useStatEntEnc = rBtnEntEncStatic.Checked
        useSortTransform = chkBoxSortTransform.Checked
        useCudaAccel = chkBoxCUDA.Checked
    End Sub

    ' Load Handler
    Private Sub ctlAlgs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctlAlgs_Initialize()
        chkBoxCUDA.Enabled = helper.isCUDAEnabled
    End Sub
    ' End Handler

    ' Handler for radio button states
    Private Sub rBtnEntEncStatic_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnEntEncStatic.CheckedChanged, rBtnEntEncAdaptive.CheckedChanged
        ' Ensure 
        If Not rBtnEntEncAdaptive.Checked And rBtnEntEncStatic.Checked Then
            useStatEntEnc = rBtnEntEncStatic.Checked
        Else
            RaiseEvent MultipleRadioButtonsCheckedError()
        End If
    End Sub
    ' End Handler

    ' Handle Sort Transform Checkbox
    Private Sub chkBoxSortTransform_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxSortTransform.CheckedChanged
        useSortTransform = chkBoxSortTransform.Checked

        ' Else clause: stating the obvious?
        ' Find out more about this stuff in other parts of the project
        If useSortTransform Then
            numSortTransformOder.Enabled = True
        Else
            numSortTransformOder.Enabled = False
        End If
    End Sub
    ' End Handler

    ' Handler for CUDA checkbox (Untested)
    Private Sub chkBoxCUDA_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxCUDA.CheckedChanged
        useCudaAccel = chkBoxCUDA.Checked
    End Sub
    ' End Handler

    ' Handler for sort transform order spinner
    Private Sub numSortTransformOder_ValueChanged(sender As Object, e As EventArgs) Handles numSortTransformOder.ValueChanged
        sortTransformOrder = numSortTransformOder.Value
    End Sub
    ' End Handler
End Class
