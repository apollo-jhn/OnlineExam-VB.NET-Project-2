Public Class Form1

    ' Global Variables
    Dim okProceed As Boolean = False
    Public Property Test1_Score As Integer = 0 ' Score counter for Test 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Next button is locked if okProceed Variable is False
        If okProceed = False Then
            btn_Next.Enabled = False
        End If
    End Sub

    ' About the project button for details '
    Private Sub b_About_Click(sender As Object, e As EventArgs) Handles b_About.Click

        ' About string text '
        Dim aboutText As String = "Course: Object Oriented Programming\nProject Title: Activity - Online Exam (Check Box and Radio Button)\nProject by: Ponteras, John Apollo S.\nSection: BSCPE 2-01\nInstructor: Prof. Johanna Ave"

        ' Converts the "\n" placeholder to Newline because Visual Basic dont have \n like C++
        aboutText = Replace(aboutText, "\n", Environment.NewLine)

        ' Displays the text '
        Beep()
        MessageBox.Show(aboutText, "About this Project")
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click

        ' Check first if all the field has been answered
        If tb_test1_ident_1.Text IsNot String.Empty AndAlso tb_test1_ident_2.Text IsNot String.Empty AndAlso tb_test1_ident_3.Text IsNot String.Empty AndAlso tb_test1_ident_4.Text IsNot String.Empty AndAlso tb_test1_ident_5.Text IsNot String.Empty AndAlso tb_test1_ident_6.Text IsNot String.Empty AndAlso tb_test1_ident_7.Text IsNot String.Empty AndAlso tb_test1_ident_8.Text IsNot String.Empty AndAlso tb_test1_ident_9.Text IsNot String.Empty AndAlso tb_test1_ident_10.Text IsNot String.Empty Then

            ' Check #1 Answer
            If UCase(tb_test1_ident_1.Text) = "CHARLES BABBAGE" Then
                Test1_Score += 1
                tb_test1_ident_1.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_1.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #2 Answer
            If UCase(tb_test1_ident_2.Text) = "BILL GATES" Then
                Test1_Score += 1
                tb_test1_ident_2.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_2.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #3 Answer
            If UCase(tb_test1_ident_3.Text) = "BLAISE PASCAL" Then
                Test1_Score += 1
                tb_test1_ident_3.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_3.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #4 Answer
            If UCase(tb_test1_ident_4.Text) = "WILLIAM HOLLERITH" Then
                Test1_Score += 1
                tb_test1_ident_4.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_4.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #5 Answer
            If UCase(tb_test1_ident_5.Text) = "WILLIAM OUGHTRED" Then
                Test1_Score += 1
                tb_test1_ident_5.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_5.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #6 Answer
            If UCase(tb_test1_ident_6.Text) = "APPLE COMPUTER" Then
                Test1_Score += 1
                tb_test1_ident_6.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_6.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #7 Answer
            If UCase(tb_test1_ident_7.Text) = "SUPER COMPUTER" Then
                Test1_Score += 1
                tb_test1_ident_7.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_7.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #8 Answer
            If UCase(tb_test1_ident_8.Text) = "ABACUS FIRST" Then
                Test1_Score += 1
                tb_test1_ident_8.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_8.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #9 Answer
            If UCase(tb_test1_ident_9.Text) = "HARDWARE" Then
                Test1_Score += 1
                tb_test1_ident_9.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_9.BackColor = Color.FromArgb(214, 40, 40)
            End If

            ' Check #10 Answer
            If UCase(tb_test1_ident_10.Text) = "PROGRAM" Then
                Test1_Score += 1
                tb_test1_ident_10.BackColor = Color.FromArgb(173, 193, 120)
            Else
                tb_test1_ident_10.BackColor = Color.FromArgb(214, 40, 40)

            End If

            ' Setting up the score
            l_test1_Score.Text = Convert.ToString(Test1_Score) + "/10"

            ' It will make the next button activated
            okProceed = True
            btn_Next.BackColor = Color.FromArgb(173, 193, 120)
            btn_Next.Enabled = True
            btn_Submit.Enabled = False
        Else
            MessageBox.Show("Fill all the fields before submitting", "Stop right there")
        End If

    End Sub

    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        ' Change the color of the button to ~Olivine
        btn_Start.BackColor = Color.FromArgb(173, 193, 120)
        ' Change the state of the Start button
        btn_Start.Enabled = False

        ' Make the item visible
        'Text Box
        tb_test1_ident_1.Visible = True
        tb_test1_ident_2.Visible = True
        tb_test1_ident_3.Visible = True
        tb_test1_ident_4.Visible = True
        tb_test1_ident_5.Visible = True
        tb_test1_ident_6.Visible = True
        tb_test1_ident_7.Visible = True
        tb_test1_ident_8.Visible = True
        tb_test1_ident_9.Visible = True
        tb_test1_ident_10.Visible = True

        ' Labels
        l_test1_ident_1.Visible = True
        l_test1_ident_2.Visible = True
        l_test1_ident_3.Visible = True
        l_test1_ident_4.Visible = True
        l_test1_ident_5.Visible = True
        l_test1_ident_6.Visible = True
        l_test1_ident_7.Visible = True
        l_test1_ident_8.Visible = True
        l_test1_ident_9.Visible = True
        l_test1_ident_10.Visible = True

        l_test1_ident_start.Visible = False

        ' To enable the submit button at the bottom
        btn_Submit.Enabled = True

    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        ' Hide this form
        Me.Hide()

        ' Show Form with same location on the screen
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = New Point(Me.Location.X + Me.Width \ 2 - Form2.Width \ 2, Me.Location.Y + Me.Height \ 2 - Form2.Height \ 2)
        Form2.Show()
    End Sub
End Class
