Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim constr As String = "server=(localDB)\MSSQLLocalDB;AttachDBFilename =D:\Northwind.mdf"
        Dim conn As New SqlConnection(constr)
        conn.Open()

        Dim sql As String = "select picture from categories
                             where categoryid = " & TextBox1.Text

        Dim cmd As New SqlCommand(sql, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adapter.Fill(data, "pic")

        Dim pic() As Byte = data.Tables("pic").Rows(0)("picture")
        Dim streampicture As New MemoryStream(pic)
        Try
            streampicture.Write(pic, 78, pic.Length - 78)

            PictureBox1.Image = Image.FromStream(streampicture)

        Catch errors As Exception

            MessageBox.Show("nodata")
            TextBox1.Clear()
        End Try
        conn.Close()

    End Sub

End Class
