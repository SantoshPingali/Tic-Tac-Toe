Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label11.Text = "Player 1" Then
            Label1.Text = "X"
            Label11.Text = "Player 2"
            Label1.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label1.Text = "O"
            Label11.Text = "Player 1"
            Label1.Enabled = False
        End If

        '' checking for win with top row when 1 is clicked
        If Label1.Text = "X" And Label2.Text = "X" And Label3.Text = "X" Then
            Label12.Text = Label1.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label2.Text = "O" And Label3.Text = "O" Then
            Label12.Text = Label1.Text + " Has Won"
        End If

        '' checking for win with diagonal when 1 is click
        If Label1.Text = "X" And Label5.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label1.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label5.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label1.Text + " Has Won"
        End If

        '' checking for win with horizontal when 1 is click
        If Label1.Text = "X" And Label4.Text = "X" And Label7.Text = "X" Then
            Label12.Text = Label1.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label4.Text = "O" And Label7.Text = "O" Then
            Label12.Text = Label1.Text + " Has Won"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label11.Text = "Player 1"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Label11.Text = "Player 1" Then
            Label2.Text = "X"
            Label11.Text = "Player 2"
            Label2.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label2.Text = "O"
            Label11.Text = "Player 1"
            Label2.Enabled = False
        End If

        '' checking for top row when 2 is clicked
        If Label1.Text = "X" And Label2.Text = "X" And Label3.Text = "X" Then
            Label12.Text = Label2.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label2.Text = "O" And Label3.Text = "O" Then
            Label12.Text = Label2.Text + " Has Won"
        End If

        '' checking for horizontal when 2 is clicked
        If Label2.Text = "X" And Label5.Text = "X" And Label8.Text = "X" Then
            Label12.Text = Label2.Text + " Has Won"
        ElseIf Label2.Text = "O" And Label5.Text = "O" And Label8.Text = "O" Then
            Label12.Text = Label2.Text + " Has Won"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Label11.Text = "Player 1" Then
            Label3.Text = "X"
            Label11.Text = "Player 2"
            Label3.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label3.Text = "O"
            Label11.Text = "Player 1"
            Label3.Enabled = False
        End If

        '' checking for top row when 3 is clicked
        If Label1.Text = "X" And Label2.Text = "X" And Label3.Text = "X" Then
            Label12.Text = Label3.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label2.Text = "O" And Label3.Text = "O" Then
            Label12.Text = Label3.Text + " Has Won"
        End If

        '' checking for horizantal when 3 is clicked
        If Label3.Text = "X" And Label6.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label3.Text + " Has Won"
        ElseIf Label3.Text = "O" And Label6.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label3.Text + " Has Won"
        End If

        '' checking for diagonal when 3 is clicked
        If Label3.Text = "X" And Label5.Text = "X" And Label7.Text = "X" Then
            Label12.Text = Label3.Text + " Has Won"
        ElseIf Label3.Text = "O" And Label5.Text = "O" And Label7.Text = "O" Then
            Label12.Text = Label3.Text + " Has Won"
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Label11.Text = "Player 1" Then
            Label4.Text = "X"
            Label11.Text = "Player 2"
            Label4.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label4.Text = "O"
            Label11.Text = "Player 1"
            Label4.Enabled = False
        End If

        '' checking for second row when 4 is clicked
        If Label4.Text = "X" And Label5.Text = "X" And Label6.Text = "X" Then
            Label12.Text = Label4.Text + " Has Won"
        ElseIf Label4.Text = "O" And Label5.Text = "O" And Label6.Text = "O" Then
            Label12.Text = Label4.Text + " Has Won"
        End If

        '' checking for vertical when 4 is clicked
        If Label1.Text = "X" And Label4.Text = "X" And Label7.Text = "X" Then
            Label12.Text = Label4.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label4.Text = "O" And Label7.Text = "O" Then
            Label12.Text = Label4.Text + " Has Won"
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Label11.Text = "Player 1" Then
            Label5.Text = "X"
            Label11.Text = "Player 2"
            Label5.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label5.Text = "O"
            Label11.Text = "Player 1"
            Label5.Enabled = False
        End If

        '' Checking for left diagonal when 5 is clicked
        If Label1.Text = "X" And Label5.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label5.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label5.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label5.Text + " Has Won"
        End If

        '' checking for right diagonal when 5 is clicked 
        If Label3.Text = "X" And Label5.Text = "X" And Label7.Text = "X" Then
            Label12.Text = Label5.Text + " Has Won"
        ElseIf Label3.Text = "O" And Label5.Text = "O" And Label7.Text = "O" Then
            Label12.Text = Label5.Text + " Has Won"
        End If

        '' checking for 2nd row when 5 is clicked
        If Label4.Text = "X" And Label5.Text = "X" And Label6.Text = "X" Then
            Label12.Text = Label5.Text + " Has Won"
        ElseIf Label4.Text = "O" And Label5.Text = "O" And Label6.Text = "O" Then
            Label12.Text = Label5.Text + " Has Won"
        End If

        '' checking for horizantal when 5 is clicked
        If Label2.Text = "X" And Label5.Text = "X" And Label8.Text = "X" Then
            Label12.Text = Label5.Text + " Has Won"
        ElseIf Label2.Text = "O" And Label5.Text = "O" And Label8.Text = "O" Then
            Label12.Text = Label5.Text + " Has Won"
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If Label11.Text = "Player 1" Then
            Label6.Text = "X"
            Label11.Text = "Player 2"
            Label6.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label6.Text = "O"
            Label11.Text = "Player 1"
            Label6.Enabled = False
        End If

        '' checking for horizantal row when 6 is clicked
        If Label3.Text = "X" And Label6.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label6.Text + " Has Won"
        ElseIf Label3.Text = "O" And Label6.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label6.Text + " Has Won"
        End If

        '' checking for second row when 6 is clicked
        If Label4.Text = "X" And Label5.Text = "X" And Label6.Text = "X" Then
            Label12.Text = Label6.Text + " Has Won"
        ElseIf Label4.Text = "O" And Label5.Text = "O" And Label6.Text = "O" Then
            Label12.Text = Label6.Text + " Has Won"
        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If Label11.Text = "Player 1" Then
            Label7.Text = "X"
            Label11.Text = "Player 2"
            Label7.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label7.Text = "O"
            Label11.Text = "Player 1"
            Label7.Enabled = False
        End If

        '' checking for horizantal when 7 is clicked
        If Label1.Text = "X" And Label4.Text = "X" And Label7.Text = "X" Then
            Label12.Text = Label7.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label4.Text = "O" And Label7.Text = "O" Then
            Label12.Text = Label7.Text + " Has Won"
        End If

        '' checking for diagonal when 7 is clicked
        If Label3.Text = "X" And Label5.Text = "X" And Label7.Text = "X" Then
            Label12.Text = Label7.Text + " Has Won"
        ElseIf Label3.Text = "O" And Label5.Text = "O" And Label7.Text = "O" Then
            Label12.Text = Label7.Text + " Has Won"
        End If

        '' checking for bottom row when 7 is clicked
        If Label7.Text = "X" And Label8.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label7.Text + " Has Won"
        ElseIf Label7.Text = "O" And Label8.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label7.Text + " Has Won"
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If Label11.Text = "Player 1" Then
            Label8.Text = "X"
            Label11.Text = "Player 2"
            Label8.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label8.Text = "O"
            Label11.Text = "Player 1"
            Label8.Enabled = False
        End If

        '' checking for horizantal when 8 is clicked
        If Label2.Text = "X" And Label5.Text = "X" And Label8.Text = "X" Then
            Label12.Text = Label8.Text + " Has Won"
        ElseIf Label2.Text = "O" And Label5.Text = "O" And Label8.Text = "O" Then
            Label12.Text = Label8.Text + " Has Won"
        End If

        ''checking fo bottom row when 8 is clicked
        If Label7.Text = "X" And Label8.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label8.Text + " Has Won"
        ElseIf Label7.Text = "O" And Label8.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label8.Text + " Has Won"
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        If Label11.Text = "Player 1" Then
            Label9.Text = "X"
            Label11.Text = "Player 2"
            Label9.Enabled = False
        ElseIf Label11.Text = "Player 2" Then
            Label9.Text = "O"
            Label11.Text = "Player 1"
            Label9.Enabled = False
        End If

        '' checking for diagonal when 9 is clicked
        If Label1.Text = "X" And Label5.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label9.Text + " Has Won"
        ElseIf Label1.Text = "O" And Label5.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label9.Text + " Has Won"
        End If

        '' checking for horizantal when 9 is clicked
        If Label3.Text = "X" And Label6.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label9.Text + " Has Won"
        ElseIf Label3.Text = "O" And Label6.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label9.Text + " Has Won"
        End If

        If Label7.Text = "X" And Label8.Text = "X" And Label9.Text = "X" Then
            Label12.Text = Label9.Text + " Has Won"
        ElseIf Label7.Text = "O" And Label8.Text = "O" And Label9.Text = "O" Then
            Label12.Text = Label9.Text + " Has Won"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
