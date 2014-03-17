Public Class ctlBtnGrpConfirm
    Event ActionCancel()
    Event ActionOK()

    ' Proxy Init
    Private Sub ctlBtnGrpConfirm_Initialize()

    End Sub

    Private Sub ctlBtnGrpConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Builder method pls
        RaiseEvent ActionOK()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RaiseEvent ActionCancel()
    End Sub
End Class
