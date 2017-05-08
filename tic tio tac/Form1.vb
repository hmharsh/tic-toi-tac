Public Class Form1

    Dim playear_tern, one, two, three, four, five, six, seven, eight, nine, win As Boolean
    Dim gend, canwin, cwin, one_val, two_val, three_val, four_val, five_val, six_val, seven_val, eight_val, nine_val As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        win = False
        playear_tern = True
        one = False
        two = False
        three = False
        five = False
        four = False
        six = False
        seven = False
        nine = False
        eight = False
        one_val = 4
        two_val = 4
        three_val = 4
        four_val = 4
        five_val = 4
        six_val = 4
        seven_val = 4
        eight_val = 4
        nine_val = 4





        PictureBox1.Image = My.Resources.download
        PictureBox2.Image = My.Resources.download
        PictureBox3.Image = My.Resources.download
        PictureBox4.Image = My.Resources.download
        PictureBox5.Image = My.Resources.download
        PictureBox6.Image = My.Resources.download
        PictureBox7.Image = My.Resources.download
        PictureBox8.Image = My.Resources.download
        PictureBox9.Image = My.Resources.download

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If (one = False) Then
            one = True
            If (playear_tern = True) Then
                PictureBox1.Image = My.Resources.z
                one_val = 0
            Else
                PictureBox1.Image = My.Resources.c
                one_val = 1
            End If
            My.Computer.Audio.Play(My.Resources.Tick_DeepFrozenApps_397275646, AudioPlayMode.WaitToComplete)
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
          
            check()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If (two = False) Then
            two = True
            If (playear_tern = True) Then
                PictureBox2.Image = My.Resources.z
                two_val = 0

            Else
                PictureBox2.Image = My.Resources.c
                two_val = 1
            End If
            My.Computer.Audio.Play(My.Resources.Tick_DeepFrozenApps_397275646, AudioPlayMode.WaitToComplete)
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
            check()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If (three = False) Then
            three = True
            If (playear_tern = True) Then
                PictureBox3.Image = My.Resources.z
                three_val = 0
            Else
                PictureBox3.Image = My.Resources.c
                three_val = 1
            End If
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
            check()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If (four = False) Then
            four = True
            If (playear_tern = True) Then
                PictureBox4.Image = My.Resources.z
                four_val = 0
            Else
                PictureBox4.Image = My.Resources.c
                four_val = 1
            End If
            My.Computer.Audio.Play(My.Resources.Tick_DeepFrozenApps_397275646, AudioPlayMode.WaitToComplete)
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
            check()
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If (five = False) Then
            five = True
            canwin = 0
            If (playear_tern = True) Then
                PictureBox5.Image = My.Resources.z

                five_val = 0
            Else
                PictureBox5.Image = My.Resources.c
                five_val = 1

            End If
            My.Computer.Audio.Play(My.Resources.Tick_DeepFrozenApps_397275646, AudioPlayMode.WaitToComplete)
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
            check()
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If (six = False) Then
            six = True
            If (playear_tern = True) Then
                PictureBox6.Image = My.Resources.z
                six_val = 0
            Else
                PictureBox6.Image = My.Resources.c
                six_val = 1
            End If
            My.Computer.Audio.Play(My.Resources.Tick_DeepFrozenApps_397275646, AudioPlayMode.WaitToComplete)
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
            check()
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If (seven = False) Then
            seven = True
            If (playear_tern = True) Then
                PictureBox7.Image = My.Resources.z
                seven_val = 0
            Else
                PictureBox7.Image = My.Resources.c
                seven_val = 1
            End If
            My.Computer.Audio.Play(My.Resources.Tick_DeepFrozenApps_397275646, AudioPlayMode.WaitToComplete)
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
            check()
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If (eight = False) Then
            eight = True
            If (playear_tern = True) Then
                PictureBox8.Image = My.Resources.z
                eight_val = 0
            Else
                PictureBox8.Image = My.Resources.c
                eight_val = 1
            End If
            My.Computer.Audio.Play(My.Resources.Tick_DeepFrozenApps_397275646, AudioPlayMode.WaitToComplete)
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
            check()
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If (nine = False) Then
            nine = True
            If (playear_tern = True) Then
                PictureBox9.Image = My.Resources.z
                nine_val = 0
            Else
                PictureBox9.Image = My.Resources.c
                nine_val = 1
            End If
            My.Computer.Audio.Play(My.Resources.Tick_DeepFrozenApps_397275646, AudioPlayMode.WaitToComplete)
            If (RadioButton1.Checked = True) Then
                mark()
            Else
                If (playear_tern = True) Then
                    playear_tern = False
                    Label2.Text = 2
                Else
                    Label2.Text = 1
                    playear_tern = True
                End If

            End If
            check()
        End If
    End Sub
    Sub check()
        TextBox1.Text = one_val.ToString() + "_" + two_val.ToString() + " " + three_val.ToString()
        TextBox2.Text = four_val.ToString() + "_" + five_val.ToString() + " " + six_val.ToString()
        TextBox3.Text = seven_val.ToString() + "_" + eight_val.ToString() + " " + nine_val.ToString()
        If ((one_val + two_val + three_val = 3) Or (one_val + four_val + seven_val = 3) Or (one_val + five_val + nine_val = 3)) Then

            ' Me.Text = (one_val.ToString() + "+" + two_val.ToString() + "+" + three_val.ToString())
            ' init()
            win = True
            pwin()
        End If
        If ((one_val + two_val + three_val = 0) Or (one_val + four_val + seven_val = 0) Or (one_val + five_val + nine_val = 0)) Then
          

            ' Me.Text = (one_val.ToString() + "+" + two_val.ToString() + "+" + three_val.ToString())
            ' init()
            win = True
            pwin()
        End If
        If ((seven_val + eight_val + nine_val = 3) Or (three_val + six_val + nine_val = 3)) Then


            ' Me.Text = (one_val.ToString() + "+" + two_val.ToString() + "+" + three_val.ToString())
            ' init()
            win = True
            pwin()
        End If
        If ((seven_val + eight_val + nine_val = 0) Or (three_val + six_val + nine_val = 0)) Then


            ' Me.Text = (one_val.ToString() + "+" + two_val.ToString() + "+" + three_val.ToString())
            ' init()
            win = True
            pwin()
        End If



        ''
        If ((four_val + five_val + six_val = 3) Or (two_val + five_val + eight_val = 3)) Then
            ' Me.Text = (one_val.ToString() + "+" + two_val.ToString() + "+" + three_val.ToString())
            ' init()
            win = True
            pwin()
        End If
        If ((four_val + five_val + six_val = 0) Or (two_val + five_val + eight_val = 0)) Then


            ' Me.Text = (one_val.ToString() + "+" + two_val.ToString() + "+" + three_val.ToString())
            ' init()
            win = True
            pwin()
        End If

        If ((seven_val + five_val + three_val = 3)) Then


            ' Me.Text = (one_val.ToString() + "+" + two_val.ToString() + "+" + three_val.ToString())
            ' init()
            win = True
            pwin()
        End If
        If ((seven_val + five_val + three_val = 0)) Then


            ' Me.Text = (one_val.ToString() + "+" + two_val.ToString() + "+" + three_val.ToString())
            ' init()
            win = True
            pwin()
        End If


        If (one = True And two = True And three = True And four = True And five = True And six = True And seven = True And eight = True And nine = True) Then
            'complete..
            If (win = False) Then
                ptie()
            Else
                win = 1
                pwin()
            End If

            ''

            ''
        End If


    End Sub
    Sub pwin()
        If (RadioButton2.Checked = True) Then


            If (Val(Label2.Text) = 1) Then
                Label7.Text = (Val(Label7.Text) + 1)
                init()
            Else
                Label6.Text = (Val(Label6.Text) + 1)
                init()
            End If

        ElseIf (RadioButton1.Checked = True) Then



          
                canwin = 1

            
            End If



    End Sub
   
    Sub ptie()
        If (RadioButton2.Checked = True) Then
            Label4.Text = (Val(Label4.Text) + 1)

        End If
        init()
    End Sub
    Sub init()
    
        gend = 0
        canwin = 4
        cwin = 4

            win = False
            playear_tern = True
            one = False
            two = False
            three = False
            five = False
            four = False
            six = False
            seven = False
            nine = False
            eight = False
            one_val = 4
            two_val = 4
            three_val = 4
            four_val = 4
            five_val = 4
            six_val = 4
            seven_val = 4
            eight_val = 4
            nine_val = 4
      
        If (MsgBox(" Want to start a new game..", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok) Then



            PictureBox1.Image = My.Resources.download
            PictureBox2.Image = My.Resources.download
            PictureBox3.Image = My.Resources.download
            PictureBox4.Image = My.Resources.download
            PictureBox5.Image = My.Resources.download
            PictureBox6.Image = My.Resources.download
            PictureBox7.Image = My.Resources.download
            PictureBox8.Image = My.Resources.download
            PictureBox9.Image = My.Resources.download
        End If
      
    End Sub


    Sub mark()
        'default cwin is 4
        cwin = 4

        gend = 0
        'this procedure mark from CPU side...
        ' if cpu win den cwin =1 else if 0 else if tie cwin=3''


        ''main code
        ' PictureBox9.Image = My.Resources.z]



        ''''buf

        'code to check if in nxt tern i(cpu) is winning..
        If (one = False) Then
            one_val = 1
            check()
            If (canwin = 1) Then
                PictureBox1.Image = My.Resources.c
                cwin = 1
                gend = 1
            Else
                one_val = 4
            End If

        End If
        If (two = False) Then
            If (gend = 0) Then

                two_val = 1
                check()
                If (canwin = 1) Then
                    PictureBox2.Image = My.Resources.c
                    cwin = 1
                    gend = 1
                Else
                    two_val = 4
                End If

            End If
        End If
        If (three = False) Then
            If (gend = 0) Then
                three_val = 1
                check()
                If (canwin = 1) Then
                    PictureBox3.Image = My.Resources.c
                    cwin = 1
                    gend = 1
                Else
                    three_val = 4

                End If
            End If

        End If
        If (four = False) Then
            If (gend = 0) Then
                four_val = 1
                check()
                If (canwin = 1) Then
                    PictureBox4.Image = My.Resources.c
                    cwin = 1
                    gend = 1
                Else
                    four_val = 4

                End If
            End If

        End If
        If (five = False) Then
            If (gend = 0) Then

                five_val = 1
                check()
                If (canwin = 1) Then
                    PictureBox5.Image = My.Resources.c
                    cwin = 1
                    gend = 1
                Else
                    five_val = 4

                End If

            End If

        End If
        If (six = False) Then
            If (gend = 0) Then

                six_val = 1
                check()
                If (canwin = 1) Then
                    PictureBox6.Image = My.Resources.c
                    cwin = 1
                    gend = 1
                Else
                    six_val = 4

                End If

            End If

        End If
        If (seven = False) Then
            If (gend = 0) Then
                seven_val = 1
                check()
                If (canwin = 1) Then
                    PictureBox7.Image = My.Resources.c
                    cwin = 1
                    gend = 1
                Else
                    seven_val = 4

                End If
            End If

        End If
        If (eight = False) Then
            If (gend = 0) Then
                eight_val = 1
                check()
                If (canwin = 1) Then
                    PictureBox8.Image = My.Resources.c
                    cwin = 1
                    gend = 1
                Else
                    eight_val = 4

                End If
            End If

        End If
        If (nine = False) Then
            If (gend = 0) Then
                nine_val = 1
                check()
                If (canwin = 1) Then
                    PictureBox9.Image = My.Resources.c
                    cwin = 1
                    gend = 1
                Else
                    nine_val = 4

                End If
            End If

        End If
        'code to check if in nxt tern i(cpu) is winning.. end here

















       
        'buf


        'code to check if in nxt tern user(playear is winning..)
        'canwin=0

        If (one = False) Then
            If (gend = 0) Then


                one_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox1.Image = My.Resources.c
                    'cwin = 1
                    gend = 1
                    one_val = 1
                Else
                    one_val = 4
                End If
            End If
        End If




        If (two = False) Then
            If (gend = 0) Then

                two_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox2.Image = My.Resources.c
                    ' cwin = 1
                    gend = 1
                    two_val = 1
                Else
                    two_val = 4
                End If

            End If
        End If
        If (three = False) Then
            If (gend = 0) Then
                three_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox3.Image = My.Resources.c
                    'cwin = 1
                    gend = 1
                    three_val = 1
                Else
                    three_val = 4

                End If
            End If

        End If
        If (four = False) Then
            If (gend = 0) Then
                four_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox4.Image = My.Resources.c
                    'cwin = 1
                    gend = 1
                    four_val = 1
                Else
                    four_val = 4

                End If
            End If

        End If
        If (five = False) Then
            If (gend = 0) Then

                five_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox5.Image = My.Resources.c
                    ' cwin = 1
                    gend = 1
                    five_val = 1

                Else
                    five_val = 4

                End If

            End If

        End If
        If (six = False) Then
            If (gend = 0) Then

                six_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox6.Image = My.Resources.c
                    '  cwin = 1
                    gend = 1
                    six_val = 1
                Else
                    six_val = 4

                End If

            End If

        End If
        If (seven = False) Then
            If (gend = 0) Then
                seven_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox7.Image = My.Resources.c
                    ' cwin = 1
                    gend = 1
                    seven_val = 1
                Else
                    seven_val = 4

                End If
            End If

        End If
        If (eight = False) Then
            If (gend = 0) Then
                eight_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox8.Image = My.Resources.c
                    ' cwin = 1
                    gend = 1
                    eight_val = 1
                Else
                    eight_val = 4

                End If
            End If

        End If
        If (nine = False) Then
            If (gend = 0) Then
                nine_val = 0
                check()
                If (canwin = 1) Then
                    PictureBox9.Image = My.Resources.c
                    ' cwin = 1
                    gend = 1
                    nine_val = 1
                Else
                    nine_val = 4

                End If
            End If

        End If


        'code to check if in nxt tern user(playear is winning..) end here..


        If (gend = 0) Then
            If (five = False) Then
                PictureBox5.Image = My.Resources.c
                gend = 1
                five_val = 1
                five = True
            Else
                If (two = False) Then
                    PictureBox2.Image = My.Resources.c
                    gend = 1
                    two_val = 1
                    two = True
                ElseIf (three = False) Then
                    PictureBox3.Image = My.Resources.c
                    gend = 1
                    three_val = 1
                    three = True
                ElseIf (four = False) Then
                    PictureBox4.Image = My.Resources.c
                    gend = 1
                    four_val = 1
                    four = True
                ElseIf (one = False) Then
                    PictureBox1.Image = My.Resources.c
                    gend = 1
                    one_val = 1
                    one = True
                ElseIf (six = False) Then
                    PictureBox6.Image = My.Resources.c
                    gend = 1
                    six_val = 1
                    six = True
                ElseIf (seven = False) Then
                    PictureBox7.Image = My.Resources.c
                    gend = 1
                    seven_val = 1
                    seven = True
                ElseIf (eight = False) Then
                    PictureBox8.Image = My.Resources.c
                    gend = 1
                    eight_val = 1
                    eight = True
                ElseIf (nine = False) Then
                    PictureBox9.Image = My.Resources.c
                    gend = 1
                    nine_val = 1
                    nine = True
                End If



                End If
        End If

        ''main code end here
        If (one = True And two = True And three = True And four = True And five = True And six = True And seven = True And eight = True And nine = True) Then
            cwin = 3
        End If


        If (cwin = 1) Then
            'increment label 7,cpu win
            Label7.Text = (Val(Label7.Text) + 1)
            init()
        ElseIf (cwin = 0) Then
            'increment label 6,user win
            Label6.Text = (Val(Label6.Text) + 1)
            '  init()
        ElseIf (cwin = 3) Then
            'tie
            Label4.Text = (Val(Label4.Text) + 1)
            init()
        Else

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        init()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            Label10.Visible = False
            Me.Height = 417
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.Height = 360
        cwin = True
        Label10.Visible = True
    End Sub
End Class
