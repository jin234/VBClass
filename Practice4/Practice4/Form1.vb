Public Class Form1

    Private Sub ButtonSum_Click(sender As Object, e As EventArgs) Handles ButtonSum.Click
        Dim result As Double = (CDbl(TextBoxNumber1.Text) + CDbl(TextBoxNumber2.Text))
        TextBoxTotal.Text = Format(result, "#,###.00")
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        Dim result As Double = (CDbl(TextBoxNumber1.Text) - CDbl(TextBoxNumber2.Text))
        TextBoxTotal.Text = Format(result, "#,###.00")
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        Dim result As Double = (CDbl(TextBoxNumber1.Text) * CDbl(TextBoxNumber2.Text))
        TextBoxTotal.Text = Format(result, "#,###.00")
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        Dim result As Double = (CDbl(TextBoxNumber1.Text) / CDbl(TextBoxNumber2.Text))
        TextBoxTotal.Text = Format(result, "#,###.00")
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNumber1.Text = ""
        TextBoxNumber2.Text = ""
        TextBoxTotal.Text = ""
    End Sub
End Class
