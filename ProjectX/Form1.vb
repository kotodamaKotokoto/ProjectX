Public Class Form1

    Private forture_telling_list As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forture_telling_list = GetCSV("..\../csv/forture_telling.csv")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text

        ' add method to forture-tekking(占い)
        ' 大吉、中吉、小吉、凶、大凶　の５つをランダムでMsgBox（）で表示

        ' ランダム処理
        Dim bytesData As Byte()

        Dim rnd As Random = New Random(1)

        'Shift JISとして文字列に変換
        bytesData = System.Text.Encoding.GetEncoding(932).GetBytes(str)

        ' 合計を加算
        Dim sum As Integer = 0
        For i As Integer = 0 To bytesData.Count - 1
            sum += bytesData(i)
        Next

        MsgBox(forture_telling_list(sum Mod forture_telling_list.Count))

        ' 文字コード出力
        TextBox2.Text = BitConverter.ToString(bytesData)
    End Sub


End Class
