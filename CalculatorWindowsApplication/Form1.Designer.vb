<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.Num7 = New System.Windows.Forms.Button()
        Me.Num8 = New System.Windows.Forms.Button()
        Me.Num9 = New System.Windows.Forms.Button()
        Me.OpDivide = New System.Windows.Forms.Button()
        Me.OpMultiply = New System.Windows.Forms.Button()
        Me.Num6 = New System.Windows.Forms.Button()
        Me.Num5 = New System.Windows.Forms.Button()
        Me.Num4 = New System.Windows.Forms.Button()
        Me.OpMinus = New System.Windows.Forms.Button()
        Me.Num3 = New System.Windows.Forms.Button()
        Me.Num2 = New System.Windows.Forms.Button()
        Me.Num1 = New System.Windows.Forms.Button()
        Me.OpPlus = New System.Windows.Forms.Button()
        Me.OpEquals = New System.Windows.Forms.Button()
        Me.Num0 = New System.Windows.Forms.Button()
        Me.NumDot = New System.Windows.Forms.Button()
        Me.OpClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Enabled = False
        Me.ResultTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTextBox.Location = New System.Drawing.Point(15, 13)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.ReadOnly = True
        Me.ResultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ResultTextBox.Size = New System.Drawing.Size(414, 38)
        Me.ResultTextBox.TabIndex = 0
        Me.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Num7
        '
        Me.Num7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num7.Location = New System.Drawing.Point(15, 65)
        Me.Num7.Name = "Num7"
        Me.Num7.Size = New System.Drawing.Size(98, 76)
        Me.Num7.TabIndex = 1
        Me.Num7.Text = "7"
        Me.Num7.UseVisualStyleBackColor = True
        '
        'Num8
        '
        Me.Num8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num8.Location = New System.Drawing.Point(121, 65)
        Me.Num8.Name = "Num8"
        Me.Num8.Size = New System.Drawing.Size(98, 76)
        Me.Num8.TabIndex = 2
        Me.Num8.Text = "8"
        Me.Num8.UseVisualStyleBackColor = True
        '
        'Num9
        '
        Me.Num9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num9.Location = New System.Drawing.Point(225, 65)
        Me.Num9.Name = "Num9"
        Me.Num9.Size = New System.Drawing.Size(98, 76)
        Me.Num9.TabIndex = 3
        Me.Num9.Text = "9"
        Me.Num9.UseVisualStyleBackColor = True
        '
        'OpDivide
        '
        Me.OpDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.OpDivide.Location = New System.Drawing.Point(331, 65)
        Me.OpDivide.Name = "OpDivide"
        Me.OpDivide.Size = New System.Drawing.Size(98, 76)
        Me.OpDivide.TabIndex = 4
        Me.OpDivide.Text = "/"
        Me.OpDivide.UseVisualStyleBackColor = True
        '
        'OpMultiply
        '
        Me.OpMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.OpMultiply.Location = New System.Drawing.Point(331, 147)
        Me.OpMultiply.Name = "OpMultiply"
        Me.OpMultiply.Size = New System.Drawing.Size(98, 76)
        Me.OpMultiply.TabIndex = 8
        Me.OpMultiply.Text = "*"
        Me.OpMultiply.UseVisualStyleBackColor = True
        '
        'Num6
        '
        Me.Num6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num6.Location = New System.Drawing.Point(225, 147)
        Me.Num6.Name = "Num6"
        Me.Num6.Size = New System.Drawing.Size(98, 76)
        Me.Num6.TabIndex = 7
        Me.Num6.Text = "6"
        Me.Num6.UseVisualStyleBackColor = True
        '
        'Num5
        '
        Me.Num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num5.Location = New System.Drawing.Point(121, 147)
        Me.Num5.Name = "Num5"
        Me.Num5.Size = New System.Drawing.Size(98, 76)
        Me.Num5.TabIndex = 6
        Me.Num5.Text = "5"
        Me.Num5.UseVisualStyleBackColor = True
        '
        'Num4
        '
        Me.Num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num4.Location = New System.Drawing.Point(15, 147)
        Me.Num4.Name = "Num4"
        Me.Num4.Size = New System.Drawing.Size(98, 76)
        Me.Num4.TabIndex = 5
        Me.Num4.Text = "4"
        Me.Num4.UseVisualStyleBackColor = True
        '
        'OpMinus
        '
        Me.OpMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.OpMinus.Location = New System.Drawing.Point(331, 229)
        Me.OpMinus.Name = "OpMinus"
        Me.OpMinus.Size = New System.Drawing.Size(98, 76)
        Me.OpMinus.TabIndex = 12
        Me.OpMinus.Text = "-"
        Me.OpMinus.UseVisualStyleBackColor = True
        '
        'Num3
        '
        Me.Num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num3.Location = New System.Drawing.Point(225, 229)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(98, 76)
        Me.Num3.TabIndex = 11
        Me.Num3.Text = "3"
        Me.Num3.UseVisualStyleBackColor = True
        '
        'Num2
        '
        Me.Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num2.Location = New System.Drawing.Point(121, 229)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(98, 76)
        Me.Num2.TabIndex = 10
        Me.Num2.Text = "2"
        Me.Num2.UseVisualStyleBackColor = True
        '
        'Num1
        '
        Me.Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num1.Location = New System.Drawing.Point(15, 229)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(98, 76)
        Me.Num1.TabIndex = 9
        Me.Num1.Text = "1"
        Me.Num1.UseVisualStyleBackColor = True
        '
        'OpPlus
        '
        Me.OpPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.OpPlus.Location = New System.Drawing.Point(331, 311)
        Me.OpPlus.Name = "OpPlus"
        Me.OpPlus.Size = New System.Drawing.Size(98, 76)
        Me.OpPlus.TabIndex = 16
        Me.OpPlus.Text = "+"
        Me.OpPlus.UseVisualStyleBackColor = True
        '
        'OpEquals
        '
        Me.OpEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.OpEquals.Location = New System.Drawing.Point(225, 311)
        Me.OpEquals.Name = "OpEquals"
        Me.OpEquals.Size = New System.Drawing.Size(98, 76)
        Me.OpEquals.TabIndex = 15
        Me.OpEquals.Text = "="
        Me.OpEquals.UseVisualStyleBackColor = True
        '
        'Num0
        '
        Me.Num0.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Num0.Location = New System.Drawing.Point(121, 311)
        Me.Num0.Name = "Num0"
        Me.Num0.Size = New System.Drawing.Size(98, 76)
        Me.Num0.TabIndex = 14
        Me.Num0.Text = "0"
        Me.Num0.UseVisualStyleBackColor = True
        '
        'NumDot
        '
        Me.NumDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.NumDot.Location = New System.Drawing.Point(15, 311)
        Me.NumDot.Name = "NumDot"
        Me.NumDot.Size = New System.Drawing.Size(98, 76)
        Me.NumDot.TabIndex = 13
        Me.NumDot.Text = "."
        Me.NumDot.UseVisualStyleBackColor = True
        '
        'OpClear
        '
        Me.OpClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.OpClear.Location = New System.Drawing.Point(15, 393)
        Me.OpClear.Name = "OpClear"
        Me.OpClear.Size = New System.Drawing.Size(413, 76)
        Me.OpClear.TabIndex = 17
        Me.OpClear.Text = "Clear"
        Me.OpClear.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 491)
        Me.Controls.Add(Me.OpClear)
        Me.Controls.Add(Me.OpPlus)
        Me.Controls.Add(Me.OpEquals)
        Me.Controls.Add(Me.Num0)
        Me.Controls.Add(Me.NumDot)
        Me.Controls.Add(Me.OpMinus)
        Me.Controls.Add(Me.Num3)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.OpMultiply)
        Me.Controls.Add(Me.Num6)
        Me.Controls.Add(Me.Num5)
        Me.Controls.Add(Me.Num4)
        Me.Controls.Add(Me.OpDivide)
        Me.Controls.Add(Me.Num9)
        Me.Controls.Add(Me.Num8)
        Me.Controls.Add(Me.Num7)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Calculator"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents Num7 As Button
    Friend WithEvents Num8 As Button
    Friend WithEvents Num9 As Button
    Friend WithEvents OpDivide As Button
    Friend WithEvents OpMultiply As Button
    Friend WithEvents Num6 As Button
    Friend WithEvents Num5 As Button
    Friend WithEvents Num4 As Button
    Friend WithEvents OpMinus As Button
    Friend WithEvents Num3 As Button
    Friend WithEvents Num2 As Button
    Friend WithEvents Num1 As Button
    Friend WithEvents OpPlus As Button
    Friend WithEvents OpEquals As Button
    Friend WithEvents Num0 As Button
    Friend WithEvents NumDot As Button
    Friend WithEvents OpClear As Button
End Class
