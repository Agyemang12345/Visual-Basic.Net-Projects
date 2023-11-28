Public Class Form4
    Dim decDiscount As Decimal
    Dim decTotal As Decimal
    Dim intMonths As Integer
    Dim decBaseFee As Decimal
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radseniorcitizen.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkKarate.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radAdult.Checked = False
        radChild.Checked = False
        radseniorcitizen.Checked = False
        radStudent.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False
        chkYoga.Checked = False
        txtMonths.Text = String.Empty
        lblMonthlyFees.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult =
            MessageBox.Show("Do you wish to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Not Integer.TryParse(txtMonths.Text, intMonths) Then
            MessageBox.Show("Months must be a valid integer", "Input Error")
            Return
        End If
        If (intMonths < 1) Or (intMonths > 24) Then
            MessageBox.Show("Enter the value in th range of " & "1 - 24 for months.", "Input Error")
            Return
        End If
        If radAdult.Checked = True Then
            decBaseFee = 40
        ElseIf radChild.Checked = True Then
            decBaseFee = 20
        ElseIf radStudent.Checked = True Then
            decBaseFee = 25
        ElseIf radseniorcitizen.Checked = True Then
            decBaseFee = 30
        End If

        If chkYoga.Checked = True Then
            decBaseFee += 10
        End If
        If chkKarate.Checked = True Then
            decBaseFee += 30
        End If
        If chkTrainer.Checked = True Then
            decBaseFee += 50
        End If
        Select Case intMonths
            Case Is <= 3
                decDiscount = 0
        End Select

        decBaseFee -= decDiscount
        decTotal = decBaseFee * intMonths

        lblMonthlyFees.Text = decBaseFee.ToString("C")
        lblTotal.Text = decBaseFee.ToString("C")
    End Sub
End Class