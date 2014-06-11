Imports System
Imports System.Management

Public Class Helpers
    Dim GPUName As String = Nothing
    Dim CUDAGPUName As String = "NVIDIA"

    Public Function GetGPUName() As String
        ' Begin Try-Catch
        Try
            ' New MgmtObjSearcher to launch a WMI Query
            Dim wmiResults As New ManagementObjectSearcher _
                ("root\CIMV2", "SELECT * FROM Win32_VideoController ")

            ' Iterate through results of query to get the Name property
            For Each wmiResult As ManagementObject In wmiResults.Get()
                GPUName = wmiResult.GetPropertyValue("Name").ToString
            Next
        Catch err As ManagementException
            MsgBox(err.Message)
        End Try

        ' Return what we found
        Return GPUName
    End Function

    ' Detect if VideoCard supports CUDA
    ' I think this is bad practice...
    Public Function isCUDAEnabled() As Boolean
        Dim localHelper As New Helpers
        Dim tmpGPUName As String = localHelper.GetGPUName()
        Dim GPUFoud As Boolean = False
        If InStr(tmpGPUName.ToUpper, CUDAGPUName) Then
            GPUFoud = True
        Else
            GPUFoud = False
        End If
        Return GPUFoud
    End Function

    ' Command builder Method
    ' Figure out how to refactor later
    ' Convert variables to an Enum(?) and work with a single Getter
    ' and magic numbers(?)
    Public Function BuildCommand() As String
        Return ""
    End Function
End Class
