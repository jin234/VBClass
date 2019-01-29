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
        Me.ButtonSum = New System.Windows.Forms.Button()
        Me.LabelNumber2 = New System.Windows.Forms.Label()
        Me.TextBoxNumber2 = New System.Windows.Forms.TextBox()
        Me.LabelNumber1 = New System.Windows.Forms.Label()
        Me.TextBoxNumber1 = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonSum
        '
        Me.ButtonSum.Location = New System.Drawing.Point(35, 92)
        Me.ButtonSum.Name = "ButtonSum"
        Me.ButtonSum.Size = New System.Drawing.Size(96, 36)
        Me.ButtonSum.TabIndex = 12
        Me.ButtonSum.Text = "Sum"
        Me.ButtonSum.UseVisualStyleBackColor = True
        '
        'LabelNumber2
        '
        Me.LabelNumber2.AutoSize = True
        Me.LabelNumber2.Location = New System.Drawing.Point(32, 53)
        Me.LabelNumber2.Name = "LabelNumber2"
        Me.LabelNumber2.Size = New System.Drawing.Size(53, 13)
        Me.LabelNumber2.TabIndex = 10
        Me.LabelNumber2.Text = "Number 2"
        '
        'TextBoxNumber2
        '
        Me.TextBoxNumber2.Location = New System.Drawing.Point(102, 50)
        Me.TextBoxNumber2.Name = "TextBoxNumber2"
        Me.TextBoxNumber2.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxNumber2.TabIndex = 9
        '
        'LabelNumber1
        '
        Me.LabelNumber1.AutoSize = True
        Me.LabelNumber1.Location = New System.Drawing.Point(32, 27)
        Me.LabelNumber1.Name = "LabelNumber1"
        Me.LabelNumber1.Size = New System.Drawing.Size(53, 13)
        Me.LabelNumber1.TabIndex = 8
        Me.LabelNumber1.Text = "Number 1"
        '
        'TextBoxNumber1
        '
        Me.TextBoxNumber1.Location = New System.Drawing.Point(102, 24)
        Me.TextBoxNumber1.Name = "TextBoxNumber1"
        Me.TextBoxNumber1.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxNumber1.TabIndex = 7
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(152, 92)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(99, 36)
        Me.ButtonClear.TabIndex = 13
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 148)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonSum)
        Me.Controls.Add(Me.LabelNumber2)
        Me.Controls.Add(Me.TextBoxNumber2)
        Me.Controls.Add(Me.LabelNumber1)
        Me.Controls.Add(Me.TextBoxNumber1)
        Me.Name = "Form1"
        Me.Text = "Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSum As Button
    Friend WithEvents LabelNumber2 As Label
    Friend WithEvents TextBoxNumber2 As TextBox
    Friend WithEvents LabelNumber1 As Label
    Friend WithEvents TextBoxNumber1 As TextBox
    Friend WithEvents ButtonClear As Button
End Class
