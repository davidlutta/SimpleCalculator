Public Class Calculator
    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles Num1.Click, Num2.Click, Num3.Click, Num4.Click, Num5.Click, Num6.Click, Num7.Click, Num8.Click, Num9.Click, Num0.Click, NumDot.Click, OpClear.Click, OpDivide.Click, OpEquals.Click, OpMinus.Click, OpMultiply.Click, OpPlus.Click
        'Getting the clicked Button then casting it to a button object
        Dim buttonClicked As Button = CType(sender, Button)
        If buttonClicked.Name = "Num0" Then
            ResultTextBox.Text = ResultTextBox.Text + "0"
        End If
        If buttonClicked.Name = "Num1" Then
            ResultTextBox.Text = ResultTextBox.Text + "1"
        End If
        If buttonClicked.Name = "Num2" Then
            ResultTextBox.Text = ResultTextBox.Text + "2"
        End If
        If buttonClicked.Name = "Num3" Then
            ResultTextBox.Text = ResultTextBox.Text + "3"
        End If
        If buttonClicked.Name = "Num4" Then
            ResultTextBox.Text = ResultTextBox.Text + "4"
        End If
        If buttonClicked.Name = "Num5" Then
            ResultTextBox.Text = ResultTextBox.Text + "5"
        End If
        If buttonClicked.Name = "Num6" Then
            ResultTextBox.Text = ResultTextBox.Text + "6"
        End If
        If buttonClicked.Name = "Num7" Then
            ResultTextBox.Text = ResultTextBox.Text + "7"
        End If
        If buttonClicked.Name = "Num8" Then
            ResultTextBox.Text = ResultTextBox.Text + "8"
        End If
        If buttonClicked.Name = "Num9" Then
            ResultTextBox.Text = ResultTextBox.Text + "9"
        End If
        If buttonClicked.Name = "NumDot" Then
            ResultTextBox.Text = ResultTextBox.Text + "."
        End If
        If buttonClicked.Name = "OpEquals" Then
            'Getting the String inside the textbox
            Dim equation = ResultTextBox.Text
            'Getting the result 
            Dim result As String = New DataTable().Compute(equation, Nothing)
            ResultTextBox.Text = result
        End If
        If buttonClicked.Name = "OpMinus" Then
            ResultTextBox.Text = ResultTextBox.Text + "-"
        End If
        If buttonClicked.Name = "OpPlus" Then
            ResultTextBox.Text = ResultTextBox.Text + "+"
        End If
        If buttonClicked.Name = "OpMultiply" Then
            ResultTextBox.Text = ResultTextBox.Text + "*"
        End If
        If buttonClicked.Name = "OpDivide" Then
            ResultTextBox.Text = ResultTextBox.Text + "/"
        End If
        If buttonClicked.Name = "OpClear" Then
            ResultTextBox.Text = ""
        End If


    End Sub
End Class
