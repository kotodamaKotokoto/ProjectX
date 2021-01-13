Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m_hello As String = "Hello"
        ShowMessage(m_hello)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowMessage(TextBox1.Text)
    End Sub
End Class
