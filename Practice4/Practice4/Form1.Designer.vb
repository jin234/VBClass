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
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonSum = New System.Windows.Forms.Button()
        Me.LabelNumber2 = New System.Windows.Forms.Label()
        Me.TextBoxNumber2 = New System.Windows.Forms.TextBox()
        Me.LabelNumber1 = New System.Windows.Forms.Label()
        Me.TextBoxNumber1 = New System.Windows.Forms.TextBox()
        Me.ButtonMinus = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivision = New System.Windows.Forms.Button()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(358, 116)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(94, 36)
        Me.ButtonClear.TabIndex = 19
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonSum
        '
        Me.ButtonSum.Location = New System.Drawing.Point(358, 29)
        Me.ButtonSum.Name = "ButtonSum"
        Me.ButtonSum.Size = New System.Drawing.Size(42, 36)
        Me.ButtonSum.TabIndex = 18
        Me.ButtonSum.Text = "+"
        Me.ButtonSum.UseVisualStyleBackColor = True
        '
        'LabelNumber2
        '
        Me.LabelNumber2.AutoSize = True
        Me.LabelNumber2.Location = New System.Drawing.Point(49, 77)
        Me.LabelNumber2.Name = "LabelNumber2"
        Me.LabelNumber2.Size = New System.Drawing.Size(53, 13)
        Me.LabelNumber2.TabIndex = 17
        Me.LabelNumber2.Text = "Number 2"
        '
        'TextBoxNumber2
        '
        Me.TextBoxNumber2.Location = New System.Drawing.Point(119, 74)
        Me.TextBoxNumber2.Name = "TextBoxNumber2"
        Me.TextBoxNumber2.Size = New System.Drawing.Size(223, 20)
        Me.TextBoxNumber2.TabIndex = 16
        '
        'LabelNumber1
        '
        Me.LabelNumber1.AutoSize = True
        Me.LabelNumber1.Location = New System.Drawing.Point(49, 32)
        Me.LabelNumber1.Name = "LabelNumber1"
        Me.LabelNumber1.Size = New System.Drawing.Size(53, 13)
        Me.LabelNumber1.TabIndex = 15
        Me.LabelNumber1.Text = "Number 1"
        '
        'TextBoxNumber1
        '
        Me.TextBoxNumber1.Location = New System.Drawing.Point(119, 29)
        Me.TextBoxNumber1.Name = "TextBoxNumber1"
        Me.TextBoxNumber1.Size = New System.Drawing.Size(223, 20)
        Me.TextBoxNumber1.TabIndex = 14
        '
        'ButtonMinus
        '
        Me.ButtonMinus.Location = New System.Drawing.Point(410, 29)
        Me.ButtonMinus.Name = "ButtonMinus"
        Me.ButtonMinus.Size = New System.Drawing.Size(42, 36)
        Me.ButtonMinus.TabIndex = 20
        Me.ButtonMinus.Text = "-"
        Me.ButtonMinus.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Location = New System.Drawing.Point(358, 74)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(42, 36)
        Me.ButtonMultiply.TabIndex = 21
        Me.ButtonMultiply.Text = "*"
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonDivision
        '
        Me.ButtonDivision.Location = New System.Drawing.Point(410, 74)
        Me.ButtonDivision.Name = "ButtonDivision"
        Me.ButtonDivision.Size = New System.Drawing.Size(42, 36)
        Me.ButtonDivision.TabIndex = 22
        Me.ButtonDivision.Text = "/"
        Me.ButtonDivision.UseVisualStyleBackColor = True
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(119, 116)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(223, 20)
        Me.TextBoxTotal.TabIndex = 24
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(49, 119)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(31, 13)
        Me.LabelTotal.TabIndex = 23
        Me.LabelTotal.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 158)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.ButtonDivision)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonMinus)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonSum)
        Me.Controls.Add(Me.LabelNumber2)
        Me.Controls.Add(Me.TextBoxNumber2)
        Me.Controls.Add(Me.LabelNumber1)
        Me.Controls.Add(Me.TextBoxNumber1)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonSum As Button
    Friend WithEvents LabelNumber2 As Label
    Friend WithEvents TextBoxNumber2 As TextBox
    Friend WithEvents LabelNumber1 As Label
    Friend WithEvents TextBoxNumber1 As TextBox
    Friend WithEvents ButtonMinus As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivision As Button
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents LabelTotal As Label
End Class
