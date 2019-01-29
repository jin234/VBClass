Public Class Form1
    Private Sub ButtonSum_Click(sender As Object, e As EventArgs) Handles ButtonSum.Click
        MessageBox.Show("Sum Is : " & (CDbl(TextBoxNumber1.Text) + CDbl(TextBoxNumber2.Text)), "Sum of Num1 and Num2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNumber1.Text = " "
        TextBoxNumber2.Text = " "
    End Sub
End Class
