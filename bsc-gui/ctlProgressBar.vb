Imports System
Imports System.Exception
Public Class ctlProgressBar
    Public Event ProgressBarFull()
    Public Event ProgressBarEmpty()

    Public Sub SetPercent(ByVal value As Integer)
        If value >= 0 And value <= 100 Then
            prgBar.Value = ((prgBar.Maximum - prgBar.Minimum) * value) / 100 + prgBar.Minimum
        End If
    End Sub

    Public Function GetPercent() As Integer
        Return (100 * prgBar.Value) / (prgBar.Maximum - prgBar.Minimum)
    End Function

    ' Reset to minimum filled / default state
    Public Sub Reset()
        prgBar.Value = prgBar.Minimum
    End Sub

    ' Increment Value by 1% or {value}%
    Public Sub Increment(Optional ByVal value As Integer = 1)
        Try
            If prgBar.Value = 100 Then
                ' Need something to handle this gracfully
                RaiseEvent ProgressBarFull()
            End If

            ' No need to Handle -ve coz unsigned
            If (value + GetPercent() > 100) Or (value < 0) Then
                Throw New ArgumentOutOfRangeException
            Else
                prgBar.Value += (value / 100) * (prgBar.Maximum - prgBar.Minimum)
            End If

        Catch ex As ArgumentOutOfRangeException
            ' Do something?
        End Try

    End Sub

    ' Decrement Value by 1 or {value}
    Public Sub Decrement(Optional ByVal value As UInteger = 1)
        Try
            If prgBar.Value = 0 Then
                ' Need something to handle this gracfully
                RaiseEvent ProgressBarEmpty()
            End If

            ' No need to Handle -ve coz unsigned
            If (value > GetPercent()) Or (value < 0) Then
                Throw New ArgumentOutOfRangeException
            Else
                prgBar.Value += (value / 100) * (prgBar.Maximum - prgBar.Minimum)
            End If

        Catch ex As ArgumentOutOfRangeException
            ' Do something?
        End Try
    End Sub

End Class
