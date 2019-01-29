Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Salary As Integer = CInt(TextSalary.Text) * 12
        Dim Salary40p As Integer = Salary * 0.4
        Dim tax As Integer = 0
        Dim message As String = ""

        If Salary40p > 60000 Then

            Salary -= 60000
        Else
            Salary -= Salary40p
        End If
        Salary -= 30000
        Dim ASalary As Integer = Salary

        If Salary <= 150000 Then
            message = "ได้รับการยกเว้นภาษี"
        ElseIf Salary <= 300000 Then
            ASalary -= 150000
            tax += ASalary * 0.05
        ElseIf Salary <= 500000 Then
            ASalary -= 200000
            tax += ASalary * 0.1
        ElseIf Salary <= 750000 Then
            ASalary -= 250000
            tax += ASalary * 0.15
        ElseIf Salary <= 1000000 Then
            ASalary -= 250000
            tax += ASalary * 0.2
        ElseIf Salary <= 2000000 Then
            ASalary -= 1000000
            tax += ASalary * 0.25
        ElseIf Salary <= 400000 Then
            ASalary -= 2000000
            tax += ASalary * 0.3
        Else
            tax += ASalary * 0.35



        End If

        If tax <> 0 Then
            LabelText.Text = tax
        Else
            LabelText.Text = message
        End If

    End Sub

End Class
