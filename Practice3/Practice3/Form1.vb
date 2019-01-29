Public Class Form1
    Private Sub Button7p_Click(sender As Object, e As EventArgs) Handles Button7p.Click
        Dim vat As Double = 7
        TextBoxTotal.Text = Format(CDbl(TextBoxPrice.Text) * (100 - vat) / 100, "#,###.00") & " Baht"
    End Sub

    Private Sub Button10p_Click(sender As Object, e As EventArgs) Handles Button10p.Click
        Dim vat As Double = 10
        TextBoxTotal.Text = Format(CDbl(TextBoxPrice.Text) * (100 - vat) / 100, "#,###.00") & " Baht"
    End Sub

    Private Sub Button15p_Click(sender As Object, e As EventArgs) Handles Button15p.Click
        Dim vat As Double = 15
        TextBoxTotal.Text = Format(CDbl(TextBoxPrice.Text) * (100 - vat) / 100, "#,###.00") & " Baht"
    End Sub
End Class
