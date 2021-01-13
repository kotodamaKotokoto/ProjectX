
Module Common

    Public Sub ShowMessage(str As String)
        If Not str Is Nothing Then
            If str.Equals("") Then
                MsgBox("文字列は(空欄)です！")
            Else
                MsgBox(str)
            End If
        Else
            MsgBox("文字列はNothing です！")
        End If
    End Sub
End Module
