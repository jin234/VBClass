Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim RNG As Random = New Random
        Dim GenNum As Integer = RNG.Next(0, 99)
        Dim Tried As Integer = 7

        For x = Tried - 1 To -1 Step -1

            Dim GuessNum As Integer = InputBox(" กรุณาป้อนตัวเลขที่ต้องการทาย ")
            If x = -1 Then
                MessageBox.Show("จบเกมส์ คุุณแพ้แล้ว", " ", MessageBoxButtons.OK)
            ElseIf GuessNum < GenNum Then
                MessageBox.Show("มากกว่านี้", " ", MessageBoxButtons.OK)
            ElseIf GuessNum > GenNum Then
                MessageBox.Show("น้อยกว่านี้", " ", MessageBoxButtons.OK)
            ElseIf GuessNum = GenNum Then
                MessageBox.Show(GenNum & "....ถูกต้อง คุุณคือผู้ชนะ", " ", MessageBoxButtons.OK)
                Exit For
            Else
                MessageBox.Show("กรุณาป้อนตัวเลข", " ", MessageBoxButtons.OK)
                x += 1
            End If
            Label2.Text = x

        Next
        Label2.Text = 7
        Button1.Enabled = True
    End Sub

End Class
