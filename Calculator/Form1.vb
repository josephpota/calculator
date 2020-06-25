

Option Strict On
Public Class Form1
    Dim dblResult As Double



    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        ElseIf txtCalculator.Text.Length > 0 Then
            txtCalculator.Text = txtCalculator.Text.Remove(txtCalculator.Text.Length - 1, 1)
        End If



    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCalculator.ResetText()

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "1"
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtCalculator.Text = CStr(dblResult) Then
            txtCalculator.ResetText()
        End If

        txtCalculator.Text = txtCalculator.Text & "9"
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        txtCalculator.Text = txtCalculator.Text & " + "
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        txtCalculator.Text = txtCalculator.Text & " - "
    End Sub
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        txtCalculator.Text = txtCalculator.Text & " / "
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        txtCalculator.Text = txtCalculator.Text & " * "

    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        txtCalculator.Text = txtCalculator.Text & "."

    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        Try
            'Declare variables
            Dim strEquation As String
            Dim dtAnswer As New DataTable()


            'set variables
            strEquation = txtCalculator.Text
            'does calculation
            dblResult = CDbl(dtAnswer.Compute(strEquation, Nothing))

            'Displays
            txtCalculator.Text = CStr(dblResult)

        Catch ex As Exception
            MessageBox.Show("There is an error, please check your equation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        txtCalculator.Select(txtCalculator.Text.Length, 0)

    End Sub

    Private Sub txtCalculator_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCalculator.KeyPress



        'wipes textbox with button press after hitting equals unless 
        'you immediately hit an operator
        If txtCalculator.Text = CStr(dblResult) Then
            If e.KeyChar = ControlChars.Back Then
                txtCalculator.ResetText()
            Else
                If e.KeyChar <> "+" Then
                    If e.KeyChar <> "-" Then
                        If e.KeyChar <> "*" Then
                            If e.KeyChar <> "/" Then
                                If e.KeyChar <> "." Then
                                    txtCalculator.ResetText()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


        'only allows numbers and operators to be entered into keyboard
        If Not Char.IsNumber(e.KeyChar) Then
            If e.KeyChar <> ControlChars.Back Then
                If e.KeyChar <> "+" Then
                    If e.KeyChar <> "-" Then
                        If e.KeyChar <> "*" Then
                            If e.KeyChar <> "/" Then
                                If e.KeyChar <> "." Then
                                    e.Handled = True
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        End If

        'allows enter button to act as equals button
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnEquals_Click(sender, e)
        End If

    End Sub
End Class
