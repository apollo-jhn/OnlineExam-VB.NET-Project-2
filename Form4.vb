Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get all the scores
        Dim score_t1 As Integer = Form1.Test1_Score
        Dim score_t2 As Integer = Form2.Test2_score
        Dim score_t3 As Integer = Form3.Test3_score
        Dim score_main As Double

        score_main = ((score_t1 + score_t2 + score_t3) / 30) * 100

        Dim all_score As String
        all_score = "Test 1: " + score_t1.ToString + "/10\nTest 2: " + score_t2.ToString + "/10\nTest 3: " + score_t3.ToString + "/10"
        all_score = Replace(all_score, "\n", Environment.NewLine)
        Label3.Text = all_score


        Dim string_score_main As String = score_main.ToString
        Label2.Text = String.Concat(string_score_main.AsSpan(0, 4), "/100")

        If score_main >= 0 Then
            If score_main >= 50 Then
                If score_main > 75 Then
                    Label1.Text = "Congratulations, Very good indeed!"
                    Me.BackColor = Color.FromArgb(52, 78, 65)
                End If
            Else
                Label1.Text = "Not Bad, Very Good!"
                Me.BackColor = Color.FromArgb(252, 163, 17)
            End If
        Else
            Label1.Text = "Better luck next time!"
            Me.BackColor = Color.FromArgb(214, 40, 40)
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        ' Hide this form
        Me.Hide()
        ' Show Form 3
        Form3.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Thank you for using the application", "Exit") = DialogResult.OK Then
            Form1.Close()
            Form2.Close()
            Form3.Close()
            Me.Close()
        End If
    End Sub
End Class