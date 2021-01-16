Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m_hello As String = "Hello"
        ShowMessage(m_hello)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text

        ' add method to forture-tekking(占い)
        ' 大吉、中吉、小吉、凶、大凶　の５つをランダムでMsgBox（）で表示
        Dim forture_telling_str As String() = {"大吉", "中吉", "小吉", "凶", "大凶"}

        ' ランダム処理
        Dim bytesData As Byte()

        'Shift JISとして文字列に変換
        bytesData = System.Text.Encoding.GetEncoding(932).GetBytes(str)

        ' 合計を加算
        Dim sum As Integer = 0
        For i As Integer = 0 To bytesData.Count - 1
            sum += bytesData(i)
        Next
        MsgBox(forture_telling_str(sum Mod 5))

        ' 文字コード出力
        TextBox2.Text = BitConverter.ToString(bytesData)
    End Sub


End Class
