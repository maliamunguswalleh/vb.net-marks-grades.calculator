Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim mark As Single
        mark = TextBox1.Text
        TextBox2.Text = MsgBox("")

        Select Case mark
            Case 90 To 100
                MsgBox("Excelence")
            Case 80 To 89
                MsgBox("very Good")
            Case 70 To 79
                MsgBox("Good")
            Case 60 To 69
                MsgBox("Medium")
            Case 50 To 59
                MsgBox("Pass")
            Case 0 To 49
                MsgBox("Fail")

            Case Else
                MsgBox("Wrong Entry")
        End Select



    End Sub
End Class
