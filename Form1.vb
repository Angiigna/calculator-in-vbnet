Public Class Form1
    Dim number1 As Decimal
    Dim number2 As Decimal
    Dim solution As Decimal
    Dim operate As String
    Dim nooperation As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "1"
            Else
                TextBox.Text = "1"
            End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "2"
            Else
                TextBox.Text = "2"
            End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "3"
            Else
                TextBox.Text = "3"
            End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "4"
            Else
                TextBox.Text = "4"
            End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "5"
            Else
                TextBox.Text = "5"
            End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "6"
            Else
                TextBox.Text = "6"
            End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "7"
            Else
                TextBox.Text = "7"
            End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "8"
            Else
                TextBox.Text = "8"
            End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "9"
            Else
                TextBox.Text = "9"
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
            If TextBox.Text <> "0" Then
                TextBox.Text += "0"
            Else
                TextBox.Text = "0"
        End If
    End Sub

    Private Sub Buttonc_Click(sender As Object, e As EventArgs) Handles Buttonc.Click
        TextBox.Text = "0"
    End Sub

    Private Sub Buttonplus_Click(sender As Object, e As EventArgs) Handles Buttonplus.Click
        number1 = (TextBox.Text)
        TextBox.Text = "0"
        nooperation = False
        operate = "+"
    End Sub

    Private Sub Buttonequal_Click(sender As Object, e As EventArgs) Handles Buttonequal.Click
        If nooperation = False Then
            number2 = (TextBox.Text)
            If operate = "+" Then
                solution = number1 + number2
                TextBox.Text = solution
            ElseIf operate = "-" Then
                solution = number1 - number2
                TextBox.Text = solution
            ElseIf operate = "*" Then
                solution = number1 * number2
                TextBox.Text = solution
            ElseIf operate = "/" Then
                solution = number1 / number2
                TextBox.Text = solution
            End If
        End If
        nooperation = True

    End Sub

    Private Sub Buttonminus_Click(sender As Object, e As EventArgs) Handles Buttonminus.Click
        number1 = (TextBox.Text)
        TextBox.Text = "0"
        nooperation = False
        operate = "-"
    End Sub

    Private Sub Buttonmultiply_Click(sender As Object, e As EventArgs) Handles Buttonmultiply.Click
        number1 = (TextBox.Text)
        TextBox.Text = "0"
        nooperation = False
        operate = "*"
    End Sub

    Private Sub Buttondivide_Click(sender As Object, e As EventArgs) Handles Buttondivide.Click
        number1 = (TextBox.Text)
        TextBox.Text = "0"
        nooperation = False
        operate = "/"
    End Sub
End Class
