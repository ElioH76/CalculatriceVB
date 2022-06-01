Public Class Form1

    Dim operateur = ""
    Dim operande1 As Double
    Dim operande2 As Double


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub textCalc_TextChanged(sender As Object, e As EventArgs) Handles textCalc.TextChanged

    End Sub

    Private Sub bout_0_Click(sender As Object, e As EventArgs) Handles bout_0.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "0"
        Else
            textCalc.Text = textCalc.Text + "0"
        End If
    End Sub
    Private Sub bout_1_Click(sender As Object, e As EventArgs) Handles bout_1.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "1"
        Else
            textCalc.Text = textCalc.Text + "1"
        End If
    End Sub
    Private Sub bout_2_Click(sender As Object, e As EventArgs) Handles bout_2.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "2"
        Else
            textCalc.Text = textCalc.Text + "2"
        End If
    End Sub
    Private Sub bout_3_Click(sender As Object, e As EventArgs) Handles bout_3.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "3"
        Else
            textCalc.Text = textCalc.Text + "3"
        End If
    End Sub
    Private Sub bout_4_Click(sender As Object, e As EventArgs) Handles bout_4.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "4"
        Else
            textCalc.Text = textCalc.Text + "4"
        End If
    End Sub
    Private Sub bout_5_Click(sender As Object, e As EventArgs) Handles bout_5.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "5"
        Else
            textCalc.Text = textCalc.Text + "5"
        End If
    End Sub
    Private Sub bout_6_Click(sender As Object, e As EventArgs) Handles bout_6.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "6"
        Else
            textCalc.Text = textCalc.Text + "6"
        End If
    End Sub
    Private Sub bout_7_Click(sender As Object, e As EventArgs) Handles bout_7.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "7"
        Else
            textCalc.Text = textCalc.Text + "7"
        End If
    End Sub
    Private Sub bout_8_Click(sender As Object, e As EventArgs) Handles bout_8.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "8"
        Else
            textCalc.Text = textCalc.Text + "8"
        End If
    End Sub
    Private Sub bout_9_Click(sender As Object, e As EventArgs) Handles bout_9.Click
        If textCalc.Text = "0" Then
            textCalc.Text = "9"
        Else
            textCalc.Text = textCalc.Text + "9"
        End If
    End Sub

    Private Sub bout_egal_Click(sender As Object, e As EventArgs) Handles bout_egal.Click
        operande2 = textCalc.Text

        If operateur = "+" Then
            textCalc.Text = operande1 + operande2
        ElseIf operateur = "-" Then
            textCalc.Text = operande1 - operande2
        ElseIf operateur = "/" Then
            textCalc.Text = operande1 / operande2
        ElseIf operateur = "x" Then
            textCalc.Text = operande1 * operande2
        End If


    End Sub

    Private Sub bout_add_Click(sender As Object, e As EventArgs) Handles bout_add.Click
        operateur = "+"
        operande1 = textCalc.Text
        textCalc.Text = " "

    End Sub

    Private Sub bout_div_Click(sender As Object, e As EventArgs) Handles bout_div.Click
        operateur = "/"
        operande1 = textCalc.Text
        textCalc.Text = " "
    End Sub

    Private Sub bout_mult_Click(sender As Object, e As EventArgs) Handles bout_mult.Click
        operateur = "x"
        operande1 = textCalc.Text
        textCalc.Text = " "
    End Sub

    Private Sub bout_sous_Click(sender As Object, e As EventArgs) Handles bout_sous.Click

        operateur = "-"
        operande1 = textCalc.Text
        textCalc.Text = " "

    End Sub

    Private Sub bout_reset_Click(sender As Object, e As EventArgs) Handles bout_reset.Click
        textCalc.Text = " "
        operande1 = 0
        operande2 = 0
    End Sub

    Private Sub bout_virg_Click(sender As Object, e As EventArgs) Handles bout_virg.Click
        textCalc.Text = textCalc.Text + ","

    End Sub

    Private Sub bout_neg_Click(sender As Object, e As EventArgs) Handles bout_neg.Click

        If operande1 = 0 Or operande2 = 0 Then
            textCalc.Text = "-"
        Else
            operande1 = textCalc.Text
            textCalc.Text = " "
        End If
    End Sub
End Class
