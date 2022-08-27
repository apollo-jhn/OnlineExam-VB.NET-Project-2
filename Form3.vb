Public Class Form3
    Public Property Test3_score As Integer = 0
    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Close()
        Form2.Close()
    End Sub

    Private Sub btn_test3_Start_Click(sender As Object, e As EventArgs) Handles btn_test3_Start.Click
        ' Change hide the press start text
        l_test3_ident_start.Visible = False

        ' Make the groupboxes visible
        gb_test3_question1.Visible = True
        gb_test3_question2.Visible = True
        gb_test3_question3.Visible = True
        gb_test3_question4.Visible = True
        gb_test3_question5.Visible = True
        gb_test3_question6.Visible = True
        gb_test3_question7.Visible = True
        gb_test3_question8.Visible = True
        gb_test3_question9.Visible = True
        gb_test3_question10.Visible = True


        ' Change the state of the Start button
        btn_test3_Start.Enabled = False
        ' Change the color of the button to ~Olivine
        btn_test3_Start.BackColor = Color.FromArgb(173, 193, 120)
        ' Make the Submit Accessable
        btn_test3_Submit.Enabled = True
    End Sub

    Private Sub btn_test3_Previous_Click(sender As Object, e As EventArgs) Handles btn_test3_Previous.Click
        ' Hide this form
        Me.Hide()

        ' Show Form with same location on the screen
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = New Point(Me.Location.X + Me.Width \ 2 - Form2.Width \ 2, Me.Location.Y + Me.Height \ 2 - Form2.Height \ 2)
        Form2.Show()
    End Sub

    Private Sub btn_test3_Submit_Click(sender As Object, e As EventArgs) Handles btn_test3_Submit.Click
        ' Making sure the all the fields has been anwered
        If MessageBox.Show("You can't change the answer after submitting", "Are you sure to submit?", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            ' Lock all checkboxes
            cb_test3_question1_1.Enabled = False
            cb_test3_question1_2.Enabled = False
            cb_test3_question1_3.Enabled = False
            cb_test3_question1_4.Enabled = False
            cb_test3_question2_1.Enabled = False
            cb_test3_question2_2.Enabled = False
            cb_test3_question2_3.Enabled = False
            cb_test3_question2_4.Enabled = False
            cb_test3_question3_1.Enabled = False
            cb_test3_question3_2.Enabled = False
            cb_test3_question3_3.Enabled = False
            cb_test3_question3_4.Enabled = False
            cb_test3_question4_1.Enabled = False
            cb_test3_question4_2.Enabled = False
            cb_test3_question4_3.Enabled = False
            cb_test3_question4_4.Enabled = False
            cb_test3_question5_1.Enabled = False
            cb_test3_question5_2.Enabled = False
            cb_test3_question5_3.Enabled = False
            cb_test3_question5_4.Enabled = False
            cb_test3_question6_1.Enabled = False
            cb_test3_question6_2.Enabled = False
            cb_test3_question6_3.Enabled = False
            cb_test3_question7_1.Enabled = False
            cb_test3_question7_2.Enabled = False
            cb_test3_question7_3.Enabled = False
            cb_test3_question7_4.Enabled = False
            cb_test3_question8_1.Enabled = False
            cb_test3_question8_2.Enabled = False
            cb_test3_question8_3.Enabled = False
            cb_test3_question8_4.Enabled = False
            cb_test3_question9_1.Enabled = False
            cb_test3_question9_2.Enabled = False
            cb_test3_question9_3.Enabled = False
            cb_test3_question9_4.Enabled = False
            cb_test3_question10_1.Enabled = False
            cb_test3_question10_2.Enabled = False
            cb_test3_question10_3.Enabled = False
            cb_test3_question10_4.Enabled = False

            ' Check all the answers
            ' Question 1
            If cb_test3_question1_3.Checked = True Then
                Test3_score += 1
                l_test3_question1.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question1.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 2
            If cb_test3_question2_4.Checked = True Then
                Test3_score += 1
                l_test3_question2.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question2.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 3
            If cb_test3_question3_2.Checked = True Then
                Test3_score += 1
                l_test3_question3.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question3.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 4
            If cb_test3_question4_1.Checked = True Then
                Test3_score += 1
                l_test3_question4.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question4.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 5
            If cb_test3_question5_1.Checked = True Then
                Test3_score += 1
                l_test3_question5.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question5.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 6
            If cb_test3_question6_2.Checked = True Then
                Test3_score += 1
                l_test3_question6.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question6.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 7
            If cb_test3_question7_4.Checked = True Then
                Test3_score += 1
                l_test3_question7.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question7.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 8
            If cb_test3_question8_3.Checked = True Then
                Test3_score += 1
                l_test3_question8.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question8.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 9
            If cb_test3_question9_1.Checked = True Then
                Test3_score += 1
                l_test3_question9.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question9.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Question 10
            If cb_test3_question10_2.Checked = True Then
                Test3_score += 1
                l_test3_question10.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                l_test3_question10.ForeColor = Color.FromArgb(214, 40, 40)
            End If


            ' Setting up the score
            l_test3_Score.Text = Convert.ToString(Test3_score) + "/10"

            ' It will make the next button activated
            btn_test3_Next.BackColor = Color.FromArgb(173, 193, 120)
            btn_test3_Next.Enabled = True
            btn_test3_Submit.Enabled = False
        End If
    End Sub

    Private Sub btn_test3_Next_Click(sender As Object, e As EventArgs) Handles btn_test3_Next.Click
        ' Hide this form
        Me.Hide()

        ' Show Form with same location on the screen
        Form4.Show()
    End Sub
End Class