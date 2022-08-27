Public Class Form2
    ' Global Property
    Public Property Test2_score As Integer = 0 ' Score Counter for Test 2

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Close()
    End Sub

    ' Previous button
    Private Sub btn_Prev_Click(sender As Object, e As EventArgs) Handles btn_Prev.Click
        ' Hide this form
        Me.Hide()

        ' Show Form with same location on the screen
        Form1.StartPosition = FormStartPosition.Manual
        Form1.Location = New Point(Me.Location.X + Me.Width \ 2 - Form1.Width \ 2, Me.Location.Y + Me.Height \ 2 - Form1.Height \ 2)
        Form1.Show()
    End Sub

    ' Start button
    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        ' Change state of Start prompt
        l_test2_ident_start.Visible = False

        ' Info show
        l_test2_rowInfoAnswers1.Visible = True
        l_test2_rowInfoAnswers2.Visible = True
        l_test2_rowInfoAnswers3.Visible = True

        ' Show all the question and radio buttons
        gb_test2_question1.Visible = True
        gb_test2_question2.Visible = True
        gb_test2_question3.Visible = True
        gb_test2_question4.Visible = True
        gb_test2_question5.Visible = True
        gb_test2_question6.Visible = True
        gb_test2_question7.Visible = True
        gb_test2_question8.Visible = True
        gb_test2_question9.Visible = True
        gb_test2_question10.Visible = True


        ' Change the state of the Start button
        btn_Start.Enabled = False
        ' Change the color of the button to ~Olivine
        btn_Start.BackColor = Color.FromArgb(173, 193, 120)
        ' Make the Submit Accessable
        btn_Submit.Enabled = True

    End Sub
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        If MessageBox.Show("You can't change the answer after submitting", "Are you sure to submit?", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            ' Lock the Radio buttons
            rb_test2_q1_1.Enabled = False
            rb_test2_q1_2.Enabled = False
            rb_test2_q1_3.Enabled = False
            rb_test2_q2_1.Enabled = False
            rb_test2_q2_2.Enabled = False
            rb_test2_q2_3.Enabled = False
            rb_test2_q3_1.Enabled = False
            rb_test2_q3_2.Enabled = False
            rb_test2_q3_3.Enabled = False
            rb_test2_q4_1.Enabled = False
            rb_test2_q4_2.Enabled = False
            rb_test2_q4_3.Enabled = False
            rb_test2_q5_1.Enabled = False
            rb_test2_q5_2.Enabled = False
            rb_test2_q5_3.Enabled = False
            rb_test2_q6_1.Enabled = False
            rb_test2_q6_2.Enabled = False
            rb_test2_q6_3.Enabled = False
            rb_test2_q7_1.Enabled = False
            rb_test2_q7_2.Enabled = False
            rb_test2_q7_3.Enabled = False
            rb_test2_q8_1.Enabled = False
            rb_test2_q8_2.Enabled = False
            rb_test2_q8_3.Enabled = False
            rb_test2_q9_1.Enabled = False
            rb_test2_q9_2.Enabled = False
            rb_test2_q9_3.Enabled = False
            rb_test2_q10_1.Enabled = False
            rb_test2_q10_2.Enabled = False
            rb_test2_q10_2.Enabled = False

            ' Check the answer
            '#1
            If rb_test2_q1_3.Checked = True Then
                Test2_score += 1
                gb_test2_question1.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question1.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#2
            If rb_test2_q2_2.Checked = True Then
                Test2_score += 1
                gb_test2_question2.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question2.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#3
            If rb_test2_q3_1.Checked = True Then
                Test2_score += 1
                gb_test2_question3.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question3.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#4
            If rb_test2_q4_3.Checked = True Then
                Test2_score += 1
                gb_test2_question4.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question4.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#5
            If rb_test2_q5_1.Checked = True Then
                Test2_score += 1
                gb_test2_question5.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question5.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#6
            If rb_test2_q6_2.Checked = True Then
                Test2_score += 1
                gb_test2_question6.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question6.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#7
            If rb_test2_q7_3.Checked = True Then
                Test2_score += 1
                gb_test2_question7.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question7.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#8
            If rb_test2_q8_2.Checked = True Then
                Test2_score += 1
                gb_test2_question8.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question8.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#9
            If rb_test2_q9_1.Checked = True Then
                Test2_score += 1
                gb_test2_question9.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question9.ForeColor = Color.FromArgb(214, 40, 40)
            End If
            '#10
            If rb_test2_q10_3.Checked = True Then
                Test2_score += 1
                gb_test2_question10.ForeColor = Color.FromArgb(173, 193, 120)
            Else
                gb_test2_question10.ForeColor = Color.FromArgb(214, 40, 40)
            End If

            ' Setting up the score
            l_test2_Score.Text = Convert.ToString(Test2_score) + "/10"

            ' It will make the next button activated
            btn_Next.BackColor = Color.FromArgb(173, 193, 120)
            btn_Next.Enabled = True
            btn_Submit.Enabled = False
        End If
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        ' Hide this form
        Me.Hide()

        ' Show Form with same location on the screen
        Form3.StartPosition = FormStartPosition.Manual
        Form3.Location = New Point(Me.Location.X + Me.Width \ 2 - Form3.Width \ 2, Me.Location.Y + Me.Height \ 2 - Form3.Height \ 2)
        Form3.Show()
    End Sub
End Class