Public Class Form1
    Dim Number1 As Integer
    Dim Number2 As Integer
    Dim Answer As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Number1 = Num1.Text
        Number2 = Num2.Text
        Answer = Number1 + Number2
        MessageBox.Show(Answer)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Number1 = Num1.Text
        Number2 = Num2.Text
        Answer = Number1 - Number2
        MessageBox.Show(Answer)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Number1 = Num1.Text
        Number2 = Num2.Text
        Answer = Number1 * Number2
        MessageBox.Show(Answer)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Number1 = Num1.Text
        Number2 = Num2.Text
        Answer = Number1 / Number2
        MessageBox.Show(Answer)
    End Sub
End Class
