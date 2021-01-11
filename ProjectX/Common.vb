
Module Common

    Public Sub ShowMessage(str As String)
        If Not str Is Nothing Then
            MsgBox(str)
        Else
            MsgBox("文字列はNothing です！")
        End If
    End Sub
End Module
