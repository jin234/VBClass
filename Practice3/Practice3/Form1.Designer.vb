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
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.LabelVat = New System.Windows.Forms.Label()
        Me.Button7p = New System.Windows.Forms.Button()
        Me.Button10p = New System.Windows.Forms.Button()
        Me.Button15p = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Location = New System.Drawing.Point(39, 38)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(31, 13)
        Me.LabelPrice.TabIndex = 0
        Me.LabelPrice.Text = "Price"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(84, 35)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxPrice.TabIndex = 1
        '
        'LabelVat
        '
        Me.LabelVat.AutoSize = True
        Me.LabelVat.Location = New System.Drawing.Point(39, 66)
        Me.LabelVat.Name = "LabelVat"
        Me.LabelVat.Size = New System.Drawing.Size(23, 13)
        Me.LabelVat.TabIndex = 2
        Me.LabelVat.Text = "Vat"
        '
        'Button7p
        '
        Me.Button7p.Location = New System.Drawing.Point(84, 61)
        Me.Button7p.Name = "Button7p"
        Me.Button7p.Size = New System.Drawing.Size(75, 23)
        Me.Button7p.TabIndex = 3
        Me.Button7p.Text = "7 %"
        Me.Button7p.UseVisualStyleBackColor = True
        '
        'Button10p
        '
        Me.Button10p.Location = New System.Drawing.Point(165, 61)
        Me.Button10p.Name = "Button10p"
        Me.Button10p.Size = New System.Drawing.Size(75, 23)
        Me.Button10p.TabIndex = 4
        Me.Button10p.Text = "10 %"
        Me.Button10p.UseVisualStyleBackColor = True
        '
        'Button15p
        '
        Me.Button15p.Location = New System.Drawing.Point(246, 61)
        Me.Button15p.Name = "Button15p"
        Me.Button15p.Size = New System.Drawing.Size(75, 23)
        Me.Button15p.TabIndex = 5
        Me.Button15p.Text = "15 %"
        Me.Button15p.UseVisualStyleBackColor = True
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(39, 94)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(31, 13)
        Me.LabelTotal.TabIndex = 6
        Me.LabelTotal.Text = "Total"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(84, 94)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(237, 20)
        Me.TextBoxTotal.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 157)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Button15p)
        Me.Controls.Add(Me.Button10p)
        Me.Controls.Add(Me.Button7p)
        Me.Controls.Add(Me.LabelVat)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.LabelPrice)
        Me.Name = "Form1"
        Me.Text = "Vat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPrice As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents LabelVat As Label
    Friend WithEvents Button7p As Button
    Friend WithEvents Button10p As Button
    Friend WithEvents Button15p As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents TextBoxTotal As TextBox
End Class
