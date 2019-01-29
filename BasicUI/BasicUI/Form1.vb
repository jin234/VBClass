Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        LabelFullNameOut.Text = TextBoxName.Text & " " & TextBoxSurname.Text
    End Sub
End Class
