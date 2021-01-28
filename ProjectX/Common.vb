
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

    Public Function GetCSV(file_path As String) As List(Of String)
        Dim list As New List(Of String)

        ' csv ファイルから読み込み処理
        Using textFile As New FileIO.TextFieldParser(file_path) ' -- デフォルト encoding は UTF8
            ' --- デリミターをタブと定義する
            textFile.TextFieldType = FileIO.FieldType.Delimited
            textFile.SetDelimiters(vbTab)    ' -- カンマ区切りの場合はカッコ内を "," にします
            ' --- 行を文字型配列（currentRow）に読み込み、各列を DataGridView に格納する
            Dim currentRow As String() ' -- 文字型配列
            Dim myRow As Integer = 0
            Dim myCol As Integer = 0
            ' ---▼▼ 行ループ
            While Not textFile.EndOfData
                currentRow = textFile.ReadFields() ' -- １行を文字型配列に格納
                Dim currentColumn As String
                ' ---▼ 列ループ：１行分の列を埋める
                For Each currentColumn In currentRow

                    Dim str As String() = currentColumn.Split(",")
                    For Each item In str
                        list.Add(item)
                    Next
                    myCol += 1
                Next ' --▲ 列ループ
                myCol = 0
                myRow += 1
            End While ' --▲▲ 行ループ
            ' --- 入力ファイルを閉じる
        End Using

        GetCSV = list
    End Function
End Module
