<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelSum = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelAVG = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelINPUT = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelSum
        '
        Me.LabelSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSum.Location = New System.Drawing.Point(111, 70)
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(145, 22)
        Me.LabelSum.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "คำนวน"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextNum
        '
        Me.TextNum.Location = New System.Drawing.Point(111, 23)
        Me.TextNum.Name = "TextNum"
        Me.TextNum.Size = New System.Drawing.Size(80, 20)
        Me.TextNum.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ผลรวม"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ตัวเลขที่จะรับ"
        '
        'LabelAVG
        '
        Me.LabelAVG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelAVG.Location = New System.Drawing.Point(111, 108)
        Me.LabelAVG.Name = "LabelAVG"
        Me.LabelAVG.Size = New System.Drawing.Size(145, 22)
        Me.LabelAVG.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ค่าเฉลี่ย"
        '
        'LabelINPUT
        '
        Me.LabelINPUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelINPUT.Location = New System.Drawing.Point(111, 148)
        Me.LabelINPUT.Name = "LabelINPUT"
        Me.LabelINPUT.Size = New System.Drawing.Size(145, 99)
        Me.LabelINPUT.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "เลขที่รับมา"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 291)
        Me.Controls.Add(Me.LabelINPUT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelAVG)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelSum)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sum and avg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSum As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelAVG As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelINPUT As Label
    Friend WithEvents Label6 As Label
End Class
